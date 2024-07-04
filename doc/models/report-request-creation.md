
# Report Request Creation

## Structure

`ReportRequestCreation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`NewReportRequest`](../../doc/models/new-report-request.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "filter": {
        "report_users": [
          {
            "user_id": "123456",
            "user_id_code": "SWBIC"
          }
        ],
        "date_from": "2016-03-13",
        "date_to": "2016-03-13"
      },
      "payment_scheme": "payment_scheme4",
      "report_type": "report_type8"
    },
    "id": "00001c2a-0000-0000-0000-000000000000",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "type": "report_requests",
    "version": 110
  }
}
```

