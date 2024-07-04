
# Transaction File Submission Scheme Reference

## Structure

`TransactionFileSubmissionSchemeReference`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClearingId` | `string` | Optional | Service User Number (SUN) of the payment originator<br>**Constraints**: *Pattern*: `.{6}$` |
| `FileIdentifier` | `string` | Optional | Submission serial number |
| `FileNumber` | `string` | Optional | Number of the file sent to the scheme |
| `TransactionCount` | `int?` | Optional | The count of transactions submitted in a given scheme file |
| `TransactionSum` | `string` | Optional | The sum of transactions submitted in a given scheme file |

## Example (as JSON)

```json
{
  "clearing_id": "ABC123",
  "file_identifier": "123456",
  "file_number": "001",
  "transaction_count": 1,
  "transaction_sum": "1000.00"
}
```

