
# Scheme Message Details Response

## Structure

`SchemeMessageDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`SchemeMessage`](../../doc/models/scheme-message.md) | Required | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "date": "2016-03-13T12:52:32.123Z",
      "entries": [
        {
          "key": "key0",
          "value": "value2"
        }
      ],
      "payment_scheme": "FDW",
      "scheme_message_type": "scheme_message_type8",
      "unique_scheme_id": "unique_scheme_id2"
    },
    "id": "00001c2a-0000-0000-0000-000000000000",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "relationships": {
      "scheme_message_admission": {
        "data": [
          {
            "attributes": {
              "admission_datetime": "2016-03-13T12:52:32.123Z",
              "scheme_status_code": "scheme_status_code6",
              "scheme_status_code_description": "scheme_status_code_description4",
              "status": "delivery_confirmed"
            },
            "id": "00001c2a-0000-0000-0000-000000000000",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "scheme_message": {
                "data": [
                  {
                    "attributes": {
                      "date": "2016-03-13T12:52:32.123Z",
                      "entries": [
                        {
                          "key": "key0",
                          "value": "value2"
                        }
                      ],
                      "payment_scheme": "FDW",
                      "scheme_message_type": "scheme_message_type8",
                      "unique_scheme_id": "unique_scheme_id2"
                    },
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {},
                    "type": "scheme_messages",
                    "version": 110
                  },
                  {
                    "attributes": {
                      "date": "2016-03-13T12:52:32.123Z",
                      "entries": [
                        {
                          "key": "key0",
                          "value": "value2"
                        }
                      ],
                      "payment_scheme": "FDW",
                      "scheme_message_type": "scheme_message_type8",
                      "unique_scheme_id": "unique_scheme_id2"
                    },
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {},
                    "type": "scheme_messages",
                    "version": 110
                  },
                  {
                    "attributes": {
                      "date": "2016-03-13T12:52:32.123Z",
                      "entries": [
                        {
                          "key": "key0",
                          "value": "value2"
                        }
                      ],
                      "payment_scheme": "FDW",
                      "scheme_message_type": "scheme_message_type8",
                      "unique_scheme_id": "unique_scheme_id2"
                    },
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {},
                    "type": "scheme_messages",
                    "version": 110
                  }
                ]
              }
            },
            "type": "scheme_message_admissions",
            "version": 110
          }
        ]
      }
    },
    "type": "scheme_messages",
    "version": 110
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

