
# Account Attributes Organisation Identification

## Structure

`AccountAttributesOrganisationIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Actors` | [`List<AccountAttributesOrganisationIdentificationActor>`](../../doc/models/account-attributes-organisation-identification-actor.md) | Optional | - |
| `Address` | `List<string>` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `140` |
| `City` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Country` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Z]{2}$` |
| `Identification` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `140` |
| `IdentificationIssuer` | `string` | Optional | - |
| `IdentificationScheme` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `IdentificationSchemeCode` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `RegistrationNumber` | `string` | Optional | - |
| `TaxResidency` | `string` | Optional | ISO 3166-1 code used to identify the domicile of the account<br>**Constraints**: *Pattern*: `^[A-Z]{2}$` |

## Example (as JSON)

```json
{
  "country": "GB",
  "tax_residency": "GB",
  "actors": [
    {
      "birth_date": "2016-03-13",
      "name": [
        "name8",
        "name9"
      ],
      "residency": "residency8",
      "role": "role8"
    },
    {
      "birth_date": "2016-03-13",
      "name": [
        "name8",
        "name9"
      ],
      "residency": "residency8",
      "role": "role8"
    }
  ],
  "address": [
    "address2",
    "address3"
  ],
  "city": "city2",
  "identification": "identification4"
}
```

