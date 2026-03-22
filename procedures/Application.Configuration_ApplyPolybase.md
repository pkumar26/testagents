
# Application.Configuration_ApplyPolybase

## Business Purpose
The stored procedure `Configuration_ApplyPolybase` primarily aims to configure PolyBase connectivity within the SQL Server environment. It checks if PolyBase is installed and configured properly and provides warnings if requirements are not met.

## Parameters
| Name | Type | Direction | Default |
|------|------|-----------|--------|
| —    | —    | —         | —      |

## Tables
| Table | Operations |
|-------|------------|
| —     | —          |

## Business Rules
- Prints a warning if PolyBase is not installed.
- Checks that the 'hadoop connectivity' configuration is enabled and prints a warning if it is not.

## Technical Debt
| Item | Severity |
|------|----------|
| Missing TRY/CATCH | High |
