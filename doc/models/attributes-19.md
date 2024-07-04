
# Attributes 19

## Structure

`Attributes19`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AcceptanceQualifier` | [`AcceptanceQualifierEnum?`](../../doc/models/acceptance-qualifier-enum.md) | Optional | All accepted payments will receive the matching qualifier code |
| `ReferenceMask` | `string` | Optional | Account number of the account. A unique number will automatically be generated if not provided. |
| `UserDefinedData` | [`List<UserDefinedData>`](../../doc/models/user-defined-data.md) | Optional | All purpose list of key-value pairs to store specific data.<br>**Constraints**: *Maximum Items*: `5` |
| `ValidationType` | [`BranchValidationTypeEnum?`](../../doc/models/branch-validation-type-enum.md) | Optional | optional validation to apply to the branch |

## Example (as JSON)

```json
{
  "reference_mask": "41426819",
  "acceptance_qualifier": "next_calendar_day",
  "user_defined_data": [
    {
      "key": "key6",
      "value": "value8"
    }
  ],
  "validation_type": "account_mod_check"
}
```

