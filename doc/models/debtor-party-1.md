
# Debtor Party 1

## Structure

`DebtorParty1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | **Constraints**: *Pattern*: `^[A-Za-z0-9 \/\-?:\(\)\.,’\+\#\=\!\"%&\*\<\>;\{@\r\n]*$` |
| `AccountNumber` | `string` | Required | **Constraints**: *Pattern*: `^[A-Z0-9]{6,34}$` |
| `BankId` | `string` | Required | - |

## Example (as JSON)

```json
{
  "account_name": "account_name8",
  "account_number": "account_number0",
  "bank_id": "bank_id2"
}
```

