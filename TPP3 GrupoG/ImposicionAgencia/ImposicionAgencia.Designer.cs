namespace TPP3_GrupoG.ImposicionAgencia
{
    partial class ImposicionAgencia
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
            labelTelefonoCliente = new Label();
            labelCPCliente = new Label();
            labelDireccionCliente = new Label();
            labelLocalidadCliente = new Label();
            label9 = new Label();
            labelDNI = new Label();
            provinciaLBL = new Label();
            CBLocalidad = new ComboBox();
            Rdb_domicilio = new RadioButton();
            labelProvinciaCliente = new Label();
            labelNombreyApellido = new Label();
            pronviciaCliente = new Label();
            CBProvincia = new ComboBox();
            localidadLBL = new Label();
            CBTipoEntrega = new ComboBox();
            Agencia = new Label();
            CodigoPostalDestinatario = new Label();
            TBDDCP = new TextBox();
            CodidoPostal = new Label();
            TipoPaquete = new Label();
            CBTipoPaquete = new ComboBox();
            Btn_Volver = new Button();
            btn_Registrarcliente = new Button();
            buttonBuscar = new Button();
            TBCliente = new TextBox();
            lbl_BuscarCliente = new Label();
            label2 = new Label();
            TBDPDescripcion = new TextBox();
            lbl_Descripcion = new Label();
            lbl_DetallePaquete = new Label();
            lbl_TipoEntrega = new Label();
            Rdb_CD = new RadioButton();
            Rdb_Agencia = new RadioButton();
            lbl_TelefonoDestinatario = new Label();
            lbl_direccionDestinatario = new Label();
            label4 = new Label();
            TBDDTelefono = new TextBox();
            TBDDDireccion = new TextBox();
            TBDDDNI = new TextBox();
            TBDDNombre = new TextBox();
            lbl_NombreDestinatario = new Label();
            lbl_DatosDestinatario = new Label();
            lbl_Telefono = new Label();
            lbl_Direccion = new Label();
            label7 = new Label();
            lbl_DatosCliente = new Label();
            label3 = new Label();
            lbl_NameTutasa = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelTelefonoCliente
            // 
            labelTelefonoCliente.AutoSize = true;
            labelTelefonoCliente.Location = new Point(11, 478);
            labelTelefonoCliente.Margin = new Padding(2, 0, 2, 0);
            labelTelefonoCliente.Name = "labelTelefonoCliente";
            labelTelefonoCliente.Size = new Size(85, 15);
            labelTelefonoCliente.TabIndex = 134;
            labelTelefonoCliente.Text = "[XXXXXXXXXX]";
            // 
            // labelCPCliente
            // 
            labelCPCliente.AutoSize = true;
            labelCPCliente.Location = new Point(11, 392);
            labelCPCliente.Margin = new Padding(2, 0, 2, 0);
            labelCPCliente.Name = "labelCPCliente";
            labelCPCliente.Size = new Size(43, 15);
            labelCPCliente.TabIndex = 133;
            labelCPCliente.Text = "[XXXX]";
            // 
            // labelDireccionCliente
            // 
            labelDireccionCliente.AutoSize = true;
            labelDireccionCliente.Location = new Point(11, 440);
            labelDireccionCliente.Margin = new Padding(2, 0, 2, 0);
            labelDireccionCliente.Name = "labelDireccionCliente";
            labelDireccionCliente.Size = new Size(65, 15);
            labelDireccionCliente.TabIndex = 132;
            labelDireccionCliente.Text = "[Dirección]";
            // 
            // labelLocalidadCliente
            // 
            labelLocalidadCliente.AutoSize = true;
            labelLocalidadCliente.Location = new Point(11, 348);
            labelLocalidadCliente.Margin = new Padding(2, 0, 2, 0);
            labelLocalidadCliente.Name = "labelLocalidadCliente";
            labelLocalidadCliente.Size = new Size(66, 15);
            labelLocalidadCliente.TabIndex = 131;
            labelLocalidadCliente.Text = "[Localidad]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 332);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 130;
            label9.Text = "Localidad";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(11, 264);
            labelDNI.Margin = new Padding(2, 0, 2, 0);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(71, 15);
            labelDNI.TabIndex = 129;
            labelDNI.Text = "[XXXXXXXX]";
            // 
            // provinciaLBL
            // 
            provinciaLBL.AutoSize = true;
            provinciaLBL.Location = new Point(318, 313);
            provinciaLBL.Name = "provinciaLBL";
            provinciaLBL.Size = new Size(56, 15);
            provinciaLBL.TabIndex = 128;
            provinciaLBL.Text = "Provincia";
            // 
            // CBLocalidad
            // 
            CBLocalidad.FormattingEnabled = true;
            CBLocalidad.Location = new Point(320, 381);
            CBLocalidad.Name = "CBLocalidad";
            CBLocalidad.Size = new Size(232, 23);
            CBLocalidad.TabIndex = 127;
            CBLocalidad.SelectedIndexChanged += CBLocalidad_SelectedIndexChanged;
            // 
            // Rdb_domicilio
            // 
            Rdb_domicilio.AutoSize = true;
            Rdb_domicilio.Location = new Point(763, 121);
            Rdb_domicilio.Margin = new Padding(3, 2, 3, 2);
            Rdb_domicilio.Name = "Rdb_domicilio";
            Rdb_domicilio.Size = new Size(86, 19);
            Rdb_domicilio.TabIndex = 126;
            Rdb_domicilio.TabStop = true;
            Rdb_domicilio.Text = "A domicilio";
            Rdb_domicilio.UseVisualStyleBackColor = true;
            Rdb_domicilio.CheckedChanged += Rdb_domicilio_CheckedChanged;
            // 
            // labelProvinciaCliente
            // 
            labelProvinciaCliente.AutoSize = true;
            labelProvinciaCliente.Location = new Point(11, 304);
            labelProvinciaCliente.Margin = new Padding(2, 0, 2, 0);
            labelProvinciaCliente.Name = "labelProvinciaCliente";
            labelProvinciaCliente.Size = new Size(83, 15);
            labelProvinciaCliente.TabIndex = 125;
            labelProvinciaCliente.Text = "[Buenos Aires]";
            // 
            // labelNombreyApellido
            // 
            labelNombreyApellido.AutoSize = true;
            labelNombreyApellido.Location = new Point(11, 220);
            labelNombreyApellido.Margin = new Padding(2, 0, 2, 0);
            labelNombreyApellido.Name = "labelNombreyApellido";
            labelNombreyApellido.Size = new Size(135, 15);
            labelNombreyApellido.TabIndex = 124;
            labelNombreyApellido.Text = "[Nombre de la empresa]";
            // 
            // pronviciaCliente
            // 
            pronviciaCliente.AutoSize = true;
            pronviciaCliente.Location = new Point(11, 289);
            pronviciaCliente.Name = "pronviciaCliente";
            pronviciaCliente.Size = new Size(56, 15);
            pronviciaCliente.TabIndex = 123;
            pronviciaCliente.Text = "Provincia";
            // 
            // CBProvincia
            // 
            CBProvincia.FormattingEnabled = true;
            CBProvincia.Location = new Point(320, 330);
            CBProvincia.Name = "CBProvincia";
            CBProvincia.Size = new Size(232, 23);
            CBProvincia.TabIndex = 122;
            CBProvincia.SelectedIndexChanged += CBProvincia_SelectedIndexChanged;
            // 
            // localidadLBL
            // 
            localidadLBL.AutoSize = true;
            localidadLBL.Location = new Point(318, 363);
            localidadLBL.Name = "localidadLBL";
            localidadLBL.Size = new Size(58, 15);
            localidadLBL.TabIndex = 121;
            localidadLBL.Text = "Localidad";
            // 
            // CBTipoEntrega
            // 
            CBTipoEntrega.FormattingEnabled = true;
            CBTipoEntrega.Location = new Point(329, 145);
            CBTipoEntrega.Name = "CBTipoEntrega";
            CBTipoEntrega.Size = new Size(520, 23);
            CBTipoEntrega.TabIndex = 120;
            // 
            // Agencia
            // 
            Agencia.AutoSize = true;
            Agencia.Location = new Point(680, 425);
            Agencia.Name = "Agencia";
            Agencia.Size = new Size(0, 15);
            Agencia.TabIndex = 119;
            // 
            // CodigoPostalDestinatario
            // 
            CodigoPostalDestinatario.AutoSize = true;
            CodigoPostalDestinatario.Location = new Point(318, 412);
            CodigoPostalDestinatario.Name = "CodigoPostalDestinatario";
            CodigoPostalDestinatario.Size = new Size(81, 15);
            CodigoPostalDestinatario.TabIndex = 118;
            CodigoPostalDestinatario.Text = "Código Postal";
            // 
            // TBDDCP
            // 
            TBDDCP.Location = new Point(320, 430);
            TBDDCP.Name = "TBDDCP";
            TBDDCP.Size = new Size(232, 23);
            TBDDCP.TabIndex = 117;
            TBDDCP.TextChanged += TBDDCP_TextChanged;
            // 
            // CodidoPostal
            // 
            CodidoPostal.AutoSize = true;
            CodidoPostal.Location = new Point(11, 378);
            CodidoPostal.Name = "CodidoPostal";
            CodidoPostal.Size = new Size(81, 15);
            CodidoPostal.TabIndex = 116;
            CodidoPostal.Text = "Código Postal";
            // 
            // TipoPaquete
            // 
            TipoPaquete.AutoSize = true;
            TipoPaquete.Location = new Point(680, 219);
            TipoPaquete.Name = "TipoPaquete";
            TipoPaquete.Size = new Size(93, 15);
            TipoPaquete.TabIndex = 115;
            TipoPaquete.Text = "Tipo de Paquete";
            // 
            // CBTipoPaquete
            // 
            CBTipoPaquete.FormattingEnabled = true;
            CBTipoPaquete.Location = new Point(680, 237);
            CBTipoPaquete.Name = "CBTipoPaquete";
            CBTipoPaquete.Size = new Size(147, 23);
            CBTipoPaquete.TabIndex = 114;
            CBTipoPaquete.SelectedIndexChanged += CBTipoPaquete_SelectedIndexChanged;
            // 
            // Btn_Volver
            // 
            Btn_Volver.BackColor = Color.DarkRed;
            Btn_Volver.ForeColor = SystemColors.ButtonHighlight;
            Btn_Volver.Location = new Point(741, 576);
            Btn_Volver.Margin = new Padding(3, 2, 3, 2);
            Btn_Volver.Name = "Btn_Volver";
            Btn_Volver.Size = new Size(108, 32);
            Btn_Volver.TabIndex = 113;
            Btn_Volver.Text = "Cancelar/Volver";
            Btn_Volver.UseVisualStyleBackColor = false;
            Btn_Volver.Click += Btn_Volver_Click;
            // 
            // btn_Registrarcliente
            // 
            btn_Registrarcliente.BackColor = Color.Green;
            btn_Registrarcliente.ForeColor = SystemColors.ButtonHighlight;
            btn_Registrarcliente.Location = new Point(577, 575);
            btn_Registrarcliente.Margin = new Padding(2);
            btn_Registrarcliente.Name = "btn_Registrarcliente";
            btn_Registrarcliente.Size = new Size(156, 33);
            btn_Registrarcliente.TabIndex = 112;
            btn_Registrarcliente.Text = "Confirmar Imposición";
            btn_Registrarcliente.UseVisualStyleBackColor = false;
            btn_Registrarcliente.Click += btn_Registrarcliente_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(183, 144);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(91, 23);
            buttonBuscar.TabIndex = 111;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += ButtonBuscar_Click;
            // 
            // TBCliente
            // 
            TBCliente.Location = new Point(11, 144);
            TBCliente.Margin = new Padding(3, 2, 3, 2);
            TBCliente.Name = "TBCliente";
            TBCliente.Size = new Size(167, 23);
            TBCliente.TabIndex = 110;
            // 
            // lbl_BuscarCliente
            // 
            lbl_BuscarCliente.AutoSize = true;
            lbl_BuscarCliente.Font = new Font("Segoe UI", 12F);
            lbl_BuscarCliente.Location = new Point(11, 96);
            lbl_BuscarCliente.Margin = new Padding(2, 0, 2, 0);
            lbl_BuscarCliente.Name = "lbl_BuscarCliente";
            lbl_BuscarCliente.Size = new Size(108, 21);
            lbl_BuscarCliente.TabIndex = 109;
            lbl_BuscarCliente.Text = "Buscar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 125);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 108;
            label2.Text = "Ingrese DNI o CUIT";
            // 
            // TBDPDescripcion
            // 
            TBDPDescripcion.Location = new Point(680, 287);
            TBDPDescripcion.Margin = new Padding(3, 2, 3, 2);
            TBDPDescripcion.Name = "TBDPDescripcion";
            TBDPDescripcion.Size = new Size(147, 23);
            TBDPDescripcion.TabIndex = 107;
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Location = new Point(680, 270);
            lbl_Descripcion.Margin = new Padding(2, 0, 2, 0);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(69, 15);
            lbl_Descripcion.TabIndex = 106;
            lbl_Descripcion.Text = "Descripcion";
            // 
            // lbl_DetallePaquete
            // 
            lbl_DetallePaquete.AutoSize = true;
            lbl_DetallePaquete.Font = new Font("Segoe UI", 10F);
            lbl_DetallePaquete.Location = new Point(671, 182);
            lbl_DetallePaquete.Margin = new Padding(2, 0, 2, 0);
            lbl_DetallePaquete.Name = "lbl_DetallePaquete";
            lbl_DetallePaquete.Size = new Size(130, 19);
            lbl_DetallePaquete.TabIndex = 105;
            lbl_DetallePaquete.Text = "Detalles de Paquete";
            // 
            // lbl_TipoEntrega
            // 
            lbl_TipoEntrega.AutoSize = true;
            lbl_TipoEntrega.Location = new Point(329, 96);
            lbl_TipoEntrega.Margin = new Padding(2, 0, 2, 0);
            lbl_TipoEntrega.Name = "lbl_TipoEntrega";
            lbl_TipoEntrega.Size = new Size(90, 15);
            lbl_TipoEntrega.TabIndex = 104;
            lbl_TipoEntrega.Text = "Tipo de Entrega";
            // 
            // Rdb_CD
            // 
            Rdb_CD.AutoSize = true;
            Rdb_CD.Location = new Point(533, 121);
            Rdb_CD.Margin = new Padding(3, 2, 3, 2);
            Rdb_CD.Name = "Rdb_CD";
            Rdb_CD.Size = new Size(147, 19);
            Rdb_CD.TabIndex = 103;
            Rdb_CD.TabStop = true;
            Rdb_CD.Text = "Centro de Distribucion ";
            Rdb_CD.UseVisualStyleBackColor = true;
            Rdb_CD.CheckedChanged += Rdb_CD_CheckedChanged;
            // 
            // Rdb_Agencia
            // 
            Rdb_Agencia.AutoSize = true;
            Rdb_Agencia.Location = new Point(329, 121);
            Rdb_Agencia.Margin = new Padding(3, 2, 3, 2);
            Rdb_Agencia.Name = "Rdb_Agencia";
            Rdb_Agencia.Size = new Size(68, 19);
            Rdb_Agencia.TabIndex = 102;
            Rdb_Agencia.TabStop = true;
            Rdb_Agencia.Text = "Agencia";
            Rdb_Agencia.UseVisualStyleBackColor = true;
            Rdb_Agencia.CheckedChanged += Rdb_Agencia_CheckedChanged;
            // 
            // lbl_TelefonoDestinatario
            // 
            lbl_TelefonoDestinatario.AutoSize = true;
            lbl_TelefonoDestinatario.Location = new Point(322, 506);
            lbl_TelefonoDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_TelefonoDestinatario.Name = "lbl_TelefonoDestinatario";
            lbl_TelefonoDestinatario.Size = new Size(53, 15);
            lbl_TelefonoDestinatario.TabIndex = 101;
            lbl_TelefonoDestinatario.Text = "Telefono";
            // 
            // lbl_direccionDestinatario
            // 
            lbl_direccionDestinatario.AutoSize = true;
            lbl_direccionDestinatario.Location = new Point(320, 456);
            lbl_direccionDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_direccionDestinatario.Name = "lbl_direccionDestinatario";
            lbl_direccionDestinatario.Size = new Size(57, 15);
            lbl_direccionDestinatario.TabIndex = 100;
            lbl_direccionDestinatario.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 267);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 99;
            label4.Text = "DNI / CUIT";
            // 
            // TBDDTelefono
            // 
            TBDDTelefono.Location = new Point(320, 523);
            TBDDTelefono.Margin = new Padding(2);
            TBDDTelefono.Name = "TBDDTelefono";
            TBDDTelefono.Size = new Size(232, 23);
            TBDDTelefono.TabIndex = 98;
            // 
            // TBDDDireccion
            // 
            TBDDDireccion.Location = new Point(320, 475);
            TBDDDireccion.Margin = new Padding(2);
            TBDDDireccion.Name = "TBDDDireccion";
            TBDDDireccion.Size = new Size(232, 23);
            TBDDDireccion.TabIndex = 97;
            TBDDDireccion.TextChanged += TBDDDireccion_TextChanged_1;
            // 
            // TBDDDNI
            // 
            TBDDDNI.Location = new Point(320, 284);
            TBDDDNI.Margin = new Padding(2);
            TBDDDNI.Name = "TBDDDNI";
            TBDDDNI.Size = new Size(232, 23);
            TBDDDNI.TabIndex = 96;
            // 
            // TBDDNombre
            // 
            TBDDNombre.Location = new Point(320, 237);
            TBDDNombre.Margin = new Padding(2);
            TBDDNombre.Name = "TBDDNombre";
            TBDDNombre.Size = new Size(232, 23);
            TBDDNombre.TabIndex = 95;
            // 
            // lbl_NombreDestinatario
            // 
            lbl_NombreDestinatario.AutoSize = true;
            lbl_NombreDestinatario.Location = new Point(320, 211);
            lbl_NombreDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_NombreDestinatario.Name = "lbl_NombreDestinatario";
            lbl_NombreDestinatario.Size = new Size(161, 15);
            lbl_NombreDestinatario.TabIndex = 94;
            lbl_NombreDestinatario.Text = "Nombre y apellido / Empresa";
            // 
            // lbl_DatosDestinatario
            // 
            lbl_DatosDestinatario.AutoSize = true;
            lbl_DatosDestinatario.Font = new Font("Segoe UI", 10F);
            lbl_DatosDestinatario.Location = new Point(318, 182);
            lbl_DatosDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_DatosDestinatario.Name = "lbl_DatosDestinatario";
            lbl_DatosDestinatario.Size = new Size(142, 19);
            lbl_DatosDestinatario.TabIndex = 93;
            lbl_DatosDestinatario.Text = "Datos de Destinatario";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(11, 463);
            lbl_Telefono.Margin = new Padding(2, 0, 2, 0);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(53, 15);
            lbl_Telefono.TabIndex = 92;
            lbl_Telefono.Text = "Teléfono";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(11, 425);
            lbl_Direccion.Margin = new Padding(2, 0, 2, 0);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(57, 15);
            lbl_Direccion.TabIndex = 91;
            lbl_Direccion.Text = "Dirección";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 249);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 90;
            label7.Text = "DNI / CUIT";
            // 
            // lbl_DatosCliente
            // 
            lbl_DatosCliente.AutoSize = true;
            lbl_DatosCliente.Font = new Font("Segoe UI", 10F);
            lbl_DatosCliente.Location = new Point(11, 182);
            lbl_DatosCliente.Margin = new Padding(2, 0, 2, 0);
            lbl_DatosCliente.Name = "lbl_DatosCliente";
            lbl_DatosCliente.Size = new Size(110, 19);
            lbl_DatosCliente.TabIndex = 89;
            lbl_DatosCliente.Text = "Datos de Cliente";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(251, 18);
            label3.Name = "label3";
            label3.Size = new Size(507, 33);
            label3.TabIndex = 88;
            label3.Text = "-Imposicion de Encomienda por Agencia";
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(17, 18);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(150, 33);
            lbl_NameTutasa.TabIndex = 87;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 205);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 86;
            label1.Text = "Nombre y apellido / Nombre empresa";
            // 
            // ImposicionAgencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 619);
            Controls.Add(labelTelefonoCliente);
            Controls.Add(labelCPCliente);
            Controls.Add(labelDireccionCliente);
            Controls.Add(labelLocalidadCliente);
            Controls.Add(label9);
            Controls.Add(labelDNI);
            Controls.Add(provinciaLBL);
            Controls.Add(CBLocalidad);
            Controls.Add(Rdb_domicilio);
            Controls.Add(labelProvinciaCliente);
            Controls.Add(labelNombreyApellido);
            Controls.Add(pronviciaCliente);
            Controls.Add(CBProvincia);
            Controls.Add(localidadLBL);
            Controls.Add(CBTipoEntrega);
            Controls.Add(Agencia);
            Controls.Add(CodigoPostalDestinatario);
            Controls.Add(TBDDCP);
            Controls.Add(CodidoPostal);
            Controls.Add(TipoPaquete);
            Controls.Add(CBTipoPaquete);
            Controls.Add(Btn_Volver);
            Controls.Add(btn_Registrarcliente);
            Controls.Add(buttonBuscar);
            Controls.Add(TBCliente);
            Controls.Add(lbl_BuscarCliente);
            Controls.Add(label2);
            Controls.Add(TBDPDescripcion);
            Controls.Add(lbl_Descripcion);
            Controls.Add(lbl_DetallePaquete);
            Controls.Add(lbl_TipoEntrega);
            Controls.Add(Rdb_CD);
            Controls.Add(Rdb_Agencia);
            Controls.Add(lbl_TelefonoDestinatario);
            Controls.Add(lbl_direccionDestinatario);
            Controls.Add(label4);
            Controls.Add(TBDDTelefono);
            Controls.Add(TBDDDireccion);
            Controls.Add(TBDDDNI);
            Controls.Add(TBDDNombre);
            Controls.Add(lbl_NombreDestinatario);
            Controls.Add(lbl_DatosDestinatario);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Direccion);
            Controls.Add(label7);
            Controls.Add(lbl_DatosCliente);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(label1);
            Name = "ImposicionAgencia";
            Text = "Imposición en Agencia";
            Load += ImposicionAgencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label labelTelefonoCliente;
        private Label label12;
        private Label labelDireccionCliente;
        private Label labelLocalidadCliente;
        private Label label9;
        private Label labelDNI;
        private Label provinciaLBL;
        private ComboBox CBLocalidad;
        private RadioButton Rdb_domicilio;
        private Label labelProvinciaCliente;
        private Label labelNombreyApellido;
        private Label pronviciaCliente;
        private ComboBox CBProvincia;
        private Label localidadLBL;
        private ComboBox CBTipoEntrega;
        private Label Agencia;
        private Label CodigoPostalDestinatario;
        private TextBox TBDDCP;
        private Label CodidoPostal;
        private Label TipoPaquete;
        private ComboBox CBTipoPaquete;
        private Button Btn_Volver;
        private Button btn_Registrarcliente;
        private Button buttonBuscar;
        private TextBox TBCliente;
        private Label lbl_BuscarCliente;
        private Label label2;
        private TextBox TBDPDescripcion;
        private Label lbl_Descripcion;
        private Label lbl_DetallePaquete;
        private Label lbl_TipoEntrega;
        private RadioButton Rdb_CD;
        private RadioButton Rdb_Agencia;
        private Label lbl_TelefonoDestinatario;
        private Label lbl_direccionDestinatario;
        private Label label4;
        private TextBox TBDDTelefono;
        private TextBox TBDDDireccion;
        private TextBox textBox6;
        private TextBox TBDDNombre;
        private Label lbl_NombreDestinatario;
        private Label lbl_DatosDestinatario;
        private Label lbl_Telefono;
        private Label lbl_Direccion;
        private Label label7;
        private Label lbl_DatosCliente;
        private Label label3;
        public Label lbl_NameTutasa;
        private Label label1;
        private Label labelCPCliente;
        private TextBox TBDDDNI;
    }
}