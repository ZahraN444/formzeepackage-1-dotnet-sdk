
# Query Beneficiary Debtor Organisation Identification

## Structure

`QueryBeneficiaryDebtorOrganisationIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Optional | Another ID of the organisation<br>**Constraints**: *Maximum Length*: `35` |
| `IdentificationCode` | `string` | Optional | Code for the type of other ID of organisation |
| `IdentificationIssuer` | `string` | Optional | Issuer of the other ID of organisation<br>**Constraints**: *Maximum Length*: `35` |
| `IdentificationScheme` | `string` | Optional | Custom internal code for the type of other ID of organisation<br>**Constraints**: *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "identification": "H7FNTJ4851HG0EXQ1Z70",
  "identification_code": "LEI",
  "identification_issuer": "London Stock Exchange",
  "identification_scheme": "Custom code"
}
```

