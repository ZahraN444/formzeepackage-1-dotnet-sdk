
# Report Request Attributes

## Structure

`ReportRequestAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filter` | [`ReportRequestFilter`](../../doc/models/report-request-filter.md) | Required | - |
| `PaymentScheme` | `string` | Required | - |
| `ReportType` | `string` | Required | - |
| `Status` | [`ReportRequestStatusEnum`](../../doc/models/report-request-status-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "filter": {
    "report_users": [
      {
        "user_id": "123456",
        "user_id_code": "SUN"
      }
    ],
    "date_from": "2016-03-13",
    "date_to": "2016-03-13"
  },
  "payment_scheme": "payment_scheme0",
  "report_type": "report_type4",
  "status": "pending"
}
```

