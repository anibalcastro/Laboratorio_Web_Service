
namespace Presentacion
{
    partial class Clima
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clima));
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgMañana1 = new System.Windows.Forms.PictureBox();
            this.lblDia1 = new System.Windows.Forms.Label();
            this.txtDescripcionMañana = new System.Windows.Forms.TextBox();
            this.imgTarde1 = new System.Windows.Forms.PictureBox();
            this.txtComentarioTarde = new System.Windows.Forms.TextBox();
            this.lblTarde1 = new System.Windows.Forms.Label();
            this.txtComentarioNoche = new System.Windows.Forms.TextBox();
            this.lblNoche1 = new System.Windows.Forms.Label();
            this.imgNoche1 = new System.Windows.Forms.PictureBox();
            this.txtComentarioNoche1 = new System.Windows.Forms.TextBox();
            this.lblNoche2 = new System.Windows.Forms.Label();
            this.imgNoche2 = new System.Windows.Forms.PictureBox();
            this.txtComentarioTarde1 = new System.Windows.Forms.TextBox();
            this.lblTarde2 = new System.Windows.Forms.Label();
            this.imgTarde2 = new System.Windows.Forms.PictureBox();
            this.txtComentarioMañana1 = new System.Windows.Forms.TextBox();
            this.lblDia2 = new System.Windows.Forms.Label();
            this.imgMañana2 = new System.Windows.Forms.PictureBox();
            this.PanelLunar = new System.Windows.Forms.Panel();
            this.gbSol = new System.Windows.Forms.GroupBox();
            this.lblSaleSol = new System.Windows.Forms.Label();
            this.lblSePoneSol = new System.Windows.Forms.Label();
            this.gbFaseLunar = new System.Windows.Forms.GroupBox();
            this.lblFaseLunar = new System.Windows.Forms.Label();
            this.gbEfemerideLunar = new System.Windows.Forms.GroupBox();
            this.lblSaleLuna = new System.Windows.Forms.Label();
            this.lblSePoneLuna = new System.Windows.Forms.Label();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.lblMinima = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSol = new System.Windows.Forms.CheckBox();
            this.cbEfemeridadLuna = new System.Windows.Forms.CheckBox();
            this.cbFaseLunar = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMañana1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTarde1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoche1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoche2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTarde2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMañana2)).BeginInit();
            this.PanelLunar.SuspendLayout();
            this.gbSol.SuspendLayout();
            this.gbFaseLunar.SuspendLayout();
            this.gbEfemerideLunar.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // cbZona
            // 
            this.cbZona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Location = new System.Drawing.Point(53, 63);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(257, 21);
            this.cbZona.TabIndex = 0;
            this.cbZona.SelectedIndexChanged += new System.EventHandler(this.cbZona_SelectedIndexChanged);
            // 
            // cbCiudad
            // 
            this.cbCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(388, 63);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(257, 21);
            this.cbCiudad.TabIndex = 1;
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbCiudad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGIONAL:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(385, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CIUDAD:";
            // 
            // imgMañana1
            // 
            this.imgMañana1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgMañana1.Location = new System.Drawing.Point(54, 128);
            this.imgMañana1.Name = "imgMañana1";
            this.imgMañana1.Size = new System.Drawing.Size(99, 93);
            this.imgMañana1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMañana1.TabIndex = 4;
            this.imgMañana1.TabStop = false;
            // 
            // lblDia1
            // 
            this.lblDia1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDia1.AutoSize = true;
            this.lblDia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia1.ForeColor = System.Drawing.Color.White;
            this.lblDia1.Image = ((System.Drawing.Image)(resources.GetObject("lblDia1.Image")));
            this.lblDia1.Location = new System.Drawing.Point(158, 128);
            this.lblDia1.Name = "lblDia1";
            this.lblDia1.Size = new System.Drawing.Size(66, 16);
            this.lblDia1.TabIndex = 5;
            this.lblDia1.Text = "MAÑANA";
            // 
            // txtDescripcionMañana
            // 
            this.txtDescripcionMañana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescripcionMañana.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcionMañana.Enabled = false;
            this.txtDescripcionMañana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionMañana.Location = new System.Drawing.Point(159, 153);
            this.txtDescripcionMañana.Multiline = true;
            this.txtDescripcionMañana.Name = "txtDescripcionMañana";
            this.txtDescripcionMañana.Size = new System.Drawing.Size(190, 68);
            this.txtDescripcionMañana.TabIndex = 6;
            // 
            // imgTarde1
            // 
            this.imgTarde1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgTarde1.Location = new System.Drawing.Point(54, 299);
            this.imgTarde1.Name = "imgTarde1";
            this.imgTarde1.Size = new System.Drawing.Size(99, 93);
            this.imgTarde1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTarde1.TabIndex = 7;
            this.imgTarde1.TabStop = false;
            // 
            // txtComentarioTarde
            // 
            this.txtComentarioTarde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComentarioTarde.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtComentarioTarde.Enabled = false;
            this.txtComentarioTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioTarde.Location = new System.Drawing.Point(159, 324);
            this.txtComentarioTarde.Multiline = true;
            this.txtComentarioTarde.Name = "txtComentarioTarde";
            this.txtComentarioTarde.Size = new System.Drawing.Size(190, 68);
            this.txtComentarioTarde.TabIndex = 9;
            // 
            // lblTarde1
            // 
            this.lblTarde1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTarde1.AutoSize = true;
            this.lblTarde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarde1.ForeColor = System.Drawing.Color.White;
            this.lblTarde1.Image = ((System.Drawing.Image)(resources.GetObject("lblTarde1.Image")));
            this.lblTarde1.Location = new System.Drawing.Point(158, 299);
            this.lblTarde1.Name = "lblTarde1";
            this.lblTarde1.Size = new System.Drawing.Size(55, 16);
            this.lblTarde1.TabIndex = 8;
            this.lblTarde1.Text = "TARDE";
            // 
            // txtComentarioNoche
            // 
            this.txtComentarioNoche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComentarioNoche.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtComentarioNoche.Enabled = false;
            this.txtComentarioNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioNoche.Location = new System.Drawing.Point(159, 490);
            this.txtComentarioNoche.Multiline = true;
            this.txtComentarioNoche.Name = "txtComentarioNoche";
            this.txtComentarioNoche.Size = new System.Drawing.Size(190, 68);
            this.txtComentarioNoche.TabIndex = 12;
            // 
            // lblNoche1
            // 
            this.lblNoche1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoche1.AutoSize = true;
            this.lblNoche1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoche1.ForeColor = System.Drawing.Color.White;
            this.lblNoche1.Image = ((System.Drawing.Image)(resources.GetObject("lblNoche1.Image")));
            this.lblNoche1.Location = new System.Drawing.Point(158, 465);
            this.lblNoche1.Name = "lblNoche1";
            this.lblNoche1.Size = new System.Drawing.Size(56, 16);
            this.lblNoche1.TabIndex = 11;
            this.lblNoche1.Text = "NOCHE";
            // 
            // imgNoche1
            // 
            this.imgNoche1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgNoche1.Location = new System.Drawing.Point(54, 465);
            this.imgNoche1.Name = "imgNoche1";
            this.imgNoche1.Size = new System.Drawing.Size(99, 93);
            this.imgNoche1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNoche1.TabIndex = 10;
            this.imgNoche1.TabStop = false;
            // 
            // txtComentarioNoche1
            // 
            this.txtComentarioNoche1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentarioNoche1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtComentarioNoche1.Enabled = false;
            this.txtComentarioNoche1.Location = new System.Drawing.Point(494, 490);
            this.txtComentarioNoche1.Multiline = true;
            this.txtComentarioNoche1.Name = "txtComentarioNoche1";
            this.txtComentarioNoche1.Size = new System.Drawing.Size(190, 68);
            this.txtComentarioNoche1.TabIndex = 21;
            // 
            // lblNoche2
            // 
            this.lblNoche2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoche2.AutoSize = true;
            this.lblNoche2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoche2.ForeColor = System.Drawing.Color.White;
            this.lblNoche2.Image = ((System.Drawing.Image)(resources.GetObject("lblNoche2.Image")));
            this.lblNoche2.Location = new System.Drawing.Point(498, 471);
            this.lblNoche2.Name = "lblNoche2";
            this.lblNoche2.Size = new System.Drawing.Size(56, 16);
            this.lblNoche2.TabIndex = 20;
            this.lblNoche2.Text = "NOCHE";
            // 
            // imgNoche2
            // 
            this.imgNoche2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgNoche2.Location = new System.Drawing.Point(389, 465);
            this.imgNoche2.Name = "imgNoche2";
            this.imgNoche2.Size = new System.Drawing.Size(99, 93);
            this.imgNoche2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNoche2.TabIndex = 19;
            this.imgNoche2.TabStop = false;
            // 
            // txtComentarioTarde1
            // 
            this.txtComentarioTarde1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentarioTarde1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtComentarioTarde1.Enabled = false;
            this.txtComentarioTarde1.Location = new System.Drawing.Point(494, 324);
            this.txtComentarioTarde1.Multiline = true;
            this.txtComentarioTarde1.Name = "txtComentarioTarde1";
            this.txtComentarioTarde1.Size = new System.Drawing.Size(190, 68);
            this.txtComentarioTarde1.TabIndex = 18;
            // 
            // lblTarde2
            // 
            this.lblTarde2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTarde2.AutoSize = true;
            this.lblTarde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarde2.ForeColor = System.Drawing.Color.White;
            this.lblTarde2.Image = ((System.Drawing.Image)(resources.GetObject("lblTarde2.Image")));
            this.lblTarde2.Location = new System.Drawing.Point(497, 305);
            this.lblTarde2.Name = "lblTarde2";
            this.lblTarde2.Size = new System.Drawing.Size(55, 16);
            this.lblTarde2.TabIndex = 17;
            this.lblTarde2.Text = "TARDE";
            // 
            // imgTarde2
            // 
            this.imgTarde2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgTarde2.Location = new System.Drawing.Point(389, 299);
            this.imgTarde2.Name = "imgTarde2";
            this.imgTarde2.Size = new System.Drawing.Size(99, 93);
            this.imgTarde2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTarde2.TabIndex = 16;
            this.imgTarde2.TabStop = false;
            // 
            // txtComentarioMañana1
            // 
            this.txtComentarioMañana1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentarioMañana1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtComentarioMañana1.Enabled = false;
            this.txtComentarioMañana1.Location = new System.Drawing.Point(494, 153);
            this.txtComentarioMañana1.Multiline = true;
            this.txtComentarioMañana1.Name = "txtComentarioMañana1";
            this.txtComentarioMañana1.Size = new System.Drawing.Size(190, 68);
            this.txtComentarioMañana1.TabIndex = 15;
            // 
            // lblDia2
            // 
            this.lblDia2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDia2.AutoSize = true;
            this.lblDia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia2.ForeColor = System.Drawing.Color.White;
            this.lblDia2.Image = ((System.Drawing.Image)(resources.GetObject("lblDia2.Image")));
            this.lblDia2.Location = new System.Drawing.Point(498, 128);
            this.lblDia2.Name = "lblDia2";
            this.lblDia2.Size = new System.Drawing.Size(66, 16);
            this.lblDia2.TabIndex = 14;
            this.lblDia2.Text = "MAÑANA";
            // 
            // imgMañana2
            // 
            this.imgMañana2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMañana2.Location = new System.Drawing.Point(389, 128);
            this.imgMañana2.Name = "imgMañana2";
            this.imgMañana2.Size = new System.Drawing.Size(99, 93);
            this.imgMañana2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMañana2.TabIndex = 13;
            this.imgMañana2.TabStop = false;
            // 
            // PanelLunar
            // 
            this.PanelLunar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelLunar.Controls.Add(this.gbSol);
            this.PanelLunar.Controls.Add(this.gbFaseLunar);
            this.PanelLunar.Controls.Add(this.gbEfemerideLunar);
            this.PanelLunar.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelLunar.Location = new System.Drawing.Point(768, 0);
            this.PanelLunar.Name = "PanelLunar";
            this.PanelLunar.Size = new System.Drawing.Size(275, 731);
            this.PanelLunar.TabIndex = 25;
            // 
            // gbSol
            // 
            this.gbSol.Controls.Add(this.pictureBox3);
            this.gbSol.Controls.Add(this.pictureBox1);
            this.gbSol.Controls.Add(this.lblSaleSol);
            this.gbSol.Controls.Add(this.lblSePoneSol);
            this.gbSol.ForeColor = System.Drawing.Color.White;
            this.gbSol.Location = new System.Drawing.Point(34, 490);
            this.gbSol.Name = "gbSol";
            this.gbSol.Size = new System.Drawing.Size(200, 100);
            this.gbSol.TabIndex = 2;
            this.gbSol.TabStop = false;
            this.gbSol.Text = "Efemeride del Sol";
            this.gbSol.Visible = false;
            // 
            // lblSaleSol
            // 
            this.lblSaleSol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaleSol.AutoSize = true;
            this.lblSaleSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleSol.ForeColor = System.Drawing.Color.White;
            this.lblSaleSol.Location = new System.Drawing.Point(103, 31);
            this.lblSaleSol.Name = "lblSaleSol";
            this.lblSaleSol.Size = new System.Drawing.Size(0, 18);
            this.lblSaleSol.TabIndex = 36;
            // 
            // lblSePoneSol
            // 
            this.lblSePoneSol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSePoneSol.AutoSize = true;
            this.lblSePoneSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSePoneSol.ForeColor = System.Drawing.Color.White;
            this.lblSePoneSol.Location = new System.Drawing.Point(103, 70);
            this.lblSePoneSol.Name = "lblSePoneSol";
            this.lblSePoneSol.Size = new System.Drawing.Size(0, 18);
            this.lblSePoneSol.TabIndex = 35;
            // 
            // gbFaseLunar
            // 
            this.gbFaseLunar.Controls.Add(this.lblFaseLunar);
            this.gbFaseLunar.ForeColor = System.Drawing.Color.White;
            this.gbFaseLunar.Location = new System.Drawing.Point(34, 256);
            this.gbFaseLunar.Name = "gbFaseLunar";
            this.gbFaseLunar.Size = new System.Drawing.Size(200, 100);
            this.gbFaseLunar.TabIndex = 1;
            this.gbFaseLunar.TabStop = false;
            this.gbFaseLunar.Text = "Fase Lunar";
            this.gbFaseLunar.Visible = false;
            // 
            // lblFaseLunar
            // 
            this.lblFaseLunar.AutoSize = true;
            this.lblFaseLunar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaseLunar.Location = new System.Drawing.Point(6, 43);
            this.lblFaseLunar.Name = "lblFaseLunar";
            this.lblFaseLunar.Size = new System.Drawing.Size(0, 18);
            this.lblFaseLunar.TabIndex = 0;
            // 
            // gbEfemerideLunar
            // 
            this.gbEfemerideLunar.Controls.Add(this.pictureBox4);
            this.gbEfemerideLunar.Controls.Add(this.pictureBox5);
            this.gbEfemerideLunar.Controls.Add(this.lblSaleLuna);
            this.gbEfemerideLunar.Controls.Add(this.lblSePoneLuna);
            this.gbEfemerideLunar.ForeColor = System.Drawing.Color.White;
            this.gbEfemerideLunar.Location = new System.Drawing.Point(34, 39);
            this.gbEfemerideLunar.Name = "gbEfemerideLunar";
            this.gbEfemerideLunar.Size = new System.Drawing.Size(200, 100);
            this.gbEfemerideLunar.TabIndex = 0;
            this.gbEfemerideLunar.TabStop = false;
            this.gbEfemerideLunar.Text = "Efemeride Lunar";
            this.gbEfemerideLunar.Visible = false;
            // 
            // lblSaleLuna
            // 
            this.lblSaleLuna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaleLuna.AutoSize = true;
            this.lblSaleLuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleLuna.ForeColor = System.Drawing.Color.White;
            this.lblSaleLuna.Location = new System.Drawing.Point(103, 24);
            this.lblSaleLuna.Name = "lblSaleLuna";
            this.lblSaleLuna.Size = new System.Drawing.Size(0, 18);
            this.lblSaleLuna.TabIndex = 32;
            // 
            // lblSePoneLuna
            // 
            this.lblSePoneLuna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSePoneLuna.AutoSize = true;
            this.lblSePoneLuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSePoneLuna.ForeColor = System.Drawing.Color.White;
            this.lblSePoneLuna.Location = new System.Drawing.Point(103, 63);
            this.lblSePoneLuna.Name = "lblSePoneLuna";
            this.lblSePoneLuna.Size = new System.Drawing.Size(0, 18);
            this.lblSePoneLuna.TabIndex = 31;
            // 
            // PanelInfo
            // 
            this.PanelInfo.Controls.Add(this.lblMaxima);
            this.PanelInfo.Controls.Add(this.lblMinima);
            this.PanelInfo.Controls.Add(this.label5);
            this.PanelInfo.Controls.Add(this.label4);
            this.PanelInfo.Controls.Add(this.cbSol);
            this.PanelInfo.Controls.Add(this.cbEfemeridadLuna);
            this.PanelInfo.Controls.Add(this.cbFaseLunar);
            this.PanelInfo.Controls.Add(this.btnSalir);
            this.PanelInfo.Controls.Add(this.lblTarde2);
            this.PanelInfo.Controls.Add(this.label1);
            this.PanelInfo.Controls.Add(this.cbZona);
            this.PanelInfo.Controls.Add(this.label2);
            this.PanelInfo.Controls.Add(this.cbCiudad);
            this.PanelInfo.Controls.Add(this.pictureBox2);
            this.PanelInfo.Location = new System.Drawing.Point(1, 0);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(761, 731);
            this.PanelInfo.TabIndex = 26;
            // 
            // lblMaxima
            // 
            this.lblMaxima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxima.ForeColor = System.Drawing.Color.White;
            this.lblMaxima.Image = ((System.Drawing.Image)(resources.GetObject("lblMaxima.Image")));
            this.lblMaxima.Location = new System.Drawing.Point(557, 631);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(0, 18);
            this.lblMaxima.TabIndex = 30;
            // 
            // lblMinima
            // 
            this.lblMinima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinima.AutoSize = true;
            this.lblMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinima.ForeColor = System.Drawing.Color.White;
            this.lblMinima.Image = ((System.Drawing.Image)(resources.GetObject("lblMinima.Image")));
            this.lblMinima.Location = new System.Drawing.Point(557, 593);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(0, 18);
            this.lblMinima.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(385, 631);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "TEMPERATURA MÁXIMA";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(386, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "TEMPERATURA MINIMA:";
            // 
            // cbSol
            // 
            this.cbSol.AutoSize = true;
            this.cbSol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbSol.BackgroundImage")));
            this.cbSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSol.ForeColor = System.Drawing.Color.White;
            this.cbSol.Location = new System.Drawing.Point(60, 655);
            this.cbSol.Name = "cbSol";
            this.cbSol.Size = new System.Drawing.Size(144, 20);
            this.cbSol.TabIndex = 26;
            this.cbSol.Text = "Ver Efemeridad Sol";
            this.cbSol.UseVisualStyleBackColor = true;
            this.cbSol.CheckedChanged += new System.EventHandler(this.cbSol_CheckedChanged);
            // 
            // cbEfemeridadLuna
            // 
            this.cbEfemeridadLuna.AutoSize = true;
            this.cbEfemeridadLuna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbEfemeridadLuna.BackgroundImage")));
            this.cbEfemeridadLuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEfemeridadLuna.ForeColor = System.Drawing.Color.White;
            this.cbEfemeridadLuna.Location = new System.Drawing.Point(60, 632);
            this.cbEfemeridadLuna.Name = "cbEfemeridadLuna";
            this.cbEfemeridadLuna.Size = new System.Drawing.Size(157, 20);
            this.cbEfemeridadLuna.TabIndex = 25;
            this.cbEfemeridadLuna.Text = "Ver Efermeridad Luna";
            this.cbEfemeridadLuna.UseVisualStyleBackColor = true;
            this.cbEfemeridadLuna.CheckedChanged += new System.EventHandler(this.cbEfemeridadLuna_CheckedChanged);
            // 
            // cbFaseLunar
            // 
            this.cbFaseLunar.AutoSize = true;
            this.cbFaseLunar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbFaseLunar.BackgroundImage")));
            this.cbFaseLunar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFaseLunar.ForeColor = System.Drawing.Color.White;
            this.cbFaseLunar.Location = new System.Drawing.Point(60, 609);
            this.cbFaseLunar.Name = "cbFaseLunar";
            this.cbFaseLunar.Size = new System.Drawing.Size(118, 20);
            this.cbFaseLunar.TabIndex = 24;
            this.cbFaseLunar.Text = "Ver Fase Lunar";
            this.cbFaseLunar.UseVisualStyleBackColor = true;
            this.cbFaseLunar.CheckedChanged += new System.EventHandler(this.cbFaseLunar_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(533, 678);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(215, 41);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(755, 728);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(39, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(39, 56);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // Clima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 731);
            this.Controls.Add(this.txtComentarioNoche1);
            this.Controls.Add(this.lblNoche2);
            this.Controls.Add(this.imgNoche2);
            this.Controls.Add(this.txtComentarioTarde1);
            this.Controls.Add(this.imgTarde2);
            this.Controls.Add(this.txtComentarioMañana1);
            this.Controls.Add(this.lblDia2);
            this.Controls.Add(this.imgMañana2);
            this.Controls.Add(this.txtComentarioNoche);
            this.Controls.Add(this.lblNoche1);
            this.Controls.Add(this.imgNoche1);
            this.Controls.Add(this.txtComentarioTarde);
            this.Controls.Add(this.lblTarde1);
            this.Controls.Add(this.imgTarde1);
            this.Controls.Add(this.txtDescripcionMañana);
            this.Controls.Add(this.lblDia1);
            this.Controls.Add(this.imgMañana1);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.PanelLunar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clima";
            this.Text = "CLIMA";
            ((System.ComponentModel.ISupportInitialize)(this.imgMañana1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTarde1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoche1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoche2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTarde2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMañana2)).EndInit();
            this.PanelLunar.ResumeLayout(false);
            this.gbSol.ResumeLayout(false);
            this.gbSol.PerformLayout();
            this.gbFaseLunar.ResumeLayout(false);
            this.gbFaseLunar.PerformLayout();
            this.gbEfemerideLunar.ResumeLayout(false);
            this.gbEfemerideLunar.PerformLayout();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgMañana1;
        private System.Windows.Forms.Label lblDia1;
        private System.Windows.Forms.TextBox txtDescripcionMañana;
        private System.Windows.Forms.PictureBox imgTarde1;
        private System.Windows.Forms.TextBox txtComentarioTarde;
        private System.Windows.Forms.Label lblTarde1;
        private System.Windows.Forms.TextBox txtComentarioNoche;
        private System.Windows.Forms.Label lblNoche1;
        private System.Windows.Forms.PictureBox imgNoche1;
        private System.Windows.Forms.TextBox txtComentarioNoche1;
        private System.Windows.Forms.Label lblNoche2;
        private System.Windows.Forms.PictureBox imgNoche2;
        private System.Windows.Forms.TextBox txtComentarioTarde1;
        private System.Windows.Forms.Label lblTarde2;
        private System.Windows.Forms.PictureBox imgTarde2;
        private System.Windows.Forms.TextBox txtComentarioMañana1;
        private System.Windows.Forms.Label lblDia2;
        private System.Windows.Forms.PictureBox imgMañana2;
        private System.Windows.Forms.Panel PanelLunar;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox cbSol;
        private System.Windows.Forms.CheckBox cbEfemeridadLuna;
        private System.Windows.Forms.CheckBox cbFaseLunar;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.Label lblMinima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSol;
        private System.Windows.Forms.GroupBox gbFaseLunar;
        private System.Windows.Forms.GroupBox gbEfemerideLunar;
        private System.Windows.Forms.Label lblSaleSol;
        private System.Windows.Forms.Label lblSePoneSol;
        private System.Windows.Forms.Label lblFaseLunar;
        private System.Windows.Forms.Label lblSaleLuna;
        private System.Windows.Forms.Label lblSePoneLuna;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

