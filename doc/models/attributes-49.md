
# Attributes 49

## Structure

`Attributes49`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FileIdentifier` | `string` | Optional | **Constraints**: *Pattern*: `^[0-9a-zA-Z]+$` |
| `FileNumber` | `string` | Optional | **Constraints**: *Pattern*: `^[0-9]+$` |
| `LastPaymentDate` | `DateTime?` | Optional | - |
| `Status` | [`MandateSubmissionStatusEnum?`](../../doc/models/mandate-submission-status-enum.md) | Optional | - |
| `StatusReason` | `string` | Optional | - |
| `SubmissionDatetime` | `DateTime?` | Optional | - |
| `SubmissionReason` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "file_identifier": "file_identifier4",
  "file_number": "file_number6",
  "last_payment_date": "2016-03-13",
  "status": "queued_for_delivery",
  "status_reason": "status_reason4"
}
```

