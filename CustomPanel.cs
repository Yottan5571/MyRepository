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
    public partial class CustomPanel : Control
    {

        public Button RemoveButton;

        public CustomPanel()
        {
            InitializeComponent();

            RemoveButton = new Button()
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom,
                Location = new Point(this.Width - 50, 0),
                Margin = new Padding(5, 5, 5, 5),
                AllowDrop = true,
                Visible = true,
                BackColor = Color.Red
            };

            this.Controls.Add(RemoveButton);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            //RemoveButton.Visible = true;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            //RemoveButton.Visible = false;
            base.OnMouseLeave(e);
        }
    }
}
