
# Account Holding Entity

Information about the financial institution servicing the account.

## Structure

`AccountHoldingEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAddress` | `List<string>` | Optional | Financial institution address |
| `BankId` | `string` | Required | **Constraints**: *Pattern*: `^[A-Z0-9]{0,16}$` |
| `BankIdCode` | [`BankIdCodeEnum`](../../doc/models/bank-id-code-enum.md) | Required | - |
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
  "bank_id": "bank_id0",
  "bank_id_code": "ESNCC",
  "bank_name": "NATIONAL WESTMINSTER BANK PLC",
  "bank_party_id": "//AT12345",
  "bank_ids": [
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

