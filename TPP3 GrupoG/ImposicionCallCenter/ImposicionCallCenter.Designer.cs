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
            rdb_Domicilio = new RadioButton();
            lbl_TipoEntrega = new Label();
            lbl_DetallePaquete = new Label();
            textBox9 = new TextBox();
            lbl_Pesokg = new Label();
            lbl_Largo = new Label();
            lbl_Ancho = new Label();
            lbl_alto = new Label();
            lbl_Descripcion = new Label();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            lbl_BuscarCliente = new Label();
            textBox14 = new TextBox();
            button1 = new Button();
            btn_Registrarcliente = new Button();
            Btn_Volver = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 199);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 164);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre y apellido / Nombre empresa";
            label1.Click += label1_Click;
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(33, 23);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(172, 47);
            lbl_NameTutasa.TabIndex = 10;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(259, 23);
            label3.Name = "label3";
            label3.Size = new Size(579, 47);
            label3.TabIndex = 11;
            label3.Text = "-Imposicion de Encomienda por CALL CENTER";
            // 
            // lbl_DatosCliente
            // 
            lbl_DatosCliente.AutoSize = true;
            lbl_DatosCliente.Font = new Font("Segoe UI", 10F);
            lbl_DatosCliente.Location = new Point(33, 92);
            lbl_DatosCliente.Margin = new Padding(2, 0, 2, 0);
            lbl_DatosCliente.Name = "lbl_DatosCliente";
            lbl_DatosCliente.Size = new Size(136, 23);
            lbl_DatosCliente.TabIndex = 22;
            lbl_DatosCliente.Text = "Datos de Cliente";
            lbl_DatosCliente.Click += lbl_IngreseDNI_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 239);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 23;
            label7.Text = "DNI / CUIT";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 261);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(33, 322);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 27);
            textBox3.TabIndex = 25;
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(33, 300);
            lbl_Direccion.Margin = new Padding(2, 0, 2, 0);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(72, 20);
            lbl_Direccion.TabIndex = 26;
            lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(33, 361);
            lbl_Telefono.Margin = new Padding(2, 0, 2, 0);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(67, 20);
            lbl_Telefono.TabIndex = 27;
            lbl_Telefono.Text = "Telefono";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(33, 383);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 28;
            // 
            // lbl_DatosDestinatario
            // 
            lbl_DatosDestinatario.AutoSize = true;
            lbl_DatosDestinatario.Font = new Font("Segoe UI", 10F);
            lbl_DatosDestinatario.Location = new Point(380, 92);
            lbl_DatosDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_DatosDestinatario.Name = "lbl_DatosDestinatario";
            lbl_DatosDestinatario.Size = new Size(175, 23);
            lbl_DatosDestinatario.TabIndex = 29;
            lbl_DatosDestinatario.Text = "Datos de Destinatario";
            // 
            // lbl_NombreDestinatario
            // 
            lbl_NombreDestinatario.AutoSize = true;
            lbl_NombreDestinatario.Location = new Point(369, 131);
            lbl_NombreDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_NombreDestinatario.Name = "lbl_NombreDestinatario";
            lbl_NombreDestinatario.Size = new Size(205, 20);
            lbl_NombreDestinatario.TabIndex = 30;
            lbl_NombreDestinatario.Text = "Nombre y apellido / Empresa";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(369, 166);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(264, 27);
            textBox5.TabIndex = 31;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(369, 228);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(264, 27);
            textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(369, 289);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(264, 27);
            textBox7.TabIndex = 33;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(369, 350);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(264, 27);
            textBox8.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 206);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 35;
            label4.Text = "DNI / CUIT";
            // 
            // lbl_direccionDestinatario
            // 
            lbl_direccionDestinatario.AutoSize = true;
            lbl_direccionDestinatario.Location = new Point(369, 267);
            lbl_direccionDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_direccionDestinatario.Name = "lbl_direccionDestinatario";
            lbl_direccionDestinatario.Size = new Size(72, 20);
            lbl_direccionDestinatario.TabIndex = 36;
            lbl_direccionDestinatario.Text = "Direccion";
            // 
            // lbl_TelefonoDestinatario
            // 
            lbl_TelefonoDestinatario.AutoSize = true;
            lbl_TelefonoDestinatario.Location = new Point(369, 328);
            lbl_TelefonoDestinatario.Margin = new Padding(2, 0, 2, 0);
            lbl_TelefonoDestinatario.Name = "lbl_TelefonoDestinatario";
            lbl_TelefonoDestinatario.Size = new Size(67, 20);
            lbl_TelefonoDestinatario.TabIndex = 37;
            lbl_TelefonoDestinatario.Text = "Telefono";
            // 
            // Rdb_Agencia
            // 
            Rdb_Agencia.AutoSize = true;
            Rdb_Agencia.Location = new Point(369, 423);
            Rdb_Agencia.Name = "Rdb_Agencia";
            Rdb_Agencia.Size = new Size(84, 24);
            Rdb_Agencia.TabIndex = 38;
            Rdb_Agencia.TabStop = true;
            Rdb_Agencia.Text = "Agencia";
            Rdb_Agencia.UseVisualStyleBackColor = true;
            // 
            // Rdb_CD
            // 
            Rdb_CD.AutoSize = true;
            Rdb_CD.Location = new Point(459, 423);
            Rdb_CD.Name = "Rdb_CD";
            Rdb_CD.Size = new Size(183, 24);
            Rdb_CD.TabIndex = 39;
            Rdb_CD.TabStop = true;
            Rdb_CD.Text = "Centro de Distribucion ";
            Rdb_CD.UseVisualStyleBackColor = true;
            // 
            // rdb_Domicilio
            // 
            rdb_Domicilio.AutoSize = true;
            rdb_Domicilio.Location = new Point(369, 453);
            rdb_Domicilio.Name = "rdb_Domicilio";
            rdb_Domicilio.Size = new Size(95, 24);
            rdb_Domicilio.TabIndex = 40;
            rdb_Domicilio.TabStop = true;
            rdb_Domicilio.Text = "Domicilio";
            rdb_Domicilio.UseVisualStyleBackColor = true;
            // 
            // lbl_TipoEntrega
            // 
            lbl_TipoEntrega.AutoSize = true;
            lbl_TipoEntrega.Location = new Point(369, 389);
            lbl_TipoEntrega.Margin = new Padding(2, 0, 2, 0);
            lbl_TipoEntrega.Name = "lbl_TipoEntrega";
            lbl_TipoEntrega.Size = new Size(115, 20);
            lbl_TipoEntrega.TabIndex = 41;
            lbl_TipoEntrega.Text = "Tipo de Entrega";
            // 
            // lbl_DetallePaquete
            // 
            lbl_DetallePaquete.AutoSize = true;
            lbl_DetallePaquete.Font = new Font("Segoe UI", 10F);
            lbl_DetallePaquete.Location = new Point(745, 92);
            lbl_DetallePaquete.Margin = new Padding(2, 0, 2, 0);
            lbl_DetallePaquete.Name = "lbl_DetallePaquete";
            lbl_DetallePaquete.Size = new Size(161, 23);
            lbl_DetallePaquete.TabIndex = 42;
            lbl_DetallePaquete.Text = "Detalles de Paquete";
            lbl_DetallePaquete.Click += label2_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(815, 166);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(91, 27);
            textBox9.TabIndex = 45;
            // 
            // lbl_Pesokg
            // 
            lbl_Pesokg.AutoSize = true;
            lbl_Pesokg.Location = new Point(730, 166);
            lbl_Pesokg.Margin = new Padding(2, 0, 2, 0);
            lbl_Pesokg.Name = "lbl_Pesokg";
            lbl_Pesokg.Size = new Size(67, 20);
            lbl_Pesokg.TabIndex = 46;
            lbl_Pesokg.Text = "Peso(Kg)";
            // 
            // lbl_Largo
            // 
            lbl_Largo.AutoSize = true;
            lbl_Largo.Location = new Point(730, 206);
            lbl_Largo.Margin = new Padding(2, 0, 2, 0);
            lbl_Largo.Name = "lbl_Largo";
            lbl_Largo.Size = new Size(47, 20);
            lbl_Largo.TabIndex = 47;
            lbl_Largo.Text = "Largo";
            // 
            // lbl_Ancho
            // 
            lbl_Ancho.AutoSize = true;
            lbl_Ancho.Location = new Point(730, 248);
            lbl_Ancho.Margin = new Padding(2, 0, 2, 0);
            lbl_Ancho.Name = "lbl_Ancho";
            lbl_Ancho.Size = new Size(51, 20);
            lbl_Ancho.TabIndex = 48;
            lbl_Ancho.Text = "Ancho";
            // 
            // lbl_alto
            // 
            lbl_alto.AutoSize = true;
            lbl_alto.Location = new Point(730, 292);
            lbl_alto.Margin = new Padding(2, 0, 2, 0);
            lbl_alto.Name = "lbl_alto";
            lbl_alto.Size = new Size(37, 20);
            lbl_alto.TabIndex = 49;
            lbl_alto.Text = "Alto";
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Location = new Point(730, 338);
            lbl_Descripcion.Margin = new Padding(2, 0, 2, 0);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(87, 20);
            lbl_Descripcion.TabIndex = 50;
            lbl_Descripcion.Text = "Descripcion";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(815, 248);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(91, 27);
            textBox10.TabIndex = 51;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(815, 206);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(91, 27);
            textBox11.TabIndex = 52;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(815, 292);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(91, 27);
            textBox12.TabIndex = 53;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(730, 372);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(176, 27);
            textBox13.TabIndex = 54;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(33, 127);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 24);
            checkBox1.TabIndex = 55;
            checkBox1.Text = "¿Existe el Cliente?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 453);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 56;
            label2.Text = "Ingrese DNI";
            // 
            // lbl_BuscarCliente
            // 
            lbl_BuscarCliente.AutoSize = true;
            lbl_BuscarCliente.Font = new Font("Segoe UI", 12F);
            lbl_BuscarCliente.Location = new Point(33, 423);
            lbl_BuscarCliente.Margin = new Padding(2, 0, 2, 0);
            lbl_BuscarCliente.Name = "lbl_BuscarCliente";
            lbl_BuscarCliente.Size = new Size(133, 28);
            lbl_BuscarCliente.TabIndex = 57;
            lbl_BuscarCliente.Text = "Buscar Cliente";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(33, 480);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(190, 27);
            textBox14.TabIndex = 58;
            // 
            // button1
            // 
            button1.Location = new Point(228, 480);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(69, 27);
            button1.TabIndex = 59;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_Registrarcliente
            // 
            btn_Registrarcliente.BackColor = Color.Green;
            btn_Registrarcliente.ForeColor = SystemColors.ButtonHighlight;
            btn_Registrarcliente.Location = new Point(610, 471);
            btn_Registrarcliente.Margin = new Padding(2);
            btn_Registrarcliente.Name = "btn_Registrarcliente";
            btn_Registrarcliente.Size = new Size(142, 50);
            btn_Registrarcliente.TabIndex = 60;
            btn_Registrarcliente.Text = "Registrar Cliente";
            btn_Registrarcliente.UseVisualStyleBackColor = false;
            // 
            // Btn_Volver
            // 
            Btn_Volver.BackColor = Color.DarkRed;
            Btn_Volver.ForeColor = SystemColors.ButtonHighlight;
            Btn_Volver.Location = new Point(782, 469);
            Btn_Volver.Name = "Btn_Volver";
            Btn_Volver.Size = new Size(124, 49);
            Btn_Volver.TabIndex = 61;
            Btn_Volver.Text = "Cancelar/Volver";
            Btn_Volver.UseVisualStyleBackColor = false;
            // 
            // ImposicionCallCenter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 532);
            Controls.Add(Btn_Volver);
            Controls.Add(btn_Registrarcliente);
            Controls.Add(button1);
            Controls.Add(textBox14);
            Controls.Add(lbl_BuscarCliente);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(lbl_Descripcion);
            Controls.Add(lbl_alto);
            Controls.Add(lbl_Ancho);
            Controls.Add(lbl_Largo);
            Controls.Add(lbl_Pesokg);
            Controls.Add(textBox9);
            Controls.Add(lbl_DetallePaquete);
            Controls.Add(lbl_TipoEntrega);
            Controls.Add(rdb_Domicilio);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "ImposicionCallCenter";
            Text = "ImposicionCallCenter";
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
        private RadioButton rdb_Domicilio;
        private Label lbl_TipoEntrega;
        private Label lbl_DetallePaquete;
        private TextBox textBox9;
        private Label lbl_Pesokg;
        private Label lbl_Largo;
        private Label lbl_Ancho;
        private Label lbl_alto;
        private Label lbl_Descripcion;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private CheckBox checkBox1;
        private Label label2;
        private Label lbl_BuscarCliente;
        private TextBox textBox14;
        private Button button1;
        private Button btn_Registrarcliente;
        private Button Btn_Volver;
    }
}