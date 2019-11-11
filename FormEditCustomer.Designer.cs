namespace wirginmediacw2
{
    partial class FormEditCustomer
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
            this.lstcustomers = new System.Windows.Forms.ListBox();
            this.btnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstcustomers
            // 
            this.lstcustomers.FormattingEnabled = true;
            this.lstcustomers.Location = new System.Drawing.Point(43, 48);
            this.lstcustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstcustomers.Name = "lstcustomers";
            this.lstcustomers.Size = new System.Drawing.Size(564, 199);
            this.lstcustomers.TabIndex = 0;
            this.lstcustomers.Click += new System.EventHandler(this.lstcustomers_Click);
            this.lstcustomers.SelectedIndexChanged += new System.EventHandler(this.lstcustomers_SelectedIndexChanged);
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Red;
            this.btnback.Location = new System.Drawing.Point(661, 57);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(128, 58);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "🔙";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Click on a customer to edit";
            // 
            // FormEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lstcustomers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEditCustomer";
            this.Text = "FormEditCustomer";
            this.Load += new System.EventHandler(this.FormEditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstcustomers;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label1;
    }
}