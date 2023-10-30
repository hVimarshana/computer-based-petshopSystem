
namespace PetShopManagement_ICTProject_
{
    partial class StaffRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.dgv_Regstration = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStaffRegistrationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSet = new PetShopManagement_ICTProject_.staffDataSet();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UsernameID = new System.Windows.Forms.TextBox();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_MobileNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.tblStaffRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addStaff = new PetShopManagement_ICTProject_.AddStaff();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Billing = new System.Windows.Forms.Button();
            this.btn_DogsCat = new System.Windows.Forms.Button();
            this.btn_StaffReg = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblStaffRegistrationTableAdapter = new PetShopManagement_ICTProject_.AddStaffTableAdapters.TblStaffRegistrationTableAdapter();
            this.tblStaffRegistrationTableAdapter1 = new PetShopManagement_ICTProject_.staffDataSetTableAdapters.TblStaffRegistrationTableAdapter();
            this.btn_Product = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Regstration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffRegistrationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.dgv_Regstration);
            this.panel1.Controls.Add(this.btn_Register);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_UsernameID);
            this.panel1.Controls.Add(this.cmb_Designation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_Gender);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_MobileNumber);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_NIC);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_LastName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_FirstName);
            this.panel1.Location = new System.Drawing.Point(294, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 590);
            this.panel1.TabIndex = 8;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_new.Location = new System.Drawing.Point(12, 306);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(130, 41);
            this.btn_new.TabIndex = 38;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Delete.Location = new System.Drawing.Point(420, 306);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 41);
            this.btn_Delete.TabIndex = 37;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Edit.Location = new System.Drawing.Point(284, 306);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(130, 41);
            this.btn_Edit.TabIndex = 36;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // dgv_Regstration
            // 
            this.dgv_Regstration.AutoGenerateColumns = false;
            this.dgv_Regstration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Regstration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.nICDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgv_Regstration.DataSource = this.tblStaffRegistrationBindingSource1;
            this.dgv_Regstration.Location = new System.Drawing.Point(3, 353);
            this.dgv_Regstration.Name = "dgv_Regstration";
            this.dgv_Regstration.ReadOnly = true;
            this.dgv_Regstration.RowHeadersWidth = 51;
            this.dgv_Regstration.RowTemplate.Height = 24;
            this.dgv_Regstration.Size = new System.Drawing.Size(1180, 237);
            this.dgv_Regstration.TabIndex = 35;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // nICDataGridViewTextBoxColumn
            // 
            this.nICDataGridViewTextBoxColumn.DataPropertyName = "NIC";
            this.nICDataGridViewTextBoxColumn.HeaderText = "NIC";
            this.nICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nICDataGridViewTextBoxColumn.Name = "nICDataGridViewTextBoxColumn";
            this.nICDataGridViewTextBoxColumn.ReadOnly = true;
            this.nICDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            this.mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblStaffRegistrationBindingSource1
            // 
            this.tblStaffRegistrationBindingSource1.DataMember = "TblStaffRegistration";
            this.tblStaffRegistrationBindingSource1.DataSource = this.staffDataSet;
            // 
            // staffDataSet
            // 
            this.staffDataSet.DataSetName = "staffDataSet";
            this.staffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Register.Location = new System.Drawing.Point(148, 306);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(130, 41);
            this.btn_Register.TabIndex = 34;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(564, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Password
            // 
            this.txt_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStaffRegistrationBindingSource1, "Password", true));
            this.txt_Password.Location = new System.Drawing.Point(687, 243);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(277, 22);
            this.txt_Password.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(530, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Username ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_UsernameID
            // 
            this.txt_UsernameID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStaffRegistrationBindingSource1, "UserName", true));
            this.txt_UsernameID.Location = new System.Drawing.Point(687, 186);
            this.txt_UsernameID.Name = "txt_UsernameID";
            this.txt_UsernameID.Size = new System.Drawing.Size(277, 22);
            this.txt_UsernameID.TabIndex = 30;
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblStaffRegistrationBindingSource1, "UserType", true));
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cmb_Designation.Location = new System.Drawing.Point(132, 248);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(130, 24);
            this.cmb_Designation.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Usertype";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblStaffRegistrationBindingSource1, "Gender", true));
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_Gender.Location = new System.Drawing.Point(364, 249);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(126, 24);
            this.cmb_Gender.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(517, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Mobile number";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_MobileNumber
            // 
            this.txt_MobileNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStaffRegistrationBindingSource1, "MobileNumber", true));
            this.txt_MobileNumber.Location = new System.Drawing.Point(687, 94);
            this.txt_MobileNumber.Name = "txt_MobileNumber";
            this.txt_MobileNumber.Size = new System.Drawing.Size(277, 22);
            this.txt_MobileNumber.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(617, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "NIC";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_NIC
            // 
            this.txt_NIC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStaffRegistrationBindingSource1, "NIC", true));
            this.txt_NIC.Location = new System.Drawing.Point(687, 43);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(277, 22);
            this.txt_NIC.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(27, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Address";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Address
            // 
            this.txt_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStaffRegistrationBindingSource1, "Address", true));
            this.txt_Address.Location = new System.Drawing.Point(132, 133);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(351, 92);
            this.txt_Address.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(274, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gender";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(8, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Last name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_LastName
            // 
            this.txt_LastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStaffRegistrationBindingSource1, "LastName", true));
            this.txt_LastName.Location = new System.Drawing.Point(132, 78);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(352, 22);
            this.txt_LastName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "First name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStaffRegistrationBindingSource1, "FirstName", true));
            this.txt_FirstName.Location = new System.Drawing.Point(132, 32);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(351, 22);
            this.txt_FirstName.TabIndex = 15;
            // 
            // tblStaffRegistrationBindingSource
            // 
            this.tblStaffRegistrationBindingSource.DataMember = "TblStaffRegistration";
            this.tblStaffRegistrationBindingSource.DataSource = this.addStaff;
            // 
            // addStaff
            // 
            this.addStaff.DataSetName = "AddStaff";
            this.addStaff.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btn_Logout.Location = new System.Drawing.Point(3, 547);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(287, 55);
            this.btn_Logout.TabIndex = 26;
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
            this.btn_Billing.Location = new System.Drawing.Point(3, 470);
            this.btn_Billing.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Billing.Name = "btn_Billing";
            this.btn_Billing.Size = new System.Drawing.Size(287, 55);
            this.btn_Billing.TabIndex = 25;
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
            this.btn_DogsCat.Location = new System.Drawing.Point(3, 351);
            this.btn_DogsCat.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.btn_DogsCat.Name = "btn_DogsCat";
            this.btn_DogsCat.Size = new System.Drawing.Size(287, 55);
            this.btn_DogsCat.TabIndex = 24;
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
            this.btn_StaffReg.Location = new System.Drawing.Point(3, 293);
            this.btn_StaffReg.Margin = new System.Windows.Forms.Padding(0);
            this.btn_StaffReg.Name = "btn_StaffReg";
            this.btn_StaffReg.Size = new System.Drawing.Size(287, 55);
            this.btn_StaffReg.TabIndex = 23;
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
            this.btn_Dashboard.Location = new System.Drawing.Point(3, 235);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(287, 55);
            this.btn_Dashboard.TabIndex = 22;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "PUPPY PET SHOP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(99, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // tblStaffRegistrationTableAdapter
            // 
            this.tblStaffRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // tblStaffRegistrationTableAdapter1
            // 
            this.tblStaffRegistrationTableAdapter1.ClearBeforeFill = true;
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
            this.btn_Product.Location = new System.Drawing.Point(3, 412);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(287, 55);
            this.btn_Product.TabIndex = 27;
            this.btn_Product.Text = "Products";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // StaffRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1492, 614);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Billing);
            this.Controls.Add(this.btn_DogsCat);
            this.Controls.Add(this.btn_StaffReg);
            this.Controls.Add(this.btn_Dashboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StaffRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Regstration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffRegistrationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridView dgv_Regstration;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UsernameID;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_MobileNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Billing;
        private System.Windows.Forms.Button btn_DogsCat;
        private System.Windows.Forms.Button btn_StaffReg;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AddStaff addStaff;
        private System.Windows.Forms.BindingSource tblStaffRegistrationBindingSource;
        private AddStaffTableAdapters.TblStaffRegistrationTableAdapter tblStaffRegistrationTableAdapter;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private staffDataSet staffDataSet;
        private System.Windows.Forms.BindingSource tblStaffRegistrationBindingSource1;
        private staffDataSetTableAdapters.TblStaffRegistrationTableAdapter tblStaffRegistrationTableAdapter1;
        private System.Windows.Forms.Button btn_Product;
    }
}

