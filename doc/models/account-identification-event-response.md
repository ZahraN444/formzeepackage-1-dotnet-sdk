
# Account Identification Event Response

## Structure

`AccountIdentificationEventResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`AccountIdentificationEventData`](../../doc/models/account-identification-event-data.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "secondary_identification": "secondary_identification2"
    },
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "type": "type0",
    "version": 110,
    "relationships": {
      "account": {
        "data": [
          {
            "attributes": {
              "acceptance_qualifier": "some_other_time",
              "account_classification": "Personal",
              "account_matching_opt_out": false,
              "account_number": "account_number4",
              "alternative_bank_account_names": [
                "alternative_bank_account_names9"
              ],
              "country": "country8"
            },
            "id": "00001c2a-0000-0000-0000-000000000000",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "account_events": {
                "data": [
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
              "master_account": {
                "data": [
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
          },
          {
            "attributes": {
              "acceptance_qualifier": "some_other_time",
              "account_classification": "Personal",
              "account_matching_opt_out": false,
              "account_number": "account_number4",
              "alternative_bank_account_names": [
                "alternative_bank_account_names9"
              ],
              "country": "country8"
            },
            "id": "00001c2a-0000-0000-0000-000000000000",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "account_events": {
                "data": [
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
              "master_account": {
                "data": [
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
        ]
      }
    }
  }
}
```

