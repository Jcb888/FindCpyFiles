using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

// ToDo charger par defaut dernier utilisé.
// ToDo supprimer item fenetre fille

namespace FindCpyFiles
{
    public partial class Form1 : Form
    {
        // Les variables globals au formulaire
        string appDataArterris = "";//c'est dans ce repertoire qu'on a les droits et qu'il convient d'écrire
        string appdata = "";//son ss rep.
        public static configObject co = new configObject();
        Form2 fp = new Form2();
        FormImporterListeDesCodes fldc = new FormImporterListeDesCodes();
        FormAffichage fa = new FormAffichage();
        HashSet<String> hashSetOfFilesToCopy = new HashSet<string>();//hashset n'accepte pas les doublons
        SortedSet<String> sortedSetDesNumFacturesAchercher = new SortedSet<string>();//recherche rapide car trier et pas de doublons
        public String dstDIR = "";
        public HashSet<String> hashsetDebutFichierAchercher = new HashSet<string>();
        
        public Form1()
        {
            InitializeComponent();
            fp.Tag = this;
            fp.setRef();//methode implementer dans la classe form2 pour lien vers this (le pere)
            fldc.Tag = this;
            fldc.setRef();
            fa.textBox1.Text = "N° fac" + "\t" + "nomfic" + "\t\t" + "numLigne" + Environment.NewLine;
            appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            appDataArterris = Path.Combine(appdata, "Arterris");
            XmlSerializer xs = new XmlSerializer(typeof(configObject));//pour serialiser en XML la config (sauvegarde des paths src et dst)
            co.ListRepertoire2Travail = new List<comboItem>();
            co.ListPathDestination = new List<comboItem>();
            co.listCommencePar = new List<comboItem>();
            co.ListContient = new List<comboItem>();
            co.bSousRepDest = true;
            co.strRepertoire2Travail = "";
            co.strPathDestination = "";
            co.strCommencePar = "";
            co.strContient = "";
            co.ligneCommencePar = "";

            if (!Directory.Exists(appDataArterris))
                Directory.CreateDirectory(appDataArterris);

            if (!File.Exists(appDataArterris + "\\configFindFiles.xml"))//si le fichier n'existe pas on le cré avec init à "";
            {
                co.ListRepertoire2Travail.Add(new comboItem("1", @"c:\temp"));
                co.strRepertoire2Travail = "c:\\temp";
                comboBoxWorkingDirectory.Text = co.strRepertoire2Travail;


                co.ListPathDestination.Add(new comboItem("1", @""));
                co.strPathDestination = @"c:\temp";
                comboBoxdestination.Text = co.strPathDestination;

                co.listCommencePar.Add(new comboItem("1", "test"));
                co.strCommencePar = "test";
                this.textBoxNomFichierCommencePar.Text = co.strCommencePar;

                co.ListContient.Add(new comboItem("1", "test"));
                co.strContient = "test";
                fp.comboBoxContient.Text = co.strContient;

                co.checkTest1 = true;
                fp.checkBoxTest1.Checked = co.checkTest1;

                co.checkTest2 = true;
                fp.checkBoxtest2.Checked = co.checkTest2;

                co.bSousRepDest = true;
                //checkBoxSousRep.Checked = true;

                co.bSimulation = false;
                //checkBoxSimulation.Checked = co.bSimulation;

                co.ligneCommencePar = "LD";

                if (!File.Exists(appDataArterris + "\\configFindFiles.xml"))//creation
                {

                    using (StreamWriter wr = new StreamWriter(appDataArterris + "\\configFindFiles.xml"))
                    {
                        xs.Serialize(wr, co);
                    }

                }


            }

            using (StreamReader rd = new StreamReader(appDataArterris + "\\configFindFiles.xml"))
            {
                co = xs.Deserialize(rd) as configObject;

            }

            remplirCombo();
            chargerHashSetCommencePar();

        }

        public configObject getCO()
        {
            return co;
        }

        public void importerNumFactures(String[] tabdesNumFa)
        {
            foreach (String item in tabdesNumFa)
            {
                try
                {
                    this.sortedSetDesNumFacturesAchercher.Add(item);
                }
                catch (Exception)
                {

                    MessageBox.Show("erreur d'insertion de item {0}",item);
                    continue;
                }
                
            }

            chargerlistView();

        }

