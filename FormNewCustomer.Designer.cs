namespace wirginmediacw2
{
    partial class FormNewCustomer
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txtsur = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtpostcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumserv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listCustomerServices = new System.Windows.Forms.ListBox();
            this.listAllServices = new System.Windows.Forms.ListBox();
            this.btnAddToCustomer = new System.Windows.Forms.Button();
            this.btnRemoveFromCustomer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(228, 33);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(143, 24);
            this.txtID.TabIndex = 0;
            // 
            // txtfn
            // 
            this.txtfn.Location = new System.Drawing.Point(228, 80);
            this.txtfn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(143, 24);
            this.txtfn.TabIndex = 1;
            // 
            // txtsur
            // 
            this.txtsur.Location = new System.Drawing.Point(228, 135);
            this.txtsur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsur.Name = "txtsur";
            this.txtsur.Size = new System.Drawing.Size(143, 24);
            this.txtsur.TabIndex = 2;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(228, 191);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(143, 24);
            this.txtaddress.TabIndex = 3;
            // 
            // txtpostcode
            // 
            this.txtpostcode.Location = new System.Drawing.Point(228, 242);
            this.txtpostcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpostcode.Name = "txtpostcode";
            this.txtpostcode.Size = new System.Drawing.Size(143, 24);
            this.txtpostcode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(41, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(41, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(41, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Postcode:";
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Red;
            this.btnsave.Location = new System.Drawing.Point(660, 178);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(135, 52);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save Customer";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnreset
            // 
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.Red;
            this.btnreset.Location = new System.Drawing.Point(660, 99);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(135, 52);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "Reset Form";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Red;
            this.btnback.Location = new System.Drawing.Point(660, 14);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(135, 52);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "🔙";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(42, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of services:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(8, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Services:";
            // 
            // txtnumserv
            // 
            this.txtnumserv.Location = new System.Drawing.Point(228, 288);
            this.txtnumserv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnumserv.Name = "txtnumserv";
            this.txtnumserv.Size = new System.Drawing.Size(143, 24);
            this.txtnumserv.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnumserv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpostcode);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtsur);
            this.groupBox1.Controls.Add(this.txtfn);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(61, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(455, 373);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please insert new customer details";
            // 
            // listCustomerServices
            // 
            this.listCustomerServices.FormattingEnabled = true;
            this.listCustomerServices.Location = new System.Drawing.Point(5, 381);
            this.listCustomerServices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listCustomerServices.Name = "listCustomerServices";
            this.listCustomerServices.Size = new System.Drawing.Size(470, 147);
            this.listCustomerServices.TabIndex = 18;
            this.listCustomerServices.SelectedIndexChanged += new System.EventHandler(this.listCustomerServices_SelectedIndexChanged);
            // 
            // listAllServices
            // 
            this.listAllServices.FormattingEnabled = true;
            this.listAllServices.Location = new System.Drawing.Point(520, 380);
            this.listAllServices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listAllServices.Name = "listAllServices";
            this.listAllServices.Size = new System.Drawing.Size(459, 147);
            this.listAllServices.TabIndex = 19;
            // 
            // btnAddToCustomer
            // 
            this.btnAddToCustomer.Location = new System.Drawing.Point(478, 380);
            this.btnAddToCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddToCustomer.Name = "btnAddToCustomer";
            this.btnAddToCustomer.Size = new System.Drawing.Size(38, 33);
            this.btnAddToCustomer.TabIndex = 20;
            this.btnAddToCustomer.Text = "<";
            this.btnAddToCustomer.UseVisualStyleBackColor = true;
            this.btnAddToCustomer.Click += new System.EventHandler(this.btnAddToCustomer_Click);
            // 
            // btnRemoveFromCustomer
            // 
            this.btnRemoveFromCustomer.Location = new System.Drawing.Point(478, 418);
            this.btnRemoveFromCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveFromCustomer.Name = "btnRemoveFromCustomer";
            this.btnRemoveFromCustomer.Size = new System.Drawing.Size(38, 33);
            this.btnRemoveFromCustomer.TabIndex = 21;
            this.btnRemoveFromCustomer.Text = ">";
            this.btnRemoveFromCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveFromCustomer.Click += new System.EventHandler(this.btnRemoveFromCustomer_Click);
            // 
            // FormNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 673);
            this.Controls.Add(this.btnRemoveFromCustomer);
            this.Controls.Add(this.btnAddToCustomer);
            this.Controls.Add(this.listAllServices);
            this.Controls.Add(this.listCustomerServices);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsave);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNewCustomer";
            this.Load += new System.EventHandler(this.FormNewCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.TextBox txtsur;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtpostcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnumserv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listCustomerServices;
        private System.Windows.Forms.ListBox listAllServices;
        private System.Windows.Forms.Button btnAddToCustomer;
        private System.Windows.Forms.Button btnRemoveFromCustomer;
    }
}