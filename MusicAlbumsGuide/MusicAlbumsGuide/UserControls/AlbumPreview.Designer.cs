namespace MusicAlbumsGuide.UserControls
{
    partial class AlbumPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumPreview));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AlbumName = new System.Windows.Forms.Label();
            this.ReleaseYear = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.PdfCreateButton = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSize = true;
            this.AlbumName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlbumName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AlbumName.Location = new System.Drawing.Point(3, 2);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(132, 23);
            this.AlbumName.TabIndex = 1;
            this.AlbumName.Text = "Имя альбома";
            this.AlbumName.DoubleClick += new System.EventHandler(this.AlbumName_DoubleClick);
            this.AlbumName.MouseEnter += new System.EventHandler(this.AlbumName_MouseEnter);
            this.AlbumName.MouseLeave += new System.EventHandler(this.AlbumName_MouseLeave);
            // 
            // ReleaseYear
            // 
            this.ReleaseYear.AutoSize = true;
            this.ReleaseYear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.ReleaseYear.Location = new System.Drawing.Point(133, 25);
            this.ReleaseYear.Name = "ReleaseYear";
            this.ReleaseYear.Size = new System.Drawing.Size(77, 16);
            this.ReleaseYear.TabIndex = 2;
            this.ReleaseYear.Text = "Год выпуска";
            this.ReleaseYear.Click += new System.EventHandler(this.ReleaseYear_Click);
            this.ReleaseYear.DoubleClick += new System.EventHandler(this.ReleaseYear_DoubleClick);
            this.ReleaseYear.MouseEnter += new System.EventHandler(this.ReleaseYear_MouseEnter);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit.Location = new System.Drawing.Point(20, 240);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(90, 33);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            this.Edit.MouseEnter += new System.EventHandler(this.Edit_MouseEnter);
            this.Edit.MouseLeave += new System.EventHandler(this.Edit_MouseLeave);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(120, 240);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(90, 33);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            this.Delete.MouseEnter += new System.EventHandler(this.Delete_MouseEnter);
            this.Delete.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.ContentPanel.Controls.Add(this.PdfCreateButton);
            this.ContentPanel.Controls.Add(this.Author);
            this.ContentPanel.Controls.Add(this.pictureBox1);
            this.ContentPanel.Controls.Add(this.Delete);
            this.ContentPanel.Controls.Add(this.Edit);
            this.ContentPanel.Controls.Add(this.AlbumName);
            this.ContentPanel.Controls.Add(this.ReleaseYear);
            this.ContentPanel.Location = new System.Drawing.Point(5, 5);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(230, 280);
            this.ContentPanel.TabIndex = 6;
            this.ContentPanel.Click += new System.EventHandler(this.ContentPanel_Click);
            this.ContentPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ContentPanel_MouseDoubleClick);
            this.ContentPanel.MouseEnter += new System.EventHandler(this.ContentPanel_MouseEnter);
            this.ContentPanel.MouseLeave += new System.EventHandler(this.ContentPanel_MouseLeave);
            // 
            // PdfCreateButton
            // 
            this.PdfCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PdfCreateButton.Image = ((System.Drawing.Image)(resources.GetObject("PdfCreateButton.Image")));
            this.PdfCreateButton.Location = new System.Drawing.Point(190, 0);
            this.PdfCreateButton.Name = "PdfCreateButton";
            this.PdfCreateButton.Size = new System.Drawing.Size(40, 40);
            this.PdfCreateButton.TabIndex = 7;
            this.PdfCreateButton.UseVisualStyleBackColor = true;
            this.PdfCreateButton.Click += new System.EventHandler(this.PdfCreateButton_Click);
            this.PdfCreateButton.MouseEnter += new System.EventHandler(this.PdfCreateButton_MouseEnter);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.ForeColor = System.Drawing.Color.Silver;
            this.Author.Location = new System.Drawing.Point(4, 25);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(45, 17);
            this.Author.TabIndex = 6;
            this.Author.Text = "Автор";
            this.Author.DoubleClick += new System.EventHandler(this.Author_DoubleClick);
            this.Author.MouseEnter += new System.EventHandler(this.Author_MouseEnter);
            this.Author.MouseLeave += new System.EventHandler(this.Author_MouseLeave);
            // 
            // AlbumPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.ContentPanel);
            this.Name = "AlbumPreview";
            this.Size = new System.Drawing.Size(240, 290);
            this.Load += new System.EventHandler(this.AlbumPreview_Load);
            this.Click += new System.EventHandler(this.AlbumPreview_Click);
            this.DoubleClick += new System.EventHandler(this.AlbumPreview_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.AlbumPreview_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.AlbumPreview_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AlbumName;
        private System.Windows.Forms.Label ReleaseYear;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Button PdfCreateButton;
    }
}
