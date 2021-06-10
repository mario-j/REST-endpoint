# APIDemo

A sample API Demo that seeds a database with 3 users and provides 2 endpoints for searching users and adding users.

## Use

Copy the repository to your local machine and open the solution using Visual Studio. Run the solution and a local window should open that contains the 2 endpoints (Search and Add) of the UserController. Shown below.

![image](https://user-images.githubusercontent.com/54779892/121532514-071ccb80-c9c5-11eb-9986-3543c6b525d7.png)

To view the current state of the database, open the SQL Server Object Explorer window. The window can be accessed via View -> SQL Server Object Explorer. 

Open the file path shown below and right click on the User table and select View Data to open the User table.

![image](https://user-images.githubusercontent.com/54779892/121533479-ee60e580-c9c5-11eb-86db-8d0e967b409a.png)

## Seeding

The database is initially seeded in the DBInitializer.cs class. The initial state of the database can be seen below.

![image](https://user-images.githubusercontent.com/54779892/121533120-9629e380-c9c5-11eb-843e-ebfd98659eaf.png)



