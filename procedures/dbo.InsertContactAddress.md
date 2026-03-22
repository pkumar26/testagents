# dbo.InsertContactAddress

## Business Purpose
The procedure manages the insertion of contact addresses ensuring formatted capitalization of street and city names.

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
| dbo.ContactAddresses | INSERT, SELECT, SELECT INTO |

## Business Rules
- Formats street and city names to proper case

## Technical Debt
| Item | Severity |
|------|----------|
| Possible hard-coded magic number | Low |
| No TRY...CATCH error handling | High |
| Write operations without explicit transaction management | High |
