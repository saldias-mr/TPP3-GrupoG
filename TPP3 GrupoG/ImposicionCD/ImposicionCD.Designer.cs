namespace TPP3_GrupoG.ImposicionCD
{
    partial class ImposicionCD
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
            lbl_NameTutasa = new Label();
            label3 = new Label();
            lbl_BuscarCliente = new Label();
            label2 = new Label();
            tbBuscarCliente = new TextBox();
            buttonBuscar = new Button();
            lbl_DatosCliente = new Label();
            label1 = new Label();
            lbDCNombre = new Label();
            label7 = new Label();
            lbDCDNI = new Label();
            pronviciaCliente = new Label();
            lbDCProvincia = new Label();
            label9 = new Label();
            lbDCLocalidad = new Label();
            CodidoPostal = new Label();
            lbDCCP = new Label();
            lbl_Direccion = new Label();
            lbDCDireccion = new Label();
            lbDCTelefono = new Label();
            lbl_Telefono = new Label();
            provinciaLBL = new Label();
            cbDDLocalidad = new ComboBox();
            cbDDProvincia = new ComboBox();
            localidadLBL = new Label();
            CodigoPostalDestinatario = new Label();
            tbDDCP = new TextBox();
            lbl_TelefonoDestinatario = new Label();
            lbl_direccionDestinatario = new Label();
            label4 = new Label();
            tbDDTelefono = new TextBox();
            tbDDDireccion = new TextBox();
            tbDDDNI = new TextBox();
            tbDDNombre = new TextBox();
            lbl_NombreDestinatario = new Label();
            lbl_DatosDestinatario = new Label();
            TipoPaquete = new Label();
            cbTipoPaquete = new ComboBox();
            lbl_DetallePaquete = new Label();
            Rdb_domicilio = new RadioButton();
            cbTipoEntrega = new ComboBox();
            Agencia = new Label();
            Btn_Volver = new Button();
            btn_Registrarcliente = new Button();
            lbl_TipoEntrega = new Label();
            Rdb_CD = new RadioButton();
            Rdb_Agencia = new RadioButton();
            lbl_Descripcion = new Label();
            tbDPDescripcion = new TextBox();
            SuspendLayout();
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(20, 14);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(150, 35);
            lbl_NameTutasa.TabIndex = 11;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(202, 14);
            label3.Name = "label3";
            label3.Size = new Size(507, 35);
            label3.TabIndex = 12;
            label3.Text = "-Imposicion de Encomienda por CD";
            // 
            // lbl_BuscarCliente
            // 
            lbl_BuscarCliente.AutoSize = true;
            lbl_BuscarCliente.Font = new Font("Segoe UI", 12F);
            lbl_BuscarCliente.Location = new Point(20, 77);
            lbl_BuscarCliente.Margin = new Padding(2, 0, 2, 0);
            lbl_BuscarCliente.Name = "lbl_BuscarCliente";
            lbl_BuscarCliente.Size = new Size(108, 21);
            lbl_BuscarCliente.TabIndex = 58;
            lbl_BuscarCliente.Text = "Buscar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 113);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 59;
            label2.Text = "Ingrese DNI";
            // 
            // tbBuscarCliente
            // 
            tbBuscarCliente.Location = new Point(20, 130);
            tbBuscarCliente.Margin = new Padding(3, 2, 3, 2);
            tbBuscarCliente.Name = "tbBuscarCliente";
            tbBuscarCliente.Size = new Size(167, 23);
            tbBuscarCliente.TabIndex = 60;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(191, 127);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(71, 25);
            buttonBuscar.TabIndex = 61;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // lbl_DatosCliente
            // 
            lbl_DatosCliente.AutoSize = true;
            lbl_DatosCliente.Font = new Font("Segoe UI", 10F);
            lbl_DatosCliente.Location = new Point(20, 175);
            lbl_DatosCliente.Margin = new Padding(2, 0, 2, 0);
            lbl_DatosCliente.Name = "lbl_DatosCliente";
            lbl_DatosCliente.Size = new Size(110, 19);
            lbl_DatosCliente.TabIndex = 62;
            lbl_DatosCliente.Text = "Datos de Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 203);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 63;
            label1.Text = "Nombre y apellido / Nombre empresa";
            // 
            // lbDCNombre
            // 
            lbDCNombre.AutoSize = true;
            lbDCNombre.Location = new Point(20, 218);
            lbDCNombre.Margin = new Padding(2, 0, 2, 0);
            lbDCNombre.Name = "lbDCNombre";
            lbDCNombre.Size = new Size(135, 15);
            lbDCNombre.TabIndex = 76;
            lbDCNombre.Text = "[Nombre de la empresa]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 253);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 77;
            label7.Text = "DNI / CUIT";
            // 
            // lbDCDNI
            // 
            lbDCDNI.AutoSize = true;
            lbDCDNI.Location = new Point(20, 268);
            lbDCDNI.Margin = new Padding(2, 0, 2, 0);
            lbDCDNI.Name = "lbDCDNI";
            lbDCDNI.Size = new Size(71, 15);
            lbDCDNI.TabIndex = 81;
            lbDCDNI.Text = "[XXXXXXXX]";
            // 
            // pronviciaCliente
            // 
            pronviciaCliente.AutoSize = true;
            pronviciaCliente.Location = new Point(20, 300);
            pronviciaCliente.Name = "pronviciaCliente";
            pronviciaCliente.Size = new Size(56, 15);
            pronviciaCliente.TabIndex = 82;
            pronviciaCliente.Text = "Provincia";
            // 
            // lbDCProvincia
            // 
            lbDCProvincia.AutoSize = true;
            lbDCProvincia.Location = new Point(20, 315);
            lbDCProvincia.Margin = new Padding(2, 0, 2, 0);
            lbDCProvincia.Name = "lbDCProvincia";
            lbDCProvincia.Size = new Size(83, 15);
            lbDCProvincia.TabIndex = 83;
            lbDCProvincia.Text = "[Buenos Aires]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 344);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 84;
            label9.Text = "Localidad";
            // 
            // lbDCLocalidad
            // 
            lbDCLocalidad.AutoSize = true;
            lbDCLocalidad.Location = new Point(20, 359);
            lbDCLocalidad.Margin = new Padding(2, 0, 2, 0);
            lbDCLocalidad.Name = "lbDCLocalidad";
            lbDCLocalidad.Size = new Size(66, 15);
            lbDCLocalidad.TabIndex = 85;
            lbDCLocalidad.Text = "[Localidad]";
            // 
            // CodidoPostal
            // 
            CodidoPostal.AutoSize = true;
            CodidoPostal.Location = new Point(20, 391);
            CodidoPostal.Name = "CodidoPostal";
            CodidoPostal.Size = new Size(81, 15);
            CodidoPostal.TabIndex = 86;
            CodidoPostal.Text = "Código Postal";
            // 
            // lbDCCP
            // 
            lbDCCP.AutoSize = true;
            lbDCCP.Location = new Point(20, 406);
            lbDCCP.Margin = new Padding(2, 0, 2, 0);
            lbDCCP.Name = "lbDCCP";
            lbDCCP.Size = new Size(43, 15);
            lbDCCP.TabIndex = 87;
            lbDCCP.Text = "[XXXX]";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(22, 437);
            lbl_Direccion.Margin = new Padding(2, 0, 2, 0);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(57, 15);
            lbl_Direccion.TabIndex = 88;
            lbl_Direccion.Text = "Dirección";
            // 
            // lbDCDireccion
            // 
            lbDCDireccion.AutoSize = true;
            lbDCDireccion.Location = new Point(22, 452);
            lbDCDireccion.Margin = new Padding(2, 0, 2, 0);
            lbDCDireccion.Name = "lbDCDireccion";
            lbDCDireccion.Size = new Size(65, 15);
            lbDCDireccion.TabIndex = 89;
            lbDCDireccion.Text = "[Dirección]";
            // 
            // lbDCTelefono
            // 
            lbDCTelefono.AutoSize = true;
            lbDCTelefono.Location = new Point(20, 500);
            lbDCTelefono.Margin = new Padding(2, 0, 2, 0);
            lbDCTelefono.Name = "lbDCTelefono";
            lbDCTelefono.Size = new Size(85, 15);
            lbDCTelefono.TabIndex = 91;
            lbDCTelefono.Text = "[XXXXXXXXXX]";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(20, 485);
            lbl_Telefono.Margin = new Padding(2, 0, 2, 0);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(53, 15);
            lbl_Telefono.TabIndex = 90;
            lbl_Telefono.Text = "Teléfono";
            // 
            // provinciaLBL
            // 
            provinciaLBL.AutoSize = true;
            provinciaLBL.Location = new Point(298, 306);
            provinciaLBL.Name = "provinciaLBL";
            provinciaLBL.Size = new Size(56, 15);
            provinciaLBL.TabIndex = 106;
            provinciaLBL.Text = "Provincia";
            // 
            // cbDDLocalidad
            // 
            cbDDLocalidad.FormattingEnabled = true;
            cbDDLocalidad.Location = new Point(299, 374);
            cbDDLocalidad.Name = "cbDDLocalidad";
            cbDDLocalidad.Size = new Size(232, 23);
            cbDDLocalidad.TabIndex = 105;
            cbDDLocalidad.SelectedIndexChanged += cbDDLocalidad_SelectedIndexChanged;
            // 
            // cbDDProvincia
            // 
            cbDDProvincia.FormattingEnabled = true;
            cbDDProvincia.Location = new Point(299, 323);
            cbDDProvincia.Name = "cbDDProvincia";
            cbDDProvincia.Size = new Size(232, 23);
            cbDDProvincia.TabIndex = 104;
            cbDDProvincia.SelectedIndexChanged += cbDDProvincia_SelectedIndexChanged;
            // 
            // localidadLBL
            // 
            localidadLBL.AutoSize = true;
            localidadLBL.Location = new Point(298, 356);
            localidadLBL.Name = "localidadLBL";
            localidadLBL.Size = new Size(58, 15);
            localidadLBL.TabIndex = 103;
            localidadLBL.Text = "Localidad";
            // 
            // CodigoPostalDestinatario
            // 
            CodigoPostalDestinatario.AutoSize = true;
            CodigoPostalDestinatario.Location = new Point(298, 405);
            CodigoPostalDestinatario.Name = "CodigoPostalDestinatario";
            CodigoPostalDestinatario.Size = new Size(81, 15);
            CodigoPostalDestinatario.TabIndex = 102;
            CodigoPostalDestinatario.Text = "Código Postal";
            // 
            // tbDDCP
            // 
            tbDDCP.Location = new Point(299, 423);
            tbDDCP.Name = "tbDDCP";
            tbDDCP.Size = new Size(232, 23);
            tbDDCP.TabIndex = 101;
            tbDDCP.TextChanged += tbDDCP_TextChanged;
            // 
            // lbl_TelefonoDestinatario
            // 
            lbl_TelefonoDestinatario.AutoSize = true;
            lbl_TelefonoDestinatario.Location = new Point(299, 494);
            lbl_TelefonoDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_TelefonoDestinatario.Name = "lbl_TelefonoDestinatario";
            lbl_TelefonoDestinatario.Size = new Size(53, 15);
            lbl_TelefonoDestinatario.TabIndex = 100;
            lbl_TelefonoDestinatario.Text = "Telefono";
            // 
            // lbl_direccionDestinatario
            // 
            lbl_direccionDestinatario.AutoSize = true;
            lbl_direccionDestinatario.Location = new Point(299, 451);
            lbl_direccionDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_direccionDestinatario.Name = "lbl_direccionDestinatario";
            lbl_direccionDestinatario.Size = new Size(57, 15);
            lbl_direccionDestinatario.TabIndex = 99;
            lbl_direccionDestinatario.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 260);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 98;
            label4.Text = "DNI / CUIT";
            // 
            // tbDDTelefono
            // 
            tbDDTelefono.Location = new Point(298, 511);
            tbDDTelefono.Margin = new Padding(2);
            tbDDTelefono.Name = "tbDDTelefono";
            tbDDTelefono.Size = new Size(232, 23);
            tbDDTelefono.TabIndex = 97;
            // 
            // tbDDDireccion
            // 
            tbDDDireccion.Location = new Point(298, 468);
            tbDDDireccion.Margin = new Padding(2);
            tbDDDireccion.Name = "tbDDDireccion";
            tbDDDireccion.Size = new Size(232, 23);
            tbDDDireccion.TabIndex = 96;
            tbDDDireccion.TextChanged += tbDDDireccion_TextChanged_1;
            // 
            // tbDDDNI
            // 
            tbDDDNI.Location = new Point(299, 277);
            tbDDDNI.Margin = new Padding(2);
            tbDDDNI.Name = "tbDDDNI";
            tbDDDNI.Size = new Size(232, 23);
            tbDDDNI.TabIndex = 95;
            // 
            // tbDDNombre
            // 
            tbDDNombre.Location = new Point(299, 221);
            tbDDNombre.Margin = new Padding(2);
            tbDDNombre.Name = "tbDDNombre";
            tbDDNombre.Size = new Size(232, 23);
            tbDDNombre.TabIndex = 94;
            // 
            // lbl_NombreDestinatario
            // 
            lbl_NombreDestinatario.AutoSize = true;
            lbl_NombreDestinatario.Location = new Point(299, 204);
            lbl_NombreDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_NombreDestinatario.Name = "lbl_NombreDestinatario";
            lbl_NombreDestinatario.Size = new Size(161, 15);
            lbl_NombreDestinatario.TabIndex = 93;
            lbl_NombreDestinatario.Text = "Nombre y apellido / Empresa";
            // 
            // lbl_DatosDestinatario
            // 
            lbl_DatosDestinatario.AutoSize = true;
            lbl_DatosDestinatario.Font = new Font("Segoe UI", 10F);
            lbl_DatosDestinatario.Location = new Point(298, 175);
            lbl_DatosDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_DatosDestinatario.Name = "lbl_DatosDestinatario";
            lbl_DatosDestinatario.Size = new Size(142, 19);
            lbl_DatosDestinatario.TabIndex = 92;
            lbl_DatosDestinatario.Text = "Datos de Destinatario";
            // 
            // TipoPaquete
            // 
            TipoPaquete.AutoSize = true;
            TipoPaquete.Location = new Point(603, 207);
            TipoPaquete.Name = "TipoPaquete";
            TipoPaquete.Size = new Size(93, 15);
            TipoPaquete.TabIndex = 111;
            TipoPaquete.Text = "Tipo de Paquete";
            // 
            // cbTipoPaquete
            // 
            cbTipoPaquete.FormattingEnabled = true;
            cbTipoPaquete.Location = new Point(603, 225);
            cbTipoPaquete.Name = "cbTipoPaquete";
            cbTipoPaquete.Size = new Size(147, 23);
            cbTipoPaquete.TabIndex = 110;
            cbTipoPaquete.SelectedIndexChanged += cbTipoPaquete_SelectedIndexChanged;
            // 
            // lbl_DetallePaquete
            // 
            lbl_DetallePaquete.AutoSize = true;
            lbl_DetallePaquete.Font = new Font("Segoe UI", 10F);
            lbl_DetallePaquete.Location = new Point(603, 175);
            lbl_DetallePaquete.Margin = new Padding(2, 0, 2, 0);
            lbl_DetallePaquete.Name = "lbl_DetallePaquete";
            lbl_DetallePaquete.Size = new Size(130, 19);
            lbl_DetallePaquete.TabIndex = 107;
            lbl_DetallePaquete.Text = "Detalles de Paquete";
            // 
            // Rdb_domicilio
            // 
            Rdb_domicilio.AutoSize = true;
            Rdb_domicilio.Location = new Point(664, 102);
            Rdb_domicilio.Margin = new Padding(3, 2, 3, 2);
            Rdb_domicilio.Name = "Rdb_domicilio";
            Rdb_domicilio.Size = new Size(86, 19);
            Rdb_domicilio.TabIndex = 119;
            Rdb_domicilio.TabStop = true;
            Rdb_domicilio.Text = "A domicilio";
            Rdb_domicilio.UseVisualStyleBackColor = true;
            Rdb_domicilio.CheckedChanged += Rdb_domicilio_CheckedChanged;
            // 
            // cbTipoEntrega
            // 
            cbTipoEntrega.FormattingEnabled = true;
            cbTipoEntrega.Location = new Point(299, 129);
            cbTipoEntrega.Name = "cbTipoEntrega";
            cbTipoEntrega.Size = new Size(451, 23);
            cbTipoEntrega.TabIndex = 118;
            // 
            // Agencia
            // 
            Agencia.AutoSize = true;
            Agencia.Location = new Point(308, 136);
            Agencia.Name = "Agencia";
            Agencia.Size = new Size(0, 15);
            Agencia.TabIndex = 117;
            // 
            // Btn_Volver
            // 
            Btn_Volver.BackColor = Color.DarkRed;
            Btn_Volver.ForeColor = SystemColors.ButtonHighlight;
            Btn_Volver.Location = new Point(642, 567);
            Btn_Volver.Margin = new Padding(3, 2, 3, 2);
            Btn_Volver.Name = "Btn_Volver";
            Btn_Volver.Size = new Size(108, 37);
            Btn_Volver.TabIndex = 116;
            Btn_Volver.Text = "Cancelar/Volver";
            Btn_Volver.UseVisualStyleBackColor = false;
            Btn_Volver.Click += Btn_Volver_Click;
            // 
            // btn_Registrarcliente
            // 
            btn_Registrarcliente.BackColor = Color.Green;
            btn_Registrarcliente.ForeColor = SystemColors.ButtonHighlight;
            btn_Registrarcliente.Location = new Point(467, 567);
            btn_Registrarcliente.Margin = new Padding(2);
            btn_Registrarcliente.Name = "btn_Registrarcliente";
            btn_Registrarcliente.Size = new Size(156, 38);
            btn_Registrarcliente.TabIndex = 115;
            btn_Registrarcliente.Text = "Confirmar Imposición";
            btn_Registrarcliente.UseVisualStyleBackColor = false;
            btn_Registrarcliente.Click += btn_Registrarcliente_Click;
            // 
            // lbl_TipoEntrega
            // 
            lbl_TipoEntrega.AutoSize = true;
            lbl_TipoEntrega.Location = new Point(299, 77);
            lbl_TipoEntrega.Margin = new Padding(2, 0, 2, 0);
            lbl_TipoEntrega.Name = "lbl_TipoEntrega";
            lbl_TipoEntrega.Size = new Size(90, 15);
            lbl_TipoEntrega.TabIndex = 114;
            lbl_TipoEntrega.Text = "Tipo de Entrega";
            // 
            // Rdb_CD
            // 
            Rdb_CD.AutoSize = true;
            Rdb_CD.Location = new Point(444, 102);
            Rdb_CD.Margin = new Padding(3, 2, 3, 2);
            Rdb_CD.Name = "Rdb_CD";
            Rdb_CD.Size = new Size(147, 19);
            Rdb_CD.TabIndex = 113;
            Rdb_CD.TabStop = true;
            Rdb_CD.Text = "Centro de Distribucion ";
            Rdb_CD.UseVisualStyleBackColor = true;
            Rdb_CD.CheckedChanged += Rdb_CD_CheckedChanged;
            // 
            // Rdb_Agencia
            // 
            Rdb_Agencia.AutoSize = true;
            Rdb_Agencia.Location = new Point(308, 102);
            Rdb_Agencia.Margin = new Padding(3, 2, 3, 2);
            Rdb_Agencia.Name = "Rdb_Agencia";
            Rdb_Agencia.Size = new Size(68, 19);
            Rdb_Agencia.TabIndex = 112;
            Rdb_Agencia.TabStop = true;
            Rdb_Agencia.Text = "Agencia";
            Rdb_Agencia.UseVisualStyleBackColor = true;
            Rdb_Agencia.CheckedChanged += Rdb_Agencia_CheckedChanged;
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Location = new Point(603, 258);
            lbl_Descripcion.Margin = new Padding(2, 0, 2, 0);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(69, 15);
            lbl_Descripcion.TabIndex = 108;
            lbl_Descripcion.Text = "Descripcion";
            // 
            // tbDPDescripcion
            // 
            tbDPDescripcion.Location = new Point(603, 275);
            tbDPDescripcion.Margin = new Padding(3, 2, 3, 2);
            tbDPDescripcion.Name = "tbDPDescripcion";
            tbDPDescripcion.Size = new Size(147, 23);
            tbDPDescripcion.TabIndex = 109;
            // 
            // ImposicionCD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 629);
            Controls.Add(Rdb_domicilio);
            Controls.Add(cbTipoEntrega);
            Controls.Add(Agencia);
            Controls.Add(Btn_Volver);
            Controls.Add(btn_Registrarcliente);
            Controls.Add(lbl_TipoEntrega);
            Controls.Add(Rdb_CD);
            Controls.Add(Rdb_Agencia);
            Controls.Add(TipoPaquete);
            Controls.Add(cbTipoPaquete);
            Controls.Add(tbDPDescripcion);
            Controls.Add(lbl_Descripcion);
            Controls.Add(lbl_DetallePaquete);
            Controls.Add(provinciaLBL);
            Controls.Add(cbDDLocalidad);
            Controls.Add(cbDDProvincia);
            Controls.Add(localidadLBL);
            Controls.Add(CodigoPostalDestinatario);
            Controls.Add(tbDDCP);
            Controls.Add(lbl_TelefonoDestinatario);
            Controls.Add(lbl_direccionDestinatario);
            Controls.Add(label4);
            Controls.Add(tbDDTelefono);
            Controls.Add(tbDDDireccion);
            Controls.Add(tbDDDNI);
            Controls.Add(tbDDNombre);
            Controls.Add(lbl_NombreDestinatario);
            Controls.Add(lbl_DatosDestinatario);
            Controls.Add(lbDCTelefono);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbDCDireccion);
            Controls.Add(lbl_Direccion);
            Controls.Add(lbDCCP);
            Controls.Add(CodidoPostal);
            Controls.Add(lbDCLocalidad);
            Controls.Add(label9);
            Controls.Add(lbDCProvincia);
            Controls.Add(pronviciaCliente);
            Controls.Add(lbDCDNI);
            Controls.Add(label7);
            Controls.Add(lbDCNombre);
            Controls.Add(label1);
            Controls.Add(lbl_DatosCliente);
            Controls.Add(buttonBuscar);
            Controls.Add(tbBuscarCliente);
            Controls.Add(label2);
            Controls.Add(lbl_BuscarCliente);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Margin = new Padding(2);
            Name = "ImposicionCD";
            Text = "ImposicionCD";
            Load += ImposicionCD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbl_NameTutasa;
        private Label label3;
        private Label lbl_BuscarCliente;
        private Label label2;
        private TextBox tbBuscarCliente;
        private Button buttonBuscar;
        private Label lbl_DatosCliente;
        private Label label1;
        private Label lbDCNombre;
        private Label label7;
        private Label lbDCDNI;
        private Label pronviciaCliente;
        private Label lbDCProvincia;
        private Label label9;
        private Label lbDCLocalidad;
        private Label CodidoPostal;
        private Label lbDCCP;
        private Label lbl_Direccion;
        private Label lbDCDireccion;
        private Label lbDCTelefono;
        private Label lbl_Telefono;
        private Label provinciaLBL;
        private ComboBox cbDDLocalidad;
        private ComboBox cbDDProvincia;
        private Label localidadLBL;
        private Label CodigoPostalDestinatario;
        private TextBox tbDDCP;
        private Label lbl_TelefonoDestinatario;
        private Label lbl_direccionDestinatario;
        private Label label4;
        private TextBox tbDDTelefono;
        private TextBox tbDDDireccion;
        private TextBox tbDDDNI;
        private TextBox tbDDNombre;
        private Label lbl_NombreDestinatario;
        private Label lbl_DatosDestinatario;
        private Label TipoPaquete;
        private ComboBox cbTipoPaquete;
        private Label lbl_DetallePaquete;
        private RadioButton Rdb_domicilio;
        private ComboBox cbTipoEntrega;
        private Label Agencia;
        private Button Btn_Volver;
        private Button btn_Registrarcliente;
        private Label lbl_TipoEntrega;
        private RadioButton Rdb_CD;
        private RadioButton Rdb_Agencia;
        private Label lbl_Descripcion;
        private TextBox tbDPDescripcion;
    }
}