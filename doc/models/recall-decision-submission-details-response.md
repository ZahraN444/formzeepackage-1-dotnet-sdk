
# Recall Decision Submission Details Response

## Structure

`RecallDecisionSubmissionDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`RecallDecisionSubmission`](../../doc/models/recall-decision-submission.md) | Optional | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "auto": false,
      "status": "delivery_confirmed",
      "status_reason": "status_reason6",
      "submission_datetime": "2016-03-13T12:52:32.123Z"
    },
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "relationships": {
      "payment": {
        "data": [
          {
            "attributes": {
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
              "amount": "amount6",
              "batch_booking_indicator": "batch_booking_indicator2",
              "batch_id": "batch_id6",
              "batch_type": "batch_type0"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "beneficiary": {
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
              "beneficiary_account": {
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
              "debtor": {
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
              "debtor_account": {
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
              "forwarded_payment": {
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
              "amount": "amount6",
              "batch_booking_indicator": "batch_booking_indicator2",
              "batch_id": "batch_id6",
              "batch_type": "batch_type0"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "beneficiary": {
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
              "beneficiary_account": {
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
              "debtor": {
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
              "debtor_account": {
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
              "forwarded_payment": {
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
              "amount": "amount6",
              "batch_booking_indicator": "batch_booking_indicator2",
              "batch_id": "batch_id6",
              "batch_type": "batch_type0"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "beneficiary": {
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
              "beneficiary_account": {
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
              "debtor": {
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
              "debtor_account": {
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
              "forwarded_payment": {
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
      },
      "recall": {
        "data": [
          {
            "attributes": {
              "reason": "reason0",
              "reason_code": "reason_code8",
              "status": "confirmed"
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
              "recall_admission": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "recall_decisions": {
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
              "recall_reversal": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "recall_submission": {
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
          {
            "attributes": {
              "reason": "reason0",
              "reason_code": "reason_code8",
              "status": "confirmed"
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
              "recall_admission": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "recall_decisions": {
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
              "recall_reversal": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "recall_submission": {
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
          {
            "attributes": {
              "reason": "reason0",
              "reason_code": "reason_code8",
              "status": "confirmed"
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
              "recall_admission": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "recall_decisions": {
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
              "recall_reversal": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "recall_submission": {
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
          }
        ]
      },
      "recall_decision": {
        "data": [
          {
            "attributes": {
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
              "answer": "pending",
              "charges_amount": {
                "amount": "amount4",
                "currency": "currency2"
              },
              "reason": "reason0",
              "reason_code": "reason_code8"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "decision_admission": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "decision_submission": {
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
            "type": "type0"
          },
          {
            "attributes": {
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
              "answer": "pending",
              "charges_amount": {
                "amount": "amount4",
                "currency": "currency2"
              },
              "reason": "reason0",
              "reason_code": "reason_code8"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "decision_admission": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "decision_submission": {
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
            "type": "type0"
          },
          {
            "attributes": {
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
              "answer": "pending",
              "charges_amount": {
                "amount": "amount4",
                "currency": "currency2"
              },
              "reason": "reason0",
              "reason_code": "reason_code8"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "decision_admission": {
                "data": [
                  {
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "type": "type0"
                  }
                ]
              },
              "decision_submission": {
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
