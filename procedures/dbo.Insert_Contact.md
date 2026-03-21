# dbo.InsertContact

## Business Purpose
Inserts new contacts into the `dbo.Contacts` table, ensuring no duplicates are present.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|---------|
| @FirstName | VARCHAR(40) | IN | — |
| @LastName | VARCHAR(40) | IN | — |
| @DateOfBirth | DATE | IN | NULL |
| @AllowContactByPhone | BIT | IN | — |
| @ContactId | INT | OUT | — |

## Tables
| Table | Operations |
|-------|------------|
| dbo.Contacts | INSERT, SELECT |

## Calls
| Procedure / Function | Type |
|----------------------|------|
| dbo.SelectContact | EXEC |

## Business Rules
- Avoid inserting duplicate contacts.

## Technical Debt
| Item | Severity |
|------|----------|
| Write operations without explicit transaction management | High |
| No TRY...CATCH error handling | High |
