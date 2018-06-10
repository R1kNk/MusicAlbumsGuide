using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.UserControls
{
    /// <summary>
    /// This class wraps the list items in the combo box
    /// </summary>
    public class CheckComboBoxItem
    {
        /// <summary>
        /// C'tor - creates a CheckComboBoxItem
        /// </summary>
        /// <param name="text">Label of the check box in the drop down list</param>
        /// <param name="initialCheckState">Initial value for the check box (true=checked)</param>
        public CheckComboBoxItem(string text, bool initialCheckState)
        {
            _checkState = initialCheckState;
            _text = text;
        }

        private bool _checkState = false;
        /// <summary>
        /// Gets the check value (true=checked)
        /// </summary>
        public bool CheckState
        {
            get { return _checkState; }
            set { _checkState = value; }
        }

        private string _text = "";
        /// <summary>
        /// Gets the label of the check box
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private object _tag = null;
        /// <summary>
        /// User defined data
        /// </summary>
        public object Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        /// <summary>
        /// This is used to keep the edit control portion of the combo box consistent
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Text + ";";
        }

    }
}
