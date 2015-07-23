# Code First Entity Framework with Web API 2

This repository is the code to follow the tutorial at 
[ChrisByram.com/Blog](http://www.chrisbyram.com/blog/2015/07/26/code-first-ef-with-web-api-2)

## 1: Setup:
1. Create Web Application

## 2: Entity Framework Code First:
1. Install EF and setup Nuget Restore
2. Add Models for Ticket and TicketCategory
3. Add Connection String
4. Add Database Context

## 3: Setup Views:
1. Add Home Controller & Index View

## 4: EntityFramework Controllers
1. Add Ticket Controller & Ticket Category Controller
2. Add navigation

## 5: Data Initializer
1. Add Initializer
2. Define initializer in web.config
3. Add tickets
4. Disable data initialization in web.config

## 6: Migrations
1. Enable Migrations and run update database
2. Uncomment new property in Ticket
3. add-migration ticket-important-property then update database
4. add-migration ticket-important-not-needed then update database

## 7: Web API
1. Add Ticket and TicketCategories api controllers.
2. Switch Web API to use JSON and handle circular reference issue.
3. Create TicketCategoryJsonModel as another way to handle references.