﻿
namespace CarProjectApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.LblBrand = new System.Windows.Forms.Label();
            this.TxtBrand = new System.Windows.Forms.TextBox();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.LblModel = new System.Windows.Forms.Label();
            this.LblManfDate = new System.Windows.Forms.Label();
            this.LblCubic = new System.Windows.Forms.Label();
            this.LblEmission = new System.Windows.Forms.Label();
            this.TxtBodyType = new System.Windows.Forms.TextBox();
            this.LblBodyType = new System.Windows.Forms.Label();
            this.TxtFuel = new System.Windows.Forms.TextBox();
            this.LblFuel = new System.Windows.Forms.Label();
            this.LblHp = new System.Windows.Forms.Label();
            this.TxtOwner = new System.Windows.Forms.TextBox();
            this.LblOwner = new System.Windows.Forms.Label();
            this.TxtRegNum = new System.Windows.Forms.TextBox();
            this.LblRegNum = new System.Windows.Forms.Label();
            this.TxtVin = new System.Windows.Forms.TextBox();
            this.LblVin = new System.Windows.Forms.Label();
            this.DtManfDate = new System.Windows.Forms.DateTimePicker();
            this.NudCubic = new System.Windows.Forms.NumericUpDown();
            this.NudHp = new System.Windows.Forms.NumericUpDown();
            this.TxtEgn = new System.Windows.Forms.TextBox();
            this.LblEgn = new System.Windows.Forms.Label();
            this.CbEmission = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CheckBoxAC = new System.Windows.Forms.CheckBox();
            this.CheckBoxElPcg = new System.Windows.Forms.CheckBox();
            this.CheckBoxLAW = new System.Windows.Forms.CheckBox();
            this.LblExtras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.ErrorTxtBrand = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTxtModel = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorNudCubic = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorNudHp = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTxtBodyType = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorCbEmission = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTxtFuel = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTxtVin = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTxtRegNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTxtOwner = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTxtEgn = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnClrForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudCubic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNudCubic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNudHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtBodyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCbEmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtVin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtRegNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtEgn)).BeginInit();
            this.SuspendLayout();
            // 
            // LblBrand
            // 
            this.LblBrand.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblBrand.AutoSize = true;
            this.LblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBrand.Location = new System.Drawing.Point(55, 42);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(72, 28);
            this.LblBrand.TabIndex = 2;
            this.LblBrand.Text = "Марка";
            // 
            // TxtBrand
            // 
            this.TxtBrand.CausesValidation = false;
            this.TxtBrand.Location = new System.Drawing.Point(185, 43);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(180, 27);
            this.TxtBrand.TabIndex = 3;
            this.TxtBrand.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBrand_Validating);
            // 
            // TxtModel
            // 
            this.TxtModel.CausesValidation = false;
            this.TxtModel.Location = new System.Drawing.Point(185, 81);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(180, 27);
            this.TxtModel.TabIndex = 5;
            this.TxtModel.Validating += new System.ComponentModel.CancelEventHandler(this.TxtModel_Validating);
            // 
            // LblModel
            // 
            this.LblModel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblModel.AutoSize = true;
            this.LblModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblModel.Location = new System.Drawing.Point(55, 81);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(74, 28);
            this.LblModel.TabIndex = 4;
            this.LblModel.Text = "Модел";
            // 
            // LblManfDate
            // 
            this.LblManfDate.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblManfDate.AutoSize = true;
            this.LblManfDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblManfDate.Location = new System.Drawing.Point(21, 128);
            this.LblManfDate.Name = "LblManfDate";
            this.LblManfDate.Size = new System.Drawing.Size(145, 28);
            this.LblManfDate.TabIndex = 6;
            this.LblManfDate.Text = "Прозведен на ";
            // 
            // LblCubic
            // 
            this.LblCubic.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblCubic.AutoSize = true;
            this.LblCubic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCubic.Location = new System.Drawing.Point(21, 172);
            this.LblCubic.Name = "LblCubic";
            this.LblCubic.Size = new System.Drawing.Size(155, 28);
            this.LblCubic.TabIndex = 8;
            this.LblCubic.Text = "Капацитет(cm3)";
            // 
            // LblEmission
            // 
            this.LblEmission.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblEmission.AutoSize = true;
            this.LblEmission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEmission.Location = new System.Drawing.Point(22, 307);
            this.LblEmission.Name = "LblEmission";
            this.LblEmission.Size = new System.Drawing.Size(145, 28);
            this.LblEmission.TabIndex = 16;
            this.LblEmission.Text = "Евро Стандарт";
            // 
            // TxtBodyType
            // 
            this.TxtBodyType.CausesValidation = false;
            this.TxtBodyType.Location = new System.Drawing.Point(185, 264);
            this.TxtBodyType.Name = "TxtBodyType";
            this.TxtBodyType.Size = new System.Drawing.Size(180, 27);
            this.TxtBodyType.TabIndex = 15;
            this.TxtBodyType.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBodyType_Validating);
            // 
            // LblBodyType
            // 
            this.LblBodyType.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblBodyType.AutoSize = true;
            this.LblBodyType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBodyType.Location = new System.Drawing.Point(21, 263);
            this.LblBodyType.Name = "LblBodyType";
            this.LblBodyType.Size = new System.Drawing.Size(140, 28);
            this.LblBodyType.TabIndex = 14;
            this.LblBodyType.Text = "Тип на купето";
            // 
            // TxtFuel
            // 
            this.TxtFuel.CausesValidation = false;
            this.TxtFuel.Location = new System.Drawing.Point(185, 351);
            this.TxtFuel.Name = "TxtFuel";
            this.TxtFuel.Size = new System.Drawing.Size(180, 27);
            this.TxtFuel.TabIndex = 13;
            this.TxtFuel.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFuel_Validating);
            // 
            // LblFuel
            // 
            this.LblFuel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblFuel.AutoSize = true;
            this.LblFuel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFuel.Location = new System.Drawing.Point(9, 347);
            this.LblFuel.Name = "LblFuel";
            this.LblFuel.Size = new System.Drawing.Size(165, 28);
            this.LblFuel.TabIndex = 12;
            this.LblFuel.Text = "Тип на горивото";
            // 
            // LblHp
            // 
            this.LblHp.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblHp.AutoSize = true;
            this.LblHp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHp.Location = new System.Drawing.Point(25, 215);
            this.LblHp.Name = "LblHp";
            this.LblHp.Size = new System.Drawing.Size(134, 28);
            this.LblHp.TabIndex = 10;
            this.LblHp.Text = "Мощност(к.с)";
            // 
            // TxtOwner
            // 
            this.TxtOwner.CausesValidation = false;
            this.TxtOwner.Location = new System.Drawing.Point(185, 513);
            this.TxtOwner.Name = "TxtOwner";
            this.TxtOwner.Size = new System.Drawing.Size(180, 27);
            this.TxtOwner.TabIndex = 23;
            this.TxtOwner.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOwner_Validating);
            // 
            // LblOwner
            // 
            this.LblOwner.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblOwner.AutoSize = true;
            this.LblOwner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOwner.Location = new System.Drawing.Point(12, 513);
            this.LblOwner.Name = "LblOwner";
            this.LblOwner.Size = new System.Drawing.Size(168, 28);
            this.LblOwner.TabIndex = 22;
            this.LblOwner.Text = "Име(собственик)";
            // 
            // TxtRegNum
            // 
            this.TxtRegNum.CausesValidation = false;
            this.TxtRegNum.Location = new System.Drawing.Point(185, 430);
            this.TxtRegNum.Name = "TxtRegNum";
            this.TxtRegNum.Size = new System.Drawing.Size(180, 27);
            this.TxtRegNum.TabIndex = 21;
            this.TxtRegNum.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRegNum_Validating);
            // 
            // LblRegNum
            // 
            this.LblRegNum.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblRegNum.AutoSize = true;
            this.LblRegNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRegNum.Location = new System.Drawing.Point(42, 430);
            this.LblRegNum.Name = "LblRegNum";
            this.LblRegNum.Size = new System.Drawing.Size(105, 28);
            this.LblRegNum.TabIndex = 20;
            this.LblRegNum.Text = "Рег.номер";
            // 
            // TxtVin
            // 
            this.TxtVin.CausesValidation = false;
            this.TxtVin.Location = new System.Drawing.Point(185, 393);
            this.TxtVin.Name = "TxtVin";
            this.TxtVin.Size = new System.Drawing.Size(180, 27);
            this.TxtVin.TabIndex = 19;
            this.TxtVin.Validating += new System.ComponentModel.CancelEventHandler(this.TxtVin_Validating);
            // 
            // LblVin
            // 
            this.LblVin.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblVin.AutoSize = true;
            this.LblVin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVin.Location = new System.Drawing.Point(42, 393);
            this.LblVin.Name = "LblVin";
            this.LblVin.Size = new System.Drawing.Size(111, 28);
            this.LblVin.TabIndex = 18;
            this.LblVin.Text = "VIN Номер";
            // 
            // DtManfDate
            // 
            this.DtManfDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtManfDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtManfDate.Location = new System.Drawing.Point(185, 128);
            this.DtManfDate.Name = "DtManfDate";
            this.DtManfDate.Size = new System.Drawing.Size(180, 27);
            this.DtManfDate.TabIndex = 24;
            // 
            // NudCubic
            // 
            this.NudCubic.CausesValidation = false;
            this.NudCubic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NudCubic.Location = new System.Drawing.Point(185, 172);
            this.NudCubic.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudCubic.Name = "NudCubic";
            this.NudCubic.Size = new System.Drawing.Size(180, 27);
            this.NudCubic.TabIndex = 25;
            this.NudCubic.Validating += new System.ComponentModel.CancelEventHandler(this.NudCubic_Validating);
            // 
            // NudHp
            // 
            this.NudHp.CausesValidation = false;
            this.NudHp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NudHp.Location = new System.Drawing.Point(185, 215);
            this.NudHp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudHp.Name = "NudHp";
            this.NudHp.Size = new System.Drawing.Size(180, 27);
            this.NudHp.TabIndex = 26;
            this.NudHp.Validating += new System.ComponentModel.CancelEventHandler(this.NudHp_Validating);
            // 
            // TxtEgn
            // 
            this.TxtEgn.CausesValidation = false;
            this.TxtEgn.Location = new System.Drawing.Point(185, 550);
            this.TxtEgn.Name = "TxtEgn";
            this.TxtEgn.Size = new System.Drawing.Size(180, 27);
            this.TxtEgn.TabIndex = 28;
            this.TxtEgn.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEgn_Validating);
            // 
            // LblEgn
            // 
            this.LblEgn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblEgn.AutoSize = true;
            this.LblEgn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEgn.Location = new System.Drawing.Point(12, 546);
            this.LblEgn.Name = "LblEgn";
            this.LblEgn.Size = new System.Drawing.Size(162, 28);
            this.LblEgn.TabIndex = 27;
            this.LblEgn.Text = "ЕГН(собственик)";
            // 
            // CbEmission
            // 
            this.CbEmission.CausesValidation = false;
            this.CbEmission.FormattingEnabled = true;
            this.CbEmission.Location = new System.Drawing.Point(185, 308);
            this.CbEmission.Name = "CbEmission";
            this.CbEmission.Size = new System.Drawing.Size(180, 28);
            this.CbEmission.TabIndex = 31;
            this.CbEmission.Validating += new System.ComponentModel.CancelEventHandler(this.CbEmission_Validating);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(417, 188);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(138, 55);
            this.BtnAdd.TabIndex = 32;
            this.BtnAdd.Text = "Добави автомобил";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.Location = new System.Drawing.Point(417, 263);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(138, 54);
            this.BtnUpdate.TabIndex = 33;
            this.BtnUpdate.Text = "Промени автомобил";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorNudCubic.SetIconAlignment(this.BtnDelete, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.BtnDelete.Location = new System.Drawing.Point(417, 337);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(138, 55);
            this.BtnDelete.TabIndex = 34;
            this.BtnDelete.Text = "Изтрий автомобил";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CheckBoxAC
            // 
            this.CheckBoxAC.AutoSize = true;
            this.CheckBoxAC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxAC.Location = new System.Drawing.Point(467, 62);
            this.CheckBoxAC.Name = "CheckBoxAC";
            this.CheckBoxAC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxAC.Size = new System.Drawing.Size(123, 32);
            this.CheckBoxAC.TabIndex = 35;
            this.CheckBoxAC.Text = "Климатик";
            this.CheckBoxAC.UseVisualStyleBackColor = true;
            // 
            // CheckBoxElPcg
            // 
            this.CheckBoxElPcg.AutoSize = true;
            this.CheckBoxElPcg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxElPcg.Location = new System.Drawing.Point(479, 100);
            this.CheckBoxElPcg.Name = "CheckBoxElPcg";
            this.CheckBoxElPcg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxElPcg.Size = new System.Drawing.Size(111, 32);
            this.CheckBoxElPcg.TabIndex = 36;
            this.CheckBoxElPcg.Text = "Ел.Пакет";
            this.CheckBoxElPcg.UseVisualStyleBackColor = true;
            // 
            // CheckBoxLAW
            // 
            this.CheckBoxLAW.AutoSize = true;
            this.CheckBoxLAW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxLAW.Location = new System.Drawing.Point(366, 138);
            this.CheckBoxLAW.Name = "CheckBoxLAW";
            this.CheckBoxLAW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxLAW.Size = new System.Drawing.Size(224, 32);
            this.CheckBoxLAW.TabIndex = 37;
            this.CheckBoxLAW.Text = "Алуминиеви джанти";
            this.CheckBoxLAW.UseVisualStyleBackColor = true;
            // 
            // LblExtras
            // 
            this.LblExtras.AutoSize = true;
            this.LblExtras.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblExtras.Location = new System.Drawing.Point(436, 9);
            this.LblExtras.Name = "LblExtras";
            this.LblExtras.Size = new System.Drawing.Size(93, 31);
            this.LblExtras.TabIndex = 38;
            this.LblExtras.Text = "Екстри";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Информация за автомобила";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 31);
            this.label2.TabIndex = 40;
            this.label2.Text = "Информация за собственика";
            // 
            // CarGridView
            // 
            this.CarGridView.AllowUserToAddRows = false;
            this.CarGridView.AllowUserToDeleteRows = false;
            this.CarGridView.AllowUserToResizeRows = false;
            this.CarGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Location = new System.Drawing.Point(597, 6);
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.RowHeadersWidth = 51;
            this.CarGridView.RowTemplate.Height = 29;
            this.CarGridView.Size = new System.Drawing.Size(648, 587);
            this.CarGridView.TabIndex = 41;
            this.CarGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CarGridView_RowHeaderMouseClick);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(6, 6);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(40, 27);
            this.TxtId.TabIndex = 42;
            this.TxtId.Visible = false;
            // 
            // ErrorTxtBrand
            // 
            this.ErrorTxtBrand.ContainerControl = this;
            // 
            // ErrorTxtModel
            // 
            this.ErrorTxtModel.ContainerControl = this;
            // 
            // ErrorNudCubic
            // 
            this.ErrorNudCubic.ContainerControl = this;
            // 
            // ErrorNudHp
            // 
            this.ErrorNudHp.ContainerControl = this;
            // 
            // ErrorTxtBodyType
            // 
            this.ErrorTxtBodyType.ContainerControl = this;
            // 
            // ErrorCbEmission
            // 
            this.ErrorCbEmission.ContainerControl = this;
            // 
            // ErrorTxtFuel
            // 
            this.ErrorTxtFuel.ContainerControl = this;
            // 
            // ErrorTxtVin
            // 
            this.ErrorTxtVin.ContainerControl = this;
            // 
            // ErrorTxtRegNum
            // 
            this.ErrorTxtRegNum.ContainerControl = this;
            // 
            // ErrorTxtOwner
            // 
            this.ErrorTxtOwner.ContainerControl = this;
            // 
            // ErrorTxtEgn
            // 
            this.ErrorTxtEgn.ContainerControl = this;
            // 
            // BtnClrForm
            // 
            this.BtnClrForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnClrForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClrForm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClrForm.Location = new System.Drawing.Point(417, 407);
            this.BtnClrForm.Name = "BtnClrForm";
            this.BtnClrForm.Size = new System.Drawing.Size(138, 59);
            this.BtnClrForm.TabIndex = 43;
            this.BtnClrForm.Text = "Изчисти формата";
            this.BtnClrForm.UseVisualStyleBackColor = false;
            this.BtnClrForm.Click += new System.EventHandler(this.BtnClrForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 603);
            this.Controls.Add(this.BtnClrForm);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.CarGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblExtras);
            this.Controls.Add(this.CheckBoxLAW);
            this.Controls.Add(this.CheckBoxElPcg);
            this.Controls.Add(this.CheckBoxAC);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbEmission);
            this.Controls.Add(this.TxtEgn);
            this.Controls.Add(this.LblEgn);
            this.Controls.Add(this.NudHp);
            this.Controls.Add(this.NudCubic);
            this.Controls.Add(this.DtManfDate);
            this.Controls.Add(this.TxtOwner);
            this.Controls.Add(this.LblOwner);
            this.Controls.Add(this.TxtRegNum);
            this.Controls.Add(this.LblRegNum);
            this.Controls.Add(this.TxtVin);
            this.Controls.Add(this.LblVin);
            this.Controls.Add(this.LblEmission);
            this.Controls.Add(this.TxtBodyType);
            this.Controls.Add(this.LblBodyType);
            this.Controls.Add(this.TxtFuel);
            this.Controls.Add(this.LblFuel);
            this.Controls.Add(this.LblHp);
            this.Controls.Add(this.LblCubic);
            this.Controls.Add(this.LblManfDate);
            this.Controls.Add(this.TxtModel);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.TxtBrand);
            this.Controls.Add(this.LblBrand);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudCubic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNudCubic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNudHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtBodyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCbEmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtVin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtRegNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTxtEgn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.TextBox TxtBrand;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Label LblManfDate;
        private System.Windows.Forms.Label LblCubic;
        private System.Windows.Forms.Label LblEmission;
        private System.Windows.Forms.TextBox TxtBodyType;
        private System.Windows.Forms.Label LblBodyType;
        private System.Windows.Forms.TextBox TxtFuel;
        private System.Windows.Forms.Label LblFuel;
        private System.Windows.Forms.Label LblHp;
        private System.Windows.Forms.TextBox TxtOwner;
        private System.Windows.Forms.Label LblOwner;
        private System.Windows.Forms.TextBox TxtRegNum;
        private System.Windows.Forms.Label LblRegNum;
        private System.Windows.Forms.TextBox TxtVin;
        private System.Windows.Forms.Label LblVin;
        private System.Windows.Forms.DateTimePicker DtManfDate;
        private System.Windows.Forms.NumericUpDown NudCubic;
        private System.Windows.Forms.NumericUpDown NudHp;
        private System.Windows.Forms.TextBox TxtEgn;
        private System.Windows.Forms.Label LblEgn;
        private System.Windows.Forms.ComboBox CbEmission;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.CheckBox CheckBoxAC;
        private System.Windows.Forms.CheckBox CheckBoxElPcg;
        private System.Windows.Forms.CheckBox CheckBoxLAW;
        private System.Windows.Forms.Label LblExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CarGridView;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.ErrorProvider ErrorTxtBrand;
        private System.Windows.Forms.ErrorProvider ErrorTxtModel;
        private System.Windows.Forms.ErrorProvider ErrorNudCubic;
        private System.Windows.Forms.ErrorProvider ErrorNudHp;
        private System.Windows.Forms.ErrorProvider ErrorTxtBodyType;
        private System.Windows.Forms.ErrorProvider ErrorCbEmission;
        private System.Windows.Forms.ErrorProvider ErrorTxtFuel;
        private System.Windows.Forms.ErrorProvider ErrorTxtVin;
        private System.Windows.Forms.ErrorProvider ErrorTxtRegNum;
        private System.Windows.Forms.ErrorProvider ErrorTxtOwner;
        private System.Windows.Forms.ErrorProvider ErrorTxtEgn;
        private System.Windows.Forms.Button BtnClrForm;
    }
}

