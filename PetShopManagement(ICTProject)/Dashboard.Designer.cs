
namespace PetShopManagement_ICTProject_
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Billing = new System.Windows.Forms.Button();
            this.btn_DogsCat = new System.Windows.Forms.Button();
            this.btn_StaffReg = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Log = new System.Windows.Forms.Label();
            this.btn_Product = new System.Windows.Forms.Button();
            this.DemandChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblBill = new PetShopManagement_ICTProject_.TblBill();
            this.tblBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBillTableAdapter = new PetShopManagement_ICTProject_.TblBillTableAdapters.TblBillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DemandChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(2, 538);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(287, 55);
            this.btn_Logout.TabIndex = 18;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Billing
            // 
            this.btn_Billing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_Billing.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Billing.FlatAppearance.BorderSize = 0;
            this.btn_Billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Billing.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Billing.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Billing.Image = ((System.Drawing.Image)(resources.GetObject("btn_Billing.Image")));
            this.btn_Billing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Billing.Location = new System.Drawing.Point(2, 450);
            this.btn_Billing.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Billing.Name = "btn_Billing";
            this.btn_Billing.Size = new System.Drawing.Size(287, 55);
            this.btn_Billing.TabIndex = 17;
            this.btn_Billing.Text = "Billing";
            this.btn_Billing.UseVisualStyleBackColor = false;
            this.btn_Billing.Click += new System.EventHandler(this.btn_Billing_Click);
            // 
            // btn_DogsCat
            // 
            this.btn_DogsCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_DogsCat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_DogsCat.FlatAppearance.BorderSize = 0;
            this.btn_DogsCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DogsCat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DogsCat.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_DogsCat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DogsCat.Image")));
            this.btn_DogsCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DogsCat.Location = new System.Drawing.Point(2, 331);
            this.btn_DogsCat.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.btn_DogsCat.Name = "btn_DogsCat";
            this.btn_DogsCat.Size = new System.Drawing.Size(287, 55);
            this.btn_DogsCat.TabIndex = 16;
            this.btn_DogsCat.Text = "Dogs catergories";
            this.btn_DogsCat.UseVisualStyleBackColor = false;
            this.btn_DogsCat.Click += new System.EventHandler(this.btn_DogsCat_Click);
            // 
            // btn_StaffReg
            // 
            this.btn_StaffReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_StaffReg.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_StaffReg.FlatAppearance.BorderSize = 0;
            this.btn_StaffReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StaffReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StaffReg.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_StaffReg.Image = ((System.Drawing.Image)(resources.GetObject("btn_StaffReg.Image")));
            this.btn_StaffReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StaffReg.Location = new System.Drawing.Point(2, 273);
            this.btn_StaffReg.Margin = new System.Windows.Forms.Padding(0);
            this.btn_StaffReg.Name = "btn_StaffReg";
            this.btn_StaffReg.Size = new System.Drawing.Size(287, 55);
            this.btn_StaffReg.TabIndex = 15;
            this.btn_StaffReg.Text = "Staff registration";
            this.btn_StaffReg.UseVisualStyleBackColor = false;
            this.btn_StaffReg.Click += new System.EventHandler(this.btn_StaffReg_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(2, 215);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(287, 55);
            this.btn_Dashboard.TabIndex = 14;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "PUPPY PET SHOP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(90, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.DemandChart);
            this.panel1.Controls.Add(this.lbl_Log);
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(293, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 594);
            this.panel1.TabIndex = 19;
            // 
            // lbl_Log
            // 
            this.lbl_Log.AutoSize = true;
            this.lbl_Log.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log.Location = new System.Drawing.Point(421, 36);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(0, 35);
            this.lbl_Log.TabIndex = 0;
            this.lbl_Log.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_Product.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Product.FlatAppearance.BorderSize = 0;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Product.Image = ((System.Drawing.Image)(resources.GetObject("btn_Product.Image")));
            this.btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.Location = new System.Drawing.Point(2, 392);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(287, 55);
            this.btn_Product.TabIndex = 20;
            this.btn_Product.Text = "Products";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // DemandChart
            // 
            chartArea2.Name = "ChartArea1";
            this.DemandChart.ChartAreas.Add(chartArea2);
            this.DemandChart.DataSource = this.tblBillBindingSource;
            legend2.Name = "Legend1";
            this.DemandChart.Legends.Add(legend2);
            this.DemandChart.Location = new System.Drawing.Point(114, 131);
            this.DemandChart.Name = "DemandChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "OrderName";
            series2.YValueMembers = "Quantity";
            this.DemandChart.Series.Add(series2);
            this.DemandChart.Size = new System.Drawing.Size(759, 435);
            this.DemandChart.TabIndex = 1;
            this.DemandChart.Text = "chart1";
            // 
            // tblBill
            // 
            this.tblBill.DataSetName = "TblBill";
            this.tblBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBillBindingSource
            // 
            this.tblBillBindingSource.DataMember = "TblBill";
            this.tblBillBindingSource.DataSource = this.tblBill;
            // 
            // tblBillTableAdapter
            // 
            this.tblBillTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1255, 618);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Billing);
            this.Controls.Add(this.btn_DogsCat);
            this.Controls.Add(this.btn_StaffReg);
            this.Controls.Add(this.btn_Dashboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DemandChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Billing;
        private System.Windows.Forms.Button btn_DogsCat;
        private System.Windows.Forms.Button btn_StaffReg;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Log;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.DataVisualization.Charting.Chart DemandChart;
        private TblBill tblBill;
        private System.Windows.Forms.BindingSource tblBillBindingSource;
        private TblBillTableAdapters.TblBillTableAdapter tblBillTableAdapter;
    }
}