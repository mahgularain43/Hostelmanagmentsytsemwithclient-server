# Hostel Management System (Client–Server)

A **WinForms application** built with **C#** and **SQL Server** to manage hostel operations.  
The project follows a **client–server architecture**, where the WinForms app acts as the client interface and SQL Server serves as the backend database.

---

## 📌 Features
- **Student Management**
  - Registration & profile management
  - Room allotment
  - Fee tracking & billing
  - Complaints submission (student) and resolution (admin)

- **Admin & Staff Management**
  - Staff salary management
  - Utility bills tracking
  - Complaints monitoring (admin panel)
  - Rooms management (availability, assignment, updates)

- **Chat System**
  - Student ↔ Server communication
  - Admin ↔ Student interaction

- **Other Modules**
  - Activity calendar
  - Menu display
  - Options and custom controls for UI enhancement

---

## 🛠️ Tech Stack
- **Frontend:** Windows Forms (C#)
- **Backend:** SQL Server (hosteldb.bacpac included)
- **Architecture:** Client–Server

---

## 🚀 Getting Started
1. Clone this repository:
   ```bash
   git clone https://github.com/<your-username>/HostelManagementSystem.git


Open the solution file (hostelproject.sln) in Visual Studio.

Restore/attach the database:

Use hosteldb.bacpac to import the database into SQL Server.

Update the connection string in your function.cs file (or wherever DB connection is defined).

Run the project.

## 📂 Repository Structure
├─ *.cs / *.Designer.cs / *.resx   # WinForms UI and logic files
├─ hosteldb.bacpac.zip             # SQL Server database export
├─ hostelproject.sln               # Visual Studio solution
├─ hostelproject.csproj            # Project file
└─ README.md

## 👨‍💻 Author

mahgularain43, Barirah and Sara Najam

## ⚠️ Note

This is an academic/learning project. It is not optimized for production use.
