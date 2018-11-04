namespace FindCpyFiles
{
    partial class FormImporterListeDesCodes
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonColler = new System.Windows.Forms.Button();
            this.buttonOkImporter = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 415);
            this.textBox1.TabIndex = 0;
            // 
            // buttonColler
            // 
            this.buttonColler.Location = new System.Drawing.Point(63, 421);
            this.buttonColler.Name = "buttonColler";
            this.buttonColler.Size = new System.Drawing.Size(75, 23);
            this.buttonColler.TabIndex = 1;
            this.buttonColler.Text = "Coller";
            this.buttonColler.UseVisualStyleBackColor = true;
            this.buttonColler.Click += new System.EventHandler(this.buttonColler_Click);
            // 
            // buttonOkImporter
            // 
            this.buttonOkImporter.Location = new System.Drawing.Point(171, 421);
            this.buttonOkImporter.Name = "buttonOkImporter";
            this.buttonOkImporter.Size = new System.Drawing.Size(75, 23);
            this.buttonOkImporter.TabIndex = 2;
            this.buttonOkImporter.Text = "OK Importer";
            this.buttonOkImporter.UseVisualStyleBackColor = true;
            this.buttonOkImporter.Click += new System.EventHandler(this.buttonOkImporter_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(258, 421);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormImporterListeDesCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOkImporter);
            this.Controls.Add(this.buttonColler);
            this.Controls.Add(this.textBox1);
            this.Name = "FormImporterListeDesCodes";
            this.Text = "FormImporterListeDesCodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImporterListeDesCodes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonColler;
        private System.Windows.Forms.Button buttonOkImporter;
        private System.Windows.Forms.Button buttonClear;
    }
}