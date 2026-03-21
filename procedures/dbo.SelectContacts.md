# dbo.SelectContacts

## Business Purpose
Selects contacts from `dbo.Contacts` with the first name 'Grace'.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|--------|
| —    | —    | —         | —      |

## Tables
| Table | Operations |
|-------|------------|
| dbo.Contacts | SELECT |

## Calls
| Procedure / Function | Type |
|----------------------|------|
| dbo.SelectContacts | EXEC |

## Business Rules
- Fetch all records matching specific first name.

## Technical Debt
| Item | Severity |
|------|----------|
| Uses SELECT * | Low |
| No TRY...CATCH error handling | High |
