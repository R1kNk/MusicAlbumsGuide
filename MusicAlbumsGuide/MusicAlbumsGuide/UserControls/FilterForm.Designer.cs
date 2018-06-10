using System;

namespace MusicAlbumsGuide.UserControls
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.Title = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.Label();
            this.Divider2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResetFilters = new System.Windows.Forms.Button();
            this.SaveAndReloadButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ReleaseYearsLabel = new System.Windows.Forms.Label();
            this.CarriersLabel = new System.Windows.Forms.Label();
            this.TypesLabel = new System.Windows.Forms.Label();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.TracksCountLabel = new System.Windows.Forms.Label();
            this.ReleasingLabelsLabel = new System.Windows.Forms.Label();
            this.BackgrounWorker = new System.ComponentModel.BackgroundWorker();
            this.GenresComboBox = new MusicAlbumsGuide.UserControls.CheckComboBox();
            this.ReleaseYearsComboBox = new MusicAlbumsGuide.UserControls.CheckComboBox();
            this.CarriersComboBox = new MusicAlbumsGuide.UserControls.CheckComboBox();
            this.TypesComboBox = new MusicAlbumsGuide.UserControls.CheckComboBox();
            this.AuthorsComboBox = new MusicAlbumsGuide.UserControls.CheckComboBox();
            this.TracksCountComboBox = new MusicAlbumsGuide.UserControls.CheckComboBox();
            this.ReleasingLabelsComboBox = new MusicAlbumsGuide.UserControls.CheckComboBox();
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
            this.Divider.Location = new System.Drawing.Point(-12, 35);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(1321, 13);
            this.Divider.TabIndex = 2;
            this.Divider.Text = resources.GetString("Divider.Text");
            // 
            // Divider2
            // 
            this.Divider2.AutoSize = true;
            this.Divider2.Location = new System.Drawing.Point(-232, 296);
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
            this.CancelButton.Location = new System.Drawing.Point(263, 321);
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
            this.ResetFilters.Location = new System.Drawing.Point(345, 321);
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
            this.SaveAndReloadButton.Location = new System.Drawing.Point(486, 321);
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
            this.CloseButton.Location = new System.Drawing.Point(611, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 29);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GenreLabel
            // 
            this.GenreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreLabel.Location = new System.Drawing.Point(5, 42);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(60, 18);
            this.GenreLabel.TabIndex = 14;
            this.GenreLabel.Text = "Жанры";
            // 
            // ReleaseYearsLabel
            // 
            this.ReleaseYearsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReleaseYearsLabel.AutoSize = true;
            this.ReleaseYearsLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearsLabel.Location = new System.Drawing.Point(5, 80);
            this.ReleaseYearsLabel.Name = "ReleaseYearsLabel";
            this.ReleaseYearsLabel.Size = new System.Drawing.Size(106, 18);
            this.ReleaseYearsLabel.TabIndex = 15;
            this.ReleaseYearsLabel.Text = "Года выпуска";
            // 
            // CarriersLabel
            // 
            this.CarriersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CarriersLabel.AutoSize = true;
            this.CarriersLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarriersLabel.Location = new System.Drawing.Point(5, 118);
            this.CarriersLabel.Name = "CarriersLabel";
            this.CarriersLabel.Size = new System.Drawing.Size(117, 18);
            this.CarriersLabel.TabIndex = 16;
            this.CarriersLabel.Text = "Типы носителя";
            // 
            // TypesLabel
            // 
            this.TypesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypesLabel.AutoSize = true;
            this.TypesLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypesLabel.Location = new System.Drawing.Point(5, 156);
            this.TypesLabel.Name = "TypesLabel";
            this.TypesLabel.Size = new System.Drawing.Size(119, 18);
            this.TypesLabel.TabIndex = 17;
            this.TypesLabel.Text = "Типы альбомов";
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorsLabel.Location = new System.Drawing.Point(5, 194);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(62, 18);
            this.AuthorsLabel.TabIndex = 18;
            this.AuthorsLabel.Text = "Авторы";
            // 
            // TracksCountLabel
            // 
            this.TracksCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TracksCountLabel.AutoSize = true;
            this.TracksCountLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TracksCountLabel.Location = new System.Drawing.Point(5, 232);
            this.TracksCountLabel.Name = "TracksCountLabel";
            this.TracksCountLabel.Size = new System.Drawing.Size(124, 18);
            this.TracksCountLabel.TabIndex = 19;
            this.TracksCountLabel.Text = "Кол-во дорожек";
            // 
            // ReleasingLabelsLabel
            // 
            this.ReleasingLabelsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReleasingLabelsLabel.AutoSize = true;
            this.ReleasingLabelsLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleasingLabelsLabel.Location = new System.Drawing.Point(5, 270);
            this.ReleasingLabelsLabel.Name = "ReleasingLabelsLabel";
            this.ReleasingLabelsLabel.Size = new System.Drawing.Size(159, 18);
            this.ReleasingLabelsLabel.TabIndex = 20;
            this.ReleasingLabelsLabel.Text = "Выпускающий лэйбл";
            // 
            // BackgrounWorker
            // 
            this.BackgrounWorker.WorkerSupportsCancellation = true;
            // 
            // GenresComboBox
            // 
            this.GenresComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenresComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenresComboBox.DropDownHeight = 100;
            this.GenresComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenresComboBox.FormattingEnabled = true;
            this.GenresComboBox.IntegralHeight = false;
            this.GenresComboBox.Location = new System.Drawing.Point(170, 42);
            this.GenresComboBox.Name = "GenresComboBox";
            this.GenresComboBox.Size = new System.Drawing.Size(470, 25);
            this.GenresComboBox.TabIndex = 0;
            this.GenresComboBox.Text = "Выбранные жанры";
            this.GenresComboBox.CheckStateChanged += new System.EventHandler(this.GenresComboBox_CheckStateChanged);
            // 
            // ReleaseYearsComboBox
            // 
            this.ReleaseYearsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReleaseYearsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ReleaseYearsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearsComboBox.FormattingEnabled = true;
            this.ReleaseYearsComboBox.Location = new System.Drawing.Point(170, 80);
            this.ReleaseYearsComboBox.Name = "ReleaseYearsComboBox";
            this.ReleaseYearsComboBox.Size = new System.Drawing.Size(470, 25);
            this.ReleaseYearsComboBox.TabIndex = 4;
            this.ReleaseYearsComboBox.Text = "Выбранные года релиза";
            this.ReleaseYearsComboBox.CheckStateChanged += new System.EventHandler(this.ReleaseYearsComboBox_CheckStateChanged);
            // 
            // CarriersComboBox
            // 
            this.CarriersComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CarriersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CarriersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarriersComboBox.FormattingEnabled = true;
            this.CarriersComboBox.Location = new System.Drawing.Point(170, 118);
            this.CarriersComboBox.Name = "CarriersComboBox";
            this.CarriersComboBox.Size = new System.Drawing.Size(470, 25);
            this.CarriersComboBox.TabIndex = 5;
            this.CarriersComboBox.Text = "Выбранные носители";
            this.CarriersComboBox.CheckStateChanged += new System.EventHandler(this.CarriersComboBox_CheckStateChanged);
            // 
            // TypesComboBox
            // 
            this.TypesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypesComboBox.FormattingEnabled = true;
            this.TypesComboBox.Location = new System.Drawing.Point(170, 156);
            this.TypesComboBox.Name = "TypesComboBox";
            this.TypesComboBox.Size = new System.Drawing.Size(470, 25);
            this.TypesComboBox.TabIndex = 6;
            this.TypesComboBox.Text = "Выбранные типы альбомов";
            this.TypesComboBox.CheckStateChanged += new System.EventHandler(this.TypesComboBox_CheckStateChanged);
            // 
            // AuthorsComboBox
            // 
            this.AuthorsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AuthorsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorsComboBox.FormattingEnabled = true;
            this.AuthorsComboBox.Location = new System.Drawing.Point(170, 194);
            this.AuthorsComboBox.Name = "AuthorsComboBox";
            this.AuthorsComboBox.Size = new System.Drawing.Size(470, 25);
            this.AuthorsComboBox.TabIndex = 3;
            this.AuthorsComboBox.Text = "Выбранные авторы";
            this.AuthorsComboBox.CheckStateChanged += new System.EventHandler(this.AuthorsComboBox_CheckStateChanged);
            // 
            // TracksCountComboBox
            // 
            this.TracksCountComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TracksCountComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TracksCountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TracksCountComboBox.FormattingEnabled = true;
            this.TracksCountComboBox.Location = new System.Drawing.Point(170, 232);
            this.TracksCountComboBox.Name = "TracksCountComboBox";
            this.TracksCountComboBox.Size = new System.Drawing.Size(470, 25);
            this.TracksCountComboBox.TabIndex = 7;
            this.TracksCountComboBox.Text = "Выбранное количество дорожек";
            this.TracksCountComboBox.CheckStateChanged += new System.EventHandler(this.TracksCountComboBox_CheckStateChanged);
            // 
            // ReleasingLabelsComboBox
            // 
            this.ReleasingLabelsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReleasingLabelsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ReleasingLabelsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleasingLabelsComboBox.FormattingEnabled = true;
            this.ReleasingLabelsComboBox.Location = new System.Drawing.Point(170, 270);
            this.ReleasingLabelsComboBox.Name = "ReleasingLabelsComboBox";
            this.ReleasingLabelsComboBox.Size = new System.Drawing.Size(470, 25);
            this.ReleasingLabelsComboBox.TabIndex = 8;
            this.ReleasingLabelsComboBox.Text = "Выбранные лэйблы";
            this.ReleasingLabelsComboBox.CheckStateChanged += new System.EventHandler(this.ReleasingLabelsComboBox_CheckStateChanged);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.ReleaseYearsLabel);
            this.Controls.Add(this.CarriersLabel);
            this.Controls.Add(this.TypesLabel);
            this.Controls.Add(this.AuthorsLabel);
            this.Controls.Add(this.TracksCountLabel);
            this.Controls.Add(this.ReleasingLabelsLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveAndReloadButton);
            this.Controls.Add(this.ResetFilters);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Divider2);
            this.Controls.Add(this.GenresComboBox);
            this.Controls.Add(this.ReleaseYearsComboBox);
            this.Controls.Add(this.CarriersComboBox);
            this.Controls.Add(this.TypesComboBox);
            this.Controls.Add(this.AuthorsComboBox);
            this.Controls.Add(this.TracksCountComboBox);
            this.Controls.Add(this.ReleasingLabelsComboBox);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.SizeChanged += new System.EventHandler(this.WindowSizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private CheckComboBox GenresComboBox;
        private System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label Divider;
        private CheckComboBox AuthorsComboBox;
        private CheckComboBox ReleaseYearsComboBox;
        private CheckComboBox CarriersComboBox;
        private CheckComboBox TypesComboBox;
        private CheckComboBox TracksCountComboBox;
        private CheckComboBox ReleasingLabelsComboBox;
        public System.Windows.Forms.Label Divider2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ResetFilters;
        private System.Windows.Forms.Button SaveAndReloadButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label ReleaseYearsLabel;
        private System.Windows.Forms.Label CarriersLabel;
        private System.Windows.Forms.Label TypesLabel;
        private System.Windows.Forms.Label AuthorsLabel;
        private System.Windows.Forms.Label TracksCountLabel;
        private System.Windows.Forms.Label ReleasingLabelsLabel;
        private System.ComponentModel.BackgroundWorker BackgrounWorker;

       
    }
}