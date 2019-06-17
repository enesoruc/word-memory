using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordMemory.BLL;
using WordMemory.DTO;

namespace WordMemory.UI.WinForm
{
    public partial class frmUserStatistics : Form
    {
        UserController _userController;
        public frmUserStatistics()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            switch (cmbBoxReportType.SelectedIndex)
            {
                case 0:
                    ReportAboutWordByWeek(dtPickerFirst.Value.Date);
                    break;
                case 1:
                    ReportAboutWordByMonth(dtPickerFirst.Value.Date);
                    break;
                case 2:
                    ReportAboutWordBetweenDates(dtPickerFirst.Value.Date, dtPickerLast.Value.Date);
                    break;
                default:
                    break;
            }
        }

        private void ReportAboutWordByMonth(DateTime date)
        {
            List<UserReportDTO> list = _userController.GetWordUserReportByMonth(date.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture));

            grdViewReports.DataSource = new BindingList<UserReportDTO>(list);
        }

        private void ReportAboutWordBetweenDates(DateTime date1, DateTime date2)
        {
            List<UserReportDTO> list = _userController.GetReportUserBetweenDate(date1.ToShortDateString(), date2.ToShortDateString());

            grdViewReports.DataSource = new BindingList<UserReportDTO>(list);

        }

        private void ReportAboutWordByWeek(DateTime date)
        {
            List<UserReportDTO> list = _userController.GetWordUserReportByWeek(date.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture));

            grdViewReports.DataSource = new BindingList<UserReportDTO>(list);
        }

        private void cmbBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBoxReportType.SelectedIndex)
            {
                case 0:
                    dtPickerFirst.Enabled = true;
                    btnReport.Enabled = true;
                    dtPickerLast.Enabled = false;
                    break;
                case 1:
                    dtPickerFirst.Enabled = true;
                    btnReport.Enabled = true;
                    dtPickerLast.Enabled = false;
                    break;
                case 2:
                    dtPickerFirst.Enabled = true;
                    btnReport.Enabled = true;
                    dtPickerLast.Enabled = true;
                    break;
                default:
                    dtPickerFirst.Enabled = false;
                    btnReport.Enabled = false;
                    dtPickerLast.Enabled = false;
                    break;
            }
        }

        private void dtPickerFirst_ValueChanged(object sender, EventArgs e)
        {
            dtPickerFirst.MaxDate = dtPickerLast.Value;
        }
    }
}
