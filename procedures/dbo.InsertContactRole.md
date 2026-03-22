# dbo.InsertContactRole

## Business Purpose
Associates roles with contacts, ensuring roles exist before assigning them.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|--------|
| @ContactId | INT | IN | — |
| @RoleTitle | VARCHAR(200) | IN | — |

## Tables
| Table | Operations |
|-------|------------|
| dbo.ContactRoles | INSERT, SELECT, SELECT INTO |
| dbo.Contacts | SELECT |
| dbo.Roles | INSERT, SELECT, SELECT INTO |

## Business Rules
- Rolls back transaction on error during the role assignment process

## Technical Debt
| Item | Severity |
|------|----------|
| Possible hard-coded magic number | Low |
