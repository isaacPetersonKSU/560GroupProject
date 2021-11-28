
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
            this.uxSearchTeamButton = new System.Windows.Forms.Button();
            this.uxSearchPlayerButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(172, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(802, 414);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // uxSortLabel
            // 
            this.uxSortLabel.AutoSize = true;
            this.uxSortLabel.Location = new System.Drawing.Point(9, 75);
            this.uxSortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxSortLabel.Name = "uxSortLabel";
            this.uxSortLabel.Size = new System.Drawing.Size(50, 13);
            this.uxSortLabel.TabIndex = 2;
            this.uxSortLabel.Text = "Sort By...";
            // 
            // uxPassingTDRadButt
            // 
            this.uxPassingTDRadButt.AutoSize = true;
            this.uxPassingTDRadButt.Location = new System.Drawing.Point(12, 105);
            this.uxPassingTDRadButt.Name = "uxPassingTDRadButt";
            this.uxPassingTDRadButt.Size = new System.Drawing.Size(127, 17);
            this.uxPassingTDRadButt.TabIndex = 3;
            this.uxPassingTDRadButt.TabStop = true;
            this.uxPassingTDRadButt.Text = "Passing Touchdowns";
            this.uxPassingTDRadButt.UseVisualStyleBackColor = true;
            this.uxPassingTDRadButt.CheckedChanged += new System.EventHandler(this.uxRadButtSelectionChanged);
            // 
            // uxRecivingTDRadButt
            // 
            this.uxRecivingTDRadButt.AutoSize = true;
            this.uxRecivingTDRadButt.Location = new System.Drawing.Point(12, 128);
            this.uxRecivingTDRadButt.Name = "uxRecivingTDRadButt";
            this.uxRecivingTDRadButt.Size = new System.Drawing.Size(138, 17);
            this.uxRecivingTDRadButt.TabIndex = 4;
            this.uxRecivingTDRadButt.TabStop = true;
            this.uxRecivingTDRadButt.Text = "Receiving Touchdowns";
            this.uxRecivingTDRadButt.UseVisualStyleBackColor = true;
            this.uxRecivingTDRadButt.CheckedChanged += new System.EventHandler(this.uxRadButtSelectionChanged);
            // 
            // uxRushingTDRadButt
            // 
            this.uxRushingTDRadButt.AutoSize = true;
            this.uxRushingTDRadButt.Location = new System.Drawing.Point(12, 151);
            this.uxRushingTDRadButt.Name = "uxRushingTDRadButt";
            this.uxRushingTDRadButt.Size = new System.Drawing.Size(129, 17);
            this.uxRushingTDRadButt.TabIndex = 5;
            this.uxRushingTDRadButt.TabStop = true;
            this.uxRushingTDRadButt.Text = "Rushing Touchdowns";
            this.uxRushingTDRadButt.UseVisualStyleBackColor = true;
            this.uxRushingTDRadButt.CheckedChanged += new System.EventHandler(this.uxRadButtSelectionChanged);
            // 
            // uxTotalTDRadButt
            // 
            this.uxTotalTDRadButt.AutoSize = true;
            this.uxTotalTDRadButt.Location = new System.Drawing.Point(12, 174);
            this.uxTotalTDRadButt.Name = "uxTotalTDRadButt";
            this.uxTotalTDRadButt.Size = new System.Drawing.Size(101, 17);
            this.uxTotalTDRadButt.TabIndex = 6;
            this.uxTotalTDRadButt.TabStop = true;
            this.uxTotalTDRadButt.Text = "All Touchdowns";
            this.uxTotalTDRadButt.UseVisualStyleBackColor = true;
            this.uxTotalTDRadButt.CheckedChanged += new System.EventHandler(this.uxRadButtSelectionChanged);
            // 
            // uxSearchTeamButton
            // 
            this.uxSearchTeamButton.Location = new System.Drawing.Point(869, 27);
            this.uxSearchTeamButton.Name = "uxSearchTeamButton";
            this.uxSearchTeamButton.Size = new System.Drawing.Size(105, 23);
            this.uxSearchTeamButton.TabIndex = 7;
            this.uxSearchTeamButton.Text = "Search for Team";
            this.uxSearchTeamButton.UseVisualStyleBackColor = true;
            this.uxSearchTeamButton.Click += new System.EventHandler(this.uxSearchTeamButton_Click);
            // 
            // uxSearchPlayerButton
            // 
            this.uxSearchPlayerButton.Location = new System.Drawing.Point(758, 27);
            this.uxSearchPlayerButton.Name = "uxSearchPlayerButton";
            this.uxSearchPlayerButton.Size = new System.Drawing.Size(105, 23);
            this.uxSearchPlayerButton.TabIndex = 8;
            this.uxSearchPlayerButton.Text = "Search for Player";
            this.uxSearchPlayerButton.UseVisualStyleBackColor = true;
            this.uxSearchPlayerButton.Click += new System.EventHandler(this.uxSearchPlayerButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Location = new System.Drawing.Point(354, 29);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(398, 20);
            this.uxSearchBox.TabIndex = 10;
            // 
            // TouchdownLeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(986, 501);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.uxSearchPlayerButton);
            this.Controls.Add(this.uxSearchTeamButton);
            this.Controls.Add(this.uxTotalTDRadButt);
            this.Controls.Add(this.uxRushingTDRadButt);
            this.Controls.Add(this.uxRecivingTDRadButt);
            this.Controls.Add(this.uxPassingTDRadButt);
            this.Controls.Add(this.uxSortLabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TouchdownLeaders";
            this.Text = "NFL Players";
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
        private System.Windows.Forms.Button uxSearchTeamButton;
        private System.Windows.Forms.Button uxSearchPlayerButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox uxSearchBox;
    }
}

