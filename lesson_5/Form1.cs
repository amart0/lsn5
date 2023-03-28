using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lesson_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string someText;

       
        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void file_quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void newProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void file_new_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (txt1.SelectedText != "")
            {
                txt1.Cut();
            }
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if (txt1.CanUndo == true)
            {
                txt1.Undo();
                txt1.ClearUndo();
            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            if (txt1.SelectionLength > 0)
            {
                txt2.Paste();
            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (txt1.SelectionLength > 0)
            {
                txt1.Copy();
            }
        }

        private void mnuTextBox_Click(object sender, EventArgs e)
        {
           mnuTextBox.Checked = !mnuTextBox.Checked;
            if (mnuTextBox.Checked)
            {
                txt1.Visible = true;
                txt2.Visible = true;
            }
            else
            {
                txt1.Visible = false;
                txt2.Visible = false;
            }
        }

        private void mnuImages_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";
            
            openFD.InitialDirectory = "C:";
            openFD.Title = "Insert an Image";
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg|GIF Images|*.gif";


            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");

            }
            else
            {
                Chosen_File = openFD.FileName;
                pic1.Image = Image.FromFile(Chosen_File);
            }
        }

        private void file_open_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";
            openFD.InitialDirectory = "C:";
            openFD.Title = "Open a Text File";
            openFD.FileName = "";
            openFD.Filter = "Text Files|*.txt|Word Documents|*.doc";
            if (openFD.ShowDialog() != DialogResult.Cancel)
            {
                Chosen_File = openFD.FileName;
                bigtxt1.LoadFile(Chosen_File, RichTextBoxStreamType.PlainText);
            }
        }
    }
}