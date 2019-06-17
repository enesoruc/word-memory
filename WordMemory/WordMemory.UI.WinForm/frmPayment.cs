using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordMemory.BLL;
using WordMemory.Model;

namespace WordMemory.UI.WinForm
{
    public partial class frmPayment : Form
    {
        User user;
        PaymentController _paymentController;
        UserController _userController;
        frmUser frmUser;

        public frmPayment(User currentUser,Form frm)
        {
            InitializeComponent();
            user = currentUser;
            _paymentController = new PaymentController();
            _userController = new UserController();
            frmUser = (frmUser)frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCardNumber.Text) & !String.IsNullOrWhiteSpace(txtCardPassword.Text))
            {
                Payment pay = new Payment()
                {
                    UserID = user.UserID
                };

                if (rdButtonCash.Checked == true)
                {
                    pay.PaymentTypeID = 2;
                    pay.Price = numUDCash.Value;
                }
                else
                {
                    pay.PaymentTypeID = 1;
                    pay.Price = numUDCredit.Value;
                }
                try
                {
                    _paymentController.Add(pay);
                    user.RoleID = 2;
                    _userController.Update(user);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Thanks for your payment.");

                frmUser.ChangeRole();

                this.Close();
            }
            else
            {
                MessageBox.Show("Ödeme Bilgileri Boş Geçilemez.");
            }            
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            RefreshVisible();
        }

        void RefreshVisible()
        {
            if (rdButtonCreditCard.Checked == true)
            {
                grpBoxCreditCard.Visible = true;
                grpBoxCash.Visible = false;
            }
            else
            {
                grpBoxCreditCard.Visible = false;
                grpBoxCash.Visible = true;
            }
        }

        private void rdButtonCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            RefreshVisible();
        }
    }
}
