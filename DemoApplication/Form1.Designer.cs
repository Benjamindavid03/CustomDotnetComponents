namespace DemoApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.b_TextField2 = new Blaze.Winform.Controls.B_TextField();
            this.imagePicker1 = new Blaze.Winform.Controls.B_ImagePicker();
            this.b_TextBox2 = new Blaze.Winform.Controls.Core.B_TextBox();
            this.b_TextBox1 = new Blaze.Winform.Controls.Core.B_TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_TextField2
            // 
            this.b_TextField2.BackColor = System.Drawing.SystemColors.Control;
            this.b_TextField2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.b_TextField2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_TextField2.BackgroundImage")));
            this.b_TextField2.FieldFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_TextField2.FieldText = "";
            this.b_TextField2.GColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_TextField2.GColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_TextField2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_TextField2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_TextField2.LabelMessage = "Enter your Label for the Field here";
            this.b_TextField2.Location = new System.Drawing.Point(48, 107);
            this.b_TextField2.Name = "b_TextField2";
            this.b_TextField2.Size = new System.Drawing.Size(288, 61);
            this.b_TextField2.TabIndex = 6;
            // 
            // imagePicker1
            // 
            this.imagePicker1.BackColor = System.Drawing.SystemColors.Control;
            this.imagePicker1.ImageView = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePicker1.Location = new System.Drawing.Point(342, 12);
            this.imagePicker1.Name = "imagePicker1";
            this.imagePicker1.SelectedImage = null;
            this.imagePicker1.Size = new System.Drawing.Size(258, 219);
            this.imagePicker1.TabIndex = 3;
            // 
            // b_TextBox2
            // 
            this.b_TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.b_TextBox2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.b_TextBox2.ForeColor = System.Drawing.Color.Gray;
            this.b_TextBox2.Location = new System.Drawing.Point(31, 55);
            this.b_TextBox2.Name = "b_TextBox2";
            this.b_TextBox2.Size = new System.Drawing.Size(214, 20);
            this.b_TextBox2.TabIndex = 1;
            this.b_TextBox2.Text = "Your Text Here";
            this.b_TextBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.b_TextBox2.WaterMarkFont = null;
            this.b_TextBox2.WaterMarkText = "Your Text Here";
            // 
            // b_TextBox1
            // 
            this.b_TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.b_TextBox1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.b_TextBox1.ForeColor = System.Drawing.Color.Gray;
            this.b_TextBox1.Location = new System.Drawing.Point(31, 28);
            this.b_TextBox1.Name = "b_TextBox1";
            this.b_TextBox1.Size = new System.Drawing.Size(214, 20);
            this.b_TextBox1.TabIndex = 0;
            this.b_TextBox1.Text = "Your Text Here";
            this.b_TextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.b_TextBox1.WaterMarkFont = null;
            this.b_TextBox1.WaterMarkText = "Your Text Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 251);
            this.Controls.Add(this.b_TextField2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagePicker1);
            this.Controls.Add(this.b_TextBox2);
            this.Controls.Add(this.b_TextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Blaze.Winform.Controls.Core.B_TextBox b_TextBox1;
        private Blaze.Winform.Controls.Core.B_TextBox b_TextBox2;
        private Blaze.Winform.Controls.B_ImagePicker imagePicker1;
        private Blaze.Winform.Controls.B_TextField b_TextField1;
        private System.Windows.Forms.Button button1;
        private Blaze.Winform.Controls.B_TextField b_TextField2;
    }
}

