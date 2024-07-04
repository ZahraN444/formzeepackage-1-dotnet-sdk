
# Query Ultimate Entity

## Structure

`QueryUltimateEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalAddressLine` | `string` | Optional | Additional address line of the debtor/beneficiary address<br>**Constraints**: *Maximum Length*: `70` |
| `BirthCity` | `string` | Optional | Ultimate debtor/beneficiary birth city<br>**Constraints**: *Maximum Length*: `35` |
| `BirthCountry` | `string` | Optional | Ultimate debtor/beneficiary birth country. ISO 3166 format country code<br>**Constraints**: *Pattern*: `^[A-Z]{2,2}$` |
| `BirthDate` | `DateTime?` | Optional | Ultimate debtor/beneficiary birth date. Formatted ISO 8601 format YYYY-MM-DD |
| `BirthProvince` | `string` | Optional | Ultimate debtor/beneficiary birth province<br>**Constraints**: *Maximum Length*: `35` |
| `BuildingNumber` | `string` | Optional | Building number of the debtor/beneficiary address<br>**Constraints**: *Maximum Length*: `16` |
| `City` | `string` | Optional | City/Town of the debtor/beneficiary address<br>**Constraints**: *Maximum Length*: `35` |
| `Country` | `string` | Optional | Country of ultimate debtor/beneficiary address. ISO 3166 format country code<br>**Constraints**: *Pattern*: `^[A-Z]{2,2}$` |
| `CountryOfResidence` | `string` | Optional | Country of residence of the ultimate debtor/beneficiary, ISO 3166 format country code<br>**Constraints**: *Pattern*: `^[A-Z]{2,2}$` |
| `Name` | `string` | Optional | Ultimate debtor/beneficiary name<br>**Constraints**: *Maximum Length*: `140` |
| `OrganisationIdentification` | `string` | Optional | Organisation identification of an ultimate debtor/beneficiary, in the case that the ultimate debtor/beneficiary is an organisation and not a private person.<br>**Constraints**: *Maximum Length*: `35` |
| `OrganisationIdentificationCode` | `string` | Optional | The code that specifies the type of `organisation_identification` |
| `OrganisationIdentificationIssuer` | `string` | Optional | Issuer of the `organisation_identification`<br>**Constraints**: *Maximum Length*: `35` |
| `OrganisationIdentificationScheme` | `string` | Optional | The code that specifies the scheme of `organisation_identification`<br>**Constraints**: *Maximum Length*: `35` |
| `OrganisationIdentifications` | [`List<QueryBeneficiaryDebtorOrganisationIdentification>`](../../doc/models/query-beneficiary-debtor-organisation-identification.md) | Optional | Array for additional ID(s) of ultimate organisation |
| `PostCode` | `string` | Optional | Post code of the debtor/beneficiary address<br>**Constraints**: *Maximum Length*: `16` |
| `PrivateIdentification` | [`QueryPrivateIdentification`](../../doc/models/query-private-identification.md) | Optional | - |
| `Province` | `string` | Optional | Province of the debtor/beneficiary address<br>**Constraints**: *Maximum Length*: `35` |
| `StreetName` | `string` | Optional | Street name of the debtor/beneficiary address<br>**Constraints**: *Maximum Length*: `70` |

## Example (as JSON)

```json
{
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
  "additional_address_line": "additional_address_line0"
}
```

