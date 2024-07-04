
# Branch Update

## Structure

`BranchUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes19`](../../doc/models/attributes-19.md) | Required | - |
| `Id` | `Guid` | Required | Unique resource ID |
| `OrganisationId` | `Guid` | Required | Unique ID of the organisation this resource is created by |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int` | Required | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "attributes": {
    "reference_mask": "41426819",
    "acceptance_qualifier": "some_other_time",
    "user_defined_data": [
      {
        "key": "key6",
        "value": "value8"
      },
      {
        "key": "key6",
        "value": "value8"
      }
    ],
    "validation_type": "account_mod_check"
  },
  "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "accounts",
  "version": 0
}
```

