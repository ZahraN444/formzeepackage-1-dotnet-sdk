
# Name Verification Attributes

## Structure

`NameVerificationAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountClassification` | [`AccountClassificationEnum`](../../doc/models/account-classification-enum.md) | Required | - |
| `AccountNumber` | `string` | Required | **Constraints**: *Pattern*: `^[A-Z0-9]{6,34}$` |
| `AccountNumberCode` | [`AccountNumberCodeEnum`](../../doc/models/account-number-code-enum.md) | Required | The type of identification given at `account_number` attribute |
| `BankId` | `string` | Required | - |
| `BankIdCode` | `string` | Required, Constant | **Default**: `"GBDSC"` |
| `Name` | `List<string>` | Required | Account holder names (for example title, first name, last name). Used for Confirmation of Payee matching.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `140` |
| `SecondaryIdentification` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "account_classification": "personal",
  "account_number": "account_number6",
  "account_number_code": "IBAN",
  "bank_id": "bank_id8",
  "bank_id_code": "GBDSC",
  "name": [
    "name6",
    "name7",
    "name8"
  ],
  "secondary_identification": "secondary_identification4"
}
```

