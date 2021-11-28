namespace GroupProject
{
    partial class DefaultView
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
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.uxTDLButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Location = new System.Drawing.Point(261, 57);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersWidth = 82;
            this.uxDataGrid.RowTemplate.Height = 33;
            this.uxDataGrid.Size = new System.Drawing.Size(1134, 629);
            this.uxDataGrid.TabIndex = 0;
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uxSearchBox.Location = new System.Drawing.Point(261, 12);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(425, 35);
            this.uxSearchBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 29);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Players";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Show...";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 29);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Teams";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(32, 118);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(111, 29);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Games";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Report Queries";
            // 
            // uxTDLButton
            // 
            this.uxTDLButton.Location = new System.Drawing.Point(32, 269);
            this.uxTDLButton.Name = "uxTDLButton";
            this.uxTDLButton.Size = new System.Drawing.Size(197, 67);
            this.uxTDLButton.TabIndex = 9;
            this.uxTDLButton.Text = "Touchdown Leaders";
            this.uxTDLButton.UseVisualStyleBackColor = true;
            this.uxTDLButton.Click += new System.EventHandler(this.uxTDLButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 67);
            this.button4.TabIndex = 10;
            this.button4.Text = "Team Comparison";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 67);
            this.button5.TabIndex = 11;
            this.button5.Text = "All-purpose yardage";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(32, 488);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 67);
            this.button6.TabIndex = 12;
            this.button6.Text = "Team averages";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // DefaultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 698);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.uxTDLButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "DefaultView";
            this.Text = "DefaultView";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxTDLButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}