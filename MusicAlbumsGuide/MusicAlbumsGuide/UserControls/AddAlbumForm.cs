using MusicAlbumsGuide.Database;
using MusicAlbumsGuide.Database.Models;
using MusicAlbumsGuide.SharedFormsMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAlbumsGuide.UserControls
{
    public partial class AddAlbumForm : Form
    {
        Form1 parentForm;
        ImageForm image;
        static List<Album> albums;
        static List<Genre> genres;
        static List<Carrier> carriers;
        static List<Database.Models.Type> types;
        static List<Author> authors;
        static List<ReleasingLabel> releasingLabels;
        static MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();

        public AddAlbumForm(Form1 parentForm1)
        {
            Opacity = 0;
            parentForm = parentForm1;
            InitializeComponent();
        }

        private void AddAlbumForm_Load(object sender, EventArgs e)
        {
            WindowSizeChanged(sender, e);
            CoverAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Location = new Point((parentForm.Location.X + parentForm.Size.Width / 2) - this.Size.Width / 2, (parentForm.Location.Y + parentForm.Size.Height / 2) - this.Size.Height / 2);
            this.Anchor = AnchorStyles.None;
            //
            //this.StartPosition = FormStartPosition.CenterParent;
            ControlsChangeMethods.RoundBorderForm(this);
            InitializeData(sender, e);
            Show();


        }

        private void DrawLine(Label label)
        {
            label.AutoSize = false;
            label.Height = 2;
            label.BorderStyle = BorderStyle.Fixed3D;
        }

        private void WindowSizeChanged(object sender, EventArgs e)
        {

            // this.Size = new Size(Convert.ToInt32(parentForm.Size.Width / 2), Convert.ToInt32(parentForm.Size.Height / 2));
            if (this.Size.Width > 750)
            {
                int forEachLabel = Convert.ToInt32((this.Height * 0.8) / 7);
                int forEachComboBox = Convert.ToInt32((this.Height * 0.8) / 7);
                //
                int currentHeightComboBox = Convert.ToInt32((this.Height * 0.1) + 14 - forEachLabel);
                int currentHeightLabel = Convert.ToInt32((this.Height * 0.1) + 14 - forEachComboBox);


                //Controls.Find("")
                foreach (var control in Controls)
                {
                    if (control is Label)
                    {
                        Label label = (Label)control;
                        if (label.Name != "Title")
                        {
                            label.Font = new Font(Title.Font.Name, Convert.ToInt32(label.Font.Size * 1.1));
                            label.Location = new Point(label.Location.X, currentHeightLabel += forEachLabel);
                        }
                    }
                    else if (control is CheckComboBox)
                    {
                        CheckComboBox checkComboBox = (CheckComboBox)control;
                        checkComboBox.Font = new Font(Title.Font.Name, Convert.ToInt32(checkComboBox.Font.Size * 1.1));
                        checkComboBox.Size = new Size(Convert.ToInt32(checkComboBox.Size.Width * 1.1), Convert.ToInt32(checkComboBox.Size.Height * 1.1));
                        checkComboBox.Location = new Point(checkComboBox.Location.X - 20, currentHeightComboBox += forEachComboBox);
                    }
                    else if (control is Button)
                    {
                        Button button = (Button)control;
                        if (button.Name != "CloseButton")
                            button.Location = new Point(button.Location.X, Convert.ToInt32(((this.Size.Height * 0.9) + ((this.Size.Height * 0.1) / 4))));
                    }
                }
                Title.Font = new Font(Title.Font.Name, Convert.ToInt32(Title.Font.Size * (1.1)));

            }
            else Title.Font = new Font(Title.Font.Name, Convert.ToInt32(18));
            DrawLine(Divider);
            DrawLine(Divider2);

            Divider.Location = new Point(0, Convert.ToInt32(this.Size.Height * 0.06));
            Divider2.Location = new Point(0, this.Size.Height - Convert.ToInt32(this.Size.Height * 0.06));


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


        private void InitializeTextBox(TextBox box, List<object> objects)
        {
            if (objects.Count == 0) return;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            if (objects[0] is Album)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Album buf = (Album)objects[i];

                    source.Add(buf.Name);
                }
                box.AutoCompleteCustomSource = source;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                box.AutoCompleteSource = AutoCompleteSource.CustomSource;
                return;
            }
            if (objects[0] is Author)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Author buf = (Author)objects[i];
                    source.Add(buf.Name);
                }
                box.AutoCompleteCustomSource = source;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                box.AutoCompleteSource = AutoCompleteSource.CustomSource;
                return;
            }
            if (objects[0] is Carrier)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Carrier buf = (Carrier)objects[i];
                    source.Add(buf.Name);
                }
                box.AutoCompleteCustomSource = source;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                box.AutoCompleteSource = AutoCompleteSource.CustomSource;
                return;
            }
            if (objects[0] is Genre)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Genre buf = (Genre)objects[i];
                    source.Add(buf.Name);
                }
                box.AutoCompleteCustomSource = source;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                box.AutoCompleteSource = AutoCompleteSource.CustomSource;
                return;
            }
            if (objects[0] is Database.Models.Type)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Database.Models.Type buf = (Database.Models.Type)objects[i];
                    source.Add(buf.Name);
                }
                box.AutoCompleteCustomSource = source;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                box.AutoCompleteSource = AutoCompleteSource.CustomSource;
                return;
            }
            if (objects[0] is ReleasingLabel)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    ReleasingLabel buf = (ReleasingLabel)objects[i];
                    source.Add(buf.Name);
                }
                box.AutoCompleteCustomSource = source;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                box.AutoCompleteSource = AutoCompleteSource.CustomSource;
                return;
            }
            if (objects[0] is string)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    string buf = (string)objects[i];
                    if (!source.Contains(buf))
                        source.Add(buf);
                }
                box.AutoCompleteCustomSource = source;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                box.AutoCompleteSource = AutoCompleteSource.CustomSource;
                return;
            }

        }
        private void InitializeComboBox(ComboBox box, List<object> objects)
        {
            if (objects.Count == 0) return;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            if (objects[0] is Album)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Album buf = (Album)objects[i];

                    box.Items.Add(buf.Name);
                }

                return;
            }
            if (objects[0] is Author)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Author buf = (Author)objects[i];
                    box.Items.Add(buf.Name);
                }

                return;
            }
            if (objects[0] is Carrier)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Carrier buf = (Carrier)objects[i];
                    box.Items.Add(buf.Name);
                }

                return;
            }
            if (objects[0] is Genre)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Genre buf = (Genre)objects[i];
                    box.Items.Add(buf.Name);
                }

                return;
            }
            if (objects[0] is Database.Models.Type)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    Database.Models.Type buf = (Database.Models.Type)objects[i];
                    box.Items.Add(buf.Name);
                }

                return;
            }
            if (objects[0] is ReleasingLabel)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    ReleasingLabel buf = (ReleasingLabel)objects[i];
                    box.Items.Add(buf.Name);
                }

                return;
            }
            if (objects[0] is string)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    string buf = (string)objects[i];
                    if (!box.Items.Contains(buf))
                        box.Items.Add(buf);
                }

                return;
            }

        }

        private void SaveAndReloadButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == false) return;
            SaveToDatabase();
            CancelButton.PerformClick();
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

        }
        private bool ValidateForm()
        {
            bool result = true;
            MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();
            if (string.IsNullOrEmpty(NameTextBox.Text) || NameTextBox.Text == "Введите имя альбома" || NameTextBox.Text == " ")
            {
                NameErrorProvider.SetError(NameTextBox, "Поле имени должно быть заполнено");
                if (result == true) result = false;
            }
            else
            {
                if(NameTextBox.Text.Length>40)
                {
                    NameErrorProvider.SetError(NameTextBox, "Слишком длинное имя альбома");
                    if (result == true) result = false;
                }
                else NameErrorProvider.Clear();
            }
            List<Album> albums = context.Albums.Include(p => p.Author).ToList();
            List<string> names = new List<string>();
            foreach (var album in albums)
            {
                names.Add(album.Name);
            }

            if (string.IsNullOrEmpty(GenreComboBox.Text) || GenreComboBox.Text == "Выберите жанр альбома" || GenreComboBox.Text == " ")
            {
                GenreErrorProvider.SetError(GenreComboBox, "Поле жанра должно быть заполнено");
                if (result == true) result = false;
            }
            else GenreErrorProvider.Clear();

            if (string.IsNullOrEmpty(AuthorTextBox.Text) || AuthorTextBox.Text == "Введите автора альбома" || AuthorTextBox.Text == " ")
            {
                AuthorErrorProvider.SetError(AuthorTextBox, "Поле автора должно быть заполнено");
                if (result == true) result = false;
            }

            if (names.Contains(NameTextBox.Text))
            {
                List<Album> find = albums.Where(p => p.Name == NameTextBox.Text && p.Author.Name == AuthorTextBox.Name).ToList();
                if (find.Count != 0) AuthorErrorProvider.SetError(NameTextBox, "Альбом с таким именем у данного автора уже существует");
                if (result == true) result = false;

            }
            else AuthorErrorProvider.Clear();

            if (string.IsNullOrEmpty(ReleaseYearTextBox.Text) || ReleaseYearTextBox.Text == "Введите год выпуска альбома" || ReleaseYearTextBox.Text == " ")
            {
                ReleaseYearErrorProvider.SetError(ReleaseYearTextBox, "Поле года релиза должно быть заполнено");
                if (result == true) result = false;
            }
            else
            {
                int res;
                bool isInt = Int32.TryParse(ReleaseYearTextBox.Text, out res);
                if (!isInt)
                {
                    ReleaseYearErrorProvider.SetError(ReleaseYearTextBox, "Поле года должно быть целым числом");
                    if (result == true) result = false;
                }
                else if (res > DateTime.Now.Year)
                {
                    ReleaseYearErrorProvider.SetError(ReleaseYearTextBox, "Год не должен быть больше текущего");
                    if (result == true) result = false;
                }
                else if (res < 1000)
                {
                    ReleaseYearErrorProvider.SetError(ReleaseYearTextBox, "Введите корректный год");
                    if (result == true) result = false;
                }
                else ReleaseYearErrorProvider.Clear();
            }
            if (string.IsNullOrEmpty(TypeComboBox.Text) || TypeComboBox.Text == "Выберите тип альбома" || TypeComboBox.Text == " ")
            {
                TypeErrorProvider.SetError(TypeComboBox, "Поле типа альбома должно быть заполнено");
                if (result == true) result = false;
            }
            else TypeErrorProvider.Clear();

            if (string.IsNullOrEmpty(CarrierComboBox.Text) || CarrierComboBox.Text == "Выберите тип носителя альбома" || CarrierComboBox.Text == " ")
            {
                CarrierTypeErrorProvider.SetError(CarrierComboBox, "Поле типа носителя альбома должно быть заполнено");
                if (result == true) result = false;
            }
            else CarrierTypeErrorProvider.Clear();

            if (string.IsNullOrEmpty(TrackCountTextBox.Text) || TrackCountTextBox.Text == "Введите количество дорожек в альбоме" || TrackCountTextBox.Text == " ")
            {
                TrackCountErrorProvider.SetError(TrackCountTextBox, "Поле количнства дорожек должно быть заполнено");
                if (result == true) result = false;
            }
            else
            {
                int res;
                bool isInt = Int32.TryParse(TrackCountTextBox.Text, out res);
                if (!isInt)
                {
                    TrackCountErrorProvider.SetError(TrackCountTextBox, "Количество дорожек должно быть целым числом");
                    if (result == true) result = false;
                }
                else if (res <= 0)
                {
                    TrackCountErrorProvider.SetError(TrackCountTextBox, "Количетсов дорожек не может быть равно или меньше нуля");
                    if (result == true) result = false;
                }
                else TrackCountErrorProvider.Clear();

            }
            if (string.IsNullOrEmpty(ReleaseLabelTextBox.Text) || ReleaseLabelTextBox.Text == "Введите название выпускающего лэйбла" || ReleaseLabelTextBox.Text == " ")
            {
                ReleaseLabelErrorProvider.SetError(ReleaseLabelTextBox, "Поле выпускающего лэйбла должно быть заполнено");
                if (result == true) result = false;
            }
            else ReleaseLabelErrorProvider.Clear();

            return result;

        }
        private void InitializeData(object sender, EventArgs e)
        {
            GenreComboBox_Leave(sender, e);
            NameTextBox_Leave(sender, e);
            CarrierComboBox_Leave(sender, e);
            TypeComboBox_Leave(sender, e);
            ReleaseYearTextBox_Leave(sender, e);
            ReleaseLabelTextBox_Leave(sender, e);
            AuthorTextBox_Leave(sender, e);
            TrackCountTextBox_Leave(sender, e);
            ReleaseLabelTextBox_Leave(sender, e);
            MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();
            genres = context.Genres.ToList();
            InitializeComboBox(GenreComboBox, new List<object>(genres));
            albums = context.Albums.ToList();
            List<string> years = new List<string>();
            foreach (var album in albums)
            {
                years.Add(album.ReleaseYear.ToString());
            }
            InitializeTextBox(ReleaseYearTextBox, new List<object>(years));
             carriers = context.Carriers.ToList();
            InitializeComboBox(CarrierComboBox, new List<object>(carriers));
            types = context.Types.ToList();
            InitializeComboBox(TypeComboBox, new List<object>(types));
            authors = context.Authors.ToList();
            InitializeTextBox(AuthorTextBox, new List<object>(authors));
            List<string> trackCounts = new List<string>();
            foreach (var album in albums)
            {
                trackCounts.Add(album.TrackCount.ToString());
            }
            InitializeTextBox(TrackCountTextBox, new List<object>(trackCounts));
            releasingLabels = context.ReleasingLabels.ToList();
            InitializeTextBox(ReleaseLabelTextBox, new List<object>(releasingLabels));
        }
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                NameTextBox.Text = "Введите имя альбома";
                NameTextBox.ForeColor = Color.Gray;
            }
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "Введите имя альбома")
            {
                NameTextBox.Text = "";
                NameTextBox.ForeColor = Color.Black;
            }
        }

        private void GenreComboBox_Enter(object sender, EventArgs e)
        {
            if (GenreComboBox.Text == "Выберите жанр альбома")
            {
                GenreComboBox.Text = "";
                GenreComboBox.ForeColor = Color.Black;
            }
            
        }

        private void GenreComboBox_Leave(object sender, EventArgs e)
        {
            if (GenreComboBox.Text == "")
            {
                GenreComboBox.Text = "Выберите жанр альбома";
                GenreComboBox.ForeColor = Color.Gray;
            }
            else
            {
                List<Genre> findedGenres = context.Genres.Where(p => p.Name == GenreComboBox.Text).ToList();
                if(findedGenres.Count==0)
                    GenreComboBox.Text= "Выберите жанр альбома";
            }
        }

        private void ReleaseYearTextBox_Enter(object sender, EventArgs e)
        {
            if (ReleaseYearTextBox.Text == "Введите год выпуска альбома")
            {
                ReleaseYearTextBox.Text = "";
                ReleaseYearTextBox.ForeColor = Color.Black;
            }
        }

        private void ReleaseYearTextBox_Leave(object sender, EventArgs e)
        {
            if (ReleaseYearTextBox.Text == "")
            {
                ReleaseYearTextBox.Text = "Введите год выпуска альбома";
                ReleaseYearTextBox.ForeColor = Color.Gray;
            }
        }

        private void CarrierComboBox_Enter(object sender, EventArgs e)
        {
            if (CarrierComboBox.Text == "Выберите тип носителя альбома")
            {
                CarrierComboBox.Text = "";
                CarrierComboBox.ForeColor = Color.Black;
            }
            
        }

        private void CarrierComboBox_Leave(object sender, EventArgs e)
        {
            if (CarrierComboBox.Text == "")
            {
                CarrierComboBox.Text = "Выберите тип носителя альбома";
                CarrierComboBox.ForeColor = Color.Gray;
            }
            else
            {
                List<Carrier> findedCarriers = context.Carriers.Where(p => p.Name == CarrierComboBox.Text).ToList();
                if (findedCarriers.Count == 0)
                    CarrierComboBox.Text = "Выберите тип носителя альбома";
            }
        }

        private void TypeComboBox_Enter(object sender, EventArgs e)
        {
            if (TypeComboBox.Text == "Выберите тип альбома")
            {
                TypeComboBox.Text = "";
                TypeComboBox.ForeColor = Color.Black;
            }
        }

        private void TypeComboBox_Leave(object sender, EventArgs e)
        {
            if (TypeComboBox.Text == "")
            {
                TypeComboBox.Text = "Выберите тип альбома";
                TypeComboBox.ForeColor = Color.Gray;
            }
            else
            {
                List<Database.Models.Type> findedCarriers = context.Types.Where(p => p.Name == TypeComboBox.Text).ToList();
                if (findedCarriers.Count == 0)
                    TypeComboBox.Text = "Выберите тип альбома";
            }
        }

        private void ReleaseLabelTextBox_Enter(object sender, EventArgs e)
        {
            if (ReleaseLabelTextBox.Text == "Введите название выпускающего лэйбла")
            {
                ReleaseLabelTextBox.Text = "";
                ReleaseLabelTextBox.ForeColor = Color.Black;
            }
        }

        private void ReleaseLabelTextBox_Leave(object sender, EventArgs e)
        {
            if (ReleaseLabelTextBox.Text == "")
            {
                ReleaseLabelTextBox.Text = "Введите название выпускающего лэйбла";
                ReleaseLabelTextBox.ForeColor = Color.Gray;
            }
        }

        private void TrackCountTextBox_Enter(object sender, EventArgs e)
        {
            if (TrackCountTextBox.Text == "Введите количество дорожек в альбоме")
            {
                TrackCountTextBox.Text = "";
                TrackCountTextBox.ForeColor = Color.Black;
            }
        }

        private void TrackCountTextBox_Leave(object sender, EventArgs e)
        {
            if (TrackCountTextBox.Text == "")
            {
                TrackCountTextBox.Text = "Введите количество дорожек в альбоме";
                TrackCountTextBox.ForeColor = Color.Gray;
            }
        }

        private void AuthorTextBox_Enter(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "Введите автора альбома")
            {
                AuthorTextBox.Text = "";
                AuthorTextBox.ForeColor = Color.Black;
            }
        }

        private void AuthorTextBox_Leave(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "")
            {
                AuthorTextBox.Text = "Введите автора альбома";
                AuthorTextBox.ForeColor = Color.Gray;
            }
        }

        private void UploadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog.FileName != null))
                    {
                        CoverAlbum.Image = ImageMethods.ConvertFileToImage(openFileDialog.FileName);
                        CoverAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void SaveToDatabase()
        {
            MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();
            Album newAlbum = new Album();
            newAlbum.Name = NameTextBox.Text;
            Genre currentGenre = context.Genres.Where(p => p.Name == GenreComboBox.Text).Single();
            newAlbum.GenreId = currentGenre.GenreId;
            newAlbum.ReleaseYear = Convert.ToInt32(ReleaseYearTextBox.Text);
            Carrier currentCarrier = context.Carriers.Where(p => p.Name == CarrierComboBox.Text).Single();
            newAlbum.CarrierId = currentCarrier.CarrierId;
            //
            Database.Models.Type currentType = context.Types.Where(p => p.Name == TypeComboBox.Text).Single();
            newAlbum.TypeId = currentType.TypeId;
            Author author;
            try
            {
                author = context.Authors.Where(p => p.Name == AuthorTextBox.Text).Single();
            }
            catch (Exception)
            {
                context.Authors.Add(new Author() { Name = AuthorTextBox.Text });
                context.SaveChanges();
                author = context.Authors.Where(p => p.Name == AuthorTextBox.Text).Single();
            }
            newAlbum.AuthorId = author.AuthorId;
            newAlbum.TrackCount = Convert.ToInt32(TrackCountTextBox.Text);
            //
            ReleasingLabel releasingLabel;
            try
            {
                releasingLabel = context.ReleasingLabels.Where(p => p.Name == ReleaseLabelTextBox.Text).Single();
            }
            catch (Exception)
            {
                context.ReleasingLabels.Add(new ReleasingLabel() { Name = ReleaseLabelTextBox.Text });
                context.SaveChanges();
                releasingLabel = context.ReleasingLabels.Where(p => p.Name == ReleaseLabelTextBox.Text).Single();
            }
            newAlbum.ReleasingLabelId = releasingLabel.ReleasingLabelId;
            newAlbum.CoverPhoto = ImageMethods.ConvertImageToByteArray(CoverAlbum.Image);
            context.Albums.Add(newAlbum);
            context.SaveChanges();
        }

        private void AddAlbumForm_Shown(object sender, EventArgs e)
        {
        }

        private void SaveAndCreateNew_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == false) return;
            SaveToDatabase();
            parentForm.Enabled = true;
            this.Dispose();
            parentForm.AddAlbumButton.PerformClick();
        }

        private void ResetData_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if(control is TextBox)
                {
                    TextBox buf = (TextBox)control;
                    buf.Text = "";
                }
                if (control is ComboBox)
                {
                    ComboBox buf = (ComboBox)control;
                    buf.Text = "";
                }
            }
            GenreComboBox_Leave(sender, e);
            NameTextBox_Leave(sender, e);
            CarrierComboBox_Leave(sender, e);
            TypeComboBox_Leave(sender, e);
            ReleaseYearTextBox_Leave(sender, e);
            ReleaseLabelTextBox_Leave(sender, e);
            AuthorTextBox_Leave(sender, e);
            TrackCountTextBox_Leave(sender, e);
            ReleaseLabelTextBox_Leave(sender, e);
        }

        private void CoverAlbum_Click(object sender, EventArgs e)
        {
            image = new ImageForm(parentForm, CoverAlbum.Image);
            image.Show();
        }

        private void AddAlbumForm_Activated(object sender, EventArgs e)
        {
            if (image != null)
            {
                if (!image.IsDisposed)
                {
                    image.Activate();
                    image.Del();
                }
            }
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
                    this.Dispose();
                }
            });
            timer2.Interval = 1;
            timer2.Start();

        }
    }
}

