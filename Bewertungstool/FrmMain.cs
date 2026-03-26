using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bewertungstool
{
    public partial class FrmMain : Form
    {
        private List<Note> noten;
        public FrmMain()
        {
            noten = new List<Note>();
            InitializeComponent();
        }

        public FrmMain(List<Note> noten) : this()
        {
            this.noten = noten;
            ListBoxenUpdaten();
        }

        private void ListBoxenUpdaten()
        {
            // Alte Datenquelle löschen
            lbxNotenKurz.DataSource = null;

            // Neue Datenquelle festlegen
            // Die ListBox erkennt diese Änderung und zeigt den aktuellen Zustand an.
            lbxNotenKurz.DataSource = noten;

            // Hier wird festgelegt, welche Eigenschaft in der ListBox angezeigt wird.
            lbxNotenKurz.DisplayMember = "Kurz";
        }

        private void btnNoteErzeugen_Click(object sender, EventArgs e)
        {
            NoteErzeugen();
        }
        private void tbxPunkteErreicht_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                NoteErzeugen();
            }
        }

        private void NoteErzeugen()
        {
            noten.Add(new Note(Convert.ToInt32(tbxPunkteMoeglich.Text)
                                         , Convert.ToInt32(tbxPunkteErreicht.Text)));


            ListBoxenUpdaten();

            if (cbxPunkteMoeglichBehalten.Checked == false)
            {
                tbxPunkteMoeglich.Clear();
            }
            tbxPunkteErreicht.Clear();
            tbxPunkteErreicht.Select();
        }

    }
}
