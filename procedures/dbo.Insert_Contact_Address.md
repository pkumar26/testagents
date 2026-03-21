# dbo.InsertContactAddress

## Business Purpose
Inserts address information into `dbo.ContactAddresses` after formatting the street and city names.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|--------|
| @ContactId | INT | IN | — |
| @HouseNumber | VARCHAR(200) | IN | — |
| @Street | VARCHAR(200) | IN | — |
| @City | VARCHAR(200) | IN | — |
| @Postcode | VARCHAR(20) | IN | — |

## Tables
| Table | Operations |
|-------|------------|
| dbo.ContactAddresses | INSERT, SELECT |

## Business Rules
- Ensure street and city names are properly capitalized.

## Technical Debt
| Item | Severity |
|------|----------|
| Possible hard-coded magic number | Low |
| No TRY...CATCH error handling | High |
| Write operations without explicit transaction management | High |
