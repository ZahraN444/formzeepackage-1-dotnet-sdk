
# Scheme File Admission Relationships

## Structure

`SchemeFileAdmissionRelationships`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SchemeFiles` | [`SchemeFiles`](../../doc/models/scheme-files.md) | Optional | - |

## Example (as JSON)

```json
{
  "scheme_files": {
    "data": [
      {
        "attributes": {
          "file_format": "file_format2",
          "file_hash": "file_hash0",
          "file_size": 44,
          "file_type": "switch",
          "hashing_algorithm": "hashing_algorithm2",
          "number_of_parts": 8,
          "payment_scheme": "CASS"
        },
        "created_on": "2016-03-13T12:52:32.123Z",
        "id": "00001c2a-0000-0000-0000-000000000000",
        "modified_on": "2016-03-13T12:52:32.123Z",
        "organisation_id": "00000b24-0000-0000-0000-000000000000",
        "relationships": {
          "scheme_file_admissions": {
            "data": [
              {
                "attributes": {
                  "admission_datetime": "2016-03-13T12:52:32.123Z",
                  "start_datetime": "2016-03-13T12:52:32.123Z",
                  "status": "failed",
                  "status_reason": "status_reason6"
                },
                "created_on": "2016-03-13T12:52:32.123Z",
                "id": "00001c2a-0000-0000-0000-000000000000",
                "modified_on": "2016-03-13T12:52:32.123Z",
                "organisation_id": "00000b24-0000-0000-0000-000000000000",
                "relationships": {
                  "scheme_files": {}
                },
                "type": "scheme_file_admissions"
              },
              {
                "attributes": {
                  "admission_datetime": "2016-03-13T12:52:32.123Z",
                  "start_datetime": "2016-03-13T12:52:32.123Z",
                  "status": "failed",
                  "status_reason": "status_reason6"
                },
                "created_on": "2016-03-13T12:52:32.123Z",
                "id": "00001c2a-0000-0000-0000-000000000000",
                "modified_on": "2016-03-13T12:52:32.123Z",
                "organisation_id": "00000b24-0000-0000-0000-000000000000",
                "relationships": {
                  "scheme_files": {}
                },
                "type": "scheme_file_admissions"
              }
            ]
          },
          "scheme_file_submission": {
            "data": [
              {
                "attributes": {
                  "start_datetime": "2016-03-13T12:52:32.123Z",
                  "status": "delivery_failed",
                  "status_reason": "status_reason6",
                  "submission_datetime": "2016-03-13T12:52:32.123Z"
                },
                "created_on": "2016-03-13T12:52:32.123Z",
                "id": "00001c2a-0000-0000-0000-000000000000",
                "modified_on": "2016-03-13T12:52:32.123Z",
                "organisation_id": "00000b24-0000-0000-0000-000000000000",
                "relationships": {
                  "scheme_file": {
                    "data": [
                      {},
                      {},
                      {}
                    ]
                  }
                },
                "type": "scheme_file_submissions"
              },
              {
                "attributes": {
                  "start_datetime": "2016-03-13T12:52:32.123Z",
                  "status": "delivery_failed",
                  "status_reason": "status_reason6",
                  "submission_datetime": "2016-03-13T12:52:32.123Z"
                },
                "created_on": "2016-03-13T12:52:32.123Z",
                "id": "00001c2a-0000-0000-0000-000000000000",
                "modified_on": "2016-03-13T12:52:32.123Z",
                "organisation_id": "00000b24-0000-0000-0000-000000000000",
                "relationships": {
                  "scheme_file": {
                    "data": [
                      {},
                      {},
                      {}
                    ]
                  }
                },
                "type": "scheme_file_submissions"
              },
              {
                "attributes": {
                  "start_datetime": "2016-03-13T12:52:32.123Z",
                  "status": "delivery_failed",
                  "status_reason": "status_reason6",
                  "submission_datetime": "2016-03-13T12:52:32.123Z"
                },
                "created_on": "2016-03-13T12:52:32.123Z",
                "id": "00001c2a-0000-0000-0000-000000000000",
                "modified_on": "2016-03-13T12:52:32.123Z",
                "organisation_id": "00000b24-0000-0000-0000-000000000000",
                "relationships": {
                  "scheme_file": {
                    "data": [
                      {},
                      {},
                      {}
                    ]
                  }
                },
                "type": "scheme_file_submissions"
              }
            ]
          }
        },
        "type": "scheme_files",
        "version": 110
      }
    ]
  }
}
```

