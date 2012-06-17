namespace Modelmayhem_Assistant
{
    partial class CHANGELOG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHANGELOG));
            this.progname = new System.Windows.Forms.Label();
            this.labellog = new System.Windows.Forms.Label();
            this.labelautor = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // progname
            // 
            this.progname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progname.Location = new System.Drawing.Point(12, 9);
            this.progname.Name = "progname";
            this.progname.Size = new System.Drawing.Size(768, 33);
            this.progname.TabIndex = 0;
            this.progname.Text = "Modelmayhem Assistant";
            this.progname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labellog
            // 
            this.labellog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labellog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellog.Location = new System.Drawing.Point(12, 42);
            this.labellog.Name = "labellog";
            this.labellog.Size = new System.Drawing.Size(768, 461);
            this.labellog.TabIndex = 1;
            this.labellog.Text = "label2";
            // 
            // labelautor
            // 
            this.labelautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelautor.Location = new System.Drawing.Point(610, 503);
            this.labelautor.Name = "labelautor";
            this.labelautor.Size = new System.Drawing.Size(167, 33);
            this.labelautor.TabIndex = 2;
            this.labelautor.Text = "autortext";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(609, 545);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 19);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // CHANGELOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelautor);
            this.Controls.Add(this.labellog);
            this.Controls.Add(this.progname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CHANGELOG";
            this.Text = "CHANGELOG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label progname;
        private System.Windows.Forms.Label labellog;
        private System.Windows.Forms.Label labelautor;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}