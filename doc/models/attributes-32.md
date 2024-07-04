
# Attributes 32

## Structure

`Attributes32`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdmissionDatetime` | `DateTime?` | Optional | - |
| `SchemeStatusCode` | `string` | Optional | - |
| `SchemeStatusCodeDescription` | `string` | Optional | - |
| `SettlementCycle` | `int?` | Optional | **Constraints**: `>= 0` |
| `SettlementDate` | `DateTime?` | Optional | - |
| `Status` | [`DirectDebitReturnAdmissionStatusEnum?`](../../doc/models/direct-debit-return-admission-status-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "admission_datetime": "2016-03-13T12:52:32.123Z",
  "scheme_status_code": "scheme_status_code2",
  "scheme_status_code_description": "scheme_status_code_description0",
  "settlement_cycle": 16,
  "settlement_date": "2016-03-13"
}
```

