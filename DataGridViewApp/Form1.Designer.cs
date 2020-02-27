namespace DataGridViewApp
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxPosition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtEmployeeID,
            this.txtName,
            this.cbxPosition,
            this.txtOffice,
            this.txtAge});
            this.dgvEmployee.Location = new System.Drawing.Point(-1, 1);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(798, 369);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellValueChanged);
            this.dgvEmployee.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvEmployee_EditingControlShowing);
            this.dgvEmployee.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEmployee_UserDeletingRow);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.DataPropertyName = "EmployeeID";
            this.txtEmployeeID.HeaderText = "EmployeeID";
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            // 
            // cbxPosition
            // 
            this.cbxPosition.DataPropertyName = "PositionID";
            this.cbxPosition.HeaderText = "Position";
            this.cbxPosition.Name = "cbxPosition";
            // 
            // txtOffice
            // 
            this.txtOffice.DataPropertyName = "Office";
            this.txtOffice.HeaderText = "Office";
            this.txtOffice.Name = "txtOffice";
            // 
            // txtAge
            // 
            this.txtAge.DataPropertyName = "Age";
            this.txtAge.HeaderText = "Age";
            this.txtAge.Name = "txtAge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Insert Update And Delete In C# DataGridView ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAge;
    }
}

