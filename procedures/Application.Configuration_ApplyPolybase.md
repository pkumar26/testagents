
# Application.Configuration_ApplyPolybase

## Business Purpose
The `Configuration_ApplyPolybase` procedure configures Polybase connectivity for a SQL Server environment, enabling data access from Azure Storage. It checks if Polybase is installed and configured appropriately before creating necessary external data sources and tables.

## Parameters
| Name | Type | Direction | Default |
|-------|-----------|--------|
| None |      |           |        |

## Tables
| Table | Operations |
|-------|------------|
| dbo.CityPopulationStatistics | CREATE EXTERNAL TABLE |

## Calls
| Procedure / Function | Type |
|----------------------|------|
| Dynamic SQL Execution | EXEC |

## Business Rules
- If Polybase is not installed, the procedure issues a warning.
- Formulates external table configuration only when Polybase is created and connectivity is correctly set to enhance access through Azure Storage.

## Technical Debt
| Item | Severity |
|------|----------|
| Dynamic SQL without parameterization | Medium |
| Polybase Check Hardcoded | Low |
