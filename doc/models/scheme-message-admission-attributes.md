
# Scheme Message Admission Attributes

## Structure

`SchemeMessageAdmissionAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdmissionDatetime` | `DateTime?` | Optional | - |
| `SchemeStatusCode` | `string` | Optional | - |
| `SchemeStatusCodeDescription` | `string` | Optional | - |
| `Status` | [`SchemeMessageAdmissionStatusEnum?`](../../doc/models/scheme-message-admission-status-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "admission_datetime": "2016-03-13T12:52:32.123Z",
  "scheme_status_code": "scheme_status_code8",
  "scheme_status_code_description": "scheme_status_code_description6",
  "status": "delivery_confirmed"
}
```

