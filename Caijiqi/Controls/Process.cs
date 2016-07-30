using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Caijiqi.Controls
{
    delegate void ProcessInvoke(int current);

    delegate void RemoveInvoke();

    public class Process
    {
        private Form form;
        private string text=string.Empty;
        private int total = 0;
        public Process(Form _form,int _total,string _text)
        {
            form = _form;
            text = _text;
            total = _total;
            InitializeComponent();
        }

        public void SetProcess(int value)
        {
            SetProcessValue(value);
        }

        public void SetProcessValue(int current)
        {
            if (processBar.InvokeRequired)
            {
                ProcessInvoke invoke = SetProcessValue;
                processBar.Invoke(invoke, new object[] { current } );
            }
            else
            {
                processBar.Maximum = total;
                processBar.Value = (current > total ? total : current);
            }
        }

        public void Remove()
        {
            RemovePanel();
        }


        public void RemovePanel()
        {
            if (panel.InvokeRequired)
            {
                RemoveInvoke invoke = RemovePanel;
                panel.Invoke(invoke);
            }
            else
            {
                form.Controls.Remove(panel);
            }
        }

        public void InitializeComponent()
        {
            panel = new Panel();
            processBar = new ProgressBar();
            label = new Label();


            panel.Dock = DockStyle.Fill;
            panel.Paint += Panel_Paint;
            form.Controls.Add(panel);
            panel.BringToFront();
            

            processBar.Location = new Point(100, form.Height/2 - processBar.Height);
            processBar.Width = form.Width - 200;
            panel.Controls.Add(processBar);

            label.AutoSize = true;
            label.Location = new Point((form.Width - label.Width)/2,
                form.Height/2 + processBar.Height);
            label.Text = text;
            panel.Controls.Add(label);

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            panel.BackgroundImage = global::Caijiqi.Properties.Resources.Transparent;
        }

        private Panel panel;
        private Label label;
        private ProgressBar processBar;
    }
}
