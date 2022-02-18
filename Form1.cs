using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Övning4._3
{
    public partial class Form1 : Form
    {
        public string Förnamn { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnÖppnaFil_Click(object sender, EventArgs e)
        {
            //Shows dialog box which when opened gives you possibility to type in name for opening
            DialogResult resultat = dlgÖppnaFil.ShowDialog();
            if (resultat == DialogResult.OK)
            {
                //Delete listbox content
                lbxKontakt.Items.Clear();
                //This part of code opens the stream
                FileStream inStröm = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);
                //This part of code creates a streamreader
                StreamReader läsare = new StreamReader(inStröm);
                //This one is reading contacts one per time 
                string förnamn = läsare.ReadLine();
                
               

                while (förnamn !=null)
                {
                    Kontakt k = new Kontakt(förnamn, läsare.ReadLine(), läsare.ReadLine(), läsare.ReadLine());
                    this.lbxKontakt.Items.Add(k);
                    // This part of the code checks for new contacts
                    förnamn = läsare.ReadLine();                
                }
            
                /*
                string filText = läsare.ReadToEnd();
                tbxDokument.Text = filText;
                */
                //This part of the code closes the program
                läsare.Dispose();
            }
        }

        private void btnSparaFil_Click(object sender, EventArgs e)
        {
            //Shows dialog box where you can type in filename
            DialogResult resultat = dlgSparaFil.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                //This part openes the file stream
                FileStream utStröm = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                //This part creates the streamreader
                StreamWriter skrivare = new StreamWriter(utStröm);

                //This one is reading contacts one per time 
                skrivare.WriteLine(tbxFörnamn.Text);
                skrivare.WriteLine(tbxEfternamn.Text);
                skrivare.WriteLine(tbxEpost.Text);
                skrivare.WriteLine(tbxTelefonnummer.Text);

                //This part closes the program
                skrivare.Dispose();
            }
        }

        private void btnLäggtill_Click(object sender, EventArgs e)
        {
            //This part creates the contact
            Kontakt k = new Kontakt(tbxFörnamn.Text, tbxEfternamn.Text, tbxEpost.Text, tbxTelefonnummer.Text);

            //This part adds the contact to the listbox
            lbxKontakt.Items.Add(k);
        }

        private void btnTabort_Click(object sender, EventArgs e)
        {
            if(lbxKontakt.SelectedItem != null)
            {
                //This part erases the chosen contact
                lbxKontakt.Items.RemoveAt(lbxKontakt.SelectedIndex);
            }
        }

        private void lbxKontakt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxKontakt.SelectedItem != null)
            {
                //This part creates the object from the chosen contact
                Kontakt k = lbxKontakt.SelectedItem as Kontakt;
                //Write the different parts of the contact in each text box
                tbxFörnamn.Text = k.Förnamn;
                tbxEfternamn.Text = k.Efternamn;
                tbxEpost.Text = k.Epost;
                tbxTelefonnummer.Text = k.Telefonnr;
            }
            else
            {
                //Write the different parts of the contact in each text box
                tbxFörnamn.Text = "";
                tbxEfternamn.Text = "";
                tbxEpost.Text = "";
                tbxTelefonnummer.Text = "";
            }
        }
    }
}
