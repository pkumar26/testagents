# dbo.InsertContactNotes

## Business Purpose
Inserts multiple contact notes in `dbo.ContactNotes` table by parsing a CSV string of notes.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|--------|
| @ContactId | INT | IN | — |
| @Notes | VARCHAR(MAX) | IN | — |

## Tables
| Table | Operations |
|-------|------------|
| dbo.ContactNotes | INSERT, DELETE, SELECT |
| sys.procedures | SELECT |

## Business Rules
- Only insert unique notes for a contact.

## Technical Debt
| Item | Severity |
|------|----------|
| No TRY...CATCH error handling | High |
| Write operations without explicit transaction management | High |
| Uses SELECT * | Low |
