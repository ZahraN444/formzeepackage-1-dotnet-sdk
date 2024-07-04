
# Relationship Return Submission Tasks

## Structure

`RelationshipReturnSubmissionTasks`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ReturnSubmissionTask>`](../../doc/models/return-submission-task.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
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
      "created_on": "2016-03-13T12:52:32.123Z",
      "id": "00001c2a-0000-0000-0000-000000000000",
      "modified_on": "2016-03-13T12:52:32.123Z",
      "organisation_id": "00000b24-0000-0000-0000-000000000000"
    }
  ]
}
```

