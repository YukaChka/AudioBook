//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AudioBook.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReaderBooks
    {
        public int IdReaderBook { get; set; }
        public int IdBookRB { get; set; }
        public int IdReaderRB { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Reader Reader { get; set; }
    }
}
