
# Switched Account Details

Alternate Account details to use in case the account has been switched away from this organisation.

## Structure

`SwitchedAccountDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Required | Switched account number. Must be a UK account number, maximum length 8 characters.<br>**Constraints**: *Pattern*: `^[0-9]{8}$` |
| `AccountNumberCode` | `string` | Required, Constant | ISO 20022 code used to identify the type of account number being used<br>**Default**: `"BBAN"` |
| `AccountType` | `int?` | Optional | The type of the account provided in account_number. Only required if requested by the beneficiary party.<br>**Default**: `0`<br>**Constraints**: `>= 0`, `<= 9` |
| `AccountWith` | [`AccountHoldingEntity`](../../doc/models/account-holding-entity.md) | Required | Information about the financial institution servicing the account. |
| `SwitchedEffectiveDate` | `DateTime` | Required | Starting date for the account to be effectively switched |

## Example (as JSON)

```json
{
  "account_number": "41426819",
  "account_number_code": "BBAN",
  "account_type": 0,
  "account_with": {
    "bank_address": [
      "Liverpool Customer Service Centre",
      "Stevenson Way",
      "Wavertree",
      "L13 1NW"
    ],
    "bank_id": "bank_id2",
    "bank_id_code": "PLKNR",
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
  },
  "switched_effective_date": "2017-07-23"
}
```

