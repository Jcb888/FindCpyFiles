namespace FindCpyFiles
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxWorkingDirectory = new System.Windows.Forms.ComboBox();
            this.buttonPathSource = new System.Windows.Forms.Button();
            this.comboBoxdestination = new System.Windows.Forms.ComboBox();
            this.buttonPathDest = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.parametresRechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExecuter = new System.Windows.Forms.Button();
            this.buttonSupWorking = new System.Windows.Forms.Button();
            this.buttonSupDestination = new System.Windows.Forms.Button();
            this.checkBoxSimulation = new System.Windows.Forms.CheckBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxWorkingDirectory
            // 
            this.comboBoxWorkingDirectory.FormattingEnabled = true;
            this.comboBoxWorkingDirectory.Location = new System.Drawing.Point(12, 64);
            this.comboBoxWorkingDirectory.Name = "comboBoxWorkingDirectory";
            this.comboBoxWorkingDirectory.Size = new System.Drawing.Size(366, 21);
            this.comboBoxWorkingDirectory.TabIndex = 0;
            this.comboBoxWorkingDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxWorkingDirectory_KeyDown);
            // 
            // buttonPathSource
            // 
            this.buttonPathSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPathSource.Location = new System.Drawing.Point(384, 62);
            this.buttonPathSource.Name = "buttonPathSource";
            this.buttonPathSource.Size = new System.Drawing.Size(30, 23);
            this.buttonPathSource.TabIndex = 1;
            this.buttonPathSource.Text = "...";
            this.buttonPathSource.UseVisualStyleBackColor = true;
            this.buttonPathSource.Click += new System.EventHandler(this.buttonPathSource_Click);
            // 
            // comboBoxdestination
            // 
            this.comboBoxdestination.FormattingEnabled = true;
            this.comboBoxdestination.Location = new System.Drawing.Point(12, 104);
            this.comboBoxdestination.Name = "comboBoxdestination";
            this.comboBoxdestination.Size = new System.Drawing.Size(366, 21);
            this.comboBoxdestination.TabIndex = 2;
            this.comboBoxdestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxdestination_KeyDown);
            // 
            // buttonPathDest
            // 
            this.buttonPathDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPathDest.Location = new System.Drawing.Point(384, 104);
            this.buttonPathDest.Name = "buttonPathDest";
            this.buttonPathDest.Size = new System.Drawing.Size(30, 23);
            this.buttonPathDest.TabIndex = 3;
            this.buttonPathDest.Text = "...";
            this.buttonPathDest.UseVisualStyleBackColor = true;
            this.buttonPathDest.Click += new System.EventHandler(this.buttonPathDest_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametresRechercheToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(481, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // parametresRechercheToolStripMenuItem
            // 
            this.parametresRechercheToolStripMenuItem.Name = "parametresRechercheToolStripMenuItem";
            this.parametresRechercheToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.parametresRechercheToolStripMenuItem.Text = "Paramètres recherche";
            this.parametresRechercheToolStripMenuItem.Click += new System.EventHandler(this.parametresRechercheToolStripMenuItem_Click);
            // 
            // buttonExecuter
            // 
            this.buttonExecuter.Location = new System.Drawing.Point(173, 150);
            this.buttonExecuter.Name = "buttonExecuter";
            this.buttonExecuter.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuter.TabIndex = 5;
            this.buttonExecuter.Text = "Executer";
            this.buttonExecuter.UseVisualStyleBackColor = true;
            this.buttonExecuter.Click += new System.EventHandler(this.buttonExecuter_Click_1);
            // 
            // buttonSupWorking
            // 
            this.buttonSupWorking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupWorking.Location = new System.Drawing.Point(420, 62);
            this.buttonSupWorking.Name = "buttonSupWorking";
            this.buttonSupWorking.Size = new System.Drawing.Size(37, 23);
            this.buttonSupWorking.TabIndex = 6;
            this.buttonSupWorking.Text = "Sup";
            this.buttonSupWorking.UseVisualStyleBackColor = true;
            this.buttonSupWorking.Click += new System.EventHandler(this.buttonSupWorking_Click);
            // 
            // buttonSupDestination
            // 
            this.buttonSupDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupDestination.Location = new System.Drawing.Point(420, 104);
            this.buttonSupDestination.Name = "buttonSupDestination";
            this.buttonSupDestination.Size = new System.Drawing.Size(37, 23);
            this.buttonSupDestination.TabIndex = 7;
            this.buttonSupDestination.Text = "Sup";
            this.buttonSupDestination.UseVisualStyleBackColor = true;
            this.buttonSupDestination.Click += new System.EventHandler(this.buttonSupDestination_Click);
            // 
            // checkBoxSimulation
            // 
            this.checkBoxSimulation.AutoSize = true;
            this.checkBoxSimulation.Location = new System.Drawing.Point(173, 27);
            this.checkBoxSimulation.Name = "checkBoxSimulation";
            this.checkBoxSimulation.Size = new System.Drawing.Size(74, 17);
            this.checkBoxSimulation.TabIndex = 8;
            this.checkBoxSimulation.Text = "Simulation";
            this.checkBoxSimulation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(481, 221);
            this.Controls.Add(this.checkBoxSimulation);
            this.Controls.Add(this.buttonSupDestination);
            this.Controls.Add(this.buttonSupWorking);
            this.Controls.Add(this.buttonExecuter);
            this.Controls.Add(this.buttonPathDest);
            this.Controls.Add(this.comboBoxdestination);
            this.Controls.Add(this.buttonPathSource);
            this.Controls.Add(this.comboBoxWorkingDirectory);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "findCpyFiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paramToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxWorkingDirectory;
        private System.Windows.Forms.Button buttonPathSource;
        private System.Windows.Forms.ComboBox comboBoxdestination;
        private System.Windows.Forms.Button buttonPathDest;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem parametresRechercheToolStripMenuItem;
        private System.Windows.Forms.Button buttonExecuter;
        private System.Windows.Forms.Button buttonSupWorking;
        private System.Windows.Forms.Button buttonSupDestination;
        private System.Windows.Forms.CheckBox checkBoxSimulation;
    }
}

