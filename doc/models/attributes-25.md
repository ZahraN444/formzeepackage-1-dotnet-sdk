
# Attributes 25

## Structure

`Attributes25`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Answer` | [`AnswerEnum?`](../../doc/models/answer-enum.md) | Optional | Answer to direct debit request. Only `rejected` can be used. |
| `Reason` | `string` | Optional | Free text reason in addition to `reason_code`. Maximum length 105 characters for both inbound and outbound direct debit decisions. |
| `ReasonCode` | `string` | Optional | Reason for a rejected decision. Required when answer is rejected, ignored otherwise. Has to be a valid SEPA direct debit decision reason code. |

## Example (as JSON)

```json
{
  "reason": "Closed account number",
  "reason_code": "AC04",
  "answer": "rejected"
}
```

