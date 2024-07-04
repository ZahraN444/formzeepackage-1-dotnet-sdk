
# Mandate Attributes Beneficiary Party

## Structure

`MandateAttributesBeneficiaryParty`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | - |
| `AccountNumber` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Z0-9]{6,34}$` |
| `AccountNumberCode` | [`AccountNumberCodeEnum?`](../../doc/models/account-number-code-enum.md) | Optional | The type of identification given at `account_number` attribute |
| `AccountType` | `int?` | Optional | - |
| `AccountWith` | [`AccountHoldingEntity`](../../doc/models/account-holding-entity.md) | Optional | Information about the financial institution servicing the account. |
| `Address` | `List<string>` | Optional | - |
| `Country` | `string` | Optional | - |
| `PrivateIdentification` | [`PrivateIdentification`](../../doc/models/private-identification.md) | Optional | - |

## Example (as JSON)

```json
{
  "account_number_code": "IBAN",
  "account_name": "account_name4",
  "account_number": "account_number6",
  "account_type": 184,
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
```

