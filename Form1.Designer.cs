namespace Cird_Browser
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
            this.InkBack = new MetroFramework.Controls.MetroLink();
            this.InkForward = new MetroFramework.Controls.MetroLink();
            this.txtUrl = new MetroFramework.Controls.MetroTextBox();
            this.btnGo = new MetroFramework.Controls.MetroButton();
            this.btnNewTab = new MetroFramework.Controls.MetroButton();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InkBack
            // 
            this.InkBack.Image = ((System.Drawing.Image)(resources.GetObject("InkBack.Image")));
            this.InkBack.ImageSize = 20;
            this.InkBack.Location = new System.Drawing.Point(75, 63);
            this.InkBack.Name = "InkBack";
            this.InkBack.Size = new System.Drawing.Size(28, 21);
            this.InkBack.TabIndex = 0;
            this.InkBack.UseSelectable = true;
            this.InkBack.Click += new System.EventHandler(this.InkBack_Click);
            // 
            // InkForward
            // 
            this.InkForward.Image = ((System.Drawing.Image)(resources.GetObject("InkForward.Image")));
            this.InkForward.ImageSize = 20;
            this.InkForward.Location = new System.Drawing.Point(109, 63);
            this.InkForward.Name = "InkForward";
            this.InkForward.Size = new System.Drawing.Size(28, 21);
            this.InkForward.TabIndex = 1;
            this.InkForward.UseSelectable = true;
            this.InkForward.Click += new System.EventHandler(this.InkForward_Click);
            // 
            // txtUrl
            // 
            // 
            // 
            // 
            this.txtUrl.CustomButton.Image = null;
            this.txtUrl.CustomButton.Location = new System.Drawing.Point(884, 1);
            this.txtUrl.CustomButton.Name = "";
            this.txtUrl.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrl.CustomButton.TabIndex = 1;
            this.txtUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrl.CustomButton.UseSelectable = true;
            this.txtUrl.CustomButton.Visible = false;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(153, 65);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.ShortcutsEnabled = true;
            this.txtUrl.Size = new System.Drawing.Size(902, 19);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.UseSelectable = true;
            this.txtUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGo
            // 
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGo.Location = new System.Drawing.Point(1081, 65);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(30, 19);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseSelectable = true;
            this.btnGo.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // btnNewTab
            // 
            this.btnNewTab.Location = new System.Drawing.Point(1134, 65);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(57, 19);
            this.btnNewTab.TabIndex = 4;
            this.btnNewTab.Text = "New Tab";
            this.btnNewTab.UseSelectable = true;
            this.btnNewTab.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Location = new System.Drawing.Point(11, 90);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.Size = new System.Drawing.Size(1242, 587);
            this.metroTabControl.TabIndex = 5;
            this.metroTabControl.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cird Browser";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.btnNewTab);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.InkForward);
            this.Controls.Add(this.InkBack);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink InkBack;
        private MetroFramework.Controls.MetroLink InkForward;
        private MetroFramework.Controls.MetroTextBox txtUrl;
        private MetroFramework.Controls.MetroButton btnGo;
        private MetroFramework.Controls.MetroButton btnNewTab;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

