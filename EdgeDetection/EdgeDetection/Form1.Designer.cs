namespace EdgeDetection
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picboxOriginal = new System.Windows.Forms.PictureBox();
            this.lblOringnPic = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.PictureBox();
            this.lblBinary = new System.Windows.Forms.Label();
            this.picboxEdgeDetection = new System.Windows.Forms.PictureBox();
            this.picboxResult = new System.Windows.Forms.PictureBox();
            this.lblEdgeDetection = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBinaryThreshold = new System.Windows.Forms.Label();
            this.txtBinaryThreshold = new System.Windows.Forms.TextBox();
            this.lblCannyDownValue = new System.Windows.Forms.Label();
            this.txtCannyDownValue = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblCannyUpValue = new System.Windows.Forms.Label();
            this.txtCannyUpValue = new System.Windows.Forms.TextBox();
            this.lblDilateTimes = new System.Windows.Forms.Label();
            this.txtDilateTimes = new System.Windows.Forms.TextBox();
            this.picboxRGStartPoint = new System.Windows.Forms.PictureBox();
            this.picboxRegionGrow = new System.Windows.Forms.PictureBox();
            this.lblRGStartPoint = new System.Windows.Forms.Label();
            this.lblRegionGrow = new System.Windows.Forms.Label();
            this.lblRGSPX = new System.Windows.Forms.Label();
            this.txtRGSPX = new System.Windows.Forms.TextBox();
            this.lblRGSPY = new System.Windows.Forms.Label();
            this.txtRGSPY = new System.Windows.Forms.TextBox();
            this.btnRegionGrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEdgeDetection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRGStartPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRegionGrow)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxOriginal
            // 
            this.picboxOriginal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picboxOriginal.Location = new System.Drawing.Point(12, 24);
            this.picboxOriginal.Name = "picboxOriginal";
            this.picboxOriginal.Size = new System.Drawing.Size(460, 250);
            this.picboxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxOriginal.TabIndex = 0;
            this.picboxOriginal.TabStop = false;
            // 
            // lblOringnPic
            // 
            this.lblOringnPic.AutoSize = true;
            this.lblOringnPic.Location = new System.Drawing.Point(10, 9);
            this.lblOringnPic.Name = "lblOringnPic";
            this.lblOringnPic.Size = new System.Drawing.Size(41, 12);
            this.lblOringnPic.TabIndex = 1;
            this.lblOringnPic.Text = "原图：";
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReg.Location = new System.Drawing.Point(478, 24);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(460, 250);
            this.btnReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReg.TabIndex = 2;
            this.btnReg.TabStop = false;
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Location = new System.Drawing.Point(476, 9);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(53, 12);
            this.lblBinary.TabIndex = 3;
            this.lblBinary.Text = "二值化：";
            // 
            // picboxEdgeDetection
            // 
            this.picboxEdgeDetection.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picboxEdgeDetection.Location = new System.Drawing.Point(12, 292);
            this.picboxEdgeDetection.Name = "picboxEdgeDetection";
            this.picboxEdgeDetection.Size = new System.Drawing.Size(460, 250);
            this.picboxEdgeDetection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEdgeDetection.TabIndex = 4;
            this.picboxEdgeDetection.TabStop = false;
            // 
            // picboxResult
            // 
            this.picboxResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picboxResult.Location = new System.Drawing.Point(478, 292);
            this.picboxResult.Name = "picboxResult";
            this.picboxResult.Size = new System.Drawing.Size(460, 250);
            this.picboxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxResult.TabIndex = 5;
            this.picboxResult.TabStop = false;
            // 
            // lblEdgeDetection
            // 
            this.lblEdgeDetection.AutoSize = true;
            this.lblEdgeDetection.Location = new System.Drawing.Point(12, 277);
            this.lblEdgeDetection.Name = "lblEdgeDetection";
            this.lblEdgeDetection.Size = new System.Drawing.Size(65, 12);
            this.lblEdgeDetection.TabIndex = 6;
            this.lblEdgeDetection.Text = "边缘检测：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(476, 277);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(65, 12);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "最终结果：";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(973, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1070, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblBinaryThreshold
            // 
            this.lblBinaryThreshold.AutoSize = true;
            this.lblBinaryThreshold.Location = new System.Drawing.Point(971, 74);
            this.lblBinaryThreshold.Name = "lblBinaryThreshold";
            this.lblBinaryThreshold.Size = new System.Drawing.Size(77, 12);
            this.lblBinaryThreshold.TabIndex = 10;
            this.lblBinaryThreshold.Text = "二值化阈值：";
            // 
            // txtBinaryThreshold
            // 
            this.txtBinaryThreshold.Location = new System.Drawing.Point(1045, 71);
            this.txtBinaryThreshold.Name = "txtBinaryThreshold";
            this.txtBinaryThreshold.Size = new System.Drawing.Size(100, 21);
            this.txtBinaryThreshold.TabIndex = 11;
            this.txtBinaryThreshold.Text = "30";
            // 
            // lblCannyDownValue
            // 
            this.lblCannyDownValue.AutoSize = true;
            this.lblCannyDownValue.Location = new System.Drawing.Point(971, 107);
            this.lblCannyDownValue.Name = "lblCannyDownValue";
            this.lblCannyDownValue.Size = new System.Drawing.Size(71, 12);
            this.lblCannyDownValue.TabIndex = 12;
            this.lblCannyDownValue.Text = "Canny下限：";
            // 
            // txtCannyDownValue
            // 
            this.txtCannyDownValue.Location = new System.Drawing.Point(1045, 104);
            this.txtCannyDownValue.Name = "txtCannyDownValue";
            this.txtCannyDownValue.Size = new System.Drawing.Size(100, 21);
            this.txtCannyDownValue.TabIndex = 13;
            this.txtCannyDownValue.Text = "30";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(963, 277);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(85, 23);
            this.btnReload.TabIndex = 14;
            this.btnReload.Text = "恢复默认设置";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblCannyUpValue
            // 
            this.lblCannyUpValue.AutoSize = true;
            this.lblCannyUpValue.Location = new System.Drawing.Point(971, 138);
            this.lblCannyUpValue.Name = "lblCannyUpValue";
            this.lblCannyUpValue.Size = new System.Drawing.Size(71, 12);
            this.lblCannyUpValue.TabIndex = 15;
            this.lblCannyUpValue.Text = "Canny上限：";
            // 
            // txtCannyUpValue
            // 
            this.txtCannyUpValue.Location = new System.Drawing.Point(1045, 135);
            this.txtCannyUpValue.Name = "txtCannyUpValue";
            this.txtCannyUpValue.Size = new System.Drawing.Size(100, 21);
            this.txtCannyUpValue.TabIndex = 16;
            this.txtCannyUpValue.Text = "80";
            // 
            // lblDilateTimes
            // 
            this.lblDilateTimes.AutoSize = true;
            this.lblDilateTimes.Location = new System.Drawing.Point(977, 173);
            this.lblDilateTimes.Name = "lblDilateTimes";
            this.lblDilateTimes.Size = new System.Drawing.Size(65, 12);
            this.lblDilateTimes.TabIndex = 17;
            this.lblDilateTimes.Text = "膨胀次数：";
            // 
            // txtDilateTimes
            // 
            this.txtDilateTimes.Location = new System.Drawing.Point(1045, 170);
            this.txtDilateTimes.Name = "txtDilateTimes";
            this.txtDilateTimes.Size = new System.Drawing.Size(100, 21);
            this.txtDilateTimes.TabIndex = 18;
            this.txtDilateTimes.Text = "1";
            // 
            // picboxRGStartPoint
            // 
            this.picboxRGStartPoint.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picboxRGStartPoint.Location = new System.Drawing.Point(12, 560);
            this.picboxRGStartPoint.Name = "picboxRGStartPoint";
            this.picboxRGStartPoint.Size = new System.Drawing.Size(460, 250);
            this.picboxRGStartPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxRGStartPoint.TabIndex = 19;
            this.picboxRGStartPoint.TabStop = false;
            this.picboxRGStartPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picboxRGStartPoint_MouseDown);
            // 
            // picboxRegionGrow
            // 
            this.picboxRegionGrow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picboxRegionGrow.Location = new System.Drawing.Point(478, 560);
            this.picboxRegionGrow.Name = "picboxRegionGrow";
            this.picboxRegionGrow.Size = new System.Drawing.Size(460, 250);
            this.picboxRegionGrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxRegionGrow.TabIndex = 20;
            this.picboxRegionGrow.TabStop = false;
            // 
            // lblRGStartPoint
            // 
            this.lblRGStartPoint.AutoSize = true;
            this.lblRGStartPoint.Location = new System.Drawing.Point(10, 545);
            this.lblRGStartPoint.Name = "lblRGStartPoint";
            this.lblRGStartPoint.Size = new System.Drawing.Size(89, 12);
            this.lblRGStartPoint.TabIndex = 21;
            this.lblRGStartPoint.Text = "区域增长起点：";
            // 
            // lblRegionGrow
            // 
            this.lblRegionGrow.AutoSize = true;
            this.lblRegionGrow.Location = new System.Drawing.Point(478, 545);
            this.lblRegionGrow.Name = "lblRegionGrow";
            this.lblRegionGrow.Size = new System.Drawing.Size(89, 12);
            this.lblRegionGrow.TabIndex = 22;
            this.lblRegionGrow.Text = "区域增长结果：";
            // 
            // lblRGSPX
            // 
            this.lblRGSPX.AutoSize = true;
            this.lblRGSPX.Location = new System.Drawing.Point(950, 207);
            this.lblRGSPX.Name = "lblRGSPX";
            this.lblRGSPX.Size = new System.Drawing.Size(89, 12);
            this.lblRGSPX.TabIndex = 23;
            this.lblRGSPX.Text = "区域增长起点X:";
            // 
            // txtRGSPX
            // 
            this.txtRGSPX.Location = new System.Drawing.Point(1045, 204);
            this.txtRGSPX.Name = "txtRGSPX";
            this.txtRGSPX.Size = new System.Drawing.Size(100, 21);
            this.txtRGSPX.TabIndex = 24;
            // 
            // lblRGSPY
            // 
            this.lblRGSPY.AutoSize = true;
            this.lblRGSPY.Location = new System.Drawing.Point(950, 240);
            this.lblRGSPY.Name = "lblRGSPY";
            this.lblRGSPY.Size = new System.Drawing.Size(89, 12);
            this.lblRGSPY.TabIndex = 25;
            this.lblRGSPY.Text = "区域增长起点Y:";
            // 
            // txtRGSPY
            // 
            this.txtRGSPY.Location = new System.Drawing.Point(1045, 237);
            this.txtRGSPY.Name = "txtRGSPY";
            this.txtRGSPY.Size = new System.Drawing.Size(100, 21);
            this.txtRGSPY.TabIndex = 26;
            // 
            // btnRegionGrow
            // 
            this.btnRegionGrow.Location = new System.Drawing.Point(1054, 277);
            this.btnRegionGrow.Name = "btnRegionGrow";
            this.btnRegionGrow.Size = new System.Drawing.Size(75, 23);
            this.btnRegionGrow.TabIndex = 27;
            this.btnRegionGrow.Text = "区域生长";
            this.btnRegionGrow.UseVisualStyleBackColor = true;
            this.btnRegionGrow.Click += new System.EventHandler(this.btnRegionGrow_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 821);
            this.Controls.Add(this.btnRegionGrow);
            this.Controls.Add(this.txtRGSPY);
            this.Controls.Add(this.lblRGSPY);
            this.Controls.Add(this.txtRGSPX);
            this.Controls.Add(this.lblRGSPX);
            this.Controls.Add(this.lblRegionGrow);
            this.Controls.Add(this.lblRGStartPoint);
            this.Controls.Add(this.picboxRegionGrow);
            this.Controls.Add(this.picboxRGStartPoint);
            this.Controls.Add(this.txtDilateTimes);
            this.Controls.Add(this.lblDilateTimes);
            this.Controls.Add(this.txtCannyUpValue);
            this.Controls.Add(this.lblCannyUpValue);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtCannyDownValue);
            this.Controls.Add(this.lblCannyDownValue);
            this.Controls.Add(this.txtBinaryThreshold);
            this.Controls.Add(this.lblBinaryThreshold);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEdgeDetection);
            this.Controls.Add(this.picboxResult);
            this.Controls.Add(this.picboxEdgeDetection);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lblOringnPic);
            this.Controls.Add(this.picboxOriginal);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.picboxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEdgeDetection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRGStartPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRegionGrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxOriginal;
        private System.Windows.Forms.Label lblOringnPic;
        private System.Windows.Forms.PictureBox btnReg;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.PictureBox picboxEdgeDetection;
        private System.Windows.Forms.PictureBox picboxResult;
        private System.Windows.Forms.Label lblEdgeDetection;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBinaryThreshold;
        private System.Windows.Forms.TextBox txtBinaryThreshold;
        private System.Windows.Forms.Label lblCannyDownValue;
        private System.Windows.Forms.TextBox txtCannyDownValue;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblCannyUpValue;
        private System.Windows.Forms.TextBox txtCannyUpValue;
        public System.Windows.Forms.Label lblDilateTimes;
        private System.Windows.Forms.TextBox txtDilateTimes;
        private System.Windows.Forms.PictureBox picboxRGStartPoint;
        private System.Windows.Forms.PictureBox picboxRegionGrow;
        private System.Windows.Forms.Label lblRGStartPoint;
        private System.Windows.Forms.Label lblRegionGrow;
        private System.Windows.Forms.Label lblRGSPX;
        private System.Windows.Forms.TextBox txtRGSPX;
        private System.Windows.Forms.Label lblRGSPY;
        private System.Windows.Forms.TextBox txtRGSPY;
        private System.Windows.Forms.Button btnRegionGrow;
    }
}

