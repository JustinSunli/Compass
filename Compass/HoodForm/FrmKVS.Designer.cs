﻿namespace Compass
{
    partial class FrmKVS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKVS));
            this.btnEditData = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cobLightType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtExHeight = new System.Windows.Forms.TextBox();
            this.txtExWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cobExNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExDis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExLength = new System.Windows.Forms.TextBox();
            this.txtExDis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeepth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.pbModelImage = new System.Windows.Forms.PictureBox();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditData
            // 
            this.btnEditData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnEditData.FlatAppearance.BorderSize = 0;
            this.btnEditData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditData.ForeColor = System.Drawing.Color.White;
            this.btnEditData.Location = new System.Drawing.Point(651, 616);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(122, 36);
            this.btnEditData.TabIndex = 3;
            this.btnEditData.Text = "修改参数";
            this.btnEditData.UseVisualStyleBackColor = false;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.cobLightType);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(779, 517);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(398, 135);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "烟罩配置";
            // 
            // cobLightType
            // 
            this.cobLightType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cobLightType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobLightType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobLightType.BackColor = System.Drawing.Color.Azure;
            this.cobLightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobLightType.FormattingEnabled = true;
            this.cobLightType.Location = new System.Drawing.Point(92, 25);
            this.cobLightType.Name = "cobLightType";
            this.cobLightType.Size = new System.Drawing.Size(100, 27);
            this.cobLightType.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "灯具类型";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.txtExHeight);
            this.groupBox6.Controls.Add(this.txtExWidth);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.cobExNo);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.lblExDis);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtExLength);
            this.groupBox6.Controls.Add(this.txtExDis);
            this.groupBox6.Location = new System.Drawing.Point(251, 517);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(394, 135);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "排风脖颈";
            // 
            // txtExHeight
            // 
            this.txtExHeight.BackColor = System.Drawing.Color.Azure;
            this.txtExHeight.Location = new System.Drawing.Point(268, 95);
            this.txtExHeight.Name = "txtExHeight";
            this.txtExHeight.Size = new System.Drawing.Size(100, 25);
            this.txtExHeight.TabIndex = 4;
            // 
            // txtExWidth
            // 
            this.txtExWidth.BackColor = System.Drawing.Color.Azure;
            this.txtExWidth.Location = new System.Drawing.Point(268, 60);
            this.txtExWidth.Name = "txtExWidth";
            this.txtExWidth.Size = new System.Drawing.Size(100, 25);
            this.txtExWidth.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "脖颈高度";
            // 
            // cobExNo
            // 
            this.cobExNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobExNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobExNo.BackColor = System.Drawing.Color.Azure;
            this.cobExNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobExNo.FormattingEnabled = true;
            this.cobExNo.Location = new System.Drawing.Point(94, 60);
            this.cobExNo.Name = "cobExNo";
            this.cobExNo.Size = new System.Drawing.Size(100, 27);
            this.cobExNo.TabIndex = 0;
            this.cobExNo.SelectedIndexChanged += new System.EventHandler(this.cobExNo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "脖颈宽度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "脖颈长度";
            // 
            // lblExDis
            // 
            this.lblExDis.AutoSize = true;
            this.lblExDis.Location = new System.Drawing.Point(6, 103);
            this.lblExDis.Name = "lblExDis";
            this.lblExDis.Size = new System.Drawing.Size(87, 19);
            this.lblExDis.TabIndex = 2;
            this.lblExDis.Text = "排风脖颈间距";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "排风脖颈数量";
            // 
            // txtExLength
            // 
            this.txtExLength.BackColor = System.Drawing.Color.Azure;
            this.txtExLength.Location = new System.Drawing.Point(268, 25);
            this.txtExLength.Name = "txtExLength";
            this.txtExLength.Size = new System.Drawing.Size(100, 25);
            this.txtExLength.TabIndex = 2;
            // 
            // txtExDis
            // 
            this.txtExDis.BackColor = System.Drawing.Color.Azure;
            this.txtExDis.Location = new System.Drawing.Point(94, 97);
            this.txtExDis.Name = "txtExDis";
            this.txtExDis.Size = new System.Drawing.Size(100, 25);
            this.txtExDis.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "无需减侧板";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDeepth);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 517);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "烟罩尺寸及侧板";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "烟罩深度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "烟罩长度";
            // 
            // txtDeepth
            // 
            this.txtDeepth.BackColor = System.Drawing.Color.Azure;
            this.txtDeepth.Location = new System.Drawing.Point(79, 58);
            this.txtDeepth.Name = "txtDeepth";
            this.txtDeepth.Size = new System.Drawing.Size(100, 25);
            this.txtDeepth.TabIndex = 1;
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.Azure;
            this.txtLength.Location = new System.Drawing.Point(79, 25);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 25);
            this.txtLength.TabIndex = 0;
            // 
            // pbModelImage
            // 
            this.pbModelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbModelImage.Image = global::Compass.Properties.Resources.NoPic;
            this.pbModelImage.Location = new System.Drawing.Point(23, 63);
            this.pbModelImage.Name = "pbModelImage";
            this.pbModelImage.Size = new System.Drawing.Size(750, 445);
            this.pbModelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModelImage.TabIndex = 8;
            this.pbModelImage.TabStop = false;
            // 
            // FrmKVS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbModelImage);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 675);
            this.Name = "FrmKVS";
            this.Text = "KVS";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModelImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cobLightType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtExHeight;
        private System.Windows.Forms.TextBox txtExWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cobExNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExDis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExLength;
        private System.Windows.Forms.TextBox txtExDis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeepth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.PictureBox pbModelImage;
        private System.Windows.Forms.Label label3;
    }
}