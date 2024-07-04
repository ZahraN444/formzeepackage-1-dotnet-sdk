
# Return Submission Task

## Structure

`ReturnSubmissionTask`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes12`](../../doc/models/attributes-12.md) | Optional | - |
| `CreatedOn` | `DateTime?` | Optional | - |
| `Id` | `Guid?` | Optional | - |
| `ModifiedOn` | `DateTime?` | Optional | - |
| `OrganisationId` | `Guid?` | Optional | Unique ID of the organisation this resource is created by |
| `Relationships` | [`ReturnSubmissionTaskRelationships`](../../doc/models/return-submission-task-relationships.md) | Optional | - |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "created_on": "09/26/2017 15:26:57",
  "modified_on": "09/26/2017 15:26:57",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "return_submission_tasks",
  "version": 0,
  "attributes": {
    "assignee": "customer",
    "input": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      },
      "key1": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "name": "name4",
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
  "id": "00001d46-0000-0000-0000-000000000000"
}
```

