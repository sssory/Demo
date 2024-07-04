using System;
using System.IO;
using System.Windows.Forms;

namespace App.Controls
{
    public partial class DBHelper : UserControl
    {
        public DBHelper()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string tableName = txtTable.Text.Trim();
            string nameSpace = txtNameSpace.Text.Trim();
            string folder = txtFolder.Text.Trim();

            //1 验证输入
            if (!Directory.Exists(folder))
            {
                MessageBox.Show("不存在路径");
                return;
            }

            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("请输入表名");
                return;
            }

            if (string.IsNullOrEmpty(nameSpace))
            {
                MessageBox.Show("请输入命名空间");
                return;
            }

            //2 创建文件
            try
            {
                Model.Sugar.DB.DbFirst.Where(it => it == tableName).IsCreateAttribute().IsCreateDefaultValue().FormatClassName(it => it + "Entity").CreateClassFile(folder, nameSpace);
                MessageBox.Show("成功");


                //OpenFileDialog openFile = new OpenFileDialog();
                //openFile.InitialDirectory = folder;
                //openFile.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误" + ex.Message);
            }

        }

        private void txtFolder_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog path = new FolderBrowserDialog();

            if (Directory.Exists(txtFolder.Text))
                path.SelectedPath = txtFolder.Text;


            DialogResult result = path.ShowDialog();
            if (result == DialogResult.OK)
            {
                ((TextBox)sender).Text = path.SelectedPath;
            }

        }
    }
}
