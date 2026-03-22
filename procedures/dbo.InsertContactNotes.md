# dbo.InsertContactNotes

## Business Purpose
This procedure inserts notes associated with a specific contact into the database. It manages notes as a list of values passed as comma-separated text.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|--------|
| @ContactId | INT | IN | — |
| @Notes | VARCHAR(MAX) | IN | — |

## Tables
| Table | Operations |
|-------|------------|
| dbo.ContactNotes | INSERT, SELECT, SELECT INTO |

## Business Rules
- Converts notes string into table data using STRING_SPLIT
- Deletes processed notes from internal table after insertion

## Technical Debt
| Item | Severity |
|------|----------|
| Uses SELECT * — specify columns explicitly | Low |
| No TRY...CATCH error handling | High |
| Write operations without explicit transaction management | High |
