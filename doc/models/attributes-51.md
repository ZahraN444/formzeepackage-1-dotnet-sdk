
# Attributes 51

## Structure

`Attributes51`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Optional | Further explanation of the reason given in reason_code. Only evaluated for certain reason codes. |
| `ReasonCode` | `string` | Optional | The reason for the recall. Has to be a valid [recall reason code](http://api-docs.form3.tech/api.html#enumerations-recall-reason-codes). |

## Example (as JSON)

```json
{
  "reason": "Payment was a duplicate",
  "reason_code": "DUPL"
}
```

