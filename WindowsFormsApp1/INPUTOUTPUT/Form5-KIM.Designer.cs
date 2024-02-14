namespace WindowsFormsApp1
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sch_btn = new System.Windows.Forms.Button();
            this.first_time = new System.Windows.Forms.DateTimePicker();
            this.search_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.last_time = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.importDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sch_btn
            // 
            this.sch_btn.Font = new System.Drawing.Font("굴림", 10F);
            this.sch_btn.Location = new System.Drawing.Point(876, 53);
            this.sch_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sch_btn.Name = "sch_btn";
            this.sch_btn.Size = new System.Drawing.Size(120, 21);
            this.sch_btn.TabIndex = 45;
            this.sch_btn.Text = "검색";
            this.sch_btn.UseVisualStyleBackColor = true;
            // 
            // first_time
            // 
            this.first_time.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.first_time.Location = new System.Drawing.Point(99, 52);
            this.first_time.Margin = new System.Windows.Forms.Padding(2);
            this.first_time.Name = "first_time";
            this.first_time.Size = new System.Drawing.Size(206, 25);
            this.first_time.TabIndex = 42;
            // 
            // search_combobox
            // 
            this.search_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_combobox.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_combobox.FormattingEnabled = true;
            this.search_combobox.Location = new System.Drawing.Point(660, 53);
            this.search_combobox.Margin = new System.Windows.Forms.Padding(0);
            this.search_combobox.Name = "search_combobox";
            this.search_combobox.Size = new System.Drawing.Size(167, 25);
            this.search_combobox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(306, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "~";
            // 
            // last_time
            // 
            this.last_time.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.last_time.Location = new System.Drawing.Point(334, 52);
<<<<<<< HEAD
            this.last_time.Margin = new System.Windows.Forms.Padding(2);
=======
            this.last_time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> 0a3a39eb62b2f0ef8cf9b6facb28208ab332245a
            this.last_time.Name = "last_time";
            this.last_time.Size = new System.Drawing.Size(236, 25);
            this.last_time.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(7, 56);
=======
            this.label2.Location = new System.Drawing.Point(22, 56);
>>>>>>> 0a3a39eb62b2f0ef8cf9b6facb28208ab332245a
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "기간검색";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(596, 56);
=======
            this.label3.Location = new System.Drawing.Point(611, 56);
>>>>>>> 0a3a39eb62b2f0ef8cf9b6facb28208ab332245a
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "항목";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.importDate,
            this.lotNumber,
            this.materialId,
            this.materialName,
            this.company,
            this.productType,
            this.etc});
<<<<<<< HEAD
            this.dataGridView1.Location = new System.Drawing.Point(3, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
=======
            this.dataGridView1.Location = new System.Drawing.Point(18, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> 0a3a39eb62b2f0ef8cf9b6facb28208ab332245a
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
<<<<<<< HEAD
            this.dataGridView1.Size = new System.Drawing.Size(1402, 915);
=======
            this.dataGridView1.Size = new System.Drawing.Size(1217, 681);
>>>>>>> 0a3a39eb62b2f0ef8cf9b6facb28208ab332245a
            this.dataGridView1.TabIndex = 48;
            // 
            // importDate
            // 
            this.importDate.HeaderText = "보관위치";
            this.importDate.MinimumWidth = 10;
            this.importDate.Name = "importDate";
            // 
            // lotNumber
            // 
            this.lotNumber.HeaderText = "입고일";
            this.lotNumber.MinimumWidth = 10;
            this.lotNumber.Name = "lotNumber";
            this.lotNumber.Width = 150;
            // 
            // materialId
            // 
            this.materialId.HeaderText = "유통기한";
            this.materialId.MinimumWidth = 10;
            this.materialId.Name = "materialId";
            this.materialId.Width = 150;
            // 
            // materialName
            // 
            this.materialName.HeaderText = "상품코드";
            this.materialName.MinimumWidth = 10;
            this.materialName.Name = "materialName";
            // 
            // company
            // 
            this.company.HeaderText = "제조업체";
            this.company.MinimumWidth = 10;
            this.company.Name = "company";
            this.company.Width = 200;
            // 
            // productType
            // 
            this.productType.HeaderText = "품명";
            this.productType.MinimumWidth = 10;
            this.productType.Name = "productType";
            this.productType.Width = 300;
            // 
            // etc
            // 
            this.etc.HeaderText = "검사결과";
            this.etc.MinimumWidth = 10;
            this.etc.Name = "etc";
            this.etc.Width = 120;
            // 
            // Form5
            // 
<<<<<<< HEAD
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 962);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 743);
>>>>>>> 0a3a39eb62b2f0ef8cf9b6facb28208ab332245a
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sch_btn);
            this.Controls.Add(this.first_time);
            this.Controls.Add(this.search_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last_time);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
<<<<<<< HEAD
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
=======
>>>>>>> 0a3a39eb62b2f0ef8cf9b6facb28208ab332245a
            this.Text = "Form5";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sch_btn;
        private System.Windows.Forms.DateTimePicker first_time;
        private System.Windows.Forms.ComboBox search_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker last_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn importDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn productType;
        private System.Windows.Forms.DataGridViewTextBoxColumn etc;
    }
}