﻿using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;

namespace Engine
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    partial class frmSkill : System.Windows.Forms.Form
    {

        // Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                    components.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.DarkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.lstIndex = new System.Windows.Forms.ListBox();
            this.DarkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.btnDelete = new DarkUI.Controls.DarkButton();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.DarkGroupBox5 = new DarkUI.Controls.DarkGroupBox();
            this.DarkGroupBox8 = new DarkUI.Controls.DarkGroupBox();
            this.cmbAnim = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel23 = new DarkUI.Controls.DarkLabel();
            this.cmbAnimCast = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel22 = new DarkUI.Controls.DarkLabel();
            this.nudStun = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel21 = new DarkUI.Controls.DarkLabel();
            this.DarkLabel20 = new DarkUI.Controls.DarkLabel();
            this.nudAoE = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel19 = new DarkUI.Controls.DarkLabel();
            this.chkAoE = new DarkUI.Controls.DarkCheckBox();
            this.DarkLabel18 = new DarkUI.Controls.DarkLabel();
            this.nudRange = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel17 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox7 = new DarkUI.Controls.DarkGroupBox();
            this.nudInterval = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel16 = new DarkUI.Controls.DarkLabel();
            this.nudDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel15 = new DarkUI.Controls.DarkLabel();
            this.nudVital = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel14 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox6 = new DarkUI.Controls.DarkGroupBox();
            this.nudY = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel13 = new DarkUI.Controls.DarkLabel();
            this.nudX = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel12 = new DarkUI.Controls.DarkLabel();
            this.cmbDir = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel11 = new DarkUI.Controls.DarkLabel();
            this.nudMap = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel10 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.chkKnockBack = new DarkUI.Controls.DarkCheckBox();
            this.cmbKnockBackTiles = new DarkUI.Controls.DarkComboBox();
            this.cmbProjectile = new DarkUI.Controls.DarkComboBox();
            this.chkProjectile = new DarkUI.Controls.DarkCheckBox();
            this.nudIcon = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel9 = new DarkUI.Controls.DarkLabel();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.nudCool = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel8 = new DarkUI.Controls.DarkLabel();
            this.nudCast = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel7 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox4 = new DarkUI.Controls.DarkGroupBox();
            this.DarkLabel6 = new DarkUI.Controls.DarkLabel();
            this.cmbClass = new DarkUI.Controls.DarkComboBox();
            this.cmbAccessReq = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel5 = new DarkUI.Controls.DarkLabel();
            this.nudLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel4 = new DarkUI.Controls.DarkLabel();
            this.nudMp = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel3 = new DarkUI.Controls.DarkLabel();
            this.cmbType = new DarkUI.Controls.DarkComboBox();
            this.DarkLabel2 = new DarkUI.Controls.DarkLabel();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.DarkLabel1 = new DarkUI.Controls.DarkLabel();
            this.DarkGroupBox1.SuspendLayout();
            this.DarkGroupBox2.SuspendLayout();
            this.DarkGroupBox5.SuspendLayout();
            this.DarkGroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudStun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudAoE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudRange).BeginInit();
            this.DarkGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudVital).BeginInit();
            this.DarkGroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudMap).BeginInit();
            this.DarkGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picSprite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudCool).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudCast).BeginInit();
            this.DarkGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nudMp).BeginInit();
            this.SuspendLayout();
            // 
            // DarkGroupBox1
            // 
            this.DarkGroupBox1.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox1.Controls.Add(this.lstIndex);
            this.DarkGroupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.DarkGroupBox1.Name = "DarkGroupBox1";
            this.DarkGroupBox1.Size = new System.Drawing.Size(183, 394);
            this.DarkGroupBox1.TabIndex = 0;
            this.DarkGroupBox1.TabStop = false;
            this.DarkGroupBox1.Text = "Skill List";
            // 
            // lstIndex
            // 
            this.lstIndex.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.lstIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstIndex.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstIndex.FormattingEnabled = true;
            this.lstIndex.Location = new System.Drawing.Point(6, 19);
            this.lstIndex.Name = "lstIndex";
            this.lstIndex.Size = new System.Drawing.Size(171, 366);
            this.lstIndex.TabIndex = 1;
            // 
            // DarkGroupBox2
            // 
            this.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox2.Controls.Add(this.btnDelete);
            this.DarkGroupBox2.Controls.Add(this.btnCancel);
            this.DarkGroupBox2.Controls.Add(this.btnSave);
            this.DarkGroupBox2.Controls.Add(this.DarkGroupBox5);
            this.DarkGroupBox2.Controls.Add(this.DarkGroupBox3);
            this.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox2.Location = new System.Drawing.Point(192, 3);
            this.DarkGroupBox2.Name = "DarkGroupBox2";
            this.DarkGroupBox2.Size = new System.Drawing.Size(619, 394);
            this.DarkGroupBox2.TabIndex = 1;
            this.DarkGroupBox2.TabStop = false;
            this.DarkGroupBox2.Text = "Skill Properties";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(134, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            // 
            // DarkGroupBox5
            // 
            this.DarkGroupBox5.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox5.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox5.Controls.Add(this.DarkGroupBox8);
            this.DarkGroupBox5.Controls.Add(this.DarkGroupBox7);
            this.DarkGroupBox5.Controls.Add(this.DarkGroupBox6);
            this.DarkGroupBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox5.Location = new System.Drawing.Point(342, 19);
            this.DarkGroupBox5.Name = "DarkGroupBox5";
            this.DarkGroupBox5.Size = new System.Drawing.Size(267, 367);
            this.DarkGroupBox5.TabIndex = 1;
            this.DarkGroupBox5.TabStop = false;
            this.DarkGroupBox5.Text = "Data";
            // 
            // DarkGroupBox8
            // 
            this.DarkGroupBox8.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox8.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox8.Controls.Add(this.cmbAnim);
            this.DarkGroupBox8.Controls.Add(this.DarkLabel23);
            this.DarkGroupBox8.Controls.Add(this.cmbAnimCast);
            this.DarkGroupBox8.Controls.Add(this.DarkLabel22);
            this.DarkGroupBox8.Controls.Add(this.nudStun);
            this.DarkGroupBox8.Controls.Add(this.DarkLabel21);
            this.DarkGroupBox8.Controls.Add(this.DarkLabel20);
            this.DarkGroupBox8.Controls.Add(this.nudAoE);
            this.DarkGroupBox8.Controls.Add(this.DarkLabel19);
            this.DarkGroupBox8.Controls.Add(this.chkAoE);
            this.DarkGroupBox8.Controls.Add(this.DarkLabel18);
            this.DarkGroupBox8.Controls.Add(this.nudRange);
            this.DarkGroupBox8.Controls.Add(this.DarkLabel17);
            this.DarkGroupBox8.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox8.Location = new System.Drawing.Point(6, 181);
            this.DarkGroupBox8.Name = "DarkGroupBox8";
            this.DarkGroupBox8.Size = new System.Drawing.Size(254, 181);
            this.DarkGroupBox8.TabIndex = 2;
            this.DarkGroupBox8.TabStop = false;
            this.DarkGroupBox8.Text = "Cast Settings";
            // 
            // cmbAnim
            // 
            this.cmbAnim.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbAnim.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbAnim.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAnim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnim.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAnim.FormattingEnabled = true;
            this.cmbAnim.Location = new System.Drawing.Point(104, 153);
            this.cmbAnim.Name = "cmbAnim";
            this.cmbAnim.Size = new System.Drawing.Size(144, 21);
            this.cmbAnim.TabIndex = 12;
            // 
            // DarkLabel23
            // 
            this.DarkLabel23.AutoSize = true;
            this.DarkLabel23.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel23.Location = new System.Drawing.Point(6, 156);
            this.DarkLabel23.Name = "DarkLabel23";
            this.DarkLabel23.Size = new System.Drawing.Size(56, 13);
            this.DarkLabel23.TabIndex = 11;
            this.DarkLabel23.Text = "Animation:";
            // 
            // cmbAnimCast
            // 
            this.cmbAnimCast.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbAnimCast.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbAnimCast.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAnimCast.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnimCast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimCast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnimCast.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAnimCast.FormattingEnabled = true;
            this.cmbAnimCast.Location = new System.Drawing.Point(104, 126);
            this.cmbAnimCast.Name = "cmbAnimCast";
            this.cmbAnimCast.Size = new System.Drawing.Size(144, 21);
            this.cmbAnimCast.TabIndex = 10;
            // 
            // DarkLabel22
            // 
            this.DarkLabel22.AutoSize = true;
            this.DarkLabel22.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel22.Location = new System.Drawing.Point(6, 129);
            this.DarkLabel22.Name = "DarkLabel22";
            this.DarkLabel22.Size = new System.Drawing.Size(80, 13);
            this.DarkLabel22.TabIndex = 9;
            this.DarkLabel22.Text = "Cast Animation:";
            // 
            // nudStun
            // 
            this.nudStun.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudStun.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStun.Location = new System.Drawing.Point(150, 95);
            this.nudStun.Name = "nudStun";
            this.nudStun.Size = new System.Drawing.Size(75, 20);
            this.nudStun.TabIndex = 8;
            // 
            // DarkLabel21
            // 
            this.DarkLabel21.AutoSize = true;
            this.DarkLabel21.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel21.Location = new System.Drawing.Point(6, 97);
            this.DarkLabel21.Name = "DarkLabel21";
            this.DarkLabel21.Size = new System.Drawing.Size(103, 13);
            this.DarkLabel21.TabIndex = 7;
            this.DarkLabel21.Text = "Stun Duration(secs):";
            // 
            // DarkLabel20
            // 
            this.DarkLabel20.AutoSize = true;
            this.DarkLabel20.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel20.Location = new System.Drawing.Point(107, 71);
            this.DarkLabel20.Name = "DarkLabel20";
            this.DarkLabel20.Size = new System.Drawing.Size(118, 13);
            this.DarkLabel20.TabIndex = 6;
            this.DarkLabel20.Text = "Tiles. Hint: 0 is self-cast";
            // 
            // nudAoE
            // 
            this.nudAoE.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudAoE.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAoE.Location = new System.Drawing.Point(54, 69);
            this.nudAoE.Name = "nudAoE";
            this.nudAoE.Size = new System.Drawing.Size(47, 20);
            this.nudAoE.TabIndex = 5;
            // 
            // DarkLabel19
            // 
            this.DarkLabel19.AutoSize = true;
            this.DarkLabel19.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel19.Location = new System.Drawing.Point(6, 71);
            this.DarkLabel19.Name = "DarkLabel19";
            this.DarkLabel19.Size = new System.Drawing.Size(30, 13);
            this.DarkLabel19.TabIndex = 4;
            this.DarkLabel19.Text = "AoE:";
            // 
            // chkAoE
            // 
            this.chkAoE.AutoSize = true;
            this.chkAoE.Location = new System.Drawing.Point(9, 46);
            this.chkAoE.Name = "chkAoE";
            this.chkAoE.Size = new System.Drawing.Size(79, 17);
            this.chkAoE.TabIndex = 3;
            this.chkAoE.Text = "Is AoE Skill";
            // 
            // DarkLabel18
            // 
            this.DarkLabel18.AutoSize = true;
            this.DarkLabel18.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel18.Location = new System.Drawing.Point(107, 23);
            this.DarkLabel18.Name = "DarkLabel18";
            this.DarkLabel18.Size = new System.Drawing.Size(118, 13);
            this.DarkLabel18.TabIndex = 2;
            this.DarkLabel18.Text = "Tiles. Hint: 0 is self-cast";
            // 
            // nudRange
            // 
            this.nudRange.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRange.Location = new System.Drawing.Point(54, 20);
            this.nudRange.Name = "nudRange";
            this.nudRange.Size = new System.Drawing.Size(47, 20);
            this.nudRange.TabIndex = 1;
            // 
            // DarkLabel17
            // 
            this.DarkLabel17.AutoSize = true;
            this.DarkLabel17.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel17.Location = new System.Drawing.Point(6, 23);
            this.DarkLabel17.Name = "DarkLabel17";
            this.DarkLabel17.Size = new System.Drawing.Size(42, 13);
            this.DarkLabel17.TabIndex = 0;
            this.DarkLabel17.Text = "Range:";
            // 
            // DarkGroupBox7
            // 
            this.DarkGroupBox7.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox7.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox7.Controls.Add(this.nudInterval);
            this.DarkGroupBox7.Controls.Add(this.DarkLabel16);
            this.DarkGroupBox7.Controls.Add(this.nudDuration);
            this.DarkGroupBox7.Controls.Add(this.DarkLabel15);
            this.DarkGroupBox7.Controls.Add(this.nudVital);
            this.DarkGroupBox7.Controls.Add(this.DarkLabel14);
            this.DarkGroupBox7.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox7.Location = new System.Drawing.Point(6, 98);
            this.DarkGroupBox7.Name = "DarkGroupBox7";
            this.DarkGroupBox7.Size = new System.Drawing.Size(254, 77);
            this.DarkGroupBox7.TabIndex = 1;
            this.DarkGroupBox7.TabStop = false;
            this.DarkGroupBox7.Text = "HoT & DoT Settings ";
            // 
            // nudInterval
            // 
            this.nudInterval.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudInterval.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudInterval.Location = new System.Drawing.Point(203, 45);
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(45, 20);
            this.nudInterval.TabIndex = 5;
            // 
            // DarkLabel16
            // 
            this.DarkLabel16.AutoSize = true;
            this.DarkLabel16.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel16.Location = new System.Drawing.Point(152, 47);
            this.DarkLabel16.Name = "DarkLabel16";
            this.DarkLabel16.Size = new System.Drawing.Size(45, 13);
            this.DarkLabel16.TabIndex = 4;
            this.DarkLabel16.Text = "Interval:";
            // 
            // nudDuration
            // 
            this.nudDuration.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDuration.Location = new System.Drawing.Point(90, 45);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(45, 20);
            this.nudDuration.TabIndex = 3;
            // 
            // DarkLabel15
            // 
            this.DarkLabel15.AutoSize = true;
            this.DarkLabel15.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel15.Location = new System.Drawing.Point(6, 47);
            this.DarkLabel15.Name = "DarkLabel15";
            this.DarkLabel15.Size = new System.Drawing.Size(78, 13);
            this.DarkLabel15.TabIndex = 2;
            this.DarkLabel15.Text = "Duration(secs):";
            // 
            // nudVital
            // 
            this.nudVital.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudVital.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudVital.Location = new System.Drawing.Point(146, 19);
            this.nudVital.Name = "nudVital";
            this.nudVital.Size = new System.Drawing.Size(102, 20);
            this.nudVital.TabIndex = 1;
            // 
            // DarkLabel14
            // 
            this.DarkLabel14.AutoSize = true;
            this.DarkLabel14.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel14.Location = new System.Drawing.Point(6, 21);
            this.DarkLabel14.Name = "DarkLabel14";
            this.DarkLabel14.Size = new System.Drawing.Size(134, 13);
            this.DarkLabel14.TabIndex = 0;
            this.DarkLabel14.Text = "Amount to heal or damage:";
            // 
            // DarkGroupBox6
            // 
            this.DarkGroupBox6.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox6.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox6.Controls.Add(this.nudY);
            this.DarkGroupBox6.Controls.Add(this.DarkLabel13);
            this.DarkGroupBox6.Controls.Add(this.nudX);
            this.DarkGroupBox6.Controls.Add(this.DarkLabel12);
            this.DarkGroupBox6.Controls.Add(this.cmbDir);
            this.DarkGroupBox6.Controls.Add(this.DarkLabel11);
            this.DarkGroupBox6.Controls.Add(this.nudMap);
            this.DarkGroupBox6.Controls.Add(this.DarkLabel10);
            this.DarkGroupBox6.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox6.Location = new System.Drawing.Point(6, 14);
            this.DarkGroupBox6.Name = "DarkGroupBox6";
            this.DarkGroupBox6.Size = new System.Drawing.Size(254, 78);
            this.DarkGroupBox6.TabIndex = 0;
            this.DarkGroupBox6.TabStop = false;
            this.DarkGroupBox6.Text = "Warp Settings";
            // 
            // nudY
            // 
            this.nudY.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudY.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudY.Location = new System.Drawing.Point(176, 45);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(69, 20);
            this.nudY.TabIndex = 7;
            // 
            // DarkLabel13
            // 
            this.DarkLabel13.AutoSize = true;
            this.DarkLabel13.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel13.Location = new System.Drawing.Point(118, 47);
            this.DarkLabel13.Name = "DarkLabel13";
            this.DarkLabel13.Size = new System.Drawing.Size(17, 13);
            this.DarkLabel13.TabIndex = 6;
            this.DarkLabel13.Text = "Y:";
            // 
            // nudX
            // 
            this.nudX.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudX.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudX.Location = new System.Drawing.Point(43, 45);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(69, 20);
            this.nudX.TabIndex = 5;
            // 
            // DarkLabel12
            // 
            this.DarkLabel12.AutoSize = true;
            this.DarkLabel12.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel12.Location = new System.Drawing.Point(6, 47);
            this.DarkLabel12.Name = "DarkLabel12";
            this.DarkLabel12.Size = new System.Drawing.Size(17, 13);
            this.DarkLabel12.TabIndex = 4;
            this.DarkLabel12.Text = "X:";
            // 
            // cmbDir
            // 
            this.cmbDir.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbDir.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbDir.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDir.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDir.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDir.FormattingEnabled = true;
            this.cmbDir.Items.AddRange(new object[] { "Up", "Down", "Left", "Right" });
            this.cmbDir.Location = new System.Drawing.Point(176, 18);
            this.cmbDir.Name = "cmbDir";
            this.cmbDir.Size = new System.Drawing.Size(69, 21);
            this.cmbDir.TabIndex = 3;
            // 
            // DarkLabel11
            // 
            this.DarkLabel11.AutoSize = true;
            this.DarkLabel11.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel11.Location = new System.Drawing.Point(118, 21);
            this.DarkLabel11.Name = "DarkLabel11";
            this.DarkLabel11.Size = new System.Drawing.Size(52, 13);
            this.DarkLabel11.TabIndex = 2;
            this.DarkLabel11.Text = "Direction:";
            // 
            // nudMap
            // 
            this.nudMap.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudMap.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMap.Location = new System.Drawing.Point(43, 19);
            this.nudMap.Name = "nudMap";
            this.nudMap.Size = new System.Drawing.Size(69, 20);
            this.nudMap.TabIndex = 1;
            // 
            // DarkLabel10
            // 
            this.DarkLabel10.AutoSize = true;
            this.DarkLabel10.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel10.Location = new System.Drawing.Point(6, 21);
            this.DarkLabel10.Name = "DarkLabel10";
            this.DarkLabel10.Size = new System.Drawing.Size(31, 13);
            this.DarkLabel10.TabIndex = 0;
            this.DarkLabel10.Text = "Map:";
            // 
            // DarkGroupBox3
            // 
            this.DarkGroupBox3.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox3.Controls.Add(this.chkKnockBack);
            this.DarkGroupBox3.Controls.Add(this.cmbKnockBackTiles);
            this.DarkGroupBox3.Controls.Add(this.cmbProjectile);
            this.DarkGroupBox3.Controls.Add(this.chkProjectile);
            this.DarkGroupBox3.Controls.Add(this.nudIcon);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel9);
            this.DarkGroupBox3.Controls.Add(this.picSprite);
            this.DarkGroupBox3.Controls.Add(this.nudCool);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel8);
            this.DarkGroupBox3.Controls.Add(this.nudCast);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel7);
            this.DarkGroupBox3.Controls.Add(this.DarkGroupBox4);
            this.DarkGroupBox3.Controls.Add(this.nudMp);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel3);
            this.DarkGroupBox3.Controls.Add(this.cmbType);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel2);
            this.DarkGroupBox3.Controls.Add(this.txtName);
            this.DarkGroupBox3.Controls.Add(this.DarkLabel1);
            this.DarkGroupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox3.Location = new System.Drawing.Point(6, 19);
            this.DarkGroupBox3.Name = "DarkGroupBox3";
            this.DarkGroupBox3.Size = new System.Drawing.Size(330, 323);
            this.DarkGroupBox3.TabIndex = 0;
            this.DarkGroupBox3.TabStop = false;
            this.DarkGroupBox3.Text = "Basic Settings";
            // 
            // chkKnockBack
            // 
            this.chkKnockBack.AutoSize = true;
            this.chkKnockBack.Location = new System.Drawing.Point(9, 158);
            this.chkKnockBack.Name = "chkKnockBack";
            this.chkKnockBack.Size = new System.Drawing.Size(114, 17);
            this.chkKnockBack.TabIndex = 61;
            this.chkKnockBack.Text = "Has knockback of";
            // 
            // cmbKnockBackTiles
            // 
            this.cmbKnockBackTiles.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbKnockBackTiles.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbKnockBackTiles.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbKnockBackTiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKnockBackTiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKnockBackTiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKnockBackTiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbKnockBackTiles.FormattingEnabled = true;
            this.cmbKnockBackTiles.Items.AddRange(new object[] { "No KnockBack", "1 Tile", "2 Tiles", "3 Tiles", "4 Tiles", "5 Tiles" });
            this.cmbKnockBackTiles.Location = new System.Drawing.Point(153, 156);
            this.cmbKnockBackTiles.Name = "cmbKnockBackTiles";
            this.cmbKnockBackTiles.Size = new System.Drawing.Size(171, 21);
            this.cmbKnockBackTiles.TabIndex = 60;
            // 
            // cmbProjectile
            // 
            this.cmbProjectile.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbProjectile.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbProjectile.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbProjectile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProjectile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProjectile.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbProjectile.FormattingEnabled = true;
            this.cmbProjectile.Location = new System.Drawing.Point(153, 129);
            this.cmbProjectile.Name = "cmbProjectile";
            this.cmbProjectile.Size = new System.Drawing.Size(171, 21);
            this.cmbProjectile.TabIndex = 59;
            // 
            // chkProjectile
            // 
            this.chkProjectile.AutoSize = true;
            this.chkProjectile.Location = new System.Drawing.Point(9, 131);
            this.chkProjectile.Name = "chkProjectile";
            this.chkProjectile.Size = new System.Drawing.Size(97, 17);
            this.chkProjectile.TabIndex = 58;
            this.chkProjectile.Text = "Has Projectile?";
            // 
            // nudIcon
            // 
            this.nudIcon.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudIcon.Location = new System.Drawing.Point(72, 93);
            this.nudIcon.Name = "nudIcon";
            this.nudIcon.Size = new System.Drawing.Size(80, 20);
            this.nudIcon.TabIndex = 57;
            // 
            // DarkLabel9
            // 
            this.DarkLabel9.AutoSize = true;
            this.DarkLabel9.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel9.Location = new System.Drawing.Point(6, 95);
            this.DarkLabel9.Name = "DarkLabel9";
            this.DarkLabel9.Size = new System.Drawing.Size(31, 13);
            this.DarkLabel9.TabIndex = 56;
            this.DarkLabel9.Text = "Icon:";
            // 
            // picSprite
            // 
            this.picSprite.BackColor = System.Drawing.Color.Black;
            this.picSprite.Location = new System.Drawing.Point(158, 91);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(32, 32);
            this.picSprite.TabIndex = 55;
            this.picSprite.TabStop = false;
            // 
            // nudCool
            // 
            this.nudCool.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudCool.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCool.Location = new System.Drawing.Point(247, 67);
            this.nudCool.Name = "nudCool";
            this.nudCool.Size = new System.Drawing.Size(77, 20);
            this.nudCool.TabIndex = 12;
            // 
            // DarkLabel8
            // 
            this.DarkLabel8.AutoSize = true;
            this.DarkLabel8.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel8.Location = new System.Drawing.Point(158, 69);
            this.DarkLabel8.Name = "DarkLabel8";
            this.DarkLabel8.Size = new System.Drawing.Size(83, 13);
            this.DarkLabel8.TabIndex = 11;
            this.DarkLabel8.Text = "Cooldown Time:";
            // 
            // nudCast
            // 
            this.nudCast.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudCast.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCast.Location = new System.Drawing.Point(72, 67);
            this.nudCast.Name = "nudCast";
            this.nudCast.Size = new System.Drawing.Size(80, 20);
            this.nudCast.TabIndex = 10;
            // 
            // DarkLabel7
            // 
            this.DarkLabel7.AutoSize = true;
            this.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel7.Location = new System.Drawing.Point(6, 69);
            this.DarkLabel7.Name = "DarkLabel7";
            this.DarkLabel7.Size = new System.Drawing.Size(57, 13);
            this.DarkLabel7.TabIndex = 9;
            this.DarkLabel7.Text = "Cast Time:";
            // 
            // DarkGroupBox4
            // 
            this.DarkGroupBox4.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.DarkGroupBox4.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.DarkGroupBox4.Controls.Add(this.DarkLabel6);
            this.DarkGroupBox4.Controls.Add(this.cmbClass);
            this.DarkGroupBox4.Controls.Add(this.cmbAccessReq);
            this.DarkGroupBox4.Controls.Add(this.DarkLabel5);
            this.DarkGroupBox4.Controls.Add(this.nudLevel);
            this.DarkGroupBox4.Controls.Add(this.DarkLabel4);
            this.DarkGroupBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox4.Location = new System.Drawing.Point(6, 227);
            this.DarkGroupBox4.Name = "DarkGroupBox4";
            this.DarkGroupBox4.Size = new System.Drawing.Size(318, 87);
            this.DarkGroupBox4.TabIndex = 8;
            this.DarkGroupBox4.TabStop = false;
            this.DarkGroupBox4.Text = "Requirements";
            // 
            // DarkLabel6
            // 
            this.DarkLabel6.AutoSize = true;
            this.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel6.Location = new System.Drawing.Point(6, 48);
            this.DarkLabel6.Name = "DarkLabel6";
            this.DarkLabel6.Size = new System.Drawing.Size(81, 13);
            this.DarkLabel6.TabIndex = 11;
            this.DarkLabel6.Text = "Class Required:";
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbClass.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbClass.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(94, 45);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(218, 21);
            this.cmbClass.TabIndex = 10;
            // 
            // cmbAccessReq
            // 
            this.cmbAccessReq.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbAccessReq.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbAccessReq.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAccessReq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAccessReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccessReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAccessReq.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAccessReq.FormattingEnabled = true;
            this.cmbAccessReq.Items.AddRange(new object[] { "Player", "Monitor", "Mapper", "Developer", "Creator" });
            this.cmbAccessReq.Location = new System.Drawing.Point(241, 18);
            this.cmbAccessReq.Name = "cmbAccessReq";
            this.cmbAccessReq.Size = new System.Drawing.Size(71, 21);
            this.cmbAccessReq.TabIndex = 9;
            // 
            // DarkLabel5
            // 
            this.DarkLabel5.AutoSize = true;
            this.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel5.Location = new System.Drawing.Point(144, 21);
            this.DarkLabel5.Name = "DarkLabel5";
            this.DarkLabel5.Size = new System.Drawing.Size(91, 13);
            this.DarkLabel5.TabIndex = 8;
            this.DarkLabel5.Text = "Access Required:";
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLevel.Location = new System.Drawing.Point(94, 19);
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(44, 20);
            this.nudLevel.TabIndex = 7;
            // 
            // DarkLabel4
            // 
            this.DarkLabel4.AutoSize = true;
            this.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel4.Location = new System.Drawing.Point(6, 21);
            this.DarkLabel4.Name = "DarkLabel4";
            this.DarkLabel4.Size = new System.Drawing.Size(82, 13);
            this.DarkLabel4.TabIndex = 6;
            this.DarkLabel4.Text = "Level Required:";
            // 
            // nudMp
            // 
            this.nudMp.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.nudMp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMp.Location = new System.Drawing.Point(247, 40);
            this.nudMp.Name = "nudMp";
            this.nudMp.Size = new System.Drawing.Size(77, 20);
            this.nudMp.TabIndex = 5;
            // 
            // DarkLabel3
            // 
            this.DarkLabel3.AutoSize = true;
            this.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel3.Location = new System.Drawing.Point(191, 43);
            this.DarkLabel3.Name = "DarkLabel3";
            this.DarkLabel3.Size = new System.Drawing.Size(50, 13);
            this.DarkLabel3.TabIndex = 4;
            this.DarkLabel3.Text = "MP Cost:";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.cmbType.BorderColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.cmbType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] { "Damage HP", "Damage MP", "Heal HP", "Heal MP", "Warp" });
            this.cmbType.Location = new System.Drawing.Point(72, 40);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(90, 21);
            this.cmbType.TabIndex = 3;
            // 
            // DarkLabel2
            // 
            this.DarkLabel2.AutoSize = true;
            this.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel2.Location = new System.Drawing.Point(6, 43);
            this.DarkLabel2.Name = "DarkLabel2";
            this.DarkLabel2.Size = new System.Drawing.Size(56, 13);
            this.DarkLabel2.TabIndex = 2;
            this.DarkLabel2.Text = "Skill Type:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(69)), System.Convert.ToInt32(System.Convert.ToByte(73)), System.Convert.ToInt32(System.Convert.ToByte(74)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.txtName.Location = new System.Drawing.Point(72, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 20);
            this.txtName.TabIndex = 1;
            // 
            // DarkLabel1
            // 
            this.DarkLabel1.AutoSize = true;
            this.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)), System.Convert.ToInt32(System.Convert.ToByte(220)));
            this.DarkLabel1.Location = new System.Drawing.Point(6, 16);
            this.DarkLabel1.Name = "DarkLabel1";
            this.DarkLabel1.Size = new System.Drawing.Size(60, 13);
            this.DarkLabel1.TabIndex = 0;
            this.DarkLabel1.Text = "Skill Name:";
            // 
            // frmEditor_Skill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(45)), System.Convert.ToInt32(System.Convert.ToByte(48)));
            this.ClientSize = new System.Drawing.Size(816, 401);
            this.ControlBox = false;
            this.Controls.Add(this.DarkGroupBox2);
            this.Controls.Add(this.DarkGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditor_Skill";
            this.Text = "Skill Editor";
            this.DarkGroupBox1.ResumeLayout(false);
            this.DarkGroupBox2.ResumeLayout(false);
            this.DarkGroupBox5.ResumeLayout(false);
            this.DarkGroupBox8.ResumeLayout(false);
            this.DarkGroupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudStun).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudAoE).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudRange).EndInit();
            this.DarkGroupBox7.ResumeLayout(false);
            this.DarkGroupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudVital).EndInit();
            this.DarkGroupBox6.ResumeLayout(false);
            this.DarkGroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudY).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudX).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudMap).EndInit();
            this.DarkGroupBox3.ResumeLayout(false);
            this.DarkGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picSprite).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudCool).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudCast).EndInit();
            this.DarkGroupBox4.ResumeLayout(false);
            this.DarkGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nudMp).EndInit();
            this.ResumeLayout(false);
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox1;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox1
        {
            
            get
            {
                return _DarkGroupBox1;
            }

            
            set
            {
                if (_DarkGroupBox1 != null)
                {
                }

                _DarkGroupBox1 = value;
                if (_DarkGroupBox1 != null)
                {
                }
            }
        }

        private ListBox _lstIndex;

        internal ListBox lstIndex
        {
            
            get
            {
                return _lstIndex;
            }

            
            set
            {
                if (_lstIndex != null)
                {
                }

                _lstIndex = value;
                if (_lstIndex != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox2;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox2
        {
            
            get
            {
                return _DarkGroupBox2;
            }

            
            set
            {
                if (_DarkGroupBox2 != null)
                {
                }

                _DarkGroupBox2 = value;
                if (_DarkGroupBox2 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox3;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox3
        {
            
            get
            {
                return _DarkGroupBox3;
            }

            
            set
            {
                if (_DarkGroupBox3 != null)
                {
                }

                _DarkGroupBox3 = value;
                if (_DarkGroupBox3 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkTextBox _txtName;

        internal DarkUI.Controls.DarkTextBox txtName
        {
            
            get
            {
                return _txtName;
            }

            
            set
            {
                if (_txtName != null)
                {
                }

                _txtName = value;
                if (_txtName != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel1;

        internal DarkUI.Controls.DarkLabel DarkLabel1
        {
            
            get
            {
                return _DarkLabel1;
            }

            
            set
            {
                if (_DarkLabel1 != null)
                {
                }

                _DarkLabel1 = value;
                if (_DarkLabel1 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbType;

        internal DarkUI.Controls.DarkComboBox cmbType
        {
            
            get
            {
                return _cmbType;
            }

            
            set
            {
                if (_cmbType != null)
                {
                }

                _cmbType = value;
                if (_cmbType != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel2;

        internal DarkUI.Controls.DarkLabel DarkLabel2
        {
            
            get
            {
                return _DarkLabel2;
            }

            
            set
            {
                if (_DarkLabel2 != null)
                {
                }

                _DarkLabel2 = value;
                if (_DarkLabel2 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudMp;

        internal DarkUI.Controls.DarkNumericUpDown nudMp
        {
            
            get
            {
                return _nudMp;
            }

            
            set
            {
                if (_nudMp != null)
                {
                }

                _nudMp = value;
                if (_nudMp != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel3;

        internal DarkUI.Controls.DarkLabel DarkLabel3
        {
            
            get
            {
                return _DarkLabel3;
            }

            
            set
            {
                if (_DarkLabel3 != null)
                {
                }

                _DarkLabel3 = value;
                if (_DarkLabel3 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudLevel;

        internal DarkUI.Controls.DarkNumericUpDown nudLevel
        {
            
            get
            {
                return _nudLevel;
            }

            
            set
            {
                if (_nudLevel != null)
                {
                }

                _nudLevel = value;
                if (_nudLevel != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel4;

        internal DarkUI.Controls.DarkLabel DarkLabel4
        {
            
            get
            {
                return _DarkLabel4;
            }

            
            set
            {
                if (_DarkLabel4 != null)
                {
                }

                _DarkLabel4 = value;
                if (_DarkLabel4 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox4;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox4
        {
            
            get
            {
                return _DarkGroupBox4;
            }

            
            set
            {
                if (_DarkGroupBox4 != null)
                {
                }

                _DarkGroupBox4 = value;
                if (_DarkGroupBox4 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel5;

        internal DarkUI.Controls.DarkLabel DarkLabel5
        {
            
            get
            {
                return _DarkLabel5;
            }

            
            set
            {
                if (_DarkLabel5 != null)
                {
                }

                _DarkLabel5 = value;
                if (_DarkLabel5 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbAccessReq;

        internal DarkUI.Controls.DarkComboBox cmbAccessReq
        {
            
            get
            {
                return _cmbAccessReq;
            }

            
            set
            {
                if (_cmbAccessReq != null)
                {
                }

                _cmbAccessReq = value;
                if (_cmbAccessReq != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel6;

        internal DarkUI.Controls.DarkLabel DarkLabel6
        {
            
            get
            {
                return _DarkLabel6;
            }

            
            set
            {
                if (_DarkLabel6 != null)
                {
                }

                _DarkLabel6 = value;
                if (_DarkLabel6 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbClass;

        internal DarkUI.Controls.DarkComboBox cmbClass
        {
            
            get
            {
                return _cmbClass;
            }

            
            set
            {
                if (_cmbClass != null)
                {
                }

                _cmbClass = value;
                if (_cmbClass != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudCast;

        internal DarkUI.Controls.DarkNumericUpDown nudCast
        {
            
            get
            {
                return _nudCast;
            }

            
            set
            {
                if (_nudCast != null)
                {
                }

                _nudCast = value;
                if (_nudCast != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel7;

        internal DarkUI.Controls.DarkLabel DarkLabel7
        {
            
            get
            {
                return _DarkLabel7;
            }

            
            set
            {
                if (_DarkLabel7 != null)
                {
                }

                _DarkLabel7 = value;
                if (_DarkLabel7 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudCool;

        internal DarkUI.Controls.DarkNumericUpDown nudCool
        {
            
            get
            {
                return _nudCool;
            }

            
            set
            {
                if (_nudCool != null)
                {
                }

                _nudCool = value;
                if (_nudCool != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel8;

        internal DarkUI.Controls.DarkLabel DarkLabel8
        {
            
            get
            {
                return _DarkLabel8;
            }

            
            set
            {
                if (_DarkLabel8 != null)
                {
                }

                _DarkLabel8 = value;
                if (_DarkLabel8 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel9;

        internal DarkUI.Controls.DarkLabel DarkLabel9
        {
            
            get
            {
                return _DarkLabel9;
            }

            
            set
            {
                if (_DarkLabel9 != null)
                {
                }

                _DarkLabel9 = value;
                if (_DarkLabel9 != null)
                {
                }
            }
        }

        private PictureBox _picSprite;

        internal PictureBox picSprite
        {
            
            get
            {
                return _picSprite;
            }

            
            set
            {
                if (_picSprite != null)
                {
                }

                _picSprite = value;
                if (_picSprite != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudIcon;

        internal DarkUI.Controls.DarkNumericUpDown nudIcon
        {
            
            get
            {
                return _nudIcon;
            }

            
            set
            {
                if (_nudIcon != null)
                {
                }

                _nudIcon = value;
                if (_nudIcon != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkCheckBox _chkProjectile;

        internal DarkUI.Controls.DarkCheckBox chkProjectile
        {
            
            get
            {
                return _chkProjectile;
            }

            
            set
            {
                if (_chkProjectile != null)
                {
                }

                _chkProjectile = value;
                if (_chkProjectile != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbProjectile;

        internal DarkUI.Controls.DarkComboBox cmbProjectile
        {
            
            get
            {
                return _cmbProjectile;
            }

            
            set
            {
                if (_cmbProjectile != null)
                {
                }

                _cmbProjectile = value;
                if (_cmbProjectile != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkCheckBox _chkKnockBack;

        internal DarkUI.Controls.DarkCheckBox chkKnockBack
        {
            
            get
            {
                return _chkKnockBack;
            }

            
            set
            {
                if (_chkKnockBack != null)
                {
                }

                _chkKnockBack = value;
                if (_chkKnockBack != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbKnockBackTiles;

        internal DarkUI.Controls.DarkComboBox cmbKnockBackTiles
        {
            
            get
            {
                return _cmbKnockBackTiles;
            }

            
            set
            {
                if (_cmbKnockBackTiles != null)
                {
                }

                _cmbKnockBackTiles = value;
                if (_cmbKnockBackTiles != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox5;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox5
        {
            
            get
            {
                return _DarkGroupBox5;
            }

            
            set
            {
                if (_DarkGroupBox5 != null)
                {
                }

                _DarkGroupBox5 = value;
                if (_DarkGroupBox5 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox6;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox6
        {
            
            get
            {
                return _DarkGroupBox6;
            }

            
            set
            {
                if (_DarkGroupBox6 != null)
                {
                }

                _DarkGroupBox6 = value;
                if (_DarkGroupBox6 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudMap;

        internal DarkUI.Controls.DarkNumericUpDown nudMap
        {
            
            get
            {
                return _nudMap;
            }

            
            set
            {
                if (_nudMap != null)
                {
                }

                _nudMap = value;
                if (_nudMap != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel10;

        internal DarkUI.Controls.DarkLabel DarkLabel10
        {
            
            get
            {
                return _DarkLabel10;
            }

            
            set
            {
                if (_DarkLabel10 != null)
                {
                }

                _DarkLabel10 = value;
                if (_DarkLabel10 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel11;

        internal DarkUI.Controls.DarkLabel DarkLabel11
        {
            
            get
            {
                return _DarkLabel11;
            }

            
            set
            {
                if (_DarkLabel11 != null)
                {
                }

                _DarkLabel11 = value;
                if (_DarkLabel11 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbDir;

        internal DarkUI.Controls.DarkComboBox cmbDir
        {
            
            get
            {
                return _cmbDir;
            }

            
            set
            {
                if (_cmbDir != null)
                {
                }

                _cmbDir = value;
                if (_cmbDir != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudX;

        internal DarkUI.Controls.DarkNumericUpDown nudX
        {
            
            get
            {
                return _nudX;
            }

            
            set
            {
                if (_nudX != null)
                {
                }

                _nudX = value;
                if (_nudX != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel12;

        internal DarkUI.Controls.DarkLabel DarkLabel12
        {
            
            get
            {
                return _DarkLabel12;
            }

            
            set
            {
                if (_DarkLabel12 != null)
                {
                }

                _DarkLabel12 = value;
                if (_DarkLabel12 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudY;

        internal DarkUI.Controls.DarkNumericUpDown nudY
        {
            
            get
            {
                return _nudY;
            }

            
            set
            {
                if (_nudY != null)
                {
                }

                _nudY = value;
                if (_nudY != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel13;

        internal DarkUI.Controls.DarkLabel DarkLabel13
        {
            
            get
            {
                return _DarkLabel13;
            }

            
            set
            {
                if (_DarkLabel13 != null)
                {
                }

                _DarkLabel13 = value;
                if (_DarkLabel13 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox7;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox7
        {
            
            get
            {
                return _DarkGroupBox7;
            }

            
            set
            {
                if (_DarkGroupBox7 != null)
                {
                }

                _DarkGroupBox7 = value;
                if (_DarkGroupBox7 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudVital;

        internal DarkUI.Controls.DarkNumericUpDown nudVital
        {
            
            get
            {
                return _nudVital;
            }

            
            set
            {
                if (_nudVital != null)
                {
                }

                _nudVital = value;
                if (_nudVital != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel14;

        internal DarkUI.Controls.DarkLabel DarkLabel14
        {
            
            get
            {
                return _DarkLabel14;
            }

            
            set
            {
                if (_DarkLabel14 != null)
                {
                }

                _DarkLabel14 = value;
                if (_DarkLabel14 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudDuration;

        internal DarkUI.Controls.DarkNumericUpDown nudDuration
        {
            
            get
            {
                return _nudDuration;
            }

            
            set
            {
                if (_nudDuration != null)
                {
                }

                _nudDuration = value;
                if (_nudDuration != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel15;

        internal DarkUI.Controls.DarkLabel DarkLabel15
        {
            
            get
            {
                return _DarkLabel15;
            }

            
            set
            {
                if (_DarkLabel15 != null)
                {
                }

                _DarkLabel15 = value;
                if (_DarkLabel15 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudInterval;

        internal DarkUI.Controls.DarkNumericUpDown nudInterval
        {
            
            get
            {
                return _nudInterval;
            }

            
            set
            {
                if (_nudInterval != null)
                {
                }

                _nudInterval = value;
                if (_nudInterval != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel16;

        internal DarkUI.Controls.DarkLabel DarkLabel16
        {
            
            get
            {
                return _DarkLabel16;
            }

            
            set
            {
                if (_DarkLabel16 != null)
                {
                }

                _DarkLabel16 = value;
                if (_DarkLabel16 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkGroupBox _DarkGroupBox8;

        internal DarkUI.Controls.DarkGroupBox DarkGroupBox8
        {
            
            get
            {
                return _DarkGroupBox8;
            }

            
            set
            {
                if (_DarkGroupBox8 != null)
                {
                }

                _DarkGroupBox8 = value;
                if (_DarkGroupBox8 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel18;

        internal DarkUI.Controls.DarkLabel DarkLabel18
        {
            
            get
            {
                return _DarkLabel18;
            }

            
            set
            {
                if (_DarkLabel18 != null)
                {
                }

                _DarkLabel18 = value;
                if (_DarkLabel18 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudRange;

        internal DarkUI.Controls.DarkNumericUpDown nudRange
        {
            
            get
            {
                return _nudRange;
            }

            
            set
            {
                if (_nudRange != null)
                {
                }

                _nudRange = value;
                if (_nudRange != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel17;

        internal DarkUI.Controls.DarkLabel DarkLabel17
        {
            
            get
            {
                return _DarkLabel17;
            }

            
            set
            {
                if (_DarkLabel17 != null)
                {
                }

                _DarkLabel17 = value;
                if (_DarkLabel17 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkCheckBox _chkAoE;

        internal DarkUI.Controls.DarkCheckBox chkAoE
        {
            
            get
            {
                return _chkAoE;
            }

            
            set
            {
                if (_chkAoE != null)
                {
                }

                _chkAoE = value;
                if (_chkAoE != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel20;

        internal DarkUI.Controls.DarkLabel DarkLabel20
        {
            
            get
            {
                return _DarkLabel20;
            }

            
            set
            {
                if (_DarkLabel20 != null)
                {
                }

                _DarkLabel20 = value;
                if (_DarkLabel20 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudAoE;

        internal DarkUI.Controls.DarkNumericUpDown nudAoE
        {
            
            get
            {
                return _nudAoE;
            }

            
            set
            {
                if (_nudAoE != null)
                {
                }

                _nudAoE = value;
                if (_nudAoE != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel19;

        internal DarkUI.Controls.DarkLabel DarkLabel19
        {
            
            get
            {
                return _DarkLabel19;
            }

            
            set
            {
                if (_DarkLabel19 != null)
                {
                }

                _DarkLabel19 = value;
                if (_DarkLabel19 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkNumericUpDown _nudStun;

        internal DarkUI.Controls.DarkNumericUpDown nudStun
        {
            
            get
            {
                return _nudStun;
            }

            
            set
            {
                if (_nudStun != null)
                {
                }

                _nudStun = value;
                if (_nudStun != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel21;

        internal DarkUI.Controls.DarkLabel DarkLabel21
        {
            
            get
            {
                return _DarkLabel21;
            }

            
            set
            {
                if (_DarkLabel21 != null)
                {
                }

                _DarkLabel21 = value;
                if (_DarkLabel21 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel22;

        internal DarkUI.Controls.DarkLabel DarkLabel22
        {
            
            get
            {
                return _DarkLabel22;
            }

            
            set
            {
                if (_DarkLabel22 != null)
                {
                }

                _DarkLabel22 = value;
                if (_DarkLabel22 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbAnimCast;

        internal DarkUI.Controls.DarkComboBox cmbAnimCast
        {
            
            get
            {
                return _cmbAnimCast;
            }

            
            set
            {
                if (_cmbAnimCast != null)
                {
                }

                _cmbAnimCast = value;
                if (_cmbAnimCast != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkComboBox _cmbAnim;

        internal DarkUI.Controls.DarkComboBox cmbAnim
        {
            
            get
            {
                return _cmbAnim;
            }

            
            set
            {
                if (_cmbAnim != null)
                {
                }

                _cmbAnim = value;
                if (_cmbAnim != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkLabel _DarkLabel23;

        internal DarkUI.Controls.DarkLabel DarkLabel23
        {
            
            get
            {
                return _DarkLabel23;
            }

            
            set
            {
                if (_DarkLabel23 != null)
                {
                }

                _DarkLabel23 = value;
                if (_DarkLabel23 != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkButton _btnDelete;

        internal DarkUI.Controls.DarkButton btnDelete
        {
            
            get
            {
                return _btnDelete;
            }

            
            set
            {
                if (_btnDelete != null)
                {
                }

                _btnDelete = value;
                if (_btnDelete != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkButton _btnCancel;

        internal DarkUI.Controls.DarkButton btnCancel
        {
            
            get
            {
                return _btnCancel;
            }

            
            set
            {
                if (_btnCancel != null)
                {
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                }
            }
        }

        private DarkUI.Controls.DarkButton _btnSave;

        internal DarkUI.Controls.DarkButton btnSave
        {
            
            get
            {
                return _btnSave;
            }

            
            set
            {
                if (_btnSave != null)
                {
                }

                _btnSave = value;
                if (_btnSave != null)
                {
                }
            }
        }
    }
}
