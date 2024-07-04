
# Payment Submission Creation

## Structure

`PaymentSubmissionCreation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`NewPaymentSubmission`](../../doc/models/new-payment-submission.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "id": "00001c2a-0000-0000-0000-000000000000",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "relationships": {
      "validations": {
        "data": [
          {
            "id": "00001c2a-0000-0000-0000-000000000000",
            "type": "type0"
          },
          {
            "id": "00001c2a-0000-0000-0000-000000000000",
            "type": "type0"
          },
          {
            "id": "00001c2a-0000-0000-0000-000000000000",
            "type": "type0"
          }
        ]
      }
    },
    "type": "type0",
    "version": 110
  }
}
```

