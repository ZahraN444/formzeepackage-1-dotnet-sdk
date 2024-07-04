
# Account Number Details Response

## Structure

`AccountNumberDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`AccountNumber`](../../doc/models/account-number.md) | Optional | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "id": "id0",
    "relationships": {
      "sort_code": {
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
        "id": "id0",
        "type": "type0"
      }
    },
    "type": "type0"
  },
  "links": {
    "first": "first0",
    "last": "last4",
    "next": "next2",
    "prev": "prev8",
    "self": "self2"
  }
}
```

