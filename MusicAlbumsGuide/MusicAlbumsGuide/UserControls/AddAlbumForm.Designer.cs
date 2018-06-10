using System;

namespace MusicAlbumsGuide.UserControls
{
    partial class AddAlbumForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlbumForm));
            this.Title = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.Label();
            this.Divider2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveAndReloadButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ReleaseYearsLabel = new System.Windows.Forms.Label();
            this.CarriersLabel = new System.Windows.Forms.Label();
            this.TypesLabel = new System.Windows.Forms.Label();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.TracksCountLabel = new System.Windows.Forms.Label();
            this.ReleasingLabelsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.TrackCountTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseLabelTextBox = new System.Windows.Forms.TextBox();
            this.CoverAlbum = new System.Windows.Forms.PictureBox();
            this.ImaageLabel = new System.Windows.Forms.Label();
            this.UploadImage = new System.Windows.Forms.Button();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.CarrierComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.SaveAndCreateNew = new System.Windows.Forms.Button();
            this.ResetData = new System.Windows.Forms.Button();
            this.GenreErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ReleaseYearErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CarrierTypeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TypeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AuthorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TrackCountErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ReleaseLabelErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CoverAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseYearErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarrierTypeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackCountErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseLabelErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(3, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(365, 28);
            this.Title.TabIndex = 1;
            this.Title.Text = "Добавление нового альбома";
            // 
            // Divider
            // 
            this.Divider.AutoSize = true;
            this.Divider.Location = new System.Drawing.Point(-11, 36);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(1321, 13);
            this.Divider.TabIndex = 2;
            this.Divider.Text = resources.GetString("Divider.Text");
            // 
            // Divider2
            // 
            this.Divider2.AutoSize = true;
            this.Divider2.Location = new System.Drawing.Point(-221, 564);
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
            this.CancelButton.Location = new System.Drawing.Point(97, 570);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(67, 26);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveAndReloadButton
            // 
            this.SaveAndReloadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveAndReloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveAndReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAndReloadButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAndReloadButton.ForeColor = System.Drawing.Color.White;
            this.SaveAndReloadButton.Location = new System.Drawing.Point(310, 570);
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
            this.CloseButton.Location = new System.Drawing.Point(627, 4);
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
            this.GenreLabel.Location = new System.Drawing.Point(5, 214);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(53, 18);
            this.GenreLabel.TabIndex = 14;
            this.GenreLabel.Text = "Жанр:";
            // 
            // ReleaseYearsLabel
            // 
            this.ReleaseYearsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReleaseYearsLabel.AutoSize = true;
            this.ReleaseYearsLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearsLabel.Location = new System.Drawing.Point(5, 268);
            this.ReleaseYearsLabel.Name = "ReleaseYearsLabel";
            this.ReleaseYearsLabel.Size = new System.Drawing.Size(98, 18);
            this.ReleaseYearsLabel.TabIndex = 15;
            this.ReleaseYearsLabel.Text = "Год выпуска";
            // 
            // CarriersLabel
            // 
            this.CarriersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CarriersLabel.AutoSize = true;
            this.CarriersLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarriersLabel.Location = new System.Drawing.Point(5, 321);
            this.CarriersLabel.Name = "CarriersLabel";
            this.CarriersLabel.Size = new System.Drawing.Size(106, 18);
            this.CarriersLabel.TabIndex = 16;
            this.CarriersLabel.Text = "Тип носителя";
            // 
            // TypesLabel
            // 
            this.TypesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypesLabel.AutoSize = true;
            this.TypesLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypesLabel.Location = new System.Drawing.Point(5, 374);
            this.TypesLabel.Name = "TypesLabel";
            this.TypesLabel.Size = new System.Drawing.Size(100, 18);
            this.TypesLabel.TabIndex = 17;
            this.TypesLabel.Text = "Тип альбома";
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorsLabel.Location = new System.Drawing.Point(5, 427);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(51, 18);
            this.AuthorsLabel.TabIndex = 18;
            this.AuthorsLabel.Text = "Автор";
            // 
            // TracksCountLabel
            // 
            this.TracksCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TracksCountLabel.AutoSize = true;
            this.TracksCountLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TracksCountLabel.Location = new System.Drawing.Point(5, 481);
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
            this.ReleasingLabelsLabel.Location = new System.Drawing.Point(5, 534);
            this.ReleasingLabelsLabel.Name = "ReleasingLabelsLabel";
            this.ReleasingLabelsLabel.Size = new System.Drawing.Size(159, 18);
            this.ReleasingLabelsLabel.TabIndex = 20;
            this.ReleasingLabelsLabel.Text = "Выпускающий лэйбл";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(5, 161);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 18);
            this.NameLabel.TabIndex = 21;
            this.NameLabel.Text = "Имя:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NameTextBox.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(170, 161);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.NameTextBox.Size = new System.Drawing.Size(391, 26);
            this.NameTextBox.TabIndex = 22;
            this.NameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReleaseYearTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ReleaseYearTextBox.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(170, 268);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(391, 26);
            this.ReleaseYearTextBox.TabIndex = 24;
            this.ReleaseYearTextBox.Enter += new System.EventHandler(this.ReleaseYearTextBox_Enter);
            this.ReleaseYearTextBox.Leave += new System.EventHandler(this.ReleaseYearTextBox_Leave);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AuthorTextBox.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorTextBox.Location = new System.Drawing.Point(170, 427);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AuthorTextBox.Size = new System.Drawing.Size(391, 26);
            this.AuthorTextBox.TabIndex = 27;
            this.AuthorTextBox.Enter += new System.EventHandler(this.AuthorTextBox_Enter);
            this.AuthorTextBox.Leave += new System.EventHandler(this.AuthorTextBox_Leave);
            // 
            // TrackCountTextBox
            // 
            this.TrackCountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrackCountTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TrackCountTextBox.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrackCountTextBox.Location = new System.Drawing.Point(170, 481);
            this.TrackCountTextBox.Name = "TrackCountTextBox";
            this.TrackCountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TrackCountTextBox.Size = new System.Drawing.Size(391, 26);
            this.TrackCountTextBox.TabIndex = 28;
            this.TrackCountTextBox.Enter += new System.EventHandler(this.TrackCountTextBox_Enter);
            this.TrackCountTextBox.Leave += new System.EventHandler(this.TrackCountTextBox_Leave);
            // 
            // ReleaseLabelTextBox
            // 
            this.ReleaseLabelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReleaseLabelTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ReleaseLabelTextBox.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseLabelTextBox.Location = new System.Drawing.Point(170, 534);
            this.ReleaseLabelTextBox.Name = "ReleaseLabelTextBox";
            this.ReleaseLabelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ReleaseLabelTextBox.Size = new System.Drawing.Size(391, 26);
            this.ReleaseLabelTextBox.TabIndex = 29;
            this.ReleaseLabelTextBox.Enter += new System.EventHandler(this.ReleaseLabelTextBox_Enter);
            this.ReleaseLabelTextBox.Leave += new System.EventHandler(this.ReleaseLabelTextBox_Leave);
            // 
            // CoverAlbum
            // 
            this.CoverAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoverAlbum.Image = ((System.Drawing.Image)(resources.GetObject("CoverAlbum.Image")));
            this.CoverAlbum.InitialImage = ((System.Drawing.Image)(resources.GetObject("CoverAlbum.InitialImage")));
            this.CoverAlbum.Location = new System.Drawing.Point(444, 38);
            this.CoverAlbum.Name = "CoverAlbum";
            this.CoverAlbum.Size = new System.Drawing.Size(117, 117);
            this.CoverAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoverAlbum.TabIndex = 30;
            this.CoverAlbum.TabStop = false;
            this.CoverAlbum.Click += new System.EventHandler(this.CoverAlbum_Click);
            // 
            // ImaageLabel
            // 
            this.ImaageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImaageLabel.AutoSize = true;
            this.ImaageLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImaageLabel.Location = new System.Drawing.Point(5, 82);
            this.ImaageLabel.Name = "ImaageLabel";
            this.ImaageLabel.Size = new System.Drawing.Size(142, 18);
            this.ImaageLabel.TabIndex = 31;
            this.ImaageLabel.Text = "Обложка альбома:";
            // 
            // UploadImage
            // 
            this.UploadImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadImage.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadImage.ForeColor = System.Drawing.Color.White;
            this.UploadImage.Location = new System.Drawing.Point(8, 103);
            this.UploadImage.Name = "UploadImage";
            this.UploadImage.Size = new System.Drawing.Size(82, 32);
            this.UploadImage.TabIndex = 32;
            this.UploadImage.Text = "Загрузить";
            this.UploadImage.UseVisualStyleBackColor = false;
            this.UploadImage.Click += new System.EventHandler(this.UploadImage_Click);
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.BlinkRate = 100;
            this.NameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.NameErrorProvider.ContainerControl = this;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(170, 214);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(391, 26);
            this.GenreComboBox.TabIndex = 33;
            this.GenreComboBox.Enter += new System.EventHandler(this.GenreComboBox_Enter);
            this.GenreComboBox.Leave += new System.EventHandler(this.GenreComboBox_Leave);
            // 
            // CarrierComboBox
            // 
            this.CarrierComboBox.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarrierComboBox.FormattingEnabled = true;
            this.CarrierComboBox.Location = new System.Drawing.Point(170, 321);
            this.CarrierComboBox.Name = "CarrierComboBox";
            this.CarrierComboBox.Size = new System.Drawing.Size(391, 26);
            this.CarrierComboBox.TabIndex = 34;
            this.CarrierComboBox.Enter += new System.EventHandler(this.CarrierComboBox_Enter);
            this.CarrierComboBox.Leave += new System.EventHandler(this.CarrierComboBox_Leave);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(170, 374);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(391, 26);
            this.TypeComboBox.TabIndex = 35;
            this.TypeComboBox.Enter += new System.EventHandler(this.TypeComboBox_Enter);
            this.TypeComboBox.Leave += new System.EventHandler(this.TypeComboBox_Leave);
            // 
            // SaveAndCreateNew
            // 
            this.SaveAndCreateNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveAndCreateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveAndCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAndCreateNew.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAndCreateNew.ForeColor = System.Drawing.Color.White;
            this.SaveAndCreateNew.Location = new System.Drawing.Point(468, 570);
            this.SaveAndCreateNew.Name = "SaveAndCreateNew";
            this.SaveAndCreateNew.Size = new System.Drawing.Size(166, 26);
            this.SaveAndCreateNew.TabIndex = 36;
            this.SaveAndCreateNew.Text = "Сохранить и создать ещё";
            this.SaveAndCreateNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveAndCreateNew.UseVisualStyleBackColor = false;
            this.SaveAndCreateNew.Click += new System.EventHandler(this.SaveAndCreateNew_Click);
            // 
            // ResetData
            // 
            this.ResetData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.ResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetData.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetData.ForeColor = System.Drawing.Color.White;
            this.ResetData.Location = new System.Drawing.Point(175, 570);
            this.ResetData.Name = "ResetData";
            this.ResetData.Size = new System.Drawing.Size(119, 26);
            this.ResetData.TabIndex = 37;
            this.ResetData.Text = "Сбросить данные";
            this.ResetData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetData.UseVisualStyleBackColor = false;
            this.ResetData.Click += new System.EventHandler(this.ResetData_Click);
            // 
            // GenreErrorProvider
            // 
            this.GenreErrorProvider.BlinkRate = 100;
            this.GenreErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.GenreErrorProvider.ContainerControl = this;
            // 
            // ReleaseYearErrorProvider
            // 
            this.ReleaseYearErrorProvider.BlinkRate = 100;
            this.ReleaseYearErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ReleaseYearErrorProvider.ContainerControl = this;
            // 
            // CarrierTypeErrorProvider
            // 
            this.CarrierTypeErrorProvider.BlinkRate = 100;
            this.CarrierTypeErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.CarrierTypeErrorProvider.ContainerControl = this;
            // 
            // TypeErrorProvider
            // 
            this.TypeErrorProvider.BlinkRate = 100;
            this.TypeErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.TypeErrorProvider.ContainerControl = this;
            // 
            // AuthorErrorProvider
            // 
            this.AuthorErrorProvider.BlinkRate = 100;
            this.AuthorErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AuthorErrorProvider.ContainerControl = this;
            // 
            // TrackCountErrorProvider
            // 
            this.TrackCountErrorProvider.BlinkRate = 100;
            this.TrackCountErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.TrackCountErrorProvider.ContainerControl = this;
            // 
            // ReleaseLabelErrorProvider
            // 
            this.ReleaseLabelErrorProvider.BlinkRate = 100;
            this.ReleaseLabelErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ReleaseLabelErrorProvider.ContainerControl = this;
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 600);
            this.Controls.Add(this.ResetData);
            this.Controls.Add(this.SaveAndCreateNew);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.CarrierComboBox);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.UploadImage);
            this.Controls.Add(this.ImaageLabel);
            this.Controls.Add(this.CoverAlbum);
            this.Controls.Add(this.ReleaseLabelTextBox);
            this.Controls.Add(this.TrackCountTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.ReleaseYearTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.ReleaseYearsLabel);
            this.Controls.Add(this.CarriersLabel);
            this.Controls.Add(this.TypesLabel);
            this.Controls.Add(this.AuthorsLabel);
            this.Controls.Add(this.TracksCountLabel);
            this.Controls.Add(this.ReleasingLabelsLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveAndReloadButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Divider2);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterForm";
            this.Activated += new System.EventHandler(this.AddAlbumForm_Activated);
            this.Load += new System.EventHandler(this.AddAlbumForm_Load);
            this.Shown += new System.EventHandler(this.AddAlbumForm_Shown);
            this.SizeChanged += new System.EventHandler(this.WindowSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.CoverAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseYearErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarrierTypeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackCountErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseLabelErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label Divider;
        public System.Windows.Forms.Label Divider2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveAndReloadButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label ReleaseYearsLabel;
        private System.Windows.Forms.Label CarriersLabel;
        private System.Windows.Forms.Label TypesLabel;
        private System.Windows.Forms.Label AuthorsLabel;
        private System.Windows.Forms.Label TracksCountLabel;
        private System.Windows.Forms.Label ReleasingLabelsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox TrackCountTextBox;
        private System.Windows.Forms.TextBox ReleaseLabelTextBox;
        private System.Windows.Forms.PictureBox CoverAlbum;
        private System.Windows.Forms.Label ImaageLabel;
        private System.Windows.Forms.Button UploadImage;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox CarrierComboBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Button SaveAndCreateNew;
        private System.Windows.Forms.Button ResetData;
        private System.Windows.Forms.ErrorProvider GenreErrorProvider;
        private System.Windows.Forms.ErrorProvider ReleaseYearErrorProvider;
        private System.Windows.Forms.ErrorProvider CarrierTypeErrorProvider;
        private System.Windows.Forms.ErrorProvider TypeErrorProvider;
        private System.Windows.Forms.ErrorProvider AuthorErrorProvider;
        private System.Windows.Forms.ErrorProvider TrackCountErrorProvider;
        private System.Windows.Forms.ErrorProvider ReleaseLabelErrorProvider;
    }
}