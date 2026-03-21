# dbo.InsertContactRole

## Business Purpose
Associates contacts with roles, ensuring roles are inserted if not present.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|--------|
| @ContactId | INT | IN | — |
| @RoleTitle | VARCHAR(200) | IN | — |

## Tables
| Table | Operations |
|-------|------------|
| dbo.Roles | INSERT, SELECT |
| dbo.ContactRoles | INSERT, SELECT |
| dbo.Contacts | SELECT |

## Business Rules
- Ensure roles are linked uniquely to contacts.

## Technical Debt
| Item | Severity |
|------|----------|
| Possible hard-coded magic number | Low |
