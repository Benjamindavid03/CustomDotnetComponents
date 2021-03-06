using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing; 

namespace Blaze.Winform.Controls.Core
{
    public class B_TextBox : TextBox
    {
        #region Member Variables
        Color waterMarkColor = Color.Gray;
        Color forecolor;
        Font font;
        Font waterMarkFont;
        string waterMarkText = "Your Text Here";
        #endregion
        #region Constructor
        public B_TextBox()
        {
            base.Text = this.waterMarkText;
            this.forecolor = this.ForeColor;
            this.ForeColor = this.waterMarkColor;
            this.font = this.Font;
            //event handlers
            this.TextChanged += new EventHandler(ExtdTextBox_TextChanged);
            this.KeyPress += new KeyPressEventHandler(ExtdTextBox_KeyPress);
            this.LostFocus += new EventHandler(ExtdTextBox_TextChanged);
        }
        #endregion
        #region Event Handler Methods
        void ExtdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                this.ForeColor = this.forecolor;
                this.Font = this.font;
            }
            else
            {
                this.TextChanged -= new EventHandler(ExtdTextBox_TextChanged);
                base.Text = this.waterMarkText;
                this.TextChanged += new EventHandler(ExtdTextBox_TextChanged);
                this.ForeColor = this.waterMarkColor;
                this.Font = this.waterMarkFont;
            }
        }
       void ExtdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = base.Text.Replace(this.waterMarkText, "");
            this.TextChanged -= new EventHandler(ExtdTextBox_TextChanged);
            this.Text = str;
            this.TextChanged += new EventHandler(ExtdTextBox_TextChanged);
        }
        #endregion
        #region User Defined Properties

       /// <summary>
       /// Property to set/get Background color at design/runtime
       /// </summary>
       [Browsable(true)]
       [Category("Extended Properties")]
       [Description("sets background color")]
       [DisplayName("Background Color")]
       public Color BackgroundColor
       {
           get
           {
               return (this.BackColor);
           }
           set
           {
               this.BackColor = value;
           }
       }
        /// <summary>
        /// Property to set/get Watermark color at design/runtime
        /// </summary>
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets Watermark color")]
        [DisplayName("WaterMark Color")]
        public Color WaterMarkColor
        {
            get
            {
                return this.waterMarkColor;
            }
            set
            {
                this.waterMarkColor = value;
                base.OnTextChanged(new EventArgs());
            }
        }
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets TextBox text")]
        [DisplayName("Text")]
        /// <summary>
        /// Property to get Text at runtime(hides base Text property)
        /// </summary>
        public new string Text
        {
            get
            {
                //required for validation for Text property
                return base.Text.Replace(this.waterMarkText, string.Empty);
            }
            set
            {
                base.Text = value;
            }
        }
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets WaterMark font")]
        [DisplayName("WaterMark Font")]
        /// <summary>
        /// Property to get Text at runtime(hides base Text property) 
      /// </summary>
        public Font WaterMarkFont
        {
            get
            {
                //required for validation for Text property
                return this.waterMarkFont;
            }
            set
            {
                this.waterMarkFont = value;
                this.OnTextChanged(new EventArgs());
            }
        }
        /// <summary>
        ///  Property to set/get Watermark text at design/runtime
        /// </summary>
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets Watermark Text")]
        [DisplayName("WaterMark Text")]
        public string WaterMarkText
        {
            get
            {
                return this.waterMarkText;
            }
            set
            {
                this.waterMarkText = value;
                base.OnTextChanged(new EventArgs());
            }
        }
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
                // Create image.
            Image imageFile = Image.FromFile("./blue_btn.png");
            // Create graphics object for alteration.
            Graphics newGraphics = Graphics.FromImage(imageFile);

            // Alter image.
            newGraphics.FillRectangle(new SolidBrush(Color.Black), 100, 50, 100, 100);

            // Draw image to screen.
            pe.Graphics.DrawImage(imageFile, new PointF(0.0F, 0.0F));


        }

    }
}
