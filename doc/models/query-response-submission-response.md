
# Query Response Submission Response

## Structure

`QueryResponseSubmissionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`QueryResponseSubmission`](../../doc/models/query-response-submission.md) | Required | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "auto": false,
      "status": "submitted",
      "status_reason": "status_reason6"
    },
    "id": "00001c2a-0000-0000-0000-000000000000",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "type": "query_response_submissions",
    "version": 110,
    "created_on": "2016-03-13T12:52:32.123Z",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "relationships": {
      "query": {
        "data": [
          {
            "attributes": {
              "agents": [
                {
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
                  "role": "role6"
                },
                {
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
                  "role": "role6"
                },
                {
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
                  "role": "role6"
                }
              ],
              "auto_handled": false,
              "creator_party": {
                "birth_city": "birth_city6",
                "birth_country": "birth_country0",
                "birth_date": "birth_date8",
                "birth_province": "birth_province6",
                "name": "name6"
              },
              "message_id": "message_id8",
              "processing_date": "2016-03-13",
              "query_type": "claim_non_receipt"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
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
              "payment_admission": {
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
              "payment_submission": {
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
              "query": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "query_admission": {
                "data": [
                  {
                    "attributes": {
                      "status": "confirmed",
                      "status_reason": "status_reason6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "query": {}
                    },
                    "type": "type0",
                    "version": 110
                  },
                  {
                    "attributes": {
                      "status": "confirmed",
                      "status_reason": "status_reason6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "query": {}
                    },
                    "type": "type0",
                    "version": 110
                  }
                ]
              }
            },
            "type": "type0",
            "version": 110
          }
        ]
      },
      "query_response": {
        "data": [
          {
            "attributes": {
              "answer": "transaction_not_processed",
              "charges": {
                "account_number": "account_number4",
                "account_number_code": "account_number_code6",
                "amount": "amount8",
                "currency": "currency6"
              },
              "compensation": {
                "account_number": "account_number2",
                "account_number_code": "account_number_code4",
                "amount": "amount0",
                "currency": "currency2"
              },
              "compensation_amount": "compensation_amount6",
              "currency": "currency4",
              "information": {
                "beneficiary_party": {
                  "account_number": "account_number8",
                  "account_number_code": "IBAN",
                  "account_proxy": {
                    "proxy": "proxy4",
                    "proxy_id": "proxy_id4",
                    "proxy_id_code": "proxy_id_code4"
                  },
                  "account_with": {
                    "bank_id": "bank_id2",
                    "bank_id_code": "bank_id_code0",
                    "bank_name": "bank_name4"
                  },
                  "additional_address_line": "additional_address_line4"
                },
                "correction_transaction_information": {
                  "amount": "amount4",
                  "currency": "currency2",
                  "end_to_end_reference": "end_to_end_reference2",
                  "instruction_id": "instruction_id6",
                  "processing_date": "2016-03-13"
                },
                "debtor_party": {
                  "account_number": "account_number4",
                  "account_number_code": "IBAN",
                  "account_proxy": {
                    "proxy": "proxy4",
                    "proxy_id": "proxy_id4",
                    "proxy_id_code": "proxy_id_code4"
                  },
                  "account_with": {
                    "bank_id": "bank_id2",
                    "bank_id_code": "bank_id_code0",
                    "bank_name": "bank_name4"
                  },
                  "additional_address_line": "additional_address_line6"
                },
                "duplicate_transaction_information": {
                  "end_to_end_reference": "end_to_end_reference0",
                  "references": [
                    {
                      "type": "type8",
                      "value": "value4"
                    }
                  ],
                  "scheme_transaction_id": "scheme_transaction_id6"
                },
                "payment_type_information": {
                  "amount": "amount0",
                  "category_purpose": "category_purpose2",
                  "currency": "currency8",
                  "payment_purpose": "payment_purpose4",
                  "processing_date": "2016-03-13"
                }
              }
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "query": {
                "data": [
                  {
                    "attributes": {
                      "agents": [
                        {
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
                          "role": "role6"
                        },
                        {
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
                          "role": "role6"
                        },
                        {
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
                          "role": "role6"
                        }
                      ],
                      "auto_handled": false,
                      "creator_party": {
                        "birth_city": "birth_city6",
                        "birth_country": "birth_country0",
                        "birth_date": "birth_date8",
                        "birth_province": "birth_province6",
                        "name": "name6"
                      },
                      "message_id": "message_id8",
                      "processing_date": "2016-03-13",
                      "query_type": "claim_non_receipt"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
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
                      "payment_admission": {
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
                      "payment_submission": {
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
                      "query": {
                        "data": [
                          {
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "type": "type0"
                          }
                        ]
                      },
                      "query_admission": {
                        "data": [
                          {
                            "attributes": {
                              "status": "confirmed",
                              "status_reason": "status_reason6"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "query": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "status": "confirmed",
                              "status_reason": "status_reason6"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "query": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      }
                    },
                    "type": "type0",
                    "version": 110
                  }
                ]
              },
              "query_response_admission": {
                "data": [
                  {
                    "attributes": {
                      "status": "failed",
                      "status_reason": "status_reason6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
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
                      "query": {
                        "data": [
                          {
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "type": "type0"
                          }
                        ]
                      },
                      "query_response": {
                        "data": [
                          {
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "type": "type0"
                          }
                        ]
                      },
                      "recall": {
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
                  },
                  {
                    "attributes": {
                      "status": "failed",
                      "status_reason": "status_reason6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
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
                      "query": {
                        "data": [
                          {
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "type": "type0"
                          }
                        ]
                      },
                      "query_response": {
                        "data": [
                          {
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "type": "type0"
                          }
                        ]
                      },
                      "recall": {
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
                  },
                  {
                    "attributes": {
                      "status": "failed",
                      "status_reason": "status_reason6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
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
                      "query": {
                        "data": [
                          {
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "type": "type0"
                          }
                        ]
                      },
                      "query_response": {
                        "data": [
                          {
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "type": "type0"
                          }
                        ]
                      },
                      "recall": {
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
                ]
              },
              "query_response_submission": {
                "data": [
                  {
                    "attributes": {
                      "auto": false,
                      "status": "submitted",
                      "status_reason": "status_reason6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {},
                    "type": "type0",
                    "version": 110
                  },
                  {
                    "attributes": {
                      "auto": false,
                      "status": "submitted",
                      "status_reason": "status_reason6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {},
                    "type": "type0",
                    "version": 110
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

