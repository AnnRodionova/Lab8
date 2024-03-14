﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        
        protected override void Seed(BookContext db)
        {
            
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220, ImageUrl = "/Content/img/voina.png" });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 180,  ImageUrl = "/Content/img/otzii.png" });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150,  ImageUrl = "/Content/img/chaika.png" });

           
            base.Seed(db);
        }
    }
}
