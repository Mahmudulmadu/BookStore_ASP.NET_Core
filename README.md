My_App is an ASP.NET Core MVC web application for managing a book selling website. It includes features such as category and product management, user registration, and role-based authorization.

## Features

- User registration and authentication with ASP.NET Identity
- Role-based access control (e.g., Admin role)
- CRUD operations for Categories and Products
- Product image upload and management
- Server-side validation and client-side validation scripts
- Responsive UI with Bootstrap and icons
- Rich text editing for product descriptions with TinyMCE
- API endpoints for managing products and categories
- Use of Repository and Unit of Work patterns for data access

## Technologies Used

- ASP.NET Core MVC (ASP.NET 9)
- Entity Framework Core with SQL Server
- ASP.NET Identity for authentication and authorization
- Bootstrap 5 for UI styling
- TinyMCE for rich text editing
- jQuery and DataTables for interactive product lists

## Project Structure

- `Controllers` — Contains MVC controllers for Categories, Products, and Identity
- `Models` — Contains domain models such as Category, Product, and ApplicationUser
- `Views` — Contains Razor views for managing categories and products
- `wwwroot/js` — Custom JavaScript files (e.g., product.js for DataTables)
- `Data` — Application database context (`ApplicationDbContext`) and seed data
- `Areas/Identity` — Identity UI pages and models

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- SQL Server or SQL Server Express
- Visual Studio 2022 or later (recommended)

### Setup Instructions

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/My_App.git
   cd My_App
Configure the connection string in appsettings.json:


"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=MyAppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Apply migrations and seed the database:


dotnet ef database update
Run the application:


Open your browser and navigate to https://localhost:code

Register a new user or login as Admin (if seeded)

Usage
Navigate to Categories to create, edit, or delete categories.

Navigate to Products to manage book products, upload images, and assign categories.

Admin users have full access to all features.

Contribution
Feel free to fork the repository and submit pull requests for improvements or bug fixes.

License
This project is licensed under the MIT License.

Happy coding! 🚀


