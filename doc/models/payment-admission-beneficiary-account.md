
# Payment Admission Beneficiary Account

## Structure

`PaymentAdmissionBeneficiaryAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes6`](../../doc/models/attributes-6.md) | Optional | - |
| `Id` | `Guid?` | Optional | - |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |

## Example (as JSON)

```json
{
  "type": "accounts",
  "attributes": {
    "user_defined_data": [
      {
        "key": "key6",
        "value": "value8"
      },
      {
        "key": "key6",
        "value": "value8"
      }
    ]
  },
  "id": "000009d6-0000-0000-0000-000000000000"
}
```

