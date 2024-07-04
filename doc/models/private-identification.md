
# Private Identification

## Structure

`PrivateIdentification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | `string` | Optional | Private Identification of an debtor/beneficiary or ultimate debtor/beneficiary |
| `IdentificationIssuer` | `string` | Optional | Issuer of the `identification` |
| `IdentificationScheme` | `string` | Optional | Scheme of the `identification` |
| `IdentificationSchemeCode` | `string` | Optional | The code that specifies the type of `identification` |

## Example (as JSON)

```json
{
  "identification": "AB12345",
  "identification_issuer": "HM Passport Office",
  "identification_scheme": "BANK",
  "identification_scheme_code": "CCPT"
}
```

