namespace MusicAlbumsGuide.UserControls
{
    partial class BigAlbumView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigAlbumView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Divider = new System.Windows.Forms.Label();
            this.Divider2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.AlbumName = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.AuthorNameLabel = new System.Windows.Forms.Label();
            this.LabelYear = new System.Windows.Forms.Label();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.LabelCarrier = new System.Windows.Forms.Label();
            this.CarrierTypeLabel = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.LabelTrackCount = new System.Windows.Forms.Label();
            this.TrackCountLabel = new System.Windows.Forms.Label();
            this.LabelReleasingLabel = new System.Windows.Forms.Label();
            this.ReleasingLabelLabel = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PdfSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SlideRightButton = new System.Windows.Forms.Button();
            this.SlideLeftButton = new System.Windows.Forms.Button();
            this.SlideInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Divider
            // 
            this.Divider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Divider.AutoSize = true;
            this.Divider.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Divider.Location = new System.Drawing.Point(-42, 60);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(2713, 13);
            this.Divider.TabIndex = 3;
            this.Divider.Text = resources.GetString("Divider.Text");
            // 
            // Divider2
            // 
            this.Divider2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Divider2.AutoSize = true;
            this.Divider2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Divider2.Location = new System.Drawing.Point(-814, 540);
            this.Divider2.Name = "Divider2";
            this.Divider2.Size = new System.Drawing.Size(2713, 13);
            this.Divider2.TabIndex = 4;
            this.Divider2.Text = resources.GetString("Divider2.Text");
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(17, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(381, 38);
            this.Title.TabIndex = 5;
            this.Title.Text = "Информация о альбоме";
            // 
            // AlbumName
            // 
            this.AlbumName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AlbumName.AutoSize = true;
            this.AlbumName.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlbumName.ForeColor = System.Drawing.Color.White;
            this.AlbumName.Location = new System.Drawing.Point(480, 73);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(268, 44);
            this.AlbumName.TabIndex = 6;
            this.AlbumName.Text = "Имя альбома";
            this.AlbumName.MouseEnter += new System.EventHandler(this.AlbumName_MouseEnter);
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAuthor.ForeColor = System.Drawing.Color.LightGray;
            this.LabelAuthor.Location = new System.Drawing.Point(483, 139);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(92, 29);
            this.LabelAuthor.TabIndex = 7;
            this.LabelAuthor.Text = "Автор:";
            // 
            // AuthorNameLabel
            // 
            this.AuthorNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AuthorNameLabel.AutoSize = true;
            this.AuthorNameLabel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorNameLabel.ForeColor = System.Drawing.Color.White;
            this.AuthorNameLabel.Location = new System.Drawing.Point(572, 139);
            this.AuthorNameLabel.Name = "AuthorNameLabel";
            this.AuthorNameLabel.Size = new System.Drawing.Size(86, 32);
            this.AuthorNameLabel.TabIndex = 8;
            this.AuthorNameLabel.Text = "Автор";
            // 
            // LabelYear
            // 
            this.LabelYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelYear.ForeColor = System.Drawing.Color.Silver;
            this.LabelYear.Location = new System.Drawing.Point(483, 185);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(48, 26);
            this.LabelYear.TabIndex = 9;
            this.LabelYear.Text = "Год:";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearLabel.ForeColor = System.Drawing.Color.White;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(532, 185);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(43, 26);
            this.ReleaseYearLabel.TabIndex = 10;
            this.ReleaseYearLabel.Text = "Год";
            // 
            // LabelGenre
            // 
            this.LabelGenre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGenre.ForeColor = System.Drawing.Color.LightGray;
            this.LabelGenre.Location = new System.Drawing.Point(483, 232);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(75, 29);
            this.LabelGenre.TabIndex = 11;
            this.LabelGenre.Text = "Жанр:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GenreLabel.Location = new System.Drawing.Point(564, 232);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(78, 29);
            this.GenreLabel.TabIndex = 12;
            this.GenreLabel.Text = "Жанр";
            // 
            // LabelCarrier
            // 
            this.LabelCarrier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelCarrier.AutoSize = true;
            this.LabelCarrier.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCarrier.ForeColor = System.Drawing.Color.LightGray;
            this.LabelCarrier.Location = new System.Drawing.Point(483, 296);
            this.LabelCarrier.Name = "LabelCarrier";
            this.LabelCarrier.Size = new System.Drawing.Size(163, 29);
            this.LabelCarrier.TabIndex = 13;
            this.LabelCarrier.Text = "Тип носителя:";
            // 
            // CarrierTypeLabel
            // 
            this.CarrierTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CarrierTypeLabel.AutoSize = true;
            this.CarrierTypeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarrierTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CarrierTypeLabel.Location = new System.Drawing.Point(652, 296);
            this.CarrierTypeLabel.Name = "CarrierTypeLabel";
            this.CarrierTypeLabel.Size = new System.Drawing.Size(152, 30);
            this.CarrierTypeLabel.TabIndex = 14;
            this.CarrierTypeLabel.Text = "Тип носителя";
            // 
            // LabelType
            // 
            this.LabelType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelType.ForeColor = System.Drawing.Color.LightGray;
            this.LabelType.Location = new System.Drawing.Point(483, 366);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(149, 29);
            this.LabelType.TabIndex = 15;
            this.LabelType.Text = "Тип альбома:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TypeLabel.Location = new System.Drawing.Point(638, 366);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(148, 30);
            this.TypeLabel.TabIndex = 16;
            this.TypeLabel.Text = "Тип альбома";
            // 
            // LabelTrackCount
            // 
            this.LabelTrackCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelTrackCount.AutoSize = true;
            this.LabelTrackCount.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTrackCount.ForeColor = System.Drawing.Color.LightGray;
            this.LabelTrackCount.Location = new System.Drawing.Point(483, 429);
            this.LabelTrackCount.Name = "LabelTrackCount";
            this.LabelTrackCount.Size = new System.Drawing.Size(239, 29);
            this.LabelTrackCount.TabIndex = 17;
            this.LabelTrackCount.Text = "Количество дорожек:";
            // 
            // TrackCountLabel
            // 
            this.TrackCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TrackCountLabel.AutoSize = true;
            this.TrackCountLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrackCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrackCountLabel.Location = new System.Drawing.Point(728, 429);
            this.TrackCountLabel.Name = "TrackCountLabel";
            this.TrackCountLabel.Size = new System.Drawing.Size(135, 30);
            this.TrackCountLabel.TabIndex = 18;
            this.TrackCountLabel.Text = "Количество";
            // 
            // LabelReleasingLabel
            // 
            this.LabelReleasingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelReleasingLabel.AutoSize = true;
            this.LabelReleasingLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelReleasingLabel.ForeColor = System.Drawing.Color.LightGray;
            this.LabelReleasingLabel.Location = new System.Drawing.Point(483, 487);
            this.LabelReleasingLabel.Name = "LabelReleasingLabel";
            this.LabelReleasingLabel.Size = new System.Drawing.Size(232, 29);
            this.LabelReleasingLabel.TabIndex = 19;
            this.LabelReleasingLabel.Text = "Выпускающий лэйбл:";
            // 
            // ReleasingLabelLabel
            // 
            this.ReleasingLabelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReleasingLabelLabel.AutoSize = true;
            this.ReleasingLabelLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleasingLabelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReleasingLabelLabel.Location = new System.Drawing.Point(730, 486);
            this.ReleasingLabelLabel.Name = "ReleasingLabelLabel";
            this.ReleasingLabelLabel.Size = new System.Drawing.Size(74, 30);
            this.ReleasingLabelLabel.TabIndex = 20;
            this.ReleasingLabelLabel.Text = "Лэйбл";
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit.Location = new System.Drawing.Point(807, 556);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 40);
            this.Edit.TabIndex = 21;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(957, 556);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 40);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1033, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 48);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PdfSave
            // 
            this.PdfSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PdfSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PdfSave.Image = ((System.Drawing.Image)(resources.GetObject("PdfSave.Image")));
            this.PdfSave.Location = new System.Drawing.Point(732, 552);
            this.PdfSave.Name = "PdfSave";
            this.PdfSave.Size = new System.Drawing.Size(48, 48);
            this.PdfSave.TabIndex = 25;
            this.PdfSave.UseVisualStyleBackColor = true;
            this.PdfSave.Click += new System.EventHandler(this.PdfSave_Click);
            this.PdfSave.MouseEnter += new System.EventHandler(this.PdfSave_MouseEnter);
            // 
            // SlideRightButton
            // 
            this.SlideRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SlideRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlideRightButton.Image = ((System.Drawing.Image)(resources.GetObject("SlideRightButton.Image")));
            this.SlideRightButton.Location = new System.Drawing.Point(1033, 557);
            this.SlideRightButton.Name = "SlideRightButton";
            this.SlideRightButton.Size = new System.Drawing.Size(45, 39);
            this.SlideRightButton.TabIndex = 26;
            this.SlideRightButton.UseVisualStyleBackColor = true;
            this.SlideRightButton.Visible = false;
            this.SlideRightButton.Click += new System.EventHandler(this.SlideRightButton_Click);
            // 
            // SlideLeftButton
            // 
            this.SlideLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SlideLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlideLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("SlideLeftButton.Image")));
            this.SlideLeftButton.Location = new System.Drawing.Point(10, 557);
            this.SlideLeftButton.Name = "SlideLeftButton";
            this.SlideLeftButton.Size = new System.Drawing.Size(45, 39);
            this.SlideLeftButton.TabIndex = 27;
            this.SlideLeftButton.UseVisualStyleBackColor = true;
            this.SlideLeftButton.Visible = false;
            this.SlideLeftButton.Click += new System.EventHandler(this.SlideLeftButton_Click);
            // 
            // SlideInfo
            // 
            this.SlideInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SlideInfo.AutoSize = true;
            this.SlideInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlideInfo.ForeColor = System.Drawing.Color.White;
            this.SlideInfo.Location = new System.Drawing.Point(480, 561);
            this.SlideInfo.Name = "SlideInfo";
            this.SlideInfo.Size = new System.Drawing.Size(170, 25);
            this.SlideInfo.TabIndex = 28;
            this.SlideInfo.Text = "Номер альбома";
            this.SlideInfo.Visible = false;
            // 
            // BigAlbumView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.SlideInfo);
            this.Controls.Add(this.SlideLeftButton);
            this.Controls.Add(this.SlideRightButton);
            this.Controls.Add(this.PdfSave);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.ReleasingLabelLabel);
            this.Controls.Add(this.LabelReleasingLabel);
            this.Controls.Add(this.TrackCountLabel);
            this.Controls.Add(this.LabelTrackCount);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.CarrierTypeLabel);
            this.Controls.Add(this.LabelCarrier);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.LabelGenre);
            this.Controls.Add(this.ReleaseYearLabel);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.AuthorNameLabel);
            this.Controls.Add(this.LabelAuthor);
            this.Controls.Add(this.AlbumName);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Divider2);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BigAlbumView";
            this.Size = new System.Drawing.Size(1084, 600);
            this.Load += new System.EventHandler(this.BigAlbumView_Load);
            this.SizeChanged += new System.EventHandler(this.BigAlbumView_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Divider;
        public System.Windows.Forms.Label Divider2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label AlbumName;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label AuthorNameLabel;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label LabelCarrier;
        private System.Windows.Forms.Label CarrierTypeLabel;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label LabelTrackCount;
        private System.Windows.Forms.Label TrackCountLabel;
        private System.Windows.Forms.Label LabelReleasingLabel;
        private System.Windows.Forms.Label ReleasingLabelLabel;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button PdfSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button SlideRightButton;
        private System.Windows.Forms.Button SlideLeftButton;
        private System.Windows.Forms.Label SlideInfo;
        private System.Windows.Forms.Label ReleaseYearLabel;
    }
}
