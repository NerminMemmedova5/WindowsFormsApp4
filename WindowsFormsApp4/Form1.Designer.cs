namespace WindowsFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.londonbtn = new System.Windows.Forms.Button();
            this.bakubtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Clocks";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // londonbtn
            // 
            this.londonbtn.BackColor = System.Drawing.Color.Fuchsia;
            this.londonbtn.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonbtn.ForeColor = System.Drawing.Color.Yellow;
            this.londonbtn.Location = new System.Drawing.Point(115, 163);
            this.londonbtn.Name = "londonbtn";
            this.londonbtn.Size = new System.Drawing.Size(201, 93);
            this.londonbtn.TabIndex = 1;
            this.londonbtn.Text = "London";
            this.londonbtn.UseVisualStyleBackColor = false;
            this.londonbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bakubtn
            // 
            this.bakubtn.BackColor = System.Drawing.Color.Fuchsia;
            this.bakubtn.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakubtn.ForeColor = System.Drawing.Color.Yellow;
            this.bakubtn.Location = new System.Drawing.Point(491, 163);
            this.bakubtn.Name = "bakubtn";
            this.bakubtn.Size = new System.Drawing.Size(201, 93);
            this.bakubtn.TabIndex = 2;
            this.bakubtn.Text = "Baku";
            this.bakubtn.UseVisualStyleBackColor = false;
            this.bakubtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bakubtn);
            this.Controls.Add(this.londonbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button londonbtn;
        private System.Windows.Forms.Button bakubtn;
    }
}

