
# New Report Request Attributes

## Structure

`NewReportRequestAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filter` | [`NewReportRequestFilter`](../../doc/models/new-report-request-filter.md) | Required | - |
| `PaymentScheme` | `string` | Required | - |
| `ReportType` | `string` | Required | - |

## Example (as JSON)

```json
{
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
  "payment_scheme": "payment_scheme0",
  "report_type": "report_type4"
}
```

