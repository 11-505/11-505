namespace Electronic_genealogy
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.Qumembers = new System.Windows.Forms.Button();
            this.Quwife = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Qumembers
            // 
            this.Qumembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Qumembers.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Qumembers.Location = new System.Drawing.Point(125, 100);
            this.Qumembers.Name = "Qumembers";
            this.Qumembers.Size = new System.Drawing.Size(150, 50);
            this.Qumembers.TabIndex = 0;
            this.Qumembers.Text = "查询成员";
            this.Qumembers.UseVisualStyleBackColor = true;
            // 
            // Quwife
            // 
            this.Quwife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quwife.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Quwife.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Quwife.Location = new System.Drawing.Point(125, 300);
            this.Quwife.Name = "Quwife";
            this.Quwife.Size = new System.Drawing.Size(150, 50);
            this.Quwife.TabIndex = 1;
            this.Quwife.Text = "查询配偶";
            this.Quwife.UseVisualStyleBackColor = true;
            this.Quwife.Click += new System.EventHandler(this.Quwife_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 495);
            this.Controls.Add(this.Quwife);
            this.Controls.Add(this.Qumembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.Text = "用户";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Qumembers;
        private System.Windows.Forms.Button Quwife;
    }
}