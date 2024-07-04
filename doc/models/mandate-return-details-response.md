
# Mandate Return Details Response

## Structure

`MandateReturnDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`MandateReturn`](../../doc/models/mandate-return.md) | Optional | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "debtor_party": {
        "new_bank_details": {
          "account_number": "account_number4",
          "account_number_code": "IBAN",
          "account_with": {
            "bank_address": [
              "bank_address4",
              "bank_address3",
              "bank_address2"
            ],
            "bank_id": "bank_id2",
            "bank_id_code": "PLKNR",
            "bank_ids": [
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              },
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              }
            ],
            "bank_name": "bank_name4",
            "bank_party_id": "bank_party_id6"
          }
        }
      },
      "return_code": "return_code4"
    },
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000"
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

