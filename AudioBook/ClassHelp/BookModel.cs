using AudioBook.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioBook.ClassHelp
{
    public class BookModel
    {
        public int id { get; set; }
        public string nameBook { get; set; }
        public string genre { get; set; }
        public string titleBook { get; set; }
        public string descriptionBook { get; set; }
        public string AuthorFIO { get; set; }
        public string ReaderFIO { get; set; }
        
        public BookModel(Book book)
        {
            this.id = book.IdBook;
            this.genre = EFClass.Context.Genre.Where(x => x.IdGenre == book.Genre).First().NameGenre;
            this.AuthorFIO = $"{EFClass.Context.Author.Where(x => x.IdAuthor == book.Author).First().NameAuthor} {EFClass.Context.Author.Where(x => x.IdAuthor == book.Author).First().SurnameAuthor} {EFClass.Context.Author.Where(x => x.IdAuthor == book.Author).First().MiddleAuthor}";
            this.ReaderFIO = $"{EFClass.Context.Reader.Where(x => x.IdReader == book.Reader).First().NameReader} {EFClass.Context.Reader.Where(x => x.IdReader == book.Reader).First().SurnameReader} {EFClass.Context.Reader.Where(x => x.IdReader == book.Reader).First().MiddleReader}";
            this.titleBook = book.TitleBook;
            this.nameBook = book.NameBook;
            
        }



    }
}
