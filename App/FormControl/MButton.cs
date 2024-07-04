using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.FormControl
{
    public partial class MButton : UserControl
    {
        public MButton()
        {
            InitializeComponent();
        }

        Point point1, point2, point3, point4;
        Point[] parr;

        [Description("填充色"),Category("外观")]
        public Color FillColor { get; set; } = Color.Green;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            point1 = new Point(this.Width / 4, this.Height / 5);
            point2 = new Point(this.Width / 4 * 3, this.Height / 5);
            point3 = new Point(this.Width / 4 * 3, this.Height / 5 * 4);
            point4 = new Point(this.Width / 4, this.Height / 5 * 4);
            parr = new Point[] { point1, point2, point3, point4 };
            e.Graphics.DrawPolygon(new Pen(Color.Red), parr);
            e.Graphics.FillPolygon(new SolidBrush(FillColor), parr);
        }
    }
}
