namespace Electronic_genealogy
{
    partial class Addmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addmember));
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.faid = new System.Windows.Forms.TextBox();
            this.geid = new System.Windows.Forms.TextBox();
            this.gnum = new System.Windows.Forms.TextBox();
            this.M_faid = new System.Windows.Forms.Label();
            this.Ge_id = new System.Windows.Forms.Label();
            this.M_gnum = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.TextBox();
            this.lvpl = new System.Windows.Forms.TextBox();
            this.brpl = new System.Windows.Forms.TextBox();
            this.dead = new System.Windows.Forms.TextBox();
            this.born = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.M_rank = new System.Windows.Forms.Label();
            this.M_lvpl = new System.Windows.Forms.Label();
            this.M_brpl = new System.Windows.Forms.Label();
            this.M_dead = new System.Windows.Forms.Label();
            this.M_born = new System.Windows.Forms.Label();
            this.M_sex = new System.Windows.Forms.Label();
            this.M_name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.M_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Ok.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ok.Location = new System.Drawing.Point(458, 391);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(122, 41);
            this.Ok.TabIndex = 47;
            this.Ok.Text = "确   定";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Location = new System.Drawing.Point(256, 391);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(122, 41);
            this.Cancel.TabIndex = 46;
            this.Cancel.Text = "取   消";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // faid
            // 
            this.faid.Location = new System.Drawing.Point(175, 321);
            this.faid.Name = "faid";
            this.faid.Size = new System.Drawing.Size(121, 28);
            this.faid.TabIndex = 45;
            // 
            // geid
            // 
            this.geid.Location = new System.Drawing.Point(610, 321);
            this.geid.Name = "geid";
            this.geid.Size = new System.Drawing.Size(121, 28);
            this.geid.TabIndex = 44;
            // 
            // gnum
            // 
            this.gnum.Location = new System.Drawing.Point(610, 258);
            this.gnum.Name = "gnum";
            this.gnum.Size = new System.Drawing.Size(121, 28);
            this.gnum.TabIndex = 43;
            // 
            // M_faid
            // 
            this.M_faid.BackColor = System.Drawing.Color.Transparent;
            this.M_faid.Location = new System.Drawing.Point(69, 319);
            this.M_faid.Name = "M_faid";
            this.M_faid.Size = new System.Drawing.Size(100, 28);
            this.M_faid.TabIndex = 42;
            this.M_faid.Text = "父亲ID：";
            this.M_faid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ge_id
            // 
            this.Ge_id.BackColor = System.Drawing.Color.Transparent;
            this.Ge_id.Location = new System.Drawing.Point(494, 321);
            this.Ge_id.Name = "Ge_id";
            this.Ge_id.Size = new System.Drawing.Size(100, 28);
            this.Ge_id.TabIndex = 41;
            this.Ge_id.Text = "族谱ID：";
            this.Ge_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_gnum
            // 
            this.M_gnum.BackColor = System.Drawing.Color.Transparent;
            this.M_gnum.Location = new System.Drawing.Point(494, 256);
            this.M_gnum.Name = "M_gnum";
            this.M_gnum.Size = new System.Drawing.Size(100, 28);
            this.M_gnum.TabIndex = 40;
            this.M_gnum.Text = "代  数：";
            this.M_gnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(610, 190);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(121, 28);
            this.rank.TabIndex = 39;
            // 
            // lvpl
            // 
            this.lvpl.Location = new System.Drawing.Point(610, 128);
            this.lvpl.Name = "lvpl";
            this.lvpl.Size = new System.Drawing.Size(121, 28);
            this.lvpl.TabIndex = 38;
            // 
            // brpl
            // 
            this.brpl.Location = new System.Drawing.Point(610, 71);
            this.brpl.Name = "brpl";
            this.brpl.Size = new System.Drawing.Size(121, 28);
            this.brpl.TabIndex = 37;
            // 
            // dead
            // 
            this.dead.Location = new System.Drawing.Point(175, 258);
            this.dead.Name = "dead";
            this.dead.Size = new System.Drawing.Size(121, 28);
            this.dead.TabIndex = 36;
            // 
            // born
            // 
            this.born.Location = new System.Drawing.Point(175, 190);
            this.born.Name = "born";
            this.born.Size = new System.Drawing.Size(121, 28);
            this.born.TabIndex = 35;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(175, 126);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(121, 28);
            this.sex.TabIndex = 34;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(175, 69);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 28);
            this.name.TabIndex = 33;
            // 
            // M_rank
            // 
            this.M_rank.BackColor = System.Drawing.Color.Transparent;
            this.M_rank.Location = new System.Drawing.Point(494, 186);
            this.M_rank.Name = "M_rank";
            this.M_rank.Size = new System.Drawing.Size(100, 28);
            this.M_rank.TabIndex = 32;
            this.M_rank.Text = "排  行：";
            this.M_rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_lvpl
            // 
            this.M_lvpl.BackColor = System.Drawing.Color.Transparent;
            this.M_lvpl.Location = new System.Drawing.Point(494, 124);
            this.M_lvpl.Name = "M_lvpl";
            this.M_lvpl.Size = new System.Drawing.Size(100, 28);
            this.M_lvpl.TabIndex = 31;
            this.M_lvpl.Text = "居住地：";
            this.M_lvpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_brpl
            // 
            this.M_brpl.BackColor = System.Drawing.Color.Transparent;
            this.M_brpl.Location = new System.Drawing.Point(494, 69);
            this.M_brpl.Name = "M_brpl";
            this.M_brpl.Size = new System.Drawing.Size(100, 28);
            this.M_brpl.TabIndex = 30;
            this.M_brpl.Text = "出生地：";
            this.M_brpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_dead
            // 
            this.M_dead.BackColor = System.Drawing.Color.Transparent;
            this.M_dead.Location = new System.Drawing.Point(69, 256);
            this.M_dead.Name = "M_dead";
            this.M_dead.Size = new System.Drawing.Size(100, 28);
            this.M_dead.TabIndex = 29;
            this.M_dead.Text = "死亡日期：";
            this.M_dead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_born
            // 
            this.M_born.BackColor = System.Drawing.Color.Transparent;
            this.M_born.Location = new System.Drawing.Point(69, 186);
            this.M_born.Name = "M_born";
            this.M_born.Size = new System.Drawing.Size(100, 28);
            this.M_born.TabIndex = 28;
            this.M_born.Text = "出生日期：";
            this.M_born.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_sex
            // 
            this.M_sex.BackColor = System.Drawing.Color.Transparent;
            this.M_sex.Location = new System.Drawing.Point(69, 126);
            this.M_sex.Name = "M_sex";
            this.M_sex.Size = new System.Drawing.Size(100, 28);
            this.M_sex.TabIndex = 27;
            this.M_sex.Text = "性  别：";
            this.M_sex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_name
            // 
            this.M_name.BackColor = System.Drawing.Color.Transparent;
            this.M_name.Location = new System.Drawing.Point(69, 69);
            this.M_name.Name = "M_name";
            this.M_name.Size = new System.Drawing.Size(100, 28);
            this.M_name.TabIndex = 26;
            this.M_name.Text = "姓  名：";
            this.M_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(405, 18);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(121, 28);
            this.id.TabIndex = 25;
            // 
            // M_id
            // 
            this.M_id.BackColor = System.Drawing.Color.Transparent;
            this.M_id.Location = new System.Drawing.Point(299, 18);
            this.M_id.Name = "M_id";
            this.M_id.Size = new System.Drawing.Size(100, 28);
            this.M_id.TabIndex = 24;
            this.M_id.Text = "成员ID：";
            this.M_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 增加成员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.faid);
            this.Controls.Add(this.geid);
            this.Controls.Add(this.gnum);
            this.Controls.Add(this.M_faid);
            this.Controls.Add(this.Ge_id);
            this.Controls.Add(this.M_gnum);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.lvpl);
            this.Controls.Add(this.brpl);
            this.Controls.Add(this.dead);
            this.Controls.Add(this.born);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.name);
            this.Controls.Add(this.M_rank);
            this.Controls.Add(this.M_lvpl);
            this.Controls.Add(this.M_brpl);
            this.Controls.Add(this.M_dead);
            this.Controls.Add(this.M_born);
            this.Controls.Add(this.M_sex);
            this.Controls.Add(this.M_name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.M_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "增加成员";
            this.Text = "增加成员";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox faid;
        private System.Windows.Forms.TextBox geid;
        private System.Windows.Forms.TextBox gnum;
        private System.Windows.Forms.Label M_faid;
        private System.Windows.Forms.Label Ge_id;
        private System.Windows.Forms.Label M_gnum;
        private System.Windows.Forms.TextBox rank;
        private System.Windows.Forms.TextBox lvpl;
        private System.Windows.Forms.TextBox brpl;
        private System.Windows.Forms.TextBox dead;
        private System.Windows.Forms.TextBox born;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label M_rank;
        private System.Windows.Forms.Label M_lvpl;
        private System.Windows.Forms.Label M_brpl;
        private System.Windows.Forms.Label M_dead;
        private System.Windows.Forms.Label M_born;
        private System.Windows.Forms.Label M_sex;
        private System.Windows.Forms.Label M_name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label M_id;
    }
}