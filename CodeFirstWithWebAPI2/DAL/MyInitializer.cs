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

            List<Ticket> tickets = new List<Ticket>()
            {
                new Ticket { Title=.1.1 Setup Application", TicketCategoryID = 1, 
                    Details = "Create initial web application which will be an empty web application with the Web API and MVC libraries already installed.", 
                    SprintDate = new DateTime(2015, 01, 01, 5, 0 , 0), IsClosed = true  },
                new Ticket { Title="2.1 EF Code First", TicketCategoryID = 1, 
                    Details = "Install Entity framework with nuget and setup nuget restore. This will allow individuals that pull the repository down to build and run it.", 
                    SprintDate = new DateTime(2015, 02, 01, 5, 0 , 0), IsClosed = true},
                new Ticket { Title= "2.2 EF Code First - Add Models", TicketCategoryID = 2, 
                    Details = "Add the ticket and ticketcategory models that will drive and define the creation of the SQL database. This is the part that makes it \"code first\". We will use data annotations to define our data types.", 
                    SprintDate = new DateTime(2015, 02, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "2.3 EF Code First - Connection", TicketCategoryID = 2, 
                    Details = "Just setting up a basic sql connection string in the web.config that we can reference later in the context.", 
                    SprintDate = new DateTime(2015, 02, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "2.4 EF Code First - Database Context", TicketCategoryID = 2, 
                    Details = "The database context will act like our sql connection. In fact in it's ctor we should specify what the name of the connection string is in the web.config, this is also where we define what collections are accessible. We defined the rules to create our models in the Model files. You can also use the fluent api by overriding the OnModelCreating method. Personally, I prefer to define things in the model where I am able, though it should be noted that I am creating a coupling of my models being built specifically for the entity framework. You can also use the fluent api to define this if you override the OnModelCreating method in the context. This choice should be based on the projects requirement.", 
                    SprintDate = new DateTime(2015, 02, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "3.1 Setup Views", TicketCategoryID = 1, 
                    Details = "Add home controller and index view. This is typically where the bloat begins. This step will automatically pull in jquery, bootstrap, and bootstrap's requirement of glyphicons.", 
                    SprintDate = new DateTime(2015, 03, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "4.1 EF Controllers", TicketCategoryID = 1, 
                    Details = "Here we will setup basic EF controllers with views and accept all the default c# and html. This will all be formatted for bootstrap.", 
                    SprintDate = new DateTime(2015, 03, 15, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "4.2 EF Controllers - Navigation", TicketCategoryID = 3, 
                    Details = "Added navigation to access the new areas of the site.", 
                    SprintDate = new DateTime(2015, 03, 15, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "5.1 Data Initializer", TicketCategoryID = 1, 
                    Details = "Add database initializer. The class it inherits specifically dictates how it works. Examples are: CreateDatabaseIfNotExists<>, DropCreateDatabaseAlways<>, DropCreateDatabaseIfModelChanges<>, MigrateDatabaseToLatestVersion<>, etc. The two drop database ones are useful for initial construction of the application. However, before too long you will be disabling the initialization and using migrations to avoid data loss.", 
                    SprintDate = new DateTime(2015, 04, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "5.2 Data Initializer - Define in web.config", TicketCategoryID = 3, 
                    Details = "In order for the intializer to work, you have to define it in the web.config so that Entity Framework knows what to look for where. Due to the string driven configuration, pay close attention to the namespaces and class names. Also, take note of the attribute disableDatabaseInitialization as that will be disabled after you finish initial construction and start putting real data in the database.", 
                    SprintDate = new DateTime(2015, 04, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "5.3 Data Initializer - Add tickets", TicketCategoryID = 2, 
                    Details = "Be careful how much you seed an application. At some point it'll be more tedious to try to input all of the data as c# objects and it would be better to create an sql script, or use the interface itself. Trust me, this comes from the experience of trying to get the seed data to do too much. Migrations are just around the corner and make future development extremely easy!", 
                    SprintDate = new DateTime(2015, 04, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "5.4 Data Initializer - Disable initializer", TicketCategoryID = 2, 
                    Details = "The intializer is extremely easy to disable. Just change the disableDatabaseInitialization attribute in your web.config to true and you are done with initial construction and seed data!", 
                    SprintDate = new DateTime(2015, 04, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "6.1 Migrations - Enable and run Update", TicketCategoryID = 1, 
                    Details = "Enabling migrations is a great way to allow your database to continue to evolve as the project evolves.", 
                    SprintDate = new DateTime(2015, 04, 15, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "6.2 Migrations - Add new property", TicketCategoryID = 2, 
                    Details = "When you have enabled migrations you can add or remove properties as the application evolves and the business needs change. During each iteration you'll add a new migration for that change.", 
                    SprintDate = new DateTime(2015, 04, 15, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "6.3 Migrations - Add Migration Property", TicketCategoryID = 2, 
                    Details = "By using the add-migration <name>, Entity Framework will analyze the models and look for any new changes. It will then create the C# needed to change the database to match the current code base. It will also provide up and down code so that you can revert the change later if desired. The change will take effect when you run update-database.", 
                    SprintDate = new DateTime(2015, 04, 15, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "6.4 Migrations - Add Migration Remove Property", TicketCategoryID = 2, 
                    Details = "To show that it will handle removing properties as well as new properties, we can comment out that new property and rerun the add-migration <name> and then update-database again.", 
                    SprintDate = new DateTime(2015, 04, 15, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "7.1 Web API - Add api controllers", TicketCategoryID = 1, 
                    Details = "Adding the controllers is very easy with the scaffolding, however, there are several gotchas that we have to deal with in order to get this working well with client side applications like Angular.", 
                    SprintDate = new DateTime(2015, 05, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "7.2 Web API - Json and Circular Reference", TicketCategoryID = 3, 
                    Details = "By default web api returns xml. It is very easy to change that to render JSON instead. Not so easy to handle is the circular reference problem that comes about when working with Entity Framework, most especially when we are using Code First. First off, is simply \"Include\" the nested properties that we want. Web API will make no assumptions about that. Then we can use the JsonIgnore attribute to stop the circular reference.", 
                    SprintDate = new DateTime(2015, 05, 01, 5, 0 , 0), IsClosed = true },
                new Ticket { Title= "7.3 Web API - Create a JSON Model", TicketCategoryID = 3, 
                    Details = "A better way to handle that, which of course means more code, is to create a JsonModel. Similar to the concept of a ViewModel, this gives us direct control over exactly what is rendered, and is another way to stop circular references.", 
                    SprintDate = new DateTime(2015, 05, 01, 5, 0 , 0), IsClosed = true }
            };
            tickets.ForEach(x => context.Tickets.Add(x));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}