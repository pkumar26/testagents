# dbo.Create_Type_Driving_License

## Business Purpose
Creates a user-defined type `DrivingLicense` of fixed length `CHAR(16)` ensuring non-nullability for driving license numbers.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|--------|
| —    | —    | —         | —      |

## Tables
| Table | Operations |
|-------|------------|
| —     | —          |

## Business Rules
- Store driving license with fixed and enforced constraints.

## Technical Debt
| Item | Severity |
|------|----------|
| No TRY...CATCH error handling | High |
