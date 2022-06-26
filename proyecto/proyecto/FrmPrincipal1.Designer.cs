using System;
using System.ComponentModel;
using Microsoft.Win32;

namespace proyecto
{
    partial class FrmPrincipal1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mstMenuSuperior = new System.Windows.Forms.MenuStrip();
            this.tsmIncio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBiblioteca = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSolicitudes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSolocitarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabEventos = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadAsistentesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idImagenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bINAESDataSet2 = new proyecto.BINAESDataSet2();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tabDeleteEvent = new System.Windows.Forms.TabPage();
            this.tabSolicitarEvento = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.tabEditEvent = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.checkBox33 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.checkBox34 = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.checkBox35 = new System.Windows.Forms.CheckBox();
            this.checkBox36 = new System.Windows.Forms.CheckBox();
            this.checkBox37 = new System.Windows.Forms.CheckBox();
            this.checkBox38 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabBiblioteca1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idautorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idetiquetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ididiomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idformatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpalabraclaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ideditorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcoleccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eJEMPLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bINAESDataSet1 = new proyecto.BINAESDataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tablisitEvent = new System.Windows.Forms.TabPage();
            this.tabAddUser = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtOcupación = new System.Windows.Forms.TextBox();
            this.txtInstitución = new System.Windows.Forms.TextBox();
            this.btnAddUserToBD = new System.Windows.Forms.Button();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.codigito = new System.Windows.Forms.PictureBox();
            this.QR = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPrestamoLibro = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.eJEMPLARTableAdapter = new proyecto.BINAESDataSet1TableAdapters.EJEMPLARTableAdapter();
            this.editorialTableAdapter1 = new proyecto.BINAESDataSetTableAdapters.EDITORIALTableAdapter();
            this.eVENTOTableAdapter = new proyecto.BINAESDataSet2TableAdapters.EVENTOTableAdapter();
            this.InformaciónBinaes = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.ConnectInfo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.mstMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.tabInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bINAESDataSet2)).BeginInit();
            this.tabSolicitarEvento.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabEditEvent.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.tabBiblioteca1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJEMPLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bINAESDataSet1)).BeginInit();
            this.tabAddUser.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPrestamoLibro.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.InformaciónBinaes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mstMenuSuperior, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabPrincipal, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 612F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 681);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mstMenuSuperior
            // 
            this.mstMenuSuperior.BackColor = System.Drawing.Color.OldLace;
            this.mstMenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIncio,
            this.tsmEventos,
            this.tsmBiblioteca,
            this.tsmSolicitudes,
            this.tsmAddUser});
            this.mstMenuSuperior.Location = new System.Drawing.Point(0, 43);
            this.mstMenuSuperior.Name = "mstMenuSuperior";
            this.mstMenuSuperior.Size = new System.Drawing.Size(1018, 24);
            this.mstMenuSuperior.TabIndex = 1;
            this.mstMenuSuperior.Text = "menuStrip1";
            // 
            // tsmIncio
            // 
            this.tsmIncio.BackColor = System.Drawing.Color.MistyRose;
            this.tsmIncio.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmIncio.Name = "tsmIncio";
            this.tsmIncio.Size = new System.Drawing.Size(48, 20);
            this.tsmIncio.Text = "Inicio";
            this.tsmIncio.Click += new System.EventHandler(this.btnConnectInicio_Click);
            // 
            // tsmEventos
            // 
            this.tsmEventos.BackColor = System.Drawing.Color.MistyRose;
            this.tsmEventos.Name = "tsmEventos";
            this.tsmEventos.Size = new System.Drawing.Size(60, 20);
            this.tsmEventos.Text = "Eventos";
            this.tsmEventos.Click += new System.EventHandler(this.btnConnectEvent_Click);
            // 
            // tsmBiblioteca
            // 
            this.tsmBiblioteca.BackColor = System.Drawing.Color.MistyRose;
            this.tsmBiblioteca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoDeLibrosToolStripMenuItem});
            this.tsmBiblioteca.Name = "tsmBiblioteca";
            this.tsmBiblioteca.Size = new System.Drawing.Size(71, 20);
            this.tsmBiblioteca.Text = "Biblioteca";
            this.tsmBiblioteca.Click += new System.EventHandler(this.btnConnectBibliotec_Click);
            // 
            // prestamoDeLibrosToolStripMenuItem
            // 
            this.prestamoDeLibrosToolStripMenuItem.Name = "prestamoDeLibrosToolStripMenuItem";
            this.prestamoDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.prestamoDeLibrosToolStripMenuItem.Text = "Prestamo de Libros";
            this.prestamoDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.btnPrestarLibros_Click);
            // 
            // tsmSolicitudes
            // 
            this.tsmSolicitudes.BackColor = System.Drawing.Color.MistyRose;
            this.tsmSolicitudes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSolocitarEvento,
            this.btnEditarEvento,
            this.btnEliminarEvento,
            this.btnListarEvento});
            this.tsmSolicitudes.Name = "tsmSolicitudes";
            this.tsmSolicitudes.Size = new System.Drawing.Size(76, 20);
            this.tsmSolicitudes.Text = "Solicitudes";
            // 
            // btnSolocitarEvento
            // 
            this.btnSolocitarEvento.Name = "btnSolocitarEvento";
            this.btnSolocitarEvento.Size = new System.Drawing.Size(156, 22);
            this.btnSolocitarEvento.Text = "Solicitar Evento";
            this.btnSolocitarEvento.Click += new System.EventHandler(this.btnSolocitarEvento_Click);
            // 
            // btnEditarEvento
            // 
            this.btnEditarEvento.Name = "btnEditarEvento";
            this.btnEditarEvento.Size = new System.Drawing.Size(156, 22);
            this.btnEditarEvento.Text = "Editar Evento";
            this.btnEditarEvento.Click += new System.EventHandler(this.btnEditarEvento_Click);
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(156, 22);
            this.btnEliminarEvento.Text = "Eliminar Evento";
            this.btnEliminarEvento.Click += new System.EventHandler(this.btnEliminarEvento_Click);
            // 
            // btnListarEvento
            // 
            this.btnListarEvento.Name = "btnListarEvento";
            this.btnListarEvento.Size = new System.Drawing.Size(156, 22);
            this.btnListarEvento.Text = "Listar Evento";
            this.btnListarEvento.Click += new System.EventHandler(this.btnListarEvento_Click);
            // 
            // tsmAddUser
            // 
            this.tsmAddUser.BackColor = System.Drawing.Color.MistyRose;
            this.tsmAddUser.Name = "tsmAddUser";
            this.tsmAddUser.Size = new System.Drawing.Size(104, 20);
            this.tsmAddUser.Text = "Agregar Usuario";
            this.tsmAddUser.Click += new System.EventHandler(this.btnConnetAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1012, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPrincipal.Controls.Add(this.tabInicio);
            this.tabPrincipal.Controls.Add(this.tabEventos);
            this.tabPrincipal.Controls.Add(this.tabDeleteEvent);
            this.tabPrincipal.Controls.Add(this.tabSolicitarEvento);
            this.tabPrincipal.Controls.Add(this.tabEditEvent);
            this.tabPrincipal.Controls.Add(this.tabBiblioteca1);
            this.tabPrincipal.Controls.Add(this.tablisitEvent);
            this.tabPrincipal.Controls.Add(this.tabAddUser);
            this.tabPrincipal.Controls.Add(this.tabPrestamoLibro);
            this.tabPrincipal.Controls.Add(this.InformaciónBinaes);
            this.tabPrincipal.ItemSize = new System.Drawing.Size(80, 20);
            this.tabPrincipal.Location = new System.Drawing.Point(3, 72);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1012, 606);
            this.tabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.TabStop = false;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.ConnectInfo);
            this.tabInicio.Controls.Add(this.pictureBox3);
            this.tabInicio.Location = new System.Drawing.Point(4, 24);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(1004, 578);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1016, 580);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.dataGridView2);
            this.tabEventos.Controls.Add(this.comboBox2);
            this.tabEventos.Controls.Add(this.textBox24);
            this.tabEventos.Controls.Add(this.label39);
            this.tabEventos.Location = new System.Drawing.Point(4, 24);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Padding = new System.Windows.Forms.Padding(3);
            this.tabEventos.Size = new System.Drawing.Size(1004, 578);
            this.tabEventos.TabIndex = 1;
            this.tabEventos.Text = "Eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tituloDataGridViewTextBoxColumn,
            this.objetivosDataGridViewTextBoxColumn,
            this.cantidadAsistentesDataGridViewTextBoxColumn,
            this.idAreaDataGridViewTextBoxColumn,
            this.idImagenesDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.eVENTOBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1007, 545);
            this.dataGridView2.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // objetivosDataGridViewTextBoxColumn
            // 
            this.objetivosDataGridViewTextBoxColumn.DataPropertyName = "Objetivos";
            this.objetivosDataGridViewTextBoxColumn.HeaderText = "Objetivos";
            this.objetivosDataGridViewTextBoxColumn.Name = "objetivosDataGridViewTextBoxColumn";
            // 
            // cantidadAsistentesDataGridViewTextBoxColumn
            // 
            this.cantidadAsistentesDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Asistentes";
            this.cantidadAsistentesDataGridViewTextBoxColumn.HeaderText = "Cantidad_Asistentes";
            this.cantidadAsistentesDataGridViewTextBoxColumn.Name = "cantidadAsistentesDataGridViewTextBoxColumn";
            // 
            // idAreaDataGridViewTextBoxColumn
            // 
            this.idAreaDataGridViewTextBoxColumn.DataPropertyName = "id_Area";
            this.idAreaDataGridViewTextBoxColumn.HeaderText = "id_Area";
            this.idAreaDataGridViewTextBoxColumn.Name = "idAreaDataGridViewTextBoxColumn";
            // 
            // idImagenesDataGridViewTextBoxColumn
            // 
            this.idImagenesDataGridViewTextBoxColumn.DataPropertyName = "id_Imagenes";
            this.idImagenesDataGridViewTextBoxColumn.HeaderText = "id_Imagenes";
            this.idImagenesDataGridViewTextBoxColumn.Name = "idImagenesDataGridViewTextBoxColumn";
            // 
            // eVENTOBindingSource
            // 
            this.eVENTOBindingSource.DataMember = "EVENTO";
            this.eVENTOBindingSource.DataSource = this.bINAESDataSet2;
            // 
            // bINAESDataSet2
            // 
            this.bINAESDataSet2.DataSetName = "BINAESDataSet2";
            this.bINAESDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Titulo",
            "Objetivos"});
            this.comboBox2.Location = new System.Drawing.Point(707, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(113, 6);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(588, 20);
            this.textBox24.TabIndex = 1;
            this.textBox24.TextChanged += new System.EventHandler(this.textBox24_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(6, 3);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 23);
            this.label39.TabIndex = 0;
            this.label39.Text = "Eventos";
            // 
            // tabDeleteEvent
            // 
            this.tabDeleteEvent.Location = new System.Drawing.Point(4, 24);
            this.tabDeleteEvent.Name = "tabDeleteEvent";
            this.tabDeleteEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteEvent.Size = new System.Drawing.Size(1004, 578);
            this.tabDeleteEvent.TabIndex = 2;
            this.tabDeleteEvent.Text = "Eliminar Evento";
            this.tabDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // tabSolicitarEvento
            // 
            this.tabSolicitarEvento.Controls.Add(this.tableLayoutPanel5);
            this.tabSolicitarEvento.Location = new System.Drawing.Point(4, 24);
            this.tabSolicitarEvento.Name = "tabSolicitarEvento";
            this.tabSolicitarEvento.Padding = new System.Windows.Forms.Padding(3);
            this.tabSolicitarEvento.Size = new System.Drawing.Size(1004, 578);
            this.tabSolicitarEvento.TabIndex = 3;
            this.tabSolicitarEvento.Text = "Solicitar Evento";
            this.tabSolicitarEvento.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 8;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox4, 3, 4);
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBox5, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label26, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.textBox13, 1, 8);
            this.tableLayoutPanel5.Controls.Add(this.label27, 4, 8);
            this.tableLayoutPanel5.Controls.Add(this.textBox14, 5, 8);
            this.tableLayoutPanel5.Controls.Add(this.label25, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.textBox15, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.label28, 3, 9);
            this.tableLayoutPanel5.Controls.Add(this.textBox16, 2, 10);
            this.tableLayoutPanel5.Controls.Add(this.textBox17, 2, 13);
            this.tableLayoutPanel5.Controls.Add(this.label29, 1, 12);
            this.tableLayoutPanel5.Controls.Add(this.button3, 7, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 4, 4);
            this.tableLayoutPanel5.Controls.Add(this.groupBox6, 5, 4);
            this.tableLayoutPanel5.Controls.Add(this.groupBox7, 6, 4);
            this.tableLayoutPanel5.Controls.Add(this.groupBox8, 7, 4);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 15;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1004, 578);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.checkBox9);
            this.groupBox4.Controls.Add(this.checkBox10);
            this.groupBox4.Location = new System.Drawing.Point(280, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 95);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sala de proyección";
            // 
            // checkBox7
            // 
            this.checkBox7.Location = new System.Drawing.Point(5, 65);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(104, 24);
            this.checkBox7.TabIndex = 1;
            this.checkBox7.Text = "Piso 4";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.Location = new System.Drawing.Point(5, 42);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(104, 24);
            this.checkBox9.TabIndex = 1;
            this.checkBox9.Text = "Piso 3";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.Location = new System.Drawing.Point(5, 19);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(104, 24);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "Piso 2";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Location = new System.Drawing.Point(179, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 78);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auditórium ";
            // 
            // checkBox8
            // 
            this.checkBox8.Location = new System.Drawing.Point(6, 19);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(104, 24);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Piso 1";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Location = new System.Drawing.Point(3, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "Nombre Completo";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(3, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Correo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.textBox4, 4);
            this.textBox4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox4.Location = new System.Drawing.Point(78, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(465, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.textBox5, 4);
            this.textBox5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox5.Location = new System.Drawing.Point(78, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(465, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Location = new System.Drawing.Point(78, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 95);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salones lúdicos";
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(6, 49);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(104, 24);
            this.checkBox6.TabIndex = 1;
            this.checkBox6.Text = "Piso 2";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(6, 19);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(104, 24);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Piso 1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.Location = new System.Drawing.Point(3, 300);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 35);
            this.label26.TabIndex = 15;
            this.label26.Text = "Fecha y Hora de inicio";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox13
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.textBox13, 2);
            this.textBox13.Location = new System.Drawing.Point(78, 303);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(196, 20);
            this.textBox13.TabIndex = 17;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.Location = new System.Drawing.Point(417, 300);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 35);
            this.label27.TabIndex = 16;
            this.label27.Text = "Fecha y Hora de Finalización";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox14
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.textBox14, 2);
            this.textBox14.Location = new System.Drawing.Point(549, 303);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(253, 20);
            this.textBox14.TabIndex = 18;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.Location = new System.Drawing.Point(3, 245);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 29);
            this.label25.TabIndex = 14;
            this.label25.Text = "Titulo del evento";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox15
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.textBox15, 3);
            this.textBox15.Location = new System.Drawing.Point(78, 248);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(333, 20);
            this.textBox15.TabIndex = 19;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.label28, 2);
            this.label28.Location = new System.Drawing.Point(280, 335);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(263, 36);
            this.label28.TabIndex = 20;
            this.label28.Text = "Objetivo del Evento";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox16
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.textBox16, 4);
            this.textBox16.Location = new System.Drawing.Point(179, 374);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.tableLayoutPanel5.SetRowSpan(this.textBox16, 2);
            this.textBox16.Size = new System.Drawing.Size(495, 52);
            this.textBox16.TabIndex = 21;
            // 
            // textBox17
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.textBox17, 2);
            this.textBox17.Location = new System.Drawing.Point(179, 468);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(110, 20);
            this.textBox17.TabIndex = 23;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label29.Location = new System.Drawing.Point(78, 429);
            this.label29.Name = "label29";
            this.tableLayoutPanel5.SetRowSpan(this.label29, 2);
            this.label29.Size = new System.Drawing.Size(95, 63);
            this.label29.TabIndex = 22;
            this.label29.Text = "Cantidad de Asistentes";
            this.label29.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(808, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 24;
            this.button3.Text = "Solicitar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.checkBox15);
            this.groupBox5.Controls.Add(this.checkBox13);
            this.groupBox5.Controls.Add(this.checkBox11);
            this.groupBox5.Location = new System.Drawing.Point(417, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(126, 120);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Área de Computación";
            // 
            // checkBox15
            // 
            this.checkBox15.Location = new System.Drawing.Point(6, 91);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(104, 24);
            this.checkBox15.TabIndex = 1;
            this.checkBox15.Text = "Piso 2";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.Location = new System.Drawing.Point(6, 67);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(104, 24);
            this.checkBox13.TabIndex = 1;
            this.checkBox13.Text = "Piso 2";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.Location = new System.Drawing.Point(6, 43);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(104, 24);
            this.checkBox11.TabIndex = 1;
            this.checkBox11.Text = "Piso 2";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.checkBox14);
            this.groupBox6.Location = new System.Drawing.Point(549, 133);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(125, 78);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Area de promoción de inclución";
            // 
            // checkBox14
            // 
            this.checkBox14.Location = new System.Drawing.Point(6, 29);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(104, 24);
            this.checkBox14.TabIndex = 0;
            this.checkBox14.Text = "Piso 1";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.checkBox16);
            this.groupBox7.Location = new System.Drawing.Point(680, 133);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(122, 78);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sala de investigación";
            // 
            // checkBox16
            // 
            this.checkBox16.Location = new System.Drawing.Point(0, 19);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(104, 24);
            this.checkBox16.TabIndex = 0;
            this.checkBox16.Text = "Piso 4";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox20);
            this.groupBox8.Controls.Add(this.checkBox19);
            this.groupBox8.Controls.Add(this.checkBox17);
            this.groupBox8.Controls.Add(this.checkBox18);
            this.groupBox8.Location = new System.Drawing.Point(808, 91);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(126, 120);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Area de Biblioteca";
            // 
            // checkBox20
            // 
            this.checkBox20.Location = new System.Drawing.Point(6, 91);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(91, 24);
            this.checkBox20.TabIndex = 3;
            this.checkBox20.Text = "Piso 4";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.Location = new System.Drawing.Point(6, 67);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(91, 24);
            this.checkBox19.TabIndex = 2;
            this.checkBox19.Text = "Piso3";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.Location = new System.Drawing.Point(6, 44);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(104, 24);
            this.checkBox17.TabIndex = 1;
            this.checkBox17.Text = "Piso 2";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.Location = new System.Drawing.Point(6, 19);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(104, 24);
            this.checkBox18.TabIndex = 0;
            this.checkBox18.Text = "Piso 1";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // tabEditEvent
            // 
            this.tabEditEvent.Controls.Add(this.tableLayoutPanel6);
            this.tabEditEvent.Location = new System.Drawing.Point(4, 24);
            this.tabEditEvent.Name = "tabEditEvent";
            this.tabEditEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditEvent.Size = new System.Drawing.Size(1004, 578);
            this.tabEditEvent.TabIndex = 4;
            this.tabEditEvent.Text = "Editar Evento";
            this.tabEditEvent.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 8;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56746F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel6.Controls.Add(this.label31, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label30, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox18, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.textBox19, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label32, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label33, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.textBox20, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.textBox21, 1, 8);
            this.tableLayoutPanel6.Controls.Add(this.label34, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.label35, 0, 10);
            this.tableLayoutPanel6.Controls.Add(this.textBox22, 1, 10);
            this.tableLayoutPanel6.Controls.Add(this.label36, 0, 12);
            this.tableLayoutPanel6.Controls.Add(this.groupBox9, 1, 12);
            this.tableLayoutPanel6.Controls.Add(this.groupBox10, 2, 12);
            this.tableLayoutPanel6.Controls.Add(this.groupBox11, 3, 12);
            this.tableLayoutPanel6.Controls.Add(this.groupBox12, 4, 12);
            this.tableLayoutPanel6.Controls.Add(this.groupBox13, 5, 12);
            this.tableLayoutPanel6.Controls.Add(this.groupBox14, 6, 12);
            this.tableLayoutPanel6.Controls.Add(this.groupBox15, 7, 12);
            this.tableLayoutPanel6.Controls.Add(this.button5, 7, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 17;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.44186F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.55814F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1008, 578);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.Location = new System.Drawing.Point(3, 40);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(116, 24);
            this.label31.TabIndex = 1;
            this.label31.Text = "TItulo";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.label30, 4);
            this.label30.Location = new System.Drawing.Point(125, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(485, 27);
            this.label30.TabIndex = 0;
            this.label30.Text = "Modificaón de datos del eventos: Ingresa los datos a modificar del evento ";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox18
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.textBox18, 4);
            this.textBox18.Location = new System.Drawing.Point(125, 43);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(401, 20);
            this.textBox18.TabIndex = 2;
            // 
            // textBox19
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.textBox19, 2);
            this.textBox19.Location = new System.Drawing.Point(125, 75);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(184, 20);
            this.textBox19.TabIndex = 4;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.Location = new System.Drawing.Point(3, 72);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(116, 31);
            this.label32.TabIndex = 3;
            this.label32.Text = "Fecha y hora de inicio";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.Location = new System.Drawing.Point(3, 119);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 28);
            this.label33.TabIndex = 5;
            this.label33.Text = "Fecha y hora de finalización";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox20
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.textBox20, 2);
            this.textBox20.Location = new System.Drawing.Point(125, 122);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(184, 20);
            this.textBox20.TabIndex = 6;
            // 
            // textBox21
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.textBox21, 3);
            this.textBox21.Location = new System.Drawing.Point(125, 169);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(353, 55);
            this.textBox21.TabIndex = 8;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.Location = new System.Drawing.Point(3, 166);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(116, 61);
            this.label34.TabIndex = 7;
            this.label34.Text = "Objetivo del evento ";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.Location = new System.Drawing.Point(3, 249);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(116, 27);
            this.label35.TabIndex = 9;
            this.label35.Text = "Cantidad de asistentes";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(125, 252);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(123, 20);
            this.textBox22.TabIndex = 10;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.Location = new System.Drawing.Point(3, 299);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(116, 127);
            this.label36.TabIndex = 11;
            this.label36.Text = "Area";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox9.Controls.Add(this.checkBox21);
            this.groupBox9.Controls.Add(this.checkBox22);
            this.groupBox9.Location = new System.Drawing.Point(132, 302);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(109, 121);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Salones lúdicos";
            // 
            // checkBox21
            // 
            this.checkBox21.Location = new System.Drawing.Point(6, 49);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(104, 24);
            this.checkBox21.TabIndex = 1;
            this.checkBox21.Text = "Piso 2";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.Location = new System.Drawing.Point(6, 19);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(104, 24);
            this.checkBox22.TabIndex = 0;
            this.checkBox22.Text = "Piso 1";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.checkBox23);
            this.groupBox10.Location = new System.Drawing.Point(254, 302);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(104, 121);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Auditórium ";
            // 
            // checkBox23
            // 
            this.checkBox23.Location = new System.Drawing.Point(6, 19);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(104, 24);
            this.checkBox23.TabIndex = 0;
            this.checkBox23.Text = "Piso 1";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.checkBox24);
            this.groupBox11.Controls.Add(this.checkBox25);
            this.groupBox11.Controls.Add(this.checkBox26);
            this.groupBox11.Location = new System.Drawing.Point(364, 302);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(114, 121);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Sala de proyección";
            // 
            // checkBox24
            // 
            this.checkBox24.Location = new System.Drawing.Point(5, 65);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(104, 24);
            this.checkBox24.TabIndex = 1;
            this.checkBox24.Text = "Piso 4";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.Location = new System.Drawing.Point(5, 42);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(104, 24);
            this.checkBox25.TabIndex = 1;
            this.checkBox25.Text = "Piso 3";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.Location = new System.Drawing.Point(5, 19);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(104, 24);
            this.checkBox26.TabIndex = 0;
            this.checkBox26.Text = "Piso 2";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.checkBox33);
            this.groupBox12.Controls.Add(this.checkBox12);
            this.groupBox12.Controls.Add(this.checkBox30);
            this.groupBox12.Controls.Add(this.checkBox31);
            this.groupBox12.Location = new System.Drawing.Point(484, 302);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(126, 121);
            this.groupBox12.TabIndex = 15;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Área de Computación";
            // 
            // checkBox33
            // 
            this.checkBox33.Location = new System.Drawing.Point(6, 19);
            this.checkBox33.Name = "checkBox33";
            this.checkBox33.Size = new System.Drawing.Size(104, 24);
            this.checkBox33.TabIndex = 2;
            this.checkBox33.Text = "Piso 2";
            this.checkBox33.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.Location = new System.Drawing.Point(6, 91);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(104, 24);
            this.checkBox12.TabIndex = 1;
            this.checkBox12.Text = "Piso 2";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.Location = new System.Drawing.Point(6, 67);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(104, 24);
            this.checkBox30.TabIndex = 1;
            this.checkBox30.Text = "Piso 2";
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            this.checkBox31.Location = new System.Drawing.Point(6, 43);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(104, 24);
            this.checkBox31.TabIndex = 1;
            this.checkBox31.Text = "Piso 2";
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.checkBox32);
            this.groupBox13.Location = new System.Drawing.Point(616, 302);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(128, 121);
            this.groupBox13.TabIndex = 16;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Area de promoción de inclución";
            // 
            // checkBox32
            // 
            this.checkBox32.Location = new System.Drawing.Point(6, 29);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(104, 24);
            this.checkBox32.TabIndex = 0;
            this.checkBox32.Text = "Piso 1";
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox14.Controls.Add(this.checkBox34);
            this.groupBox14.Location = new System.Drawing.Point(750, 302);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(122, 121);
            this.groupBox14.TabIndex = 17;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Sala de investigación";
            // 
            // checkBox34
            // 
            this.checkBox34.Location = new System.Drawing.Point(0, 19);
            this.checkBox34.Name = "checkBox34";
            this.checkBox34.Size = new System.Drawing.Size(104, 24);
            this.checkBox34.TabIndex = 0;
            this.checkBox34.Text = "Piso 4";
            this.checkBox34.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.checkBox35);
            this.groupBox15.Controls.Add(this.checkBox36);
            this.groupBox15.Controls.Add(this.checkBox37);
            this.groupBox15.Controls.Add(this.checkBox38);
            this.groupBox15.Location = new System.Drawing.Point(878, 302);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(126, 120);
            this.groupBox15.TabIndex = 18;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Area de Biblioteca";
            // 
            // checkBox35
            // 
            this.checkBox35.Location = new System.Drawing.Point(6, 91);
            this.checkBox35.Name = "checkBox35";
            this.checkBox35.Size = new System.Drawing.Size(91, 24);
            this.checkBox35.TabIndex = 3;
            this.checkBox35.Text = "Piso 4";
            this.checkBox35.UseVisualStyleBackColor = true;
            // 
            // checkBox36
            // 
            this.checkBox36.Location = new System.Drawing.Point(6, 67);
            this.checkBox36.Name = "checkBox36";
            this.checkBox36.Size = new System.Drawing.Size(91, 24);
            this.checkBox36.TabIndex = 2;
            this.checkBox36.Text = "Piso3";
            this.checkBox36.UseVisualStyleBackColor = true;
            // 
            // checkBox37
            // 
            this.checkBox37.Location = new System.Drawing.Point(6, 44);
            this.checkBox37.Name = "checkBox37";
            this.checkBox37.Size = new System.Drawing.Size(104, 24);
            this.checkBox37.TabIndex = 1;
            this.checkBox37.Text = "Piso 2";
            this.checkBox37.UseVisualStyleBackColor = true;
            // 
            // checkBox38
            // 
            this.checkBox38.Location = new System.Drawing.Point(6, 19);
            this.checkBox38.Name = "checkBox38";
            this.checkBox38.Size = new System.Drawing.Size(104, 24);
            this.checkBox38.TabIndex = 0;
            this.checkBox38.Text = "Piso 1";
            this.checkBox38.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(878, 3);
            this.button5.Name = "button5";
            this.tableLayoutPanel6.SetRowSpan(this.button5, 2);
            this.button5.Size = new System.Drawing.Size(110, 34);
            this.button5.TabIndex = 19;
            this.button5.Text = "Guardar Cambios";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabBiblioteca1
            // 
            this.tabBiblioteca1.Controls.Add(this.dataGridView1);
            this.tabBiblioteca1.Controls.Add(this.comboBox1);
            this.tabBiblioteca1.Controls.Add(this.textBox1);
            this.tabBiblioteca1.Controls.Add(this.label10);
            this.tabBiblioteca1.Location = new System.Drawing.Point(4, 24);
            this.tabBiblioteca1.Name = "tabBiblioteca1";
            this.tabBiblioteca1.Padding = new System.Windows.Forms.Padding(3);
            this.tabBiblioteca1.Size = new System.Drawing.Size(1004, 578);
            this.tabBiblioteca1.TabIndex = 5;
            this.tabBiblioteca1.Text = "Biblioteca";
            this.tabBiblioteca1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechapublicacionDataGridViewTextBoxColumn,
            this.idautorDataGridViewTextBoxColumn,
            this.idetiquetaDataGridViewTextBoxColumn,
            this.ididiomaDataGridViewTextBoxColumn,
            this.idformatoDataGridViewTextBoxColumn,
            this.idpalabraclaveDataGridViewTextBoxColumn,
            this.idfotoDataGridViewTextBoxColumn,
            this.ideditorialDataGridViewTextBoxColumn,
            this.idcoleccionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eJEMPLARBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1001, 531);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // fechapublicacionDataGridViewTextBoxColumn
            // 
            this.fechapublicacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_publicacion";
            this.fechapublicacionDataGridViewTextBoxColumn.HeaderText = "fecha_publicacion";
            this.fechapublicacionDataGridViewTextBoxColumn.Name = "fechapublicacionDataGridViewTextBoxColumn";
            // 
            // idautorDataGridViewTextBoxColumn
            // 
            this.idautorDataGridViewTextBoxColumn.DataPropertyName = "id_autor";
            this.idautorDataGridViewTextBoxColumn.HeaderText = "id_autor";
            this.idautorDataGridViewTextBoxColumn.Name = "idautorDataGridViewTextBoxColumn";
            // 
            // idetiquetaDataGridViewTextBoxColumn
            // 
            this.idetiquetaDataGridViewTextBoxColumn.DataPropertyName = "id_etiqueta";
            this.idetiquetaDataGridViewTextBoxColumn.HeaderText = "id_etiqueta";
            this.idetiquetaDataGridViewTextBoxColumn.Name = "idetiquetaDataGridViewTextBoxColumn";
            // 
            // ididiomaDataGridViewTextBoxColumn
            // 
            this.ididiomaDataGridViewTextBoxColumn.DataPropertyName = "id_idioma";
            this.ididiomaDataGridViewTextBoxColumn.HeaderText = "id_idioma";
            this.ididiomaDataGridViewTextBoxColumn.Name = "ididiomaDataGridViewTextBoxColumn";
            // 
            // idformatoDataGridViewTextBoxColumn
            // 
            this.idformatoDataGridViewTextBoxColumn.DataPropertyName = "id_formato";
            this.idformatoDataGridViewTextBoxColumn.HeaderText = "id_formato";
            this.idformatoDataGridViewTextBoxColumn.Name = "idformatoDataGridViewTextBoxColumn";
            // 
            // idpalabraclaveDataGridViewTextBoxColumn
            // 
            this.idpalabraclaveDataGridViewTextBoxColumn.DataPropertyName = "id_palabra_clave";
            this.idpalabraclaveDataGridViewTextBoxColumn.HeaderText = "id_palabra_clave";
            this.idpalabraclaveDataGridViewTextBoxColumn.Name = "idpalabraclaveDataGridViewTextBoxColumn";
            // 
            // idfotoDataGridViewTextBoxColumn
            // 
            this.idfotoDataGridViewTextBoxColumn.DataPropertyName = "id_foto";
            this.idfotoDataGridViewTextBoxColumn.HeaderText = "id_foto";
            this.idfotoDataGridViewTextBoxColumn.Name = "idfotoDataGridViewTextBoxColumn";
            // 
            // ideditorialDataGridViewTextBoxColumn
            // 
            this.ideditorialDataGridViewTextBoxColumn.DataPropertyName = "id_editorial";
            this.ideditorialDataGridViewTextBoxColumn.HeaderText = "id_editorial";
            this.ideditorialDataGridViewTextBoxColumn.Name = "ideditorialDataGridViewTextBoxColumn";
            // 
            // idcoleccionDataGridViewTextBoxColumn
            // 
            this.idcoleccionDataGridViewTextBoxColumn.DataPropertyName = "id_coleccion";
            this.idcoleccionDataGridViewTextBoxColumn.HeaderText = "id_coleccion";
            this.idcoleccionDataGridViewTextBoxColumn.Name = "idcoleccionDataGridViewTextBoxColumn";
            // 
            // eJEMPLARBindingSource
            // 
            this.eJEMPLARBindingSource.DataMember = "EJEMPLAR";
            this.eJEMPLARBindingSource.DataSource = this.bINAESDataSet1;
            // 
            // bINAESDataSet1
            // 
            this.bINAESDataSet1.DataSetName = "BINAESDataSet1";
            this.bINAESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "id"});
            this.comboBox1.Location = new System.Drawing.Point(635, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Libros";
            // 
            // tablisitEvent
            // 
            this.tablisitEvent.Location = new System.Drawing.Point(4, 24);
            this.tablisitEvent.Name = "tablisitEvent";
            this.tablisitEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tablisitEvent.Size = new System.Drawing.Size(1004, 578);
            this.tablisitEvent.TabIndex = 6;
            this.tablisitEvent.Text = "Listar Eventos";
            this.tablisitEvent.UseVisualStyleBackColor = true;
            // 
            // tabAddUser
            // 
            this.tabAddUser.Controls.Add(this.tableLayoutPanel3);
            this.tabAddUser.Location = new System.Drawing.Point(4, 24);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUser.Size = new System.Drawing.Size(1004, 578);
            this.tabAddUser.TabIndex = 7;
            this.tabAddUser.Text = "Agregar Usuario";
            this.tabAddUser.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.84848F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.15152F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 471F));
            this.tableLayoutPanel3.Controls.Add(this.txtTelefono, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtNombre, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtOcupación, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtInstitución, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnAddUserToBD, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtDirección, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCorreo, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.codigito, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.QR, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1000, 570);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Location = new System.Drawing.Point(558, 9);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(411, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ocupación";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dirección:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefono:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Foto:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(334, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Correo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(151, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtOcupación
            // 
            this.txtOcupación.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOcupación.Location = new System.Drawing.Point(151, 49);
            this.txtOcupación.Name = "txtOcupación";
            this.txtOcupación.Size = new System.Drawing.Size(177, 20);
            this.txtOcupación.TabIndex = 9;
            // 
            // txtInstitución
            // 
            this.txtInstitución.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInstitución.Location = new System.Drawing.Point(151, 155);
            this.txtInstitución.Name = "txtInstitución";
            this.txtInstitución.Size = new System.Drawing.Size(177, 20);
            this.txtInstitución.TabIndex = 11;
            // 
            // btnAddUserToBD
            // 
            this.btnAddUserToBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUserToBD.AutoSize = true;
            this.btnAddUserToBD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddUserToBD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUserToBD.BackgroundImage")));
            this.btnAddUserToBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddUserToBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUserToBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserToBD.Location = new System.Drawing.Point(681, 138);
            this.btnAddUserToBD.Name = "btnAddUserToBD";
            this.btnAddUserToBD.Size = new System.Drawing.Size(165, 55);
            this.btnAddUserToBD.TabIndex = 14;
            this.btnAddUserToBD.UseVisualStyleBackColor = false;
            this.btnAddUserToBD.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtDirección
            // 
            this.txtDirección.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDirección.Location = new System.Drawing.Point(151, 97);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(177, 20);
            this.txtDirección.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Location = new System.Drawing.Point(559, 97);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(409, 20);
            this.txtCorreo.TabIndex = 12;
            // 
            // codigito
            // 
            this.codigito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigito.Location = new System.Drawing.Point(151, 199);
            this.codigito.Name = "codigito";
            this.codigito.Size = new System.Drawing.Size(177, 219);
            this.codigito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codigito.TabIndex = 16;
            this.codigito.TabStop = false;
            // 
            // QR
            // 
            this.QR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QR.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QR.Location = new System.Drawing.Point(3, 196);
            this.QR.Name = "QR";
            this.QR.Size = new System.Drawing.Size(142, 225);
            this.QR.TabIndex = 15;
            this.QR.Text = "Codigo QR:";
            this.QR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(558, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Adjuntar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAdjuntarFoto_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 225);
            this.label9.TabIndex = 18;
            this.label9.Text = "Foto:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(647, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Institución:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPrestamoLibro
            // 
            this.tabPrestamoLibro.Controls.Add(this.tableLayoutPanel4);
            this.tabPrestamoLibro.Location = new System.Drawing.Point(4, 24);
            this.tabPrestamoLibro.Name = "tabPrestamoLibro";
            this.tabPrestamoLibro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrestamoLibro.Size = new System.Drawing.Size(1004, 578);
            this.tabPrestamoLibro.TabIndex = 8;
            this.tabPrestamoLibro.Text = "Prestar Libro";
            this.tabPrestamoLibro.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.88235F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.11765F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 495F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label16, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label17, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBox6, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBox7, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.label18, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.textBox8, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.textBox9, 2, 9);
            this.tableLayoutPanel4.Controls.Add(this.textBox10, 2, 11);
            this.tableLayoutPanel4.Controls.Add(this.label21, 1, 15);
            this.tableLayoutPanel4.Controls.Add(this.label22, 0, 13);
            this.tableLayoutPanel4.Controls.Add(this.label23, 1, 14);
            this.tableLayoutPanel4.Controls.Add(this.label24, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.label20, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.textBox11, 2, 14);
            this.tableLayoutPanel4.Controls.Add(this.textBox12, 2, 15);
            this.tableLayoutPanel4.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 16;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.69697F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1008, 578);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 46);
            this.label15.TabIndex = 0;
            this.label15.Text = "Información personal";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Location = new System.Drawing.Point(162, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 29);
            this.label16.TabIndex = 1;
            this.label16.Text = "Nombre Completo";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Location = new System.Drawing.Point(162, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 31);
            this.label17.TabIndex = 2;
            this.label17.Text = "Email";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(287, 69);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(333, 20);
            this.textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(287, 118);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(333, 20);
            this.textBox7.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Location = new System.Drawing.Point(162, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 30);
            this.label18.TabIndex = 5;
            this.label18.Text = "ID";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(287, 163);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(153, 20);
            this.textBox8.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.Location = new System.Drawing.Point(15, 210);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 15);
            this.label19.TabIndex = 7;
            this.label19.Text = "Detalles del Ejemplar";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(287, 232);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(153, 20);
            this.textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(287, 269);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(153, 20);
            this.textBox10.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.Location = new System.Drawing.Point(162, 357);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 27);
            this.label21.TabIndex = 9;
            this.label21.Text = "Fecha de la devolución";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.Location = new System.Drawing.Point(3, 309);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(153, 23);
            this.label22.TabIndex = 12;
            this.label22.Text = "Información del Prestamo";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.Location = new System.Drawing.Point(162, 332);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 25);
            this.label23.TabIndex = 13;
            this.label23.Text = "Fecha del préstamo";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.Location = new System.Drawing.Point(162, 229);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 25);
            this.label24.TabIndex = 14;
            this.label24.Text = "Nombre del Ejemplar";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Location = new System.Drawing.Point(162, 266);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 25);
            this.label20.TabIndex = 8;
            this.label20.Text = "ID";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(287, 335);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(153, 20);
            this.textBox11.TabIndex = 15;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(287, 360);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(153, 20);
            this.textBox12.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(782, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 40);
            this.button4.TabIndex = 17;
            this.button4.Text = "Solicitar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.Location = new System.Drawing.Point(5, 65);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(104, 24);
            this.checkBox27.TabIndex = 1;
            this.checkBox27.Text = "Piso 4";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.Location = new System.Drawing.Point(5, 42);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(104, 24);
            this.checkBox28.TabIndex = 1;
            this.checkBox28.Text = "Piso 3";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.Location = new System.Drawing.Point(5, 19);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(104, 24);
            this.checkBox29.TabIndex = 0;
            this.checkBox29.Text = "Piso 2";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(3, 579);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Correo";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.Location = new System.Drawing.Point(130, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Nombre";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox3.Location = new System.Drawing.Point(435, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Apellido";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 40);
            this.label13.TabIndex = 1;
            this.label13.Text = "Detalles del evento";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 9;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56746F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel7.Controls.Add(this.label37, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label38, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.Location = new System.Drawing.Point(3, 40);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(1, 60);
            this.label37.TabIndex = 1;
            this.label37.Text = "TItulo";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.SetColumnSpan(this.label38, 4);
            this.label38.Location = new System.Drawing.Point(-709, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(516, 20);
            this.label38.TabIndex = 0;
            this.label38.Text = "Modificaón de datos del eventos: Ingresa los datos a modificar del evento ";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(-709, 30);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(401, 20);
            this.textBox23.TabIndex = 2;
            // 
            // eJEMPLARTableAdapter
            // 
            this.eJEMPLARTableAdapter.ClearBeforeFill = true;
            // 
            // editorialTableAdapter1
            // 
            this.editorialTableAdapter1.ClearBeforeFill = true;
            // 
            // eVENTOTableAdapter
            // 
            this.eVENTOTableAdapter.ClearBeforeFill = true;
            // 
            // InformaciónBinaes
            // 
            this.InformaciónBinaes.Controls.Add(this.label45);
            this.InformaciónBinaes.Controls.Add(this.label44);
            this.InformaciónBinaes.Controls.Add(this.label43);
            this.InformaciónBinaes.Controls.Add(this.label42);
            this.InformaciónBinaes.Controls.Add(this.label41);
            this.InformaciónBinaes.Controls.Add(this.label40);
            this.InformaciónBinaes.Controls.Add(this.pictureBox4);
            this.InformaciónBinaes.Location = new System.Drawing.Point(4, 24);
            this.InformaciónBinaes.Name = "InformaciónBinaes";
            this.InformaciónBinaes.Padding = new System.Windows.Forms.Padding(3);
            this.InformaciónBinaes.Size = new System.Drawing.Size(1004, 578);
            this.InformaciónBinaes.TabIndex = 9;
            this.InformaciónBinaes.Text = "Información";
            this.InformaciónBinaes.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(33, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(513, 300);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label40
            // 
            this.label40.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label40.Location = new System.Drawing.Point(598, 102);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(400, 60);
            this.label40.TabIndex = 1;
            this.label40.Text = resources.GetString("label40.Text");
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(598, 162);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(400, 67);
            this.label41.TabIndex = 2;
            this.label41.Text = resources.GetString("label41.Text");
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(598, 229);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(398, 52);
            this.label42.TabIndex = 3;
            this.label42.Text = "Según lo explicó el Jefe de Estado, el costo será de 54 millones de dólares (incl" +
    "uyendo equipamiento y libros) y buscará ser un edificio sumamente moderno y acor" +
    "de a los nuevos tiempos.";
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(598, 281);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(400, 52);
            this.label43.TabIndex = 4;
            this.label43.Text = resources.GetString("label43.Text");
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(601, 337);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(403, 71);
            this.label44.TabIndex = 5;
            this.label44.Text = resources.GetString("label44.Text");
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(598, 399);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(406, 32);
            this.label45.TabIndex = 6;
            this.label45.Text = "La biblioteca tendrá grandes espacios para la lectura, libros de todo tipo y hast" +
    "a auditorio, se detalló.";
            // 
            // ConnectInfo
            // 
            this.ConnectInfo.Image = ((System.Drawing.Image)(resources.GetObject("ConnectInfo.Image")));
            this.ConnectInfo.Location = new System.Drawing.Point(816, 507);
            this.ConnectInfo.Name = "ConnectInfo";
            this.ConnectInfo.Size = new System.Drawing.Size(170, 51);
            this.ConnectInfo.TabIndex = 3;
            this.ConnectInfo.UseVisualStyleBackColor = true;
            this.ConnectInfo.Click += new System.EventHandler(this.ConnectInfo_Click);
            // 
            // FrmPrincipal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1017, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstMenuSuperior;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINAES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal1_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mstMenuSuperior.ResumeLayout(false);
            this.mstMenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabEventos.ResumeLayout(false);
            this.tabEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bINAESDataSet2)).EndInit();
            this.tabSolicitarEvento.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tabEditEvent.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.tabBiblioteca1.ResumeLayout(false);
            this.tabBiblioteca1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJEMPLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bINAESDataSet1)).EndInit();
            this.tabAddUser.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPrestamoLibro.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.InformaciónBinaes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.CheckBox checkBox33;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox checkBox34;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.CheckBox checkBox35;
        private System.Windows.Forms.CheckBox checkBox36;
        private System.Windows.Forms.CheckBox checkBox37;
        private System.Windows.Forms.CheckBox checkBox38;

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.CheckBox checkBox31;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox checkBox32;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox23;

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox29;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;

        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox22;

        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox21;

        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox18;

        private System.Windows.Forms.Label label30;

        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox17;

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox16;

        private System.Windows.Forms.Label label25;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;

        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;

        private System.Windows.Forms.Label label23;

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label22;

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;

        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;

        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;

        private System.Windows.Forms.GroupBox groupBox2;
        

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label label1;
        

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox codigito;

        private System.Windows.Forms.Label QR;

        private System.Windows.Forms.Button btnAddUserToBD;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtOcupación;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.TextBox txtInstitución;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

        private System.Windows.Forms.ToolStripMenuItem prestamoDeLibrosToolStripMenuItem;

        private System.Windows.Forms.TabPage tabPrestamoLibro;

        private System.Windows.Forms.ToolStripMenuItem tsmAddUser;

        private System.Windows.Forms.TabPage tabAddUser;

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.TabPage tabEditEvent;
        private System.Windows.Forms.TabPage tabBiblioteca1;
        private System.Windows.Forms.TabPage tablisitEvent;

        private System.Windows.Forms.TabPage tabDeleteEvent;
        private System.Windows.Forms.TabPage tabSolicitarEvento;

        private System.Windows.Forms.MenuStrip mstMenuSuperior;
        private System.Windows.Forms.ToolStripMenuItem tsmIncio;
        private System.Windows.Forms.ToolStripMenuItem tsmEventos;
        private System.Windows.Forms.ToolStripMenuItem tsmBiblioteca;
        private System.Windows.Forms.ToolStripMenuItem tsmSolicitudes;
        private System.Windows.Forms.ToolStripMenuItem btnSolocitarEvento;
        private System.Windows.Forms.ToolStripMenuItem btnEditarEvento;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarEvento;
        private System.Windows.Forms.ToolStripMenuItem btnListarEvento;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabEventos;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private BINAESDataSet1 bINAESDataSet1;
        private System.Windows.Forms.BindingSource eJEMPLARBindingSource;
        private BINAESDataSet1TableAdapters.EJEMPLARTableAdapter eJEMPLARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idautorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idetiquetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ididiomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idformatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpalabraclaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideditorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcoleccionDataGridViewTextBoxColumn;
        private BINAESDataSetTableAdapters.EDITORIALTableAdapter editorialTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BINAESDataSet2 bINAESDataSet2;
        private System.Windows.Forms.BindingSource eVENTOBindingSource;
        private BINAESDataSet2TableAdapters.EVENTOTableAdapter eVENTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetivosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadAsistentesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idImagenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage InformaciónBinaes;
        private System.Windows.Forms.Button ConnectInfo;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}