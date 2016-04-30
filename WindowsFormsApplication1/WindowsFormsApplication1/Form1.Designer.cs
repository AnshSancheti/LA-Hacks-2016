using System.Drawing;

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
            this.lblEventName = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.tbEventLocation = new System.Windows.Forms.TextBox();
            this.lblEventLength = new System.Windows.Forms.Label();
            this.lblEventPriority = new System.Windows.Forms.Label();
            this.tbEventLength = new System.Windows.Forms.TextBox();
            this.tbPriority = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnEventAdder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventName.Location = new System.Drawing.Point(40, 32);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(94, 19);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Event Name";
            this.lblEventName.Click += new System.EventHandler(this.lblEventName_Click);
            // 
            // tbEventName
            // 
            this.tbEventName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbEventName.Location = new System.Drawing.Point(153, 32);
            this.tbEventName.Margin = new System.Windows.Forms.Padding(2);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(138, 24);
            this.tbEventName.TabIndex = 2;
            this.tbEventName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventLocation.Location = new System.Drawing.Point(40, 72);
            this.lblEventLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(69, 19);
            this.lblEventLocation.TabIndex = 3;
            this.lblEventLocation.Text = "Location";
            this.lblEventLocation.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEventLocation
            // 
            this.tbEventLocation.Location = new System.Drawing.Point(153, 72);
            this.tbEventLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbEventLocation.Name = "tbEventLocation";
            this.tbEventLocation.Size = new System.Drawing.Size(138, 20);
            this.tbEventLocation.TabIndex = 4;
            // 
            // lblEventLength
            // 
            this.lblEventLength.AutoSize = true;
            this.lblEventLength.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventLength.Location = new System.Drawing.Point(34, 115);
            this.lblEventLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventLength.Name = "lblEventLength";
            this.lblEventLength.Size = new System.Drawing.Size(100, 19);
            this.lblEventLength.TabIndex = 5;
            this.lblEventLength.Text = "Length (mins)";
            this.lblEventLength.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblEventPriority
            // 
            this.lblEventPriority.AutoSize = true;
            this.lblEventPriority.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventPriority.Location = new System.Drawing.Point(34, 153);
            this.lblEventPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventPriority.Name = "lblEventPriority";
            this.lblEventPriority.Size = new System.Drawing.Size(53, 19);
            this.lblEventPriority.TabIndex = 6;
            this.lblEventPriority.Text = "Priority";
            // 
            // tbEventLength
            // 
            this.tbEventLength.Location = new System.Drawing.Point(153, 114);
            this.tbEventLength.Margin = new System.Windows.Forms.Padding(2);
            this.tbEventLength.Name = "tbEventLength";
            this.tbEventLength.Size = new System.Drawing.Size(138, 20);
            this.tbEventLength.TabIndex = 7;
            // 
            // tbPriority
            // 
            this.tbPriority.Location = new System.Drawing.Point(153, 153);
            this.tbPriority.Margin = new System.Windows.Forms.Padding(2);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(138, 20);
            this.tbPriority.TabIndex = 8;
            this.tbPriority.TextChanged += new System.EventHandler(this.tbPriority_TextChanged);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(229, 224);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(153, 88);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnEventAdder
            // 
            this.btnEventAdder.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEventAdder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEventAdder.FlatAppearance.BorderSize = 5;
            this.btnEventAdder.Font = new System.Drawing.Font("Consolas", 20F);
            this.btnEventAdder.ForeColor = System.Drawing.Color.White;
            this.btnEventAdder.Image = global::WindowsFormsApplication1.Properties.Resources.AddEventDesign;
            this.btnEventAdder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventAdder.Location = new System.Drawing.Point(14, 224);
            this.btnEventAdder.Margin = new System.Windows.Forms.Padding(5);
            this.btnEventAdder.Name = "btnEventAdder";
            this.btnEventAdder.Padding = new System.Windows.Forms.Padding(5);
            this.btnEventAdder.Size = new System.Drawing.Size(178, 88);
            this.btnEventAdder.TabIndex = 0;
            this.btnEventAdder.Text = "Add Event";
            this.btnEventAdder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEventAdder.UseVisualStyleBackColor = false;
            this.btnEventAdder.Click += new System.EventHandler(this.button1_Click);
            // 
            // Schedlr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(404, 326);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.tbPriority);
            this.Controls.Add(this.tbEventLength);
            this.Controls.Add(this.lblEventPriority);
            this.Controls.Add(this.lblEventLength);
            this.Controls.Add(this.tbEventLocation);
            this.Controls.Add(this.lblEventLocation);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.btnEventAdder);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lblEventPriority;
        private System.Windows.Forms.TextBox tbEventLength;
        private System.Windows.Forms.TextBox tbPriority;
        private System.Windows.Forms.Button btnDone;
    }
}

