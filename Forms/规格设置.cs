﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WY_App.Utility;
using static WY_App.Utility.Parameter;
using Parameter = WY_App.Utility.Parameter;

namespace WY_App
{
    public partial class 规格设置 : Form
    {
        public 规格设置()
        {
            InitializeComponent();
        }

        private void btn_Close_System_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point downPoint;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            num_胶宽value.Enabled = true;
            num_胶宽min.Enabled = true;
            num_胶宽max.Enabled = true;
            num_胶宽adjustN1.Enabled = true;
            num_胶宽adjustN2.Enabled = true;

            num_胶高value.Enabled = true;
            num_胶高min.Enabled = true;
            num_胶高max.Enabled = true;
            num_胶高adjustN1.Enabled = true;
            num_胶高adjustN2.Enabled = true;

            num_胶线value.Enabled = true;
            num_胶线min.Enabled = true;
            num_胶线max.Enabled = true;
            num_胶线adjustN1.Enabled = true;
            num_胶线adjustN2.Enabled = true;

            uiDouble00.Enabled = true;
            uiDouble01.Enabled = true;
            uiDouble02.Enabled = true;
            uiDouble03.Enabled = true;
            uiDouble04.Enabled = true;

            uiDouble10.Enabled = true;
            uiDouble11.Enabled = true;
            uiDouble12.Enabled = true;
            uiDouble13.Enabled = true;
            uiDouble14.Enabled = true;

            uiDouble20.Enabled = true;
            uiDouble21.Enabled = true;
            uiDouble22.Enabled = true;
            uiDouble23.Enabled = true;
            uiDouble24.Enabled = true;

            uiDouble30.Enabled = true;
            uiDouble31.Enabled = true;
            uiDouble32.Enabled = true;
            uiDouble33.Enabled = true;
            uiDouble34.Enabled = true;

            uiDouble40.Enabled = true;
            uiDouble41.Enabled = true;
            uiDouble42.Enabled = true;
            uiDouble43.Enabled = true;
            uiDouble44.Enabled = true;
            btn_Save.Enabled = true;

        }

