namespace piratesfinals
{
    partial class frmPirates
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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.btnSearchPirate = new System.Windows.Forms.Button();
            this.grdView = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBPirate = new System.Windows.Forms.GroupBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBounty = new System.Windows.Forms.TextBox();
            this.cboPirate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            this.groupBPirate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(41, 39);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(196, 20);
            this.txtKeyword.TabIndex = 0;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(270, 39);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(121, 21);
            this.cboGroup.TabIndex = 1;
            // 
            // btnSearchPirate
            // 
            this.btnSearchPirate.Location = new System.Drawing.Point(440, 36);
            this.btnSearchPirate.Name = "btnSearchPirate";
            this.btnSearchPirate.Size = new System.Drawing.Size(137, 23);
            this.btnSearchPirate.TabIndex = 2;
            this.btnSearchPirate.Text = "Search Pirate";
            this.btnSearchPirate.UseVisualStyleBackColor = true;
            this.btnSearchPirate.Click += new System.EventHandler(this.btnSearchPirate_Click);
            // 
            // grdView
            // 
            this.grdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdView.Location = new System.Drawing.Point(24, 133);
            this.grdView.Name = "grdView";
            this.grdView.ReadOnly = true;
            this.grdView.RowHeadersVisible = false;
            this.grdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdView.Size = new System.Drawing.Size(771, 414);
            this.grdView.TabIndex = 3;
            this.grdView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdView_CellClick);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(52, 574);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(121, 42);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View Details";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 574);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Pirate Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBPirate
            // 
            this.groupBPirate.Controls.Add(this.btnCancel);
            this.groupBPirate.Controls.Add(this.BtnSave);
            this.groupBPirate.Controls.Add(this.btnNewRecord);
            this.groupBPirate.Controls.Add(this.label5);
            this.groupBPirate.Controls.Add(this.label4);
            this.groupBPirate.Controls.Add(this.label3);
            this.groupBPirate.Controls.Add(this.label2);
            this.groupBPirate.Controls.Add(this.label1);
            this.groupBPirate.Controls.Add(this.cboPirate);
            this.groupBPirate.Controls.Add(this.txtBounty);
            this.groupBPirate.Controls.Add(this.txtName);
            this.groupBPirate.Controls.Add(this.txtAge);
            this.groupBPirate.Controls.Add(this.txtAlias);
            this.groupBPirate.Location = new System.Drawing.Point(813, 133);
            this.groupBPirate.Name = "groupBPirate";
            this.groupBPirate.Size = new System.Drawing.Size(339, 396);
            this.groupBPirate.TabIndex = 6;
            this.groupBPirate.TabStop = false;
            this.groupBPirate.Text = "Pirate Information";
            this.groupBPirate.Enter += new System.EventHandler(this.groupBPirate_Enter);
            // 
            // txtAlias
            // 
            this.txtAlias.Enabled = false;
            this.txtAlias.Location = new System.Drawing.Point(99, 49);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(217, 20);
            this.txtAlias.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(99, 156);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(217, 20);
            this.txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(99, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtBounty
            // 
            this.txtBounty.Enabled = false;
            this.txtBounty.Location = new System.Drawing.Point(99, 274);
            this.txtBounty.Name = "txtBounty";
            this.txtBounty.Size = new System.Drawing.Size(217, 20);
            this.txtBounty.TabIndex = 3;
            // 
            // cboPirate
            // 
            this.cboPirate.Enabled = false;
            this.cboPirate.FormattingEnabled = true;
            this.cboPirate.Location = new System.Drawing.Point(99, 212);
            this.cboPirate.Name = "cboPirate";
            this.cboPirate.Size = new System.Drawing.Size(217, 21);
            this.cboPirate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pirate Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bounty";
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Location = new System.Drawing.Point(33, 349);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(75, 23);
            this.btnNewRecord.TabIndex = 10;
            this.btnNewRecord.Text = "New Record";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(133, 349);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPirates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 639);
            this.Controls.Add(this.groupBPirate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.grdView);
            this.Controls.Add(this.btnSearchPirate);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.txtKeyword);
            this.Name = "frmPirates";
            this.Text = "frmPirates";
            this.Load += new System.EventHandler(this.frmPirates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            this.groupBPirate.ResumeLayout(false);
            this.groupBPirate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Button btnSearchPirate;
        private System.Windows.Forms.DataGridView grdView;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBPirate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPirate;
        private System.Windows.Forms.TextBox txtBounty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

