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
            // Schedlr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
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
    }
}

