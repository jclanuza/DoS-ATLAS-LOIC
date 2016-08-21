namespace LOIC
{
	partial class atlaspanel
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(atlaspanel));
            this.label2 = new System.Windows.Forms.Label();
            this.cmdTargetIP = new System.Windows.Forms.Button();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdTargetURL = new System.Windows.Forms.Button();
            this.txtTargetURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkResp = new System.Windows.Forms.CheckBox();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubsite = new System.Windows.Forms.TextBox();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdAttack = new System.Windows.Forms.Button();
            this.lbFailed = new System.Windows.Forms.Label();
            this.lbRequested = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbDownloaded = new System.Windows.Forms.Label();
            this.lbRequesting = new System.Windows.Forms.Label();
            this.lbConnecting = new System.Windows.Forms.Label();
            this.lbIdle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbDownloading = new System.Windows.Forms.Label();
            this.TTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.tShowStats = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "IPv4:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdTargetIP
            // 
            this.cmdTargetIP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdTargetIP.ForeColor = System.Drawing.Color.Black;
            this.cmdTargetIP.Location = new System.Drawing.Point(165, 188);
            this.cmdTargetIP.Name = "cmdTargetIP";
            this.cmdTargetIP.Size = new System.Drawing.Size(71, 30);
            this.cmdTargetIP.TabIndex = 4;
            this.cmdTargetIP.Text = "Preparar IP";
            this.cmdTargetIP.UseVisualStyleBackColor = false;
            this.cmdTargetIP.Click += new System.EventHandler(this.cmdTargetIP_Click);
            // 
            // txtTargetIP
            // 
            this.txtTargetIP.BackColor = System.Drawing.Color.White;
            this.txtTargetIP.ForeColor = System.Drawing.Color.Black;
            this.txtTargetIP.Location = new System.Drawing.Point(68, 108);
            this.txtTargetIP.Name = "txtTargetIP";
            this.txtTargetIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTargetIP.Size = new System.Drawing.Size(149, 20);
            this.txtTargetIP.TabIndex = 3;
            this.TTip.SetToolTip(this.txtTargetIP, "IP para atacar, si la tienes simplemente dale en \"Preparar IP\"");
            this.txtTargetIP.TextChanged += new System.EventHandler(this.txtTargetIP_TextChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdTargetURL
            // 
            this.cmdTargetURL.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdTargetURL.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cmdTargetURL.ForeColor = System.Drawing.Color.Black;
            this.cmdTargetURL.Location = new System.Drawing.Point(165, 153);
            this.cmdTargetURL.Name = "cmdTargetURL";
            this.cmdTargetURL.Size = new System.Drawing.Size(71, 26);
            this.cmdTargetURL.TabIndex = 2;
            this.cmdTargetURL.Text = "DNS ";
            this.TTip.SetToolTip(this.cmdTargetURL, "Si no sabes la IP de un sitio o eres un n00b simplemente haz\r\nClick para hacer un" +
        "a consula DNS la cual te proporciona la IP de una URL");
            this.cmdTargetURL.UseVisualStyleBackColor = false;
            this.cmdTargetURL.Click += new System.EventHandler(this.cmdTargetURL_Click);
            // 
            // txtTargetURL
            // 
            this.txtTargetURL.BackColor = System.Drawing.Color.White;
            this.txtTargetURL.ForeColor = System.Drawing.Color.Black;
            this.txtTargetURL.Location = new System.Drawing.Point(68, 17);
            this.txtTargetURL.Name = "txtTargetURL";
            this.txtTargetURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTargetURL.Size = new System.Drawing.Size(149, 20);
            this.txtTargetURL.TabIndex = 1;
            this.TTip.SetToolTip(this.txtTargetURL, "URL de la pagina a atacar: Ejemplo: www.google.com");
            this.txtTargetURL.TextChanged += new System.EventHandler(this.txtTargetURL_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(212, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(212, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 23);
            this.label3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-6, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "AVS:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Protocolo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkResp
            // 
            this.chkResp.AutoSize = true;
            this.chkResp.Checked = true;
            this.chkResp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResp.Location = new System.Drawing.Point(165, 236);
            this.chkResp.Name = "chkResp";
            this.chkResp.Size = new System.Drawing.Size(68, 21);
            this.chkResp.TabIndex = 7;
            this.chkResp.Text = "DDAS";
            this.TTip.SetToolTip(this.chkResp, "Desconectar Durante ataques simultaneos");
            this.chkResp.UseVisualStyleBackColor = true;
            this.chkResp.CheckedChanged += new System.EventHandler(this.chkResp_CheckedChanged);
            // 
            // txtThreads
            // 
            this.txtThreads.BackColor = System.Drawing.Color.White;
            this.txtThreads.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThreads.ForeColor = System.Drawing.Color.Black;
            this.txtThreads.Location = new System.Drawing.Point(81, 213);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThreads.Size = new System.Drawing.Size(61, 20);
            this.txtThreads.TabIndex = 6;
            this.txtThreads.Text = "1";
            this.txtThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtThreads, "AVS (Ataques Virtuales Simultaneos) - Esto especifica cuantos ataques simultaneos" +
        " se ejecutaran durante un ataque.\r\n\r\nLa Seleccion muy alta de numero de AVS prob" +
        "oca inestabilidad en el Sistema");
            // 
            // cbMethod
            // 
            this.cbMethod.BackColor = System.Drawing.Color.White;
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMethod.ForeColor = System.Drawing.Color.Black;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "HTTP"});
            this.cbMethod.Location = new System.Drawing.Point(81, 180);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(53, 22);
            this.cbMethod.TabIndex = 5;
            this.TTip.SetToolTip(this.cbMethod, "Que tipo de ataque quieres lanzar");
            // 
            // tbSpeed
            // 
            this.tbSpeed.AllowDrop = true;
            this.tbSpeed.BackColor = System.Drawing.Color.White;
            this.tbSpeed.Location = new System.Drawing.Point(15, 20);
            this.tbSpeed.Maximum = 20;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSpeed.Size = new System.Drawing.Size(45, 316);
            this.tbSpeed.TabIndex = 8;
            this.TTip.SetToolTip(this.tbSpeed, "Nivel de Intencidad");
            this.tbSpeed.Value = 20;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(-6, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 48);
            this.label17.TabIndex = 24;
            this.label17.Text = "Subsitios\r\n HTTP :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Puerto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSubsite
            // 
            this.txtSubsite.BackColor = System.Drawing.Color.White;
            this.txtSubsite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubsite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSubsite.Location = new System.Drawing.Point(68, 63);
            this.txtSubsite.Name = "txtSubsite";
            this.txtSubsite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSubsite.Size = new System.Drawing.Size(149, 20);
            this.txtSubsite.TabIndex = 2;
            this.txtSubsite.Text = "/";
            this.txtSubsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtSubsite, "What subsite to target (when using HTTP as type)");
            // 
            // txtTimeout
            // 
            this.txtTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTimeout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeout.ForeColor = System.Drawing.Color.Black;
            this.txtTimeout.Location = new System.Drawing.Point(30, 19);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(50, 13);
            this.txtTimeout.TabIndex = 1;
            this.txtTimeout.Text = "10000";
            this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtTimeout, "Tiempo Maximo de espera para Recivir una respuesta");
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.White;
            this.txtPort.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.Black;
            this.txtPort.Location = new System.Drawing.Point(81, 150);
            this.txtPort.Name = "txtPort";
            this.txtPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPort.Size = new System.Drawing.Size(53, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "80";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtPort, "Puerto al cual se va a atacar.\r\n\r\nHTTP = 80\r\nHTTPS = 443\r\nFTP = 21\r\nSSH = 22\r\nTEL" +
        "NET =23");
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(683, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 23);
            this.label10.TabIndex = 9;
            // 
            // cmdAttack
            // 
            this.cmdAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.cmdAttack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAttack.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAttack.ForeColor = System.Drawing.Color.Azure;
            this.cmdAttack.Location = new System.Drawing.Point(15, 468);
            this.cmdAttack.Name = "cmdAttack";
            this.cmdAttack.Size = new System.Drawing.Size(356, 82);
            this.cmdAttack.TabIndex = 1;
            this.cmdAttack.Text = "Iniciar Flooding";
            this.TTip.SetToolTip(this.cmdAttack, "Preparence para el Bombardeo.... Brotherrsss");
            this.cmdAttack.UseVisualStyleBackColor = false;
            this.cmdAttack.Click += new System.EventHandler(this.cmdAttack_Click);
            // 
            // lbFailed
            // 
            this.lbFailed.BackColor = System.Drawing.Color.White;
            this.lbFailed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFailed.Cursor = System.Windows.Forms.Cursors.No;
            this.lbFailed.Enabled = false;
            this.lbFailed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbFailed.ForeColor = System.Drawing.Color.Black;
            this.lbFailed.Location = new System.Drawing.Point(17, 454);
            this.lbFailed.Name = "lbFailed";
            this.lbFailed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFailed.Size = new System.Drawing.Size(101, 24);
            this.lbFailed.TabIndex = 24;
            this.lbFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbFailed, "Cuantas veces el Servidor no Responde.\r\n\r\n\r\nUn Numero muy alto significa que el s" +
        "ervidor esta caido.\r\nUn Numero muy alto significa que posiblemente un IDS/Firewa" +
        "ll te este bloqueando el ataque.");
            // 
            // lbRequested
            // 
            this.lbRequested.BackColor = System.Drawing.Color.White;
            this.lbRequested.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRequested.Cursor = System.Windows.Forms.Cursors.No;
            this.lbRequested.Enabled = false;
            this.lbRequested.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbRequested.ForeColor = System.Drawing.Color.Black;
            this.lbRequested.Location = new System.Drawing.Point(17, 402);
            this.lbRequested.Name = "lbRequested";
            this.lbRequested.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRequested.Size = new System.Drawing.Size(101, 24);
            this.lbRequested.TabIndex = 23;
            this.lbRequested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbRequested, "Cuantas veces se a pedido que se descarge una pagina HTTP");
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(17, 435);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 24);
            this.label22.TabIndex = 22;
            this.label22.Text = "Error ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(17, 378);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 24);
            this.label23.TabIndex = 21;
            this.label23.Text = "Peticiones";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDownloaded
            // 
            this.lbDownloaded.BackColor = System.Drawing.Color.White;
            this.lbDownloaded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDownloaded.Cursor = System.Windows.Forms.Cursors.No;
            this.lbDownloaded.Enabled = false;
            this.lbDownloaded.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbDownloaded.ForeColor = System.Drawing.Color.Black;
            this.lbDownloaded.Location = new System.Drawing.Point(20, 334);
            this.lbDownloaded.Name = "lbDownloaded";
            this.lbDownloaded.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDownloaded.Size = new System.Drawing.Size(101, 24);
            this.lbDownloaded.TabIndex = 20;
            this.lbDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbDownloaded, "Cuantas veces se a descargado una pagina en TOTAL");
            this.lbDownloaded.Click += new System.EventHandler(this.lbDownloaded_Click);
            // 
            // lbRequesting
            // 
            this.lbRequesting.BackColor = System.Drawing.Color.White;
            this.lbRequesting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRequesting.Cursor = System.Windows.Forms.Cursors.No;
            this.lbRequesting.Enabled = false;
            this.lbRequesting.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbRequesting.ForeColor = System.Drawing.Color.Black;
            this.lbRequesting.Location = new System.Drawing.Point(17, 189);
            this.lbRequesting.Name = "lbRequesting";
            this.lbRequesting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRequesting.Size = new System.Drawing.Size(101, 24);
            this.lbRequesting.TabIndex = 18;
            this.lbRequesting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbRequesting, "AVS´s Tratando de Solicitar Información al Servidor");
            this.lbRequesting.Click += new System.EventHandler(this.lbRequesting_Click);
            // 
            // lbConnecting
            // 
            this.lbConnecting.BackColor = System.Drawing.Color.White;
            this.lbConnecting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbConnecting.Cursor = System.Windows.Forms.Cursors.No;
            this.lbConnecting.Enabled = false;
            this.lbConnecting.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbConnecting.ForeColor = System.Drawing.Color.Black;
            this.lbConnecting.Location = new System.Drawing.Point(17, 118);
            this.lbConnecting.Name = "lbConnecting";
            this.lbConnecting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbConnecting.Size = new System.Drawing.Size(101, 24);
            this.lbConnecting.TabIndex = 17;
            this.lbConnecting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbConnecting, "AVS´s Tratando de Conectarse");
            this.lbConnecting.Click += new System.EventHandler(this.lbConnecting_Click);
            // 
            // lbIdle
            // 
            this.lbIdle.BackColor = System.Drawing.Color.White;
            this.lbIdle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdle.Cursor = System.Windows.Forms.Cursors.No;
            this.lbIdle.Enabled = false;
            this.lbIdle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbIdle.ForeColor = System.Drawing.Color.Black;
            this.lbIdle.Location = new System.Drawing.Point(17, 43);
            this.lbIdle.Name = "lbIdle";
            this.lbIdle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbIdle.Size = new System.Drawing.Size(101, 24);
            this.lbIdle.TabIndex = 16;
            this.lbIdle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbIdle, "AVS´s Trabajando , aveces suele estar en 0");
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(17, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 36);
            this.label12.TabIndex = 15;
            this.label12.Text = "Descargado - Exitoso";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(17, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "Descargando";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(17, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 13;
            this.label14.Text = "Solicitando";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(17, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Conexiones ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(20, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 24);
            this.label16.TabIndex = 11;
            this.label16.Text = "AVS´s Trabajando";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDownloading
            // 
            this.lbDownloading.BackColor = System.Drawing.Color.White;
            this.lbDownloading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDownloading.Cursor = System.Windows.Forms.Cursors.No;
            this.lbDownloading.Enabled = false;
            this.lbDownloading.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbDownloading.ForeColor = System.Drawing.Color.Black;
            this.lbDownloading.Location = new System.Drawing.Point(17, 260);
            this.lbDownloading.Name = "lbDownloading";
            this.lbDownloading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDownloading.Size = new System.Drawing.Size(101, 24);
            this.lbDownloading.TabIndex = 19;
            this.lbDownloading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTip.SetToolTip(this.lbDownloading, "Numero de Veces que se a repetido el paso de descargar una WEB Site si es usado e" +
        "l metodo HTTP en el 80");
            // 
            // txtTarget
            // 
            this.txtTarget.BackColor = System.Drawing.Color.Black;
            this.txtTarget.Enabled = false;
            this.txtTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.ForeColor = System.Drawing.Color.Lime;
            this.txtTarget.Location = new System.Drawing.Point(6, 13);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTarget.Size = new System.Drawing.Size(356, 40);
            this.txtTarget.TabIndex = 1;
            this.txtTarget.TabStop = false;
            this.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtTarget, "Objetivo Seleccionado para Ataque :)");
            this.txtTarget.TextChanged += new System.EventHandler(this.txtTarget_TextChanged);
            this.txtTarget.Enter += new System.EventHandler(this.txtTarget_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(165, 266);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 21);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "HFR";
            this.TTip.SetToolTip(this.checkBox1, "Habilitar Fragmentacion Random (Habilita que siertos paquetes se fragmenten)");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.DarkRed;
            this.txtData.Location = new System.Drawing.Point(9, 370);
            this.txtData.Name = "txtData";
            this.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtData.Size = new System.Drawing.Size(362, 20);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "ATLAS - XSA";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtData, "The data to send in TCP/UDP mode");
            // 
            // tShowStats
            // 
            this.tShowStats.Interval = 10;
            this.tShowStats.Tick += new System.EventHandler(this.tShowStats_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(593, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "Estado:  |";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "Información";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.informacionToolStripMenuItem.Text = "Acerca de ..";
            this.informacionToolStripMenuItem.Click += new System.EventHandler(this.informacionToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdAttack);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSubsite);
            this.groupBox1.Controls.Add(this.chkResp);
            this.groupBox1.Controls.Add(this.cmdTargetIP);
            this.groupBox1.Controls.Add(this.cmdTargetURL);
            this.groupBox1.Controls.Add(this.txtTargetIP);
            this.groupBox1.Controls.Add(this.txtTargetURL);
            this.groupBox1.Controls.Add(this.txtThreads);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.cbMethod);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 556);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos y Opciones de Ataque";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTarget);
            this.groupBox4.Location = new System.Drawing.Point(9, 398);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 64);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IP Objetivo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbSpeed);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(242, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 345);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Intensidad";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(76, 272);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 28);
            this.label25.TabIndex = 15;
            this.label25.Text = "DoS \r\nControlado";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(76, 236);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 14);
            this.label24.TabIndex = 14;
            this.label24.Text = "VER";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(78, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 14);
            this.label21.TabIndex = 13;
            this.label21.Text = "VR";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(79, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 14);
            this.label20.TabIndex = 12;
            this.label20.Text = "VM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 14);
            this.label11.TabIndex = 11;
            this.label11.Text = "VL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "VEL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Flood";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimeout);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(26, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 49);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempo de Espera";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 330);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 37);
            this.label18.TabIndex = 25;
            this.label18.Text = "Mensaje que contiene cada paquete";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.lbConnecting);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.lbFailed);
            this.groupBox5.Controls.Add(this.lbIdle);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.lbRequesting);
            this.groupBox5.Controls.Add(this.lbRequested);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lbDownloading);
            this.groupBox5.Controls.Add(this.lbDownloaded);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(423, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(150, 490);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estado";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(463, 517);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 45);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // atlaspanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 593);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "atlaspanel";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATLASTOOL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button cmdTargetURL;
		private System.Windows.Forms.TextBox txtTargetURL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdTargetIP;
		private System.Windows.Forms.TextBox txtTargetIP;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtThreads;
		private System.Windows.Forms.ComboBox cbMethod;
		private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdAttack;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label lbDownloaded;
		private System.Windows.Forms.Label lbDownloading;
		private System.Windows.Forms.Label lbRequesting;
		private System.Windows.Forms.Label lbConnecting;
		private System.Windows.Forms.Label lbIdle;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lbFailed;
		private System.Windows.Forms.Label lbRequested;
		private System.Windows.Forms.TextBox txtSubsite;
        private System.Windows.Forms.ToolTip TTip;
        private System.Windows.Forms.Timer tShowStats;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkResp;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
    }
}

