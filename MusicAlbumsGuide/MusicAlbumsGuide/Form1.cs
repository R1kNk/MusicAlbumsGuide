using MusicAlbumsGuide.Database;
using MusicAlbumsGuide.Database.Models;
using MusicAlbumsGuide.Database.Shared;
using MusicAlbumsGuide.SharedFormsMethods;
using MusicAlbumsGuide.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusicAlbumsGuide
{
    public partial class Form1 : Form
    {
        FilterForm filterForm;
        SortForm sortForm;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void WindowSizeChanged(object sender, EventArgs e)
        {

            this.ContentPanel.Size = new Size(this.Size.Width - this.MenuPanel.Size.Width-10, this.Size.Height - this.InfoPanel.Size.Height-40);

            InitializeAlbumsPreviewLocation();
            
        }

        private void MenuPanelSizeChanged(object sender, EventArgs e)
        {
            int CurrentHeightLocation = this.TitlePanel.Size.Height;
            double Percents = 1.0/(this.MenuPanel.Controls.Count-1);
            
            foreach (Control control in this.MenuPanel.Controls)
            {
                if (control.Name != "TitlePanel")
                {
                    control.Size = new Size(this.MenuPanel.Width, Convert.ToInt32((this.MenuPanel.Height-this.TitlePanel.Size.Height) * Percents));
                    control.Location = new Point(control.Location.X, CurrentHeightLocation);
                    CurrentHeightLocation += control.Size.Height;
                    if (Width > 1300)
                    {
                        control.Font = new Font(control.Font.Name, Convert.ToInt32(control.Font.Size * (1.5)));
                    }
                    else
                    {
                        control.Font = new Font(control.Font.Name, 12);
                    }

                }
            }

        }

        private void WindowLoad(object sender, EventArgs e)
        {
            this.ContentPanel.Size = new Size(this.Size.Width - this.MenuPanel.Size.Width, this.Size.Height - this.InfoPanel.Size.Height-40);
            this.MenuPanelSizeChanged(sender, e);
            this.SearchTextBox_Leave(sender,e);
            HomeButton.PerformClick();
        }

        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
            this.HomeButton.BackColor = Color.FromArgb(19, 21, 26);
        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            this.HomeButton.BackColor = Color.Transparent;
        }

        private void AddAlbumButton_MouseEnter(object sender, EventArgs e)
        {
            this.AddAlbumButton.BackColor = Color.FromArgb(19, 21, 26);
        }

        private void AddAlbumButton_MouseLeave(object sender, EventArgs e)
        {
            this.AddAlbumButton.BackColor = Color.Transparent;
        }

        private void FilterButton_MouseEnter(object sender, EventArgs e)
        {
            this.FilterButton.BackColor = Color.FromArgb(19, 21, 26);
        }

        private void FilterButton_MouseLeave(object sender, EventArgs e)
        {
            this.FilterButton.BackColor = Color.Transparent;
        }

        private void SlideModeButton_MouseEnter(object sender, EventArgs e)
        {
            this.SlideModeButton.BackColor = Color.FromArgb(19, 21, 26);
        }

        private void SlideModeButton_MouseLeave(object sender, EventArgs e)
        {
            this.SlideModeButton.BackColor = Color.Transparent;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            InitializeAlbumsPreview();
            //int SpaceColumnBetween = (ContentPanelHeight % 290)
            //Scroll panel
           
           

        }
        
        private void AddAlbumButton_Click(object sender, EventArgs e)
        {
            int index = MenuPanel.Controls.IndexOf(AddAlbumButton);
            index--;
            AddAlbumForm addAlbumForm = new AddAlbumForm(this);
            this.Enabled = false;
            addAlbumForm.Show();

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (filterForm == null)
                filterForm = new FilterForm(this);
            else
            {
                filterForm.BringToFront();
                filterForm.FilterForm_Load(sender, e);
            }
            this.Enabled = false;
            filterForm.Show();
            //comboBox1.Items.Add("lul");
            //comboBox1.Items.Add("kek");
            //comboBox1.Items.Add("aru");

        }

        private void SlideModeButton_Click(object sender, EventArgs e)
        {
            List <Album> data = GetDataByFilter();
            if (data.Count != 0)
                ShowBigViewAlbum(data[0], true, data, 0);
            //
        }
       
        private void SearchButton_MouseEnter(object sender, EventArgs e)
        {
            this.SearchButton.BackColor = Color.FromArgb(19, 21, 26);

        }

        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
            this.SearchButton.BackColor = Color.Transparent;

        }

        private void ContentPanel_SizeChanged(object sender, EventArgs e)
        {
           
        }
       
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if(SearchTextBox.Text=="Введите ключевые слова для поиска")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.White;
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Введите ключевые слова для поиска";
                SearchTextBox.ForeColor = Color.Gray;

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SearchTextBox.Text=="Введите ключевые слова для поиска")
            {
                errorProvider1.SetError(SearchTextBox, "Нужно заполнить поле для поиска!");
                return;
            }
            string[] words = SearchTextBox.Text.Split(' ');
            MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();
            List<Album> allAlbums = context.Albums.Include(p => p.Author).Include(p => p.Carrier).Include(p => p.Genre).Include(p => p.ReleasingLabel).Include(p => p.Type).ToList();
            List<Album> findedAlbums = new List<Album>();
            List<Album> result = new List<Album>();

            foreach (string s in words)
            {
                 findedAlbums = allAlbums.Where(p => (p.Genre.Name == s)||(p.Genre.Name.Contains(s))||(p.Name==s)||(p.Name.Contains(s))||(p.Author.Name==s)||(p.Author.Name.Contains(s))
                ||(p.Carrier.Name==s)||(p.Carrier.Name.Contains(s))||(p.ReleaseYear.ToString()==s)||(p.ReleaseYear.ToString().Contains(s))||(p.ReleasingLabel.Name==s)||(p.ReleasingLabel.Name.Contains(s))
                ||(p.TrackCount.ToString()==s)||(p.TrackCount.ToString().Contains(s))||(p.Type.Name==s)||(p.Type.Name.Contains(s))).ToList();
                foreach (Album a in findedAlbums)
                {
                    if (result.Contains(a)) continue;
                    result.Add(a);
                }
            }
            InitializeAlbumsPreview(result);
        }

        private void ResetData_Click(object sender, EventArgs e)
        {
            FilterAndSearchConfig.ClearAll();
            if (this.ContentPanel.Controls.Count == 1)
            {
                if (this.ContentPanel.Controls[0] is BigAlbumView)
                {
                    BigAlbumView buf = (BigAlbumView)this.ContentPanel.Controls[0];
                    if (buf.isSlide()) this.SlideModeButton.PerformClick();
                    return;
                }
            }
            HomeButton.PerformClick();
        }

        private void SaveAndReloadButton_Click(object sender, EventArgs e)
        {
            if (sortForm == null)
                sortForm = new SortForm(this);
            else sortForm.BringToFront();
            sortForm.SortForm_Load(sender,e);
            this.Enabled = false;
            sortForm.Show();
        }

        private void InitializeAlbumsPreviewLocation()
        {
            System.Windows.Forms.Control.ControlCollection data = ContentPanel.Controls;
            if (data.Count != 0)
            {
                int ContentPanelWidth = ContentPanel.Size.Width;
                int ContentPanelHeight = ContentPanel.Size.Height;

                int CountAlbumsInARow = ContentPanelWidth / 240;
                //if (CountAlbumsInARow > data.Count) CountAlbumsInARow = data.Count;
                if (CountAlbumsInARow != 0)
                {
                    int SpaceBetween = ((ContentPanelWidth - (CountAlbumsInARow * 240)) / CountAlbumsInARow) - 2;
                    int currentWidth = SpaceBetween / 2;
                    int currentHeight = 5;
                    int rowCounter = 1;
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (rowCounter > CountAlbumsInARow)
                        {
                            currentWidth = SpaceBetween / 2;
                            currentHeight += (10 + data[0].Size.Height);
                            rowCounter = 1;
                        }
                        data[i].Location = new Point(currentWidth, currentHeight);
                        data[i].Show();
                        currentWidth = (currentWidth + (SpaceBetween + data[i].Size.Width));
                        rowCounter++;
                    }
                }
            }

        }

        private void InitializeAlbumsPreview(List<Album> data = null)
        {
            string msg;
            if (data == null)
            {
                data = GetDataByFilter();
                msg = "Найдено альбомов по фильтру: " + data.Count.ToString();
            }
            else msg = "Найдено альбомов по поиску: " + data.Count.ToString();


            ContentPanel.Controls.Clear();

            AlbumPreview[] previews = new AlbumPreview[data.Count];
            for (int i = 0; i < previews.Length; i++)
            {

                previews[i] = new AlbumPreview();
                previews[i].SetInitVariables(this, data[i]);
                previews[i].Name = data[i].Name + data[i].Author.Name;
                previews[i].Size = new Size(240, 290);
                previews[i].TabIndex = 1;
                //
                ContentPanel.Controls.Add(previews[i]);

            }
            InfoLabel.Text = msg;
            InitializeAlbumsPreviewLocation();
        }

        public void ShowBigViewAlbum(Album album, bool isSlide = false, List<Album> slideAlbums = null, int slideIndex = -1)
        {

            ContentPanel.Controls.Clear();
            BigAlbumView bigViewAlbum;
            if (isSlide)
            {
                bigViewAlbum = new BigAlbumView(this, album, slideAlbums, slideIndex);

            }
            else
            {
                bigViewAlbum = new BigAlbumView(this, album);
            }
            bigViewAlbum.Size = new Size(ContentPanel.Size.Width, ContentPanel.Size.Height);
            bigViewAlbum.Location = new Point(ContentPanel.Location.X, ContentPanel.Location.Y);
            bigViewAlbum.TabIndex = 1;
            bigViewAlbum.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(bigViewAlbum);
        }

        private List<Album> GetDataByFilter()
        {
            MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();
            string Default = "";

            List<Album> allAlbums = context.Albums.Include(p => p.Author).Include(p => p.Carrier).Include(p => p.Genre).Include(p => p.ReleasingLabel).Include(p => p.Type).ToList();
            if (FilterAndSearchConfig.FilterGenre != Default)
            {
                string[] Genres = FilterAndSearchConfig.FilterGenre.Split(';');
                List<Album> findedAlbums = new List<Album>();
                foreach (string s in Genres)
                {
                    List<Album> finded = allAlbums.Where(p => p.Genre.Name == s).ToList();
                    foreach (Album a in finded) findedAlbums.Add(a);
                    allAlbums = findedAlbums;
                }

            }
            if (FilterAndSearchConfig.FilterAuthor != Default)
            {
                string[] Authors = FilterAndSearchConfig.FilterAuthor.Split(';');
                List<Album> findedAlbums = new List<Album>();
                foreach (string s in Authors)
                {
                    List<Album> finded = allAlbums.Where(p => p.Author.Name == s).ToList();
                    foreach (Album a in finded) findedAlbums.Add(a);
                    allAlbums = findedAlbums;
                }
            }
            if (FilterAndSearchConfig.FilterCarrier != Default)
            {
                string[] Carriers = FilterAndSearchConfig.FilterCarrier.Split(';');
                List<Album> findedAlbums = new List<Album>();
                foreach (string s in Carriers)
                {
                    List<Album> finded = allAlbums.Where(p => p.Carrier.Name == s).ToList();
                    foreach (Album a in finded) findedAlbums.Add(a);
                    allAlbums = findedAlbums;
                }
            }
            if (FilterAndSearchConfig.FilterReleaseYear != Default)
            {
                string[] ReleaseYears = FilterAndSearchConfig.FilterReleaseYear.Split(';');
                List<Album> findedAlbums = new List<Album>();
                foreach (string s in ReleaseYears)
                {
                    List<Album> finded = allAlbums.Where(p => p.ReleaseYear.ToString() == s).ToList();
                    foreach (Album a in finded) findedAlbums.Add(a);
                    allAlbums = findedAlbums;
                }
            }
            if (FilterAndSearchConfig.FilterReleasingLabel != Default)
            {
                string[] ReleasingLabels = FilterAndSearchConfig.FilterReleasingLabel.Split(';');
                List<Album> findedAlbums = new List<Album>();
                foreach (string s in ReleasingLabels)
                {
                    List<Album> finded = allAlbums.Where(p => p.ReleasingLabel.Name == s).ToList();
                    foreach (Album a in finded) findedAlbums.Add(a);
                    allAlbums = findedAlbums;
                }
            }
            if (FilterAndSearchConfig.FilterTrackCount != Default)
            {
                string[] TrackCounts = FilterAndSearchConfig.FilterTrackCount.Split(';');
                List<Album> findedAlbums = new List<Album>();
                foreach (string s in TrackCounts)
                {
                    List<Album> finded = allAlbums.Where(p => p.TrackCount.ToString() == s).ToList();
                    foreach (Album a in finded) findedAlbums.Add(a);
                    allAlbums = findedAlbums;
                }
            }
            if (FilterAndSearchConfig.FilterType != Default)
            {
                string[] Types = FilterAndSearchConfig.FilterType.Split(';');
                List<Album> findedAlbums = new List<Album>();
                foreach (string s in Types)
                {
                    List<Album> finded = allAlbums.Where(p => p.Type.Name == s).ToList();
                    foreach (Album a in finded) findedAlbums.Add(a);
                    allAlbums = findedAlbums;
                }
            }
            allAlbums = SortAlbums(allAlbums);
            return allAlbums;
        }

        public List<Album> SortAlbums(List<Album> allAlbums)
        {
            if (allAlbums.Count != 0)
            {
                string YearSort = "off";
                string TrackSort = "off";
                if (FilterAndSearchConfig.FilterReleaseYearAsc == true) YearSort = "asc";
                else
                if (FilterAndSearchConfig.FilterReleaseYearDesc == true) YearSort = "desc";
                if (FilterAndSearchConfig.FilterTrackCountAsc == true) TrackSort = "asc";
                else
                if (FilterAndSearchConfig.FilterTrackCountDesc == true) TrackSort = "desc";
                if (YearSort == "asc" && TrackSort == "asc") allAlbums = allAlbums.OrderBy(p => p.ReleaseYear).ThenBy(p => p.TrackCount).ToList();
                else if (YearSort == "desc" && TrackSort == "desc") allAlbums = allAlbums.OrderByDescending(p => p.ReleaseYear).ThenByDescending(p => p.TrackCount).ToList();
                else if (YearSort == "asc" && TrackSort == "desc") allAlbums = allAlbums.OrderBy(p => p.ReleaseYear).ThenByDescending(p => p.TrackCount).ToList();
                else if (YearSort == "desc" && TrackSort == "asc") allAlbums = allAlbums.OrderByDescending(p => p.ReleaseYear).ThenBy(p => p.TrackCount).ToList();
                else if (YearSort == "asc" && TrackSort == "asc") allAlbums = allAlbums.OrderBy(p => p.ReleaseYear).ThenBy(p => p.TrackCount).ToList();
                else if (YearSort == "asc" && TrackSort == "off") allAlbums = allAlbums.OrderBy(p => p.ReleaseYear).ToList();
                else if (YearSort == "desc" && TrackSort == "off") allAlbums = allAlbums.OrderByDescending(p => p.ReleaseYear).ToList();
                else if (YearSort == "off" && TrackSort == "asc") allAlbums = allAlbums.OrderBy(p => p.TrackCount).ToList();
                else if (YearSort == "off" && TrackSort == "desc") allAlbums = allAlbums.OrderByDescending(p => p.TrackCount).ToList();

            }
            return allAlbums;

        }
    }
}
