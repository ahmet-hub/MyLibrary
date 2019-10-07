using System;
using System.Windows.Forms;
using MyLibrary.Business.Abstract;
using MyLibrary.Business.Concrete;
using MyLibrary.DataAccess.Concrete.EntityFramework;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.WebForms
{
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }
        private ILibraryUserService _userService=new LibraryUserManager(new EfLibraryUserDal());

        private void UserUI_Load(object sender, EventArgs e)
        {
          LoadUser();
          
        }
        private void LoadUser()
        {
            dgwUser.DataSource = _userService.GetAll();
        }

        private void GetUser()
        {
            if (dgwUser.CurrentRow != null)
            {
                txtGetId.Text = dgwUser.CurrentRow.Cells[0].Value.ToString();
                txtUserName.Text = dgwUser.CurrentRow.Cells[1].Value.ToString();
                txtUserLastName.Text = dgwUser.CurrentRow.Cells[2].Value.ToString();
                txtUserMail.Text = dgwUser.CurrentRow.Cells[3].Value.ToString();
                txtPhone.Text = dgwUser.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void BtnAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Add(new LibraryUser
                {
                    Name = txtUserName.Text,
                    LastName = txtUserLastName.Text,
                    Email = txtUserMail.Text,
                    Phone = txtPhone.Text,
                });

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }
            LoadUser();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Update(new LibraryUser
                {
                    Id = Convert.ToInt32(txtGetId.Text),
                    Name =txtUserName.Text,
                    LastName = txtUserLastName.Text,
                    Email = txtUserMail.Text,
                    Phone = txtPhone.Text
                });
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
            }
            LoadUser();
        }

        private void BtnDeleted_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Delete(new LibraryUser
                {
                    Id = Convert.ToInt32(txtGetId.Text)
                });
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
               
            }
            LoadUser();
            
        }

        private void DgwUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetUser();
        }
    }
}
