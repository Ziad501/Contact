# Contact

This project is a **Windows Forms Application** designed using the **3-Tier Architecture**, which separates the application into three layers:

## **Presentation Layer (UI Layer):**
- Developed using **Windows Forms (WinForms)** to provide an interactive user interface.
- Allows users to perform **CRUD (Create, Read, Update, Delete) operations** on the database through user-friendly forms.
- Implements **data validation** to ensure input integrity.

## **Business Logic Layer (BLL):**
- Acts as a bridge between the **Presentation Layer** and the **Data Access Layer**.
- Contains **business rules, validation, and logic** for processing data before interacting with the database.
- Ensures proper **data manipulation and integrity** before storing or retrieving data.

## **Data Access Layer (DAL):**
- Uses **Entity Framework Core (EF Core)** to interact with the **SQL Server database**.
- Provides an abstraction over raw SQL queries, enabling seamless database operations through **LINQ and EF Core’s DbContext**.
- Handles database **CRUD operations** efficiently while maintaining **separation of concerns**.

## **Key Features:**
✅ **CRUD Operations** – Users can **Create, Read, Update, and Delete** records from the database using a user-friendly Windows Forms interface.  
✅ **Entity Framework Core** – Simplifies database interactions by leveraging **EF Core’s ORM capabilities**.  
✅ **SQL Server Integration** – Stores and manages data in a structured manner using **Microsoft SQL Server**.  
✅ **3-Tier Architecture** – Enhances **scalability, maintainability, and modularity** by separating UI, business logic, and data access.  
✅ **Data Validation** – Ensures **data consistency** before saving to the database.  
✅ **User-Friendly Interface** – Provides an intuitive design for **seamless user interaction**.  

## **Technologies Used:**
- **C# (.NET Framework/.NET Core)** – Core programming language for Windows Forms.
- **Windows Forms (WinForms)** – User interface development.
- **Entity Framework Core** – ORM for database access.
- **SQL Server** – Backend relational database.

This **3-Tier Windows Forms Application** ensures **efficient database management** while keeping the application well-structured and easy to maintain. 🚀
