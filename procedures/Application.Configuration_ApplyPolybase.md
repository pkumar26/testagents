
# Application.Configuration_ApplyPolybase

## Business Purpose
The `Configuration_ApplyPolybase` procedure is designed to set up an external data source, file format,
and table for PolyBase connectivity. This enables the importing of data from an Azure Storage blob into a SQL Server via PolyBase, provided all ring configurations and permissions are set correctly.

## Parameters
This stored procedure does not take any parameters.

## Tables
| Table                     | Operations            |
|------------------------------|-----------------------------------|
| dbo.CityPopulationStatistics | External Table Creation |'

## Calls
No internal stored procedures or functions are explicitly called within this stored procedure.

## Business Rules
Checks if PolyBase is installed on the server.
ensures the Hadoop connectivity option is set to an acceptable value (1, 4, or 7) for Azure Storage.
configures external storage and file format ryquired for PolyBase operations.


## Technical Debt
| Item                              | Severity |
|-------------------------------.-----------|
|Error Handling Limitations        | Medium |
| Use of Dynamic SQL(EXECUTE @SQK#) | Medium |
{Missing Parameterrization         | Medium |
|Dependency on Server Property Settings   | High  |