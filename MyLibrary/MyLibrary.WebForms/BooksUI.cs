using MyLibrary.Business.Abstract;
using MyLibrary.Business.Concrete;
using System;
using System.Windows.Forms;
using MyLibrary.DataAccess.Concrete.EntityFramework;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.WebForms
{
    public partial class BooksUI : Form
    {
        public BooksUI()
        {
            InitializeComponent();
        }

        private IBookService _bookService = new BookManager(new EfBookDal());
        private IAuthorService _authorService = new AuthorManager(new EfAuthorDal());
        private ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());

        private void BooksUI_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadAuthor();
            LoadBook();
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
        private void LoadAuthor()
        {
            cbxAuthor.DataSource = _authorService.GetAll();

            cbxAuthor.DisplayMember = "Name";

            cbxAuthor.ValueMember = "Id";
        }
        private void LoadCategory()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "Title";
            cbxCategory.ValueMember = "Id";
        }
        private void GetBook()
        {
            if (dgwBooks.CurrentRow != null)
            {
                txtGetId.Text = dgwBooks.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
                txtPublisher.Text = dgwBooks.CurrentRow.Cells[3].Value.ToString();
            }
        }
        private void BtnAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Add(new Book
                {
                    Name = txtName.Text,
                    CategoryId = Convert.ToInt32(cbxCategory.SelectedValue),

                    AuthorId = Convert.ToInt32(cbxAuthor.SelectedValue),
                    PublishYear = dtHistory.Value,
                    Publisher = txtPublisher.Text

                });
                MessageBox.Show("Kitap Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            LoadBook();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Update(new Book
                    {
                        Id = Convert.ToInt32(txtGetId.Text),
                        Name = txtName.Text,
                        Publisher = txtPublisher.Text,
                        PublishYear = dtHistory.Value,
                        CategoryId = Convert.ToInt32(cbxCategory.SelectedValue),
                        AuthorId = Convert.ToInt32(cbxAuthor.SelectedValue)

                    });
                MessageBox.Show("Kitap Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadBook();

        }
        private void BtnDeleted_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwBooks.CurrentRow != null)
                    _bookService.Delete(new Book
                    {
                        Id = Convert.ToInt32(txtGetId.Text)
                    });
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            LoadBook();
        }
        private void DgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetBook();
        }
    }
}

    

