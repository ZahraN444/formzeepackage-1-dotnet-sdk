
# Attributes 45

## Structure

`Attributes45`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdmissionDatetime` | `DateTime?` | Optional | - |
| `SchemeStatusCode` | `string` | Optional | - |
| `SchemeStatusCodeDescription` | `string` | Optional | - |
| `Status` | [`MandateAdmissionStatusEnum?`](../../doc/models/mandate-admission-status-enum.md) | Optional | - |
| `StatusReason` | [`MandateAdmissionStatusReasonEnum?`](../../doc/models/mandate-admission-status-reason-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "admission_datetime": "2016-03-13T12:52:32.123Z",
  "scheme_status_code": "scheme_status_code4",
  "scheme_status_code_description": "scheme_status_code_description2",
  "status": "confirmed",
  "status_reason": "bankid_not_provisioned"
}
```