        private void chargerHashSetCommencePar()
        {
            String[] tab = this.textBoxNomFichierCommencePar.Text.Split(',');
            this.hashsetDebutFichierAchercher.Clear();
            foreach (String item in tab)
            {
                this.hashsetDebutFichierAchercher.Add(item);
            }
            
        }

        private void chargerlistView()
        {
            foreach (var item in sortedSetDesNumFacturesAchercher)
            {
                string[] row = { item, "", ""};
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                
            }
            
        }

        public void remplirCombo()
        {

            co.ListRepertoire2Travail.ForEach(i => comboBoxWorkingDirectory.Items.Add(i));
            co.ListPathDestination.ForEach(i => comboBoxdestination.Items.Add(i));
            co.listCommencePar.ForEach(i => fp.comboBoxCommencePar.Items.Add(i));
            co.ListContient.ForEach(i => fp.comboBoxContient.Items.Add(i));

            comboBoxWorkingDirectory.Text = co.strRepertoire2Travail;
            comboBoxdestination.Text = co.strPathDestination;
            this.textBoxNomFichierCommencePar.Text = co.strCommencePar;
            fp.comboBoxContient.Text = co.strContient;

            fp.checkBoxTest1.Checked = co.checkTest1;
            fp.checkBoxtest2.Checked = co.checkTest2;
            this.textBoxPremiereLigneCommencePar.Text = co.ligneCommencePar;
            //checkBoxSousRep.Checked = co.bSousRepDest;
            //checkBoxSimulation.Checked = co.bSimulation;
        }

        public void setCOcheckTest1(bool b)
        {
            co.checkTest1 = b;

        }

        public void setCOcheckTest2(bool b)
        {
            co.checkTest2 = b;

        }

        public void ajouterListCommencePar()
        {

            //if (fp.comboBoxCommencePar.Text == "")
            //{
            //    MessageBox.Show("la chaine est vide sortie ");
            //    return;
            //}

            //bool b = co.listCommencePar.Any(tr => tr.myValue.Equals(fp.comboBoxCommencePar.Text, StringComparison.CurrentCultureIgnoreCase));
            //if (!b)
            //{
            //    //KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(((DicdepotDirectory.Count) + 1).ToString(), comboBoxDepot.Text);
            //    comboItem ci = new comboItem(((co.listCommencePar.Count) + 1).ToString(), fp.comboBoxCommencePar.Text);
            //    co.listCommencePar.Add(ci);
            //    co.strCommencePar = textBoxNomFichierCommencePar.Text;
            //    fp.comboBoxCommencePar.Items.Add(ci);
            //    fp.comboBoxCommencePar.SelectedIndex = fp.comboBoxCommencePar.FindStringExact(ci.myValue);
            //}
        }

        public void ajouterListContient()
        {

            if (fp.comboBoxContient.Text == "")
            {
                MessageBox.Show("la chaine est vide sortie ");
                return;
            }

            bool b = co.ListContient.Any(tr => tr.myValue.Equals(fp.comboBoxContient.Text, StringComparison.CurrentCultureIgnoreCase));
            if (!b)
            {
                //KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(((DicdepotDirectory.Count) + 1).ToString(), comboBoxDepot.Text);
                comboItem ci = new comboItem(((co.ListContient.Count) + 1).ToString(), fp.comboBoxContient.Text);
                co.ListContient.Add(ci);
                co.strContient = fp.comboBoxContient.Text;
                fp.comboBoxContient.Items.Add(ci);
                fp.comboBoxContient.SelectedIndex = fp.comboBoxContient.FindStringExact(ci.myValue);
            }
        }

        private void traiterFichierEnCours(String fichier)
        {
            String[] Lines;
            Lines = File.ReadAllLines(fichier);

            if (!Lines[0].StartsWith(this.textBoxPremiereLigneCommencePar.Text))//si la 1 er ligne ne commence pas par on rend la main
                return;

            for (int l = 0; l < Lines.Length; l++)
            {
                String numFaOfThisLine = Lines[l].Substring(88, 6);
                if (this.sortedSetDesNumFacturesAchercher.Contains(numFaOfThisLine))//le num facture des cette ligne est'il dans la liste des factures recherchés
                {//oui on l'a trouvé on peut donc l'enlever elle n'est plus à chercher.
                    this.sortedSetDesNumFacturesAchercher.Remove(numFaOfThisLine);
                    this.hashSetOfFilesToCopy.Add(fichier);//on rajoute ce fichier à la liste des fichiers à copier à la fin
                    ajouterElementTrouveSurSortie(numFaOfThisLine ,fichier, l);
                }

            }

        }

