
# Attributes 16

## Structure

`Attributes16`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClearingSystem` | `string` | Optional | Clearing infrastructure through which the payment instruction was processed<br>**Constraints**: *Pattern*: `^[0-9A-Za-z_]*$` |
| `FileIdentifier` | `string` | Optional | Identification code of the file sent to scheme.<br>**Constraints**: *Pattern*: `^[0-9a-zA-Z]+$` |
| `FileNumber` | `string` | Optional | Number of the file sent to scheme.<br>**Constraints**: *Pattern*: `^[0-9]+$` |
| `LimitBreachEndDatetime` | `DateTime?` | Optional | Time a payment was released from being held due to a limit breach |
| `LimitBreachStartDatetime` | `DateTime?` | Optional | Start time a payment was held due to a limit breach |
| `RedirectedAccountNumber` | `string` | Optional | Details of the account to which funds are redirected (if applicable) |
| `RedirectedBankId` | `string` | Optional | Details of the bank to which funds are redirected (if applicable) |
| `Route` | [`RouteEnum?`](../../doc/models/route-enum.md) | Optional | Route taken for an outbound payment |
| `SchemeStatusCode` | `string` | Optional | Scheme-specific status (if submission has been submitted to a scheme) |
| `SchemeStatusCodeDescription` | `string` | Optional | [Description](http://api-docs.form3.tech/api.html#enumerations-scheme-status-codes-for-bacs) of `scheme_status_code` |
| `SettlementCycle` | `int?` | Optional | Cycle in which the payment will be settled<br>**Constraints**: `>= 0` |
| `SettlementDate` | `DateTime?` | Optional | Date that the payment will be settled |
| `Status` | [`PaymentSubmissionStatusEnum?`](../../doc/models/payment-submission-status-enum.md) | Optional | [Status of the submission](https://api-docs.form3.tech/api.html#enumerations-payment-status-codes-submission-status) |
| `StatusReason` | `string` | Optional | Description of the submission status |
| `SubmissionDatetime` | `DateTime?` | Optional | Date of the submission |
| `TransactionStartDatetime` | `DateTime?` | Optional | Time the request was received by Form3. Used to compute the total transaction time of a payment. |

## Example (as JSON)

```json
{
  "clearing_system": "TIPS",
  "file_identifier": "123456",
  "file_number": "001",
  "limit_breach_end_datetime": "03/12/2018 14:11:55",
  "limit_breach_start_datetime": "03/12/2018 14:11:50",
  "redirected_account_number": "12345678",
  "redirected_bank_id": "400300",
  "scheme_status_code": "0000",
  "scheme_status_code_description": "Field 1 (destination sorting code) was invalid",
  "settlement_cycle": 1,
  "settlement_date": "2017-07-23",
  "status": "delivery_confirmed",
  "status_reason": "Accepted without qualification",
  "submission_datetime": "03/12/2018 14:11:48",
  "transaction_start_datetime": "03/12/2018 14:11:49"
}
```

