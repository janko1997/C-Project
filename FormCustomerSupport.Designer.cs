namespace wirginmediacw2
{
    partial class FormCustomerSupport
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
            this.listCustomersForUpgrade = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpostcode = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtsur = new System.Windows.Forms.TextBox();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.listCustomerServices = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textServiceDesc = new System.Windows.Forms.TextBox();
            this.textServiceId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textServiceDateStart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textServiceLastContact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textServiceNotes = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCustomersForUpgrade
            // 
            this.listCustomersForUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listCustomersForUpgrade.FormattingEnabled = true;
            this.listCustomersForUpgrade.Location = new System.Drawing.Point(9, 10);
            this.listCustomersForUpgrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listCustomersForUpgrade.Name = "listCustomersForUpgrade";
            this.listCustomersForUpgrade.Size = new System.Drawing.Size(344, 498);
            this.listCustomersForUpgrade.TabIndex = 0;
            this.listCustomersForUpgrade.Click += new System.EventHandler(this.listBox1_Click);
            this.listCustomersForUpgrade.SelectedIndexChanged += new System.EventHandler(this.listCustomersForUpgrade_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(364, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Postcode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(364, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(364, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(364, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(364, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Number:";
            // 
            // txtpostcode
            // 
            this.txtpostcode.ForeColor = System.Drawing.Color.Red;
            this.txtpostcode.Location = new System.Drawing.Point(470, 107);
            this.txtpostcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpostcode.Name = "txtpostcode";
            this.txtpostcode.ReadOnly = true;
            this.txtpostcode.Size = new System.Drawing.Size(143, 20);
            this.txtpostcode.TabIndex = 14;
            // 
            // txtaddress
            // 
            this.txtaddress.ForeColor = System.Drawing.Color.Red;
            this.txtaddress.Location = new System.Drawing.Point(470, 84);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(143, 20);
            this.txtaddress.TabIndex = 13;
            // 
            // txtsur
            // 
            this.txtsur.ForeColor = System.Drawing.Color.Red;
            this.txtsur.Location = new System.Drawing.Point(470, 62);
            this.txtsur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsur.Name = "txtsur";
            this.txtsur.ReadOnly = true;
            this.txtsur.Size = new System.Drawing.Size(143, 20);
            this.txtsur.TabIndex = 12;
            // 
            // txtfn
            // 
            this.txtfn.ForeColor = System.Drawing.Color.Red;
            this.txtfn.Location = new System.Drawing.Point(470, 39);
            this.txtfn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfn.Name = "txtfn";
            this.txtfn.ReadOnly = true;
            this.txtfn.Size = new System.Drawing.Size(143, 20);
            this.txtfn.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.Color.Red;
            this.txtID.Location = new System.Drawing.Point(470, 16);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(143, 20);
            this.txtID.TabIndex = 10;
            // 
            // listCustomerServices
            // 
            this.listCustomerServices.FormattingEnabled = true;
            this.listCustomerServices.Location = new System.Drawing.Point(616, 10);
            this.listCustomerServices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listCustomerServices.Name = "listCustomerServices";
            this.listCustomerServices.Size = new System.Drawing.Size(312, 160);
            this.listCustomerServices.TabIndex = 20;
            this.listCustomerServices.Click += new System.EventHandler(this.listCustomerServices_Click);
            this.listCustomerServices.SelectedIndexChanged += new System.EventHandler(this.listCustomerServices_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(614, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Discription:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(614, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "IDnumber:";
            // 
            // textServiceDesc
            // 
            this.textServiceDesc.ForeColor = System.Drawing.Color.Red;
            this.textServiceDesc.Location = new System.Drawing.Point(745, 211);
            this.textServiceDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textServiceDesc.Name = "textServiceDesc";
            this.textServiceDesc.ReadOnly = true;
            this.textServiceDesc.Size = new System.Drawing.Size(156, 20);
            this.textServiceDesc.TabIndex = 22;
            // 
            // textServiceId
            // 
            this.textServiceId.ForeColor = System.Drawing.Color.Red;
            this.textServiceId.Location = new System.Drawing.Point(745, 188);
            this.textServiceId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textServiceId.Name = "textServiceId";
            this.textServiceId.ReadOnly = true;
            this.textServiceId.Size = new System.Drawing.Size(156, 20);
            this.textServiceId.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(614, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Date started:";
            // 
            // textServiceDateStart
            // 
            this.textServiceDateStart.ForeColor = System.Drawing.Color.Red;
            this.textServiceDateStart.Location = new System.Drawing.Point(745, 234);
            this.textServiceDateStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textServiceDateStart.Name = "textServiceDateStart";
            this.textServiceDateStart.ReadOnly = true;
            this.textServiceDateStart.Size = new System.Drawing.Size(156, 20);
            this.textServiceDateStart.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(614, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Last contacted:";
            // 
            // textServiceLastContact
            // 
            this.textServiceLastContact.ForeColor = System.Drawing.Color.Red;
            this.textServiceLastContact.Location = new System.Drawing.Point(745, 257);
            this.textServiceLastContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textServiceLastContact.Name = "textServiceLastContact";
            this.textServiceLastContact.ReadOnly = true;
            this.textServiceLastContact.Size = new System.Drawing.Size(156, 20);
            this.textServiceLastContact.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(614, 277);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Notes:";
            // 
            // textServiceNotes
            // 
            this.textServiceNotes.Location = new System.Drawing.Point(617, 299);
            this.textServiceNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textServiceNotes.Multiline = true;
            this.textServiceNotes.Name = "textServiceNotes";
            this.textServiceNotes.Size = new System.Drawing.Size(275, 66);
            this.textServiceNotes.TabIndex = 29;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Location = new System.Drawing.Point(782, 369);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 43);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Red;
            this.btnback.Location = new System.Drawing.Point(617, 369);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(121, 43);
            this.btnback.TabIndex = 34;
            this.btnback.Text = "🔙";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FormCustomerSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 528);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textServiceNotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textServiceLastContact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textServiceDateStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textServiceDesc);
            this.Controls.Add(this.textServiceId);
            this.Controls.Add(this.listCustomerServices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpostcode);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtsur);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.listCustomersForUpgrade);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCustomerSupport";
            this.Text = "FormCustomerSupport";
            this.Load += new System.EventHandler(this.FormCustomerSupport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCustomersForUpgrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpostcode;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtsur;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ListBox listCustomerServices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textServiceDesc;
        private System.Windows.Forms.TextBox textServiceId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textServiceDateStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textServiceLastContact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textServiceNotes;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnback;
    }
}