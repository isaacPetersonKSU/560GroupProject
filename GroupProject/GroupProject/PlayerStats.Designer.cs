﻿
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
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxDataGrid.Location = new System.Drawing.Point(0, 0);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.Size = new System.Drawing.Size(800, 450);
            this.uxDataGrid.TabIndex = 0;
            // 
            // PlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "PlayerStats";
            this.Text = "PlayerStats";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
    }
}