
# Attributes 61

## Structure

`Attributes61`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SchemeStatusCode` | `string` | Optional | Scheme-specific status code. Refer to scheme documentation where available. |
| `Status` | [`RecallSubmissionStatusEnum?`](../../doc/models/recall-submission-status-enum.md) | Optional | [Status](http://draft-api-docs.form3.tech/api.html#enumerations-payment-status-codes-payment-submission-status) of the submission |
| `StatusReason` | `string` | Optional | Reason for submission failure if submission status is `delivery_failed` |

## Example (as JSON)

```json
{
  "scheme_status_code": "RR04",
  "status": "accepted",
  "status_reason": "Gateway failure"
}
```

