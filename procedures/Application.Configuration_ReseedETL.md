
# Application.Configuration_ReseedETL

## Business Purpose
The `Configuration_ReseedETL` procedure is designed to reset and reseed the ETL process in a data warehouse context. It updates cutoff times for ETL operations, truncates fact tables to refresh data, and deletes rows from dimension tables, preparing for a new ETL run.

## Parameters
This procedure does not use any parameters.

## Tables
| Table | Operations |
|-------|------------|
| Integration.ETL Cutoff | UPDATE |
| Fact.Movement | TRUNCATE |
| Fact.Order | TRUNCATE |
| Fact.Purchase | TRUNCATE |
| Fact.Sale | TRUNCATE |
| Fact.Stock Holding | TRUNCATE |
| Fact.Transaction | TRUNCATE |
| Dimension.City | DELETE |
| Dimension.Customer | DELETE |
| Dimension.Employee | DELETE |
| Dimension.Payment Method | DELETE |
| Dimension.Stock Item | DELETE |
| Dimension.Supplier | DELETE |
| Dimension.Transaction Type | DELETE |

## Business Rules
- Resets cutoff time for ETL processes to a specified starting datetime.
- Clears data from all major dimension and fact tables to allow new data loading.
- Deletes existing data from dimension tables to ensure complete reload during ETL.

## Technical Debt
| Item | Severity |
|------|----------|
| Hard-Coded datetime values | Medium |
| Missing TRY/CATCH for error handling | High |
| Lack of transactional control for multiple DELETE operations | High |
