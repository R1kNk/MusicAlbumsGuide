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
    public partial class SortForm : Form
    {
        Form1 parentForm;

        public SortForm(Form1 parentForm1)
        {
            Opacity = 0;
            parentForm = parentForm1;
            InitializeComponent();
        }

        public void SortForm_Load(object sender, EventArgs e)
        {
            WindowSizeChanged(sender,e);
            //
            ControlsChangeMethods.RoundBorderForm(this);
            //
            this.Location = new Point( (parentForm.Location.X+parentForm.Size.Width / 2)-this.Size.Width/2, (parentForm.Location.Y +parentForm.Size.Height / 2) - this.Size.Height/2);
            this.Anchor = AnchorStyles.None;
            //
            this.StartPosition = FormStartPosition.CenterParent;
            ReleaseYearSort.Items.Clear();
            TrackCountSort.Items.Clear();

            ReleaseYearSort.Items.Add("Старые->Новые");
            ReleaseYearSort.Items.Add("Новые->Старые");
            ReleaseYearSort.Items.Add("Отключить");
            TrackCountSort.Items.Add("Меньше->Больше");
            TrackCountSort.Items.Add("Больше->Меньше");
            TrackCountSort.Items.Add("Отключить");
            ReleaseYearSort_Leave(sender, e);
            TrackCountSort_Leave(sender, e);
            Show();

        }

        private void WindowSizeChanged(object sender, EventArgs e)
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

        private void SaveAndReloadButton_Click(object sender, EventArgs e)
        {
            CancelButton.PerformClick();
            FilterAndSearchConfig.SaveSort();
            if (parentForm.ContentPanel.Controls.Count == 1)
            {
                if (parentForm.ContentPanel.Controls[0] is BigAlbumView)
                {
                    BigAlbumView buf = (BigAlbumView)parentForm.ContentPanel.Controls[0];
                    Close();
                    if (buf.isSlide()) parentForm.SlideModeButton.PerformClick();
                    return;
                }
            }
            parentForm.HomeButton.PerformClick();
            Close();
            
        }

        private void ResetFilters_Click(object sender, EventArgs e)
        {
            FilterAndSearchConfig.ClearUnsavedAll();
            ReleaseYearSort.Text = "";
            TrackCountSort.Text = "";
            ReleaseYearSort_Leave(sender,e);
            TrackCountSort_Leave(sender,e);
        }
        
        private void ReleaseYearSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeReleaseYearsComboBox();
        }

        private void TrackCountSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTracksCountComboBox();
        }

        private void ReleaseYearSort_Leave(object sender, EventArgs e)
        {
            if(ReleaseYearSort.Text==""||ReleaseYearSort.Text==" ")
            {
                ReleaseYearSort.ForeColor = Color.Gray;
                ReleaseYearSort.Text = "По году выпуска";
            }
        }

        private void ReleaseYearSort_Enter(object sender, EventArgs e)
        {
            if(ReleaseYearSort.Text=="По году выпуска")
            {
                ReleaseYearSort.ForeColor = Color.Black;
                ReleaseYearSort.Text = "";
            }
        }

        private void TrackCountSort_Enter(object sender, EventArgs e)
        {
            if (TrackCountSort.Text == "По кол-ву дорожек")
            {
                TrackCountSort.ForeColor = Color.Black;
                TrackCountSort.Text = "";
            }
        }

        private void TrackCountSort_Leave(object sender, EventArgs e)
        {
            if (TrackCountSort.Text == "" || ReleaseYearSort.Text == " ")
            {
                TrackCountSort.ForeColor = Color.Gray;
                TrackCountSort.Text = "По кол-ву дорожек";
            }
        }

        private void ChangeReleaseYearsComboBox()
        {
            if (ReleaseYearSort.Text != "")
            {
                if (ReleaseYearSort.Text == "Старые->Новые")
                    FilterAndSearchConfig.SetReleasingYearAsc(true);
                else if (ReleaseYearSort.Text == "Новые->Старые")
                    FilterAndSearchConfig.SetReleasingYearDesc(true);
                else if (ReleaseYearSort.Text == "Отключить")
                {
                    FilterAndSearchConfig.SetFilterReleaseYearSortFalse();
                }
            }
            if (ReleaseYearSort.Text == "")
                ReleaseYearSort.Text = "По году выпуска";
        }

        private void ChangeTracksCountComboBox()
        {
            if (TrackCountSort.Text != "")
            {
                if (TrackCountSort.Text == "Меньше->Больше")
                    FilterAndSearchConfig.SetFilterTrackCountAsc(true);
                else if (TrackCountSort.Text == "Больше->Меньше")
                    FilterAndSearchConfig.SetFilterTrackCountDesc(true);
                else if (TrackCountSort.Text == "Отключить")
                {
                    FilterAndSearchConfig.SetFilterTrackCountSortFalse();
                }
            }
            if (TrackCountSort.Text == "")
                TrackCountSort.Text = "По году выпуска";
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

