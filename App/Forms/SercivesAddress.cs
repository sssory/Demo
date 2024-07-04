using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace App.Forms
{
    public partial class SercivesAddress : Form
    {
        public SercivesAddress()
        {
            InitializeComponent();
            LoadNowSetting();
        }

        private void LoadNowSetting()
        {
            List<string> sourcePort = new List<string>();
            sourcePort.Add("");
            sourcePort.Add("8097");
            sourcePort.Add("8098");
            cbbPort.DataSource=sourcePort;
            cbbPort.SelectedItem = AppConfig.Get("WebAPIPort");
            txtIP.Text = AppConfig.Get("WebAPIIP");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //1 验证输入
            string port = cbbPort.Text;

            int outPort = 0;
            if (!int.TryParse(port, out outPort))
            {
                MessageBox.Show("请选择端口");
                return;
            }

            if (outPort < 1024 || outPort > 49151)
            {
                MessageBox.Show("端口范围1024-49151");
                return;
            }

            //2 保存设置
            AppConfig.Set("WebAPIPort",port);

            //3 重启服务
            WebApiSercives.sercives.Stop();
            WebApiSercives.sercives.Start();

            MessageBox.Show("保存成功");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SercivesAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }
    }
}
