# SP Mining Analysis

Generated: 2023-11-20
Source repo: Burakkylmz/Programming_SQL_Server_Database
Total procedures: 9

## Procedure Summary

| Proc Name | Business Purpose | Tables (Operations) | Top Rule | Debt # |
|-----------|-----------------|---------------------|----------|--------|
| [dbo.Create_Type_ContactNote](procedures/dbo.Create_Type_ContactNote.md) | Creates table type for contact notes | — | Ensure notes are non-nullable | 1 |
| [dbo.Create_Type_Driving_License](procedures/dbo.Create_Type_Driving_License.md) | Creates CHAR type for driving licenses | — | Ensure driving license number fixed length | 1 |
| [dbo.InsertContactNotes](procedures/dbo.Insert_Contact_Notes_CSV_Version_While_Loop.md) | Inserts notes from CSV string | ContactNotes (INSERT, DELETE, SELECT) | Only insert unique notes for a contact | 3 |
| [dbo.InsertContactNotes](procedures/dbo.Insert_Contact_Notes_Type_With_Table_Update_Script.md) | Inserts notes using table type | ContactNotes (INSERT, SELECT) | Bulk insert with note preview | 3 |
| [dbo.InsertContactAddress](procedures/dbo.Insert_Contact_Address.md) | Inserts address details with formatting | ContactAddresses (INSERT, SELECT) | Ensure names are capitalized | 3 |
| [dbo.InsertContactNotes](procedures/dbo.Insert_Contact_Notes_Cursor.md) | Inserts notes using cursor | ContactNotes (INSERT, SELECT) | Cursor iterates through notes | 4 |
| [dbo.InsertContactRole](procedures/dbo.Insert_Contact_Role.md) | Links contacts with roles | Roles (INSERT, SELECT), ContactRoles (INSERT, SELECT), Contacts (SELECT) | Link roles uniquely to contacts | 1 |
| [dbo.InsertContact](procedures/dbo.Insert_Contact.md) | Inserts unique contact entries | Contacts (INSERT, SELECT) | Avoid duplicates on contacts | 2 |
| [dbo.SelectContacts](procedures/dbo.SelectContacts.md) | Retrieves contacts named Grace | Contacts (SELECT) | Fetch by specific first name | 2 |

## Insights
- **Most-referenced tables (top 5):** dbo.ContactNotes, dbo.Roles, dbo.Contacts, dbo.ContactAddresses
- **Most common debt categories:** Error handling (TRY...CATCH), Transaction management
- **Recommended priority fixes:** Implement TRY...CATCH error handling
