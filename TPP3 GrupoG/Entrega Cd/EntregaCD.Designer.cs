namespace TPP3_GrupoG.Entrega_Cd
{
    partial class EntregaCD
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
            button3 = new Button();
            Btn_Volver = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblFechacEntrega = new Label();
            checkBox1 = new CheckBox();
            lbl_IngreseDNI = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            lbl_Infoencomienda = new Label();
            lvw_InfoEncomienda = new ListView();
            Cantidad = new ColumnHeader("(ninguna)");
            Descripcion_Producto = new ColumnHeader();
            Guia = new ColumnHeader();
            SuspendLayout();
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(24, 21);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(172, 47);
            lbl_NameTutasa.TabIndex = 9;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(255, 21);
            label3.Name = "label3";
            label3.Size = new Size(579, 47);
            label3.TabIndex = 10;
            label3.Text = "-Registro de Entrega en Centro De Distribucion ";
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(527, 374);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(142, 50);
            button3.TabIndex = 11;
            button3.Text = "Confirmar entrega";
            button3.UseVisualStyleBackColor = false;
            // 
            // Btn_Volver
            // 
            Btn_Volver.BackColor = Color.DarkRed;
            Btn_Volver.ForeColor = SystemColors.ButtonHighlight;
            Btn_Volver.Location = new Point(710, 374);
            Btn_Volver.Name = "Btn_Volver";
            Btn_Volver.Size = new Size(124, 49);
            Btn_Volver.TabIndex = 12;
            Btn_Volver.Text = "Cancelar/Volver";
            Btn_Volver.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(591, 80);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(243, 23);
            label5.TabIndex = 13;
            label5.Text = "Indentificacion de Destinatario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(628, 135);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(628, 188);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 195);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(180, 20);
            label6.TabIndex = 16;
            label6.Text = "Ingrese DNI del Receptor ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 135);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(188, 20);
            label7.TabIndex = 17;
            label7.Text = "Ingrese Nombre y Apellido";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(416, 282);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(418, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // lblFechacEntrega
            // 
            lblFechacEntrega.Location = new Point(416, 237);
            lblFechacEntrega.Margin = new Padding(2, 0, 2, 0);
            lblFechacEntrega.Name = "lblFechacEntrega";
            lblFechacEntrega.Size = new Size(175, 32);
            lblFechacEntrega.TabIndex = 19;
            lblFechacEntrega.Text = "Ingrese Fecha de entrega";
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(416, 324);
            checkBox1.Margin = new Padding(50, 3, 3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(100, 0, 100, 0);
            checkBox1.Size = new Size(398, 30);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "¿Es persona Autorizada?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbl_IngreseDNI
            // 
            lbl_IngreseDNI.AutoSize = true;
            lbl_IngreseDNI.Font = new Font("Segoe UI", 10F);
            lbl_IngreseDNI.Location = new Point(24, 95);
            lbl_IngreseDNI.Margin = new Padding(2, 0, 2, 0);
            lbl_IngreseDNI.Name = "lbl_IngreseDNI";
            lbl_IngreseDNI.Size = new Size(293, 23);
            lbl_IngreseDNI.TabIndex = 21;
            lbl_IngreseDNI.Text = "Ingrese DNI Para Buscar Encomienda";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 135);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(279, 27);
            textBox3.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(24, 188);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(279, 27);
            button1.TabIndex = 23;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Infoencomienda
            // 
            lbl_Infoencomienda.AutoSize = true;
            lbl_Infoencomienda.Font = new Font("Segoe UI", 10F);
            lbl_Infoencomienda.Location = new Point(24, 233);
            lbl_Infoencomienda.Margin = new Padding(2, 0, 2, 0);
            lbl_Infoencomienda.Name = "lbl_Infoencomienda";
            lbl_Infoencomienda.Size = new Size(225, 23);
            lbl_Infoencomienda.TabIndex = 24;
            lbl_Infoencomienda.Text = "Informacion de Encomienda";
            // 
            // lvw_InfoEncomienda
            // 
            lvw_InfoEncomienda.Columns.AddRange(new ColumnHeader[] { Cantidad, Descripcion_Producto, Guia });
            lvw_InfoEncomienda.Location = new Point(24, 270);
            lvw_InfoEncomienda.Name = "lvw_InfoEncomienda";
            lvw_InfoEncomienda.Size = new Size(366, 121);
            lvw_InfoEncomienda.TabIndex = 25;
            lvw_InfoEncomienda.UseCompatibleStateImageBehavior = false;
            lvw_InfoEncomienda.View = View.Details;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // Descripcion_Producto
            // 
            Descripcion_Producto.Text = "Descripcion_Producto";
            Descripcion_Producto.Width = 200;
            // 
            // Guia
            // 
            Guia.Text = "Guia";
            // 
            // EntregaCD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 450);
            Controls.Add(lvw_InfoEncomienda);
            Controls.Add(lbl_Infoencomienda);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(lbl_IngreseDNI);
            Controls.Add(checkBox1);
            Controls.Add(lblFechacEntrega);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(Btn_Volver);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Name = "EntregaCD";
            Text = "EntregaCD";
            Load += EntregaCD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lbl_NameTutasa;
        private Label label3;
        private Button button3;
        private Button Btn_Volver;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label lblFechacEntrega;
        private CheckBox checkBox1;
        private Label lbl_IngreseDNI;
        private TextBox textBox3;
        private Button button1;
        private Label lbl_Infoencomienda;
        private ListView lvw_InfoEncomienda;
        private ColumnHeader Cantidad;
        private ColumnHeader Descripcion_Producto;
        private ColumnHeader Guia;
    }
}