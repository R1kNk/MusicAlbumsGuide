using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicAlbumsGuide.Database.Models;
using MusicAlbumsGuide.SharedFormsMethods;
using MusicAlbumsGuide.Database;
using System.Data.Entity;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MusicAlbumsGuide.Database.Shared;

namespace MusicAlbumsGuide.UserControls
{
    public partial class AlbumPreview : UserControl
    {
        Album currentAlbum;
        Form1 parentForm;
        public AlbumPreview()
        {
            
            InitializeComponent();
           
        }

        private void AlbumPreview_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ControlsChangeMethods.RoundBorderControl(this);
            ControlsChangeMethods.RoundBorderPanel(this.ContentPanel);
            PdfCreateButton.FlatAppearance.BorderSize = 0;
            //PanelEle

        }

        private void AlbumPreview_Click(object sender, EventArgs e)
        {
            // execute big album view
        }
        public void SetInitVariables(Form1 parent, Album album)
        {
            parentForm = parent;
            currentAlbum = album;
            //
            pictureBox1.Image = ImageMethods.ConvertByteArrayToImage(currentAlbum.CoverPhoto);
            if(currentAlbum.Name.Length<=20)
            AlbumName.Text = currentAlbum.Name;
            else
            {
                string name = default(string);
                for (int i = 0; i < 21; i++)
                {
                    name += currentAlbum.Name[i];
                }
                AlbumName.Text = name;
            }
            ReleaseYear.Text = currentAlbum.ReleaseYear.ToString() + " г.";
            Author.Text = currentAlbum.Author.Name;
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            EditAlbumForm form = new EditAlbumForm(parentForm, currentAlbum.AlbumId,this);
            parentForm.Enabled = false;
            form.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();
            Album albumToDelete = context.Albums.Include(p => p.ReleasingLabel).Include(p => p.Author).Include(p => p.Carrier).Include(p => p.Genre).Include(p => p.Type).Where(p => p.AlbumId == currentAlbum.AlbumId).Single();
            
            ReleasingLabel currentReleasingLabel = albumToDelete.ReleasingLabel;
            string labelName = "";
            string authName = "";
            if (currentReleasingLabel != null)
                if (context.Albums.Where(p => p.ReleasingLabel.ReleasingLabelId == currentReleasingLabel.ReleasingLabelId).ToList().Count == 1) labelName = albumToDelete.ReleasingLabel.Name;
            //
            Author currentAuth = albumToDelete.Author;
            if (currentAuth != null)
                if (context.Albums.Where(p => p.Author.AuthorId == currentAuth.AuthorId).ToList().Count == 1) authName = currentAuth.Name;
            //
            context.Albums.Remove(albumToDelete);
            context.SaveChanges();
            if (labelName != "") context.ReleasingLabels.Remove(context.ReleasingLabels.Where(p => p.Name == labelName).Single());
            context.SaveChanges();
            if (authName != "") context.Authors.Remove(context.Authors.Where(p => p.Name == authName).Single());
            context.SaveChanges();
            parentForm.HomeButton.PerformClick();

        }

        public void SetLocation(int x, int y)
        {
            this.Location = new Point(this.parentForm.ContentPanel.Location.X + x, this.parentForm.ContentPanel.Location.Y + y);
        }

        private void AlbumName_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 151, 31);
            toolTip1.SetToolTip(AlbumName, currentAlbum.Name);
        }

        private void ContentPanel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AlbumName_Click(object sender, EventArgs e)
        {

        }

        private void ReleaseYear_Click(object sender, EventArgs e)
        {

        }


        private void ContentPanel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 151, 31);

        }

        private void ContentPanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 51, 69);

        }

        private void AlbumName_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 51, 69);

        }

        private void Author_Click(object sender, EventArgs e)
        {

        }

        private void Author_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 151, 31);

        }

        private void Author_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 51, 69);

        }

        private void ReleaseYear_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 151, 31);

        }

        private void AlbumPreview_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 151, 31);

        }

        private void AlbumPreview_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 51, 69);

        }

        private void AlbumToPdf_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 151, 31);

        }

        private void AlbumToPdf_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 51, 69);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 151, 31);

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 51, 69);

        }

        private void Edit_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 151, 31);
        }

        private void Edit_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 51, 69);
        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 151, 31);
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 51, 69);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            parentForm.ShowBigViewAlbum(currentAlbum);
        }

        private void AlbumName_DoubleClick(object sender, EventArgs e)
        {
            parentForm.ShowBigViewAlbum(currentAlbum);

        }

        private void Author_DoubleClick(object sender, EventArgs e)
        {
            parentForm.ShowBigViewAlbum(currentAlbum);

        }

        private void ReleaseYear_DoubleClick(object sender, EventArgs e)
        {
            parentForm.ShowBigViewAlbum(currentAlbum);

        }

        private void AlbumPreview_DoubleClick(object sender, EventArgs e)
        {
            parentForm.ShowBigViewAlbum(currentAlbum);

        }

        private void ContentPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            parentForm.ShowBigViewAlbum(currentAlbum);

        }

        private void PdfCreateButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DocumentsMethods.NewDocument(currentAlbum, fbd.SelectedPath);
                }
            }

        }

        private void PdfCreateButton_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PdfCreateButton, "Кликните чтобы создать pdf документ!");
        }

    }
}
