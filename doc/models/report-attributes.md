
# Report Attributes

## Structure

`ReportAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Formats` | `List<string>` | Optional | - |
| `GenerationTime` | `DateTime?` | Optional | - |
| `ProcessingDate` | `DateTime?` | Optional | - |
| `ReportSource` | `string` | Optional | - |
| `ReportType` | `string` | Optional | Type of report. |
| `ReportTypeDescription` | `string` | Optional | - |
| `ReportUsers` | [`List<ReportUser>`](../../doc/models/report-user.md) | Optional | Users or organisations this report was generated for |

## Example (as JSON)

```json
{
  "formats": [
    "formats5",
    "formats4"
  ],
  "generation_time": "2016-03-13T12:52:32.123Z",
  "processing_date": "2016-03-13",
  "report_source": "report_source2",
  "report_type": "report_type8"
}
```

