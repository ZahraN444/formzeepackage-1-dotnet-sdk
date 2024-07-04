
# Account Attributes Private Identification

## Structure

`AccountAttributesPrivateIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | `List<string>` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `140` |
| `BirthCountry` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Z]{2}$` |
| `BirthDate` | `DateTime?` | Optional | Customer birth date |
| `City` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Country` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Z]{2}$` |
| `Identification` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `140` |
| `IdentificationIssuer` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `IdentificationScheme` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `IdentificationSchemeCode` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "birth_country": "GB",
  "birth_date": "2017-07-23",
  "country": "GB",
  "identification": "L-123456789",
  "address": [
    "address2",
    "address3"
  ],
  "city": "city8"
}
```

