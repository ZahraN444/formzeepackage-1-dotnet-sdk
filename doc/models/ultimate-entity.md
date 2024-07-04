
# Ultimate Entity

## Structure

`UltimateEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalAddressLine` | `string` | Optional | Additional address line of the debtor/beneficiary address |
| `Address` | `List<string>` | Optional | Ultimate debtor/beneficiary address |
| `BirthCity` | `string` | Optional | Ultimate debtor/beneficiary birth city |
| `BirthCountry` | `string` | Optional | Ultimate debtor/beneficiary birth country. ISO 3166 format country code |
| `BirthDate` | `DateTime?` | Optional | Ultimate debtor/beneficiary birth date. Formatted ISO 8601 format YYYY-MM-DD |
| `BirthProvince` | `string` | Optional | Ultimate debtor/beneficiary birth province |
| `BuildingNumber` | `string` | Optional | Building number of the debtor/beneficiary address |
| `City` | `string` | Optional | City/Town of the Beneficiary address |
| `Country` | `string` | Optional | Country of ultimate debtor/beneficiary address. ISO 3166 format country code |
| `CountryOfResidence` | `string` | Optional | Country of residence of the ultimate beneficiary, ISO 3166 format country code |
| `Name` | `string` | Optional | - |
| `OrganisationIdentification` | `string` | Optional | Organisation identification of an ultimate debtor/beneficiary, in the case that the ultimate debtor/beneficiary is an organisation and not a private person. |
| `OrganisationIdentificationCode` | `string` | Optional | The code that specifies the type of `organisation_identification` |
| `OrganisationIdentificationIssuer` | `string` | Optional | Issuer of the `organisation_identification` |
| `OrganisationIdentificationScheme` | `string` | Optional | The code that specifies the scheme of `organisation_identification` |
| `OrganisationIdentifications` | [`List<BeneficiaryDebtorOrganisationIdentification>`](../../doc/models/beneficiary-debtor-organisation-identification.md) | Optional | Array for additional ID(s) of ultimate organisation |
| `PostCode` | `string` | Optional | Post code of the debtor/beneficiary address |
| `PrivateIdentification` | [`PrivateIdentification`](../../doc/models/private-identification.md) | Optional | - |
| `Province` | `string` | Optional | Province of the debtor/beneficiary address |
| `StreetName` | `string` | Optional | Street name of the debtor/beneficiary address |

## Example (as JSON)

```json
{
  "address": [
    "Liverpool Customer Service Centre",
    "Stevenson Way, Wavertree, L13 1NW"
  ],
  "birth_city": "PARIS",
  "birth_country": "FR",
  "birth_date": "1973-01-31",
  "birth_province": "SOUTH SIDE",
  "city": "BRUSSELS",
  "country": "GB",
  "country_of_residence": "UA",
  "name": "Jane Bond",
  "organisation_identification": "ID1234656",
  "organisation_identification_code": "BIC",
  "organisation_identification_issuer": "NATIONAL WESTMINSTER BANK PLC",
  "organisation_identification_scheme": "CustomerId",
  "street_name": "Park Avenue",
  "additional_address_line": "additional_address_line6"
}
```

