# FlowerShop – Course Project

This Windows Forms (.NET Framework 4.8) application automates the management of a decorative plant department, handling inventory, orders, supplies and user accounts via a SQL Server backend.

## Abstract  
The main goal was to consolidate all data about decorative plants into a single, user‑friendly system for administrators and customers. During development, I gained practical experience with MS SQL Server, .NET Framework 4.8, C# and ADO.NET, and applied conceptual, logical and physical database modeling. The resulting system lets users add, edit, delete, search, filter and sort records, as well as generate reports and statistics.

##  Technologies & Environment  
- **IDE:** Microsoft Visual Studio 2022  
- **Platform:** .NET Framework 4.8  
- **Language:** C# (WinForms)  
- **Data Access:** ADO.NET (SQL Server .NET Provider)  
- **Database:** Microsoft SQL Server Management Studio  
- **Modeling:** ER‑diagram & normalization via draw.io  
- **Minimum requirements:** Windows 7+, 2 GB RAM, 1 GHz CPU, .NET 4.8, 500 MB disk, SSD & Full HD display recommended 

## Database Design  
- **Entities:** User, Order, OrderItem, Plant, Batch, Supplier, Supply, Category, Material, PlantType, FlowerColor  
- **Normalization:** All tables in 3NF; ER‑diagram → logical model → normalized schema  
- **Key relations:**  
  - User 1→* Order  
  - Order 1→* OrderItem  
  - Plant 1→* OrderItem  
  - Supplier 1→* Supply 1→* Batch *←1 Plant  

## Features

### Administrator Module  
- **CRUD** for: Plants, Suppliers, Supplies, Batches, Categories, Materials, Plant Types, Colors, Users, Orders  
- **Order details** viewer & editor (add/remove plants, adjust quantities)  
- **Automatic stock update** on supply arrival and order fulfillment  
- **Filtering & sorting** across any table via custom queries  
- **Reports** (PDF): supply invoice, order receipt  
- **Statistics** (weekly/monthly/quarterly/yearly):  
  - New user registrations per day  
  - Supplies by supplier  
  - Top‑selling plants  
  - Daily order revenue 

### Customer Module  
- **Catalog**: search by name, filter by category/material/type/color, sort by name/price/size/weight   
- **Shopping Cart**: add plants with specified quantities  
- **Order Submission**: address & payment (card/cash) form; upon confirmation, stock adjusts automatically   

## Setup & Run  
1. **Clone** this repository.  
2. **Restore** the database: run `Scripts/CreateFlowerShopDB.sql` in SSMS.  
3. **Edit** `FLOWERshop/Properties/Settings.settings` → `ConnectionString` to match your SQL Server instance.  
4. **Build** & **Run** `FLOWERshop.exe` (`bin\Debug`).  
