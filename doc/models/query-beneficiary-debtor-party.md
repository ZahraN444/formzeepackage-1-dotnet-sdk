
# Query Beneficiary Debtor Party

## Structure

`QueryBeneficiaryDebtorParty`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Optional | Debtor/Beneficiary account number. Allows upper case and numeric characters.<br>**Constraints**: *Maximum Length*: `34` |
| `AccountNumberCode` | [`QueryAccountNumberCodeEnum?`](../../doc/models/query-account-number-code-enum.md) | Optional | The type of identification given at `account_number` attribute<br>**Constraints**: *Maximum Length*: `4` |
| `AccountProxy` | [`QueryBeneficiaryDebtorAccountProxy`](../../doc/models/query-beneficiary-debtor-account-proxy.md) | Optional | - |
| `AccountWith` | [`AccountWith`](../../doc/models/account-with.md) | Optional | Debtor/Beneficiary agents bank information. |
| `AdditionalAddressLine` | `string` | Optional | Additional address line of the debtor/beneficiary address |
| `BirthCity` | `string` | Optional | Debtor/Beneficiary birth city |
| `BirthCountry` | `string` | Optional | Debtor/Beneficiary birth country. ISO 3166 format country code |
| `BirthDate` | `DateTime?` | Optional | Debtor/Beneficiary birth date. Formatted ISO 8601 format YYYY-MM-DD |
| `BirthProvince` | `string` | Optional | Debtor/Beneficiary birth province |
| `BuildingNumber` | `string` | Optional | Building number of the debtor/beneficiary address |
| `City` | `string` | Optional | City/Town of the debtor/beneficiary address |
| `Country` | `string` | Optional | Country of debtor/beneficiary address. ISO 3166 format country code |
| `CountryOfResidence` | `string` | Optional | Country of residence of the debtor/beneficiary, ISO 3166 format country code |
| `Name` | `string` | Optional | Debtor/Beneficiary name |
| `OrganisationIdentification` | `string` | Optional | Organisation identification of a debtor/beneficiary, in the case that the debtor/beneficiary is an organisation and not a private person. |
| `OrganisationIdentificationCode` | `string` | Optional | The code that specifies the type of `organisation_identification` |
| `OrganisationIdentificationIssuer` | `string` | Optional | Issuer of the `organisation_identification` |
| `OrganisationIdentificationScheme` | `string` | Optional | The code that specifies the scheme of `organisation_identification` |
| `OrganisationIdentifications` | [`List<QueryBeneficiaryDebtorOrganisationIdentification>`](../../doc/models/query-beneficiary-debtor-organisation-identification.md) | Optional | Array for additional ID(s) of ultimate organisation |
| `PostCode` | `string` | Optional | Post code of the debtor/beneficiary address |
| `PrivateIdentification` | [`QueryPrivateIdentification`](../../doc/models/query-private-identification.md) | Optional | - |
| `Province` | `string` | Optional | Province of the debtor/beneficiary address |
| `StreetName` | `string` | Optional | Street name of the debtor/beneficiary address |

## Example (as JSON)

```json
{
  "account_number": "12345678",
  "account_number_code": "IBAN",
  "birth_city": "New-York",
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
  "account_proxy": {
    "proxy": "proxy4",
    "proxy_id": "proxy_id4",
    "proxy_id_code": "proxy_id_code4"
  },
  "account_with": {
    "bank_id": "bank_id2",
    "bank_id_code": "bank_id_code0",
    "bank_name": "bank_name4"
  },
  "additional_address_line": "additional_address_line6"
}
```

