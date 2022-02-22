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
        public B_TextField()
        {
            InitializeComponent();
        }

        private void B_TextField_Load(object sender, EventArgs e)
        {

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
                return this.b_TextBox1.Text;
            }
            set
            {
                this.b_TextBox1.Text = value;
                base.OnTextChanged(new EventArgs());
            }
        }
        #endregion
    }
}
