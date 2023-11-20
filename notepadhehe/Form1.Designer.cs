namespace notepadhehe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pASTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELECTALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATETIMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORMATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fONTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.fORMATToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.oPENToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            this.fILEToolStripMenuItem.Click += new System.EventHandler(this.fILEToolStripMenuItem_Click);
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nEWToolStripMenuItem.Text = "NEW          ";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.oPENToolStripMenuItem.Text = "OPEN         ";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.sAVEToolStripMenuItem.Text = "SAVE          ";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNDOToolStripMenuItem,
            this.rEDOToolStripMenuItem,
            this.cOPYToolStripMenuItem,
            this.pASTEToolStripMenuItem,
            this.cUTToolStripMenuItem,
            this.sELECTALLToolStripMenuItem,
            this.dATETIMEToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // uNDOToolStripMenuItem
            // 
            this.uNDOToolStripMenuItem.Name = "uNDOToolStripMenuItem";
            this.uNDOToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.uNDOToolStripMenuItem.Text = "UNDO         ";
            this.uNDOToolStripMenuItem.Click += new System.EventHandler(this.uNDOToolStripMenuItem_Click);
            // 
            // rEDOToolStripMenuItem
            // 
            this.rEDOToolStripMenuItem.Name = "rEDOToolStripMenuItem";
            this.rEDOToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rEDOToolStripMenuItem.Text = "REDO          ";
            this.rEDOToolStripMenuItem.Click += new System.EventHandler(this.rEDOToolStripMenuItem_Click);
            // 
            // cOPYToolStripMenuItem
            // 
            this.cOPYToolStripMenuItem.Name = "cOPYToolStripMenuItem";
            this.cOPYToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cOPYToolStripMenuItem.Text = "COPY           ";
            this.cOPYToolStripMenuItem.Click += new System.EventHandler(this.cOPYToolStripMenuItem_Click);
            // 
            // pASTEToolStripMenuItem
            // 
            this.pASTEToolStripMenuItem.Name = "pASTEToolStripMenuItem";
            this.pASTEToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pASTEToolStripMenuItem.Text = "PASTE          ";
            this.pASTEToolStripMenuItem.Click += new System.EventHandler(this.pASTEToolStripMenuItem_Click);
            // 
            // cUTToolStripMenuItem
            // 
            this.cUTToolStripMenuItem.Name = "cUTToolStripMenuItem";
            this.cUTToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cUTToolStripMenuItem.Text = "CUT             ";
            this.cUTToolStripMenuItem.Click += new System.EventHandler(this.cUTToolStripMenuItem_Click);
            // 
            // sELECTALLToolStripMenuItem
            // 
            this.sELECTALLToolStripMenuItem.Name = "sELECTALLToolStripMenuItem";
            this.sELECTALLToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sELECTALLToolStripMenuItem.Text = "SELECT ALL   ";
            this.sELECTALLToolStripMenuItem.Click += new System.EventHandler(this.sELECTALLToolStripMenuItem_Click);
            // 
            // dATETIMEToolStripMenuItem
            // 
            this.dATETIMEToolStripMenuItem.Name = "dATETIMEToolStripMenuItem";
            this.dATETIMEToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dATETIMEToolStripMenuItem.Text = "DATE TIME";
            this.dATETIMEToolStripMenuItem.Click += new System.EventHandler(this.dATETIMEToolStripMenuItem_Click);
            // 
            // fORMATToolStripMenuItem
            // 
            this.fORMATToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fONTToolStripMenuItem,
            this.cOLORToolStripMenuItem});
            this.fORMATToolStripMenuItem.Name = "fORMATToolStripMenuItem";
            this.fORMATToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.fORMATToolStripMenuItem.Text = "FORMAT";
            this.fORMATToolStripMenuItem.Click += new System.EventHandler(this.fORMATToolStripMenuItem_Click);
            // 
            // fONTToolStripMenuItem
            // 
            this.fONTToolStripMenuItem.Name = "fONTToolStripMenuItem";
            this.fONTToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.fONTToolStripMenuItem.Text = "FONT";
            this.fONTToolStripMenuItem.Click += new System.EventHandler(this.fONTToolStripMenuItem_Click);
            // 
            // cOLORToolStripMenuItem
            // 
            this.cOLORToolStripMenuItem.Name = "cOLORToolStripMenuItem";
            this.cOLORToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.cOLORToolStripMenuItem.Text = "COLOR";
            this.cOLORToolStripMenuItem.Click += new System.EventHandler(this.cOLORToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(535, 311);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(535, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 335);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NOTEPADNIHEHE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOPYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pASTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORMATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fONTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELECTALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATETIMEToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

