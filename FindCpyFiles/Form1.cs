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
        List<String> ListFilesToCopy = new List<string>();

        public Form1()
        {
            InitializeComponent();
            fp.Tag = this;
            fp.setRef();
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
                fp.comboBoxCommencePar.Text = co.strCommencePar;

                co.ListContient.Add(new comboItem("1", "test"));
                co.strContient = "test";
                fp.comboBoxContient.Text = co.strContient;

                co.checkTest1 = true;
                fp.checkBoxTest1.Checked = co.checkTest1;

                co.checkTest2 = true;
                fp.checkBoxtest2.Checked = co.checkTest2;

                co.bSousRepDest = true;
                checkBoxSousRep.Checked = true;

                co.bSimulation = false;
                checkBoxSimulation.Checked = co.bSimulation;

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
        }
        
        public configObject getCO()
        {
            return co;
        }

        public void remplirCombo()
        {

            co.ListRepertoire2Travail.ForEach(i => comboBoxWorkingDirectory.Items.Add(i));
            co.ListPathDestination.ForEach(i => comboBoxdestination.Items.Add(i));
            co.listCommencePar.ForEach(i => fp.comboBoxCommencePar.Items.Add(i));
            co.ListContient.ForEach(i => fp.comboBoxContient.Items.Add(i));

            comboBoxWorkingDirectory.Text = co.strRepertoire2Travail;
            comboBoxdestination.Text = co.strPathDestination;
            fp.comboBoxCommencePar.Text = co.strCommencePar;
            fp.comboBoxContient.Text = co.strContient;

            fp.checkBoxTest1.Checked = co.checkTest1;
            fp.checkBoxtest2.Checked = co.checkTest2;
            checkBoxSousRep.Checked = co.bSousRepDest;
            checkBoxSimulation.Checked = co.bSimulation;
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

            if (fp.comboBoxCommencePar.Text == "")
            {
                MessageBox.Show("la chaine est vide sortie ");
                return;
            }

            bool b = co.listCommencePar.Any(tr => tr.myValue.Equals(fp.comboBoxCommencePar.Text, StringComparison.CurrentCultureIgnoreCase));
            if (!b)
            {
                //KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(((DicdepotDirectory.Count) + 1).ToString(), comboBoxDepot.Text);
                comboItem ci = new comboItem(((co.listCommencePar.Count) + 1).ToString(), fp.comboBoxCommencePar.Text);
                co.listCommencePar.Add(ci);
                co.strCommencePar = fp.comboBoxCommencePar.Text;
                fp.comboBoxCommencePar.Items.Add(ci);
                fp.comboBoxCommencePar.SelectedIndex = fp.comboBoxCommencePar.FindStringExact(ci.myValue);
            }
        }

        public void ajouterListContient()
        {

            if (fp.comboBoxContient.Text == "" )
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
            bool t1 = true;//si on ne test pas alors dans tous les cas c'est true
            bool t2 = true;

            string Line1 = System.IO.File.ReadLines(fichier).First();

            if (co.checkTest1)
            {
                
                if (Line1.StartsWith(fp.comboBoxCommencePar.Text))
                {
                    t1 = true;
                }
                else
                {
                    t1 = false ;//si en test et que le resultat est false alors c'est le seul cas ou c'est false
                }
            }

            if (co.checkTest2)
            {
               
                if (Line1.Contains(fp.comboBoxContient.Text))
                {
                    t2 = true;
                }
                else
                {
                    t2 = false;
                }
            }


            if (t1 && t2)
            {
                ListFilesToCopy.Add(fichier);
            }


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

            co.strCommencePar = fp.comboBoxCommencePar.Text;
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
            
            if (!Directory.Exists(comboBoxWorkingDirectory.Text))
            {
                MessageBox.Show("Ce repertoire source n'existe pas : " + comboBoxWorkingDirectory.Text);
                return;
            }

            if (fp.comboBoxCommencePar.Text == "" && fp.checkBoxTest1.Checked)
            {
                MessageBox.Show("Le texte commence par est vide sortie");
                return;
            }

            if (fp.comboBoxContient.Text == "" && fp.checkBoxtest2.Checked)
            {
                MessageBox.Show("texte à chercher vide sortie");
                return;
            }

            // recup de la liste des fichier .asc du repertoire de la combobox 

            //string[] tabFiles = Directory.GetFileSystemEntries(((KeyValuePair<string, string>)comboBoxWorkingDirectory.SelectedItem).Value, "*.");

            string[] tabFiles = Directory.GetFiles(comboBoxWorkingDirectory.Text, "*.");
            ListFilesToCopy.Clear();

            for (int i = 0; i < tabFiles.Length; i++)
            {
               
              traiterFichierEnCours(tabFiles[i]);
               
            }

            if(ListFilesToCopy.Count < 1)
            {
                MessageBox.Show("Aucune correspondance trouvée");
                return;
            }


            if (checkBoxSimulation.Checked == true)
            {

                FormAffichage fa = new FormAffichage();
                fa.textBox1.Font = new Font(fa.textBox1.Font, FontStyle.Bold);
                fa.textBox1.Text = "Correspondances trouvées dans " + Path.GetDirectoryName(tabFiles[0])+ " :";
                fa.textBox1.Font = new Font(fa.textBox1.Font, FontStyle.Regular);


                foreach (var item in ListFilesToCopy)
                {
                    fa.textBox1.AppendText(Environment.NewLine);
                    fa.textBox1.AppendText(item);
                }
                fa.Show();
                return;
            }
            else
            {
                DateTime dt = DateTime.Now;
                String destinationDIR = "";
                if (checkBoxSousRep.Checked)
                {
                    destinationDIR = comboBoxdestination.Text + "\\" + dt.Year + "-" + dt.Month + "-" + dt.Day + "_" + dt.Hour + dt.Minute + dt.Second;
                    Directory.CreateDirectory(destinationDIR);
                }
                else
                {
                    destinationDIR = comboBoxdestination.Text;
                }
               
                foreach (var item in ListFilesToCopy)
                {
                    string destination = Path.Combine(comboBoxdestination.Text, destinationDIR, Path.GetFileName(item));

                    try
                    {
                        File.Copy(item, destination, false);
                    }

                    catch(UnauthorizedAccessException ueae)
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
                        MessageBox.Show("destFileName existe ou erreur d’ES : " + ioe.StackTrace.ToString());
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
                System.Diagnostics.Process.Start("explorer.exe", comboBoxWorkingDirectory.Text);
            }
            catch (Exception e2)
            {

                MessageBox.Show(e2.StackTrace);
            }


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
            co.bSousRepDest = checkBoxSousRep.Checked;
        }

        private void checkBoxSimulation_CheckedChanged(object sender, EventArgs e)
        {
            co.bSimulation = checkBoxSimulation.Checked;
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
