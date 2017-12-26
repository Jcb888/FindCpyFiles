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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.checkBoxTest1 = new System.Windows.Forms.CheckBox();
            this.comboBoxCommencePar = new System.Windows.Forms.ComboBox();
            this.checkBoxtest2 = new System.Windows.Forms.CheckBox();
            this.comboBoxContient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.buttonCommencePar = new System.Windows.Forms.Button();
            this.buttonContient = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxTest1
            // 
            this.checkBoxTest1.AutoSize = true;
            this.checkBoxTest1.Location = new System.Drawing.Point(13, 13);
            this.checkBoxTest1.Name = "checkBoxTest1";
            this.checkBoxTest1.Size = new System.Drawing.Size(168, 17);
            this.checkBoxTest1.TabIndex = 0;
            this.checkBoxTest1.Text = "Si la 1er ligne commence par :";
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
            this.comboBoxCommencePar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxCommencePar_KeyDown);
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
            this.comboBoxContient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxContient_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alors copier ce fichier dans destination";
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(188, 68);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(200, 13);
            this.labelEnter.TabIndex = 5;
            this.labelEnter.Text = "[enter] Pour valider et enregistrer la saisie";
            // 
            // buttonCommencePar
            // 
            this.buttonCommencePar.Image = global::FindCpyFiles.Properties.Resources.if_delete_370086;
            this.buttonCommencePar.Location = new System.Drawing.Point(436, 13);
            this.buttonCommencePar.Name = "buttonCommencePar";
            this.buttonCommencePar.Size = new System.Drawing.Size(25, 23);
            this.buttonCommencePar.TabIndex = 6;
            this.buttonCommencePar.UseVisualStyleBackColor = true;
            this.buttonCommencePar.Click += new System.EventHandler(this.buttonCommencePar_Click);
            // 
            // buttonContient
            // 
            this.buttonContient.Image = global::FindCpyFiles.Properties.Resources.if_delete_370086;
            this.buttonContient.Location = new System.Drawing.Point(436, 42);
            this.buttonContient.Name = "buttonContient";
            this.buttonContient.Size = new System.Drawing.Size(25, 23);
            this.buttonContient.TabIndex = 7;
            this.buttonContient.UseVisualStyleBackColor = true;
            this.buttonContient.Click += new System.EventHandler(this.buttonContient_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "La 1er ligne";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Toutes les lignes";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher dans :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 184);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonContient);
            this.Controls.Add(this.buttonCommencePar);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxContient);
            this.Controls.Add(this.checkBoxtest2);
            this.Controls.Add(this.comboBoxCommencePar);
            this.Controls.Add(this.checkBoxTest1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBoxTest1;
        public System.Windows.Forms.ComboBox comboBoxCommencePar;
        public System.Windows.Forms.CheckBox checkBoxtest2;
        public System.Windows.Forms.ComboBox comboBoxContient;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Button buttonCommencePar;
        private System.Windows.Forms.Button buttonContient;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}