namespace Windows_Forms_App_pizza_futar_vizsgaszeru
{
    partial class Form1
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
            this.button_Lekeres = new System.Windows.Forms.Button();
            this.listBox_Adat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Modositas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Lekeres
            // 
            this.button_Lekeres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Lekeres.Location = new System.Drawing.Point(12, 12);
            this.button_Lekeres.Name = "button_Lekeres";
            this.button_Lekeres.Size = new System.Drawing.Size(133, 23);
            this.button_Lekeres.TabIndex = 0;
            this.button_Lekeres.Text = "Lekérés";
            this.button_Lekeres.UseVisualStyleBackColor = true;
            this.button_Lekeres.Click += new System.EventHandler(this.button_Lekeres_Click);
            // 
            // listBox_Adat
            // 
            this.listBox_Adat.FormattingEnabled = true;
            this.listBox_Adat.Location = new System.Drawing.Point(15, 41);
            this.listBox_Adat.Name = "listBox_Adat";
            this.listBox_Adat.Size = new System.Drawing.Size(130, 225);
            this.listBox_Adat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefonszám:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Modositas
            // 
            this.button_Modositas.Location = new System.Drawing.Point(15, 313);
            this.button_Modositas.Name = "button_Modositas";
            this.button_Modositas.Size = new System.Drawing.Size(130, 23);
            this.button_Modositas.TabIndex = 4;
            this.button_Modositas.Text = "Módosítás";
            this.button_Modositas.UseVisualStyleBackColor = true;
            this.button_Modositas.Click += new System.EventHandler(this.button_Modositas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 351);
            this.Controls.Add(this.button_Modositas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Adat);
            this.Controls.Add(this.button_Lekeres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "pizza_futar_vizsgaszeru";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Lekeres;
        private System.Windows.Forms.ListBox listBox_Adat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Modositas;
    }
}

