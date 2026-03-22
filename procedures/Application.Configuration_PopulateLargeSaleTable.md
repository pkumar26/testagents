
# Application.Configuration_PopulateLargeSaleTable

## Business Purpose
The `Configuration_PopulateLargeSaleTable` procedure is designed to populate large-scale sales data for 2012, adjusting sales per day based on certain constraints, and managing lineage and indexing operations related to the sales data.

## Parameters
| Name                  | Type   | Direction | Default  |
|-----------------------|--------|-----------|----------|
| @EstimatedRowsFor2012 | bigint | IN        | 12000000 |

## Tables
| Table     | Operations                      |
|-----------|---------------------------------|
| Fact.Sale | ALTER, DROP CONSTRAINT, DROP INDEX |

## Calls
| Procedure / Function                              | Type            |
|---------------------------------------------------|-----------------|
| Integration.PopulateDateDimensionForYear          | EXEC            |
| [Application].Configuration_ApplyPartitionedColumnstoreIndexing | EXEC |

## Business Rules
- Limits the number of sales per day to a maximum of 50,000 to manage data size constraints.
- Drops certain table constraints and indexes on `Fact.Sale` to manage the batch load better.

## Technical Debt
| Item                                      | Severity |
|-------------------------------------------|----------|
| Magic Numbers                             | Medium   |
| Minimal Error Handling                    | High     |
| Constraint Management Risks               | High     |
