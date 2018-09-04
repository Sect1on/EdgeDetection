using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace EdgeDetection
{
    public partial class frmMain : Form
    {
        Image<Bgr, byte> picOriginal = new Image<Bgr, byte>(@"..\..\..\..\pic\pic1.jpg");//从文件加载图片
        Image<Gray, byte> picGary;
        Image<Gray, byte> picBinary;
        Image<Gray, byte> picEdgeDetection;
        Image<Gray, byte> picResult;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GC.Collect();
            //图像处理实现
            picGary = picOriginal.Convert<Gray, Byte>();//灰度化
            picResult = picGary.Copy();
            picBinary = picGary.Copy();
            picEdgeDetection = picGary.Copy();
            picBinary = picGary.ThresholdBinary(new Gray(int.Parse(txtBinaryThreshold.Text)), new Gray(255));//二值化
            //picEdgeDetection = picBinary.Canny(int.Parse(txtCannyUpValue.Text), int.Parse(txtCannyDownValue.Text));//canny边缘检测（备用）
            CvInvoke.cvCanny(picBinary, picEdgeDetection, int.Parse(txtCannyDownValue.Text), int.Parse(txtCannyUpValue.Text), 3);//canny边缘检测
            CvInvoke.cvDilate(picEdgeDetection,picResult,IntPtr.Zero,int.Parse(txtDilateTimes.Text));//膨胀

            //显示相关
            picboxOriginal.Image = picOriginal.Bitmap;
            btnReg.Image = picBinary.Bitmap;
            picboxEdgeDetection.Image = picEdgeDetection.Bitmap;
            picboxResult.Image = picResult.Bitmap;
            picboxRGStartPoint.Image = picGary.Bitmap;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //部分参数初始化
            txtBinaryThreshold.Text = "30";
            txtCannyDownValue.Text = "30";
            txtCannyUpValue.Text = "80";
            txtDilateTimes.Text = "1";
            txtRGSPX.Text = "";
            txtRGSPY.Text = "";
        }

        private void picboxRGStartPoint_MouseDown(object sender, MouseEventArgs e)
        {
            txtRGSPX.Text = (Math.Round(e.X*4.18)).ToString();
            txtRGSPY.Text = (Math.Round(e.Y*4.33)).ToString();
        }

        private void btnRegionGrow_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Image<Bgr, byte> picRegionGrow = new Image<Bgr, byte>(1920,1080, new Bgr(0,0,0));
            int SeedGrayLevel;
            int PointGrayLevel;

            if(txtRGSPX.Text==""||txtRGSPY.Text=="")
            {
                MessageBox.Show("警告！您还没选择区域增长起点！");
            }
            int StartPointX = int.Parse(txtRGSPX.Text);
            int StartPointY = int.Parse(txtRGSPY.Text);
            Color Seed = picGary.Bitmap.GetPixel(StartPointX, StartPointY);
            SeedGrayLevel = Seed.B;

            //起始点向左上延拓
            int i = StartPointX;
            int j = StartPointY;

            for (i = StartPointX; i > 1; i--)//施工中
            {
                for (j = StartPointY; j > 1; j--)
                {

                }
            }
            //起始点向右上延拓
            //for (int i = StartPointX; i < 1910; i++)
            //{
            //    for (int j = StartPointY; j > 1; j--)
            //    {
            //        Color GrayLevel = picGary.Bitmap.GetPixel(i, j);
            //        PointGrayLevel = GrayLevel.B;
            //        if (Math.Abs(PointGrayLevel - SeedGrayLevel) < 10)
            //        {
            //            picRegionGrow.Bitmap.SetPixel(i, j, Color.White);
            //            continue;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            ////起始点向左下延拓
            //for (int i = StartPointX; i > 1; i--)
            //{
            //    for (int j = StartPointY; j < 1070; j++)
            //    {
            //        Color GrayLevel = picGary.Bitmap.GetPixel(i, j);
            //        PointGrayLevel = GrayLevel.B;
            //        if (Math.Abs(PointGrayLevel - SeedGrayLevel) < 10)
            //        {
            //            picRegionGrow.Bitmap.SetPixel(i, j, Color.White);
            //            continue;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            ////起始点向右下延拓
            //for (int i = StartPointX; i < 1910; i++)
            //{
            //    for (int j = StartPointY; j < 1070; j++)
            //    {
            //        Color GrayLevel = picGary.Bitmap.GetPixel(i, j);
            //        PointGrayLevel = GrayLevel.B;
            //        if (Math.Abs(PointGrayLevel - SeedGrayLevel) < 10)
            //        {
            //            picRegionGrow.Bitmap.SetPixel(i, j, Color.White);
            //            continue;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}


            picboxRegionGrow.Image = picRegionGrow.Bitmap;

























































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































        }
    }
}
