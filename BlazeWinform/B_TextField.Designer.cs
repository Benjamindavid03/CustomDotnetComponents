namespace Blaze.Winform
{
    partial class B_TextField
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.b_TextBox1 = new Blaze.Winform.B_TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // b_TextBox1
            // 
            this.b_TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.b_TextBox1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.b_TextBox1.ForeColor = System.Drawing.Color.Gray;
            this.b_TextBox1.Location = new System.Drawing.Point(14, 27);
            this.b_TextBox1.Name = "b_TextBox1";
            this.b_TextBox1.Size = new System.Drawing.Size(247, 20);
            this.b_TextBox1.TabIndex = 0;
            this.b_TextBox1.Text = "Your Text Here";
            this.b_TextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.b_TextBox1.WaterMarkFont = null;
            this.b_TextBox1.WaterMarkText = "Your Text Here";
            // 
            // B_TextField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_TextBox1);
            this.Name = "B_TextField";
            this.Size = new System.Drawing.Size(275, 61);
            this.Load += new System.EventHandler(this.B_TextField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B_TextBox b_TextBox1;
        private System.Windows.Forms.Label label1;
    }
}
