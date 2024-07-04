
# Direct Debit Return Reversal Creation Response

## Structure

`DirectDebitReturnReversalCreationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`DirectDebitReturnReversal`](../../doc/models/direct-debit-return-reversal.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "key1": "val1",
      "key2": "val2"
    },
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "relationships": {
      "direct_debit": {
        "data": [
          {
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
              "category_purpose": "category_purpose8",
              "category_purpose_coded": "category_purpose_coded0",
              "clearing_id": "clearing_id6"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "direct_debit_admission": {
                "data": [
                  {
                    "attributes": {
                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                      "scheme_status_code": "scheme_status_code6",
                      "scheme_status_code_description": "scheme_status_code_description4",
                      "status": "failed",
                      "status_reason": "closed_account"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {}
                    },
                    "type": "type0",
                    "version": 110
                  },
                  {
                    "attributes": {
                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                      "scheme_status_code": "scheme_status_code6",
                      "scheme_status_code_description": "scheme_status_code_description4",
                      "status": "failed",
                      "status_reason": "closed_account"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {}
                    },
                    "type": "type0",
                    "version": 110
                  },
                  {
                    "attributes": {
                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                      "scheme_status_code": "scheme_status_code6",
                      "scheme_status_code_description": "scheme_status_code_description4",
                      "status": "failed",
                      "status_reason": "closed_account"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {}
                    },
                    "type": "type0",
                    "version": 110
                  }
                ]
              },
              "direct_debit_decision": {
                "data": [
                  {
                    "attributes": {
                      "answer": "rejected",
                      "reason": "reason0",
                      "reason_code": "reason_code8"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_decision_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "source_gateway": "source_gateway2",
                              "status": "failed",
                              "status_reason": "invalid_beneficiary_details"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "source_gateway": "source_gateway2",
                              "status": "failed",
                              "status_reason": "invalid_beneficiary_details"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_decision_submission": {
                        "data": [
                          {
                            "attributes": {
                              "auto": false,
                              "scheme_status_code": "scheme_status_code6",
                              "status": "delivery_confirmed",
                              "status_reason": "status_reason6",
                              "submission_datetime": "2016-03-13T12:52:32.123Z"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
                            "type": "type0"
                          },
                          {
                            "attributes": {
                              "auto": false,
                              "scheme_status_code": "scheme_status_code6",
                              "status": "delivery_confirmed",
                              "status_reason": "status_reason6",
                              "submission_datetime": "2016-03-13T12:52:32.123Z"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
                            "type": "type0"
                          },
                          {
                            "attributes": {
                              "auto": false,
                              "scheme_status_code": "scheme_status_code6",
                              "status": "delivery_confirmed",
                              "status_reason": "status_reason6",
                              "submission_datetime": "2016-03-13T12:52:32.123Z"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
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
                      "answer": "rejected",
                      "reason": "reason0",
                      "reason_code": "reason_code8"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_decision_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "source_gateway": "source_gateway2",
                              "status": "failed",
                              "status_reason": "invalid_beneficiary_details"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "source_gateway": "source_gateway2",
                              "status": "failed",
                              "status_reason": "invalid_beneficiary_details"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_decision_submission": {
                        "data": [
                          {
                            "attributes": {
                              "auto": false,
                              "scheme_status_code": "scheme_status_code6",
                              "status": "delivery_confirmed",
                              "status_reason": "status_reason6",
                              "submission_datetime": "2016-03-13T12:52:32.123Z"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
                            "type": "type0"
                          },
                          {
                            "attributes": {
                              "auto": false,
                              "scheme_status_code": "scheme_status_code6",
                              "status": "delivery_confirmed",
                              "status_reason": "status_reason6",
                              "submission_datetime": "2016-03-13T12:52:32.123Z"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
                            "type": "type0"
                          },
                          {
                            "attributes": {
                              "auto": false,
                              "scheme_status_code": "scheme_status_code6",
                              "status": "delivery_confirmed",
                              "status_reason": "status_reason6",
                              "submission_datetime": "2016-03-13T12:52:32.123Z"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision": {}
                            },
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
              "direct_debit_recall": {
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
                      "direct_debit": {},
                      "direct_debit_recall_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "source_gateway": "source_gateway2",
                              "status": "confirmed",
                              "status_reason": "status_reason6"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_recall": {}
                            }
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "source_gateway": "source_gateway2",
                              "status": "confirmed",
                              "status_reason": "status_reason6"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_recall": {}
                            }
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "source_gateway": "source_gateway2",
                              "status": "confirmed",
                              "status_reason": "status_reason6"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_recall": {}
                            }
                          }
                        ]
                      },
                      "direct_debit_recall_submission": {
                        "data": [
                          {
                            "attributes": {
                              "destination_gateway": "destination_gateway4",
                              "scheme_status_code": "scheme_status_code6",
                              "status": "queued_for_delivery",
                              "status_reason": "status_reason6",
                              "submission_datetime": "2016-03-13T12:52:32.123Z"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_recall": {}
                            },
                            "type": "type0"
                          },
                          {
                            "attributes": {
                              "destination_gateway": "destination_gateway4",
                              "scheme_status_code": "scheme_status_code6",
                              "status": "queued_for_delivery",
                              "status_reason": "status_reason6",
                              "submission_datetime": "2016-03-13T12:52:32.123Z"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_recall": {}
                            },
                            "type": "type0"
                          }
                        ]
                      }
                    }
                  }
                ]
              },
              "direct_debit_return": {
                "data": [
                  {
                    "attributes": {
                      "charges_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "clearing_id": "clearing_id6",
                      "compensation_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "processing_date": "2016-03-13",
                      "return_amount": {
                        "amount": "amount6",
                        "currency": "currency4"
                      }
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_return_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_return_reversal": {
                        "data": [
                          {}
                        ]
                      },
                      "direct_debit_return_submission": {
                        "data": [
                          {
                            "attributes": {
                              "file_identifier": "file_identifier6",
                              "file_number": "file_number4",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "delivery_confirmed"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
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
              "direct_debit_reversal": {
                "data": [
                  {
                    "attributes": {
                      "charges_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "processing_date": "2016-03-13",
                      "reason": "reason0",
                      "reason_code": "reason_code8",
                      "reversal_amount": {
                        "amount": "amount0",
                        "currency": "currency8"
                      }
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_reversal_admission": {
                        "data": [
                          {
                            "attributes": {
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "source_gateway": "source_gateway2",
                              "status": "confirmed"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "source_gateway": "source_gateway2",
                              "status": "confirmed"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_reversal_submission": {
                        "data": [
                          {
                            "attributes": {
                              "destination_gateway": "destination_gateway4",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "submitted",
                              "status_reason": "status_reason6"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal": {}
                            },
                            "type": "type0"
                          }
                        ]
                      }
                    },
                    "type": "type0"
                  },
                  {
                    "attributes": {
                      "charges_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "processing_date": "2016-03-13",
                      "reason": "reason0",
                      "reason_code": "reason_code8",
                      "reversal_amount": {
                        "amount": "amount0",
                        "currency": "currency8"
                      }
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_reversal_admission": {
                        "data": [
                          {
                            "attributes": {
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "source_gateway": "source_gateway2",
                              "status": "confirmed"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "source_gateway": "source_gateway2",
                              "status": "confirmed"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_reversal_submission": {
                        "data": [
                          {
                            "attributes": {
                              "destination_gateway": "destination_gateway4",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "submitted",
                              "status_reason": "status_reason6"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal": {}
                            },
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
            "type": "type0",
            "version": 110
          }
        ]
      },
      "direct_debit_return": {
        "data": [
          {
            "attributes": {
              "charges_amount": {
                "amount": "amount4",
                "currency": "currency2"
              },
              "clearing_id": "clearing_id6",
              "compensation_amount": {
                "amount": "amount4",
                "currency": "currency2"
              },
              "processing_date": "2016-03-13",
              "return_amount": {
                "amount": "amount6",
                "currency": "currency4"
              }
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "direct_debit": {},
              "direct_debit_return_admission": {
                "data": [
                  {
                    "attributes": {
                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                      "scheme_status_code": "scheme_status_code6",
                      "scheme_status_code_description": "scheme_status_code_description4",
                      "settlement_cycle": 146,
                      "settlement_date": "2016-03-13"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_return": {}
                    },
                    "type": "type0",
                    "version": 110
                  },
                  {
                    "attributes": {
                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                      "scheme_status_code": "scheme_status_code6",
                      "scheme_status_code_description": "scheme_status_code_description4",
                      "settlement_cycle": 146,
                      "settlement_date": "2016-03-13"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_return": {}
                    },
                    "type": "type0",
                    "version": 110
                  },
                  {
                    "attributes": {
                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                      "scheme_status_code": "scheme_status_code6",
                      "scheme_status_code_description": "scheme_status_code_description4",
                      "settlement_cycle": 146,
                      "settlement_date": "2016-03-13"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_return": {}
                    },
                    "type": "type0",
                    "version": 110
                  }
                ]
              },
              "direct_debit_return_reversal": {
                "data": [
                  {}
                ]
              },
              "direct_debit_return_submission": {
                "data": [
                  {
                    "attributes": {
                      "file_identifier": "file_identifier6",
                      "file_number": "file_number4",
                      "scheme_status_code": "scheme_status_code6",
                      "scheme_status_code_description": "scheme_status_code_description4",
                      "status": "delivery_confirmed"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_return": {}
                    },
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
      "direct_debit_return_reversal_admission": {
        "data": [
          {
            "attributes": {
              "scheme_status_code": "scheme_status_code6",
              "scheme_status_code_description": "scheme_status_code_description4"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "direct_debit": {
                "data": [
                  {
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
                      "category_purpose": "category_purpose8",
                      "category_purpose_coded": "category_purpose_coded0",
                      "clearing_id": "clearing_id6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "failed",
                              "status_reason": "closed_account"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "failed",
                              "status_reason": "closed_account"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "failed",
                              "status_reason": "closed_account"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_decision": {
                        "data": [
                          {
                            "attributes": {
                              "answer": "rejected",
                              "reason": "reason0",
                              "reason_code": "reason_code8"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_decision_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
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
                              "answer": "rejected",
                              "reason": "reason0",
                              "reason_code": "reason_code8"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_decision_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
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
                      "direct_debit_recall": {
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
                              "direct_debit": {},
                              "direct_debit_recall_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    }
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    }
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    }
                                  }
                                ]
                              },
                              "direct_debit_recall_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "queued_for_delivery",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "queued_for_delivery",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    },
                                    "type": "type0"
                                  }
                                ]
                              }
                            }
                          }
                        ]
                      },
                      "direct_debit_return": {
                        "data": [
                          {
                            "attributes": {
                              "charges_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "clearing_id": "clearing_id6",
                              "compensation_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "processing_date": "2016-03-13",
                              "return_amount": {
                                "amount": "amount6",
                                "currency": "currency4"
                              }
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "settlement_cycle": 146,
                                      "settlement_date": "2016-03-13"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "settlement_cycle": 146,
                                      "settlement_date": "2016-03-13"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "settlement_cycle": 146,
                                      "settlement_date": "2016-03-13"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_return_reversal": {
                                "data": [
                                  {}
                                ]
                              },
                              "direct_debit_return_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "file_identifier": "file_identifier6",
                                      "file_number": "file_number4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "status": "delivery_confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
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
                      "direct_debit_reversal": {
                        "data": [
                          {
                            "attributes": {
                              "charges_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "processing_date": "2016-03-13",
                              "reason": "reason0",
                              "reason_code": "reason_code8",
                              "reversal_amount": {
                                "amount": "amount0",
                                "currency": "currency8"
                              }
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_reversal_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "status": "submitted",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0"
                                  }
                                ]
                              }
                            },
                            "type": "type0"
                          },
                          {
                            "attributes": {
                              "charges_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "processing_date": "2016-03-13",
                              "reason": "reason0",
                              "reason_code": "reason_code8",
                              "reversal_amount": {
                                "amount": "amount0",
                                "currency": "currency8"
                              }
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_reversal_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "status": "submitted",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
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
                    "type": "type0",
                    "version": 110
                  }
                ]
              },
              "direct_debit_return": {
                "data": [
                  {
                    "attributes": {
                      "charges_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "clearing_id": "clearing_id6",
                      "compensation_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "processing_date": "2016-03-13",
                      "return_amount": {
                        "amount": "amount6",
                        "currency": "currency4"
                      }
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_return_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_return_reversal": {
                        "data": [
                          {}
                        ]
                      },
                      "direct_debit_return_submission": {
                        "data": [
                          {
                            "attributes": {
                              "file_identifier": "file_identifier6",
                              "file_number": "file_number4",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "delivery_confirmed"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
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
              "direct_debit_return_reversal": {
                "data": [
                  {}
                ]
              }
            },
            "type": "type0",
            "version": 110
          },
          {
            "attributes": {
              "scheme_status_code": "scheme_status_code6",
              "scheme_status_code_description": "scheme_status_code_description4"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "direct_debit": {
                "data": [
                  {
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
                      "category_purpose": "category_purpose8",
                      "category_purpose_coded": "category_purpose_coded0",
                      "clearing_id": "clearing_id6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "failed",
                              "status_reason": "closed_account"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "failed",
                              "status_reason": "closed_account"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "failed",
                              "status_reason": "closed_account"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_decision": {
                        "data": [
                          {
                            "attributes": {
                              "answer": "rejected",
                              "reason": "reason0",
                              "reason_code": "reason_code8"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_decision_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
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
                              "answer": "rejected",
                              "reason": "reason0",
                              "reason_code": "reason_code8"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_decision_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
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
                      "direct_debit_recall": {
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
                              "direct_debit": {},
                              "direct_debit_recall_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    }
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    }
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    }
                                  }
                                ]
                              },
                              "direct_debit_recall_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "queued_for_delivery",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "queued_for_delivery",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    },
                                    "type": "type0"
                                  }
                                ]
                              }
                            }
                          }
                        ]
                      },
                      "direct_debit_return": {
                        "data": [
                          {
                            "attributes": {
                              "charges_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "clearing_id": "clearing_id6",
                              "compensation_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "processing_date": "2016-03-13",
                              "return_amount": {
                                "amount": "amount6",
                                "currency": "currency4"
                              }
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "settlement_cycle": 146,
                                      "settlement_date": "2016-03-13"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "settlement_cycle": 146,
                                      "settlement_date": "2016-03-13"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "settlement_cycle": 146,
                                      "settlement_date": "2016-03-13"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_return_reversal": {
                                "data": [
                                  {}
                                ]
                              },
                              "direct_debit_return_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "file_identifier": "file_identifier6",
                                      "file_number": "file_number4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "status": "delivery_confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
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
                      "direct_debit_reversal": {
                        "data": [
                          {
                            "attributes": {
                              "charges_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "processing_date": "2016-03-13",
                              "reason": "reason0",
                              "reason_code": "reason_code8",
                              "reversal_amount": {
                                "amount": "amount0",
                                "currency": "currency8"
                              }
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_reversal_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "status": "submitted",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0"
                                  }
                                ]
                              }
                            },
                            "type": "type0"
                          },
                          {
                            "attributes": {
                              "charges_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "processing_date": "2016-03-13",
                              "reason": "reason0",
                              "reason_code": "reason_code8",
                              "reversal_amount": {
                                "amount": "amount0",
                                "currency": "currency8"
                              }
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_reversal_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "status": "submitted",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
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
                    "type": "type0",
                    "version": 110
                  }
                ]
              },
              "direct_debit_return": {
                "data": [
                  {
                    "attributes": {
                      "charges_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "clearing_id": "clearing_id6",
                      "compensation_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "processing_date": "2016-03-13",
                      "return_amount": {
                        "amount": "amount6",
                        "currency": "currency4"
                      }
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_return_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_return_reversal": {
                        "data": [
                          {}
                        ]
                      },
                      "direct_debit_return_submission": {
                        "data": [
                          {
                            "attributes": {
                              "file_identifier": "file_identifier6",
                              "file_number": "file_number4",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "delivery_confirmed"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
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
              "direct_debit_return_reversal": {
                "data": [
                  {}
                ]
              }
            },
            "type": "type0",
            "version": 110
          },
          {
            "attributes": {
              "scheme_status_code": "scheme_status_code6",
              "scheme_status_code_description": "scheme_status_code_description4"
            },
            "created_on": "2016-03-13T12:52:32.123Z",
            "id": "00001c2a-0000-0000-0000-000000000000",
            "modified_on": "2016-03-13T12:52:32.123Z",
            "organisation_id": "00000b24-0000-0000-0000-000000000000",
            "relationships": {
              "direct_debit": {
                "data": [
                  {
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
                      "category_purpose": "category_purpose8",
                      "category_purpose_coded": "category_purpose_coded0",
                      "clearing_id": "clearing_id6"
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "failed",
                              "status_reason": "closed_account"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "failed",
                              "status_reason": "closed_account"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "failed",
                              "status_reason": "closed_account"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_decision": {
                        "data": [
                          {
                            "attributes": {
                              "answer": "rejected",
                              "reason": "reason0",
                              "reason_code": "reason_code8"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_decision_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
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
                              "answer": "rejected",
                              "reason": "reason0",
                              "reason_code": "reason_code8"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_decision_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "failed",
                                      "status_reason": "invalid_beneficiary_details"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_decision_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "auto": false,
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "delivery_confirmed",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_decision": {}
                                    },
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
                      "direct_debit_recall": {
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
                              "direct_debit": {},
                              "direct_debit_recall_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    }
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    }
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    }
                                  }
                                ]
                              },
                              "direct_debit_recall_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "queued_for_delivery",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    },
                                    "type": "type0"
                                  },
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "status": "queued_for_delivery",
                                      "status_reason": "status_reason6",
                                      "submission_datetime": "2016-03-13T12:52:32.123Z"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_recall": {}
                                    },
                                    "type": "type0"
                                  }
                                ]
                              }
                            }
                          }
                        ]
                      },
                      "direct_debit_return": {
                        "data": [
                          {
                            "attributes": {
                              "charges_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "clearing_id": "clearing_id6",
                              "compensation_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "processing_date": "2016-03-13",
                              "return_amount": {
                                "amount": "amount6",
                                "currency": "currency4"
                              }
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "settlement_cycle": 146,
                                      "settlement_date": "2016-03-13"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "settlement_cycle": 146,
                                      "settlement_date": "2016-03-13"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "admission_datetime": "2016-03-13T12:52:32.123Z",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "settlement_cycle": 146,
                                      "settlement_date": "2016-03-13"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_return_reversal": {
                                "data": [
                                  {}
                                ]
                              },
                              "direct_debit_return_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "file_identifier": "file_identifier6",
                                      "file_number": "file_number4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "status": "delivery_confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_return": {}
                                    },
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
                      "direct_debit_reversal": {
                        "data": [
                          {
                            "attributes": {
                              "charges_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "processing_date": "2016-03-13",
                              "reason": "reason0",
                              "reason_code": "reason_code8",
                              "reversal_amount": {
                                "amount": "amount0",
                                "currency": "currency8"
                              }
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_reversal_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "status": "submitted",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0"
                                  }
                                ]
                              }
                            },
                            "type": "type0"
                          },
                          {
                            "attributes": {
                              "charges_amount": {
                                "amount": "amount4",
                                "currency": "currency2"
                              },
                              "processing_date": "2016-03-13",
                              "reason": "reason0",
                              "reason_code": "reason_code8",
                              "reversal_amount": {
                                "amount": "amount0",
                                "currency": "currency8"
                              }
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_reversal_admission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  },
                                  {
                                    "attributes": {
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "source_gateway": "source_gateway2",
                                      "status": "confirmed"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
                                    "type": "type0",
                                    "version": 110
                                  }
                                ]
                              },
                              "direct_debit_reversal_submission": {
                                "data": [
                                  {
                                    "attributes": {
                                      "destination_gateway": "destination_gateway4",
                                      "scheme_status_code": "scheme_status_code6",
                                      "scheme_status_code_description": "scheme_status_code_description4",
                                      "status": "submitted",
                                      "status_reason": "status_reason6"
                                    },
                                    "created_on": "2016-03-13T12:52:32.123Z",
                                    "id": "00001c2a-0000-0000-0000-000000000000",
                                    "modified_on": "2016-03-13T12:52:32.123Z",
                                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                                    "relationships": {
                                      "direct_debit": {},
                                      "direct_debit_reversal": {}
                                    },
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
                    "type": "type0",
                    "version": 110
                  }
                ]
              },
              "direct_debit_return": {
                "data": [
                  {
                    "attributes": {
                      "charges_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "clearing_id": "clearing_id6",
                      "compensation_amount": {
                        "amount": "amount4",
                        "currency": "currency2"
                      },
                      "processing_date": "2016-03-13",
                      "return_amount": {
                        "amount": "amount6",
                        "currency": "currency4"
                      }
                    },
                    "created_on": "2016-03-13T12:52:32.123Z",
                    "id": "00001c2a-0000-0000-0000-000000000000",
                    "modified_on": "2016-03-13T12:52:32.123Z",
                    "organisation_id": "00000b24-0000-0000-0000-000000000000",
                    "relationships": {
                      "direct_debit": {},
                      "direct_debit_return_admission": {
                        "data": [
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          },
                          {
                            "attributes": {
                              "admission_datetime": "2016-03-13T12:52:32.123Z",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "settlement_cycle": 146,
                              "settlement_date": "2016-03-13"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
                            "type": "type0",
                            "version": 110
                          }
                        ]
                      },
                      "direct_debit_return_reversal": {
                        "data": [
                          {}
                        ]
                      },
                      "direct_debit_return_submission": {
                        "data": [
                          {
                            "attributes": {
                              "file_identifier": "file_identifier6",
                              "file_number": "file_number4",
                              "scheme_status_code": "scheme_status_code6",
                              "scheme_status_code_description": "scheme_status_code_description4",
                              "status": "delivery_confirmed"
                            },
                            "created_on": "2016-03-13T12:52:32.123Z",
                            "id": "00001c2a-0000-0000-0000-000000000000",
                            "modified_on": "2016-03-13T12:52:32.123Z",
                            "organisation_id": "00000b24-0000-0000-0000-000000000000",
                            "relationships": {
                              "direct_debit": {},
                              "direct_debit_return": {}
                            },
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
              "direct_debit_return_reversal": {
                "data": [
                  {}
                ]
              }
            },
            "type": "type0",
            "version": 110
          }
        ]
      }
    },
    "type": "type0"
  }
}
```

