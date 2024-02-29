
namespace OneClick
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainControl = new System.Windows.Forms.TabControl();
            this.tpUniversalID = new System.Windows.Forms.TabPage();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.gbTemplate = new System.Windows.Forms.GroupBox();
            this.rbUniversalID = new System.Windows.Forms.RadioButton();
            this.rbDomainPwdReset = new System.Windows.Forms.RadioButton();
            this.rbBitLocker = new System.Windows.Forms.RadioButton();
            this.rbMainFrame = new System.Windows.Forms.RadioButton();
            this.btnComposeEmail = new System.Windows.Forms.Button();
            this.txtTicketNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTicketNumber = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.tpStrikeEmail = new System.Windows.Forms.TabPage();
            this.gbStrikeEmail = new System.Windows.Forms.GroupBox();
            this.rbStrike1 = new System.Windows.Forms.RadioButton();
            this.rbStrike2 = new System.Windows.Forms.RadioButton();
            this.rbStrike3 = new System.Windows.Forms.RadioButton();
            this.SEbtnCompose = new System.Windows.Forms.Button();
            this.SEtxtIssue = new System.Windows.Forms.TextBox();
            this.SEtxtTicket = new System.Windows.Forms.TextBox();
            this.SEtxtEmployeeName = new System.Windows.Forms.TextBox();
            this.SEtxtCC = new System.Windows.Forms.TextBox();
            this.SEtxtTo = new System.Windows.Forms.TextBox();
            this.SElblIssue = new System.Windows.Forms.Label();
            this.SElblTicket = new System.Windows.Forms.Label();
            this.SElblEmployee = new System.Windows.Forms.Label();
            this.SElblCC = new System.Windows.Forms.Label();
            this.SElblTo = new System.Windows.Forms.Label();
            this.tpCSC = new System.Windows.Forms.TabPage();
            this.txtCSCManager = new System.Windows.Forms.TextBox();
            this.lblCSCManager = new System.Windows.Forms.Label();
            this.btnCSCCompose = new System.Windows.Forms.Button();
            this.txtCSCPassword = new System.Windows.Forms.TextBox();
            this.txtCSCName = new System.Windows.Forms.TextBox();
            this.txtCSCCC = new System.Windows.Forms.TextBox();
            this.txtCSCTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCscPwdReset = new System.Windows.Forms.RadioButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainControl.SuspendLayout();
            this.tpUniversalID.SuspendLayout();
            this.gbTemplate.SuspendLayout();
            this.tpStrikeEmail.SuspendLayout();
            this.gbStrikeEmail.SuspendLayout();
            this.tpCSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.tpUniversalID);
            this.MainControl.Controls.Add(this.tpStrikeEmail);
            this.MainControl.Controls.Add(this.tpCSC);
            this.MainControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainControl.Location = new System.Drawing.Point(0, 168);
            this.MainControl.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(819, 600);
            this.MainControl.TabIndex = 0;
            // 
            // tpUniversalID
            // 
            this.tpUniversalID.BackColor = System.Drawing.Color.LightGray;
            this.tpUniversalID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpUniversalID.Controls.Add(this.txtKey);
            this.tpUniversalID.Controls.Add(this.rbDomainPwdReset);
            this.tpUniversalID.Controls.Add(this.gbTemplate);
            this.tpUniversalID.Controls.Add(this.btnComposeEmail);
            this.tpUniversalID.Controls.Add(this.txtTicketNumber);
            this.tpUniversalID.Controls.Add(this.txtEmployeeName);
            this.tpUniversalID.Controls.Add(this.txtManagerName);
            this.tpUniversalID.Controls.Add(this.txtCC);
            this.tpUniversalID.Controls.Add(this.txtTo);
            this.tpUniversalID.Controls.Add(this.lblTicketNumber);
            this.tpUniversalID.Controls.Add(this.lblPassword);
            this.tpUniversalID.Controls.Add(this.lblEmployeeName);
            this.tpUniversalID.Controls.Add(this.lblManagerName);
            this.tpUniversalID.Controls.Add(this.lblCC);
            this.tpUniversalID.Controls.Add(this.lblTo);
            this.tpUniversalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpUniversalID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpUniversalID.Location = new System.Drawing.Point(4, 29);
            this.tpUniversalID.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.tpUniversalID.Name = "tpUniversalID";
            this.tpUniversalID.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.tpUniversalID.Size = new System.Drawing.Size(811, 567);
            this.tpUniversalID.TabIndex = 0;
            this.tpUniversalID.Text = "Universal ID";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(317, 365);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(282, 24);
            this.txtKey.TabIndex = 14;
            // 
            // gbTemplate
            // 
            this.gbTemplate.Controls.Add(this.rbUniversalID);
            this.gbTemplate.Controls.Add(this.rbBitLocker);
            this.gbTemplate.Controls.Add(this.rbMainFrame);
            this.gbTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTemplate.Location = new System.Drawing.Point(9, 7);
            this.gbTemplate.Name = "gbTemplate";
            this.gbTemplate.Size = new System.Drawing.Size(789, 78);
            this.gbTemplate.TabIndex = 17;
            this.gbTemplate.TabStop = false;
            this.gbTemplate.Text = "Choose One";
            // 
            // rbUniversalID
            // 
            this.rbUniversalID.AutoSize = true;
            this.rbUniversalID.Checked = true;
            this.rbUniversalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUniversalID.Location = new System.Drawing.Point(48, 37);
            this.rbUniversalID.Name = "rbUniversalID";
            this.rbUniversalID.Size = new System.Drawing.Size(113, 24);
            this.rbUniversalID.TabIndex = 0;
            this.rbUniversalID.TabStop = true;
            this.rbUniversalID.Text = "Universal ID";
            this.rbUniversalID.UseVisualStyleBackColor = true;
            // 
            // rbDomainPwdReset
            // 
            this.rbDomainPwdReset.AutoSize = true;
            this.rbDomainPwdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDomainPwdReset.Location = new System.Drawing.Point(575, 91);
            this.rbDomainPwdReset.Name = "rbDomainPwdReset";
            this.rbDomainPwdReset.Size = new System.Drawing.Size(202, 24);
            this.rbDomainPwdReset.TabIndex = 1;
            this.rbDomainPwdReset.TabStop = true;
            this.rbDomainPwdReset.Text = "Domain Password Reset";
            this.rbDomainPwdReset.UseVisualStyleBackColor = true;
            this.rbDomainPwdReset.Visible = false;
            // 
            // rbBitLocker
            // 
            this.rbBitLocker.AutoSize = true;
            this.rbBitLocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBitLocker.Location = new System.Drawing.Point(321, 38);
            this.rbBitLocker.Name = "rbBitLocker";
            this.rbBitLocker.Size = new System.Drawing.Size(103, 24);
            this.rbBitLocker.TabIndex = 2;
            this.rbBitLocker.TabStop = true;
            this.rbBitLocker.Text = "Bit-Locker ";
            this.rbBitLocker.UseVisualStyleBackColor = true;
            // 
            // rbMainFrame
            // 
            this.rbMainFrame.AutoSize = true;
            this.rbMainFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMainFrame.Location = new System.Drawing.Point(566, 37);
            this.rbMainFrame.Name = "rbMainFrame";
            this.rbMainFrame.Size = new System.Drawing.Size(107, 24);
            this.rbMainFrame.TabIndex = 3;
            this.rbMainFrame.TabStop = true;
            this.rbMainFrame.Text = "MainFrame";
            this.rbMainFrame.UseVisualStyleBackColor = true;
            // 
            // btnComposeEmail
            // 
            this.btnComposeEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.btnComposeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComposeEmail.Location = new System.Drawing.Point(362, 481);
            this.btnComposeEmail.Name = "btnComposeEmail";
            this.btnComposeEmail.Size = new System.Drawing.Size(170, 45);
            this.btnComposeEmail.TabIndex = 16;
            this.btnComposeEmail.Text = "Compose Email";
            this.btnComposeEmail.UseVisualStyleBackColor = false;
            this.btnComposeEmail.Click += new System.EventHandler(this.btnComposeEmail_Click);
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.Location = new System.Drawing.Point(317, 424);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.Size = new System.Drawing.Size(283, 24);
            this.txtTicketNumber.TabIndex = 15;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(317, 308);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(283, 24);
            this.txtEmployeeName.TabIndex = 13;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(317, 250);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(283, 24);
            this.txtManagerName.TabIndex = 12;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(316, 195);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(283, 24);
            this.txtCC.TabIndex = 11;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(316, 136);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(283, 24);
            this.txtTo.TabIndex = 10;
            // 
            // lblTicketNumber
            // 
            this.lblTicketNumber.AutoSize = true;
            this.lblTicketNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNumber.Location = new System.Drawing.Point(210, 423);
            this.lblTicketNumber.Name = "lblTicketNumber";
            this.lblTicketNumber.Size = new System.Drawing.Size(75, 24);
            this.lblTicketNumber.TabIndex = 9;
            this.lblTicketNumber.Text = "Ticket #";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 364);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(265, 24);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "New Password / Recovery key";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(138, 312);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(152, 24);
            this.lblEmployeeName.TabIndex = 7;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblManagerName
            // 
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerName.Location = new System.Drawing.Point(144, 254);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(141, 24);
            this.lblManagerName.TabIndex = 6;
            this.lblManagerName.Text = "Manager Name";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.Location = new System.Drawing.Point(187, 194);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(98, 24);
            this.lblCC.TabIndex = 5;
            this.lblCC.Text = "CC (email)";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(185, 136);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(100, 24);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To  (email)";
            // 
            // tpStrikeEmail
            // 
            this.tpStrikeEmail.BackColor = System.Drawing.Color.LightGray;
            this.tpStrikeEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpStrikeEmail.Controls.Add(this.gbStrikeEmail);
            this.tpStrikeEmail.Controls.Add(this.SEbtnCompose);
            this.tpStrikeEmail.Controls.Add(this.SEtxtIssue);
            this.tpStrikeEmail.Controls.Add(this.SEtxtTicket);
            this.tpStrikeEmail.Controls.Add(this.SEtxtEmployeeName);
            this.tpStrikeEmail.Controls.Add(this.SEtxtCC);
            this.tpStrikeEmail.Controls.Add(this.SEtxtTo);
            this.tpStrikeEmail.Controls.Add(this.SElblIssue);
            this.tpStrikeEmail.Controls.Add(this.SElblTicket);
            this.tpStrikeEmail.Controls.Add(this.SElblEmployee);
            this.tpStrikeEmail.Controls.Add(this.SElblCC);
            this.tpStrikeEmail.Controls.Add(this.SElblTo);
            this.tpStrikeEmail.Location = new System.Drawing.Point(4, 29);
            this.tpStrikeEmail.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.tpStrikeEmail.Name = "tpStrikeEmail";
            this.tpStrikeEmail.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.tpStrikeEmail.Size = new System.Drawing.Size(811, 567);
            this.tpStrikeEmail.TabIndex = 1;
            this.tpStrikeEmail.Text = "Strike Email";
            // 
            // gbStrikeEmail
            // 
            this.gbStrikeEmail.Controls.Add(this.rbStrike1);
            this.gbStrikeEmail.Controls.Add(this.rbStrike2);
            this.gbStrikeEmail.Controls.Add(this.rbStrike3);
            this.gbStrikeEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbStrikeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStrikeEmail.Location = new System.Drawing.Point(9, 7);
            this.gbStrikeEmail.Name = "gbStrikeEmail";
            this.gbStrikeEmail.Size = new System.Drawing.Size(789, 81);
            this.gbStrikeEmail.TabIndex = 15;
            this.gbStrikeEmail.TabStop = false;
            this.gbStrikeEmail.Text = "Choose One";
            // 
            // rbStrike1
            // 
            this.rbStrike1.AutoSize = true;
            this.rbStrike1.Location = new System.Drawing.Point(154, 51);
            this.rbStrike1.Name = "rbStrike1";
            this.rbStrike1.Size = new System.Drawing.Size(81, 24);
            this.rbStrike1.TabIndex = 0;
            this.rbStrike1.TabStop = true;
            this.rbStrike1.Text = "Strike 1";
            this.rbStrike1.UseVisualStyleBackColor = true;
            // 
            // rbStrike2
            // 
            this.rbStrike2.AutoSize = true;
            this.rbStrike2.Checked = true;
            this.rbStrike2.Location = new System.Drawing.Point(354, 51);
            this.rbStrike2.Name = "rbStrike2";
            this.rbStrike2.Size = new System.Drawing.Size(81, 24);
            this.rbStrike2.TabIndex = 1;
            this.rbStrike2.TabStop = true;
            this.rbStrike2.Text = "Strike 2";
            this.rbStrike2.UseVisualStyleBackColor = true;
            // 
            // rbStrike3
            // 
            this.rbStrike3.AutoSize = true;
            this.rbStrike3.Location = new System.Drawing.Point(566, 51);
            this.rbStrike3.Name = "rbStrike3";
            this.rbStrike3.Size = new System.Drawing.Size(81, 24);
            this.rbStrike3.TabIndex = 2;
            this.rbStrike3.TabStop = true;
            this.rbStrike3.Text = "Strike 3";
            this.rbStrike3.UseVisualStyleBackColor = true;
            // 
            // SEbtnCompose
            // 
            this.SEbtnCompose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEbtnCompose.Location = new System.Drawing.Point(363, 475);
            this.SEbtnCompose.Name = "SEbtnCompose";
            this.SEbtnCompose.Size = new System.Drawing.Size(170, 45);
            this.SEbtnCompose.TabIndex = 13;
            this.SEbtnCompose.Text = "Compose Email";
            this.SEbtnCompose.UseVisualStyleBackColor = true;
            this.SEbtnCompose.Click += new System.EventHandler(this.SEbtnCompose_Click);
            // 
            // SEtxtIssue
            // 
            this.SEtxtIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEtxtIssue.Location = new System.Drawing.Point(313, 417);
            this.SEtxtIssue.Name = "SEtxtIssue";
            this.SEtxtIssue.Size = new System.Drawing.Size(274, 26);
            this.SEtxtIssue.TabIndex = 12;
            // 
            // SEtxtTicket
            // 
            this.SEtxtTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEtxtTicket.Location = new System.Drawing.Point(313, 356);
            this.SEtxtTicket.Name = "SEtxtTicket";
            this.SEtxtTicket.Size = new System.Drawing.Size(274, 26);
            this.SEtxtTicket.TabIndex = 11;
            this.SEtxtTicket.Tag = "";
            // 
            // SEtxtEmployeeName
            // 
            this.SEtxtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEtxtEmployeeName.Location = new System.Drawing.Point(313, 295);
            this.SEtxtEmployeeName.Name = "SEtxtEmployeeName";
            this.SEtxtEmployeeName.Size = new System.Drawing.Size(274, 26);
            this.SEtxtEmployeeName.TabIndex = 10;
            // 
            // SEtxtCC
            // 
            this.SEtxtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEtxtCC.Location = new System.Drawing.Point(313, 223);
            this.SEtxtCC.Name = "SEtxtCC";
            this.SEtxtCC.Size = new System.Drawing.Size(274, 26);
            this.SEtxtCC.TabIndex = 9;
            // 
            // SEtxtTo
            // 
            this.SEtxtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEtxtTo.Location = new System.Drawing.Point(313, 156);
            this.SEtxtTo.Name = "SEtxtTo";
            this.SEtxtTo.Size = new System.Drawing.Size(274, 26);
            this.SEtxtTo.TabIndex = 8;
            // 
            // SElblIssue
            // 
            this.SElblIssue.AutoSize = true;
            this.SElblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SElblIssue.Location = new System.Drawing.Point(221, 417);
            this.SElblIssue.Name = "SElblIssue";
            this.SElblIssue.Size = new System.Drawing.Size(53, 20);
            this.SElblIssue.TabIndex = 7;
            this.SElblIssue.Text = "Issue";
            // 
            // SElblTicket
            // 
            this.SElblTicket.AutoSize = true;
            this.SElblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SElblTicket.Location = new System.Drawing.Point(221, 356);
            this.SElblTicket.Name = "SElblTicket";
            this.SElblTicket.Size = new System.Drawing.Size(62, 20);
            this.SElblTicket.TabIndex = 6;
            this.SElblTicket.Text = "Ticket ";
            // 
            // SElblEmployee
            // 
            this.SElblEmployee.AutoSize = true;
            this.SElblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SElblEmployee.Location = new System.Drawing.Point(145, 295);
            this.SElblEmployee.Name = "SElblEmployee";
            this.SElblEmployee.Size = new System.Drawing.Size(138, 20);
            this.SElblEmployee.TabIndex = 5;
            this.SElblEmployee.Text = "Employee Name";
            // 
            // SElblCC
            // 
            this.SElblCC.AutoSize = true;
            this.SElblCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SElblCC.Location = new System.Drawing.Point(183, 229);
            this.SElblCC.Name = "SElblCC";
            this.SElblCC.Size = new System.Drawing.Size(102, 20);
            this.SElblCC.TabIndex = 4;
            this.SElblCC.Text = "CC ( email )";
            // 
            // SElblTo
            // 
            this.SElblTo.AutoSize = true;
            this.SElblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SElblTo.Location = new System.Drawing.Point(188, 162);
            this.SElblTo.Name = "SElblTo";
            this.SElblTo.Size = new System.Drawing.Size(98, 20);
            this.SElblTo.TabIndex = 3;
            this.SElblTo.Text = "To ( email )";
            // 
            // tpCSC
            // 
            this.tpCSC.BackColor = System.Drawing.Color.LightGray;
            this.tpCSC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpCSC.Controls.Add(this.txtCSCManager);
            this.tpCSC.Controls.Add(this.lblCSCManager);
            this.tpCSC.Controls.Add(this.btnCSCCompose);
            this.tpCSC.Controls.Add(this.txtCSCPassword);
            this.tpCSC.Controls.Add(this.txtCSCName);
            this.tpCSC.Controls.Add(this.txtCSCCC);
            this.tpCSC.Controls.Add(this.txtCSCTo);
            this.tpCSC.Controls.Add(this.label4);
            this.tpCSC.Controls.Add(this.label3);
            this.tpCSC.Controls.Add(this.label2);
            this.tpCSC.Controls.Add(this.label1);
            this.tpCSC.Controls.Add(this.rbCscPwdReset);
            this.tpCSC.Location = new System.Drawing.Point(4, 29);
            this.tpCSC.Name = "tpCSC";
            this.tpCSC.Size = new System.Drawing.Size(811, 567);
            this.tpCSC.TabIndex = 2;
            this.tpCSC.Text = "L-CSC";
            // 
            // txtCSCManager
            // 
            this.txtCSCManager.Location = new System.Drawing.Point(328, 258);
            this.txtCSCManager.Name = "txtCSCManager";
            this.txtCSCManager.Size = new System.Drawing.Size(274, 26);
            this.txtCSCManager.TabIndex = 11;
            // 
            // lblCSCManager
            // 
            this.lblCSCManager.AutoSize = true;
            this.lblCSCManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSCManager.Location = new System.Drawing.Point(176, 258);
            this.lblCSCManager.Name = "lblCSCManager";
            this.lblCSCManager.Size = new System.Drawing.Size(130, 20);
            this.lblCSCManager.TabIndex = 10;
            this.lblCSCManager.Text = "Manager Name";
            // 
            // btnCSCCompose
            // 
            this.btnCSCCompose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSCCompose.Location = new System.Drawing.Point(363, 475);
            this.btnCSCCompose.Name = "btnCSCCompose";
            this.btnCSCCompose.Size = new System.Drawing.Size(170, 45);
            this.btnCSCCompose.TabIndex = 9;
            this.btnCSCCompose.Text = "Compose Email";
            this.btnCSCCompose.UseVisualStyleBackColor = true;
            this.btnCSCCompose.Click += new System.EventHandler(this.btnCSCCompose_Click);
            // 
            // txtCSCPassword
            // 
            this.txtCSCPassword.Location = new System.Drawing.Point(328, 401);
            this.txtCSCPassword.Name = "txtCSCPassword";
            this.txtCSCPassword.Size = new System.Drawing.Size(274, 26);
            this.txtCSCPassword.TabIndex = 8;
            // 
            // txtCSCName
            // 
            this.txtCSCName.Location = new System.Drawing.Point(328, 331);
            this.txtCSCName.Name = "txtCSCName";
            this.txtCSCName.Size = new System.Drawing.Size(274, 26);
            this.txtCSCName.TabIndex = 7;
            // 
            // txtCSCCC
            // 
            this.txtCSCCC.Location = new System.Drawing.Point(328, 190);
            this.txtCSCCC.Name = "txtCSCCC";
            this.txtCSCCC.Size = new System.Drawing.Size(274, 26);
            this.txtCSCCC.TabIndex = 6;
            // 
            // txtCSCTo
            // 
            this.txtCSCTo.Location = new System.Drawing.Point(328, 122);
            this.txtCSCTo.Name = "txtCSCTo";
            this.txtCSCTo.Size = new System.Drawing.Size(274, 26);
            this.txtCSCTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CC ( email )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "To ( email )";
            // 
            // rbCscPwdReset
            // 
            this.rbCscPwdReset.AutoSize = true;
            this.rbCscPwdReset.Checked = true;
            this.rbCscPwdReset.Location = new System.Drawing.Point(54, 40);
            this.rbCscPwdReset.Name = "rbCscPwdReset";
            this.rbCscPwdReset.Size = new System.Drawing.Size(194, 24);
            this.rbCscPwdReset.TabIndex = 0;
            this.rbCscPwdReset.TabStop = true;
            this.rbCscPwdReset.Text = "L-CSC Password Reset";
            this.rbCscPwdReset.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 168);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(252, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(498, 46);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "One Click Response Tool";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 97);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.MainControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Click Response Tool";
            this.MainControl.ResumeLayout(false);
            this.tpUniversalID.ResumeLayout(false);
            this.tpUniversalID.PerformLayout();
            this.gbTemplate.ResumeLayout(false);
            this.gbTemplate.PerformLayout();
            this.tpStrikeEmail.ResumeLayout(false);
            this.tpStrikeEmail.PerformLayout();
            this.gbStrikeEmail.ResumeLayout(false);
            this.gbStrikeEmail.PerformLayout();
            this.tpCSC.ResumeLayout(false);
            this.tpCSC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainControl;
        private System.Windows.Forms.TabPage tpUniversalID;
        private System.Windows.Forms.TabPage tpStrikeEmail;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RadioButton rbMainFrame;
        private System.Windows.Forms.RadioButton rbBitLocker;
        private System.Windows.Forms.RadioButton rbDomainPwdReset;
        private System.Windows.Forms.RadioButton rbUniversalID;
        private System.Windows.Forms.TextBox txtTicketNumber;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTicketNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnComposeEmail;
        private System.Windows.Forms.GroupBox gbTemplate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SEbtnCompose;
        private System.Windows.Forms.TextBox SEtxtIssue;
        private System.Windows.Forms.TextBox SEtxtTicket;
        private System.Windows.Forms.TextBox SEtxtEmployeeName;
        private System.Windows.Forms.TextBox SEtxtCC;
        private System.Windows.Forms.TextBox SEtxtTo;
        private System.Windows.Forms.Label SElblIssue;
        private System.Windows.Forms.Label SElblTicket;
        private System.Windows.Forms.Label SElblEmployee;
        private System.Windows.Forms.Label SElblCC;
        private System.Windows.Forms.Label SElblTo;
        private System.Windows.Forms.RadioButton rbStrike3;
        private System.Windows.Forms.RadioButton rbStrike2;
        private System.Windows.Forms.RadioButton rbStrike1;
        private System.Windows.Forms.GroupBox gbStrikeEmail;
        private System.Windows.Forms.TabPage tpCSC;
        private System.Windows.Forms.RadioButton rbCscPwdReset;
        private System.Windows.Forms.Button btnCSCCompose;
        private System.Windows.Forms.TextBox txtCSCPassword;
        private System.Windows.Forms.TextBox txtCSCName;
        private System.Windows.Forms.TextBox txtCSCCC;
        private System.Windows.Forms.TextBox txtCSCTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblCSCManager;
        private System.Windows.Forms.TextBox txtCSCManager;
    }
}

