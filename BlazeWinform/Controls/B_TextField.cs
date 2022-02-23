using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blaze.Winform.Controls
{
    public partial class B_TextField : UserControl
    {
        public Color GColor1 { get; set; }
        public Color GColor2 {get;set;}
        public B_TextField()
        {
            InitializeComponent();
        }

        #region ControlProperties
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

        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets Label Field")]
        [DisplayName("Label Message")]
        public String LabelMessage
        {
            get
            {
                return (this.label1.Text );
            }
            set
            {
                this.label1.Text = value;
            }
        }
       
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets Field font")]
        [DisplayName("Field Font")]
        /// <summary>
        /// Property to get Text at runtime(hides base Text property) 
        /// </summary>
        public Font FieldFont
        {
            get
            {
                //required for validation for Text property
                return this.label1.Font;
            }
            set
            {
                this.label1.Font = value;
                this.OnTextChanged(new EventArgs());
            }
        }
        /// <summary>
        ///  Property to set/get Watermark text at design/runtime
        /// </summary>
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets Field Text")]
        [DisplayName("Field Text")]
        public string FieldText
        {
            get
            {
                return this.b_TextBox2.Text;
            }
            set
            {
                this.b_TextBox2.Text = value;
                base.OnTextChanged(new EventArgs());
            }
        }

        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets Color 1 in Gradient")]
        [DisplayName("Gradient Color 1")]
        /// <summary>
        /// Property to set/get Gradient Color 1
        /// </summary>
        public Color GradientColor1
        {
            get
            {
                //required for validation for Text property
                return this.GColor1;
            }
            set
            {
                this.GColor1 = value;
            }
        }

        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets Color 2 in Gradient")]
        [DisplayName("Gradient Color 2")]
        /// <summary>
        /// Property to set/get Gradient Color 2
        /// </summary>
        public Color GradientColor2
        {
            get
            {
                //required for validation for Text property
                return this.GColor2;
            }
            set
            {
                this.GColor2 = value;
            }
        }

        #endregion

        private void B_TextField_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void B_TextField_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Blaze.Winform.Controls.Core.Utils.Gradient(this.ClientRectangle, GColor1, GColor2);
        }
    }
}
