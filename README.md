# Welcome to Baltic Books!

Hi, I glad to introduce you to this database design-based project. It is build using Visual studio, SQL, .NET Core and Entity Framework. The project is a Books retaliates database and as user interface that connects to the database to create, retrieve, update and delete entries. The following document contains brief user guide, database structure and technical specifications, in that order. Strap yourself in and lest get going!

### Note - you can find a copy of the database used in this project in the file by name BalticBooks.bak

# User Guide
This is a brief overview / guide for the user interface.


## Customers (CRUD)

When you launch the application, you will be greeted with a welcome message and an introductory page.
To create a new customer, navigate to the Customers link as the top right-hand side. After clicking the link, you will find yourself in the Customers List page. 




![](/BalticBooks/gitImages/welcome.jpg)




When you will have customers in your database, they will be shown here and there data will be available to link with the orders.
To create a new customer, click the Create Customer + button. This will lead you to the Creation page.




![](/BalticBooks/gitImages/createCustomer.jpg)

##

![](/BalticBooks/gitImages/listCustomer.jpg)




Here you can enter Customers name, address, phone number and email address in the appropriate fields.
After the creation you will be taken back to the customers list page. This will allow you to review your entry and edit it if necessary or delete. The edit page is like the creation page the only difference is that information about the customer will be prepopulated in the fields.




![](/BalticBooks/gitImages/editCustomer.jpg)




## CRUD operations for the Suppliers and Books 
It is extremely similar to the Customer operation. I will not go over them here as they can be easily worked out following the customer guide.



# Managing Orders / Order Lines
You can find orders in the order screen with the associate orderliness by clicking on the details of the order.



![](/BalticBooks/gitImages/)



To create an order, you must have A customer, supplier and a book prior. Because none of the order or order line fields can be left empty. After adding customer and the date of the order you will be able to add any number of order lines that contains bucks from different suppliers.



![](/BalticBooks/gitImages/)



# Database Design

The database was designed to allow a company to transition from soring information in a flat file, to a more flexible and secure database structure.

## Normalization

I start with as small sample of the data and Normalized it using the 3 Normal Forms methodology.

![](/BalticBooks/gitImages/normalization.jpg)

This helped realize the constraints that will have to be followed.

## Entity Relational Diagram
There are three main types of ERD’s. I chose to use a hybrid of physical and logical. That looks like this.

![](/BalticBooks/gitImages/erd.jpg)

This allows to visualise and determine relationships between table. Also, the data type suggestions are specified.
Following the diagram, I have built the database with Entity Framework.

# Software Technical Specification.

