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
            UltimaModificacion = new ColumnHeader();
            UltimaUbicacion = new ColumnHeader();
            Estado = new ColumnHeader();
            Cliente = new ColumnHeader();
            Destinatario = new ColumnHeader();
            FechaCreacion = new ColumnHeader();
            lbl_NameTutasa = new Label();
            label3 = new Label();
            label4 = new Label();
            Btn_Volver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 69);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese N° de Guía";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(607, 69);
            button1.Name = "button1";
            button1.Size = new Size(79, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { UltimaModificacion, UltimaUbicacion, Estado, Cliente, Destinatario, FechaCreacion });
            listView1.Location = new Point(31, 154);
            listView1.Name = "listView1";
            listView1.Size = new Size(886, 155);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // UltimaModificacion
            // 
            UltimaModificacion.Text = "Última Modificación";
            UltimaModificacion.Width = 200;
            // 
            // UltimaUbicacion
            // 
            UltimaUbicacion.Text = "Última Ubicación";
            UltimaUbicacion.Width = 200;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            // 
            // Destinatario
            // 
            Destinatario.Text = "Destinatario";
            Destinatario.Width = 200;
            // 
            // FechaCreacion
            // 
            FechaCreacion.Text = "Fecha Creación";
            FechaCreacion.Width = 100;
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(21, 7);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(150, 35);
            lbl_NameTutasa.TabIndex = 11;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(168, 7);
            label3.Name = "label3";
            label3.Size = new Size(532, 35);
            label3.TabIndex = 12;
            label3.Text = "Consultar estado e historial de una guía (tracking)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(31, 121);
            label4.Name = "label4";
            label4.Size = new Size(375, 30);
            label4.TabIndex = 14;
            label4.Text = "Informacion de Movimientos de la Encomienda";
            // 
            // Btn_Volver
            // 
            Btn_Volver.BackColor = Color.DarkRed;
            Btn_Volver.ForeColor = SystemColors.ButtonHighlight;
            Btn_Volver.Location = new Point(809, 402);
            Btn_Volver.Name = "Btn_Volver";
            Btn_Volver.Size = new Size(108, 37);
            Btn_Volver.TabIndex = 62;
            Btn_Volver.Text = "Cancelar/Volver";
            Btn_Volver.UseVisualStyleBackColor = false;
            // 
            // Tracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 450);
            Controls.Add(Btn_Volver);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Tracking";
            Text = "Tracking";
            Load += Tracking_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader UltimaModificacion;
        private ColumnHeader UltimaUbicacion;
        private ColumnHeader Estado;
        public Label lbl_NameTutasa;
        private Label label3;
        public Label label4;
        private Button Btn_Volver;
        private ColumnHeader Cliente;
        private ColumnHeader Destinatario;
        private ColumnHeader FechaCreacion;
    }
}