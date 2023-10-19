# Nutrition-Project
## This project is a web nutrition diary. It is created for everyone but it's especially suitable for peoble with digestion problems.
With this project, we request certain data of the users (height, weight, age, chronic diseases and bad habits, if any) and the foods they eat daily, their digestion status after meals, the number of steps, sleep time and water intake. We aim to identify foods and create a personalized list. With this list, we aim to identify the foods that a person should exclude from their diet and to help people with indigestion complaints find the most suitable eating habits for themselves.
## Database Design
While developing the database, we used the Microsoft SQL SERVER query language, in short MSSQL. MSSQL is a database management system. We created our database with the Code First approach. This approach is a technique that establishes a connection between the database and the programming language.
In the Code First structure, "class" structures in the programming language correspond to "table" structures in the database, and "property" structures correspond to "column" structures in the database.
In addition, thanks to Attributes, Validations can be applied to database structures and certain conditions or restrictions can be placed on columns.
## Backend & Frontend Design
We developed our project in C# language using MVC Framework architecture in ASP.NET environment. MVC consists of the initials of (Model View Controller) layers. It is understood from here that MVC is a layered architecture. Each layer has its own specific tasks.
We created 4 layers in our project. These layers we created are as follows:
1. Presentation Layer: This is the layer where interaction with the user takes place. The main purpose here is to show the data to the user and to transmit the data from the user to Data Access with the Business Layer.
2. Business Layer: The data drawn into the project by Data Access is processed in this layer. The data coming from the user first goes to the Business layer and from there it is processed and transferred to the Data Access layer. In this layer, we also specify who will access this data.
3. Data Access Layer: In this layer, database operations such as adding, reading, updating and deleting are performed. These four basic operations are referred to as CRUD.
4. Entity Layer: This is the part where the structures in which the tables and columns in the database will be defined and expressed as classes and properties in C# are kept.
## View - My Daily Values
![image](https://github.com/SenaAydin7/Nutrition-Project/assets/92725053/645b5012-71f6-496c-866a-995573bfc327)
