
# Attributes 57

## Structure

`Attributes57`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Agents` | [`List<Agent>`](../../doc/models/agent.md) | Optional | Block to represent a Financial Institution/agent in the payment chain |
| `Answer` | [`RecallDecisionAnswerEnum?`](../../doc/models/recall-decision-answer-enum.md) | Optional | Answer to the recall request. Can either be `accepted` or `rejected`. |
| `ChargesAmount` | [`CurrencyAndAmount`](../../doc/models/currency-and-amount.md) | Optional | - |
| `Reason` | `string` | Optional | Optional free text reason in addition to `reason_code` |
| `ReasonCode` | `string` | Optional | Reason for a rejected decision. Required when answer is rejected, ignored otherwise. Has to be a valid [rejected recall decision reason code](http://api-docs.form3.tech/api.html#enumerations-rejected-recall-decision-reason-codes) |
| `RecallAmount` | [`CurrencyAndAmount`](../../doc/models/currency-and-amount.md) | Optional | - |
| `ResolutionRelatedInformation` | [`ResolutionRelatedInformation`](../../doc/models/resolution-related-information.md) | Optional | - |

## Example (as JSON)

```json
{
  "answer": "accepted",
  "reason": "Closed account number",
  "reason_code": "AC04",
  "agents": [
    {
      "account_number": "account_number0",
      "account_number_code": "IBAN",
      "address": [
        "address4",
        "address5"
      ],
      "identification": {
        "bank_id": "bank_id4",
        "bank_id_code": "bank_id_code2",
        "bank_ids": [
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          }
        ]
      },
      "name": "name0"
    },
    {
      "account_number": "account_number0",
      "account_number_code": "IBAN",
      "address": [
        "address4",
        "address5"
      ],
      "identification": {
        "bank_id": "bank_id4",
        "bank_id_code": "bank_id_code2",
        "bank_ids": [
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          }
        ]
      },
      "name": "name0"
    },
    {
      "account_number": "account_number0",
      "account_number_code": "IBAN",
      "address": [
        "address4",
        "address5"
      ],
      "identification": {
        "bank_id": "bank_id4",
        "bank_id_code": "bank_id_code2",
        "bank_ids": [
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          }
        ]
      },
      "name": "name0"
    }
  ],
  "charges_amount": {
    "amount": "amount4",
    "currency": "currency2"
  }
}
```

