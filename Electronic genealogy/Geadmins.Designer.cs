namespace Electronic_genealogy
{
    partial class Geadmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geadmins));
            this.Momembers = new System.Windows.Forms.Button();
            this.Newmembers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Momembers
            // 
            this.Momembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Momembers.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Momembers.Location = new System.Drawing.Point(125, 325);
            this.Momembers.Name = "Momembers";
            this.Momembers.Size = new System.Drawing.Size(150, 50);
            this.Momembers.TabIndex = 1;
            this.Momembers.Text = "修改成员";
            this.Momembers.UseVisualStyleBackColor = true;
            this.Momembers.Click += new System.EventHandler(this.Momembers_Click);
            // 
            // Newmembers
            // 
            this.Newmembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newmembers.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Newmembers.Location = new System.Drawing.Point(125, 75);
            this.Newmembers.Name = "Newmembers";
            this.Newmembers.Size = new System.Drawing.Size(150, 50);
            this.Newmembers.TabIndex = 2;
            this.Newmembers.Text = "增加成员";
            this.Newmembers.UseVisualStyleBackColor = true;
            this.Newmembers.Click += new System.EventHandler(this.Newmembers_Click);
            // 
            // Geadmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.Newmembers);
            this.Controls.Add(this.Momembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Geadmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "族谱管理员";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Momembers;
        private System.Windows.Forms.Button Newmembers;
    }
}