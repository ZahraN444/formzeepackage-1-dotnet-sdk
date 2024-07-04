
# Transaction File Admission Response

## Structure

`TransactionFileAdmissionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`TransactionFileAdmission`](../../doc/models/transaction-file-admission.md) | Optional | - |
| `Links` | [`TransactionFileLinks`](../../doc/models/transaction-file-links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "admission_datetime": "2016-03-13T12:52:32.123Z",
      "status": "failed",
      "status_reason": "status_reason6",
      "transaction_start_datetime": "2016-03-13T12:52:32.123Z"
    },
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "relationships": {
      "transaction_files": {
        "data": [
          {
            "attributes": {
              "file_format": "ndjson",
              "file_hash": "file_hash0",
              "file_size": 44,
              "hashing_algorithm": "hashing_algorithm2",
              "number_of_parts": 8,
              "payment_scheme": "payment_scheme4",
              "transaction_count": 254,
              "transaction_data": {
                "key1": "val1",
                "key2": "val2"
              },
              "transaction_sum": "transaction_sum2"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "reports": {
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
              "transaction_file_admissions": {
                "data": [
                  {}
                ]
              },
              "transaction_file_submissions": {
                "data": [
                  {
                    "attributes": {
                      "scheme_references": [
                        {
                          "clearing_id": "clearing_id4",
                          "file_identifier": "file_identifier4",
                          "file_number": "file_number8",
                          "transaction_count": 98,
                          "transaction_sum": "transaction_sum0"
                        }
                      ],
                      "status": "delivery_failed",
                      "status_reason": "status_reason6",
                      "submission_datetime": "2016-03-13T12:52:32.123Z",
                      "transaction_start_datetime": "2016-03-13T12:52:32.123Z"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "transaction_files": {}
                    },
                    "type": "transaction_file_submissions"
                  },
                  {
                    "attributes": {
                      "scheme_references": [
                        {
                          "clearing_id": "clearing_id4",
                          "file_identifier": "file_identifier4",
                          "file_number": "file_number8",
                          "transaction_count": 98,
                          "transaction_sum": "transaction_sum0"
                        }
                      ],
                      "status": "delivery_failed",
                      "status_reason": "status_reason6",
                      "submission_datetime": "2016-03-13T12:52:32.123Z",
                      "transaction_start_datetime": "2016-03-13T12:52:32.123Z"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "transaction_files": {}
                    },
                    "type": "transaction_file_submissions"
                  }
                ]
              }
            },
            "type": "transaction_files",
            "version": 110
          },
          {
            "attributes": {
              "file_format": "ndjson",
              "file_hash": "file_hash0",
              "file_size": 44,
              "hashing_algorithm": "hashing_algorithm2",
              "number_of_parts": 8,
              "payment_scheme": "payment_scheme4",
              "transaction_count": 254,
              "transaction_data": {
                "key1": "val1",
                "key2": "val2"
              },
              "transaction_sum": "transaction_sum2"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "reports": {
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
              "transaction_file_admissions": {
                "data": [
                  {}
                ]
              },
              "transaction_file_submissions": {
                "data": [
                  {
                    "attributes": {
                      "scheme_references": [
                        {
                          "clearing_id": "clearing_id4",
                          "file_identifier": "file_identifier4",
                          "file_number": "file_number8",
                          "transaction_count": 98,
                          "transaction_sum": "transaction_sum0"
                        }
                      ],
                      "status": "delivery_failed",
                      "status_reason": "status_reason6",
                      "submission_datetime": "2016-03-13T12:52:32.123Z",
                      "transaction_start_datetime": "2016-03-13T12:52:32.123Z"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "transaction_files": {}
                    },
                    "type": "transaction_file_submissions"
                  },
                  {
                    "attributes": {
                      "scheme_references": [
                        {
                          "clearing_id": "clearing_id4",
                          "file_identifier": "file_identifier4",
                          "file_number": "file_number8",
                          "transaction_count": 98,
                          "transaction_sum": "transaction_sum0"
                        }
                      ],
                      "status": "delivery_failed",
                      "status_reason": "status_reason6",
                      "submission_datetime": "2016-03-13T12:52:32.123Z",
                      "transaction_start_datetime": "2016-03-13T12:52:32.123Z"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "transaction_files": {}
                    },
                    "type": "transaction_file_submissions"
                  }
                ]
              }
            },
            "type": "transaction_files",
            "version": 110
          }
        ]
      }
    },
    "type": "transaction_file_admissions"
  },
  "links": {
    "self": {
      "href": "href0",
      "meta": {
        "content-type": "content-type0"
      }
    }
  }
}
```

