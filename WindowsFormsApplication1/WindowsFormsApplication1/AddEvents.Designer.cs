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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedlr));
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.BackColor = System.Drawing.Color.White;
            this.lblEventName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEventName.Location = new System.Drawing.Point(50, 144);
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
            this.tbEventName.Location = new System.Drawing.Point(154, 144);
            this.tbEventName.Margin = new System.Windows.Forms.Padding(2);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(243, 24);
            this.tbEventName.TabIndex = 2;
            this.tbEventName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.BackColor = System.Drawing.Color.White;
            this.lblEventLocation.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventLocation.Location = new System.Drawing.Point(50, 172);
            this.lblEventLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(69, 19);
            this.lblEventLocation.TabIndex = 3;
            this.lblEventLocation.Text = "Location";
            this.lblEventLocation.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEventLocation
            // 
            this.tbEventLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventLocation.Location = new System.Drawing.Point(154, 172);
            this.tbEventLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbEventLocation.Name = "tbEventLocation";
            this.tbEventLocation.Size = new System.Drawing.Size(243, 23);
            this.tbEventLocation.TabIndex = 4;
            // 
            // lblEventLength
            // 
            this.lblEventLength.AutoSize = true;
            this.lblEventLength.BackColor = System.Drawing.Color.White;
            this.lblEventLength.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventLength.Location = new System.Drawing.Point(50, 199);
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
            this.lblEventPriority.BackColor = System.Drawing.Color.White;
            this.lblEventPriority.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEventPriority.Location = new System.Drawing.Point(50, 226);
            this.lblEventPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventPriority.Name = "lblEventPriority";
            this.lblEventPriority.Size = new System.Drawing.Size(53, 19);
            this.lblEventPriority.TabIndex = 6;
            this.lblEventPriority.Text = "Priority";
            this.lblEventPriority.Click += new System.EventHandler(this.lblEventPriority_Click);
            // 
            // tbEventLength
            // 
            this.tbEventLength.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventLength.Location = new System.Drawing.Point(154, 199);
            this.tbEventLength.Margin = new System.Windows.Forms.Padding(2);
            this.tbEventLength.Name = "tbEventLength";
            this.tbEventLength.Size = new System.Drawing.Size(243, 23);
            this.tbEventLength.TabIndex = 7;
            // 
            // tbPriority
            // 
            this.tbPriority.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriority.Location = new System.Drawing.Point(154, 226);
            this.tbPriority.Margin = new System.Windows.Forms.Padding(2);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(243, 23);
            this.tbPriority.TabIndex = 8;
            this.tbPriority.TextChanged += new System.EventHandler(this.tbPriority_TextChanged);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDone.FlatAppearance.BorderSize = 5;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDone.Location = new System.Drawing.Point(322, 317);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(175, 60);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnEventAdder
            // 
            this.btnEventAdder.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEventAdder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEventAdder.FlatAppearance.BorderSize = 5;
            this.btnEventAdder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventAdder.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventAdder.ForeColor = System.Drawing.Color.White;
            this.btnEventAdder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventAdder.Location = new System.Drawing.Point(30, 317);
            this.btnEventAdder.Margin = new System.Windows.Forms.Padding(5);
            this.btnEventAdder.Name = "btnEventAdder";
            this.btnEventAdder.Padding = new System.Windows.Forms.Padding(5);
            this.btnEventAdder.Size = new System.Drawing.Size(177, 60);
            this.btnEventAdder.TabIndex = 0;
            this.btnEventAdder.Text = "Add Event";
            this.btnEventAdder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEventAdder.UseVisualStyleBackColor = false;
            this.btnEventAdder.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.Color.White;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(51, 253);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(65, 16);
            this.lblDueDate.TabIndex = 10;
            this.lblDueDate.Text = "Due Date";
            this.lblDueDate.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // dtDueDate
            // 
            this.dtDueDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDueDate.Location = new System.Drawing.Point(154, 253);
            this.dtDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(243, 23);
            this.dtDueDate.TabIndex = 12;
            this.dtDueDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(30, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(467, 48);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Event";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 167);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(30, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(467, 38);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "UCFC Industries";
            // 
            // Schedlr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 391);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.btnEventAdder);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Schedlr";
            this.Text = "Schedlr";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

