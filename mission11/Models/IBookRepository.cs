﻿namespace mission11.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get;}
    }
}
