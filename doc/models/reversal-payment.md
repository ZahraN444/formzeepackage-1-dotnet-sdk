
# Reversal Payment

## Structure

`ReversalPayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes13`](../../doc/models/attributes-13.md) | Optional | - |
| `CreatedOn` | `DateTime?` | Optional | - |
| `Id` | `Guid` | Required | Unique resource ID |
| `ModifiedOn` | `DateTime?` | Optional | - |
| `OrganisationId` | `Guid` | Required | Unique ID of the organisation this resource is created by |
| `Relationships` | [`Relationships3`](../../doc/models/relationships-3.md) | Optional | - |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "reversals",
  "version": 0,
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
  "created_on": "2016-03-13T12:52:32.123Z",
  "modified_on": "2016-03-13T12:52:32.123Z",
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
    "reversal_admission": {
      "data": [
        {
          "attributes": {
            "scheme_status_code": "scheme_status_code6",
            "scheme_status_code_description": "scheme_status_code_description4",
            "source_gateway": "source_gateway2",
            "status": "pending"
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
            "reversal": {
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
                  "created_on": "2016-03-13T12:52:32.123Z",
                  "id": "00001c2a-0000-0000-0000-000000000000",
                  "modified_on": "2016-03-13T12:52:32.123Z",
                  "organisation_id": "00000b24-0000-0000-0000-000000000000",
                  "relationships": {},
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
                  "created_on": "2016-03-13T12:52:32.123Z",
                  "id": "00001c2a-0000-0000-0000-000000000000",
                  "modified_on": "2016-03-13T12:52:32.123Z",
                  "organisation_id": "00000b24-0000-0000-0000-000000000000",
                  "relationships": {},
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
                  "created_on": "2016-03-13T12:52:32.123Z",
                  "id": "00001c2a-0000-0000-0000-000000000000",
                  "modified_on": "2016-03-13T12:52:32.123Z",
                  "organisation_id": "00000b24-0000-0000-0000-000000000000",
                  "relationships": {},
                  "type": "type0"
                }
              ]
            },
            "reversal_admission_task": {
              "data": [
                {
                  "attributes": {
                    "assignee": "customer",
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
                },
                {
                  "attributes": {
                    "assignee": "customer",
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
            }
          },
          "type": "type0"
        },
        {
          "attributes": {
            "scheme_status_code": "scheme_status_code6",
            "scheme_status_code_description": "scheme_status_code_description4",
            "source_gateway": "source_gateway2",
            "status": "pending"
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
            "reversal": {
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
                  "created_on": "2016-03-13T12:52:32.123Z",
                  "id": "00001c2a-0000-0000-0000-000000000000",
                  "modified_on": "2016-03-13T12:52:32.123Z",
                  "organisation_id": "00000b24-0000-0000-0000-000000000000",
                  "relationships": {},
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
                  "created_on": "2016-03-13T12:52:32.123Z",
                  "id": "00001c2a-0000-0000-0000-000000000000",
                  "modified_on": "2016-03-13T12:52:32.123Z",
                  "organisation_id": "00000b24-0000-0000-0000-000000000000",
                  "relationships": {},
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
                  "created_on": "2016-03-13T12:52:32.123Z",
                  "id": "00001c2a-0000-0000-0000-000000000000",
                  "modified_on": "2016-03-13T12:52:32.123Z",
                  "organisation_id": "00000b24-0000-0000-0000-000000000000",
                  "relationships": {},
                  "type": "type0"
                }
              ]
            },
            "reversal_admission_task": {
              "data": [
                {
                  "attributes": {
                    "assignee": "customer",
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
                },
                {
                  "attributes": {
                    "assignee": "customer",
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
            }
          },
          "type": "type0"
        },
        {
          "attributes": {
            "scheme_status_code": "scheme_status_code6",
            "scheme_status_code_description": "scheme_status_code_description4",
            "source_gateway": "source_gateway2",
            "status": "pending"
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
            "reversal": {
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
                  "created_on": "2016-03-13T12:52:32.123Z",
                  "id": "00001c2a-0000-0000-0000-000000000000",
                  "modified_on": "2016-03-13T12:52:32.123Z",
                  "organisation_id": "00000b24-0000-0000-0000-000000000000",
                  "relationships": {},
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
                  "created_on": "2016-03-13T12:52:32.123Z",
                  "id": "00001c2a-0000-0000-0000-000000000000",
                  "modified_on": "2016-03-13T12:52:32.123Z",
                  "organisation_id": "00000b24-0000-0000-0000-000000000000",
                  "relationships": {},
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
                  "created_on": "2016-03-13T12:52:32.123Z",
                  "id": "00001c2a-0000-0000-0000-000000000000",
                  "modified_on": "2016-03-13T12:52:32.123Z",
                  "organisation_id": "00000b24-0000-0000-0000-000000000000",
                  "relationships": {},
                  "type": "type0"
                }
              ]
            },
            "reversal_admission_task": {
              "data": [
                {
                  "attributes": {
                    "assignee": "customer",
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
                },
                {
                  "attributes": {
                    "assignee": "customer",
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
            }
          },
          "type": "type0"
        }
      ]
    },
    "reversal_submission": {
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
  }
}
```

