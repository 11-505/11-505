﻿namespace Electronic_genealogy
{
    partial class Systemadmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Systemadmins));
            this.Momembers = new System.Windows.Forms.Button();
            this.Newgenealogy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Momembers
            // 
            this.Momembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Momembers.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Momembers.Location = new System.Drawing.Point(125, 300);
            this.Momembers.Name = "Momembers";
            this.Momembers.Size = new System.Drawing.Size(150, 50);
            this.Momembers.TabIndex = 1;
            this.Momembers.Text = "修改族谱";
            this.Momembers.UseVisualStyleBackColor = true;
            // 
            // Newgenealogy
            // 
            this.Newgenealogy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newgenealogy.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Newgenealogy.Location = new System.Drawing.Point(125, 100);
            this.Newgenealogy.Name = "Newgenealogy";
            this.Newgenealogy.Size = new System.Drawing.Size(150, 50);
            this.Newgenealogy.TabIndex = 2;
            this.Newgenealogy.Text = "新建族谱";
            this.Newgenealogy.UseVisualStyleBackColor = true;
            // 
            // Systemadmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.Newgenealogy);
            this.Controls.Add(this.Momembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Systemadmins";
            this.Text = "系统管理员";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Momembers;
        private System.Windows.Forms.Button Newgenealogy;
    }
}