        private void ParamSettings_Load(object sender, EventArgs e)
        {
            num_胶宽value.Value = Parameter.specificationsCam1[0].胶宽.value;
            num_胶宽min.Value = Parameter.specificationsCam1[0].胶宽.min;
            num_胶宽max.Value = Parameter.specificationsCam1[0].胶宽.max;
            num_胶宽adjustN1.Value = Parameter.specificationsCam1[0].胶宽.adjust;
            num_胶高adjustN2.Value = Parameter.specificationsCam1[1].胶宽.adjust;

            num_胶高value.Value = Parameter.specificationsCam1[0].胶高.value;
            num_胶高min.Value = Parameter.specificationsCam1[0].胶高.min;
            num_胶高max.Value = Parameter.specificationsCam1[0].胶高.max;
            num_胶高adjustN1.Value = Parameter.specificationsCam1[0].胶高.adjust;
            num_胶高adjustN2.Value = Parameter.specificationsCam1[1].胶高.adjust;

            num_胶线value.Value = Parameter.specificationsCam1[0].胶线.value;
            num_胶线min.Value = Parameter.specificationsCam1[0].胶线.min;
            num_胶线max.Value = Parameter.specificationsCam1[0].胶线.max;
            num_胶线adjustN1.Value = Parameter.specificationsCam1[0].胶线.adjust;
            num_胶线adjustN2.Value = Parameter.specificationsCam1[1].胶线.adjust;

            uiDouble00.Value = Parameter.specificationsCam2[0].料长.min;
            uiDouble01.Value = Parameter.specificationsCam2[0].料长.value;
            uiDouble02.Value = Parameter.specificationsCam2[0].料长.max;
            uiDouble03.Value = Parameter.specificationsCam2[0].料长.adjust;
            uiDouble04.Value = Parameter.specificationsCam2[1].料长.adjust;

            uiDouble10.Value = Parameter.specificationsCam2[0].料宽.min;
            uiDouble11.Value = Parameter.specificationsCam2[0].料宽.value;
            uiDouble12.Value = Parameter.specificationsCam2[0].料宽.max;
            uiDouble13.Value = Parameter.specificationsCam2[0].料宽.adjust;
            uiDouble14.Value = Parameter.specificationsCam2[1].料宽.adjust;

            uiDouble20.Value = Parameter.specificationsCam2[0].胶宽.min;
            uiDouble21.Value = Parameter.specificationsCam2[0].胶宽.value;
            uiDouble22.Value = Parameter.specificationsCam2[0].胶宽.max;
            uiDouble23.Value = Parameter.specificationsCam2[0].胶宽.adjust;
            uiDouble24.Value = Parameter.specificationsCam2[1].胶宽.adjust;

            uiDouble30.Value = Parameter.specificationsCam2[0].长端.min;
            uiDouble31.Value = Parameter.specificationsCam2[0].长端.value;
            uiDouble32.Value = Parameter.specificationsCam2[0].长端.max;
            uiDouble33.Value = Parameter.specificationsCam2[0].长端.adjust;
            uiDouble34.Value = Parameter.specificationsCam2[1].长端.adjust;

            uiDouble40.Value = Parameter.specificationsCam2[0].短端.min;
            uiDouble41.Value = Parameter.specificationsCam2[0].短端.value;
            uiDouble42.Value = Parameter.specificationsCam2[0].短端.max;
            uiDouble43.Value = Parameter.specificationsCam2[0].短端.adjust;
            uiDouble44.Value = Parameter.specificationsCam2[1].短端.adjust;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Parameter.specificationsCam1[0].胶宽.value =  num_胶宽value.Value;
            Parameter.specificationsCam1[0].胶宽.min =    num_胶宽min.Value;
            Parameter.specificationsCam1[0].胶宽.max =    num_胶宽max.Value;
            Parameter.specificationsCam1[0].胶宽.adjust = num_胶宽adjustN1.Value;
            Parameter.specificationsCam1[1].胶宽.adjust = num_胶宽adjustN2.Value;

            Parameter.specificationsCam1[0].胶高.value =  num_胶高value.Value;
            Parameter.specificationsCam1[0].胶高.min =    num_胶高min.Value;
            Parameter.specificationsCam1[0].胶高.max =    num_胶高max.Value;
            Parameter.specificationsCam1[0].胶高.adjust = num_胶高adjustN1.Value;
            Parameter.specificationsCam1[1].胶高.adjust = num_胶高adjustN2.Value;

            Parameter.specificationsCam1[0].胶线.value =  num_胶线value.Value;
            Parameter.specificationsCam1[0].胶线.min =    num_胶线min.Value;
            Parameter.specificationsCam1[0].胶线.max =    num_胶线max.Value;
            Parameter.specificationsCam1[0].胶线.adjust = num_胶线adjustN1.Value;
            Parameter.specificationsCam1[1].胶线.adjust = num_胶线adjustN2.Value;

            Parameter.specificationsCam2[0].料长.min = uiDouble00.Value;
            Parameter.specificationsCam2[0].料长.value = uiDouble01.Value;
            Parameter.specificationsCam2[0].料长.max = uiDouble02.Value;
            Parameter.specificationsCam2[0].料长.adjust = uiDouble03.Value;
            Parameter.specificationsCam2[1].料长.adjust = uiDouble04.Value;

            Parameter.specificationsCam2[0].料宽.min = uiDouble10.Value;
            Parameter.specificationsCam2[0].料宽.value = uiDouble11.Value;
            Parameter.specificationsCam2[0].料宽.max = uiDouble12.Value;
            Parameter.specificationsCam2[0].料宽.adjust = uiDouble13.Value;
            Parameter.specificationsCam2[1].料宽.adjust = uiDouble14.Value;

            Parameter.specificationsCam2[0].胶宽.min = uiDouble20.Value;
            Parameter.specificationsCam2[0].胶宽.value = uiDouble21.Value;
            Parameter.specificationsCam2[0].胶宽.max = uiDouble22.Value;
            Parameter.specificationsCam2[0].胶宽.adjust = uiDouble23.Value;
            Parameter.specificationsCam2[1].胶宽.adjust = uiDouble24.Value;

            Parameter.specificationsCam2[0].长端.min = uiDouble30.Value;
            Parameter.specificationsCam2[0].长端.value = uiDouble31.Value;
            Parameter.specificationsCam2[0].长端.max = uiDouble32.Value;
            Parameter.specificationsCam2[0].长端.adjust = uiDouble33.Value;
            Parameter.specificationsCam2[1].长端.adjust = uiDouble34.Value;

            Parameter.specificationsCam2[0].短端.min = uiDouble40.Value;
            Parameter.specificationsCam2[0].短端.value = uiDouble41.Value;
            Parameter.specificationsCam2[0].短端.max = uiDouble42.Value;
            Parameter.specificationsCam2[0].短端.adjust = uiDouble43.Value;
            Parameter.specificationsCam2[1].短端.adjust = uiDouble44.Value;

            XMLHelper.serialize<Parameter.SpecificationsCam1>(Parameter.specificationsCam1[0], "Parameter/Cam1Specifications0.xml");
            XMLHelper.serialize<Parameter.SpecificationsCam1>(Parameter.specificationsCam1[1], "Parameter/Cam1Specifications1.xml");
            XMLHelper.serialize<Parameter.SpecificationsCam2>(Parameter.specificationsCam2[0], "Parameter/Cam2Specifications0.xml");
            XMLHelper.serialize<Parameter.SpecificationsCam2>(Parameter.specificationsCam2[1], "Parameter/Cam2Specifications1.xml");
            MessageBox.Show("系统参数修改，请重启软件");
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
