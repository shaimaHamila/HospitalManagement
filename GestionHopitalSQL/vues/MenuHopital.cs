using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vues
{
    public partial class MenuHopital : Form
    {
        private int childFormNumber = 0;

        public MenuHopital()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void medecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMedecin f1 = new GestionMedecin();
            f1.Show();
            f1.MdiParent = this;
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FActualiserMedecin f1 = new FActualiserMedecin();
            f1.Show();
            f1.MdiParent = this;
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestionMedecin f2 = new GestionMedecin();
            f2.Show();
            f2.MdiParent = this;
        }

        private void modeDeconnecte_Click(object sender, EventArgs e)
        {
            GestionService f2 = new GestionService();
            f2.Show();
            f2.MdiParent = this;
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
        private void ajouterToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FAffectationService f = new FAffectationService();
            f.Show();
            f.MdiParent = this;

        }

        private void rechercheToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestionMedecin f = new GestionMedecin();
            f.Show();
            f.MdiParent = this;
        }

        private void ajouterToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            GestionService f2 = new GestionService();
            f2.Show();
            f2.MdiParent = this;
        }

        private void modeDéconnectéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FActualiserMedecinMD f = new FActualiserMedecinMD();
            f.Show();
            f.MdiParent = this;
            
        }

        private void MenuHopital_Load(object sender, EventArgs e)
        {

        }

        private void medecinsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
    }
}
