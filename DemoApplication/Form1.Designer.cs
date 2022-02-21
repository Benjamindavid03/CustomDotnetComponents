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
            this.b_TextField1 = new Blaze.Winform.B_TextField();
            this.b_TextBox2 = new Blaze.Winform.B_TextBox();
            this.b_TextBox1 = new Blaze.Winform.B_TextBox();
            this.SuspendLayout();
            // 
            // b_TextField1
            // 
            this.b_TextField1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_TextField1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_TextField1.FieldFont = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_TextField1.FieldText = "Hi. Hello";
            this.b_TextField1.LabelMessage = "Enter your message";
            this.b_TextField1.Location = new System.Drawing.Point(31, 81);
            this.b_TextField1.Name = "b_TextField1";
            this.b_TextField1.Size = new System.Drawing.Size(274, 59);
            this.b_TextField1.TabIndex = 2;
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
            this.ClientSize = new System.Drawing.Size(774, 253);
            this.Controls.Add(this.b_TextField1);
            this.Controls.Add(this.b_TextBox2);
            this.Controls.Add(this.b_TextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Blaze.Winform.B_TextBox b_TextBox1;
        private Blaze.Winform.B_TextBox b_TextBox2;
        private Blaze.Winform.B_TextField b_TextField1;



    }
}

