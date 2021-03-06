namespace EntityFramework_Queries
{
    partial class btnSelectVendorCA
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
            this.btnSelectAllVendors = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSelectVendNameCityState = new System.Windows.Forms.Button();
            this.btnMiscQueries = new System.Windows.Forms.Button();
            this.btnVendorsAndInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            this.btnSelectAllVendors.Location = new System.Drawing.Point(75, 52);
            this.btnSelectAllVendors.Name = "btnSelectAllVendors";
            this.btnSelectAllVendors.Size = new System.Drawing.Size(175, 29);
            this.btnSelectAllVendors.TabIndex = 0;
            this.btnSelectAllVendors.Text = "Select * FROM Vendors";
            this.btnSelectAllVendors.UseVisualStyleBackColor = true;
            this.btnSelectAllVendors.Click += new System.EventHandler(this.btnSelectAllVendors_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Select all CA Vendors";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSelectVendNameCityState
            // 
            this.btnSelectVendNameCityState.Location = new System.Drawing.Point(75, 165);
            this.btnSelectVendNameCityState.Name = "btnSelectVendNameCityState";
            this.btnSelectVendNameCityState.Size = new System.Drawing.Size(241, 29);
            this.btnSelectVendNameCityState.TabIndex = 2;
            this.btnSelectVendNameCityState.Text = "Select Vendor Name, City, State ";
            this.btnSelectVendNameCityState.UseVisualStyleBackColor = true;
            this.btnSelectVendNameCityState.Click += new System.EventHandler(this.btnSelectVendNameCityState_Click);
            // 
            // btnMiscQueries
            // 
            this.btnMiscQueries.Location = new System.Drawing.Point(75, 217);
            this.btnMiscQueries.Name = "btnMiscQueries";
            this.btnMiscQueries.Size = new System.Drawing.Size(175, 29);
            this.btnMiscQueries.TabIndex = 3;
            this.btnMiscQueries.Text = "Misc Queries";
            this.btnMiscQueries.UseVisualStyleBackColor = true;
            this.btnMiscQueries.Click += new System.EventHandler(this.btnMiscQueries_Click);
            // 
            // btnVendorsAndInvoices
            // 
            this.btnVendorsAndInvoices.Location = new System.Drawing.Point(75, 272);
            this.btnVendorsAndInvoices.Name = "btnVendorsAndInvoices";
            this.btnVendorsAndInvoices.Size = new System.Drawing.Size(201, 29);
            this.btnVendorsAndInvoices.TabIndex = 4;
            this.btnVendorsAndInvoices.Text = "Select * vendors w/invoices";
            this.btnVendorsAndInvoices.UseVisualStyleBackColor = true;
            this.btnVendorsAndInvoices.Click += new System.EventHandler(this.btnVendorsAndInvoices_Click);
            // 
            // btnSelectVendorCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVendorsAndInvoices);
            this.Controls.Add(this.btnMiscQueries);
            this.Controls.Add(this.btnSelectVendNameCityState);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSelectAllVendors);
            this.Name = "btnSelectVendorCA";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectAllVendors;
        private Button button2;
        private Button btnSelectVendNameCityState;
        private Button btnMiscQueries;
        private Button btnVendorsAndInvoices;
    }
}