
# Return Admission Fetch Response

## Structure

`ReturnAdmissionFetchResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`ReturnAdmissionFetch`](../../doc/models/return-admission-fetch.md) | Optional | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "admission_datetime": "2016-03-13T12:52:32.123Z",
      "route": "on_us",
      "scheme_status_code": "scheme_status_code6",
      "scheme_status_code_description": "scheme_status_code_description4",
      "settlement_cycle": 146
    },
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "relationships": {
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
    },
    "type": "type0"
  },
  "links": {
    "first": "first0",
    "last": "last4",
    "next": "next2",
    "prev": "prev8",
    "self": "self2"
  }
}
```

