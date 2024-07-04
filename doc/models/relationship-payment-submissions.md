
# Relationship Payment Submissions

## Structure

`RelationshipPaymentSubmissions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<PaymentSubmission>`](../../doc/models/payment-submission.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "attributes": {
        "clearing_system": "clearing_system0",
        "file_identifier": "file_identifier6",
        "file_number": "file_number4",
        "limit_breach_end_datetime": "2016-03-13T12:52:32.123Z",
        "limit_breach_start_datetime": "2016-03-13T12:52:32.123Z"
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
        "payment_submission_task": {
          "data": [
            {
              "attributes": {
                "assignee": "form3",
                "name": "name4",
                "output": {
                  "key0": {
                    "key1": "val1",
                    "key2": "val2"
                  },
                  "key1": {
                    "key1": "val1",
                    "key2": "val2"
                  },
                  "key2": {
                    "key1": "val1",
                    "key2": "val2"
                  }
                },
                "status": "pending"
              },
              "created_on": "2016-03-13T12:52:32.123Z",
              "id": "00001c2a-0000-0000-0000-000000000000",
              "modified_on": "2016-03-13T12:52:32.123Z",
              "organisation_id": "00000b24-0000-0000-0000-000000000000"
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
    {
      "attributes": {
        "clearing_system": "clearing_system0",
        "file_identifier": "file_identifier6",
        "file_number": "file_number4",
        "limit_breach_end_datetime": "2016-03-13T12:52:32.123Z",
        "limit_breach_start_datetime": "2016-03-13T12:52:32.123Z"
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
        "payment_submission_task": {
          "data": [
            {
              "attributes": {
                "assignee": "form3",
                "name": "name4",
                "output": {
                  "key0": {
                    "key1": "val1",
                    "key2": "val2"
                  },
                  "key1": {
                    "key1": "val1",
                    "key2": "val2"
                  },
                  "key2": {
                    "key1": "val1",
                    "key2": "val2"
                  }
                },
                "status": "pending"
              },
              "created_on": "2016-03-13T12:52:32.123Z",
              "id": "00001c2a-0000-0000-0000-000000000000",
              "modified_on": "2016-03-13T12:52:32.123Z",
              "organisation_id": "00000b24-0000-0000-0000-000000000000"
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
    }
  ]
}
```

