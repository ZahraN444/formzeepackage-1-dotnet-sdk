
# Attributes 34

## Structure

`Attributes34`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FileIdentifier` | `string` | Optional | **Constraints**: *Pattern*: `^[0-9a-zA-Z]+$` |
| `FileNumber` | `string` | Optional | **Constraints**: *Pattern*: `^[0-9]+$` |
| `SchemeStatusCode` | `string` | Optional | - |
| `SchemeStatusCodeDescription` | `string` | Optional | - |
| `Status` | [`DirectDebitReturnSubmissionStatusEnum?`](../../doc/models/direct-debit-return-submission-status-enum.md) | Optional | - |
| `StatusReason` | `string` | Optional | - |
| `SubmissionDatetime` | `DateTime?` | Optional | - |
| `TransactionStartDatetime` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "file_identifier": "file_identifier2",
  "file_number": "file_number0",
  "scheme_status_code": "scheme_status_code2",
  "scheme_status_code_description": "scheme_status_code_description0",
  "status": "delivery_confirmed"
}
```

