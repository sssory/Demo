using Http;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DoSomething(LoadState);
        }
        #region menu

        private void menu_sercives_port_Click(object sender, EventArgs e)
        {

            Forms.SercivesAddress sercivesAddress = new Forms.SercivesAddress();
            sercivesAddress.StartPosition = FormStartPosition.CenterScreen;
            sercivesAddress.ShowDialog();
        }
        private void menu_sercives_open_Click(object sender, EventArgs e)
        {
            WebApiSercives.sercives.Start();
            LoadState();
        }
        private void menu_sercives_close_Click(object sender, EventArgs e)
        {
            WebApiSercives.sercives.Stop();
            LoadState();
        }
        private void menu_help_mysql_Click(object sender, EventArgs e)
        {
            //创建选项卡
            TabPage tabPage = new TabPage();
            tabPage.Text = "生成实体";


            tab_main.TabPages.Add(tabPage);

            FormControl.DBHelper helper = new FormControl.DBHelper();
            tabPage.Controls.Add(helper);

            helper.Height = tabPage.Height;
            helper.Width = tabPage.Width;
        }
        private void menu_help_backup_Click(object sender, EventArgs e)
        {
            //创建选项卡
            TabPage tabPage = new TabPage();
            tabPage.Text = "数据备份";


            tab_main.TabPages.Add(tabPage);

            FormControl.DBBackUP backup = new FormControl.DBBackUP();

            tabPage.Controls.Add(backup);

            backup.Height = tabPage.Height;
            backup.Width = tabPage.Width;
        } 
        private void menu_mail_send_Click(object sender, EventArgs e)
        {
            string userName = "15367308740@163.com";// 发送端账号   
            string password = "DLPTITBKPHTHRUJH";//授权码
            //string password = "!sfj980427";// 

            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式    
            client.Host = "smtp.163.com";// 邮件服务器smtp.163.com表示网易邮箱服务器    
            //client.Port = 587;//邮件服务器端口
            client.UseDefaultCredentials = true;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(userName, password);//用户名、密码


            try
            {
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.From = new MailAddress(userName, "sfj");
                msg.To.Add("maybelleschoesfcw@gmail.com");//收件人
                msg.Subject = "c#Mail";//邮件标题   
                msg.Body = "c#Mail";//邮件内容   
                msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码   
                msg.IsBodyHtml = true;//是否是HTML邮件   
                msg.Priority = MailPriority.High;//邮件优先级   
                client.Send(msg);
                MessageBox.Show("发送成功");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message, "发送邮件出错");
            }
        }

        #endregion

        #region tree

        private void BindLeftTree()
        {
            //TreeNode node = new TreeNode("test", new List<TreeNode>().ToArray());
            //node.ImageIndex = 1;
            //Left_tree.Nodes.Add(node);
            //Left_tree.ImageList = new ImageList();
        }

        #endregion

        #region webapi

        private void LoadState()
        {
            menu_foot_lblApi.Text = "API Sercives:" + WebApiSercives.sercives.State.ToString();

            if (WebApiSercives.sercives.State == WebApiSercives.APIOC.OPEN)
            {
                menu_sercives_open.Enabled = false;
                menu_sercives_close.Enabled = true;
            }
            else
            {
                menu_sercives_open.Enabled = true;
                menu_sercives_close.Enabled = false;
            }
        }
        private void menu_foot_lblApi_Click(object sender, EventArgs e)
        {
            if (WebApiSercives.sercives.State == WebApiSercives.APIOC.CLOSE)
            {
                WebApiSercives.sercives.Start();
            }
            else
            {
                WebApiSercives.sercives.Stop();
            }

            DoSomething(LoadState);
        }

        #endregion

        #region delegate
        public delegate void ShowMsg(string txt);
        public void ShowMSG(string txt)
        {
            MessageBox.Show(txt);
        }
        public void DoSomething(ShowMsg sm)
        {
            string msg = "一条消息";
            sm(msg);
        }
        public void DoSomething(Action action)
        {
            action();
        }

        #endregion


    }
}
