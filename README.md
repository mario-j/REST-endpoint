# APIDemo

A sample API Demo that seeds a database with 3 users and provides 2 endpoints for searching users and adding users.

## Use

Copy the repository to your local machine and open the solution using Visual Studio. Run the solution and a local window should open that contains the 2 endpoints (Search and Add) of the UserController. Shown below.

![image](https://user-images.githubusercontent.com/54779892/121532514-071ccb80-c9c5-11eb-9986-3543c6b525d7.png)

Click on the endpoint that you'd like to use and then click the Try It Out Button.

![image](https://user-images.githubusercontent.com/54779892/121533847-48fa4180-c9c6-11eb-9027-1d288f7b7817.png)

Then enter the required input field and click Execute to execute the endpoint.

The Search endpoint returns a JSON list of the records that contain the input in their first name or last name. The Add endpoint adds the entered user into the database.

To view the current state of the database, open the SQL Server Object Explorer window. The window can be accessed via View -> SQL Server Object Explorer. 

Open the file path shown below and right click on the User table and select View Data to open the User table.

![image](https://user-images.githubusercontent.com/54779892/121533479-ee60e580-c9c5-11eb-86db-8d0e967b409a.png)


## Seeding

The database is initially seeded in the DBInitializer.cs class. The initial state of the database can be seen below.

![image](https://user-images.githubusercontent.com/54779892/121533120-9629e380-c9c5-11eb-843e-ebfd98659eaf.png)

## Testing

Testing is done in the APiDemo.Tests project. To run the tests go to View -> Test Explorer, right click on the project, and run the tests. 

![image](https://user-images.githubusercontent.com/54779892/121607627-fc3e5700-ca15-11eb-922d-fe2e0802c99d.png)




