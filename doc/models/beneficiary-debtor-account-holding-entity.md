
# Beneficiary Debtor Account Holding Entity

## Structure

`BeneficiaryDebtorAccountHoldingEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAddress` | `List<string>` | Optional | Financial institution address |
| `BankId` | `string` | Optional | Financial institution identification |
| `BankIdCode` | `string` | Optional | The type of identification provided at `bank_id` attribute. Must be ISO code as listed in the [External Code Sets spreadsheet](https://www.iso20022.org/external_code_list.page) |
| `BankIds` | [`List<AccountWithBankId>`](../../doc/models/account-with-bank-id.md) | Optional | Array for additional ID(s) for agent |
| `BankName` | `string` | Optional | Financial institution name |
| `BankPartyId` | `string` | Optional | Identifier of the financial institution which services the account |

## Example (as JSON)

```json
{
  "bank_address": [
    "Liverpool Customer Service Centre",
    "Stevenson Way",
    "Wavertree",
    "L13 1NW"
  ],
  "bank_id": "333333",
  "bank_name": "NATIONAL WESTMINSTER BANK PLC",
  "bank_party_id": "//AT12345",
  "bank_id_code": "bank_id_code8",
  "bank_ids": [
    {
      "bank_id": "bank_id4",
      "bank_id_code": "bank_id_code8"
    },
    {
      "bank_id": "bank_id4",
      "bank_id_code": "bank_id_code8"
    },
    {
      "bank_id": "bank_id4",
      "bank_id_code": "bank_id_code8"
    }
  ]
}
```

