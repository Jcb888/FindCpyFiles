namespace FindCpyFiles.Resources
{
    partial class ChargerListeDesCodes
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
            this.textBoxChargerList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxChargerList
            // 
            this.textBoxChargerList.Location = new System.Drawing.Point(3, 1);
            this.textBoxChargerList.Multiline = true;
            this.textBoxChargerList.Name = "textBoxChargerList";
            this.textBoxChargerList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChargerList.Size = new System.Drawing.Size(251, 448);
            this.textBoxChargerList.TabIndex = 0;
            // 
            // ChargerListeDesCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 450);
            this.Controls.Add(this.textBoxChargerList);
            this.Name = "ChargerListeDesCodes";
            this.Text = "ChargerListeDesCodes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChargerList;
    }
}