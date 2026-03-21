# dbo.InsertContactNotes

## Business Purpose
Inserts multiple notes using a cursor from a CSV input.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|--------|
| @ContactId | INT | IN | — |
| @Notes | VARCHAR(MAX) | IN | — |

## Tables
| Table | Operations |
|-------|------------|
| dbo.ContactNotes | INSERT, SELECT |
| STRING_SPLIT | SELECT |

## Business Rules
- Cursor iterates through notes.

## Technical Debt
| Item | Severity |
|------|----------|
| Uses cursor instead of set-based logic | Medium |
| Uses SELECT * | Low |
| No TRY...CATCH error handling | High |
| Write operations without explicit transaction management | High |
