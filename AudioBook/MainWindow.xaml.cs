using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AudioBook.DB;
using AudioBook.ClassHelp;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using AudioBook.Win;

namespace AudioBook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BookModel> books = new List<BookModel>();
        public class BookModel
        {
            public int id { get; set; }
            public string nameBook { get; set; }
            public string genre { get; set; }
            public string titleBook { get;set; }
            public string descriptionBook { get; set; }
            public string AuthorFIO { get;set; }
            public string ReaderFIO { get; set; }
            public BookModel(Book book)
            {
                this.id = book.IdBook;
                this.genre = EFClass.Context.Genre.Where(x=> x.IdGenre == book.Genre).First().NameGenre;
                this.AuthorFIO = $"{EFClass.Context.Author.Where(x => x.IdAuthor == book.Author).First().NameAuthor} {EFClass.Context.Author.Where(x => x.IdAuthor == book.Author).First().SurnameAuthor} {EFClass.Context.Author.Where(x => x.IdAuthor == book.Author).First().MiddleAuthor}";
                this.ReaderFIO= $"{EFClass.Context.Reader.Where(x => x.IdReader == book.Reader).First().NameReader} {EFClass.Context.Reader.Where(x => x.IdReader == book.Reader).First().SurnameReader} {EFClass.Context.Reader.Where(x => x.IdReader == book.Reader).First().MiddleReader}";
                this.titleBook = book.TitleBook;
                this.nameBook = book.NameBook;
            }


        }

        public MainWindow()
        {
            InitializeComponent();
            GetListBook();
        }
        private void GetListBook()
        {
            
            List<Book> data = EFClass.Context.Book.ToList();
            foreach (Book book in data)
            {
                books.Add(new BookModel(book));
            }

           

            LvBooks.ItemsSource = books;
        }

        private void LvBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnSearch(object sender, RoutedEventArgs e)
        {
            WindowBook window = new WindowBook();
            window.Show();
        }
        

        

        private void btn_Book_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            BookModel item = books.FindAll(x => x.id == int.Parse(btn.Tag.ToString())).FirstOrDefault();
            MessageBox.Show(item.id.ToString());
            
            


            WindowBook window = new WindowBook();
            window.Show();
        }
    }
}
