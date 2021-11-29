
namespace GroupProject
{
    partial class PlayerStats
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
            this.uxDataTable = new System.Windows.Forms.DataGridView();
            this.uxPlayerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataTable
            // 
            this.uxDataTable.AllowUserToAddRows = false;
            this.uxDataTable.AllowUserToDeleteRows = false;
            this.uxDataTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataTable.Location = new System.Drawing.Point(50, 113);
            this.uxDataTable.Margin = new System.Windows.Forms.Padding(6);
            this.uxDataTable.Name = "uxDataTable";
            this.uxDataTable.ReadOnly = true;
            this.uxDataTable.RowHeadersVisible = false;
            this.uxDataTable.RowHeadersWidth = 82;
            this.uxDataTable.Size = new System.Drawing.Size(1504, 672);
            this.uxDataTable.TabIndex = 0;
            // 
            // uxPlayerLabel
            // 
            this.uxPlayerLabel.AutoSize = true;
            this.uxPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxPlayerLabel.Location = new System.Drawing.Point(670, 9);
            this.uxPlayerLabel.Name = "uxPlayerLabel";
            this.uxPlayerLabel.Size = new System.Drawing.Size(100, 37);
            this.uxPlayerLabel.TabIndex = 1;
            this.uxPlayerLabel.Text = "label1";
            // 
            // PlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.uxPlayerLabel);
            this.Controls.Add(this.uxDataTable);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PlayerStats";
            this.Text = "PlayerStats";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataTable;
        private System.Windows.Forms.Label uxPlayerLabel;
    }
}