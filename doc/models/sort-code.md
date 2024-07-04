
# Sort Code

## Structure

`SortCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes1`](../../doc/models/attributes-1.md) | Optional | - |
| `Id` | `string` | Optional | - |
| `Type` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Za-z_]*$` |

## Example (as JSON)

```json
{
  "attributes": {
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
  },
  "id": "id8",
  "type": "type2"
}
```

