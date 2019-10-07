namespace MyLibrary.WebForms
{
    partial class TraceUI
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
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.dtpTake = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.btnAdded = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwBooks.Location = new System.Drawing.Point(398, 0);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowHeadersWidth = 51;
            this.dgwBooks.RowTemplate.Height = 24;
            this.dgwBooks.Size = new System.Drawing.Size(877, 612);
            this.dgwBooks.TabIndex = 12;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBooks_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email :";
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(79, 61);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(287, 24);
            this.cbxUser.TabIndex = 16;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(12, 551);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 18;
            this.txtBookID.Visible = false;
            // 
            // dtpTake
            // 
            this.dtpTake.Location = new System.Drawing.Point(157, 124);
            this.dtpTake.Name = "dtpTake";
            this.dtpTake.Size = new System.Drawing.Size(209, 22);
            this.dtpTake.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Veriliş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Alış Tarihi :";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Location = new System.Drawing.Point(157, 171);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(209, 22);
            this.dtpReturn.TabIndex = 22;
            // 
            // btnAdded
            // 
            this.btnAdded.FlatAppearance.BorderSize = 0;
            this.btnAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdded.Location = new System.Drawing.Point(16, 231);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(350, 45);
            this.btnAdded.TabIndex = 23;
            this.btnAdded.Text = "KİTAP KİRALA";
            this.btnAdded.UseVisualStyleBackColor = true;
            this.btnAdded.Click += new System.EventHandler(this.BtnAdded_Click);
            // 
            // TraceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 612);
            this.Controls.Add(this.btnAdded);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTake);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.dgwBooks);
            this.Name = "TraceUI";
            this.Text = "TraceUI";
            this.Load += new System.EventHandler(this.TraceUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.DateTimePicker dtpTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Button btnAdded;
    }
}