
# New Report Request Filter

## Structure

`NewReportRequestFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateFrom` | `DateTime?` | Optional | - |
| `DateTo` | `DateTime?` | Optional | - |
| `ReportUsers` | [`List<NewReportRequestReportUser>`](../../doc/models/new-report-request-report-user.md) | Required | - |

## Example (as JSON)

```json
{
  "report_users": [
    {
      "user_id": "123456",
      "user_id_code": "SWBIC"
    }
  ],
  "date_from": "2016-03-13",
  "date_to": "2016-03-13"
}
```

