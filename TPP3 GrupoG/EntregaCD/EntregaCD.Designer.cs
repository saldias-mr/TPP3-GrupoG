namespace TPP3_GrupoG.Entregas
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
            textBox1 = new TextBox();
            lbl_IngreseDNI = new Label();
            listView1 = new ListView();
            numGuia = new ColumnHeader();
            lbl_Infoencomienda = new Label();
            button1 = new Button();
            button3 = new Button();
            Btn_Volver = new Button();
            lbl_NameTutasa = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 88);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 0;
            // 
            // lbl_IngreseDNI
            // 
            lbl_IngreseDNI.AutoSize = true;
            lbl_IngreseDNI.Font = new Font("Segoe UI", 10F);
            lbl_IngreseDNI.Location = new Point(19, 70);
            lbl_IngreseDNI.Margin = new Padding(2, 0, 2, 0);
            lbl_IngreseDNI.Name = "lbl_IngreseDNI";
            lbl_IngreseDNI.Size = new Size(95, 19);
            lbl_IngreseDNI.TabIndex = 1;
            lbl_IngreseDNI.Text = " DNI Receptor";
            lbl_IngreseDNI.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { numGuia });
            listView1.Location = new Point(19, 157);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(327, 131);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // numGuia
            // 
            numGuia.Text = "Nº Guía";
            numGuia.Width = 90;
            // 
            // lbl_Infoencomienda
            // 
            lbl_Infoencomienda.AutoSize = true;
            lbl_Infoencomienda.Font = new Font("Segoe UI", 12F);
            lbl_Infoencomienda.Location = new Point(19, 134);
            lbl_Infoencomienda.Margin = new Padding(2, 0, 2, 0);
            lbl_Infoencomienda.Name = "lbl_Infoencomienda";
            lbl_Infoencomienda.Size = new Size(95, 21);
            lbl_Infoencomienda.TabIndex = 3;
            lbl_Infoencomienda.Text = "Encomienda";
            // 
            // button1
            // 
            button1.Location = new Point(242, 88);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(19, 358);
            button3.Margin = new Padding(2, 2, 2, 2);
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
            Btn_Volver.Location = new Point(238, 359);
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
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(213, 13);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 9;
            label3.Text = "Registro de Entrega";
            label3.Click += label3_Click;
            // 
            // EntregaCD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 407);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(Btn_Volver);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(lbl_Infoencomienda);
            Controls.Add(listView1);
            Controls.Add(lbl_IngreseDNI);
            Controls.Add(textBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EntregaCD";
            Text = "Entregas (CD)";
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
        private ColumnHeader numGuia;
    }
}