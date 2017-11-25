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

namespace Dominguez_Bagel_Lists
{
    public partial class Bagels : Form
    {
        public Bagels()
        {
            InitializeComponent();
        }

        private void removeBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BagelListBox.Items.RemoveAt(BagelListBox.SelectedIndex);
            }
            catch
            {
                if (BagelListBox == null)
                {
                    MessageBox.Show("You have not selected a bagel type! I will try to remove the first item in your list",
                                "No Selection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    BagelListBox.Items.Remove(BagelListBox.Items[0]);
                }
                catch
                {
                    MessageBox.Show("Your list is completely empty, there is nothing to remove!",
                               "No items!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void openAndLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader bagelStream;
            string bagelName;
            string bagelTempHold;

            BagelOpenFileDialog.Filter = "Text Files (*.txt|*.txt|All files (*.)|*.*";
            BagelOpenFileDialog.InitialDirectory = "\\\\myhome.spu.edu\\users\\dominguezmah\\Documents\\Visual Studio 2015\\Projects";
            BagelOpenFileDialog.Title = "Select file to open";

            try
            {
                if (BagelOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bagelStream = File.OpenText(BagelOpenFileDialog.FileName);
                }
                else
                {
                    return;
                }
                while(bagelStream.EndOfStream == false)
                {
                    bagelName = bagelStream.ReadLine();
                    BagelListBox.Items.Add(bagelName);
                    bagelTempHold = bagelName;
                }
            }
            catch (Exception fileEx)
            {
                MessageBox.Show(BagelOpenFileDialog.FileName, fileEx.Message, MessageBoxButtons.OK);
            }
        }

        private void openAndAddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BagelListBox.Items.Add(BagelTextBox.Text);
        }

        private void countBagelTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string numListBoxItems;
            numListBoxItems = BagelListBox.Items.Count.ToString();

            MessageBox.Show("You have " + numListBoxItems + " number of bagel types currently in stock!", 
                            "Item Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BagelListBox.Items.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
