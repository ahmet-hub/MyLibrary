using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.Business.Abstract;
using MyLibrary.Business.Concrete;
using MyLibrary.DataAccess.Concrete.EntityFramework;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.WebForms
{
    public partial class TraceUI : Form
    {
        public TraceUI()
        {
            InitializeComponent();
        }

        private IBookService _bookService=new BookManager(new EfBookDal());
        private ILibraryUserService _userService=new LibraryUserManager(new EfLibraryUserDal());
        private IUserBookTraceService _userBookTraceService = new UserBookTraceManager(new EfUserBookTraceDal());

        private void TraceUI_Load(object sender, EventArgs e)
        {
            LoadBook();
            LoadUser();
        }

        private void LoadUser()
        {
            cbxUser.DataSource = _userService.GetAll();
            cbxUser.DisplayMember = "Email";
            cbxUser.ValueMember = "Id";
        }
        private void LoadBook()
        {
            dgwBooks.DataSource = _bookService.GetAll();

            dgwBooks.Columns[6].Visible = false;
            dgwBooks.Columns[7].Visible = false;
            dgwBooks.Columns[1].HeaderText = "KİTAP ADI";
            dgwBooks.Columns[2].HeaderText = "YAYIN YILI";
            dgwBooks.Columns[3].HeaderText = "YAYIN EVİ";
            dgwBooks.Columns[4].HeaderText = "YAZAR";
            dgwBooks.Columns[5].HeaderText = "KATEGORİ";
        }

        private void GetBook()
        {
            if (dgwBooks.CurrentRow != null) txtBookID.Text = dgwBooks.CurrentRow.Cells[0].Value.ToString();
        }
        private void DgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetBook();
        }

        private void BtnAdded_Click(object sender, EventArgs e)
        {
            _userBookTraceService.Add(new UserBookTrace
            {
                BookId = Convert.ToInt32(txtBookID.Text),
                UserId = Convert.ToInt32(cbxUser.SelectedValue),
                TakenDate = dtpTake.Value,
                ReturnDate = dtpReturn.Value


            });
        }
    }
}
