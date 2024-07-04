
# Reversal Admission Update Relationships

## Structure

`ReversalAdmissionUpdateRelationships`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReversalAdmissionTasks` | [`List<ReversalAdmissionTask>`](../../doc/models/reversal-admission-task.md) | Optional | - |

## Example (as JSON)

```json
{
  "reversal_admission_tasks": [
    {
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
      "created_on": "2016-03-13T12:52:32.123Z",
      "id": "00001acc-0000-0000-0000-000000000000",
      "modified_on": "2016-03-13T12:52:32.123Z",
      "organisation_id": "000009c6-0000-0000-0000-000000000000"
    },
    {
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
      "created_on": "2016-03-13T12:52:32.123Z",
      "id": "00001acc-0000-0000-0000-000000000000",
      "modified_on": "2016-03-13T12:52:32.123Z",
      "organisation_id": "000009c6-0000-0000-0000-000000000000"
    }
  ]
}
```

