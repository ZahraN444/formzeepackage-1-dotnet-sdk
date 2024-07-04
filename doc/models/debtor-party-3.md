
# Debtor Party 3

## Structure

`DebtorParty3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NewBankDetails` | [`NewBankDetails1`](../../doc/models/new-bank-details-1.md) | Optional | - |

## Example (as JSON)

```json
{
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
}
```

