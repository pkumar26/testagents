# SP Mining Analysis

Generated: 2023-11-17
Source repo: Burakkylmz/Programming_SQL_Server_Database
Total procedures: 3

## Procedure Summary

| Proc Name | Business Purpose | Tables (Operations) | Top Rule | Debt # |
|-----------|-----------------|---------------------|----------|--------|
| [dbo.InsertContactNotes](procedures/dbo.InsertContactNotes.md) | Inserts contact notes from a comma-separated list | ContactNotes (INSERT, SELECT) | Converts notes using STRING_SPLIT | 3 |
| [dbo.InsertContactAddress](procedures/dbo.InsertContactAddress.md) | Inserts contact addresses with proper name formatting | ContactAddresses (INSERT, SELECT) | Formats street/city names | 3 |
| [dbo.InsertContactRole](procedures/dbo.InsertContactRole.md) | Assigns roles to contacts ensuring roles exist | ContactRoles (INSERT, SELECT), Roles (INSERT, SELECT), Contacts (SELECT) | Rolls back on error during assignment | 1 |

## Insights
- **Most-referenced tables (top 5):** ContactNotes, ContactAddresses, ContactRoles, Roles, Contacts
- **Most common debt categories:** Missing TRY/CATCH, Unmanaged transactions
- **Recommended priority fixes:** Add error handling and transaction management
