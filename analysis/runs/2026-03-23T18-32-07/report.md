
# Stored Procedure Analysis Report

## Executive Summary
- **Total Procedures Analyzed**: 14
- **Domain Breakdown**:
  - Security: 4
  - Reporting: 2
  - Performance: 5

## Dependency Graph
- `Configuration_ApplyFullTextIndexing` calls procedures related to searching.
- `Configuration_DisableInMemory` affects customer orders and temperatures recording.
- `Configuration_ConfigureForEnterpriseEdition` applies indexing, memory, and partition configurations.

## Top Technical Debt Patterns
- **Dynamic SQL**: High severity in multiple procedures.

