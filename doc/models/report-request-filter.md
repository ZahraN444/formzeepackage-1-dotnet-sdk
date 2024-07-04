
# Report Request Filter

## Structure

`ReportRequestFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateFrom` | `DateTime?` | Optional | - |
| `DateTo` | `DateTime?` | Optional | - |
| `ReportUsers` | [`List<ReportUser>`](../../doc/models/report-user.md) | Required | - |

## Example (as JSON)

```json
{
  "report_users": [
    {
      "user_id": "123456",
      "user_id_code": "SUN"
    }
  ],
  "date_from": "2016-03-13",
  "date_to": "2016-03-13"
}
```

