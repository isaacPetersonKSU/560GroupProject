
namespace GroupProject
{
    partial class TouchdownLeaders
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
            this.uxSortLabel = new System.Windows.Forms.Label();
            this.uxPassingTDRadButt = new System.Windows.Forms.RadioButton();
            this.uxRecivingTDRadButt = new System.Windows.Forms.RadioButton();
            this.uxRushingTDRadButt = new System.Windows.Forms.RadioButton();
            this.uxTotalTDRadButt = new System.Windows.Forms.RadioButton();
            this.uxDiscriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeight = 46;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(344, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1440, 888);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // uxSortLabel
            // 
            this.uxSortLabel.AutoSize = true;
            this.uxSortLabel.Location = new System.Drawing.Point(18, 144);
            this.uxSortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxSortLabel.Name = "uxSortLabel";
            this.uxSortLabel.Size = new System.Drawing.Size(100, 25);
            this.uxSortLabel.TabIndex = 2;
            this.uxSortLabel.Text = "Sort By...";
            // 
            // uxPassingTDRadButt
            // 
            this.uxPassingTDRadButt.AutoSize = true;
            this.uxPassingTDRadButt.Location = new System.Drawing.Point(24, 202);
            this.uxPassingTDRadButt.Margin = new System.Windows.Forms.Padding(6);
            this.uxPassingTDRadButt.Name = "uxPassingTDRadButt";
            this.uxPassingTDRadButt.Size = new System.Drawing.Size(248, 29);
            this.uxPassingTDRadButt.TabIndex = 3;
            this.uxPassingTDRadButt.TabStop = true;
            this.uxPassingTDRadButt.Text = "Passing Touchdowns";
            this.uxPassingTDRadButt.UseVisualStyleBackColor = true;
            this.uxPassingTDRadButt.CheckedChanged += new System.EventHandler(this.uxRadButtSelectionChanged);
            // 
            // uxRecivingTDRadButt
            // 
            this.uxRecivingTDRadButt.AutoSize = true;
            this.uxRecivingTDRadButt.Location = new System.Drawing.Point(24, 246);
            this.uxRecivingTDRadButt.Margin = new System.Windows.Forms.Padding(6);
            this.uxRecivingTDRadButt.Name = "uxRecivingTDRadButt";
            this.uxRecivingTDRadButt.Size = new System.Drawing.Size(266, 29);
            this.uxRecivingTDRadButt.TabIndex = 4;
            this.uxRecivingTDRadButt.TabStop = true;
            this.uxRecivingTDRadButt.Text = "Receiving Touchdowns";
            this.uxRecivingTDRadButt.UseVisualStyleBackColor = true;
            this.uxRecivingTDRadButt.CheckedChanged += new System.EventHandler(this.uxRadButtSelectionChanged);
            // 
            // uxRushingTDRadButt
            // 
            this.uxRushingTDRadButt.AutoSize = true;
            this.uxRushingTDRadButt.Location = new System.Drawing.Point(24, 290);
            this.uxRushingTDRadButt.Margin = new System.Windows.Forms.Padding(6);
            this.uxRushingTDRadButt.Name = "uxRushingTDRadButt";
            this.uxRushingTDRadButt.Size = new System.Drawing.Size(250, 29);
            this.uxRushingTDRadButt.TabIndex = 5;
            this.uxRushingTDRadButt.TabStop = true;
            this.uxRushingTDRadButt.Text = "Rushing Touchdowns";
            this.uxRushingTDRadButt.UseVisualStyleBackColor = true;
            this.uxRushingTDRadButt.CheckedChanged += new System.EventHandler(this.uxRadButtSelectionChanged);
            // 
            // uxTotalTDRadButt
            // 
            this.uxTotalTDRadButt.AutoSize = true;
            this.uxTotalTDRadButt.Location = new System.Drawing.Point(24, 335);
            this.uxTotalTDRadButt.Margin = new System.Windows.Forms.Padding(6);
            this.uxTotalTDRadButt.Name = "uxTotalTDRadButt";
            this.uxTotalTDRadButt.Size = new System.Drawing.Size(195, 29);
            this.uxTotalTDRadButt.TabIndex = 6;
            this.uxTotalTDRadButt.TabStop = true;
            this.uxTotalTDRadButt.Text = "All Touchdowns";
            this.uxTotalTDRadButt.UseVisualStyleBackColor = true;
            this.uxTotalTDRadButt.CheckedChanged += new System.EventHandler(this.uxRadButtSelectionChanged);
            // 
            // uxDiscriptionLabel
            // 
            this.uxDiscriptionLabel.AutoSize = true;
            this.uxDiscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxDiscriptionLabel.Location = new System.Drawing.Point(806, 9);
            this.uxDiscriptionLabel.Name = "uxDiscriptionLabel";
            this.uxDiscriptionLabel.Size = new System.Drawing.Size(397, 37);
            this.uxDiscriptionLabel.TabIndex = 10;
            this.uxDiscriptionLabel.Text = "Top 50 touchdown scorers";
            // 
            // TouchdownLeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1800, 963);
            this.Controls.Add(this.uxDiscriptionLabel);
            this.Controls.Add(this.uxTotalTDRadButt);
            this.Controls.Add(this.uxRushingTDRadButt);
            this.Controls.Add(this.uxRecivingTDRadButt);
            this.Controls.Add(this.uxPassingTDRadButt);
            this.Controls.Add(this.uxSortLabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TouchdownLeaders";
            this.Text = "Touchdown Leaders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label uxSortLabel;
        private System.Windows.Forms.RadioButton uxPassingTDRadButt;
        private System.Windows.Forms.RadioButton uxRecivingTDRadButt;
        private System.Windows.Forms.RadioButton uxRushingTDRadButt;
        private System.Windows.Forms.RadioButton uxTotalTDRadButt;
        private System.Windows.Forms.Label uxDiscriptionLabel;
    }
}

