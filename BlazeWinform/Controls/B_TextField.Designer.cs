using Blaze.Winform.Controls.Core;
namespace Blaze.Winform.Controls
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
            this.b_TextBox2 = new Blaze.Winform.Controls.Core.B_TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your Label for the Field here";
            // 
            // b_TextBox2
            // 
            this.b_TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.b_TextBox2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.b_TextBox2.ForeColor = System.Drawing.Color.Gray;
            this.b_TextBox2.Location = new System.Drawing.Point(39, 27);
            this.b_TextBox2.Name = "b_TextBox2";
            this.b_TextBox2.Size = new System.Drawing.Size(232, 20);
            this.b_TextBox2.TabIndex = 2;
            this.b_TextBox2.Text = "Your Text Here";
            this.b_TextBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.b_TextBox2.WaterMarkFont = null;
            this.b_TextBox2.WaterMarkText = "Your Text Here";
            // 
            // B_TextField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.b_TextBox2);
            this.Controls.Add(this.label1);
            this.Name = "B_TextField";
            this.Size = new System.Drawing.Size(288, 61);
            this.Load += new System.EventHandler(this.B_TextField_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.B_TextField_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private B_TextBox b_TextBox2;
    }
}
