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
            this.buttonExecuter = new System.Windows.Forms.Button();
            this.buttonSupWorking = new System.Windows.Forms.Button();
            this.buttonSupDestination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDateFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trouvé = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fichier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCharger = new System.Windows.Forms.Button();
            this.textBoxNomFichierCommencePar = new System.Windows.Forms.TextBox();
            this.labelNomFichierCommencePar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPremiereLigneCommencePar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxWorkingDirectory
            // 
            this.comboBoxWorkingDirectory.FormattingEnabled = true;
            this.comboBoxWorkingDirectory.Location = new System.Drawing.Point(239, 257);
            this.comboBoxWorkingDirectory.Name = "comboBoxWorkingDirectory";
            this.comboBoxWorkingDirectory.Size = new System.Drawing.Size(304, 21);
            this.comboBoxWorkingDirectory.TabIndex = 0;
            this.comboBoxWorkingDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxWorkingDirectory_KeyDown);
            // 
            // buttonPathSource
            // 
            this.buttonPathSource.Location = new System.Drawing.Point(549, 255);
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
            this.comboBoxdestination.Location = new System.Drawing.Point(239, 320);
            this.comboBoxdestination.Name = "comboBoxdestination";
            this.comboBoxdestination.Size = new System.Drawing.Size(304, 21);
            this.comboBoxdestination.TabIndex = 2;
            this.comboBoxdestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxdestination_KeyDown);
            // 
            // buttonPathDest
            // 
            this.buttonPathDest.Location = new System.Drawing.Point(549, 318);
            this.buttonPathDest.Name = "buttonPathDest";
            this.buttonPathDest.Size = new System.Drawing.Size(27, 23);
            this.buttonPathDest.TabIndex = 3;
            this.buttonPathDest.Text = "...";
            this.buttonPathDest.UseVisualStyleBackColor = true;
            this.buttonPathDest.Click += new System.EventHandler(this.buttonPathDest_Click);
            // 
            // buttonExecuter
            // 
            this.buttonExecuter.Location = new System.Drawing.Point(358, 400);
            this.buttonExecuter.Name = "buttonExecuter";
            this.buttonExecuter.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuter.TabIndex = 5;
            this.buttonExecuter.Text = "Executer";
            this.buttonExecuter.UseVisualStyleBackColor = true;
            this.buttonExecuter.Click += new System.EventHandler(this.buttonExecuter_Click_1);
            // 
            // buttonSupWorking
            // 
            this.buttonSupWorking.Image = ((System.Drawing.Image)(resources.GetObject("buttonSupWorking.Image")));
            this.buttonSupWorking.Location = new System.Drawing.Point(582, 255);
            this.buttonSupWorking.Name = "buttonSupWorking";
            this.buttonSupWorking.Size = new System.Drawing.Size(27, 23);
            this.buttonSupWorking.TabIndex = 6;
            this.buttonSupWorking.UseVisualStyleBackColor = true;
            this.buttonSupWorking.Click += new System.EventHandler(this.buttonSupWorking_Click);
            // 
            // buttonSupDestination
            // 
            this.buttonSupDestination.Image = ((System.Drawing.Image)(resources.GetObject("buttonSupDestination.Image")));
            this.buttonSupDestination.Location = new System.Drawing.Point(582, 318);
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
            this.label1.Location = new System.Drawing.Point(241, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destination :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 344);
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
            this.label4.Location = new System.Drawing.Point(241, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Analyser les fichiers dont la date de modification est comprise entre le";
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
            // textBoxNomFichierCommencePar
            // 
            this.textBoxNomFichierCommencePar.Location = new System.Drawing.Point(239, 149);
            this.textBoxNomFichierCommencePar.Name = "textBoxNomFichierCommencePar";
            this.textBoxNomFichierCommencePar.Size = new System.Drawing.Size(370, 20);
            this.textBoxNomFichierCommencePar.TabIndex = 20;
            // 
            // labelNomFichierCommencePar
            // 
            this.labelNomFichierCommencePar.AutoSize = true;
            this.labelNomFichierCommencePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomFichierCommencePar.Location = new System.Drawing.Point(238, 133);
            this.labelNomFichierCommencePar.Name = "labelNomFichierCommencePar";
            this.labelNomFichierCommencePar.Size = new System.Drawing.Size(350, 13);
            this.labelNomFichierCommencePar.TabIndex = 21;
            this.labelNomFichierCommencePar.Text = "Et dont le nom commence par :  (plusieurs noms possibles séparés par \',\' )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Et dont la premiére ligne du fichier commence par :";
            // 
            // textBoxPremiereLigneCommencePar
            // 
            this.textBoxPremiereLigneCommencePar.Location = new System.Drawing.Point(237, 203);
            this.textBoxPremiereLigneCommencePar.Name = "textBoxPremiereLigneCommencePar";
            this.textBoxPremiereLigneCommencePar.Size = new System.Drawing.Size(370, 20);
            this.textBoxPremiereLigneCommencePar.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(670, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 404);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1059, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPremiereLigneCommencePar);
            this.Controls.Add(this.labelNomFichierCommencePar);
            this.Controls.Add(this.textBoxNomFichierCommencePar);
            this.Controls.Add(this.buttonCharger);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDateFin);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "findCpyFiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button buttonExecuter;
        private System.Windows.Forms.Button buttonSupWorking;
        private System.Windows.Forms.Button buttonSupDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader trouvé;
        private System.Windows.Forms.Button buttonCharger;
        private System.Windows.Forms.ColumnHeader Fichier;
        private System.Windows.Forms.TextBox textBoxNomFichierCommencePar;
        private System.Windows.Forms.Label labelNomFichierCommencePar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPremiereLigneCommencePar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

