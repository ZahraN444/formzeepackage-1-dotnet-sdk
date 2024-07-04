
# Reversal Admission Task

## Structure

`ReversalAdmissionTask`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes15`](../../doc/models/attributes-15.md) | Optional | - |
| `CreatedOn` | `DateTime?` | Optional | - |
| `Id` | `Guid?` | Optional | - |
| `ModifiedOn` | `DateTime?` | Optional | - |
| `OrganisationId` | `Guid?` | Optional | Unique ID of the organisation this resource is created by |
| `Relationships` | [`ReversalAdmissionTaskRelationships`](../../doc/models/reversal-admission-task-relationships.md) | Optional | - |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "created_on": "09/26/2017 15:26:57",
  "modified_on": "09/26/2017 15:26:57",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "reversal_admission_tasks",
  "version": 0,
  "attributes": {
    "assignee": "customer",
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
  "id": "00001df4-0000-0000-0000-000000000000"
}
```

