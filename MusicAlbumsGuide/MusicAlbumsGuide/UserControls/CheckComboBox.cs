using MusicAlbumsGuide.Database.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MusicAlbumsGuide.UserControls
{
    

    /// <summary>
    /// Inherits from ComboBox and handles DrawItem and SelectedIndexChanged events to create an
    /// owner drawn combo box drop-down.  The contents of the dropdown are rendered using the
    /// CheckBoxRenderer class.
    /// </summary>
    public  class CheckComboBox : ComboBox
    {
        static DateTime LastChange;
        /// <summary>
        /// C'tor
        /// </summary>
        public CheckComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DrawItem += new DrawItemEventHandler(CheckComboBox_DrawItem);
            this.SelectedIndexChanged += new EventHandler(CheckComboBox_SelectedIndexChanged);
            SelectedText = "Option";
        }

        /// <summary>
        /// Invoked when the selected index is changed on the dropdown.  This sets the check state
        /// of the CheckComboBoxItem and fires the public event CheckStateChanged using the 
        /// CheckComboBoxItem as the event sender.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - LastChange;
            if (span < new TimeSpan(0, 0, 1)) return;
            else
            {
                LastChange = DateTime.Now;
                CheckComboBoxItem item = (CheckComboBoxItem)SelectedItem;
                item.CheckState = !item.CheckState;
                if (CheckStateChanged != null)
                    CheckStateChanged(item, e);
            }
        }

        /// <summary>
        /// Invoked when the ComboBox has to render the drop-down items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // make sure the index is valid (sanity check)
            if (e.Index == -1)
            {
                return;
            }

            // test the item to see if its a CheckComboBoxItem
            if (!(Items[e.Index] is CheckComboBoxItem))
            {
                // it's not, so just render it as a default string
                e.Graphics.DrawString(
                    Items[e.Index].ToString(),
                    this.Font,
                    Brushes.Black,
                    new Point(e.Bounds.X, e.Bounds.Y));
                return;
            }

            // get the CheckComboBoxItem from the collection
            CheckComboBoxItem box = (CheckComboBoxItem)Items[e.Index];

            // render it
            CheckBoxRenderer.RenderMatchingApplicationState = true;
            CheckBoxRenderer.DrawCheckBox(
                e.Graphics,
                new Point(e.Bounds.X, e.Bounds.Y),
                e.Bounds,
                box.Text,
                this.Font,
                (e.State & DrawItemState.Focus) == 0,
                box.CheckState ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal);
        }

        /// <summary>
        /// Fired when the user clicks a check box item in the drop-down list
        /// </summary>
        public event EventHandler CheckStateChanged;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
        public void SetSelectedText(string text)
        {
            SelectedText = text;
        }
        public void InitializeItems(List<object> objects)
        {
            if(objects.Count!=0)
            {
                if(objects[0] is Genre)
                {
                    foreach (var item in objects)
                    {
                        Genre buf = (Genre)item;
                        this.Items.Add(new CheckComboBoxItem(buf.Name, false));
                    }
                    return;
                }
                if (objects[0] is Author)
                {
                    foreach (var item in objects)
                    {
                        Author buf = (Author)item;
                        this.Items.Add(new CheckComboBoxItem(buf.Name, false));
                    }
                    return;
                }
                if (objects[0] is Carrier)
                {
                    foreach (var item in objects)
                    {
                        Carrier buf = (Carrier)item;
                        this.Items.Add(new CheckComboBoxItem(buf.Name, false));
                    }
                    return;
                }
                if (objects[0] is ReleasingLabel)
                {
                    foreach (var item in objects)
                    {
                        ReleasingLabel buf = (ReleasingLabel)item;
                        this.Items.Add(new CheckComboBoxItem(buf.Name, false));
                    }
                    return;
                }
                if (objects[0] is Database.Models.Type)
                {
                    foreach (var item in objects)
                    {
                        Database.Models.Type buf = (Database.Models.Type)item;
                        this.Items.Add(new CheckComboBoxItem(buf.Name, false));
                    }
                    return;
                }
                if (objects[0] is string)
                {
                    foreach (var item in objects)
                    {
                        string buf = (string)item;
                        if(!Items.Contains(new CheckComboBoxItem(buf,false)))
                        this.Items.Add(new CheckComboBoxItem(buf, false));
                    }
                    return;
                }
            }
        }
    }
}
