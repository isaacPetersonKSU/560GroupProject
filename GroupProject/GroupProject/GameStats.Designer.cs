namespace GroupProject
{
    partial class GameStats
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
            this.uxAllPurpYardGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxAllPurpYardGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxAllPurpYardGrid
            // 
            this.uxAllPurpYardGrid.AllowUserToAddRows = false;
            this.uxAllPurpYardGrid.AllowUserToDeleteRows = false;
            this.uxAllPurpYardGrid.AllowUserToResizeColumns = false;
            this.uxAllPurpYardGrid.AllowUserToResizeRows = false;
            this.uxAllPurpYardGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.uxAllPurpYardGrid.ColumnHeadersHeight = 25;
            this.uxAllPurpYardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uxAllPurpYardGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uxAllPurpYardGrid.Location = new System.Drawing.Point(12, 119);
            this.uxAllPurpYardGrid.MultiSelect = false;
            this.uxAllPurpYardGrid.Name = "uxAllPurpYardGrid";
            this.uxAllPurpYardGrid.ReadOnly = true;
            this.uxAllPurpYardGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxAllPurpYardGrid.RowHeadersVisible = false;
            this.uxAllPurpYardGrid.RowHeadersWidth = 82;
            this.uxAllPurpYardGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.uxAllPurpYardGrid.Size = new System.Drawing.Size(320, 168);
            this.uxAllPurpYardGrid.TabIndex = 4;
            // 
            // GameStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxAllPurpYardGrid);
            this.Name = "GameStats";
            this.Text = "GameStats";
            ((System.ComponentModel.ISupportInitialize)(this.uxAllPurpYardGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxAllPurpYardGrid;
    }
}