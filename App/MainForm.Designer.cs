
namespace App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu_Top = new System.Windows.Forms.MenuStrip();
            this.menu_sercives = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sercives_port = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sercives_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sercives_close = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help_mysql = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_mail = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_mail_send = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_foot = new System.Windows.Forms.StatusStrip();
            this.menu_foot_lblApi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.pageWelcome = new System.Windows.Forms.TabPage();
            this.menu_Top.SuspendLayout();
            this.menu_foot.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Top
            // 
            this.menu_Top.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sercives,
            this.menu_help,
            this.menu_mail});
            this.menu_Top.Location = new System.Drawing.Point(0, 0);
            this.menu_Top.Name = "menu_Top";
            this.menu_Top.Size = new System.Drawing.Size(1043, 25);
            this.menu_Top.TabIndex = 1;
            this.menu_Top.Text = "menuStrip1";
            // 
            // menu_sercives
            // 
            this.menu_sercives.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sercives_port,
            this.menu_sercives_open,
            this.menu_sercives_close});
            this.menu_sercives.Name = "menu_sercives";
            this.menu_sercives.Size = new System.Drawing.Size(44, 21);
            this.menu_sercives.Text = "服务";
            // 
            // menu_sercives_port
            // 
            this.menu_sercives_port.Name = "menu_sercives_port";
            this.menu_sercives_port.Size = new System.Drawing.Size(124, 22);
            this.menu_sercives_port.Text = "设置端口";
            this.menu_sercives_port.Click += new System.EventHandler(this.menu_sercives_port_Click);
            // 
            // menu_sercives_open
            // 
            this.menu_sercives_open.Name = "menu_sercives_open";
            this.menu_sercives_open.Size = new System.Drawing.Size(124, 22);
            this.menu_sercives_open.Text = "开启服务";
            this.menu_sercives_open.Click += new System.EventHandler(this.menu_sercives_open_Click);
            // 
            // menu_sercives_close
            // 
            this.menu_sercives_close.Name = "menu_sercives_close";
            this.menu_sercives_close.Size = new System.Drawing.Size(124, 22);
            this.menu_sercives_close.Text = "关闭服务";
            this.menu_sercives_close.Click += new System.EventHandler(this.menu_sercives_close_Click);
            // 
            // menu_help
            // 
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_help_backup,
            this.menu_help_mysql});
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(44, 21);
            this.menu_help.Text = "帮助";
            // 
            // menu_help_backup
            // 
            this.menu_help_backup.Name = "menu_help_backup";
            this.menu_help_backup.Size = new System.Drawing.Size(180, 22);
            this.menu_help_backup.Text = "数据备份";
            this.menu_help_backup.Click += new System.EventHandler(this.menu_help_backup_Click);
            // 
            // menu_help_mysql
            // 
            this.menu_help_mysql.Name = "menu_help_mysql";
            this.menu_help_mysql.Size = new System.Drawing.Size(180, 22);
            this.menu_help_mysql.Text = "生成实体";
            this.menu_help_mysql.Click += new System.EventHandler(this.menu_help_mysql_Click);
            // 
            // menu_mail
            // 
            this.menu_mail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_mail_send});
            this.menu_mail.Name = "menu_mail";
            this.menu_mail.Size = new System.Drawing.Size(44, 21);
            this.menu_mail.Text = "邮箱";
            // 
            // menu_mail_send
            // 
            this.menu_mail_send.Name = "menu_mail_send";
            this.menu_mail_send.Size = new System.Drawing.Size(124, 22);
            this.menu_mail_send.Text = "发送邮件";
            this.menu_mail_send.Click += new System.EventHandler(this.menu_mail_send_Click);
            // 
            // menu_foot
            // 
            this.menu_foot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_foot_lblApi});
            this.menu_foot.Location = new System.Drawing.Point(0, 573);
            this.menu_foot.Name = "menu_foot";
            this.menu_foot.Size = new System.Drawing.Size(1043, 22);
            this.menu_foot.TabIndex = 2;
            this.menu_foot.Text = "statusStrip1";
            // 
            // menu_foot_lblApi
            // 
            this.menu_foot_lblApi.Name = "menu_foot_lblApi";
            this.menu_foot_lblApi.Size = new System.Drawing.Size(0, 17);
            // 
            // tab_main
            // 
            this.tab_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_main.Controls.Add(this.pageWelcome);
            this.tab_main.Location = new System.Drawing.Point(0, 28);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(1043, 542);
            this.tab_main.TabIndex = 3;
            // 
            // pageWelcome
            // 
            this.pageWelcome.Location = new System.Drawing.Point(4, 22);
            this.pageWelcome.Name = "pageWelcome";
            this.pageWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.pageWelcome.Size = new System.Drawing.Size(1035, 516);
            this.pageWelcome.TabIndex = 0;
            this.pageWelcome.Text = "欢迎";
            this.pageWelcome.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 595);
            this.Controls.Add(this.tab_main);
            this.Controls.Add(this.menu_foot);
            this.Controls.Add(this.menu_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_Top;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForm";
            this.menu_Top.ResumeLayout(false);
            this.menu_Top.PerformLayout();
            this.menu_foot.ResumeLayout(false);
            this.menu_foot.PerformLayout();
            this.tab_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu_Top;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.StatusStrip menu_foot;
        private System.Windows.Forms.ToolStripStatusLabel menu_foot_lblApi;
        private System.Windows.Forms.ToolStripMenuItem menu_sercives;
        private System.Windows.Forms.ToolStripMenuItem menu_sercives_port;
        private System.Windows.Forms.ToolStripMenuItem menu_sercives_close;
        private System.Windows.Forms.ToolStripMenuItem menu_sercives_open;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.ToolStripMenuItem menu_help_mysql;
        private System.Windows.Forms.ToolStripMenuItem menu_help_backup;
        private System.Windows.Forms.ToolStripMenuItem menu_mail;
        private System.Windows.Forms.ToolStripMenuItem menu_mail_send;
        private System.Windows.Forms.TabPage pageWelcome;
    }
}

