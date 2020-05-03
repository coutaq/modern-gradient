using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Coutaq
{
    public partial class ModernGradient: UserControl
    {
        
        private Color gradientBegin = Color.White;
        [
        Category("Appearance"),
        Description("Gradient Beginning Color")
        ]
        public Color GradientBegin
        {
            get { return gradientBegin;}
            set{
                gradientBegin = value;
                Invalidate();
            }
        }
        private Color gradientEnd = Color.Black;
        [
        Category("Appearance"),
        Description("Gradient Ending Color")
        ]
        public Color GradientEnd
        {

            get {return gradientEnd; }
            set{ 
                gradientEnd = value;
                Invalidate();
            }
        }
        public ModernGradient()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void ModernGradient_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            StringFormat style = new StringFormat();
            style.Alignment = StringAlignment.Near;
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, gradientBegin, gradientEnd, 45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void ModernGradient_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        [Browsable(false)]
        public new Color BackColor { get { return Color.White; } }
        [Browsable(false)]
        public new Color ForeColor { get { return Color.White; } }
        [Browsable(false)]
        public new ImageLayout BackgroundImageLayout { get { return ImageLayout.Center; } }
        [Browsable(false)] 
        public new Image BackgroundImage { get { return null; } }
        [Browsable(false)]
        public new System.Windows.Forms.RightToLeft RightToLeft { get { return System.Windows.Forms.RightToLeft.Inherit; } }
        [Browsable(false)]
        public new Font Font { get { return new Font(Font.SystemFontName, 8); } }
        public new System.Windows.Forms.DockStyle Dock { get { return System.Windows.Forms.DockStyle.Fill; } }

    }

}
