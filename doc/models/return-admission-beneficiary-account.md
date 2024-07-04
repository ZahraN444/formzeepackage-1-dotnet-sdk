
# Return Admission Beneficiary Account

## Structure

`ReturnAdmissionBeneficiaryAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes10`](../../doc/models/attributes-10.md) | Optional | - |
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
  "id": "00002626-0000-0000-0000-000000000000"
}
```

