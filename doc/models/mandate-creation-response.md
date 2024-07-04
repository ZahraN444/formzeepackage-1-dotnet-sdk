
# Mandate Creation Response

## Structure

`MandateCreationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Mandate`](../../doc/models/mandate.md) | Optional | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "amount": "amount6",
      "beneficiary_party": {
        "account_name": "account_name0",
        "account_number": "account_number8",
        "account_number_code": "IBAN",
        "account_type": 6,
        "account_with": {
          "bank_address": [
            "bank_address4",
            "bank_address3",
            "bank_address2"
          ],
          "bank_id": "bank_id2",
          "bank_id_code": "PLKNR",
          "bank_ids": [
            {
              "bank_id": "bank_id4",
              "bank_id_code": "bank_id_code8"
            },
            {
              "bank_id": "bank_id4",
              "bank_id_code": "bank_id_code8"
            }
          ],
          "bank_name": "bank_name4",
          "bank_party_id": "bank_party_id6"
        }
      },
      "clearing_id": "clearing_id6",
      "currency": "currency4",
      "debtor_party": {
        "account_name": "account_name2",
        "account_number": "account_number4",
        "account_number_code": "IBAN",
        "account_with": {
          "bank_address": [
            "bank_address4",
            "bank_address3",
            "bank_address2"
          ],
          "bank_id": "bank_id2",
          "bank_id_code": "PLKNR",
          "bank_ids": [
            {
              "bank_id": "bank_id4",
              "bank_id_code": "bank_id_code8"
            },
            {
              "bank_id": "bank_id4",
              "bank_id_code": "bank_id_code8"
            }
          ],
          "bank_name": "bank_name4",
          "bank_party_id": "bank_party_id6"
        },
        "address": [
          "address8"
        ]
      }
    },
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "relationships": {
      "mandate_admission": {
        "data": [
          {
            "attributes": {
              "admission_datetime": "2016-03-13T12:52:32.123Z",
              "scheme_status_code": "scheme_status_code6",
              "scheme_status_code_description": "scheme_status_code_description4",
              "status": "confirmed",
              "status_reason": "mandate_expired"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000"
          },
          {
            "attributes": {
              "admission_datetime": "2016-03-13T12:52:32.123Z",
              "scheme_status_code": "scheme_status_code6",
              "scheme_status_code_description": "scheme_status_code_description4",
              "status": "confirmed",
              "status_reason": "mandate_expired"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000"
          },
          {
            "attributes": {
              "admission_datetime": "2016-03-13T12:52:32.123Z",
              "scheme_status_code": "scheme_status_code6",
              "scheme_status_code_description": "scheme_status_code_description4",
              "status": "confirmed",
              "status_reason": "mandate_expired"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000"
          }
        ]
      },
      "mandate_return": {
        "data": [
          {
            "attributes": {
              "debtor_party": {
                "new_bank_details": {
                  "account_number": "account_number4",
                  "account_number_code": "IBAN",
                  "account_with": {
                    "bank_address": [
                      "bank_address4",
                      "bank_address3",
                      "bank_address2"
                    ],
                    "bank_id": "bank_id2",
                    "bank_id_code": "PLKNR",
                    "bank_ids": [
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      },
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      }
                    ],
                    "bank_name": "bank_name4",
                    "bank_party_id": "bank_party_id6"
                  }
                }
              },
              "return_code": "return_code4"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000"
          },
          {
            "attributes": {
              "debtor_party": {
                "new_bank_details": {
                  "account_number": "account_number4",
                  "account_number_code": "IBAN",
                  "account_with": {
                    "bank_address": [
                      "bank_address4",
                      "bank_address3",
                      "bank_address2"
                    ],
                    "bank_id": "bank_id2",
                    "bank_id_code": "PLKNR",
                    "bank_ids": [
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      },
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      }
                    ],
                    "bank_name": "bank_name4",
                    "bank_party_id": "bank_party_id6"
                  }
                }
              },
              "return_code": "return_code4"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000"
          }
        ]
      },
      "mandate_submission": {
        "data": [
          {
            "attributes": {
              "file_identifier": "file_identifier6",
              "file_number": "file_number4",
              "last_payment_date": "2016-03-13",
              "original_mandate": {
                "amount": "amount4",
                "beneficiary_party": {
                  "account_name": "account_name0",
                  "account_number": "account_number8",
                  "account_number_code": "IBAN",
                  "account_type": 6,
                  "account_with": {
                    "bank_address": [
                      "bank_address4",
                      "bank_address3",
                      "bank_address2"
                    ],
                    "bank_id": "bank_id2",
                    "bank_id_code": "PLKNR",
                    "bank_ids": [
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      },
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      }
                    ],
                    "bank_name": "bank_name4",
                    "bank_party_id": "bank_party_id6"
                  }
                },
                "clearing_id": "clearing_id6",
                "currency": "currency8",
                "debtor_party": {
                  "account_name": "account_name2",
                  "account_number": "account_number4",
                  "account_number_code": "IBAN",
                  "account_with": {
                    "bank_address": [
                      "bank_address4",
                      "bank_address3",
                      "bank_address2"
                    ],
                    "bank_id": "bank_id2",
                    "bank_id_code": "PLKNR",
                    "bank_ids": [
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      },
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      }
                    ],
                    "bank_name": "bank_name4",
                    "bank_party_id": "bank_party_id6"
                  },
                  "address": [
                    "address8"
                  ]
                }
              },
              "status": "validation_passed"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000"
          },
          {
            "attributes": {
              "file_identifier": "file_identifier6",
              "file_number": "file_number4",
              "last_payment_date": "2016-03-13",
              "original_mandate": {
                "amount": "amount4",
                "beneficiary_party": {
                  "account_name": "account_name0",
                  "account_number": "account_number8",
                  "account_number_code": "IBAN",
                  "account_type": 6,
                  "account_with": {
                    "bank_address": [
                      "bank_address4",
                      "bank_address3",
                      "bank_address2"
                    ],
                    "bank_id": "bank_id2",
                    "bank_id_code": "PLKNR",
                    "bank_ids": [
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      },
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      }
                    ],
                    "bank_name": "bank_name4",
                    "bank_party_id": "bank_party_id6"
                  }
                },
                "clearing_id": "clearing_id6",
                "currency": "currency8",
                "debtor_party": {
                  "account_name": "account_name2",
                  "account_number": "account_number4",
                  "account_number_code": "IBAN",
                  "account_with": {
                    "bank_address": [
                      "bank_address4",
                      "bank_address3",
                      "bank_address2"
                    ],
                    "bank_id": "bank_id2",
                    "bank_id_code": "PLKNR",
                    "bank_ids": [
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      },
                      {
                        "bank_id": "bank_id4",
                        "bank_id_code": "bank_id_code8"
                      }
                    ],
                    "bank_name": "bank_name4",
                    "bank_party_id": "bank_party_id6"
                  },
                  "address": [
                    "address8"
                  ]
                }
              },
              "status": "validation_passed"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000"
          }
        ]
      },
      "most_recent_collection": {
        "data": {
          "id": "00001c2a-0000-0000-0000-000000000000",
          "type": "type0"
        }
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

