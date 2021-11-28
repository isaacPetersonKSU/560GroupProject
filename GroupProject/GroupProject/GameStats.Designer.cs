
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
            this.uxDataGridHome = new System.Windows.Forms.DataGridView();
            this.uxDataGridAway = new System.Windows.Forms.DataGridView();
            this.uxHomeLabel = new System.Windows.Forms.Label();
            this.uxAwayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridAway)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGridHome
            // 
            this.uxDataGridHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGridHome.Location = new System.Drawing.Point(12, 32);
            this.uxDataGridHome.Name = "uxDataGridHome";
            this.uxDataGridHome.Size = new System.Drawing.Size(900, 201);
            this.uxDataGridHome.TabIndex = 0;
            // 
            // uxDataGridAway
            // 
            this.uxDataGridAway.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGridAway.Location = new System.Drawing.Point(12, 269);
            this.uxDataGridAway.Name = "uxDataGridAway";
            this.uxDataGridAway.Size = new System.Drawing.Size(900, 201);
            this.uxDataGridAway.TabIndex = 1;
            // 
            // uxHomeLabel
            // 
            this.uxHomeLabel.AutoSize = true;
            this.uxHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeLabel.Location = new System.Drawing.Point(12, 5);
            this.uxHomeLabel.Name = "uxHomeLabel";
            this.uxHomeLabel.Size = new System.Drawing.Size(131, 24);
            this.uxHomeLabel.TabIndex = 2;
            this.uxHomeLabel.Text = "Home Team:";
            // 
            // uxAwayLabel
            // 
            this.uxAwayLabel.AutoSize = true;
            this.uxAwayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAwayLabel.Location = new System.Drawing.Point(12, 242);
            this.uxAwayLabel.Name = "uxAwayLabel";
            this.uxAwayLabel.Size = new System.Drawing.Size(125, 24);
            this.uxAwayLabel.TabIndex = 3;
            this.uxAwayLabel.Text = "Away Team:";
            // 
            // GameStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 487);
            this.Controls.Add(this.uxAwayLabel);
            this.Controls.Add(this.uxHomeLabel);
            this.Controls.Add(this.uxDataGridAway);
            this.Controls.Add(this.uxDataGridHome);
            this.Name = "GameStats";
            this.Text = "GameStats";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGridHome;
        private System.Windows.Forms.DataGridView uxDataGridAway;
        private System.Windows.Forms.Label uxHomeLabel;
        private System.Windows.Forms.Label uxAwayLabel;
    }
}