
# Attributes 5

## Structure

`Attributes5`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdmissionDatetime` | `DateTime?` | Optional | Date and time the payment admission was created |
| `ClearingSystem` | `string` | Optional | Clearing infrastructure through which the payment instruction was processed<br>**Constraints**: *Pattern*: `^[0-9A-Za-z_]*$` |
| `Route` | [`RouteEnum?`](../../doc/models/route-enum.md) | Optional | Route taken for an outbound payment |
| `SchemeStatusCode` | `string` | Optional | Refers to individual scheme where applicable |
| `SchemeStatusCodeDescription` | `string` | Optional | [Description](http://api-docs.form3.tech/api.html#enumerations-scheme-status-codes-for-bacs) of `scheme_status_code` |
| `SettlementCycle` | `int?` | Optional | Cycle in which the payment will be settled<br>**Constraints**: `>= 0` |
| `SettlementDate` | `DateTime?` | Optional | Date on which the payment will be settled |
| `Status` | [`PaymentAdmissionStatusEnum?`](../../doc/models/payment-admission-status-enum.md) | Optional | [Status of the admission](https://api-docs.form3.tech/api.html#enumerations-payment-status-codes-admission-status) |
| `StatusReason` | [`PaymentAdmissionStatusReasonEnum?`](../../doc/models/payment-admission-status-reason-enum.md) | Optional | [Payment admission status reason](https://api-docs.form3.tech/api.html#enumerations-payment-status-codes-payment-admission-status-reasons) |

## Example (as JSON)

```json
{
  "admission_datetime": "09/26/2017 15:26:57",
  "clearing_system": "TIPS",
  "scheme_status_code": "10001",
  "scheme_status_code_description": "Field 1 (destination sorting code) was invalid",
  "settlement_cycle": 1,
  "settlement_date": "2017-09-28",
  "status": "confirmed",
  "status_reason": "accepted",
  "route": "on_us"
}
```

