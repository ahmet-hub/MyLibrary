using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary.WebForms
{
    public partial class Form1 : Form
    {      
        public Form1()           
        {

            MyLibrary.Business.DbFirstTest firstTest = new Business.DbFirstTest();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private BooksUI _booksUi;
        private void BtnBooks_Click(object sender, EventArgs e)
        {
            if (_booksUi != null && !_booksUi.IsDisposed) return;
            _booksUi = new BooksUI();
            _booksUi.Show();
        }

        private UserUI _userUi;
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            if(_userUi !=null && _booksUi.IsDisposed) return;
            _booksUi=new BooksUI();
            _booksUi.Show();

        }

        private TraceUI _traceUi;
        private void BtnTrace_Click(object sender, EventArgs e)
        {
            if (_traceUi != null && _traceUi.IsDisposed) return;
            _traceUi = new TraceUI();
            _traceUi.Show();                          
        }
    }
}
