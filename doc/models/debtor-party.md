
# Debtor Party

## Structure

`DebtorParty`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Name of debtor as given with account |
| `AccountNumber` | `string` | Optional | Debtor account number. Allows upper case and numeric characters. |
| `AccountNumberCode` | [`AccountNumberCodeEnum?`](../../doc/models/account-number-code-enum.md) | Optional | The type of identification given at `account_number` attribute |
| `AccountProxy` | [`BeneficiaryDebtorAccountProxy`](../../doc/models/beneficiary-debtor-account-proxy.md) | Optional | - |
| `AccountWith` | [`BeneficiaryDebtorAccountHoldingEntity`](../../doc/models/beneficiary-debtor-account-holding-entity.md) | Optional | - |
| `AdditionalAddressLine` | `string` | Optional | Additional address line of the Debtor address |
| `Address` | `List<string>` | Optional | Debtor address |
| `BirthCity` | `string` | Optional | Debtor birth city |
| `BirthCountry` | `string` | Optional | Debtor birth country. ISO 3166 format country code |
| `BirthDate` | `DateTime?` | Optional | Debtor birth date. Formatted according to ISO 8601 format: YYYY-MM-DD |
| `BirthProvince` | `string` | Optional | Debtor birth province |
| `BuildingNumber` | `string` | Optional | Building number of the Debtor address |
| `City` | `string` | Optional | City/Town of the Debtor address |
| `Country` | `string` | Optional | Country of debtor address. ISO 3166 format country code" |
| `CountryOfResidence` | `string` | Optional | Country of residence of the debtor party, ISO 3166 format country code |
| `CustomerId` | `string` | Optional | SWIFT BIC for ordering customer, either BIC8 or BIC11 |
| `CustomerIdCode` | `string` | Optional | Code for `customer_id` |
| `Name` | `string` | Optional | Debtor name |
| `OrganisationIdentification` | `string` | Optional | Organisation identification of a debtor, in the case that the debtor is an organisation and not a private person |
| `OrganisationIdentificationCode` | `string` | Optional | The code that specifies the type of `organisation_identification` |
| `OrganisationIdentificationIssuer` | `string` | Optional | Issuer of the `organisation_identification` |
| `OrganisationIdentificationScheme` | `string` | Optional | The code that specifies the scheme of `organisation_identification` |
| `OrganisationIdentifications` | [`List<BeneficiaryDebtorOrganisationIdentification>`](../../doc/models/beneficiary-debtor-organisation-identification.md) | Optional | Array for additional ID(s) of debtor organisation |
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
  "birth_city": "PARIS",
  "birth_country": "FR",
  "birth_date": "1973-01-31",
  "birth_province": "SOUTH SIDE",
  "city": "BRUSSELS",
  "country": "GB",
  "country_of_residence": "IT",
  "customer_id": "BARCGB22",
  "customer_id_code": "SWBIC",
  "name": "Norman Smith",
  "organisation_identification": "ID1234656",
  "organisation_identification_code": "BIC",
  "organisation_identification_issuer": "NATIONAL WESTMINSTER BANK PLC",
  "organisation_identification_scheme": "CustomerId",
  "street_name": "Park Avenue",
  "account_proxy": {
    "proxy": "proxy4",
    "proxy_id": "proxy_id4",
    "proxy_id_code": "proxy_id_code4"
  },
  "account_with": {
    "bank_address": [
      "bank_address4",
      "bank_address3",
      "bank_address2"
    ],
    "bank_id": "bank_id2",
    "bank_id_code": "bank_id_code0",
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
    "bank_name": "bank_name4"
  }
}
```

