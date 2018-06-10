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
    public partial class ImageForm : Form
    {
        Form parent;
        public ImageForm(Form parentForm, Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            parent = parentForm;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Del();
           // parent.Activate();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            this.Anchor = AnchorStyles.None;

            this.Location = new Point((parent.Location.X + parent.Size.Width / 2) - this.Size.Width / 2, (parent.Location.Y + parent.Size.Height / 2) - this.Size.Height / 2);
            Show();
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

        public void Del()
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
