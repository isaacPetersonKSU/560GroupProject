using System;
using System.Windows.Forms;

namespace GroupProject
{
    partial class SeasonView
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
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxPlayersRadButt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uxTeamsRadButt = new System.Windows.Forms.RadioButton();
            this.uxGamesRadButt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.uxTDLButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.uxStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxDateLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.AllowUserToAddRows = false;
            this.uxDataGrid.AllowUserToDeleteRows = false;
            this.uxDataGrid.AllowUserToResizeRows = false;
            this.uxDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Location = new System.Drawing.Point(130, 42);
            this.uxDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxDataGrid.MultiSelect = false;
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.ReadOnly = true;
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.RowHeadersWidth = 82;
            this.uxDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.uxDataGrid.RowTemplate.Height = 33;
            this.uxDataGrid.ShowEditingIcon = false;
            this.uxDataGrid.Size = new System.Drawing.Size(420, 315);
            this.uxDataGrid.TabIndex = 0;
            this.uxDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uxDataGrid_CellMouseClick);
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uxSearchBox.Location = new System.Drawing.Point(262, 6);
            this.uxSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(230, 21);
            this.uxSearchBox.TabIndex = 1;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(494, 5);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(56, 22);
            this.uxSearchButton.TabIndex = 2;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxPlayersRadButt
            // 
            this.uxPlayersRadButt.AutoSize = true;
            this.uxPlayersRadButt.Checked = true;
            this.uxPlayersRadButt.Location = new System.Drawing.Point(16, 62);
            this.uxPlayersRadButt.Margin = new System.Windows.Forms.Padding(2);
            this.uxPlayersRadButt.Name = "uxPlayersRadButt";
            this.uxPlayersRadButt.Size = new System.Drawing.Size(59, 17);
            this.uxPlayersRadButt.TabIndex = 4;
            this.uxPlayersRadButt.TabStop = true;
            this.uxPlayersRadButt.Text = "Players";
            this.uxPlayersRadButt.UseVisualStyleBackColor = true;
            this.uxPlayersRadButt.CheckedChanged += new System.EventHandler(this.uxRadButts_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Show...";
            // 
            // uxTeamsRadButt
            // 
            this.uxTeamsRadButt.AutoSize = true;
            this.uxTeamsRadButt.Location = new System.Drawing.Point(16, 81);
            this.uxTeamsRadButt.Margin = new System.Windows.Forms.Padding(2);
            this.uxTeamsRadButt.Name = "uxTeamsRadButt";
            this.uxTeamsRadButt.Size = new System.Drawing.Size(57, 17);
            this.uxTeamsRadButt.TabIndex = 6;
            this.uxTeamsRadButt.Text = "Teams";
            this.uxTeamsRadButt.UseVisualStyleBackColor = true;
            this.uxTeamsRadButt.CheckedChanged += new System.EventHandler(this.uxRadButts_CheckedChanged);
            // 
            // uxGamesRadButt
            // 
            this.uxGamesRadButt.AutoSize = true;
            this.uxGamesRadButt.Location = new System.Drawing.Point(16, 99);
            this.uxGamesRadButt.Margin = new System.Windows.Forms.Padding(2);
            this.uxGamesRadButt.Name = "uxGamesRadButt";
            this.uxGamesRadButt.Size = new System.Drawing.Size(58, 17);
            this.uxGamesRadButt.TabIndex = 7;
            this.uxGamesRadButt.Text = "Games";
            this.uxGamesRadButt.UseVisualStyleBackColor = true;
            this.uxGamesRadButt.CheckedChanged += new System.EventHandler(this.uxRadButts_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Report Queries";
            // 
            // uxTDLButton
            // 
            this.uxTDLButton.Location = new System.Drawing.Point(16, 154);
            this.uxTDLButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxTDLButton.Name = "uxTDLButton";
            this.uxTDLButton.Size = new System.Drawing.Size(98, 35);
            this.uxTDLButton.TabIndex = 9;
            this.uxTDLButton.Text = "Touchdown Leaders";
            this.uxTDLButton.UseVisualStyleBackColor = true;
            this.uxTDLButton.Click += new System.EventHandler(this.uxTDLButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 192);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "Team Comparison";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 230);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 35);
            this.button5.TabIndex = 11;
            this.button5.Text = "All-purpose yardage";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 268);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 35);
            this.button6.TabIndex = 12;
            this.button6.Text = "Team averages";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // uxStartDatePicker
            // 
            this.uxStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxStartDatePicker.Location = new System.Drawing.Point(212, 7);
            this.uxStartDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.uxStartDatePicker.MaxDate = this.uxEndDatePicker.Value;
            this.uxStartDatePicker.MinDate = new System.DateTime(2020, 9, 10, 0, 0, 0, 0);
            this.uxStartDatePicker.Name = "uxStartDatePicker";
            this.uxStartDatePicker.Size = new System.Drawing.Size(122, 20);
            this.uxStartDatePicker.TabIndex = 14;
            this.uxStartDatePicker.Value = new System.DateTime(2020, 9, 10, 0, 0, 0, 0);
            this.uxStartDatePicker.Visible = false;
            // 
            // uxEndDatePicker
            // 
            this.uxEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxEndDatePicker.Location = new System.Drawing.Point(354, 7);
            this.uxEndDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.uxEndDatePicker.MaxDate = new System.DateTime(2021, 1, 3, 0, 0, 0, 0);
            this.uxEndDatePicker.MinDate = new System.DateTime(2020, 9, 24, 0, 0, 0, 0);
            this.uxEndDatePicker.Name = "uxEndDatePicker";
            this.uxEndDatePicker.Size = new System.Drawing.Size(122, 20);
            this.uxEndDatePicker.TabIndex = 13;
            this.uxEndDatePicker.Value = new System.DateTime(2020, 12, 28, 0, 0, 0, 0);
            this.uxEndDatePicker.Visible = false;
            // 
            // uxDateLabel2
            // 
            this.uxDateLabel2.AutoSize = true;
            this.uxDateLabel2.Location = new System.Drawing.Point(336, 9);
            this.uxDateLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxDateLabel2.Name = "uxDateLabel2";
            this.uxDateLabel2.Size = new System.Drawing.Size(16, 13);
            this.uxDateLabel2.TabIndex = 16;
            this.uxDateLabel2.Text = "to";
            this.uxDateLabel2.Visible = false;
            // 
            // SeasonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 363);
            this.Controls.Add(this.uxDateLabel2);
            this.Controls.Add(this.uxStartDatePicker);
            this.Controls.Add(this.uxEndDatePicker);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.uxTDLButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxGamesRadButt);
            this.Controls.Add(this.uxTeamsRadButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPlayersRadButt);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.uxDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SeasonView";
            this.Text = "NFL Stats";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.RadioButton uxPlayersRadButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton uxTeamsRadButt;
        private System.Windows.Forms.RadioButton uxGamesRadButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxTDLButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker uxStartDatePicker;
        private System.Windows.Forms.Label uxDateLabel2;
        private System.Windows.Forms.DateTimePicker uxEndDatePicker;
    }
}