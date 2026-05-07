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
            listView1 = new ListView();
            numGuia = new ColumnHeader();
            direccion = new ColumnHeader();
            guiasAsociadas = new Label();
            button1 = new Button();
            button2 = new Button();
            dniFleteroTXT = new TextBox();
            buscarFletero = new Button();
            dniFletero = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { numGuia, direccion });
            listView1.Location = new Point(11, 48);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(559, 178);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // guiasAsociadas
            // 
            guiasAsociadas.AutoSize = true;
            guiasAsociadas.Location = new Point(11, 31);
            guiasAsociadas.Margin = new Padding(2, 0, 2, 0);
            guiasAsociadas.Name = "guiasAsociadas";
            guiasAsociadas.Size = new Size(36, 15);
            guiasAsociadas.TabIndex = 8;
            guiasAsociadas.Text = "Guías";
            // 
            // button1
            // 
            button1.Location = new Point(413, 230);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(76, 25);
            button1.TabIndex = 9;
            button1.Text = "Confirmar recepción";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(493, 230);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(76, 25);
            button2.TabIndex = 10;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // dniFleteroTXT
            // 
            dniFleteroTXT.Location = new Point(86, 9);
            dniFleteroTXT.Margin = new Padding(2);
            dniFleteroTXT.Name = "dniFleteroTXT";
            dniFleteroTXT.Size = new Size(106, 23);
            dniFleteroTXT.TabIndex = 13;
            // 
            // buscarFletero
            // 
            buscarFletero.Location = new Point(207, 8);
            buscarFletero.Margin = new Padding(2);
            buscarFletero.Name = "buscarFletero";
            buscarFletero.Size = new Size(78, 24);
            buscarFletero.TabIndex = 12;
            buscarFletero.Text = "Buscar";
            buscarFletero.UseVisualStyleBackColor = true;
            // 
            // dniFletero
            // 
            dniFletero.AutoSize = true;
            dniFletero.Location = new Point(11, 9);
            dniFletero.Margin = new Padding(2, 0, 2, 0);
            dniFletero.Name = "dniFletero";
            dniFletero.Size = new Size(66, 15);
            dniFletero.TabIndex = 11;
            dniFletero.Text = "DNI Fletero";
            // 
            // RecepcionHDRAgencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 276);
            Controls.Add(dniFleteroTXT);
            Controls.Add(buscarFletero);
            Controls.Add(dniFletero);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(guiasAsociadas);
            Controls.Add(listView1);
            Margin = new Padding(2);
            Name = "RecepcionHDRAgencia";
            Text = "Recepción de Hojas de Ruta (Agencia)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView1;
        private ColumnHeader numGuia;
        private ColumnHeader direccion;
        private Label guiasAsociadas;
        private Button button1;
        private Button button2;
        private TextBox dniFleteroTXT;
        private Button buscarFletero;
        private Label dniFletero;
    }
}