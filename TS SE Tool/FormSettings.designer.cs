﻿namespace TS_SE_Tool
{
    partial class FormSettings
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelDistance = new System.Windows.Forms.Label();
            this.comboBoxSettingDistanceMesSelect = new System.Windows.Forms.ComboBox();
            this.comboBoxSettingCurrencySelect = new System.Windows.Forms.ComboBox();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelDayShort = new System.Windows.Forms.Label();
            this.labelHourShort = new System.Windows.Forms.Label();
            this.numericUpDownSettingPickTimeD = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDataBase = new System.Windows.Forms.GroupBox();
            this.buttonDBClear = new System.Windows.Forms.Button();
            this.buttonDBImport = new System.Windows.Forms.Button();
            this.buttonDBExport = new System.Windows.Forms.Button();
            this.numericUpDownSettingLoopCitys = new System.Windows.Forms.NumericUpDown();
            this.labelLoopEvery = new System.Windows.Forms.Label();
            this.numericUpDownSettingPickTimeH = new System.Windows.Forms.NumericUpDown();
            this.labelJobPickupTime = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingPickTimeD)).BeginInit();
            this.groupBoxDataBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingLoopCitys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingPickTimeH)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelDistance);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxSettingDistanceMesSelect);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxSettingCurrencySelect);
            this.splitContainer1.Panel1.Controls.Add(this.labelCurrency);
            this.splitContainer1.Panel1.Controls.Add(this.labelCity);
            this.splitContainer1.Panel1.Controls.Add(this.labelDayShort);
            this.splitContainer1.Panel1.Controls.Add(this.labelHourShort);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownSettingPickTimeD);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDataBase);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownSettingLoopCitys);
            this.splitContainer1.Panel1.Controls.Add(this.labelLoopEvery);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownSettingPickTimeH);
            this.splitContainer1.Panel1.Controls.Add(this.labelJobPickupTime);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(350, 241);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(12, 73);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(49, 13);
            this.labelDistance.TabIndex = 11;
            this.labelDistance.Text = "Distance";
            // 
            // comboBoxSettingDistanceMesSelect
            // 
            this.comboBoxSettingDistanceMesSelect.FormattingEnabled = true;
            this.comboBoxSettingDistanceMesSelect.Location = new System.Drawing.Point(181, 69);
            this.comboBoxSettingDistanceMesSelect.Name = "comboBoxSettingDistanceMesSelect";
            this.comboBoxSettingDistanceMesSelect.Size = new System.Drawing.Size(157, 21);
            this.comboBoxSettingDistanceMesSelect.TabIndex = 10;
            // 
            // comboBoxSettingCurrencySelect
            // 
            this.comboBoxSettingCurrencySelect.Enabled = false;
            this.comboBoxSettingCurrencySelect.FormattingEnabled = true;
            this.comboBoxSettingCurrencySelect.Location = new System.Drawing.Point(181, 97);
            this.comboBoxSettingCurrencySelect.Name = "comboBoxSettingCurrencySelect";
            this.comboBoxSettingCurrencySelect.Size = new System.Drawing.Size(157, 21);
            this.comboBoxSettingCurrencySelect.TabIndex = 9;
            this.comboBoxSettingCurrencySelect.Visible = false;
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(12, 100);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(49, 13);
            this.labelCurrency.TabIndex = 8;
            this.labelCurrency.Text = "Currency";
            this.labelCurrency.Visible = false;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(227, 45);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(23, 13);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "city";
            // 
            // labelDayShort
            // 
            this.labelDayShort.AutoSize = true;
            this.labelDayShort.Location = new System.Drawing.Point(228, 14);
            this.labelDayShort.Name = "labelDayShort";
            this.labelDayShort.Size = new System.Drawing.Size(24, 13);
            this.labelDayShort.TabIndex = 6;
            this.labelDayShort.Text = "day";
            // 
            // labelHourShort
            // 
            this.labelHourShort.AutoSize = true;
            this.labelHourShort.Location = new System.Drawing.Point(310, 14);
            this.labelHourShort.Name = "labelHourShort";
            this.labelHourShort.Size = new System.Drawing.Size(28, 13);
            this.labelHourShort.TabIndex = 5;
            this.labelHourShort.Text = "hour";
            // 
            // numericUpDownSettingPickTimeD
            // 
            this.numericUpDownSettingPickTimeD.Location = new System.Drawing.Point(181, 12);
            this.numericUpDownSettingPickTimeD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownSettingPickTimeD.Name = "numericUpDownSettingPickTimeD";
            this.numericUpDownSettingPickTimeD.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownSettingPickTimeD.TabIndex = 4;
            this.numericUpDownSettingPickTimeD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSettingPickTimeD.ValueChanged += new System.EventHandler(this.numericUpDownSettingPickTimeD_ValueChanged);
            // 
            // groupBoxDataBase
            // 
            this.groupBoxDataBase.Controls.Add(this.buttonDBClear);
            this.groupBoxDataBase.Controls.Add(this.buttonDBImport);
            this.groupBoxDataBase.Controls.Add(this.buttonDBExport);
            this.groupBoxDataBase.Location = new System.Drawing.Point(12, 122);
            this.groupBoxDataBase.Name = "groupBoxDataBase";
            this.groupBoxDataBase.Size = new System.Drawing.Size(326, 54);
            this.groupBoxDataBase.TabIndex = 3;
            this.groupBoxDataBase.TabStop = false;
            this.groupBoxDataBase.Text = "DataBase";
            this.groupBoxDataBase.Visible = false;
            // 
            // buttonDBClear
            // 
            this.buttonDBClear.Enabled = false;
            this.buttonDBClear.Location = new System.Drawing.Point(218, 19);
            this.buttonDBClear.Name = "buttonDBClear";
            this.buttonDBClear.Size = new System.Drawing.Size(100, 23);
            this.buttonDBClear.TabIndex = 5;
            this.buttonDBClear.Text = "Clear";
            this.buttonDBClear.UseVisualStyleBackColor = true;
            this.buttonDBClear.Click += new System.EventHandler(this.buttonSettingDBClear_Click);
            // 
            // buttonDBImport
            // 
            this.buttonDBImport.Enabled = false;
            this.buttonDBImport.Location = new System.Drawing.Point(112, 19);
            this.buttonDBImport.Name = "buttonDBImport";
            this.buttonDBImport.Size = new System.Drawing.Size(100, 23);
            this.buttonDBImport.TabIndex = 4;
            this.buttonDBImport.Text = "Import";
            this.buttonDBImport.UseVisualStyleBackColor = true;
            this.buttonDBImport.Click += new System.EventHandler(this.buttonSettingDBImport_Click);
            // 
            // buttonDBExport
            // 
            this.buttonDBExport.Enabled = false;
            this.buttonDBExport.Location = new System.Drawing.Point(6, 19);
            this.buttonDBExport.Name = "buttonDBExport";
            this.buttonDBExport.Size = new System.Drawing.Size(100, 23);
            this.buttonDBExport.TabIndex = 3;
            this.buttonDBExport.Text = "Export";
            this.buttonDBExport.UseVisualStyleBackColor = true;
            this.buttonDBExport.Click += new System.EventHandler(this.buttonSettingDBExport_Click);
            // 
            // numericUpDownSettingLoopCitys
            // 
            this.numericUpDownSettingLoopCitys.Location = new System.Drawing.Point(181, 43);
            this.numericUpDownSettingLoopCitys.Name = "numericUpDownSettingLoopCitys";
            this.numericUpDownSettingLoopCitys.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSettingLoopCitys.TabIndex = 1;
            this.numericUpDownSettingLoopCitys.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSettingLoopCitys.ValueChanged += new System.EventHandler(this.numericUpDownSettingLoopCitys_ValueChanged);
            // 
            // labelLoopEvery
            // 
            this.labelLoopEvery.AutoSize = true;
            this.labelLoopEvery.Location = new System.Drawing.Point(12, 45);
            this.labelLoopEvery.Name = "labelLoopEvery";
            this.labelLoopEvery.Size = new System.Drawing.Size(61, 13);
            this.labelLoopEvery.TabIndex = 0;
            this.labelLoopEvery.Text = "Loop Every";
            // 
            // numericUpDownSettingPickTimeH
            // 
            this.numericUpDownSettingPickTimeH.Location = new System.Drawing.Point(264, 12);
            this.numericUpDownSettingPickTimeH.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownSettingPickTimeH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownSettingPickTimeH.Name = "numericUpDownSettingPickTimeH";
            this.numericUpDownSettingPickTimeH.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSettingPickTimeH.TabIndex = 1;
            this.numericUpDownSettingPickTimeH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSettingPickTimeH.ValueChanged += new System.EventHandler(this.numericUpDownSettingPickTimeH_ValueChanged);
            // 
            // labelJobPickupTime
            // 
            this.labelJobPickupTime.AutoSize = true;
            this.labelJobPickupTime.Location = new System.Drawing.Point(12, 14);
            this.labelJobPickupTime.Name = "labelJobPickupTime";
            this.labelJobPickupTime.Size = new System.Drawing.Size(86, 13);
            this.labelJobPickupTime.TabIndex = 0;
            this.labelJobPickupTime.Text = "Job Pickup Time";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(263, 15);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonSettingCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(12, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSettingSave_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 280);
            this.Name = "FormSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingPickTimeD)).EndInit();
            this.groupBoxDataBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingLoopCitys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingPickTimeH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelLoopEvery;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownSettingLoopCitys;
        private System.Windows.Forms.NumericUpDown numericUpDownSettingPickTimeH;
        private System.Windows.Forms.Label labelJobPickupTime;
        private System.Windows.Forms.GroupBox groupBoxDataBase;
        private System.Windows.Forms.Button buttonDBImport;
        private System.Windows.Forms.Button buttonDBExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonDBClear;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.ComboBox comboBoxSettingDistanceMesSelect;
        private System.Windows.Forms.ComboBox comboBoxSettingCurrencySelect;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelDayShort;
        private System.Windows.Forms.Label labelHourShort;
        private System.Windows.Forms.NumericUpDown numericUpDownSettingPickTimeD;
        private System.Windows.Forms.Label labelCurrency;
    }
}