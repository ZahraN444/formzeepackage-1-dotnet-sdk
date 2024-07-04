
# Name Verification Admission Attributes

## Structure

`NameVerificationAdmissionAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ActualName` | `string` | Optional | - |
| `Answer` | [`NameVerificationAdmissionAnswerEnum?`](../../doc/models/name-verification-admission-answer-enum.md) | Optional | - |
| `Reason` | `string` | Optional | - |
| `ReasonCode` | [`NameVerificationAdmissionReasonCodeEnum?`](../../doc/models/name-verification-admission-reason-code-enum.md) | Optional | - |
| `Status` | [`NameVerificationAdmissionStatusEnum`](../../doc/models/name-verification-admission-status-enum.md) | Required | - |
| `StatusReason` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "actual_name": "actual_name8",
  "answer": "confirmed",
  "reason": "reason2",
  "reason_code": "BAMM",
  "status": "confirmed",
  "status_reason": "status_reason8"
}
```

