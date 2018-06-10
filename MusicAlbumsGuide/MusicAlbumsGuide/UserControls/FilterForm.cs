using MusicAlbumsGuide.Database;
using MusicAlbumsGuide.Database.Models;
using MusicAlbumsGuide.SharedFormsMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAlbumsGuide.UserControls
{
    public partial class FilterForm : Form
    {
        Form1 parentForm;

        public FilterForm(Form1 parentForm1)
        {
            Opacity = 0;
            parentForm = parentForm1;
            InitializeComponent();
        }

        public void FilterForm_Load(object sender, EventArgs e)
        {
            WindowSizeChanged(sender,e);
            //

            //
            this.Location = new Point( (parentForm.Location.X+parentForm.Size.Width / 2)-this.Size.Width/2, (parentForm.Location.Y +parentForm.Size.Height / 2) - this.Size.Height/2);
            this.Anchor = AnchorStyles.None;
            //
            GenresComboBox.Items.Clear();
            ReleaseYearsComboBox.Items.Clear();
            CarriersComboBox.Items.Clear();
            TypesComboBox.Items.Clear();
            AuthorsComboBox.Items.Clear();
            TracksCountComboBox.Items.Clear();
            ReleasingLabelsComboBox.Items.Clear();
            //
            this.StartPosition = FormStartPosition.CenterParent;
            ControlsChangeMethods.RoundBorderForm(this);
            MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();
            List<Genre> genres = context.Genres.ToList();
            GenresComboBox.InitializeItems(new List<object>(genres));
            List<Album> albums = context.Albums.OrderBy(p=>p.ReleaseYear).ToList();
            List<string> years = new List<string>();

            foreach (var album in albums)
            {
                years.Add(album.ReleaseYear.ToString());
            }
            ReleaseYearsComboBox.InitializeItems(new List<object>(years));
            List<Carrier> carriers = context.Carriers.ToList();
            CarriersComboBox.InitializeItems(new List<object>(carriers));
            List<Database.Models.Type> types = context.Types.ToList();
            TypesComboBox.InitializeItems(new List<object>(types));
            List<Author> authors = context.Authors.ToList();
            AuthorsComboBox.InitializeItems(new List<object>(authors));
            albums = albums.OrderBy(p => p.TrackCount).ToList();
            List<string> trackCounts = new List<string>();
            foreach (var album in albums)
            {
                trackCounts.Add(album.TrackCount.ToString());
            }
            TracksCountComboBox.InitializeItems(new List<object>(trackCounts));
            List<ReleasingLabel> labels = context.ReleasingLabels.ToList();
            ReleasingLabelsComboBox.InitializeItems(new List<object>(labels));
            Show();

        }

        public void WindowSizeChanged(object sender, EventArgs e)
        {
           
            DrawLine(Divider);
            DrawLine(Divider2);

            Divider.Location = new Point(0, Convert.ToInt32(this.Size.Height * 0.1));
            Divider2.Location = new Point(0, this.Size.Height- Convert.ToInt32(this.Size.Height * 0.1));


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            parentForm.Enabled = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parentForm.Enabled = true;
            Close();
            
        }

        private async void GenresComboBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender is CheckComboBoxItem)
            {
                CheckComboBoxItem item = (CheckComboBoxItem)sender;
                if (item.CheckState == true)
                {
                    FilterAndSearchConfig.AddUnsavedFilterGenre(item.Text);
                }
                else if(item.CheckState==false)
                        FilterAndSearchConfig.DeleteUnsavedFilterGenre(item.Text);
                string UNS = FilterAndSearchConfig.UnsavedFilterGenre;
                string result = await Task.Factory.StartNew<string>(
                                                             () => Timer());
                ChangeGenreComboBox();
            }
        }

        private async void ReleasingLabelsComboBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender is CheckComboBoxItem)
            {
                CheckComboBoxItem item = (CheckComboBoxItem)sender;
                if (item.CheckState)
                    FilterAndSearchConfig.AddFilterUnsavedReleasingLabel(item.Text);
                else FilterAndSearchConfig.DeleteFilterUnsavedReleasingLabel(item.Text);
                string result = await Task.Factory.StartNew<string>(
                                                             () => Timer(),
                                                             TaskCreationOptions.LongRunning);
                ChangeReleaseLabelsComboBox();
            }
        }

        private async void TracksCountComboBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender is CheckComboBoxItem)
            {
                CheckComboBoxItem item = (CheckComboBoxItem)sender;
                if (item.CheckState)
                    FilterAndSearchConfig.AddFilterUnsavedTrackCount(item.Text);
                else FilterAndSearchConfig.DeleteFilterUnsavedTrackCount(item.Text);
                string result = await Task.Factory.StartNew<string>(
                                                             () => Timer(),
                                                             TaskCreationOptions.LongRunning);
                ChangeTracksCountComboBox();
            }
        }

        private async void TypesComboBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender is CheckComboBoxItem)
            {
                CheckComboBoxItem item = (CheckComboBoxItem)sender;
                if (item.CheckState)
                    FilterAndSearchConfig.AddFilterUnsavedType(item.Text);
                else FilterAndSearchConfig.DeleteFilterUnsavedType(item.Text);
                string result = await Task.Factory.StartNew<string>(() => Timer(),TaskCreationOptions.LongRunning);
                ChangeTypesComboBox();
            }
        }

        private async void CarriersComboBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender is CheckComboBoxItem)
            {
                CheckComboBoxItem item = (CheckComboBoxItem)sender;
                if (item.CheckState)
                    FilterAndSearchConfig.AddFilterUnsavedCarrier(item.Text);
                else FilterAndSearchConfig.DeleteFilterUnsavedCarrier(item.Text);
                string result = await Task.Factory.StartNew<string>(() => Timer(),TaskCreationOptions.LongRunning);
                ChangeCarriersComboBox();
            }
        }

        private async void ReleaseYearsComboBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender is CheckComboBoxItem)
            {
                CheckComboBoxItem item = (CheckComboBoxItem)sender;
                if (item.CheckState)
                    FilterAndSearchConfig.AddFilterUnsavedReleaseYear(item.Text);
                else FilterAndSearchConfig.DeleteFilterUnsavedReleaseYear(item.Text);
                string result = await Task.Factory.StartNew<string>(() => Timer(), TaskCreationOptions.LongRunning);
                ChangeReleaseYearsComboBox();
            }
        }

        private async void AuthorsComboBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender is CheckComboBoxItem)
            {
                CheckComboBoxItem item = (CheckComboBoxItem)sender;
                if (item.CheckState)
                    FilterAndSearchConfig.AddFilterUnsavedAuthor(item.Text);
                else FilterAndSearchConfig.DeleteFilterUnsavedAuthor(item.Text);
                string result = await Task.Factory.StartNew<string>(() => Timer(), TaskCreationOptions.LongRunning);
                ChangeAuthorsComboBox();
            }
        }

        private void ChangeGenreComboBox()
        {

            if (GenresComboBox.Text != "")
            {
                GenresComboBox.Text = FilterAndSearchConfig.UnsavedFilterGenre;
            }
            if (GenresComboBox.Text == "")
            GenresComboBox.Text = "Выбранные жанры";
        }

        private void ChangeReleaseYearsComboBox()
        {
            if (ReleaseYearsComboBox.Text != "")
                ReleaseYearsComboBox.Text = FilterAndSearchConfig.UnsavedFilterReleaseYear;
            if (ReleaseYearsComboBox.Text == "")
                ReleaseYearsComboBox.Text = "Выбранные года релиза";
        }

        private void ChangeCarriersComboBox()
        {
            if (CarriersComboBox.Text != "")
                CarriersComboBox.Text = FilterAndSearchConfig.UnsavedFilterCarrier;
            if (CarriersComboBox.Text == "")
                CarriersComboBox.Text = "Выбранные носители";
        }

        private void ChangeTypesComboBox()
        {
            if (TypesComboBox.Text != "")
                TypesComboBox.Text = FilterAndSearchConfig.UnsavedFilterType;
            if (TypesComboBox.Text == "")
                TypesComboBox.Text = "Выбранные типы альбомов";
        }

        private void ChangeAuthorsComboBox()
        {
            if (AuthorsComboBox.Text != "")
                AuthorsComboBox.Text = FilterAndSearchConfig.UnsavedFilterAuthor;
            if (AuthorsComboBox.Text == "")
            AuthorsComboBox.Text = "Выбранные авторы";
        }

        private void ChangeTracksCountComboBox()
        {
            if (TracksCountComboBox.Text != "")
                TracksCountComboBox.Text = FilterAndSearchConfig.UnsavedFilterTrackCount;
            if (TracksCountComboBox.Text == "")
                TracksCountComboBox.Text = "Выбранное количество дорожек";
        }

        private void ChangeReleaseLabelsComboBox()
        {
            if (ReleasingLabelsComboBox.Text != "")
                ReleasingLabelsComboBox.Text = FilterAndSearchConfig.UnsavedFilterReleasingLabel;
            if (ReleasingLabelsComboBox.Text == "")
                ReleasingLabelsComboBox.Text = "Выбранные лэйблы";
        }

        private void SaveAndReloadButton_Click(object sender, EventArgs e)
        {
            FilterAndSearchConfig.SaveFilter();
            parentForm.Enabled = true;
            if (parentForm.ContentPanel.Controls.Count == 1)
            {
                if (parentForm.ContentPanel.Controls[0] is BigAlbumView)
                {
                    BigAlbumView buf = (BigAlbumView)parentForm.ContentPanel.Controls[0];
                    if (buf.isSlide()) parentForm.SlideModeButton.PerformClick();
                    Close();
                    return;
                }
            }
            parentForm.HomeButton.PerformClick();
            Close();


        }

        private void ResetFilters_Click(object sender, EventArgs e)
        {
            FilterAndSearchConfig.ClearUnsavedAll();
            ChangeGenreComboBox();
            ChangeAuthorsComboBox();
            ChangeCarriersComboBox();
            ChangeReleaseLabelsComboBox();
            ChangeTracksCountComboBox();
            ChangeTypesComboBox();
            ChangeReleaseYearsComboBox();
        }

        private new void Show()
        {
            Opacity = 0;
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler((sender1, e1) =>
            {
                if ((Opacity += 0.1) >= 1)
                    timer1.Stop();
            });
            timer1.Interval = 1;
            timer1.Start();
        }

        public new void Close()
        {
            Opacity = 1;

            System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler((sender2, e2) =>
            {
                if ((Opacity -= 0.1) <= 0)
                {
                    timer2.Stop();
                    this.Hide();
                }
            });
            timer2.Interval = 1;
            timer2.Start();

        }

        private void DrawLine(Label label)
        {
            label.AutoSize = false;
            label.Height = 2;
            label.BorderStyle = BorderStyle.Fixed3D;
        }

        private string Timer()
        {
            Thread.Sleep(1);
            return "ok";
        }

    }
}

