
# Name Verification Submission Attributes

## Structure

`NameVerificationSubmissionAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ActualName` | `string` | Optional | - |
| `Answer` | [`NameVerificationSubmissionAnswerEnum?`](../../doc/models/name-verification-submission-answer-enum.md) | Optional | - |
| `Reason` | `string` | Optional | - |
| `ReasonCode` | [`NameVerificationSubmissionReasonCodeEnum?`](../../doc/models/name-verification-submission-reason-code-enum.md) | Optional | - |
| `Status` | [`NameVerificationSubmissionStatusEnum`](../../doc/models/name-verification-submission-status-enum.md) | Required | - |
| `StatusReason` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "actual_name": "actual_name4",
  "answer": "confirmed",
  "reason": "reason0",
  "reason_code": "BAMM",
  "status": "delivery_confirmed",
  "status_reason": "status_reason6"
}
```

