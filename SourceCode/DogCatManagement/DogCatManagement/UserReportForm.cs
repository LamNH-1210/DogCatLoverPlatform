using DataAccess.DAO;
using DataAccess.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DogCatManagement
{
    public partial class UserReportForm : Form
    {
        private IPostRepository postRepository = null;
        private IReportRepository reportRepository = null;
        private int postId;
        private Post _post;

        private CustomerHomePage _homePage;
        private UserSession _userSession;
        public UserReportForm(UserSession userSession, Post post)
        {
            InitializeComponent();
            postRepository = new PostRepository();
            reportRepository = new ReportRepository();
            _userSession = userSession;
            _post = post;
            _homePage = new CustomerHomePage(_userSession);
            lb_OtherEmpty.Visible = false;
            cmb_Reasons.Items.Add("Spam");
            cmb_Reasons.Items.Add("Violence");
            cmb_Reasons.Items.Add("Terrorism");
            cmb_Reasons.Items.Add("Words that cause hate");
            cmb_Reasons.Items.Add("False information");
            cmb_Reasons.Items.Add("Harass others");
            cmb_Reasons.Items.Add("Others");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _homePage.Show();
        }

        private void btn_SendReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report new_Report = new Report();
                new_Report.PostId = _post.PostId;
                new_Report.UserId = _userSession.UserId;
                new_Report.ReportDate = DateTime.Now;
                if (cmb_Reasons.SelectedItem != null)
                {
                    if (!cmb_Reasons.SelectedItem.Equals("Others"))
                    {
                        new_Report.ReportReason = cmb_Reasons.SelectedItem.ToString();
                    }
                    else
                    {
                        if (txt_OtherReason.Text.Length == 0)
                        {
                            lb_OtherEmpty.Enabled = true;
                            return;
                        }
                        new_Report.ReportReason = txt_OtherReason.Text.Trim();
                    }
                    reportRepository.AddReport(new_Report);
                    MessageBox.Show("Report successful!");
                    this.Hide();
                    _homePage.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Report failed! " + ex.Message);
            }
        }

        private void UserReportForm_Load(object sender, EventArgs e)
        {
            cmb_Reasons.SelectedIndex = 0;
            cmb_Reasons.DisplayMember = "Report Reason";
        }

        private void cmb_Reasons_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectOption = cmb_Reasons.SelectedItem.ToString();
            txt_OtherReason.Enabled = selectOption.Equals("Others");

            lb_OtherEmpty.Visible = false;
        }
    }
}


