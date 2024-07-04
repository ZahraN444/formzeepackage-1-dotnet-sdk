
# Attributes 9

## Structure

`Attributes9`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdmissionDatetime` | `DateTime?` | Optional | Date and time the payment admission was created |
| `Route` | [`Route1Enum?`](../../doc/models/route-1-enum.md) | Optional | Route taken for a return |
| `SchemeStatusCode` | `string` | Optional | Refer to individual scheme where applicable |
| `SchemeStatusCodeDescription` | `string` | Optional | [Description](http://api-docs.form3.tech/api.html#enumerations-scheme-status-codes-for-bacs) of `scheme_status_code` |
| `SettlementCycle` | `int?` | Optional | Cycle in which the payment will be settled<br>**Constraints**: `>= 0` |
| `SettlementDate` | `DateTime?` | Optional | Date on which the payment will be settled |
| `Status` | [`ReturnAdmissionStatusEnum?`](../../doc/models/return-admission-status-enum.md) | Optional | [Status](http://draft-api-docs.form3.tech/api.html#enumerations-payment-admission-status) of the return admission |
| `StatusReason` | `string` | Optional | Further explanation of the status. [See here](http://api-docs.form3.tech/api.html#enumerations-payment-admission-status-reasons) for possible values. |
| `UniqueSchemeId` | `string` | Optional | Scheme-specific unique ID (42 character string) |

## Example (as JSON)

```json
{
  "admission_datetime": "09/28/2017 14:21:46",
  "scheme_status_code": "1001",
  "scheme_status_code_description": "Field 1 (destination sorting code) was invalid",
  "settlement_cycle": 1,
  "settlement_date": "2017-01-14",
  "status": "confirmed",
  "status_reason": "Account data invalid",
  "route": "on_us"
}
```

