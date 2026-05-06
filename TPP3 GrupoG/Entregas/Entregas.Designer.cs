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
            label1 = new Label();
            listView1 = new ListView();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 1;
            label1.Text = "DNI Receptor";
            // 
            // listView1
            // 
            listView1.Location = new Point(27, 143);
            listView1.Name = "listView1";
            listView1.Size = new Size(269, 286);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 115);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 3;
            label2.Text = "Encomienda";
            // 
            // button1
            // 
            button1.Location = new Point(313, 44);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(313, 356);
            button3.Name = "button3";
            button3.Size = new Size(112, 73);
            button3.TabIndex = 6;
            button3.Text = "Confirmar entrega";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Entregas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Entregas";
            Text = "Entregas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ListView listView1;
        private Label label2;
        private Button button1;
        private Button button3;
    }
}