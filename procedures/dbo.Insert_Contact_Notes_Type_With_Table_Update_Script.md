# dbo.InsertContactNotes

## Business Purpose
Inserts contact notes using a table type, allows bulk insertion and updates note preview.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|---------|
| @ContactId | INT | IN | — |
| @Notes | ContactNote READONLY | IN | — |

## Tables
| Table | Operations |
|-------|------------|
| dbo.ContactNotes | INSERT, SELECT |

## Business Rules
- Bulk insert notes and prefix them for visibility.

## Technical Debt
| Item | Severity |
|------|----------|
| No TRY...CATCH error handling | High |
| Write operations without explicit transaction management | High |
| Uses SELECT * | Low |
