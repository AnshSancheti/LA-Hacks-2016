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
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventName.Location = new System.Drawing.Point(53, 39);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(114, 21);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Event Name";
            this.lblEventName.Click += new System.EventHandler(this.lblEventName_Click);
            // 
            // tbEventName
            // 
            this.tbEventName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbEventName.Location = new System.Drawing.Point(204, 39);
            this.tbEventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(183, 28);
            this.tbEventName.TabIndex = 2;
            this.tbEventName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventLocation.Location = new System.Drawing.Point(53, 89);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(83, 21);
            this.lblEventLocation.TabIndex = 3;
            this.lblEventLocation.Text = "Location";
            this.lblEventLocation.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEventLocation
            // 
            this.tbEventLocation.Location = new System.Drawing.Point(204, 89);
            this.tbEventLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEventLocation.Name = "tbEventLocation";
            this.tbEventLocation.Size = new System.Drawing.Size(183, 22);
            this.tbEventLocation.TabIndex = 4;
            // 
            // lblEventLength
            // 
            this.lblEventLength.AutoSize = true;
            this.lblEventLength.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventLength.Location = new System.Drawing.Point(45, 142);
            this.lblEventLength.Name = "lblEventLength";
            this.lblEventLength.Size = new System.Drawing.Size(119, 21);
            this.lblEventLength.TabIndex = 5;
            this.lblEventLength.Text = "Length (mins)";
            this.lblEventLength.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblEventPriority
            // 
            this.lblEventPriority.AutoSize = true;
            this.lblEventPriority.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventPriority.Location = new System.Drawing.Point(45, 188);
            this.lblEventPriority.Name = "lblEventPriority";
            this.lblEventPriority.Size = new System.Drawing.Size(62, 21);
            this.lblEventPriority.TabIndex = 6;
            this.lblEventPriority.Text = "Priority";
            // 
            // tbEventLength
            // 
            this.tbEventLength.Location = new System.Drawing.Point(204, 140);
            this.tbEventLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEventLength.Name = "tbEventLength";
            this.tbEventLength.Size = new System.Drawing.Size(183, 22);
            this.tbEventLength.TabIndex = 7;
            // 
            // tbPriority
            // 
            this.tbPriority.Location = new System.Drawing.Point(204, 188);
            this.tbPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(183, 22);
            this.tbPriority.TabIndex = 8;
            this.tbPriority.TextChanged += new System.EventHandler(this.tbPriority_TextChanged);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(281, 291);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(204, 108);
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
            this.btnEventAdder.Location = new System.Drawing.Point(16, 289);
            this.btnEventAdder.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEventAdder.Name = "btnEventAdder";
            this.btnEventAdder.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEventAdder.Size = new System.Drawing.Size(237, 108);
            this.btnEventAdder.TabIndex = 0;
            this.btnEventAdder.Text = "Add Event";
            this.btnEventAdder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEventAdder.UseVisualStyleBackColor = false;
            this.btnEventAdder.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(46, 232);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(68, 17);
            this.lblDueDate.TabIndex = 10;
            this.lblDueDate.Text = "Due Date";
            this.lblDueDate.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // dtDueDate
            // 
            this.dtDueDate.Location = new System.Drawing.Point(204, 227);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(245, 22);
            this.dtDueDate.TabIndex = 12;
            this.dtDueDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Schedlr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(498, 412);
            this.Controls.Add(this.dtDueDate);
            this.Controls.Add(this.lblDueDate);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtDueDate;
    }
}

