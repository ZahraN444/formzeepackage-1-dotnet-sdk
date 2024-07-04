
# Debtor Party 2

## Structure

`DebtorParty2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Name of debtor as given with account |
| `AccountNumber` | `string` | Optional | Debtor account number. Allows upper case and numeric characters. |
| `AccountNumberCode` | [`AccountNumberCodeEnum?`](../../doc/models/account-number-code-enum.md) | Optional | The type of identification given at `account_number` attribute |
| `AccountWith` | [`AccountHoldingEntity`](../../doc/models/account-holding-entity.md) | Optional | Information about the financial institution servicing the account. |
| `Address` | `List<string>` | Optional | Debtor address |
| `BuildingNumber` | `string` | Optional | Building number of the Debtor address |
| `City` | `string` | Optional | City/Town of the Debtor address |
| `Country` | `string` | Optional | Country of debtor address. ISO 3166 format country code" |
| `Name` | `string` | Optional | Debtor name |
| `OrganisationIdentification` | `string` | Optional | Organisation identification of a beneficiary, used in the case that the beneficiary is an organisation and not a private person |
| `OrganisationIdentificationCode` | `string` | Optional | The code that specifies the type of `organisation_identification` |
| `OrganisationIdentificationIssuer` | `string` | Optional | Issuer of the `organisation_identification` |
| `OrganisationIdentificationScheme` | `string` | Optional | The code that specifies the scheme of `organisation_identification` |
| `OrganisationIdentifications` | [`List<BeneficiaryDebtorOrganisationIdentification>`](../../doc/models/beneficiary-debtor-organisation-identification.md) | Optional | Array for additional ID(s) of ultimate organisation |
| `PostCode` | `string` | Optional | Post code of the Debtor address |
| `PrivateIdentification` | [`PrivateIdentification`](../../doc/models/private-identification.md) | Optional | - |
| `Province` | `string` | Optional | Province of the Debtor address |
| `StreetName` | `string` | Optional | Street name of the Debtor address |

## Example (as JSON)

```json
{
  "account_name": "Jane Bond",
  "account_number": "12345678",
  "account_number_code": "IBAN",
  "address": [
    "63 St Mary Axe",
    "London",
    "EC3A 8AA"
  ],
  "city": "BRUSSELS",
  "country": "GB",
  "name": "Norman Smith",
  "organisation_identification": "ID1234656",
  "organisation_identification_code": "BIC",
  "organisation_identification_issuer": "NATIONAL WESTMINSTER BANK PLC",
  "organisation_identification_scheme": "CustomerId",
  "street_name": "Park Avenue",
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

