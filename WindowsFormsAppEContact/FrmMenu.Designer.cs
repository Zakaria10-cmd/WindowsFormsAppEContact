namespace WindowsFormsAppEContact
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnListContact = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pContent = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pMenu.Controls.Add(this.btnQuit);
            this.pMenu.Controls.Add(this.btnNouveau);
            this.pMenu.Controls.Add(this.btnListContact);
            this.pMenu.Controls.Add(this.pictureBox1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(156, 600);
            this.pMenu.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.Location = new System.Drawing.Point(4, 249);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(154, 53);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveau.Image")));
            this.btnNouveau.Location = new System.Drawing.Point(4, 190);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(154, 53);
            this.btnNouveau.TabIndex = 3;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnListContact
            // 
            this.btnListContact.BackColor = System.Drawing.Color.SkyBlue;
            this.btnListContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListContact.FlatAppearance.BorderSize = 0;
            this.btnListContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListContact.Image = ((System.Drawing.Image)(resources.GetObject("btnListContact.Image")));
            this.btnListContact.Location = new System.Drawing.Point(4, 131);
            this.btnListContact.Name = "btnListContact";
            this.btnListContact.Size = new System.Drawing.Size(154, 53);
            this.btnListContact.TabIndex = 2;
            this.btnListContact.Text = "Contacts";
            this.btnListContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListContact.UseVisualStyleBackColor = false;
            this.btnListContact.Click += new System.EventHandler(this.btnListContact_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.Color.DarkGray;
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pContent.Location = new System.Drawing.Point(156, 0);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(719, 600);
            this.pContent.TabIndex = 1;
            // 
            // FrmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(875, 600);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnListContact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Panel pContent;
    }
}