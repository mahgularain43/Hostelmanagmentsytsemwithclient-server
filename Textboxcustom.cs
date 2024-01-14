using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace hostelproject
{
    [DefaultEvent("_Textchanged")]
    public partial class Textboxcustom : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.Indigo;
        private bool isFocused = false;
        private int borderRadius = 0;

        private Color placeholderColor = Color.White;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;


        public Textboxcustom()
        {
            InitializeComponent();
        }

        //Events 

        public event EventHandler _Textchanged;

        //Propertise  
        [Category("Custom Textbox")]
        public Color BorderColor { get { return borderColor; } set { borderColor = value; this.Invalidate(); } }

        [Category("Custom Textbox")]
        public int BorderSize { get { return borderSize; } set { borderSize = value; this.Invalidate(); } }

        [Category("Custom Textbox")]
        public bool UnderlinedStyle { get { return underlinedStyle; } set { underlinedStyle = value; this.Invalidate(); } }

        [Category("Custom Textbox")]
        public bool PasswordChar
        {
            get
            {
                return isPasswordChar;
            }
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("Custom Textbox")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("Custom Textbox")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; textBox1.BackColor = value; }
        }

        [Category("Custom Textbox")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; textBox1.ForeColor = value; }
        }

        [Category("Custom Textbox")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value; textBox1.Font = value;
                if (this.DesignMode) { UpdateControlHeight(); }
            }
        }

        [Category("Custom Textbox")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) { return ""; }
                else
                { return textBox1.Text; /*SetPlaceholder();*/ }
            }
            set
            { textBox1.Text = value; }
        }


        [Category("Custom Textbox")]
        public Color BorderFocusColor { get { return borderFocusColor; } set { borderFocusColor = value; } }

        [Category("Custom Textbox")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Custom Textbox")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                if (isPasswordChar) { textBox1.ForeColor = value; }
                placeholderColor = value;
            }
        }
        [Category("Custom Textbox")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set { placeholderText = value; textBox1.Text = ""; SetPlaceholder(); }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar) { textBox1.UseSystemPasswordChar = false; }

            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar) { textBox1.UseSystemPasswordChar = true; }

            }
        }

        //Overridden Methods 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            if (borderRadius > 1)//Round textbox 
            {
                //Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    if (!isFocused)
                    {
                        if (underlinedStyle)
                        {
                            //Draw border smoothing 
                            g.DrawPath(penBorderSmooth, pathBorderSmooth);
                            //Draw border
                            g.SmoothingMode = SmoothingMode.None;
                            g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            //g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                            //Draw border smoothing 
                            g.DrawPath(penBorderSmooth, pathBorderSmooth);
                            //Draw border
                            g.DrawPath(penBorder, pathBorder);
                        }

                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underlinedStyle)
                        {
                            g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                }


            }
            else //regular rectangel textbox 
            {
                //Draw borders 
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (!isFocused)
                    {
                        if (underlinedStyle)
                        {
                            g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }

                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underlinedStyle)
                        {
                            g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_Textchanged != null)
            {
                _Textchanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
