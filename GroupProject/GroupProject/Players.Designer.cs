
namespace GroupProject
{
    partial class Players
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touchdownLeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passingTouchdownLeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivingTouchdownLeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rushingTouchdownLeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortPlayersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "uxMenuStrip";
            // 
            // sortPlayersToolStripMenuItem
            // 
            this.sortPlayersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.touchdownLeadersToolStripMenuItem,
            this.passingTouchdownLeadersToolStripMenuItem,
            this.receivingTouchdownLeadersToolStripMenuItem,
            this.rushingTouchdownLeadersToolStripMenuItem});
            this.sortPlayersToolStripMenuItem.Name = "sortPlayersToolStripMenuItem";
            this.sortPlayersToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.sortPlayersToolStripMenuItem.Text = "Sort Players";
            // 
            // touchdownLeadersToolStripMenuItem
            // 
            this.touchdownLeadersToolStripMenuItem.Name = "touchdownLeadersToolStripMenuItem";
            this.touchdownLeadersToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.touchdownLeadersToolStripMenuItem.Text = "Total Touchdown Leaders";
            this.touchdownLeadersToolStripMenuItem.Click += new System.EventHandler(this.touchdownLeadersToolStripMenuItem_Click);
            // 
            // passingTouchdownLeadersToolStripMenuItem
            // 
            this.passingTouchdownLeadersToolStripMenuItem.Name = "passingTouchdownLeadersToolStripMenuItem";
            this.passingTouchdownLeadersToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.passingTouchdownLeadersToolStripMenuItem.Text = "Passing Touchdown Leaders";
            this.passingTouchdownLeadersToolStripMenuItem.Click += new System.EventHandler(this.passingTouchdownLeadersToolStripMenuItem_Click);
            // 
            // receivingTouchdownLeadersToolStripMenuItem
            // 
            this.receivingTouchdownLeadersToolStripMenuItem.Name = "receivingTouchdownLeadersToolStripMenuItem";
            this.receivingTouchdownLeadersToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.receivingTouchdownLeadersToolStripMenuItem.Text = "Receiving Touchdown Leaders";
            this.receivingTouchdownLeadersToolStripMenuItem.Click += new System.EventHandler(this.receivingTouchdownLeadersToolStripMenuItem_Click);
            // 
            // rushingTouchdownLeadersToolStripMenuItem
            // 
            this.rushingTouchdownLeadersToolStripMenuItem.Name = "rushingTouchdownLeadersToolStripMenuItem";
            this.rushingTouchdownLeadersToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.rushingTouchdownLeadersToolStripMenuItem.Text = "Rushing Touchdown Leaders";
            this.rushingTouchdownLeadersToolStripMenuItem.Click += new System.EventHandler(this.rushingTouchdownLeadersToolStripMenuItem_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(544, 384);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Players";
            this.Text = "NFL Players";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem touchdownLeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passingTouchdownLeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivingTouchdownLeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rushingTouchdownLeadersToolStripMenuItem;
    }
}

