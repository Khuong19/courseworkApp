namespace Coursework
{
    partial class hrmmain
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
            menuStrip1 = new MenuStrip();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            addNewDataToolStripMenuItem = new ToolStripMenuItem();
            viewDataByGroupToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            editDataToolStripMenuItem = new ToolStripMenuItem();
            deleteDataToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewDataToolStripMenuItem, viewDataByGroupToolStripMenuItem, editDataToolStripMenuItem, deleteDataToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(67, 20);
            categoryToolStripMenuItem.Text = "Category";
            // 
            // addNewDataToolStripMenuItem
            // 
            addNewDataToolStripMenuItem.Name = "addNewDataToolStripMenuItem";
            addNewDataToolStripMenuItem.Size = new Size(176, 22);
            addNewDataToolStripMenuItem.Text = "Add new data";
            addNewDataToolStripMenuItem.Click += addNewDataToolStripMenuItem_Click;
            // 
            // viewDataByGroupToolStripMenuItem
            // 
            viewDataByGroupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, studentToolStripMenuItem, teacherToolStripMenuItem, adminToolStripMenuItem });
            viewDataByGroupToolStripMenuItem.Name = "viewDataByGroupToolStripMenuItem";
            viewDataByGroupToolStripMenuItem.Size = new Size(176, 22);
            viewDataByGroupToolStripMenuItem.Text = "View data by group";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(115, 22);
            searchToolStripMenuItem.Text = "Search";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(115, 22);
            studentToolStripMenuItem.Text = "Student";
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Size = new Size(115, 22);
            teacherToolStripMenuItem.Text = "Teacher";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(115, 22);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // editDataToolStripMenuItem
            // 
            editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            editDataToolStripMenuItem.Size = new Size(176, 22);
            editDataToolStripMenuItem.Text = "Edit data";
            // 
            // deleteDataToolStripMenuItem
            // 
            deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            deleteDataToolStripMenuItem.Size = new Size(176, 22);
            deleteDataToolStripMenuItem.Text = "Delete data";
            // 
            // hrmmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "hrmmain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desktop Information System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem addNewDataToolStripMenuItem;
        private ToolStripMenuItem viewDataByGroupToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem editDataToolStripMenuItem;
        private ToolStripMenuItem deleteDataToolStripMenuItem;
    }
}