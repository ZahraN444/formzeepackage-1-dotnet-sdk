
# Beneficiary Party 1

## Structure

`BeneficiaryParty1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Name of beneficiary as given with account |
| `AccountNumber` | `string` | Optional | Beneficiary account number |
| `AccountNumberCode` | [`AccountNumberCodeEnum?`](../../doc/models/account-number-code-enum.md) | Optional | The type of identification given at `account_number` attribute |
| `AccountProxy` | [`BeneficiaryDebtorAccountProxy`](../../doc/models/beneficiary-debtor-account-proxy.md) | Optional | - |
| `AccountType` | `int?` | Optional | The type of the account given with `beneficiary_party.account_number`. Single digit number. Only required if requested by the beneficiary party. Defaults to 0. |
| `AccountWith` | [`BeneficiaryDebtorAccountHoldingEntity`](../../doc/models/beneficiary-debtor-account-holding-entity.md) | Optional | - |
| `AdditionalAddressLine` | `string` | Optional | Additional address line of the beneficiary address |
| `Address` | `List<string>` | Optional | Beneficiary address |
| `BirthCity` | `string` | Optional | Beneficiary birth city |
| `BirthCountry` | `string` | Optional | Beneficiary birth country, ISO 3166 format country code |
| `BirthDate` | `DateTime?` | Optional | Beneficiary birth date. Formatted according to ISO 8601 format: YYYY-MM-DD |
| `BirthProvince` | `string` | Optional | Beneficiary birth province |
| `BuildingNumber` | `string` | Optional | Building number of the beneficiary address |
| `City` | `string` | Optional | City/Town of the Beneficiary address |
| `Country` | `string` | Optional | Country of the beneficiary address, ISO 3166 format country code |
| `CountryOfResidence` | `string` | Optional | Country of residence of the beneficiary party, ISO 3166 format country code |
| `Name` | `string` | Optional | Beneficiary name |
| `OrganisationIdentification` | `string` | Optional | Organisation identification of a beneficiary, used in the case that the beneficiary is an organisation and not a private person |
| `OrganisationIdentificationCode` | `string` | Optional | The code that specifies the type of `organisation_identification` |
| `OrganisationIdentificationIssuer` | `string` | Optional | Issuer of the `organisation_identification` |
| `OrganisationIdentificationScheme` | `string` | Optional | The code that specifies the scheme of `organisation_identification` |
| `OrganisationIdentifications` | [`List<BeneficiaryDebtorOrganisationIdentification>`](../../doc/models/beneficiary-debtor-organisation-identification.md) | Optional | Array for additional ID(s) of beneficiary organisation |
| `PostCode` | `string` | Optional | Post code of the beneficiary address |
| `PrivateIdentification` | [`PrivateIdentification`](../../doc/models/private-identification.md) | Optional | - |
| `Province` | `string` | Optional | Province of the beneficiary address |
| `StreetName` | `string` | Optional | Street name of the beneficiary address |
| `TelephoneNumber` | `string` | Optional | Beneficiary phone number |

## Example (as JSON)

```json
{
  "account_name": "James Bond",
  "account_number": "71268996",
  "account_number_code": "IBAN",
  "account_type": 0,
  "address": [
    "1 Clarence Mew",
    "Horsforth",
    "Leeds Ls18 4EP"
  ],
  "birth_city": "PARIS",
  "birth_country": "FR",
  "birth_date": "1977-02-28",
  "birth_province": "NORTHSIDE",
  "city": "BRUSSELS",
  "country": "DE",
  "country_of_residence": "PL",
  "name": "James Bond",
  "organisation_identification": "ID1234656",
  "organisation_identification_code": "BIC",
  "organisation_identification_issuer": "NATIONAL WESTMINSTER BANK PLC",
  "organisation_identification_scheme": "CustomerId",
  "street_name": "Park Avenue",
  "telephone_number": "+447921123987",
  "account_proxy": {
    "proxy": "proxy4",
    "proxy_id": "proxy_id4",
    "proxy_id_code": "proxy_id_code4"
  }
}
```

