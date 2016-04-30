namespace WindowsFormsApplication1
{
    partial class Schedlr
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
            this.btnEventAdder = new System.Windows.Forms.Button();
            this.lblEventName = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.tbEventLocation = new System.Windows.Forms.TextBox();
            this.lblEventLength = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEventLength = new System.Windows.Forms.TextBox();
            this.tbPriority = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEventAdder
            // 
            this.btnEventAdder.Location = new System.Drawing.Point(195, 218);
            this.btnEventAdder.Name = "btnEventAdder";
            this.btnEventAdder.Size = new System.Drawing.Size(75, 23);
            this.btnEventAdder.TabIndex = 0;
            this.btnEventAdder.Text = "Add Event";
            this.btnEventAdder.UseVisualStyleBackColor = true;
            this.btnEventAdder.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(33, 50);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(85, 17);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Event Name";
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(146, 47);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(100, 22);
            this.tbEventName.TabIndex = 2;
            this.tbEventName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Location = new System.Drawing.Point(33, 89);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(62, 17);
            this.lblEventLocation.TabIndex = 3;
            this.lblEventLocation.Text = "Location";
            this.lblEventLocation.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEventLocation
            // 
            this.tbEventLocation.Location = new System.Drawing.Point(146, 86);
            this.tbEventLocation.Name = "tbEventLocation";
            this.tbEventLocation.Size = new System.Drawing.Size(100, 22);
            this.tbEventLocation.TabIndex = 4;
            // 
            // lblEventLength
            // 
            this.lblEventLength.AutoSize = true;
            this.lblEventLength.Location = new System.Drawing.Point(33, 128);
            this.lblEventLength.Name = "lblEventLength";
            this.lblEventLength.Size = new System.Drawing.Size(95, 17);
            this.lblEventLength.TabIndex = 5;
            this.lblEventLength.Text = "Length (mins)";
            this.lblEventLength.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Priority";
            // 
            // tbEventLength
            // 
            this.tbEventLength.Location = new System.Drawing.Point(146, 125);
            this.tbEventLength.Name = "tbEventLength";
            this.tbEventLength.Size = new System.Drawing.Size(100, 22);
            this.tbEventLength.TabIndex = 7;
            // 
            // tbPriority
            // 
            this.tbPriority.Location = new System.Drawing.Point(146, 160);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(100, 22);
            this.tbPriority.TabIndex = 8;
            // 
            // Schedlr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.tbPriority);
            this.Controls.Add(this.tbEventLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEventLength);
            this.Controls.Add(this.tbEventLocation);
            this.Controls.Add(this.lblEventLocation);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.btnEventAdder);
            this.Name = "Schedlr";
            this.Text = "Schedlr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventAdder;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.TextBox tbEventLocation;
        private System.Windows.Forms.Label lblEventLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEventLength;
        private System.Windows.Forms.TextBox tbPriority;
    }
}

