
# Application.Configuration_PopulateLargeSaleTable

## Business Purpose
The `Configuration_PopulateLargeSaleTable` procedure initializes and populates a table with estimated sales data for the year 2012, structured for partitioning and indexing. It manages data lineage and handles partitioned columnstore indexing for performance improvements.

## Parameters
| Name               | Type    | Direction | Default    |
|--------------------|---------|-----------|------------|
| @EstimatedRowsFor2012 | bigint | IN        | 12000000   |

## Tables
| Table              | Operations |
|--------------------|------------|
| Integration.Lineage | INSERT     |
| Fact.Sale           | SELECT     |

## Calls
| Procedure / Function                              | Type |
|---------------------------------------------------|------|
| Integration.PopulateDateDimensionForYear          | EXEC |
| Application.Configuration_ApplyPartitionedColumnstoreIndexing | EXEC |

## Business Rules
- Uses estimated rows for sales calculations over a given year.
- Applies partitioned columnstore indexing for optimized data insertions and access patterns.

## Technical Debt
| Item                     | Severity |
|--------------------------|----------|
| Missing TRY/CATCH        | Medium   |
| Hard-coded year          | Medium   |
