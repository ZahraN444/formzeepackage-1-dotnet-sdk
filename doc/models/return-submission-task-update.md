
# Return Submission Task Update

## Structure

`ReturnSubmissionTaskUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes64`](../../doc/models/attributes-64.md) | Optional | - |
| `Id` | `Guid?` | Optional | Unique resource ID |
| `OrganisationId` | `Guid?` | Optional | Unique ID of the organisation this resource is created by |
| `Type` | [`Type14Enum?`](../../doc/models/type-14-enum.md) | Optional | - |
| `Version` | `int?` | Optional | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "version": 0,
  "attributes": {
    "output": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      },
      "key1": {
        "key1": "val1",
        "key2": "val2"
      },
      "key2": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "status": "pending"
  },
  "type": "return_submission_tasks"
}
```

