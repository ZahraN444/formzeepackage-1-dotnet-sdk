
# New Report Request Submission

## Structure

`NewReportRequestSubmission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`NewReportRequestSubmissionAttributes`](../../doc/models/new-report-request-submission-attributes.md) | Optional | - |
| `Id` | `Guid` | Required | - |
| `OrganisationId` | `Guid` | Required | - |
| `Type` | `string` | Required, Constant | **Default**: `"report_request_submissions"` |
| `Version` | `int?` | Optional | **Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "id": "000026f2-0000-0000-0000-000000000000",
  "organisation_id": "000015ec-0000-0000-0000-000000000000",
  "type": "report_request_submissions",
  "attributes": {
    "status": "pending"
  },
  "version": 6
}
```

