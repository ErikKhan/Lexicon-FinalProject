# This is my Final Project "HollyView".
This project is for the **Movies enthusists**.<br>
*This project is built using C# in backend and ASP.Net in the front end with MVC (Model View Controller) Model*.<br>
Model–view–controller (MVC) is a software architectural pattern commonly used for developing user interfaces that divide the related program logic into three interconnected elements.<br>
- **This is a simple CRUD project** having different roles for users, Non-user and Admin. <br> 
- This project is more like a clone wikipedia where an admin can Post a movie and the users can only edit or can add more information about that particular movie. The main Index Page has been divided into different Sections.<br>
  - Navbar
  ![navbar](https://user-images.githubusercontent.com/73182090/177760189-e60c60ca-4fc9-4cb2-9df3-3fb2d970524f.png)
  - Hero WallPaper
  ![hero](https://user-images.githubusercontent.com/73182090/177760248-ed023fc0-596d-4f4b-8e2f-f615f34c5646.png)
  - Cards
  ![card](https://user-images.githubusercontent.com/73182090/177760298-363ad26c-0a5d-48d8-be44-0419acc65d0f.png)
  - Footer
  ![footer](https://user-images.githubusercontent.com/73182090/177760346-245d76f7-62da-45cf-9f9f-532b9ec5ce5f.png)
  - A search bar functionality is also used to Find the particular movie using the NAME of the movie. <br>
  ![home](https://user-images.githubusercontent.com/73182090/177759269-98896850-8b07-4690-a738-fef4a16919de.png)
  - Movie Home Page
  ![home](https://user-images.githubusercontent.com/73182090/177760718-4fcee8b3-b1c9-4a6e-8512-d6d6ebd59a91.png)
  - Individual cards for Edit and deleting a movie
  ![detail](https://user-images.githubusercontent.com/73182090/177760814-7ded4afc-3003-4666-894f-7ec9cd6e446f.png)
- Authentication is required for securely validating the user identity and it is a crucial precursor to authorization.  
- Authorization policies start after the authentication process completes. The authorization process determines what data you can access.<br>   
The Project has been divided into three main authorization process: <br>
This has been done by using built-in function [Authorization] But in Database
(Microsoft SQL Database) the creator should give roles to admin, and authenticated users. For Autentication, user must register first and then Log-in to get the
full access of the website.<br>
1. Admin - Admin has the full authorization. It can do all the CRUD operations e.g. Create, Read, update and delete.<br>
![logIn](https://user-images.githubusercontent.com/73182090/177760562-efeedac8-6a9c-41a3-81dc-45307b9b02fa.png)
2. User - User can only read and update the data.<br>
3. Non-user - It can only view the user interface. If the non-user clicks on create, delete or update it will give the user "Permission denined" and will
go to the register page.<br>
![authorization](https://user-images.githubusercontent.com/73182090/177758946-9308e7d8-3d7d-4cb5-99aa-62d7e4c8339a.png)

**Stack used in this project:**<br>
Backend: C#<br>
DataBase: Microsoft SQL Server. Entity framework<br>
Front-end: ASP.Net, Razor Pages, CSS, Bootstrap, Javascript.<br>
**This is my other project "Blog" where I have used one to many relationship and used ViewModel**
[One to Many relationship Project](https://github.com/ErikKhan/MyBlogViewModel)
![comment](https://user-images.githubusercontent.com/73182090/177770949-f47ccd33-85fe-4297-ae78-77924177e493.png)

