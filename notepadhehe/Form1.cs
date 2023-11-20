using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepadhehe
{
    public partial class Form1 : Form
    {
        private SaveFileDialog savefileDialog;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            oPENToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            sAVEToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            nEWToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            uNDOToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            rEDOToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            cOPYToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            pASTEToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            cUTToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            sELECTALLToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            richTextBox1.SelectionChanged += new EventHandler(richTextBox1_TextChanged);


        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    if (richTextBox1.Modified)
                    {
                        DialogResult result = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            savefile();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            e.Cancel = true; // Cancel the closing action
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fORMATToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newfile();
        }
        private void Newfile() 
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        savefile();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else
                {
                    this.richTextBox1.Text = string.Empty;
                    this.Text = "Untitled hehe";
                }
            }
            catch(Exception ex)
            {

            }
            finally 
            {
            
            }
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "open";
            op.Filter = "Text Document(*.txt)|*.txt| All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            this.Text = op.FileName;

        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile();
        }
         // save
        private void savefile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    savefileDialog = new SaveFileDialog();

                    if (savefileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(savefileDialog.FileName, this.richTextBox1.Text);
                    }
                }
                else 
                {
                    MessageBox.Show("This file is empty");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    if (richTextBox1.Modified)
                    {
                        DialogResult result = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            savefile(); 
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void uNDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Undo
            richTextBox1.Undo();
        }

        private void rEDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Redo
            richTextBox1.Redo();
        }

        private void cOPYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Copy
            richTextBox1.Copy();
        }

        private void pASTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Paste
            richTextBox1.Paste();

        }

        private void cUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cut
            richTextBox1.Cut();


        }

        private void sELECTALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAll
            richTextBox1.SelectAll();

        }

        private void dATETIMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Date Time
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void fONTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Font
            FontDialog op = new FontDialog();
            if (op.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = op.Font;
        }

        private void cOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Color
            ColorDialog op = new ColorDialog();
            if (op.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = op.Color;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int currentLine = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1;
            int currentColumn = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(currentLine - 1) + 1;

            toolStripStatusLabel1.Text = $"Ln {currentLine}, Col {currentColumn}";
        }

    }
}
