namespace Electronic_genealogy
{
    partial class Momembers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Momembers));
            this.button1 = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Algebra = new System.Windows.Forms.TextBox();
            this.Ranking = new System.Windows.Forms.TextBox();
            this.Placebirth = new System.Windows.Forms.TextBox();
            this.Datebirth = new System.Windows.Forms.TextBox();
            this.NameT = new System.Windows.Forms.TextBox();
            this.Wherelive = new System.Windows.Forms.TextBox();
            this.Datedeath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.FatherID = new System.Windows.Forms.TextBox();
            this.GenealogyID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Momember = new System.Windows.Forms.DataGridView();
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdeadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlvplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genealogy_DataDataSet = new Electronic_genealogy.Genealogy_DataDataSet();
            this.membersTableAdapter = new Electronic_genealogy.Genealogy_DataDataSetTableAdapters.MembersTableAdapter();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Momember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genealogy_DataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(572, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(659, 300);
            this.Gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(112, 28);
            this.Gender.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(144, 300);
            this.ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(112, 28);
            this.ID.TabIndex = 5;
            // 
            // Algebra
            // 
            this.Algebra.Location = new System.Drawing.Point(659, 425);
            this.Algebra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Algebra.Name = "Algebra";
            this.Algebra.Size = new System.Drawing.Size(112, 28);
            this.Algebra.TabIndex = 9;
            // 
            // Ranking
            // 
            this.Ranking.Location = new System.Drawing.Point(144, 425);
            this.Ranking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(112, 28);
            this.Ranking.TabIndex = 10;
            // 
            // Placebirth
            // 
            this.Placebirth.Location = new System.Drawing.Point(397, 361);
            this.Placebirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Placebirth.Name = "Placebirth";
            this.Placebirth.Size = new System.Drawing.Size(112, 28);
            this.Placebirth.TabIndex = 11;
            // 
            // Datebirth
            // 
            this.Datebirth.Location = new System.Drawing.Point(144, 361);
            this.Datebirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Datebirth.Name = "Datebirth";
            this.Datebirth.Size = new System.Drawing.Size(112, 28);
            this.Datebirth.TabIndex = 12;
            // 
            // NameT
            // 
            this.NameT.Location = new System.Drawing.Point(397, 300);
            this.NameT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(112, 28);
            this.NameT.TabIndex = 13;
            // 
            // Wherelive
            // 
            this.Wherelive.Location = new System.Drawing.Point(659, 361);
            this.Wherelive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Wherelive.Name = "Wherelive";
            this.Wherelive.Size = new System.Drawing.Size(112, 28);
            this.Wherelive.TabIndex = 14;
            // 
            // Datedeath
            // 
            this.Datedeath.Location = new System.Drawing.Point(397, 425);
            this.Datedeath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Datedeath.Name = "Datedeath";
            this.Datedeath.Size = new System.Drawing.Size(112, 28);
            this.Datedeath.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(90, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 19);
            this.label14.TabIndex = 27;
            this.label14.Text = "ID：";
            // 
            // FatherID
            // 
            this.FatherID.Location = new System.Drawing.Point(144, 483);
            this.FatherID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FatherID.Name = "FatherID";
            this.FatherID.Size = new System.Drawing.Size(112, 28);
            this.FatherID.TabIndex = 8;
            // 
            // GenealogyID
            // 
            this.GenealogyID.Location = new System.Drawing.Point(397, 483);
            this.GenealogyID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenealogyID.Name = "GenealogyID";
            this.GenealogyID.Size = new System.Drawing.Size(112, 28);
            this.GenealogyID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(306, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "出生地：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(52, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "父亲ID：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(34, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "出生日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(325, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "姓名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(287, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "死亡日期：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(72, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "排行：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(305, 486);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "族谱ID：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(587, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "代数：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(568, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 38;
            this.label13.Text = "居住地：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(587, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 19);
            this.label15.TabIndex = 39;
            this.label15.Text = "性别：";
            // 
            // Momember
            // 
            this.Momember.AutoGenerateColumns = false;
            this.Momember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Momember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.mnameDataGridViewTextBoxColumn,
            this.msexDataGridViewTextBoxColumn,
            this.mbornDataGridViewTextBoxColumn,
            this.mdeadDataGridViewTextBoxColumn,
            this.mbrplDataGridViewTextBoxColumn,
            this.mlvplDataGridViewTextBoxColumn,
            this.mrankDataGridViewTextBoxColumn,
            this.mgnumDataGridViewTextBoxColumn,
            this.geidDataGridViewTextBoxColumn,
            this.mfaidDataGridViewTextBoxColumn});
            this.Momember.DataSource = this.membersBindingSource;
            this.Momember.Location = new System.Drawing.Point(-1, 0);
            this.Momember.Name = "Momember";
            this.Momember.RowHeadersWidth = 51;
            this.Momember.RowTemplate.Height = 27;
            this.Momember.Size = new System.Drawing.Size(902, 273);
            this.Momember.TabIndex = 40;
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "M_id";
            this.midDataGridViewTextBoxColumn.HeaderText = "M_id";
            this.midDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            this.midDataGridViewTextBoxColumn.Width = 125;
            // 
            // mnameDataGridViewTextBoxColumn
            // 
            this.mnameDataGridViewTextBoxColumn.DataPropertyName = "M_name";
            this.mnameDataGridViewTextBoxColumn.HeaderText = "M_name";
            this.mnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnameDataGridViewTextBoxColumn.Name = "mnameDataGridViewTextBoxColumn";
            this.mnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // msexDataGridViewTextBoxColumn
            // 
            this.msexDataGridViewTextBoxColumn.DataPropertyName = "M_sex";
            this.msexDataGridViewTextBoxColumn.HeaderText = "M_sex";
            this.msexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.msexDataGridViewTextBoxColumn.Name = "msexDataGridViewTextBoxColumn";
            this.msexDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbornDataGridViewTextBoxColumn
            // 
            this.mbornDataGridViewTextBoxColumn.DataPropertyName = "M_born";
            this.mbornDataGridViewTextBoxColumn.HeaderText = "M_born";
            this.mbornDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbornDataGridViewTextBoxColumn.Name = "mbornDataGridViewTextBoxColumn";
            this.mbornDataGridViewTextBoxColumn.Width = 125;
            // 
            // mdeadDataGridViewTextBoxColumn
            // 
            this.mdeadDataGridViewTextBoxColumn.DataPropertyName = "M_dead";
            this.mdeadDataGridViewTextBoxColumn.HeaderText = "M_dead";
            this.mdeadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mdeadDataGridViewTextBoxColumn.Name = "mdeadDataGridViewTextBoxColumn";
            this.mdeadDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrplDataGridViewTextBoxColumn
            // 
            this.mbrplDataGridViewTextBoxColumn.DataPropertyName = "M_brpl";
            this.mbrplDataGridViewTextBoxColumn.HeaderText = "M_brpl";
            this.mbrplDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrplDataGridViewTextBoxColumn.Name = "mbrplDataGridViewTextBoxColumn";
            this.mbrplDataGridViewTextBoxColumn.Width = 125;
            // 
            // mlvplDataGridViewTextBoxColumn
            // 
            this.mlvplDataGridViewTextBoxColumn.DataPropertyName = "M_lvpl";
            this.mlvplDataGridViewTextBoxColumn.HeaderText = "M_lvpl";
            this.mlvplDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mlvplDataGridViewTextBoxColumn.Name = "mlvplDataGridViewTextBoxColumn";
            this.mlvplDataGridViewTextBoxColumn.Width = 125;
            // 
            // mrankDataGridViewTextBoxColumn
            // 
            this.mrankDataGridViewTextBoxColumn.DataPropertyName = "M_rank";
            this.mrankDataGridViewTextBoxColumn.HeaderText = "M_rank";
            this.mrankDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mrankDataGridViewTextBoxColumn.Name = "mrankDataGridViewTextBoxColumn";
            this.mrankDataGridViewTextBoxColumn.Width = 125;
            // 
            // mgnumDataGridViewTextBoxColumn
            // 
            this.mgnumDataGridViewTextBoxColumn.DataPropertyName = "M_gnum";
            this.mgnumDataGridViewTextBoxColumn.HeaderText = "M_gnum";
            this.mgnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mgnumDataGridViewTextBoxColumn.Name = "mgnumDataGridViewTextBoxColumn";
            this.mgnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // geidDataGridViewTextBoxColumn
            // 
            this.geidDataGridViewTextBoxColumn.DataPropertyName = "Ge_id";
            this.geidDataGridViewTextBoxColumn.HeaderText = "Ge_id";
            this.geidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.geidDataGridViewTextBoxColumn.Name = "geidDataGridViewTextBoxColumn";
            this.geidDataGridViewTextBoxColumn.Width = 125;
            // 
            // mfaidDataGridViewTextBoxColumn
            // 
            this.mfaidDataGridViewTextBoxColumn.DataPropertyName = "M_faid";
            this.mfaidDataGridViewTextBoxColumn.HeaderText = "M_faid";
            this.mfaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mfaidDataGridViewTextBoxColumn.Name = "mfaidDataGridViewTextBoxColumn";
            this.mfaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.genealogy_DataDataSet;
            // 
            // genealogy_DataDataSet
            // 
            this.genealogy_DataDataSet.DataSetName = "Genealogy_DataDataSet";
            this.genealogy_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.SystemColors.Control;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Refresh.Location = new System.Drawing.Point(747, 475);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(98, 36);
            this.Refresh.TabIndex = 41;
            this.Refresh.Text = "刷新";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Momembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Momember);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Datedeath);
            this.Controls.Add(this.Wherelive);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.Datebirth);
            this.Controls.Add(this.Placebirth);
            this.Controls.Add(this.Ranking);
            this.Controls.Add(this.Algebra);
            this.Controls.Add(this.FatherID);
            this.Controls.Add(this.GenealogyID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Momembers";
            this.Text = "修改成员";
            this.Load += new System.EventHandler(this.Momembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Momember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genealogy_DataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Algebra;
        private System.Windows.Forms.TextBox Ranking;
        private System.Windows.Forms.TextBox Placebirth;
        private System.Windows.Forms.TextBox Datebirth;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.TextBox Wherelive;
        private System.Windows.Forms.TextBox Datedeath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox FatherID;
        private System.Windows.Forms.TextBox GenealogyID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView Momember;
        private Genealogy_DataDataSet genealogy_DataDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private Genealogy_DataDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdeadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlvplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Refresh;
    }
}