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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxWorkingDirectory = new System.Windows.Forms.ComboBox();
            this.buttonPathSource = new System.Windows.Forms.Button();
            this.comboBoxdestination = new System.Windows.Forms.ComboBox();
            this.buttonPathDest = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.parametresRechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExecuter = new System.Windows.Forms.Button();
            this.buttonSupWorking = new System.Windows.Forms.Button();
            this.buttonSupDestination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAnalyseSiDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDateFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trouvé = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fichier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCharger = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxWorkingDirectory
            // 
            this.comboBoxWorkingDirectory.FormattingEnabled = true;
            this.comboBoxWorkingDirectory.Location = new System.Drawing.Point(239, 174);
            this.comboBoxWorkingDirectory.Name = "comboBoxWorkingDirectory";
            this.comboBoxWorkingDirectory.Size = new System.Drawing.Size(304, 21);
            this.comboBoxWorkingDirectory.TabIndex = 0;
            this.comboBoxWorkingDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxWorkingDirectory_KeyDown);
            // 
            // buttonPathSource
            // 
            this.buttonPathSource.Location = new System.Drawing.Point(549, 172);
            this.buttonPathSource.Name = "buttonPathSource";
            this.buttonPathSource.Size = new System.Drawing.Size(27, 23);
            this.buttonPathSource.TabIndex = 1;
            this.buttonPathSource.Text = "...";
            this.buttonPathSource.UseVisualStyleBackColor = true;
            this.buttonPathSource.Click += new System.EventHandler(this.buttonPathSource_Click);
            // 
            // comboBoxdestination
            // 
            this.comboBoxdestination.FormattingEnabled = true;
            this.comboBoxdestination.Location = new System.Drawing.Point(239, 213);
            this.comboBoxdestination.Name = "comboBoxdestination";
            this.comboBoxdestination.Size = new System.Drawing.Size(304, 21);
            this.comboBoxdestination.TabIndex = 2;
            this.comboBoxdestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxdestination_KeyDown);
            // 
            // buttonPathDest
            // 
            this.buttonPathDest.Location = new System.Drawing.Point(549, 211);
            this.buttonPathDest.Name = "buttonPathDest";
            this.buttonPathDest.Size = new System.Drawing.Size(27, 23);
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
            this.menuStrip2.Size = new System.Drawing.Size(654, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // parametresRechercheToolStripMenuItem
            // 
            this.parametresRechercheToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.parametresRechercheToolStripMenuItem.Name = "parametresRechercheToolStripMenuItem";
            this.parametresRechercheToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.parametresRechercheToolStripMenuItem.Text = "Paramètres recherche";
            this.parametresRechercheToolStripMenuItem.Click += new System.EventHandler(this.parametresRechercheToolStripMenuItem_Click);
            // 
            // buttonExecuter
            // 
            this.buttonExecuter.Location = new System.Drawing.Point(358, 293);
            this.buttonExecuter.Name = "buttonExecuter";
            this.buttonExecuter.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuter.TabIndex = 5;
            this.buttonExecuter.Text = "Executer";
            this.buttonExecuter.UseVisualStyleBackColor = true;
            this.buttonExecuter.Click += new System.EventHandler(this.buttonExecuter_Click_1);
            // 
            // buttonSupWorking
            // 
            this.buttonSupWorking.Image = global::FindCpyFiles.Properties.Resources.if_delete_370086;
            this.buttonSupWorking.Location = new System.Drawing.Point(582, 172);
            this.buttonSupWorking.Name = "buttonSupWorking";
            this.buttonSupWorking.Size = new System.Drawing.Size(27, 23);
            this.buttonSupWorking.TabIndex = 6;
            this.buttonSupWorking.UseVisualStyleBackColor = true;
            this.buttonSupWorking.Click += new System.EventHandler(this.buttonSupWorking_Click);
            // 
            // buttonSupDestination
            // 
            this.buttonSupDestination.Image = global::FindCpyFiles.Properties.Resources.if_delete_370086;
            this.buttonSupDestination.Location = new System.Drawing.Point(582, 211);
            this.buttonSupDestination.Name = "buttonSupDestination";
            this.buttonSupDestination.Size = new System.Drawing.Size(27, 23);
            this.buttonSupDestination.TabIndex = 7;
            this.buttonSupDestination.UseVisualStyleBackColor = true;
            this.buttonSupDestination.Click += new System.EventHandler(this.buttonSupDestination_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destination :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "[Enter] pour enregistrer un path";
            // 
            // dateTimePickerDateDebut
            // 
            this.dateTimePickerDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateDebut.Location = new System.Drawing.Point(244, 88);
            this.dateTimePickerDateDebut.Name = "dateTimePickerDateDebut";
            this.dateTimePickerDateDebut.Size = new System.Drawing.Size(117, 20);
            this.dateTimePickerDateDebut.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Analyser les fichiers dont la date de modification est comprise entre le";
            // 
            // checkBoxAnalyseSiDate
            // 
            this.checkBoxAnalyseSiDate.AutoSize = true;
            this.checkBoxAnalyseSiDate.Location = new System.Drawing.Point(239, 53);
            this.checkBoxAnalyseSiDate.Name = "checkBoxAnalyseSiDate";
            this.checkBoxAnalyseSiDate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnalyseSiDate.TabIndex = 15;
            this.checkBoxAnalyseSiDate.UseVisualStyleBackColor = true;
            this.checkBoxAnalyseSiDate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePickerDateFin
            // 
            this.dateTimePickerDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateFin.Location = new System.Drawing.Point(426, 88);
            this.dateTimePickerDateFin.Name = "dateTimePickerDateFin";
            this.dateTimePickerDateFin.Size = new System.Drawing.Size(117, 20);
            this.dateTimePickerDateFin.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "et le";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.trouvé,
            this.Fichier});
            this.listView1.Location = new System.Drawing.Point(12, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(201, 404);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Num
            // 
            this.Num.Text = "Num";
            // 
            // trouvé
            // 
            this.trouvé.Text = "trouvé";
            // 
            // Fichier
            // 
            this.Fichier.Text = "fichier";
            this.Fichier.Width = 80;
            // 
            // buttonCharger
            // 
            this.buttonCharger.Location = new System.Drawing.Point(70, 452);
            this.buttonCharger.Name = "buttonCharger";
            this.buttonCharger.Size = new System.Drawing.Size(75, 23);
            this.buttonCharger.TabIndex = 19;
            this.buttonCharger.Text = "Importer";
            this.buttonCharger.UseVisualStyleBackColor = true;
            this.buttonCharger.Click += new System.EventHandler(this.buttonCharger_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(654, 523);
            this.Controls.Add(this.buttonCharger);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDateFin);
            this.Controls.Add(this.checkBoxAnalyseSiDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDateDebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSupDestination);
            this.Controls.Add(this.buttonSupWorking);
            this.Controls.Add(this.buttonExecuter);
            this.Controls.Add(this.buttonPathDest);
            this.Controls.Add(this.comboBoxdestination);
            this.Controls.Add(this.buttonPathSource);
            this.Controls.Add(this.comboBoxWorkingDirectory);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAnalyseSiDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader trouvé;
        private System.Windows.Forms.Button buttonCharger;
        private System.Windows.Forms.ColumnHeader Fichier;
    }
}

