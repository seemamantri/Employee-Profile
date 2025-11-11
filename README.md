\# ASP.NET User Management System (Up to Profile Page)



\## 📘 Project Overview

This project is a beginner-friendly User Management System built using ASP.NET Web Forms, C#, ADO.NET, and SQL Server.

It allows users to:

\- Register their details

\- Log in securely

\- View their personal profile

\- Log out safely



The project uses Stored Procedures for database operations and Session Management for security.



---



\## ⚙️ Technologies Used

\- Frontend: ASP.NET Web Forms (HTML + ASP Controls)

\- Backend: C#

\- Database: SQL Server

\- Data Access: ADO.NET

\- Security: Session-based authentication

\- Stored Procedures: Insert, Select, and Profile retrieval



---



\## 🧠 Features Implemented

| Page | Description |

|------|--------------|

| Registration.aspx | Allows users to enter their Name, Phone, and Email. Inserts data into SQL using stored procedure `sp\_InsertUser`. |

| Login.aspx | Validates Email and Phone against database using `sp\_Login`. If valid, redirects to Home page. |

| Home.aspx | Displays a welcome message using `Session\["Email"]`. Includes buttons for View Profile and Logout. |

| Profile.aspx | Displays logged-in user’s Name, Phone, and Email fetched from database using `sp\_GetUserProfile`. |

| Logout | Ends the user session and redirects to Login page. |



---



\## 🗂️ Database Structure

\*\*Database Name:\*\* userdb  

\*\*Table Name:\*\* UserInfo  



| Id | INT (Primary Key, Identity) | Unique user ID |

| Name | NVARCHAR(100) | User’s full name |

| Phone | NVARCHAR(15) | User’s phone number |

| Email | NVARCHAR(100) | User’s email address |







\## 🧩 Stored Procedures Used



\### 1️⃣ sp\_InsertUser

```sql

CREATE PROCEDURE sp\_InsertUser

&nbsp; @Name NVARCHAR(100),

&nbsp; @Phone NVARCHAR(15),

&nbsp; @Email NVARCHAR(100)

AS

BEGIN

&nbsp; INSERT INTO UserInfo (Name, Phone, Email)

&nbsp; VALUES (@Name, @Phone, @Email);

END;







2️⃣ sp\_Login

CREATE PROCEDURE sp\_Login

&nbsp; @Email NVARCHAR(100),

&nbsp; @Phone NVARCHAR(15)

AS

BEGIN

&nbsp; SELECT COUNT(\*) FROM UserInfo WHERE Email=@Email AND Phone=@Phone;

END;







3️⃣ sp\_GetUserProfile

CREATE PROCEDURE sp\_GetUserProfile

&nbsp; @Email NVARCHAR(100)

AS

BEGIN

&nbsp; SELECT Name, Phone, Email FROM UserInfo WHERE Email=@Email;

END;





🧭 Project Flow



Registration → Login → Home → Profile → Logout



🔒 Session Management



When the user logs in, Session\["Email"] stores their email.



Home and Profile pages check this session to allow only logged-in users.



On Logout, Session.Clear() removes session data and redirects to Login page.







✅ How to Run the Project



Open the project in Visual Studio.



In SQL Server Management Studio (SSMS):



Create a database named userdb.



Create a table UserInfo with columns: Id, Name, Phone, Email.



Create the three stored procedures shown above.



Update your connection string in the code if needed.



Set Login.aspx as the start page.



Run the project → Register → Login → View Profile → Logout.







Next Suggested Step:



After completing this:



Add Edit Profile Page (to update name or phone)



Add Change Password Page (for security)



Add Admin Page (to view all users)

