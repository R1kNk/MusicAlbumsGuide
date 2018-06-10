using System;
using System.Windows.Forms;

namespace MusicAlbumsGuide.UserControls
{
    partial class SortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortForm));
            this.Title = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.Label();
            this.Divider2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResetFilters = new System.Windows.Forms.Button();
            this.SaveAndReloadButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ReleaseYearsLabel = new System.Windows.Forms.Label();
            this.TracksCountLabel = new System.Windows.Forms.Label();
            this.BackgrounWorker = new System.ComponentModel.BackgroundWorker();
            this.ReleaseYearSort = new System.Windows.Forms.ComboBox();
            this.TrackCountSort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(3, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(261, 28);
            this.Title.TabIndex = 1;
            this.Title.Text = "Настройка фильтра";
            // 
            // Divider
            // 
            this.Divider.AutoSize = true;
            this.Divider.Location = new System.Drawing.Point(-13, 32);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(1321, 13);
            this.Divider.TabIndex = 2;
            this.Divider.Text = resources.GetString("Divider.Text");
            // 
            // Divider2
            // 
            this.Divider2.AutoSize = true;
            this.Divider2.Location = new System.Drawing.Point(-232, 270);
            this.Divider2.Name = "Divider2";
            this.Divider2.Size = new System.Drawing.Size(1321, 13);
            this.Divider2.TabIndex = 9;
            this.Divider2.Text = resources.GetString("Divider2.Text");
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(263, 301);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(58, 26);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ResetFilters
            // 
            this.ResetFilters.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.ResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetFilters.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetFilters.ForeColor = System.Drawing.Color.White;
            this.ResetFilters.Location = new System.Drawing.Point(343, 301);
            this.ResetFilters.Name = "ResetFilters";
            this.ResetFilters.Size = new System.Drawing.Size(125, 26);
            this.ResetFilters.TabIndex = 11;
            this.ResetFilters.Text = "Сбросить фильтры";
            this.ResetFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetFilters.UseVisualStyleBackColor = false;
            this.ResetFilters.Click += new System.EventHandler(this.ResetFilters_Click);
            // 
            // SaveAndReloadButton
            // 
            this.SaveAndReloadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveAndReloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveAndReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAndReloadButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAndReloadButton.ForeColor = System.Drawing.Color.White;
            this.SaveAndReloadButton.Location = new System.Drawing.Point(486, 301);
            this.SaveAndReloadButton.Name = "SaveAndReloadButton";
            this.SaveAndReloadButton.Size = new System.Drawing.Size(152, 26);
            this.SaveAndReloadButton.TabIndex = 12;
            this.SaveAndReloadButton.Text = "Сохранить и Загрузить";
            this.SaveAndReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveAndReloadButton.UseVisualStyleBackColor = false;
            this.SaveAndReloadButton.Click += new System.EventHandler(this.SaveAndReloadButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(611, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 29);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ReleaseYearsLabel
            // 
            this.ReleaseYearsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReleaseYearsLabel.AutoSize = true;
            this.ReleaseYearsLabel.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearsLabel.Location = new System.Drawing.Point(12, 111);
            this.ReleaseYearsLabel.Name = "ReleaseYearsLabel";
            this.ReleaseYearsLabel.Size = new System.Drawing.Size(207, 34);
            this.ReleaseYearsLabel.TabIndex = 15;
            this.ReleaseYearsLabel.Text = "Года выпуска";
            // 
            // TracksCountLabel
            // 
            this.TracksCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TracksCountLabel.AutoSize = true;
            this.TracksCountLabel.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TracksCountLabel.Location = new System.Drawing.Point(2, 189);
            this.TracksCountLabel.Name = "TracksCountLabel";
            this.TracksCountLabel.Size = new System.Drawing.Size(238, 34);
            this.TracksCountLabel.TabIndex = 19;
            this.TracksCountLabel.Text = "Кол-во дорожек";
            // 
            // BackgrounWorker
            // 
            this.BackgrounWorker.WorkerSupportsCancellation = true;
            // 
            // ReleaseYearSort
            // 
            this.ReleaseYearSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReleaseYearSort.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearSort.FormattingEnabled = true;
            this.ReleaseYearSort.Location = new System.Drawing.Point(263, 111);
            this.ReleaseYearSort.Name = "ReleaseYearSort";
            this.ReleaseYearSort.Size = new System.Drawing.Size(375, 42);
            this.ReleaseYearSort.TabIndex = 22;
            this.ReleaseYearSort.SelectedIndexChanged += new System.EventHandler(this.ReleaseYearSort_SelectedIndexChanged);
            this.ReleaseYearSort.Enter += new System.EventHandler(this.ReleaseYearSort_Enter);
            this.ReleaseYearSort.Leave += new System.EventHandler(this.ReleaseYearSort_Leave);
            // 
            // TrackCountSort
            // 
            this.TrackCountSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TrackCountSort.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrackCountSort.FormattingEnabled = true;
            this.TrackCountSort.Location = new System.Drawing.Point(263, 181);
            this.TrackCountSort.Name = "TrackCountSort";
            this.TrackCountSort.Size = new System.Drawing.Size(375, 42);
            this.TrackCountSort.TabIndex = 23;
            this.TrackCountSort.SelectedIndexChanged += new System.EventHandler(this.TrackCountSort_SelectedIndexChanged);
            this.TrackCountSort.Enter += new System.EventHandler(this.TrackCountSort_Enter);
            this.TrackCountSort.Leave += new System.EventHandler(this.TrackCountSort_Leave);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 330);
            this.Controls.Add(this.TrackCountSort);
            this.Controls.Add(this.ReleaseYearSort);
            this.Controls.Add(this.ReleaseYearsLabel);
            this.Controls.Add(this.TracksCountLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveAndReloadButton);
            this.Controls.Add(this.ResetFilters);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Divider2);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterForm";
            this.Load += new System.EventHandler(this.SortForm_Load);
            this.SizeChanged += new System.EventHandler(this.WindowSizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion
        private System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label Divider;
        public System.Windows.Forms.Label Divider2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ResetFilters;
        private System.Windows.Forms.Button SaveAndReloadButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label ReleaseYearsLabel;
        private System.Windows.Forms.Label TracksCountLabel;
        private System.ComponentModel.BackgroundWorker BackgrounWorker;
        private ComboBox ReleaseYearSort;
        private ComboBox TrackCountSort;
    }
}