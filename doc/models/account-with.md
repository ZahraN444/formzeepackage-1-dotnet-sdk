
# Account With

Debtor/Beneficiary agents bank information.

## Structure

`AccountWith`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankId` | `string` | Optional | Identification of a member of a clearing system.<br>**Constraints**: *Maximum Length*: `35` |
| `BankIdCode` | `string` | Optional | Identification of a clearing system, in a coded form as published in an external list.<br>**Constraints**: *Maximum Length*: `5` |
| `BankName` | `string` | Optional | Name by which an agent is known and which is usually used to identify that agent.<br>**Constraints**: *Maximum Length*: `140` |

## Example (as JSON)

```json
{
  "bank_id": "096735172",
  "bank_id_code": "USABA",
  "bank_name": "BNP Paribas"
}
```

