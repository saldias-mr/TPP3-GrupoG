namespace TPP3_GrupoG.ImposicionCallCenter
{
    partial class ImposicionCallCenter
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
            label1 = new Label();
            lbl_NameTutasa = new Label();
            label3 = new Label();
            lbl_DatosCliente = new Label();
            label7 = new Label();
            lbl_Direccion = new Label();
            lbl_Telefono = new Label();
            lbl_DatosDestinatario = new Label();
            lbl_NombreDestinatario = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label4 = new Label();
            lbl_direccionDestinatario = new Label();
            lbl_TelefonoDestinatario = new Label();
            Rdb_Agencia = new RadioButton();
            Rdb_CD = new RadioButton();
            lbl_TipoEntrega = new Label();
            lbl_DetallePaquete = new Label();
            lbl_Descripcion = new Label();
            textBox13 = new TextBox();
            label2 = new Label();
            lbl_BuscarCliente = new Label();
            textBox14 = new TextBox();
            button1 = new Button();
            btn_Registrarcliente = new Button();
            Btn_Volver = new Button();
            comboBox1 = new ComboBox();
            TipoPaquete = new Label();
            CodidoPostal = new Label();
            textBox10 = new TextBox();
            CodigoPostalDestinatario = new Label();
            Agencia = new Label();
            AgenciaCB = new ComboBox();
            localidadLBL = new Label();
            comboBox3 = new ComboBox();
            pronviciaCliente = new Label();
            label5 = new Label();
            label6 = new Label();
            Rdb_domicilio = new RadioButton();
            comboBox2 = new ComboBox();
            provinciaLBL = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 178);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre y apellido / Nombre empresa";
            label1.Click += label1_Click;
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(29, 17);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(150, 35);
            lbl_NameTutasa.TabIndex = 10;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(247, 9);
            label3.Name = "label3";
            label3.Size = new Size(507, 35);
            label3.TabIndex = 11;
            label3.Text = "-Imposicion de Encomienda por CALL CENTER";
            // 
            // lbl_DatosCliente
            // 
            lbl_DatosCliente.AutoSize = true;
            lbl_DatosCliente.Font = new Font("Segoe UI", 10F);
            lbl_DatosCliente.Location = new Point(29, 155);
            lbl_DatosCliente.Margin = new Padding(2, 0, 2, 0);
            lbl_DatosCliente.Name = "lbl_DatosCliente";
            lbl_DatosCliente.Size = new Size(110, 19);
            lbl_DatosCliente.TabIndex = 22;
            lbl_DatosCliente.Text = "Datos de Cliente";
            lbl_DatosCliente.Click += lbl_IngreseDNI_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 222);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 23;
            label7.Text = "DNI / CUIT";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(29, 398);
            lbl_Direccion.Margin = new Padding(2, 0, 2, 0);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(57, 15);
            lbl_Direccion.TabIndex = 26;
            lbl_Direccion.Text = "Dirección";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(29, 436);
            lbl_Telefono.Margin = new Padding(2, 0, 2, 0);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(53, 15);
            lbl_Telefono.TabIndex = 27;
            lbl_Telefono.Text = "Teléfono";
            // 
            // lbl_DatosDestinatario
            // 
            lbl_DatosDestinatario.AutoSize = true;
            lbl_DatosDestinatario.Font = new Font("Segoe UI", 10F);
            lbl_DatosDestinatario.Location = new Point(317, 155);
            lbl_DatosDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_DatosDestinatario.Name = "lbl_DatosDestinatario";
            lbl_DatosDestinatario.Size = new Size(142, 19);
            lbl_DatosDestinatario.TabIndex = 29;
            lbl_DatosDestinatario.Text = "Datos de Destinatario";
            // 
            // lbl_NombreDestinatario
            // 
            lbl_NombreDestinatario.AutoSize = true;
            lbl_NombreDestinatario.Location = new Point(308, 184);
            lbl_NombreDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_NombreDestinatario.Name = "lbl_NombreDestinatario";
            lbl_NombreDestinatario.Size = new Size(161, 15);
            lbl_NombreDestinatario.TabIndex = 30;
            lbl_NombreDestinatario.Text = "Nombre y apellido / Empresa";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(308, 201);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(232, 23);
            textBox5.TabIndex = 31;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(308, 257);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(232, 23);
            textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(306, 448);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(232, 23);
            textBox7.TabIndex = 33;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(306, 491);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(232, 23);
            textBox8.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 240);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 35;
            label4.Text = "DNI / CUIT";
            // 
            // lbl_direccionDestinatario
            // 
            lbl_direccionDestinatario.AutoSize = true;
            lbl_direccionDestinatario.Location = new Point(308, 431);
            lbl_direccionDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_direccionDestinatario.Name = "lbl_direccionDestinatario";
            lbl_direccionDestinatario.Size = new Size(57, 15);
            lbl_direccionDestinatario.TabIndex = 36;
            lbl_direccionDestinatario.Text = "Direccion";
            // 
            // lbl_TelefonoDestinatario
            // 
            lbl_TelefonoDestinatario.AutoSize = true;
            lbl_TelefonoDestinatario.Location = new Point(308, 474);
            lbl_TelefonoDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_TelefonoDestinatario.Name = "lbl_TelefonoDestinatario";
            lbl_TelefonoDestinatario.Size = new Size(53, 15);
            lbl_TelefonoDestinatario.TabIndex = 37;
            lbl_TelefonoDestinatario.Text = "Telefono";
            // 
            // Rdb_Agencia
            // 
            Rdb_Agencia.AutoSize = true;
            Rdb_Agencia.Location = new Point(324, 94);
            Rdb_Agencia.Margin = new Padding(3, 2, 3, 2);
            Rdb_Agencia.Name = "Rdb_Agencia";
            Rdb_Agencia.Size = new Size(68, 19);
            Rdb_Agencia.TabIndex = 38;
            Rdb_Agencia.TabStop = true;
            Rdb_Agencia.Text = "Agencia";
            Rdb_Agencia.UseVisualStyleBackColor = true;
            // 
            // Rdb_CD
            // 
            Rdb_CD.AutoSize = true;
            Rdb_CD.Location = new Point(413, 94);
            Rdb_CD.Margin = new Padding(3, 2, 3, 2);
            Rdb_CD.Name = "Rdb_CD";
            Rdb_CD.Size = new Size(147, 19);
            Rdb_CD.TabIndex = 39;
            Rdb_CD.TabStop = true;
            Rdb_CD.Text = "Centro de Distribucion ";
            Rdb_CD.UseVisualStyleBackColor = true;
            // 
            // lbl_TipoEntrega
            // 
            lbl_TipoEntrega.AutoSize = true;
            lbl_TipoEntrega.Location = new Point(317, 71);
            lbl_TipoEntrega.Margin = new Padding(2, 0, 2, 0);
            lbl_TipoEntrega.Name = "lbl_TipoEntrega";
            lbl_TipoEntrega.Size = new Size(90, 15);
            lbl_TipoEntrega.TabIndex = 41;
            lbl_TipoEntrega.Text = "Tipo de Entrega";
            lbl_TipoEntrega.Click += lbl_TipoEntrega_Click;
            // 
            // lbl_DetallePaquete
            // 
            lbl_DetallePaquete.AutoSize = true;
            lbl_DetallePaquete.Font = new Font("Segoe UI", 10F);
            lbl_DetallePaquete.Location = new Point(642, 155);
            lbl_DetallePaquete.Margin = new Padding(2, 0, 2, 0);
            lbl_DetallePaquete.Name = "lbl_DetallePaquete";
            lbl_DetallePaquete.Size = new Size(130, 19);
            lbl_DetallePaquete.TabIndex = 42;
            lbl_DetallePaquete.Text = "Detalles de Paquete";
            lbl_DetallePaquete.Click += label2_Click;
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Location = new Point(642, 243);
            lbl_Descripcion.Margin = new Padding(2, 0, 2, 0);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(69, 15);
            lbl_Descripcion.TabIndex = 50;
            lbl_Descripcion.Text = "Descripcion";
            lbl_Descripcion.Click += lbl_Descripcion_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(642, 260);
            textBox13.Margin = new Padding(3, 2, 3, 2);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(147, 23);
            textBox13.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 56;
            label2.Text = "Ingrese DNI";
            // 
            // lbl_BuscarCliente
            // 
            lbl_BuscarCliente.AutoSize = true;
            lbl_BuscarCliente.Font = new Font("Segoe UI", 12F);
            lbl_BuscarCliente.Location = new Point(29, 69);
            lbl_BuscarCliente.Margin = new Padding(2, 0, 2, 0);
            lbl_BuscarCliente.Name = "lbl_BuscarCliente";
            lbl_BuscarCliente.Size = new Size(108, 21);
            lbl_BuscarCliente.TabIndex = 57;
            lbl_BuscarCliente.Text = "Buscar Cliente";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(29, 117);
            textBox14.Margin = new Padding(3, 2, 3, 2);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(167, 23);
            textBox14.TabIndex = 58;
            // 
            // button1
            // 
            button1.Location = new Point(201, 117);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(71, 25);
            button1.TabIndex = 59;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_Registrarcliente
            // 
            btn_Registrarcliente.BackColor = Color.Green;
            btn_Registrarcliente.ForeColor = SystemColors.ButtonHighlight;
            btn_Registrarcliente.Location = new Point(536, 577);
            btn_Registrarcliente.Margin = new Padding(2);
            btn_Registrarcliente.Name = "btn_Registrarcliente";
            btn_Registrarcliente.Size = new Size(156, 38);
            btn_Registrarcliente.TabIndex = 60;
            btn_Registrarcliente.Text = "Confirmar Imposición";
            btn_Registrarcliente.UseVisualStyleBackColor = false;
            // 
            // Btn_Volver
            // 
            Btn_Volver.BackColor = Color.DarkRed;
            Btn_Volver.ForeColor = SystemColors.ButtonHighlight;
            Btn_Volver.Location = new Point(700, 578);
            Btn_Volver.Margin = new Padding(3, 2, 3, 2);
            Btn_Volver.Name = "Btn_Volver";
            Btn_Volver.Size = new Size(108, 37);
            Btn_Volver.TabIndex = 61;
            Btn_Volver.Text = "Cancelar/Volver";
            Btn_Volver.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(642, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 62;
            // 
            // TipoPaquete
            // 
            TipoPaquete.AutoSize = true;
            TipoPaquete.Location = new Point(642, 192);
            TipoPaquete.Name = "TipoPaquete";
            TipoPaquete.Size = new Size(93, 15);
            TipoPaquete.TabIndex = 63;
            TipoPaquete.Text = "Tipo de Paquete";
            TipoPaquete.Click += label5_Click;
            // 
            // CodidoPostal
            // 
            CodidoPostal.AutoSize = true;
            CodidoPostal.Location = new Point(29, 351);
            CodidoPostal.Name = "CodidoPostal";
            CodidoPostal.Size = new Size(81, 15);
            CodidoPostal.TabIndex = 65;
            CodidoPostal.Text = "Código Postal";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(308, 403);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(232, 23);
            textBox10.TabIndex = 66;
            // 
            // CodigoPostalDestinatario
            // 
            CodigoPostalDestinatario.AutoSize = true;
            CodigoPostalDestinatario.Location = new Point(306, 385);
            CodigoPostalDestinatario.Name = "CodigoPostalDestinatario";
            CodigoPostalDestinatario.Size = new Size(81, 15);
            CodigoPostalDestinatario.TabIndex = 67;
            CodigoPostalDestinatario.Text = "Código Postal";
            // 
            // Agencia
            // 
            Agencia.AutoSize = true;
            Agencia.Location = new Point(652, 398);
            Agencia.Name = "Agencia";
            Agencia.Size = new Size(0, 15);
            Agencia.TabIndex = 68;
            // 
            // AgenciaCB
            // 
            AgenciaCB.FormattingEnabled = true;
            AgenciaCB.Location = new Point(317, 117);
            AgenciaCB.Name = "AgenciaCB";
            AgenciaCB.Size = new Size(472, 23);
            AgenciaCB.TabIndex = 69;
            // 
            // localidadLBL
            // 
            localidadLBL.AutoSize = true;
            localidadLBL.Location = new Point(306, 336);
            localidadLBL.Name = "localidadLBL";
            localidadLBL.Size = new Size(58, 15);
            localidadLBL.TabIndex = 72;
            localidadLBL.Text = "Localidad";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(308, 303);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(232, 23);
            comboBox3.TabIndex = 73;
            // 
            // pronviciaCliente
            // 
            pronviciaCliente.AutoSize = true;
            pronviciaCliente.Location = new Point(29, 262);
            pronviciaCliente.Name = "pronviciaCliente";
            pronviciaCliente.Size = new Size(56, 15);
            pronviciaCliente.TabIndex = 74;
            pronviciaCliente.Text = "Provincia";
            pronviciaCliente.Click += label5_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 193);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 75;
            label5.Text = "[Nombre de la empresa]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 277);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 76;
            label6.Text = "[Buenos Aires]";
            // 
            // Rdb_domicilio
            // 
            Rdb_domicilio.AutoSize = true;
            Rdb_domicilio.Location = new Point(580, 94);
            Rdb_domicilio.Margin = new Padding(3, 2, 3, 2);
            Rdb_domicilio.Name = "Rdb_domicilio";
            Rdb_domicilio.Size = new Size(86, 19);
            Rdb_domicilio.TabIndex = 77;
            Rdb_domicilio.TabStop = true;
            Rdb_domicilio.Text = "A domicilio";
            Rdb_domicilio.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(308, 354);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(232, 23);
            comboBox2.TabIndex = 78;
            // 
            // provinciaLBL
            // 
            provinciaLBL.AutoSize = true;
            provinciaLBL.Location = new Point(306, 286);
            provinciaLBL.Name = "provinciaLBL";
            provinciaLBL.Size = new Size(56, 15);
            provinciaLBL.TabIndex = 79;
            provinciaLBL.Text = "Provincia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 237);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 80;
            label8.Text = "[XXXXXXXX]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 305);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 81;
            label9.Text = "Localidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 321);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 82;
            label10.Text = "[Localidad]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 413);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(65, 15);
            label11.TabIndex = 83;
            label11.Text = "[Dirección]";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 365);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 84;
            label12.Text = "[XXXX]";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 451);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 85;
            label13.Text = "[XXXXXXXXXX]";
            // 
            // ImposicionCallCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 626);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(provinciaLBL);
            Controls.Add(comboBox2);
            Controls.Add(Rdb_domicilio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pronviciaCliente);
            Controls.Add(comboBox3);
            Controls.Add(localidadLBL);
            Controls.Add(AgenciaCB);
            Controls.Add(Agencia);
            Controls.Add(CodigoPostalDestinatario);
            Controls.Add(textBox10);
            Controls.Add(CodidoPostal);
            Controls.Add(TipoPaquete);
            Controls.Add(comboBox1);
            Controls.Add(Btn_Volver);
            Controls.Add(btn_Registrarcliente);
            Controls.Add(button1);
            Controls.Add(textBox14);
            Controls.Add(lbl_BuscarCliente);
            Controls.Add(label2);
            Controls.Add(textBox13);
            Controls.Add(lbl_Descripcion);
            Controls.Add(lbl_DetallePaquete);
            Controls.Add(lbl_TipoEntrega);
            Controls.Add(Rdb_CD);
            Controls.Add(Rdb_Agencia);
            Controls.Add(lbl_TelefonoDestinatario);
            Controls.Add(lbl_direccionDestinatario);
            Controls.Add(label4);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(lbl_NombreDestinatario);
            Controls.Add(lbl_DatosDestinatario);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Direccion);
            Controls.Add(label7);
            Controls.Add(lbl_DatosCliente);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ImposicionCallCenter";
            Text = "ImposicionCallCenter";
            Load += ImposicionCallCenter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public Label lbl_NameTutasa;
        private Label label3;
        private Label lbl_DatosCliente;
        private Label label7;
        private Label lbl_Direccion;
        private Label lbl_Telefono;
        private Label lbl_DatosDestinatario;
        private Label lbl_NombreDestinatario;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label4;
        private Label lbl_direccionDestinatario;
        private Label lbl_TelefonoDestinatario;
        private RadioButton Rdb_Agencia;
        private RadioButton Rdb_CD;
        private Label lbl_TipoEntrega;
        private Label lbl_DetallePaquete;
        private Label lbl_Descripcion;
        private TextBox textBox13;
        private Label label2;
        private Label lbl_BuscarCliente;
        private TextBox textBox14;
        private Button button1;
        private Button btn_Registrarcliente;
        private Button Btn_Volver;
        private ComboBox comboBox1;
        private Label TipoPaquete;
        private Label CodidoPostal;
        private TextBox textBox10;
        private Label CodigoPostalDestinatario;
        private Label Agencia;
        private ComboBox AgenciaCB;
        private Label CDCb;
        private ComboBox comboBox2;
        private Label localidadLBL;
        private ComboBox comboBox3;
        private Label pronviciaCliente;
        private Label label5;
        private Label label6;
        private RadioButton Rdb_domicilio;
        private Label provinciaLBL;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}