
# Attributes 1

## Structure

`Attributes1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankCode` | `string` | Optional | - |
| `BankName` | `string` | Optional | - |
| `BankOfficeTitle` | `string` | Optional | - |
| `SupportedSchemes` | [`SupportedSchemes`](../../doc/models/supported-schemes.md) | Optional | - |

## Example (as JSON)

```json
{
  "bank_code": "bank_code0",
  "bank_name": "bank_name0",
  "bank_office_title": "bank_office_title6",
  "supported_schemes": {
    "BACS": {
      "accepts_payments": false,
      "account_switching": "ineligible",
      "allowed_transactions": [
        "CU",
        "BS",
        "DV"
      ],
      "service_status": "service_status6"
    },
    "CCC": {
      "accepts_payments": false,
      "service_status": "service_status0"
    },
    "CHAPS": {
      "accepts_payments": false,
      "service_status": "service_status2"
    },
    "FPS": {
      "accepts_payments": false,
      "handling_bank_code": "handling_bank_code6",
      "handling_bank_connection": "handling_bank_connection2",
      "service_status": "service_status0"
    }
  }
}
```

