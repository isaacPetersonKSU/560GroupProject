namespace GroupProject
{
    partial class TeamStats
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
            this.uxTeamTotalGrid = new System.Windows.Forms.DataGridView();
            this.uxTeamTotalsLabel = new System.Windows.Forms.Label();
            this.uxPlayerList = new System.Windows.Forms.DataGridView();
            this.uxPlayerListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamTotalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlayerList)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTeamTotalGrid
            // 
            this.uxTeamTotalGrid.AllowUserToAddRows = false;
            this.uxTeamTotalGrid.AllowUserToDeleteRows = false;
            this.uxTeamTotalGrid.AllowUserToResizeRows = false;
            this.uxTeamTotalGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.uxTeamTotalGrid.ColumnHeadersHeight = 25;
            this.uxTeamTotalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uxTeamTotalGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uxTeamTotalGrid.Location = new System.Drawing.Point(12, 45);
            this.uxTeamTotalGrid.MultiSelect = false;
            this.uxTeamTotalGrid.Name = "uxTeamTotalGrid";
            this.uxTeamTotalGrid.ReadOnly = true;
            this.uxTeamTotalGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxTeamTotalGrid.RowHeadersVisible = false;
            this.uxTeamTotalGrid.RowHeadersWidth = 82;
            this.uxTeamTotalGrid.Size = new System.Drawing.Size(482, 73);
            this.uxTeamTotalGrid.TabIndex = 1;
            // 
            // uxTeamTotalsLabel
            // 
            this.uxTeamTotalsLabel.AutoSize = true;
            this.uxTeamTotalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxTeamTotalsLabel.Location = new System.Drawing.Point(8, 22);
            this.uxTeamTotalsLabel.Name = "uxTeamTotalsLabel";
            this.uxTeamTotalsLabel.Size = new System.Drawing.Size(96, 20);
            this.uxTeamTotalsLabel.TabIndex = 2;
            this.uxTeamTotalsLabel.Text = "Team Totals";
            // 
            // uxPlayerList
            // 
            this.uxPlayerList.AllowUserToAddRows = false;
            this.uxPlayerList.AllowUserToDeleteRows = false;
            this.uxPlayerList.AllowUserToResizeRows = false;
            this.uxPlayerList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.uxPlayerList.ColumnHeadersHeight = 25;
            this.uxPlayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uxPlayerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uxPlayerList.Location = new System.Drawing.Point(12, 144);
            this.uxPlayerList.MultiSelect = false;
            this.uxPlayerList.Name = "uxPlayerList";
            this.uxPlayerList.ReadOnly = true;
            this.uxPlayerList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxPlayerList.RowHeadersVisible = false;
            this.uxPlayerList.RowHeadersWidth = 82;
            this.uxPlayerList.Size = new System.Drawing.Size(482, 168);
            this.uxPlayerList.TabIndex = 3;
            // 
            // uxPlayerListLabel
            // 
            this.uxPlayerListLabel.AutoSize = true;
            this.uxPlayerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxPlayerListLabel.Location = new System.Drawing.Point(15, 121);
            this.uxPlayerListLabel.Name = "uxPlayerListLabel";
            this.uxPlayerListLabel.Size = new System.Drawing.Size(60, 20);
            this.uxPlayerListLabel.TabIndex = 4;
            this.uxPlayerListLabel.Text = "Players";
            // 
            // TeamStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 324);
            this.Controls.Add(this.uxPlayerListLabel);
            this.Controls.Add(this.uxPlayerList);
            this.Controls.Add(this.uxTeamTotalsLabel);
            this.Controls.Add(this.uxTeamTotalGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TeamStats";
            this.Text = "TeamStat";
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamTotalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlayerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxTeamTotalGrid;
        private System.Windows.Forms.Label uxTeamTotalsLabel;
        private System.Windows.Forms.DataGridView uxPlayerList;
        private System.Windows.Forms.Label uxPlayerListLabel;
    }
}