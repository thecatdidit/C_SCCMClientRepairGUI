namespace SCCM_Client_Repair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Repair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Repair
            // 
            this.button_Repair.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button_Repair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Repair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button_Repair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Repair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Repair.Location = new System.Drawing.Point(147, 85);
            this.button_Repair.Name = "button_Repair";
            this.button_Repair.Size = new System.Drawing.Size(165, 37);
            this.button_Repair.TabIndex = 1;
            this.button_Repair.Text = "Repair SCCM 2012 Client";
            this.button_Repair.UseVisualStyleBackColor = true;
            this.button_Repair.Click += new System.EventHandler(this.button_Repair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stripLabel,
            this.stripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 169);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(441, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "Version 1.0.0";
            // 
            // stripLabel
            // 
            this.stripLabel.AutoSize = false;
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(250, 17);
            this.stripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stripProgressBar
            // 
            this.stripProgressBar.Name = "stripProgressBar";
            this.stripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SCCM_Client_Repair.Properties.Resources.pennmed_2in_color;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(106, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 86);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMain.Location = new System.Drawing.Point(46, 93);
            this.labelMain.MaximumSize = new System.Drawing.Size(350, 0);
            this.labelMain.MinimumSize = new System.Drawing.Size(350, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(350, 21);
            this.labelMain.TabIndex = 4;
            this.labelMain.Text = "Do not close this program until it is completed. ";
            this.labelMain.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(441, 191);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.button_Repair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Penn Medicine IS - SCCM Client Repair";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Repair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private System.Windows.Forms.ToolStripProgressBar stripProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMain;
    }
}

