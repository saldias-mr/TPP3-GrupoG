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
            textBox1 = new TextBox();
            label1 = new Label();
            lbl_NameTutasa = new Label();
            label3 = new Label();
            lbl_DatosCliente = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lbl_Direccion = new Label();
            lbl_Telefono = new Label();
            textBox4 = new TextBox();
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
            textBox9 = new TextBox();
            CodidoPostal = new Label();
            textBox10 = new TextBox();
            CodigoPostalDestinatario = new Label();
            Agencia = new Label();
            AgenciaCB = new ComboBox();
            provincialocalidadLBL = new Label();
            comboBox3 = new ComboBox();
            pronviciaCliente = new Label();
            CPCliente = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 226);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 200);
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
            lbl_DatosCliente.Location = new Point(29, 171);
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
            label7.Location = new Point(29, 322);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 23;
            label7.Text = "DNI / CUIT";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 339);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 385);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 23);
            textBox3.TabIndex = 25;
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(29, 368);
            lbl_Direccion.Margin = new Padding(2, 0, 2, 0);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(57, 15);
            lbl_Direccion.TabIndex = 26;
            lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(29, 414);
            lbl_Telefono.Margin = new Padding(2, 0, 2, 0);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(53, 15);
            lbl_Telefono.TabIndex = 27;
            lbl_Telefono.Text = "Telefono";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 430);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 23);
            textBox4.TabIndex = 28;
            // 
            // lbl_DatosDestinatario
            // 
            lbl_DatosDestinatario.AutoSize = true;
            lbl_DatosDestinatario.Font = new Font("Segoe UI", 10F);
            lbl_DatosDestinatario.Location = new Point(332, 69);
            lbl_DatosDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_DatosDestinatario.Name = "lbl_DatosDestinatario";
            lbl_DatosDestinatario.Size = new Size(142, 19);
            lbl_DatosDestinatario.TabIndex = 29;
            lbl_DatosDestinatario.Text = "Datos de Destinatario";
            // 
            // lbl_NombreDestinatario
            // 
            lbl_NombreDestinatario.AutoSize = true;
            lbl_NombreDestinatario.Location = new Point(323, 98);
            lbl_NombreDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_NombreDestinatario.Name = "lbl_NombreDestinatario";
            lbl_NombreDestinatario.Size = new Size(161, 15);
            lbl_NombreDestinatario.TabIndex = 30;
            lbl_NombreDestinatario.Text = "Nombre y apellido / Empresa";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(323, 124);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(232, 23);
            textBox5.TabIndex = 31;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(323, 171);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(232, 23);
            textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(323, 313);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(232, 23);
            textBox7.TabIndex = 33;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(323, 358);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(232, 23);
            textBox8.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 154);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 35;
            label4.Text = "DNI / CUIT";
            // 
            // lbl_direccionDestinatario
            // 
            lbl_direccionDestinatario.AutoSize = true;
            lbl_direccionDestinatario.Location = new Point(323, 296);
            lbl_direccionDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_direccionDestinatario.Name = "lbl_direccionDestinatario";
            lbl_direccionDestinatario.Size = new Size(57, 15);
            lbl_direccionDestinatario.TabIndex = 36;
            lbl_direccionDestinatario.Text = "Direccion";
            // 
            // lbl_TelefonoDestinatario
            // 
            lbl_TelefonoDestinatario.AutoSize = true;
            lbl_TelefonoDestinatario.Location = new Point(323, 342);
            lbl_TelefonoDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_TelefonoDestinatario.Name = "lbl_TelefonoDestinatario";
            lbl_TelefonoDestinatario.Size = new Size(53, 15);
            lbl_TelefonoDestinatario.TabIndex = 37;
            lbl_TelefonoDestinatario.Text = "Telefono";
            // 
            // Rdb_Agencia
            // 
            Rdb_Agencia.AutoSize = true;
            Rdb_Agencia.Location = new Point(652, 364);
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
            Rdb_CD.Location = new Point(731, 364);
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
            lbl_TipoEntrega.Location = new Point(652, 339);
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
            lbl_DetallePaquete.Location = new Point(652, 69);
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
            lbl_Descripcion.Location = new Point(661, 157);
            lbl_Descripcion.Margin = new Padding(2, 0, 2, 0);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(69, 15);
            lbl_Descripcion.TabIndex = 50;
            lbl_Descripcion.Text = "Descripcion";
            lbl_Descripcion.Click += lbl_Descripcion_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(661, 174);
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
            btn_Registrarcliente.Location = new Point(652, 489);
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
            Btn_Volver.Location = new Point(816, 490);
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
            comboBox1.Location = new Point(661, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 62;
            // 
            // TipoPaquete
            // 
            TipoPaquete.AutoSize = true;
            TipoPaquete.Location = new Point(661, 106);
            TipoPaquete.Name = "TipoPaquete";
            TipoPaquete.Size = new Size(93, 15);
            TipoPaquete.TabIndex = 63;
            TipoPaquete.Text = "Tipo de Paquete";
            TipoPaquete.Click += label5_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(29, 481);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(232, 23);
            textBox9.TabIndex = 64;
            // 
            // CodidoPostal
            // 
            CodidoPostal.AutoSize = true;
            CodidoPostal.Location = new Point(29, 463);
            CodidoPostal.Name = "CodidoPostal";
            CodidoPostal.Size = new Size(81, 15);
            CodidoPostal.TabIndex = 65;
            CodidoPostal.Text = "Código Postal";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(323, 264);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(232, 23);
            textBox10.TabIndex = 66;
            // 
            // CodigoPostalDestinatario
            // 
            CodigoPostalDestinatario.AutoSize = true;
            CodigoPostalDestinatario.Location = new Point(323, 246);
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
            AgenciaCB.Location = new Point(652, 398);
            AgenciaCB.Name = "AgenciaCB";
            AgenciaCB.Size = new Size(226, 23);
            AgenciaCB.TabIndex = 69;
            // 
            // provincialocalidadLBL
            // 
            provincialocalidadLBL.AutoSize = true;
            provincialocalidadLBL.Location = new Point(323, 200);
            provincialocalidadLBL.Name = "provincialocalidadLBL";
            provincialocalidadLBL.Size = new Size(112, 15);
            provincialocalidadLBL.TabIndex = 72;
            provincialocalidadLBL.Text = "Provincia/Localidad";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(323, 217);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(232, 23);
            comboBox3.TabIndex = 73;
            // 
            // pronviciaCliente
            // 
            pronviciaCliente.AutoSize = true;
            pronviciaCliente.Location = new Point(29, 264);
            pronviciaCliente.Name = "pronviciaCliente";
            pronviciaCliente.Size = new Size(112, 15);
            pronviciaCliente.TabIndex = 74;
            pronviciaCliente.Text = "Provincia/Localidad";
            pronviciaCliente.Click += label5_Click_1;
            // 
            // CPCliente
            // 
            CPCliente.Location = new Point(29, 288);
            CPCliente.Name = "CPCliente";
            CPCliente.Size = new Size(232, 23);
            CPCliente.TabIndex = 75;
            // 
            // ImposicionCallCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 538);
            Controls.Add(CPCliente);
            Controls.Add(pronviciaCliente);
            Controls.Add(comboBox3);
            Controls.Add(provincialocalidadLBL);
            Controls.Add(AgenciaCB);
            Controls.Add(Agencia);
            Controls.Add(CodigoPostalDestinatario);
            Controls.Add(textBox10);
            Controls.Add(CodidoPostal);
            Controls.Add(textBox9);
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
            Controls.Add(textBox4);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Direccion);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(lbl_DatosCliente);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "ImposicionCallCenter";
            Text = "ImposicionCallCenter";
            Load += ImposicionCallCenter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        public Label lbl_NameTutasa;
        private Label label3;
        private Label lbl_DatosCliente;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lbl_Direccion;
        private Label lbl_Telefono;
        private TextBox textBox4;
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
        private TextBox textBox9;
        private Label CodidoPostal;
        private TextBox textBox10;
        private Label CodigoPostalDestinatario;
        private Label Agencia;
        private ComboBox AgenciaCB;
        private Label CDCb;
        private ComboBox comboBox2;
        private Label provincialocalidadLBL;
        private ComboBox comboBox3;
        private Label pronviciaCliente;
        private TextBox CPCliente;
    }
}