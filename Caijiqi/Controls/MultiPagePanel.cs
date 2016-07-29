using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Caijiqi.Controls
{
    public class MultiPagePanel : System.Windows.Forms.Panel
    {
        private int _currentPageIndex;

        public int CurrentPageIndex
        {
            get { return _currentPageIndex; }
            set
            {
                if (value >= 0 && value < base.Controls.Count)
                {
                    foreach (Control page in Controls)
                    {

                        page.Hide();
                    }
                    Controls[value].Show();
                    _currentPageIndex = value;
                }
            }
        }

        public void AddPage(Control page)
        {
            base.Controls.Add(page);
            page.Dock = DockStyle.Fill;
        }
    }
}
