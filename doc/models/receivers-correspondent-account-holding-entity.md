
# Receivers Correspondent Account Holding Entity

## Structure

`ReceiversCorrespondentAccountHoldingEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAddress` | `List<string>` | Optional | Receiver's correspondent's address |
| `BankId` | `string` | Optional | SWIFT BIC for receiver's correspondent |
| `BankIdCode` | `string` | Optional | The type of identification provided at `bank_id` attribute. Must be ISO code as listed in the [External Code Sets spreadsheet](https://www.iso20022.org/external_code_list.page) |
| `BankName` | `string` | Optional | Receiver's correspondent's name |
| `BankPartyId` | `string` | Optional | Receiver's correspondent party identifier |

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
  "bank_name": "XYZ BANK PLC",
  "bank_party_id": "//AT12345",
  "bank_id_code": "bank_id_code2"
}
```

