using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvents
{
    public partial class CustomLabel : Label
    {
        public CustomLabel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            CustomPanel parent = this.Parent as CustomPanel;
            parent.RemoveButton.BringToFront();
            parent.RemoveButton.Update();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            CustomPanel parent = this.Parent as CustomPanel;
            parent.RemoveButton.SendToBack();
            base.OnMouseLeave(e);
        }
    }
}
