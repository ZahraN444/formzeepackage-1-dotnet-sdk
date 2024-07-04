
# New Recall Decision Submission

## Structure

`NewRecallDecisionSubmission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`RecallDecisionSubmissionAttributes`](../../doc/models/recall-decision-submission-attributes.md) | Optional | - |
| `Id` | `Guid` | Required | Unique resource ID |
| `OrganisationId` | `Guid` | Required | Unique ID of the organisation this resource is created by |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "recall_decision_submissions",
  "version": 0,
  "attributes": {
    "auto": false,
    "status": "delivery_confirmed",
    "status_reason": "status_reason6",
    "submission_datetime": "2016-03-13T12:52:32.123Z"
  }
}
```

