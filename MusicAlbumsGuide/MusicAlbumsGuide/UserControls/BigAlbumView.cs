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

namespace MusicAlbumsGuide.UserControls
{
    public partial class BigAlbumView : UserControl
    {
        Form1 parent;
        Album currentAlbum;
        List<Album> slideALbums;
        int slideIndex = -1;
        public BigAlbumView(Form1 parentForm, Album album = null, List<Album> slideAlbumList=null, int currentIndex=-1)
        {
            parent = parentForm;
            if (slideAlbumList != null)
            {
                if (currentIndex != -1 && currentIndex < slideAlbumList.Count)
                {
                    slideALbums = slideAlbumList;
                    slideIndex = currentIndex;
                    currentAlbum = album;
                }
            }
            else
            if (album != null)
            currentAlbum = album;
  
            InitializeComponent();
           
        }

        private void BigAlbumView_Load(object sender, EventArgs e)
        {

            //Slide
            if (slideIndex != -1)
            {
                if (slideIndex != 0) { SlideLeftButton.Visible = true; SlideLeftButton.FlatAppearance.BorderSize = 0; }
                if (slideIndex != slideALbums.Count - 1) { SlideRightButton.Visible = true; SlideRightButton.FlatAppearance.BorderSize = 0;}
                SlideInfo.Visible = true;
                SlideInfo.Text = $"({slideIndex + 1}/{slideALbums.Count})";
            CloseButton.Visible = false;
                PdfSave.Visible = false;
                Edit.Visible = false;
                Delete.Visible = false;
            }
            //
            pictureBox1.Image = ImageMethods.ConvertByteArrayToImage(currentAlbum.CoverPhoto);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            InitializeData();
            BigAlbumView_SizeChanged(sender,e);
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            parent.HomeButton.PerformClick();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();
            Album albumToDelete = context.Albums.Include(p=>p.ReleasingLabel).Include(p => p.Author).Include(p => p.Carrier).Include(p => p.Genre).Include(p => p.Type).Where(p => p.AlbumId == currentAlbum.AlbumId).Single();

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
            parent.HomeButton.PerformClick();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditAlbumForm form = new EditAlbumForm(parent, currentAlbum.AlbumId, this);
            parent.Enabled = false;
            form.Show();
        }

        private void PdfSave_Click(object sender, EventArgs e)
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

        private void BigAlbumView_SizeChanged(object sender, EventArgs e)
        {
            CloseButton.FlatAppearance.BorderSize = 0;
            PdfSave.FlatAppearance.BorderSize = 0;
            Divider.Location = new Point(0, Convert.ToInt32(this.Size.Height * 0.1));
            Divider2.Location = new Point(0, Convert.ToInt32(this.Size.Height * 0.9));
            DrawLine(Divider);
            DrawLine(Divider2);

        }

        private void AlbumName_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(AlbumName, currentAlbum.Name);

        }

        private void PdfSave_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PdfSave, "Кликните чтобы создать pdf документ!");
        }

        private void SlideRightButton_Click(object sender, EventArgs e)
        {
            parent.ShowBigViewAlbum(slideALbums[slideIndex + 1],true,slideALbums,slideIndex+1);
        }

        private void SlideLeftButton_Click(object sender, EventArgs e)
        {
            parent.ShowBigViewAlbum(slideALbums[slideIndex - 1], true, slideALbums, slideIndex - 1);
        }

        private void DrawLine(Label label)
        {
            label.AutoSize = false;
            label.Height = 2;
            label.BorderStyle = BorderStyle.Fixed3D;
        }

        private void InitializeData()
        {
            if (currentAlbum.Name.Length <= 30)
                AlbumName.Text = currentAlbum.Name;
            else
            {
                string name = default(string);
                for (int i = 0; i < 31; i++)
                {
                    name += currentAlbum.Name[i];
                }
                AlbumName.Text = name;
            }
            //
            AlbumName.Text = currentAlbum.Name;
            AuthorNameLabel.Text = currentAlbum.Author.Name;
            ReleaseYearLabel.Text = currentAlbum.ReleaseYear.ToString();
            GenreLabel.Text = currentAlbum.Genre.Name;
            CarrierTypeLabel.Text = currentAlbum.Carrier.Name;
            TypeLabel.Text = currentAlbum.Type.Name;
            TrackCountLabel.Text = currentAlbum.TrackCount.ToString();
            ReleasingLabelLabel.Text = currentAlbum.ReleasingLabel.Name;
        }

        public bool isSlide()
        {
            if (slideIndex != -1) return true;
            return false;
        }
    }
}
