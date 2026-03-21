# dbo.InsertContactNotes_CSV_while_loop

## Business Purpose
Used to insert contact notes using a SSP value while looping through notes until they are exhausted.


## Parameters

| Name | Type | Direction | Default |
| @ContactId | INT  | IN | - |
| @Notes | VARCHAR(MAW) | IN ? - | 


## Tables Accessed

| Table | Operations |
|-------------||-----------------|
| dbo.ContactNotes | SELECT, INSERST, DELETE|


## Technical Debt

| Item | Severity |
|--------------||-----------------|
| Uses SELECT * <specify columns explicitly> | Low |
| Wirite operations without explicit transaction management | High |
| No TRY..CATCH sheme error handling | High |
