# Megalontest - Customer Orders Application

This repository contains the solution for the Megalon Coding Test, structured into three projects: `CustomerOrders.Data` (data access), `CustomerOrders.Api` (backend API), and `CustomerOrders.App` (Blazor Hybrid UI).

## Getting Started

### Prerequisites

* [cite_start]Visual Studio 2022 (.NET 8.0 SDK, ASP.NET, Data Storage workloads)[cite: 4, 17].
* [cite_start]SQL Server LocalDB[cite: 4].

### Running Instructions

1.  **Clone Repository**: `git clone https://github.com/rcvl13/megalontest.git`
2.  **Open Solution**: Open `megalontest.sln` in Visual Studio.
3.  **Database Setup**:
    * In Package Manager Console, set "Default project" to `CustomerOrders.Data`.
    * Run `Update-Database`.
    * *(Troubleshooting: If "object already exists" or deployment errors occur, delete `CustomerOrdersDB` from SQL Server Object Explorer, uninstall `CustomerOrders.App` from Windows Settings, delete `bin`/`obj` folders from all projects, restart PC, open VS as Admin, then re-run `Update-Database`)*.
4.  **Run Application**: Press `F5`.
    * `CustomerOrders.Api` (Swagger) and `CustomerOrders.App` (Blazor desktop app) will launch.
    * **Note**: Blazor app connects to API on `https://localhost:[YOUR_API_PORT]/`. Verify port in `CustomerOrders.Api\Properties\launchSettings.json`.

### Verification

* [cite_start]**API**: Test `https://localhost:[YOUR_API_PORT]/swagger` (e.g., `/api/Customers` for list with orders in JSON)[cite: 14, 15].
* [cite_start]**Blazor App**: Navigate to "Customers" for list; click "View Orders" for details[cite: 17, 20].

---
