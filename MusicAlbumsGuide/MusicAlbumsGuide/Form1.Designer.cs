using MusicAlbumsGuide.Database;
using MusicAlbumsGuide.Database.Models;
using MusicAlbumsGuide.UserControls;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MusicAlbumsGuide
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.AddAlbumButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SlideModeButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.SaveAndReloadButton = new System.Windows.Forms.Button();
            this.ResetData = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SearchTextBox = new MusicAlbumsGuide.UserControls.RoundedTextbox();
            this.MenuPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(72)))));
            this.MenuPanel.Controls.Add(this.TitlePanel);
            this.MenuPanel.Controls.Add(this.HomeButton);
            this.MenuPanel.Controls.Add(this.AddAlbumButton);
            this.MenuPanel.Controls.Add(this.FilterButton);
            this.MenuPanel.Controls.Add(this.SlideModeButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 660);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.SizeChanged += new System.EventHandler(this.MenuPanelSizeChanged);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(200, 150);
            this.TitlePanel.TabIndex = 6;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(0, 150);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(200, 128);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.Text = "Главная";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            this.HomeButton.MouseEnter += new System.EventHandler(this.HomeButton_MouseEnter);
            this.HomeButton.MouseLeave += new System.EventHandler(this.HomeButton_MouseLeave);
            // 
            // AddAlbumButton
            // 
            this.AddAlbumButton.BackColor = System.Drawing.Color.Transparent;
            this.AddAlbumButton.FlatAppearance.BorderSize = 0;
            this.AddAlbumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAlbumButton.ForeColor = System.Drawing.Color.White;
            this.AddAlbumButton.Image = ((System.Drawing.Image)(resources.GetObject("AddAlbumButton.Image")));
            this.AddAlbumButton.Location = new System.Drawing.Point(0, 278);
            this.AddAlbumButton.Name = "AddAlbumButton";
            this.AddAlbumButton.Size = new System.Drawing.Size(200, 128);
            this.AddAlbumButton.TabIndex = 2;
            this.AddAlbumButton.Text = "Добавить альбом";
            this.AddAlbumButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddAlbumButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddAlbumButton.UseVisualStyleBackColor = false;
            this.AddAlbumButton.Click += new System.EventHandler(this.AddAlbumButton_Click);
            this.AddAlbumButton.MouseEnter += new System.EventHandler(this.AddAlbumButton_MouseEnter);
            this.AddAlbumButton.MouseLeave += new System.EventHandler(this.AddAlbumButton_MouseLeave);
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.Transparent;
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.ForeColor = System.Drawing.Color.White;
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.Location = new System.Drawing.Point(0, 406);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(200, 128);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Фильтр";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FilterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            this.FilterButton.MouseEnter += new System.EventHandler(this.FilterButton_MouseEnter);
            this.FilterButton.MouseLeave += new System.EventHandler(this.FilterButton_MouseLeave);
            // 
            // SlideModeButton
            // 
            this.SlideModeButton.BackColor = System.Drawing.Color.Transparent;
            this.SlideModeButton.FlatAppearance.BorderSize = 0;
            this.SlideModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlideModeButton.ForeColor = System.Drawing.Color.White;
            this.SlideModeButton.Image = ((System.Drawing.Image)(resources.GetObject("SlideModeButton.Image")));
            this.SlideModeButton.Location = new System.Drawing.Point(0, 534);
            this.SlideModeButton.Name = "SlideModeButton";
            this.SlideModeButton.Size = new System.Drawing.Size(200, 128);
            this.SlideModeButton.TabIndex = 5;
            this.SlideModeButton.Text = "Режим слайдов";
            this.SlideModeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SlideModeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SlideModeButton.UseVisualStyleBackColor = false;
            this.SlideModeButton.Click += new System.EventHandler(this.SlideModeButton_Click);
            this.SlideModeButton.MouseEnter += new System.EventHandler(this.SlideModeButton_MouseEnter);
            this.SlideModeButton.MouseLeave += new System.EventHandler(this.SlideModeButton_MouseLeave);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(72)))));
            this.InfoPanel.Controls.Add(this.SaveAndReloadButton);
            this.InfoPanel.Controls.Add(this.ResetData);
            this.InfoPanel.Controls.Add(this.SearchPanel);
            this.InfoPanel.Controls.Add(this.InfoLabel);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(200, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1084, 60);
            this.InfoPanel.TabIndex = 1;
            // 
            // SaveAndReloadButton
            // 
            this.SaveAndReloadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveAndReloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveAndReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAndReloadButton.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAndReloadButton.ForeColor = System.Drawing.Color.White;
            this.SaveAndReloadButton.Location = new System.Drawing.Point(393, 15);
            this.SaveAndReloadButton.Name = "SaveAndReloadButton";
            this.SaveAndReloadButton.Size = new System.Drawing.Size(105, 31);
            this.SaveAndReloadButton.TabIndex = 13;
            this.SaveAndReloadButton.Text = "Сортировка";
            this.SaveAndReloadButton.UseVisualStyleBackColor = false;
            this.SaveAndReloadButton.Click += new System.EventHandler(this.SaveAndReloadButton_Click);
            // 
            // ResetData
            // 
            this.ResetData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.ResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetData.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetData.ForeColor = System.Drawing.Color.White;
            this.ResetData.Location = new System.Drawing.Point(504, 15);
            this.ResetData.Name = "ResetData";
            this.ResetData.Size = new System.Drawing.Size(119, 31);
            this.ResetData.TabIndex = 38;
            this.ResetData.Text = "Сбросить фильтр";
            this.ResetData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetData.UseVisualStyleBackColor = false;
            this.ResetData.Click += new System.EventHandler(this.ResetData_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchPanel.Location = new System.Drawing.Point(629, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(455, 60);
            this.SearchPanel.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(384, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(47, 41);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.SearchButton.MouseEnter += new System.EventHandler(this.SearchButton_MouseEnter);
            this.SearchButton.MouseLeave += new System.EventHandler(this.SearchButton_MouseLeave);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(-2, 16);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(370, 24);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Найдено альбомов по фильтру: 8";
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContentPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContentPanel.Location = new System.Drawing.Point(200, 60);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1084, 600);
            this.ContentPanel.TabIndex = 2;
            this.ContentPanel.SizeChanged += new System.EventHandler(this.ContentPanel_SizeChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.SearchTextBox.Location = new System.Drawing.Point(0, 15);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(388, 31);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 660);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicAlbumsGuide";
            this.Load += new System.EventHandler(this.WindowLoad);
            this.SizeChanged += new System.EventHandler(this.WindowSizeChanged);
            this.MenuPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        public System.Windows.Forms.Button SlideModeButton;
        private System.Windows.Forms.Button FilterButton;
        public System.Windows.Forms.Button AddAlbumButton;
        private System.Windows.Forms.Panel InfoPanel;
        public System.Windows.Forms.Label InfoLabel;
        public System.Windows.Forms.Panel ContentPanel;
        public System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Button SearchButton;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private UserControls.RoundedTextbox SearchTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ResetData;
        private System.Windows.Forms.Button SaveAndReloadButton;
    }
}

