
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
            this.uxSortByComboBox = new System.Windows.Forms.ComboBox();
            this.uxSortLabel = new System.Windows.Forms.Label();
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(802, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // uxSortByComboBox
            // 
            this.uxSortByComboBox.FormattingEnabled = true;
            this.uxSortByComboBox.Location = new System.Drawing.Point(14, 27);
            this.uxSortByComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxSortByComboBox.Name = "uxSortByComboBox";
            this.uxSortByComboBox.Size = new System.Drawing.Size(146, 21);
            this.uxSortByComboBox.TabIndex = 1;
            this.uxSortByComboBox.SelectedIndexChanged += new System.EventHandler(this.uxSortByComboBox_SelectedIndexChanged);
            // 
            // uxSortLabel
            // 
            this.uxSortLabel.AutoSize = true;
            this.uxSortLabel.Location = new System.Drawing.Point(11, 9);
            this.uxSortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxSortLabel.Name = "uxSortLabel";
            this.uxSortLabel.Size = new System.Drawing.Size(50, 13);
            this.uxSortLabel.TabIndex = 2;
            this.uxSortLabel.Text = "Sort By...";
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Location = new System.Drawing.Point(13, 108);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(147, 20);
            this.uxSearchBox.TabIndex = 3;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(48, 134);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(75, 23);
            this.uxSearchButton.TabIndex = 4;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(986, 501);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.uxSortLabel);
            this.Controls.Add(this.uxSortByComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Players";
            this.Text = "NFL Players";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox uxSortByComboBox;
        private System.Windows.Forms.Label uxSortLabel;
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.Button uxSearchButton;
    }
}

