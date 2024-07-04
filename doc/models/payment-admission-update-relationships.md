
# Payment Admission Update Relationships

## Structure

`PaymentAdmissionUpdateRelationships`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentAdmissionTasks` | [`List<PaymentAdmissionTask>`](../../doc/models/payment-admission-task.md) | Optional | - |

## Example (as JSON)

```json
{
  "payment_admission_tasks": [
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
        "status": "pending",
        "workflow": "000021d2-0000-0000-0000-000000000000"
      },
      "created_on": "2016-03-13T12:52:32.123Z",
      "id": "000001da-0000-0000-0000-000000000000",
      "modified_on": "2016-03-13T12:52:32.123Z",
      "organisation_id": "000017e4-0000-0000-0000-000000000000"
    }
  ]
}
```

