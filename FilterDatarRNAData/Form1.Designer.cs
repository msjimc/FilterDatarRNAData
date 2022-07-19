using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilterDatarRNAData
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.nudToo = new System.Windows.Forms.NumericUpDown();
            this.nudPercentIdentity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTaxonomyLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnFiltered = new System.Windows.Forms.Button();
            this.rboPercent = new System.Windows.Forms.RadioButton();
            this.rboProportions = new System.Windows.Forms.RadioButton();
            this.rboAbsolute = new System.Windows.Forms.RadioButton();
            this.cboTaxonomyName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPercent = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.cboTaxonomyStart = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboSequenceColumn = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboDataEnd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDataStart = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentIdentity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxonomyLevel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(290, 11);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select raw data file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter sequence size range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "to";
            // 
            // nudFrom
            // 
            this.nudFrom.Location = new System.Drawing.Point(185, 14);
            this.nudFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFrom.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(75, 20);
            this.nudFrom.TabIndex = 6;
            this.nudFrom.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // nudToo
            // 
            this.nudToo.Location = new System.Drawing.Point(290, 14);
            this.nudToo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudToo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudToo.Name = "nudToo";
            this.nudToo.Size = new System.Drawing.Size(75, 20);
            this.nudToo.TabIndex = 7;
            this.nudToo.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // nudPercentIdentity
            // 
            this.nudPercentIdentity.Location = new System.Drawing.Point(290, 40);
            this.nudPercentIdentity.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudPercentIdentity.Name = "nudPercentIdentity";
            this.nudPercentIdentity.Size = new System.Drawing.Size(75, 20);
            this.nudPercentIdentity.TabIndex = 8;
            this.nudPercentIdentity.Value = new decimal(new int[] {
            98,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Percent identity to blast hit";
            // 
            // nudTaxonomyLevel
            // 
            this.nudTaxonomyLevel.Enabled = false;
            this.nudTaxonomyLevel.Location = new System.Drawing.Point(290, 168);
            this.nudTaxonomyLevel.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudTaxonomyLevel.Name = "nudTaxonomyLevel";
            this.nudTaxonomyLevel.Size = new System.Drawing.Size(75, 20);
            this.nudTaxonomyLevel.TabIndex = 10;
            this.nudTaxonomyLevel.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudTaxonomyLevel.ValueChanged += new System.EventHandler(this.nudTaxonomyLevel_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Taxonomic level of Identity";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(291, 16);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of UTOs: not set";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Results";
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(6, 39);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(359, 84);
            this.lblResults.TabIndex = 15;
            this.lblResults.Text = "Not set";
            // 
            // btnFiltered
            // 
            this.btnFiltered.Enabled = false;
            this.btnFiltered.Location = new System.Drawing.Point(291, 41);
            this.btnFiltered.Name = "btnFiltered";
            this.btnFiltered.Size = new System.Drawing.Size(75, 23);
            this.btnFiltered.TabIndex = 16;
            this.btnFiltered.Text = "Filtered";
            this.btnFiltered.UseVisualStyleBackColor = true;
            this.btnFiltered.Click += new System.EventHandler(this.btnFiltered_Click);
            // 
            // rboPercent
            // 
            this.rboPercent.AutoSize = true;
            this.rboPercent.Checked = true;
            this.rboPercent.Location = new System.Drawing.Point(188, 20);
            this.rboPercent.Name = "rboPercent";
            this.rboPercent.Size = new System.Drawing.Size(62, 17);
            this.rboPercent.TabIndex = 21;
            this.rboPercent.TabStop = true;
            this.rboPercent.Text = "Percent";
            this.rboPercent.UseVisualStyleBackColor = true;
            // 
            // rboProportions
            // 
            this.rboProportions.AutoSize = true;
            this.rboProportions.Location = new System.Drawing.Point(97, 20);
            this.rboProportions.Name = "rboProportions";
            this.rboProportions.Size = new System.Drawing.Size(78, 17);
            this.rboProportions.TabIndex = 20;
            this.rboProportions.Text = "Proportions";
            this.rboProportions.UseVisualStyleBackColor = true;
            // 
            // rboAbsolute
            // 
            this.rboAbsolute.AutoSize = true;
            this.rboAbsolute.Location = new System.Drawing.Point(6, 20);
            this.rboAbsolute.Name = "rboAbsolute";
            this.rboAbsolute.Size = new System.Drawing.Size(66, 17);
            this.rboAbsolute.TabIndex = 19;
            this.rboAbsolute.Text = "Absolute";
            this.rboAbsolute.UseVisualStyleBackColor = true;
            // 
            // cboTaxonomyName
            // 
            this.cboTaxonomyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTaxonomyName.Enabled = false;
            this.cboTaxonomyName.FormattingEnabled = true;
            this.cboTaxonomyName.Location = new System.Drawing.Point(163, 167);
            this.cboTaxonomyName.Name = "cboTaxonomyName";
            this.cboTaxonomyName.Size = new System.Drawing.Size(121, 21);
            this.cboTaxonomyName.TabIndex = 22;
            this.cboTaxonomyName.SelectedIndexChanged += new System.EventHandler(this.cboTaxonomyName_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudFrom);
            this.groupBox1.Controls.Add(this.nudToo);
            this.groupBox1.Controls.Add(this.nudPercentIdentity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPercent);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.cboTaxonomyStart);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboSequenceColumn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboTaxonomyName);
            this.groupBox2.Controls.Add(this.nudTaxonomyLevel);
            this.groupBox2.Controls.Add(this.cboDataEnd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboDataStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Location = new System.Drawing.Point(10, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 224);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data selection";
            // 
            // cboPercent
            // 
            this.cboPercent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPercent.FormattingEnabled = true;
            this.cboPercent.Location = new System.Drawing.Point(165, 116);
            this.cboPercent.Name = "cboPercent";
            this.cboPercent.Size = new System.Drawing.Size(204, 21);
            this.cboPercent.TabIndex = 15;
            this.cboPercent.SelectedIndexChanged += new System.EventHandler(this.cboPercent_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Select percent alignment column";
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(290, 195);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // cboTaxonomyStart
            // 
            this.cboTaxonomyStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTaxonomyStart.FormattingEnabled = true;
            this.cboTaxonomyStart.Location = new System.Drawing.Point(164, 143);
            this.cboTaxonomyStart.Name = "cboTaxonomyStart";
            this.cboTaxonomyStart.Size = new System.Drawing.Size(204, 21);
            this.cboTaxonomyStart.TabIndex = 9;
            this.cboTaxonomyStart.SelectedIndexChanged += new System.EventHandler(this.cboTaxonomyStart_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Import data from file";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Select first taxonomy column";
            // 
            // cboSequenceColumn
            // 
            this.cboSequenceColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSequenceColumn.FormattingEnabled = true;
            this.cboSequenceColumn.Location = new System.Drawing.Point(164, 90);
            this.cboSequenceColumn.Name = "cboSequenceColumn";
            this.cboSequenceColumn.Size = new System.Drawing.Size(204, 21);
            this.cboSequenceColumn.TabIndex = 7;
            this.cboSequenceColumn.SelectedIndexChanged += new System.EventHandler(this.cboSequenceColumn_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Select sequence column";
            // 
            // cboDataEnd
            // 
            this.cboDataEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataEnd.FormattingEnabled = true;
            this.cboDataEnd.Location = new System.Drawing.Point(164, 65);
            this.cboDataEnd.Name = "cboDataEnd";
            this.cboDataEnd.Size = new System.Drawing.Size(204, 21);
            this.cboDataEnd.TabIndex = 5;
            this.cboDataEnd.SelectedIndexChanged += new System.EventHandler(this.cboDataEnd_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Select last column of data";
            // 
            // cboDataStart
            // 
            this.cboDataStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataStart.FormattingEnabled = true;
            this.cboDataStart.Location = new System.Drawing.Point(164, 40);
            this.cboDataStart.Name = "cboDataStart";
            this.cboDataStart.Size = new System.Drawing.Size(204, 21);
            this.cboDataStart.TabIndex = 3;
            this.cboDataStart.SelectedIndexChanged += new System.EventHandler(this.cboDataStart_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select first column of data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblResults);
            this.groupBox3.Location = new System.Drawing.Point(10, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 131);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Feedback";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rboAbsolute);
            this.groupBox4.Controls.Add(this.btnExport);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnFiltered);
            this.groupBox4.Controls.Add(this.rboPercent);
            this.groupBox4.Controls.Add(this.rboProportions);
            this.groupBox4.Location = new System.Drawing.Point(10, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 78);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Export options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 25;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Filter sequences by Taxonomy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentIdentity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxonomyLevel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.NumericUpDown nudToo;
        private System.Windows.Forms.NumericUpDown nudPercentIdentity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTaxonomyLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnFiltered;
        private System.Windows.Forms.RadioButton rboPercent;
        private System.Windows.Forms.RadioButton rboProportions;
        private System.Windows.Forms.RadioButton rboAbsolute;
        private System.Windows.Forms.ComboBox cboTaxonomyName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cboTaxonomyStart;
        private Label label11;
        private ComboBox cboSequenceColumn;
        private Label label10;
        private ComboBox cboDataEnd;
        private Label label9;
        private ComboBox cboDataStart;
        private Label label8;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
        private Label label12;
        private Button btnImport;
        private ComboBox cboPercent;
        private Label label14;
    }
}

