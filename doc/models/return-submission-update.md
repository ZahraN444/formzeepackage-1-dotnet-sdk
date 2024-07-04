
# Return Submission Update

## Structure

`ReturnSubmissionUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes65`](../../doc/models/attributes-65.md) | Optional | - |
| `Id` | `Guid` | Required | Unique resource ID |
| `OrganisationId` | `Guid` | Required | Unique ID of the organisation this resource is created by |
| `Relationships` | [`ReturnSubmissionUpdateRelationships`](../../doc/models/return-submission-update-relationships.md) | Optional | - |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int` | Required | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "return_submissions",
  "version": 0,
  "attributes": {
    "redirected_account_number": "redirected_account_number2",
    "redirected_bank_id": "redirected_bank_id8",
    "route": "on_us",
    "scheme_status_code": "scheme_status_code6",
    "scheme_status_code_description": "scheme_status_code_description4"
  },
  "relationships": {
    "return_submission_tasks": [
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
        "id": "000023e8-0000-0000-0000-000000000000",
        "modified_on": "2016-03-13T12:52:32.123Z",
        "organisation_id": "000012e2-0000-0000-0000-000000000000"
      }
    ]
  }
}
```

