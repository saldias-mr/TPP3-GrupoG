namespace TPP3_GrupoG.Entregas
{
    partial class Entregas
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
            lbl_IngreseDNI = new Label();
            listView1 = new ListView();
            Descripcion_Encomienda = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Guia = new ColumnHeader();
            lbl_Infoencomienda = new Label();
            button1 = new Button();
            button3 = new Button();
            Btn_Volver = new Button();
            lbl_NameTutasa = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            lbl_Advertencia = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblFechacEntrega = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 88);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 0;
            // 
            // lbl_IngreseDNI
            // 
            lbl_IngreseDNI.AutoSize = true;
            lbl_IngreseDNI.Font = new Font("Segoe UI", 10F);
            lbl_IngreseDNI.Location = new Point(19, 58);
            lbl_IngreseDNI.Margin = new Padding(2, 0, 2, 0);
            lbl_IngreseDNI.Name = "lbl_IngreseDNI";
            lbl_IngreseDNI.Size = new Size(140, 19);
            lbl_IngreseDNI.TabIndex = 1;
            lbl_IngreseDNI.Text = "Ingrese DNI Receptor";
            lbl_IngreseDNI.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Descripcion_Encomienda, Cantidad, Guia });
            listView1.Location = new Point(19, 174);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(427, 131);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Descripcion_Encomienda
            // 
            Descripcion_Encomienda.Text = "Descripcion_Encomienda";
            Descripcion_Encomienda.Width = 180;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 120;
            // 
            // Guia
            // 
            Guia.Text = "Guia";
            Guia.Width = 69;
            // 
            // lbl_Infoencomienda
            // 
            lbl_Infoencomienda.AutoSize = true;
            lbl_Infoencomienda.Font = new Font("Segoe UI", 12F);
            lbl_Infoencomienda.Location = new Point(19, 140);
            lbl_Infoencomienda.Margin = new Padding(2, 0, 2, 0);
            lbl_Infoencomienda.Name = "lbl_Infoencomienda";
            lbl_Infoencomienda.Size = new Size(204, 21);
            lbl_Infoencomienda.TabIndex = 3;
            lbl_Infoencomienda.Text = "Informacion de Encomienda";
            // 
            // button1
            // 
            button1.Location = new Point(242, 88);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(104, 20);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(598, 357);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(124, 38);
            button3.TabIndex = 6;
            button3.Text = "Confirmar entrega";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Btn_Volver
            // 
            Btn_Volver.BackColor = Color.DarkRed;
            Btn_Volver.ForeColor = SystemColors.ButtonHighlight;
            Btn_Volver.Location = new Point(744, 358);
            Btn_Volver.Margin = new Padding(3, 2, 3, 2);
            Btn_Volver.Name = "Btn_Volver";
            Btn_Volver.Size = new Size(108, 37);
            Btn_Volver.TabIndex = 7;
            Btn_Volver.Text = "Cancelar/Volver";
            Btn_Volver.UseVisualStyleBackColor = false;
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(19, 7);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(150, 35);
            lbl_NameTutasa.TabIndex = 8;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(230, 7);
            label3.Name = "label3";
            label3.Size = new Size(465, 35);
            label3.TabIndex = 9;
            label3.Text = "-Registro de Entrega en Agencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(497, 94);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 19);
            label5.TabIndex = 11;
            label5.Text = "Indentificacion de Destinatario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(665, 146);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(497, 146);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 15);
            label6.TabIndex = 13;
            label6.Text = "Ingrese DNI del Receptor ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(665, 190);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 23);
            textBox3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(497, 193);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(148, 15);
            label7.TabIndex = 15;
            label7.Text = "Ingrese Nombre y Apellido";
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(497, 287);
            checkBox1.Margin = new Padding(44, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(88, 0, 88, 0);
            checkBox1.Size = new Size(348, 22);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "¿Es persona Autorizada?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lbl_Advertencia
            // 
            lbl_Advertencia.AutoSize = true;
            lbl_Advertencia.BackColor = SystemColors.Info;
            lbl_Advertencia.Font = new Font("Segoe UI", 10F);
            lbl_Advertencia.Location = new Point(11, 332);
            lbl_Advertencia.Margin = new Padding(2, 0, 2, 0);
            lbl_Advertencia.Name = "lbl_Advertencia";
            lbl_Advertencia.Size = new Size(374, 19);
            lbl_Advertencia.TabIndex = 18;
            lbl_Advertencia.Text = "Advertencia. Se debe Validar DNI antes de Registrar Entrega";
            lbl_Advertencia.Click += lbl_Advertencia_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(497, 253);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(349, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // lblFechacEntrega
            // 
            lblFechacEntrega.Location = new Point(497, 226);
            lblFechacEntrega.Margin = new Padding(2, 0, 2, 0);
            lblFechacEntrega.Name = "lblFechacEntrega";
            lblFechacEntrega.Size = new Size(153, 24);
            lblFechacEntrega.TabIndex = 20;
            lblFechacEntrega.Text = "Ingrese Fecha de entrega";
            // 
            // Entregas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 407);
            Controls.Add(lblFechacEntrega);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_Advertencia);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(Btn_Volver);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(lbl_Infoencomienda);
            Controls.Add(listView1);
            Controls.Add(lbl_IngreseDNI);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "Entregas";
            Text = "Entregas";
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
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private CheckBox checkBox1;
        public Label lbl_Advertencia;
        private DateTimePicker dateTimePicker1;
        private Label lblFechacEntrega;
        private ColumnHeader Descripcion_Encomienda;
        private ColumnHeader Cantidad;
        private ColumnHeader Guia;
    }
}