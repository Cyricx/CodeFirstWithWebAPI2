using CodeFirstWithWebAPI2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstWithWebAPI2.DAL
{
    public class MyInitializer : DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            List<TicketCategory> categories = new List<TicketCategory>()
            {
                new TicketCategory { Name = "Feature", IsActive = true },
                new TicketCategory { Name = "Enhancement", IsActive = true },
                new TicketCategory { Name = "Bug", IsActive = true }
            };
            categories.ForEach(x => context.TicketCategories.Add(x));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}