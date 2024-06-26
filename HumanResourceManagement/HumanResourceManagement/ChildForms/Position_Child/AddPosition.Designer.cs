﻿namespace HumanResourceManagement.ChildForms.Position_Child
{
    partial class frmAddPosition
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panelNamePosition = new System.Windows.Forms.Panel();
            this.txbNamePosition = new System.Windows.Forms.TextBox();
            this.lblNamePosition = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelIdPosition = new System.Windows.Forms.Panel();
            this.txbIdPosition = new System.Windows.Forms.TextBox();
            this.lblIdPosition = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.panelNamePosition.SuspendLayout();
            this.panelIdPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panelDescription);
            this.panel1.Controls.Add(this.panelNamePosition);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.panelIdPosition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 554);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(477, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 49);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Location = new System.Drawing.Point(634, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 49);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelDescription
            // 
            this.panelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDescription.Controls.Add(this.txbDescription);
            this.panelDescription.Controls.Add(this.lblDescription);
            this.panelDescription.Location = new System.Drawing.Point(125, 187);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(651, 264);
            this.panelDescription.TabIndex = 2;
            // 
            // txbDescription
            // 
            this.txbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescription.Location = new System.Drawing.Point(168, 4);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(480, 252);
            this.txbDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 10);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 25);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Mô Tả";
            // 
            // panelNamePosition
            // 
            this.panelNamePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNamePosition.Controls.Add(this.txbNamePosition);
            this.panelNamePosition.Controls.Add(this.lblNamePosition);
            this.panelNamePosition.Location = new System.Drawing.Point(125, 132);
            this.panelNamePosition.Name = "panelNamePosition";
            this.panelNamePosition.Size = new System.Drawing.Size(651, 41);
            this.panelNamePosition.TabIndex = 1;
            // 
            // txbNamePosition
            // 
            this.txbNamePosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNamePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNamePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNamePosition.Location = new System.Drawing.Point(168, 2);
            this.txbNamePosition.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txbNamePosition.Name = "txbNamePosition";
            this.txbNamePosition.Size = new System.Drawing.Size(480, 36);
            this.txbNamePosition.TabIndex = 0;
            // 
            // lblNamePosition
            // 
            this.lblNamePosition.AutoSize = true;
            this.lblNamePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePosition.Location = new System.Drawing.Point(3, 10);
            this.lblNamePosition.Name = "lblNamePosition";
            this.lblNamePosition.Size = new System.Drawing.Size(129, 25);
            this.lblNamePosition.TabIndex = 0;
            this.lblNamePosition.Text = "Tên Chức Vụ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblTitle.Location = new System.Drawing.Point(287, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm Chức Vụ Mới";
            // 
            // panelIdPosition
            // 
            this.panelIdPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIdPosition.Controls.Add(this.txbIdPosition);
            this.panelIdPosition.Controls.Add(this.lblIdPosition);
            this.panelIdPosition.Location = new System.Drawing.Point(125, 77);
            this.panelIdPosition.Name = "panelIdPosition";
            this.panelIdPosition.Size = new System.Drawing.Size(651, 49);
            this.panelIdPosition.TabIndex = 0;
            // 
            // txbIdPosition
            // 
            this.txbIdPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIdPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIdPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdPosition.Location = new System.Drawing.Point(168, 8);
            this.txbIdPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbIdPosition.Name = "txbIdPosition";
            this.txbIdPosition.ReadOnly = true;
            this.txbIdPosition.Size = new System.Drawing.Size(480, 29);
            this.txbIdPosition.TabIndex = 2;
            // 
            // lblIdPosition
            // 
            this.lblIdPosition.AutoSize = true;
            this.lblIdPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPosition.Location = new System.Drawing.Point(3, 12);
            this.lblIdPosition.Name = "lblIdPosition";
            this.lblIdPosition.Size = new System.Drawing.Size(122, 25);
            this.lblIdPosition.TabIndex = 0;
            this.lblIdPosition.Text = "Mã Chức Vụ";
            // 
            // frmAddPosition
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(910, 570);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPosition";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPosition";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.panelNamePosition.ResumeLayout(false);
            this.panelNamePosition.PerformLayout();
            this.panelIdPosition.ResumeLayout(false);
            this.panelIdPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelNamePosition;
        private System.Windows.Forms.TextBox txbNamePosition;
        private System.Windows.Forms.Label lblNamePosition;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelIdPosition;
        private System.Windows.Forms.TextBox txbIdPosition;
        private System.Windows.Forms.Label lblIdPosition;
    }
}