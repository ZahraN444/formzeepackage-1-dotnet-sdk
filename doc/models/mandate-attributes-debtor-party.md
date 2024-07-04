
# Mandate Attributes Debtor Party

## Structure

`MandateAttributesDebtorParty`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | - |
| `AccountNumber` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Z0-9]{6,34}$` |
| `AccountNumberCode` | [`AccountNumberCodeEnum?`](../../doc/models/account-number-code-enum.md) | Optional | The type of identification given at `account_number` attribute |
| `AccountWith` | [`AccountHoldingEntity`](../../doc/models/account-holding-entity.md) | Optional | Information about the financial institution servicing the account. |
| `Address` | `List<string>` | Optional | - |
| `Country` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "account_number_code": "IBAN",
  "account_name": "account_name8",
  "account_number": "account_number0",
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
  },
  "address": [
    "address4"
  ]
}
```

