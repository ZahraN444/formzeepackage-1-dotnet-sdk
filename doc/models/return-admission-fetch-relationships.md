
# Return Admission Fetch Relationships

## Structure

`ReturnAdmissionFetchRelationships`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BeneficiaryAccount` | [`RelationshipReturnAdmissionBeneficiaryAccount`](../../doc/models/relationship-return-admission-beneficiary-account.md) | Optional | - |
| `Payment` | [`RelationshipLinks`](../../doc/models/relationship-links.md) | Optional | - |
| `PaymentReturn` | [`RelationshipLinks`](../../doc/models/relationship-links.md) | Optional | - |
| `Validations` | [`RelationshipLinks`](../../doc/models/relationship-links.md) | Optional | - |

## Example (as JSON)

```json
{
  "beneficiary_account": {
    "data": [
      {
        "attributes": {
          "user_defined_data": [
            {
              "key": "key6",
              "value": "value8"
            },
            {
              "key": "key6",
              "value": "value8"
            }
          ]
        },
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "attributes": {
          "user_defined_data": [
            {
              "key": "key6",
              "value": "value8"
            },
            {
              "key": "key6",
              "value": "value8"
            }
          ]
        },
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "attributes": {
          "user_defined_data": [
            {
              "key": "key6",
              "value": "value8"
            },
            {
              "key": "key6",
              "value": "value8"
            }
          ]
        },
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  },
  "payment": {
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
  },
  "payment_return": {
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
  },
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
}
```

