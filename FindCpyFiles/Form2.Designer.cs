namespace FindCpyFiles
{
    partial class Form2
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
            this.checkBoxTest1 = new System.Windows.Forms.CheckBox();
            this.comboBoxCommencePar = new System.Windows.Forms.ComboBox();
            this.checkBoxtest2 = new System.Windows.Forms.CheckBox();
            this.comboBoxContient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxTest1
            // 
            this.checkBoxTest1.AutoSize = true;
            this.checkBoxTest1.Location = new System.Drawing.Point(13, 13);
            this.checkBoxTest1.Name = "checkBoxTest1";
            this.checkBoxTest1.Size = new System.Drawing.Size(168, 17);
            this.checkBoxTest1.TabIndex = 0;
            this.checkBoxTest1.Text = "Si la 1er ligne commance par :";
            this.checkBoxTest1.UseVisualStyleBackColor = true;
            this.checkBoxTest1.CheckedChanged += new System.EventHandler(this.checkBoxTest1_CheckedChanged);
            // 
            // comboBoxCommencePar
            // 
            this.comboBoxCommencePar.FormattingEnabled = true;
            this.comboBoxCommencePar.Location = new System.Drawing.Point(188, 13);
            this.comboBoxCommencePar.Name = "comboBoxCommencePar";
            this.comboBoxCommencePar.Size = new System.Drawing.Size(241, 21);
            this.comboBoxCommencePar.TabIndex = 1;
            // 
            // checkBoxtest2
            // 
            this.checkBoxtest2.AutoSize = true;
            this.checkBoxtest2.Location = new System.Drawing.Point(13, 42);
            this.checkBoxtest2.Name = "checkBoxtest2";
            this.checkBoxtest2.Size = new System.Drawing.Size(82, 17);
            this.checkBoxtest2.TabIndex = 2;
            this.checkBoxtest2.Text = "et contient :";
            this.checkBoxtest2.UseVisualStyleBackColor = true;
            this.checkBoxtest2.CheckedChanged += new System.EventHandler(this.checkBoxtest2_CheckedChanged);
            // 
            // comboBoxContient
            // 
            this.comboBoxContient.FormattingEnabled = true;
            this.comboBoxContient.Location = new System.Drawing.Point(188, 40);
            this.comboBoxContient.Name = "comboBoxContient";
            this.comboBoxContient.Size = new System.Drawing.Size(241, 21);
            this.comboBoxContient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alors copier ce fichier dans destination";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxContient);
            this.Controls.Add(this.checkBoxtest2);
            this.Controls.Add(this.comboBoxCommencePar);
            this.Controls.Add(this.checkBoxTest1);
            this.Name = "Form2";
            this.Text = "Paramètres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBoxTest1;
        public System.Windows.Forms.ComboBox comboBoxCommencePar;
        public System.Windows.Forms.CheckBox checkBoxtest2;
        public System.Windows.Forms.ComboBox comboBoxContient;
        public System.Windows.Forms.Label label1;
    }
}