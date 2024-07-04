
# Supported Schemes

## Structure

`SupportedSchemes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BACS` | [`BACS`](../../doc/models/bacs.md) | Optional | - |
| `CCC` | [`CCC`](../../doc/models/ccc.md) | Optional | - |
| `CHAPS` | [`CHAPS`](../../doc/models/chaps.md) | Optional | - |
| `FPS` | [`FPS`](../../doc/models/fps.md) | Optional | - |

## Example (as JSON)

```json
{
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
```

