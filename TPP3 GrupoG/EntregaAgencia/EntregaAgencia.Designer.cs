namespace TPP3_GrupoG.Entregas
{
    partial class EntregaAgencia
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
            lbl_IngreseDNI = new Label();
            listView1 = new ListView();
            numGuia = new ColumnHeader();
            cliente = new ColumnHeader();
            destinatario = new ColumnHeader();
            lbl_Infoencomienda = new Label();
            button1 = new Button();
            button3 = new Button();
            Btn_Volver = new Button();
            lbl_NameTutasa = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblFechacEntrega = new Label();
            imprimirComprobante = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // lbl_IngreseDNI
            // 
            lbl_IngreseDNI.AutoSize = true;
            lbl_IngreseDNI.Font = new Font("Segoe UI", 10F);
            lbl_IngreseDNI.Location = new Point(27, 118);
            lbl_IngreseDNI.Name = "lbl_IngreseDNI";
            lbl_IngreseDNI.Size = new Size(134, 28);
            lbl_IngreseDNI.TabIndex = 1;
            lbl_IngreseDNI.Text = " DNI Receptor";
            lbl_IngreseDNI.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { numGuia, cliente, destinatario });
            listView1.Location = new Point(27, 259);
            listView1.Name = "listView1";
            listView1.Size = new Size(330, 216);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // numGuia
            // 
            numGuia.Text = "Nº Guía";
            numGuia.Width = 90;
            // 
            // cliente
            // 
            cliente.Text = "Cliente";
            cliente.Width = 100;
            // 
            // destinatario
            // 
            destinatario.Text = "Destinatario";
            destinatario.Width = 110;
            // 
            // lbl_Infoencomienda
            // 
            lbl_Infoencomienda.AutoSize = true;
            lbl_Infoencomienda.Font = new Font("Segoe UI", 12F);
            lbl_Infoencomienda.Location = new Point(27, 224);
            lbl_Infoencomienda.Name = "lbl_Infoencomienda";
            lbl_Infoencomienda.Size = new Size(145, 32);
            lbl_Infoencomienda.TabIndex = 3;
            lbl_Infoencomienda.Text = "Encomienda";
            // 
            // button1
            // 
            button1.Location = new Point(346, 147);
            button1.Name = "button1";
            button1.Size = new Size(149, 33);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(27, 597);
            button3.Name = "button3";
            button3.Size = new Size(177, 63);
            button3.TabIndex = 6;
            button3.Text = "Confirmar entrega";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Btn_Volver
            // 
            Btn_Volver.BackColor = Color.DarkRed;
            Btn_Volver.ForeColor = SystemColors.ButtonHighlight;
            Btn_Volver.Location = new Point(372, 597);
            Btn_Volver.Margin = new Padding(4, 3, 4, 3);
            Btn_Volver.Name = "Btn_Volver";
            Btn_Volver.Size = new Size(154, 62);
            Btn_Volver.TabIndex = 7;
            Btn_Volver.Text = "Cancelar/Volver";
            Btn_Volver.UseVisualStyleBackColor = false;
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(27, 12);
            lbl_NameTutasa.Margin = new Padding(4, 0, 4, 0);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(214, 58);
            lbl_NameTutasa.TabIndex = 8;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(304, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(222, 38);
            label3.TabIndex = 9;
            label3.Text = "Registro de Entrega";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 539);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(330, 31);
            dateTimePicker1.TabIndex = 19;
            // 
            // lblFechacEntrega
            // 
            lblFechacEntrega.Location = new Point(27, 496);
            lblFechacEntrega.Name = "lblFechacEntrega";
            lblFechacEntrega.Size = new Size(219, 40);
            lblFechacEntrega.TabIndex = 20;
            lblFechacEntrega.Text = "Fecha de entrega";
            // 
            // imprimirComprobante
            // 
            imprimirComprobante.BackColor = Color.Yellow;
            imprimirComprobante.Location = new Point(222, 597);
            imprimirComprobante.Name = "imprimirComprobante";
            imprimirComprobante.Size = new Size(135, 63);
            imprimirComprobante.TabIndex = 21;
            imprimirComprobante.Text = "Imprimir comprobante";
            imprimirComprobante.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 31);
            textBox2.TabIndex = 22;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // EntregaAgencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 678);
            Controls.Add(textBox2);
            Controls.Add(imprimirComprobante);
            Controls.Add(lblFechacEntrega);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(Btn_Volver);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(lbl_Infoencomienda);
            Controls.Add(listView1);
            Controls.Add(lbl_IngreseDNI);
            Name = "EntregaAgencia";
            Text = "Entregas (Agencia)";
            Load += Entregas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lbl_IngreseDNI;
        private ListView listView1;
        private Label lbl_Infoencomienda;
        private Button button1;
        private Button button3;
        private Button Btn_Volver;
        public Label lbl_NameTutasa;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label lblFechacEntrega;
        private ColumnHeader numGuia;
        private ColumnHeader cliente;
        private ColumnHeader destinatario;
        private Button imprimirComprobante;
        private TextBox textBox2;
    }
}