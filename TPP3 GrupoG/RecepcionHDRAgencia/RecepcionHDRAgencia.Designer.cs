namespace TPP3_GrupoG.RecepcionHDRAgencia
{
    partial class RecepcionHDRAgencia
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
            numHDR = new Label();
            textBox1 = new TextBox();
            buscarNumHDR = new Button();
            textBox2 = new TextBox();
            fleteroTXT = new Label();
            textBox3 = new TextBox();
            tipoHDR = new Label();
            listView1 = new ListView();
            guiasAsociadas = new Label();
            numGuia = new ColumnHeader();
            direccion = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // numHDR
            // 
            numHDR.AutoSize = true;
            numHDR.Location = new Point(32, 19);
            numHDR.Name = "numHDR";
            numHDR.Size = new Size(79, 25);
            numHDR.TabIndex = 0;
            numHDR.Text = "Nº HDR:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 31);
            textBox1.TabIndex = 1;
            // 
            // buscarNumHDR
            // 
            buscarNumHDR.Location = new Point(313, 19);
            buscarNumHDR.Name = "buscarNumHDR";
            buscarNumHDR.Size = new Size(112, 34);
            buscarNumHDR.TabIndex = 2;
            buscarNumHDR.Text = "Buscar";
            buscarNumHDR.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 31);
            textBox2.TabIndex = 3;
            // 
            // fleteroTXT
            // 
            fleteroTXT.AutoSize = true;
            fleteroTXT.Location = new Point(41, 82);
            fleteroTXT.Name = "fleteroTXT";
            fleteroTXT.Size = new Size(70, 25);
            fleteroTXT.TabIndex = 4;
            fleteroTXT.Text = "Fletero:";
            fleteroTXT.Click += fleteroTXT_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 31);
            textBox3.TabIndex = 5;
            // 
            // tipoHDR
            // 
            tipoHDR.AutoSize = true;
            tipoHDR.Location = new Point(51, 150);
            tipoHDR.Name = "tipoHDR";
            tipoHDR.Size = new Size(51, 25);
            tipoHDR.TabIndex = 6;
            tipoHDR.Text = "Tipo:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { numGuia, direccion });
            listView1.Location = new Point(117, 253);
            listView1.Name = "listView1";
            listView1.Size = new Size(203, 146);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // guiasAsociadas
            // 
            guiasAsociadas.AutoSize = true;
            guiasAsociadas.Location = new Point(117, 225);
            guiasAsociadas.Name = "guiasAsociadas";
            guiasAsociadas.Size = new Size(55, 25);
            guiasAsociadas.TabIndex = 8;
            guiasAsociadas.Text = "Guías";
            // 
            // numGuia
            // 
            numGuia.Text = "Nº Guía";
            numGuia.Width = 90;
            // 
            // direccion
            // 
            direccion.Text = "Dirección";
            direccion.Width = 90;
            // 
            // button1
            // 
            button1.Location = new Point(117, 447);
            button1.Name = "button1";
            button1.Size = new Size(174, 62);
            button1.TabIndex = 9;
            button1.Text = "Confirmar recepción";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(313, 475);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // RecepcionHDRAgencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 521);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(guiasAsociadas);
            Controls.Add(listView1);
            Controls.Add(tipoHDR);
            Controls.Add(textBox3);
            Controls.Add(fleteroTXT);
            Controls.Add(textBox2);
            Controls.Add(buscarNumHDR);
            Controls.Add(textBox1);
            Controls.Add(numHDR);
            Name = "RecepcionHDRAgencia";
            Text = "Recepción de Hojas de Ruta (Agencia)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numHDR;
        private TextBox textBox1;
        private Button buscarNumHDR;
        private TextBox textBox2;
        private Label fleteroTXT;
        private TextBox textBox3;
        private Label tipoHDR;
        private ListView listView1;
        private ColumnHeader numGuia;
        private ColumnHeader direccion;
        private Label guiasAsociadas;
        private Button button1;
        private Button button2;
    }
}