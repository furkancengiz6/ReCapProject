# ReCapProject

A comprehensive **Car Rental Management System** developed using the **C# .NET Core** framework. This project demonstrates a multi-layered architecture with advanced features for managing rental services, customers, vehicles, and related operations.

---

## **Features**

### **1. Vehicle Management**
- Add, update, and delete vehicles.
- View a list of all available vehicles.
- Search and filter vehicles by brand, model, and price range.

### **2. Customer Management**
- Add new customers and manage customer information.
- Associate customers with rental transactions.

### **3. Rental Management**
- Book vehicles for customers.
- Manage rental records (start date, return date, total cost).
- Track active rentals and available vehicles.

### **4. Brand and Model Management**
- Add and manage vehicle brands and models.
- Link models to their respective brands for efficient categorization.

### **5. User Authentication**
- Implemented JWT (JSON Web Tokens) for secure user authentication.
- Role-based access control for admin and standard users.

---

## **Technologies Used**

- **Backend**: ASP.NET Core 6.0, Entity Framework Core
- **Frontend**: (Option to integrate Angular/React/Blazor, if applicable)
- **Database**: Microsoft SQL Server
- **Dependency Injection**: Built-in DI Container
- **API**: RESTful API with Swagger Documentation
- **Authentication**: JWT (JSON Web Token)
- **Architecture**: Multi-layered architecture with:
  - Core Layer
  - Data Access Layer
  - Business Logic Layer
  - Web API Layer

---

## **Setup Instructions**

### **Prerequisites**
- Visual Studio 2022 or later.
- .NET 6.0 SDK installed.
- SQL Server configured and running.

### **Steps to Run Locally**
1. **Clone the Repository**  
   ```bash
   git clone https://github.com/furkancengiz6/ReCapProject.git
   cd ReCapProject
