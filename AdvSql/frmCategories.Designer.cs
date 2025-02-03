namespace AdvSql
{
    partial class frmCategories
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCategories = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClearForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.BackgroundColor = SystemColors.ControlLightLight;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(59, 26);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(555, 271);
            dgvCategories.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 319);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "รหัสหมวดหมู่สินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 358);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 2;
            label2.Text = "ชื่อหมวดหมู่สินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 394);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 3;
            label3.Text = "คำอธิบายหมวดหมู่";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(146, 316);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(399, 27);
            txtCategoryID.TabIndex = 4;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(146, 355);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(399, 27);
            txtCategoryName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(146, 394);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(399, 102);
            txtDescription.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 128, 0);
            btnInsert.ForeColor = SystemColors.ControlLightLight;
            btnInsert.Location = new Point(12, 513);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(109, 58);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "เพิ่ม";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(127, 513);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 58);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "ปรับปรุง";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lime;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(384, 513);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 58);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.FromArgb(255, 255, 192);
            btnClearForm.ForeColor = Color.Black;
            btnClearForm.Location = new Point(524, 513);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(109, 58);
            btnClearForm.TabIndex = 10;
            btnClearForm.Text = "ล้างฟอร์ม";
            btnClearForm.UseVisualStyleBackColor = false;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(645, 594);
            Controls.Add(btnClearForm);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCategories);
            Name = "frmCategories";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClearForm;
    }
}
