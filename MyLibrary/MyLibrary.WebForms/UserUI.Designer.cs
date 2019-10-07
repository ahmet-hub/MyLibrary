namespace MyLibrary.WebForms
{
    partial class UserUI
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
            this.dgwUser = new System.Windows.Forms.DataGridView();
            this.txtGetId = new System.Windows.Forms.TextBox();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdded = new System.Windows.Forms.Button();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUser
            // 
            this.dgwUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwUser.Location = new System.Drawing.Point(382, 0);
            this.dgwUser.Name = "dgwUser";
            this.dgwUser.RowHeadersWidth = 51;
            this.dgwUser.RowTemplate.Height = 24;
            this.dgwUser.Size = new System.Drawing.Size(893, 612);
            this.dgwUser.TabIndex = 12;
            this.dgwUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwUser_CellClick);
            // 
            // txtGetId
            // 
            this.txtGetId.Location = new System.Drawing.Point(19, 564);
            this.txtGetId.Name = "txtGetId";
            this.txtGetId.Size = new System.Drawing.Size(30, 22);
            this.txtGetId.TabIndex = 33;
            this.txtGetId.Visible = false;
            // 
            // btnDeleted
            // 
            this.btnDeleted.FlatAppearance.BorderSize = 0;
            this.btnDeleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleted.Location = new System.Drawing.Point(25, 461);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(325, 45);
            this.btnDeleted.TabIndex = 32;
            this.btnDeleted.Text = "SİL";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.BtnDeleted_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Adı :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(24, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(325, 45);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdded
            // 
            this.btnAdded.FlatAppearance.BorderSize = 0;
            this.btnAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdded.Location = new System.Drawing.Point(23, 339);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(327, 45);
            this.btnAdded.TabIndex = 25;
            this.btnAdded.Text = "Ekle";
            this.btnAdded.UseVisualStyleBackColor = true;
            this.btnAdded.Click += new System.EventHandler(this.BtnAdded_Click);
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.Location = new System.Drawing.Point(149, 71);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(200, 22);
            this.txtUserLastName.TabIndex = 21;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(149, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 22);
            this.txtUserName.TabIndex = 20;
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(150, 109);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(200, 22);
            this.txtUserMail.TabIndex = 34;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(150, 151);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 35;
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 612);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtUserMail);
            this.Controls.Add(this.txtGetId);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdded);
            this.Controls.Add(this.txtUserLastName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.dgwUser);
            this.Name = "UserUI";
            this.Text = "UserUI";
            this.Load += new System.EventHandler(this.UserUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUser;
        private System.Windows.Forms.TextBox txtGetId;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdded;
        private System.Windows.Forms.TextBox txtUserLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.TextBox txtPhone;
    }
}