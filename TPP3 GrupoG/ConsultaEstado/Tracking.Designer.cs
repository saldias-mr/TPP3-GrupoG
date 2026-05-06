namespace TPP3_GrupoG.ConsultaEstado
{
    partial class Tracking
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
            textBox1 = new TextBox();
            button1 = new Button();
            listView1 = new ListView();
            Fecha = new ColumnHeader();
            Hora = new ColumnHeader();
            Punto_Operativo = new ColumnHeader();
            Estado = new ColumnHeader();
            lbl_NameTutasa = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            Btn_Volver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 92);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese N° de Identificador ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 92);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(694, 92);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Fecha, Hora, Punto_Operativo, Estado });
            listView1.Location = new Point(35, 205);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(749, 205);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 150;
            // 
            // Hora
            // 
            Hora.Text = "Hora";
            Hora.Width = 100;
            // 
            // Punto_Operativo
            // 
            Punto_Operativo.Text = "Punto_Operativo";
            Punto_Operativo.Width = 200;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 200;
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(24, 9);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(172, 47);
            lbl_NameTutasa.TabIndex = 11;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(192, 9);
            label3.Name = "label3";
            label3.Size = new Size(608, 47);
            label3.TabIndex = 12;
            label3.Text = "Consultar estado e historial de una guía (tracking)";
            // 
            // label2
            // 
            label2.Location = new Point(35, 449);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(323, 27);
            label2.TabIndex = 13;
            label2.Text = "Ingrese el Codigo que figura en la Encomienda";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(35, 153);
            label4.Name = "label4";
            label4.Size = new Size(429, 40);
            label4.TabIndex = 14;
            label4.Text = "Informacion de Movimientos de la Encomienda";
            // 
            // Btn_Volver
            // 
            Btn_Volver.BackColor = Color.DarkRed;
            Btn_Volver.ForeColor = SystemColors.ButtonHighlight;
            Btn_Volver.Location = new Point(660, 427);
            Btn_Volver.Name = "Btn_Volver";
            Btn_Volver.Size = new Size(124, 49);
            Btn_Volver.TabIndex = 62;
            Btn_Volver.Text = "Cancelar/Volver";
            Btn_Volver.UseVisualStyleBackColor = false;
            // 
            // Tracking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 487);
            Controls.Add(Btn_Volver);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Tracking";
            Text = "Tracking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Fecha;
        private ColumnHeader Hora;
        private ColumnHeader Punto_Operativo;
        private ColumnHeader Estado;
        public Label lbl_NameTutasa;
        private Label label3;
        private Label label2;
        public Label label4;
        private Button Btn_Volver;
    }
}