        private void ajouterElementTrouveSurSortie(string numFaOfThisLine, String fichier, int l)
        {
            fa.textBox1.AppendText(numFaOfThisLine + "\t" + Path.GetFileName(fichier) + "\t" + l.ToString() + Environment.NewLine);
        }

        private void buttonPathSource_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = this.comboBoxWorkingDirectory.Text;

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                comboBoxWorkingDirectory.Text = fbd.SelectedPath.ToString();
            }

            ajouterWorkinglistCombo();

        }

        private void ajouterWorkinglistCombo()
        {
            if (!Directory.Exists(comboBoxWorkingDirectory.Text))
            {
                MessageBox.Show("Ce repertoire est introuvable : " + comboBoxWorkingDirectory.Text);
                return;
            }

            bool b = co.ListRepertoire2Travail.Any(tr => tr.myValue.Equals(comboBoxWorkingDirectory.Text, StringComparison.CurrentCultureIgnoreCase));
            if (!b)
            {
                //KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(((DicdepotDirectory.Count) + 1).ToString(), comboBoxDepot.Text);
                comboItem ci = new comboItem(((co.ListRepertoire2Travail.Count) + 1).ToString(), comboBoxWorkingDirectory.Text);
                co.ListRepertoire2Travail.Add(ci);
                comboBoxWorkingDirectory.Items.Add(ci);
                comboBoxWorkingDirectory.SelectedIndex = comboBoxWorkingDirectory.FindStringExact(ci.myValue);
            }
        }

        private void ajouterDestinationlistCombo()
        {
            if (!Directory.Exists(comboBoxdestination.Text))
            {
                MessageBox.Show("Ce repertoire est introuvable : " + comboBoxdestination.Text);
                return;
            }

            bool b = co.ListPathDestination.Any(tr => tr.myValue.Equals(comboBoxdestination.Text, StringComparison.CurrentCultureIgnoreCase));
            if (!b)
            {
                //KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(((DicdepotDirectory.Count) + 1).ToString(), comboBoxDepot.Text);
                comboItem ci = new comboItem(((co.ListPathDestination.Count) + 1).ToString(), comboBoxdestination.Text);
                co.ListPathDestination.Add(ci);
                comboBoxdestination.Items.Add(ci);
                comboBoxdestination.SelectedIndex = comboBoxdestination.FindStringExact(ci.myValue);
            }
        }


        private void ajouterPathDestListCombo()
        {

            bool b = co.ListPathDestination.Any(tr => tr.myValue.Equals(comboBoxdestination.Text, StringComparison.CurrentCultureIgnoreCase));
            if (!b)
            {

                comboItem ci = new comboItem(((co.ListPathDestination.Count) + 1).ToString(), comboBoxdestination.Text);
                co.ListPathDestination.Add(ci);
                comboBoxdestination.Items.Add(ci);
                comboBoxdestination.SelectedIndex = comboBoxdestination.FindStringExact(ci.myValue);
            }
        }


        public void creatXML()
        {

            if (co == null)//un min de verif qd mm
                return;

            co.strCommencePar = textBoxNomFichierCommencePar.Text;
            co.ligneCommencePar = textBoxPremiereLigneCommencePar.Text;
            co.strContient = fp.comboBoxContient.Text;

            try
            {

                XmlSerializer xs = new XmlSerializer(typeof(configObject));
                using (StreamWriter wr = new StreamWriter(appDataArterris + "\\configFindFiles.xml"))
                {
                    xs.Serialize(wr, co);
                }

                //MessageBox.Show("Enregitrement des paramétres bien effectué \n\r" + "Source: " + co.strSourcePath + "\n\r" + "Destination: " + co.strDestinationPath);

            }
            catch (Exception e)
            {

                MessageBox.Show("Erreur lors de la sauvegarde des paramètres: " + e.StackTrace.ToString());
            }

        }


        private void buttonDeleteRep2W_Click(object sender, EventArgs e)
        {
            if (comboBoxWorkingDirectory.SelectedIndex != -1)
            {
                co.ListRepertoire2Travail.RemoveAll(x => x.myValue.Contains(this.comboBoxWorkingDirectory.Text));
                comboBoxWorkingDirectory.Items.RemoveAt(comboBoxWorkingDirectory.SelectedIndex);
            }
        }

        private void buttonPathDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = this.comboBoxdestination.Text;

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                comboBoxdestination.Text = fbd.SelectedPath.ToString();
            }

            ajouterPathDestListCombo();
        }

        private void parametresRechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fp.Show();
        }

        private void comboBoxWorkingDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ajouterWorkinglistCombo();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            creatXML();
        }

        private void buttonExecuter_Click_1(object sender, EventArgs e)
        {
            if (this.sortedSetDesNumFacturesAchercher.Count < 1)
            {
                MessageBox.Show("Rien à chercher, importer liste");
                return;
            }


            if (!Directory.Exists(comboBoxWorkingDirectory.Text))
            {
                MessageBox.Show("Ce repertoire d'analyse n'existe pas : " + comboBoxWorkingDirectory.Text);
                return;
            }

            if (this.textBoxNomFichierCommencePar.Text == "")
            {
                MessageBox.Show("Le texte nom fichier commence par est vide sortie");
                return;
            }

            if (this.textBoxPremiereLigneCommencePar.Text == "")
            {
                MessageBox.Show("1 er ligne du fichier commence par est vide sortie");
                return;
            }

            string[] tabFiles = Directory.GetFiles(comboBoxWorkingDirectory.Text, "*.");
            hashSetOfFilesToCopy.Clear();

            foreach (String file in tabFiles)
            {

                // est - ce que le fichier est dans les dates à analyser
                DateTime dtFile = File.GetLastWriteTime(file).Date;
                if (!(dtFile.Date > this.dateTimePickerDateDebut.Value.Date && dtFile.Date < this.dateTimePickerDateFin.Value.Date))
                {
                    //la date n'est pas comprise entre date debut et fin le fichier n'est pas à analyser on passe au suivant
                    continue;
                }

                String strDebutNomFichier = Path.GetFileName(file).Substring(0, 5);
                if (!hashsetDebutFichierAchercher.Contains(strDebutNomFichier))
                {
                    //si le fichier ne commence pas par une chaine faisant partie de la liste on passe au suivant
                    continue;
                }

                //si on arrive ici le fichier est dans les dates et commence par une chaine de la liste
                traiterFichierEnCours(file);
            }
           

            if (hashSetOfFilesToCopy.Count < 1)
            {
                MessageBox.Show("Aucune correspondance trouvée");
                return;
            }


            if (false)
            {
                //jc20181103 -> deplace dans la methode ajouterelementtrouvesursortie

                //FormAffichage fa = new FormAffichage();
                //fa.textBox1.Font = new Font(fa.textBox1.Font, FontStyle.Bold);
                //fa.textBox1.Text = "Correspondances trouvées dans " + Path.GetDirectoryName(tabFiles[0]) + " :";
                //fa.textBox1.Font = new Font(fa.textBox1.Font, FontStyle.Regular);


                //foreach (var item in hashSetOfFilesToCopy)
                //{
                //    fa.textBox1.AppendText(Environment.NewLine);
                //    fa.textBox1.AppendText(item);
                //}
                //fa.Show();
                //return;
            }
            else
            {
                DateTime dt = DateTime.Now;
                dstDIR = "";
                if (true)
                {
                    dstDIR = comboBoxdestination.Text + "\\" + dt.Year + "-" + dt.Month + "-" + dt.Day + "_" + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second;
                    //dstDIR = comboBoxdestination.Text + "\\" + DateTime.Now.ToString("YYYYHHmmss");
                    Directory.CreateDirectory(dstDIR);
                }
                else
                {
                    dstDIR = comboBoxdestination.Text;
                }


                foreach (var item in hashSetOfFilesToCopy)
                {
                    string destination = Path.Combine(comboBoxdestination.Text, dstDIR, Path.GetFileName(item));

                    try
                    {
                        File.Copy(item, destination, false);
                    }

                    catch (UnauthorizedAccessException ueae)
                    {
                        MessageBox.Show("Acces non authorise : " + ueae.StackTrace.ToString());
                    }

                    catch (ArgumentNullException ane)
                    {
                        MessageBox.Show("un des chemins est vide : " + ane.StackTrace.ToString());
                    }

                    catch (ArgumentException ae)
                    {
                        MessageBox.Show("erreur dans les chemins passés en paramètre : " + ae.StackTrace.ToString());
                    }

                    catch (PathTooLongException atle)
                    {
                        MessageBox.Show("un des chemins est trop long : " + atle.StackTrace.ToString());

                    }

                    catch (DirectoryNotFoundException dnfe)
                    {
                        MessageBox.Show("Un  des chemins n'existe pas : " + dnfe.StackTrace.ToString());
                    }

                    catch (FileNotFoundException fnfe)
                    {
                        MessageBox.Show("Le fichier source non trouve : " + fnfe.StackTrace.ToString());
                    }

                    catch (IOException ioe)
                    {
                        DialogResult result = MessageBox.Show("Le fichier existe déja dans la destination " + Environment.NewLine + " vous devrier utiliser l'option créer sous répertoire !", "ATTENTION !", MessageBoxButtons.YesNoCancel);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                break;
                            case DialogResult.No:
                                break;
                            case DialogResult.Cancel:
                                return;
                        }

                    }

                    catch (NotSupportedException nse)
                    {
                        MessageBox.Show("sourceFileName ou destFileName a un format non valide. : " + nse.StackTrace.ToString());
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la copie: " + ex.StackTrace.ToString());
                    }
                }
            }

            try
            {
                System.Diagnostics.Process.Start("explorer.exe", dstDIR);
            }
            catch (Exception e2)
            {

                MessageBox.Show(e2.StackTrace);
            }
            fa.Show();

        }

        private void comboBoxdestination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ajouterDestinationlistCombo();
            }
        }

        private void buttonSupWorking_Click(object sender, EventArgs e)
        {
            if (comboBoxWorkingDirectory.SelectedIndex != -1)
            {
                co.ListRepertoire2Travail.RemoveAll(x => x.myValue.Contains(this.comboBoxWorkingDirectory.Text));
                comboBoxWorkingDirectory.Items.RemoveAt(comboBoxWorkingDirectory.SelectedIndex);
                if (comboBoxWorkingDirectory.Items.Count < 1)
                    return;
                comboBoxWorkingDirectory.SelectedIndex = 0;
            }
        }

        private void buttonSupDestination_Click(object sender, EventArgs e)
        {
            if (comboBoxdestination.SelectedIndex != -1)
            {
                co.ListPathDestination.RemoveAll(x => x.myValue.Contains(this.comboBoxdestination.Text));
                comboBoxdestination.Items.RemoveAt(comboBoxdestination.SelectedIndex);
                comboBoxdestination.SelectedIndex = 0;
            }
        }

        private void checkBoxSousRep_CheckedChanged(object sender, EventArgs e)
        {
            //co.bSousRepDest = checkBoxSousRep.Checked;
        }

        private void checkBoxSimulation_CheckedChanged(object sender, EventArgs e)
        {
            //co.bSimulation = checkBoxSimulation.Checked;
        }


        private void buttonCharger_Click(object sender, EventArgs e)
        {
            if(fldc != null)
                fldc.Show();
        }
    }




    public class configObject
    {

        public configObject()
        {

        }


        public bool checkTest1;
        public bool checkTest2;
        public bool bSousRepDest;
        public bool bSimulation;
        public String strRepertoire2Travail;
        public String strPathDestination;
        public String strCommencePar;
        public String strContient;
        public String ligneCommencePar;
        public List<comboItem> ListRepertoire2Travail;
        public List<comboItem> ListPathDestination;
        public List<comboItem> listCommencePar;
        public List<comboItem> ListContient;

    }

    [Serializable]
    public class comboItem
    {
        public comboItem()
        {

        }

        public comboItem(string k, string v)
        {
            myKey = k;
            myValue = v;
        }

        [XmlElement("StringElementKey")]
        public String myKey { get; set; }

        [XmlElement("StringElementValue")]
        public String myValue { get; set; }

        public override string ToString()
        {
            return myValue;
        }

    }
}
