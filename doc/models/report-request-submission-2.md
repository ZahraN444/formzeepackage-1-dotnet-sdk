
# Report Request Submission 2

## Structure

`ReportRequestSubmission2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ReportRequestSubmission>`](../../doc/models/report-request-submission.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "attributes": {
        "scheme_status_code": "scheme_status_code6",
        "status": "delivery_failed",
        "status_reason": "status_reason6"
      },
      "created_on": "2016-03-13T12:52:32.123Z",
      "id": "00001c2a-0000-0000-0000-000000000000",
      "modified_on": "2016-03-13T12:52:32.123Z",
      "organisation_id": "00000b24-0000-0000-0000-000000000000",
      "relationships": {
        "report_request": {
          "data": [
            {
              "attributes": {
                "filter": {
                  "date_from": "2016-03-13",
                  "date_to": "2016-03-13",
                  "report_users": [
                    {
                      "user_id": "user_id8",
                      "user_id_code": "user_id_code4"
                    }
                  ]
                },
                "payment_scheme": "payment_scheme4",
                "report_type": "report_type8",
                "status": "pending"
              },
              "created_on": "2016-03-13T12:52:32.123Z",
              "id": "00001c2a-0000-0000-0000-000000000000",
              "modified_on": "2016-03-13T12:52:32.123Z",
              "organisation_id": "00000b24-0000-0000-0000-000000000000",
              "relationships": {
                "report": {
                  "data": [
                    {
                      "attributes": {
                        "formats": [
                          "formats5",
                          "formats6"
                        ],
                        "generation_time": "2016-03-13T12:52:32.123Z",
                        "processing_date": "2016-03-13",
                        "report_source": "report_source2",
                        "report_type": "report_type8"
                      },
                      "created_on": "2016-03-13T12:52:32.123Z",
                      "id": "00001c2a-0000-0000-0000-000000000000",
                      "modified_on": "2016-03-13T12:52:32.123Z",
                      "organisation_id": "00000b24-0000-0000-0000-000000000000",
                      "relationships": {
                        "report_admission": {
                          "data": [
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            },
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            }
                          ]
                        },
                        "report_request": {
                          "data": [
                            {},
                            {}
                          ]
                        },
                        "transaction_file": {
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
                      "type": "reports",
                      "version": 110
                    },
                    {
                      "attributes": {
                        "formats": [
                          "formats5",
                          "formats6"
                        ],
                        "generation_time": "2016-03-13T12:52:32.123Z",
                        "processing_date": "2016-03-13",
                        "report_source": "report_source2",
                        "report_type": "report_type8"
                      },
                      "created_on": "2016-03-13T12:52:32.123Z",
                      "id": "00001c2a-0000-0000-0000-000000000000",
                      "modified_on": "2016-03-13T12:52:32.123Z",
                      "organisation_id": "00000b24-0000-0000-0000-000000000000",
                      "relationships": {
                        "report_admission": {
                          "data": [
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            },
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            }
                          ]
                        },
                        "report_request": {
                          "data": [
                            {},
                            {}
                          ]
                        },
                        "transaction_file": {
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
                      "type": "reports",
                      "version": 110
                    },
                    {
                      "attributes": {
                        "formats": [
                          "formats5",
                          "formats6"
                        ],
                        "generation_time": "2016-03-13T12:52:32.123Z",
                        "processing_date": "2016-03-13",
                        "report_source": "report_source2",
                        "report_type": "report_type8"
                      },
                      "created_on": "2016-03-13T12:52:32.123Z",
                      "id": "00001c2a-0000-0000-0000-000000000000",
                      "modified_on": "2016-03-13T12:52:32.123Z",
                      "organisation_id": "00000b24-0000-0000-0000-000000000000",
                      "relationships": {
                        "report_admission": {
                          "data": [
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            },
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            }
                          ]
                        },
                        "report_request": {
                          "data": [
                            {},
                            {}
                          ]
                        },
                        "transaction_file": {
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
                      "type": "reports",
                      "version": 110
                    }
                  ]
                },
                "report_request_submission": {
                  "data": [
                    {},
                    {},
                    {}
                  ]
                }
              },
              "type": "report_requests",
              "version": 110
            },
            {
              "attributes": {
                "filter": {
                  "date_from": "2016-03-13",
                  "date_to": "2016-03-13",
                  "report_users": [
                    {
                      "user_id": "user_id8",
                      "user_id_code": "user_id_code4"
                    }
                  ]
                },
                "payment_scheme": "payment_scheme4",
                "report_type": "report_type8",
                "status": "pending"
              },
              "created_on": "2016-03-13T12:52:32.123Z",
              "id": "00001c2a-0000-0000-0000-000000000000",
              "modified_on": "2016-03-13T12:52:32.123Z",
              "organisation_id": "00000b24-0000-0000-0000-000000000000",
              "relationships": {
                "report": {
                  "data": [
                    {
                      "attributes": {
                        "formats": [
                          "formats5",
                          "formats6"
                        ],
                        "generation_time": "2016-03-13T12:52:32.123Z",
                        "processing_date": "2016-03-13",
                        "report_source": "report_source2",
                        "report_type": "report_type8"
                      },
                      "created_on": "2016-03-13T12:52:32.123Z",
                      "id": "00001c2a-0000-0000-0000-000000000000",
                      "modified_on": "2016-03-13T12:52:32.123Z",
                      "organisation_id": "00000b24-0000-0000-0000-000000000000",
                      "relationships": {
                        "report_admission": {
                          "data": [
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            },
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            }
                          ]
                        },
                        "report_request": {
                          "data": [
                            {},
                            {}
                          ]
                        },
                        "transaction_file": {
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
                      "type": "reports",
                      "version": 110
                    },
                    {
                      "attributes": {
                        "formats": [
                          "formats5",
                          "formats6"
                        ],
                        "generation_time": "2016-03-13T12:52:32.123Z",
                        "processing_date": "2016-03-13",
                        "report_source": "report_source2",
                        "report_type": "report_type8"
                      },
                      "created_on": "2016-03-13T12:52:32.123Z",
                      "id": "00001c2a-0000-0000-0000-000000000000",
                      "modified_on": "2016-03-13T12:52:32.123Z",
                      "organisation_id": "00000b24-0000-0000-0000-000000000000",
                      "relationships": {
                        "report_admission": {
                          "data": [
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            },
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            }
                          ]
                        },
                        "report_request": {
                          "data": [
                            {},
                            {}
                          ]
                        },
                        "transaction_file": {
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
                      "type": "reports",
                      "version": 110
                    },
                    {
                      "attributes": {
                        "formats": [
                          "formats5",
                          "formats6"
                        ],
                        "generation_time": "2016-03-13T12:52:32.123Z",
                        "processing_date": "2016-03-13",
                        "report_source": "report_source2",
                        "report_type": "report_type8"
                      },
                      "created_on": "2016-03-13T12:52:32.123Z",
                      "id": "00001c2a-0000-0000-0000-000000000000",
                      "modified_on": "2016-03-13T12:52:32.123Z",
                      "organisation_id": "00000b24-0000-0000-0000-000000000000",
                      "relationships": {
                        "report_admission": {
                          "data": [
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            },
                            {
                              "attributes": {
                                "admission_datetime": "2016-03-13T12:52:32.123Z",
                                "scheme_status_code": "scheme_status_code6",
                                "scheme_status_code_description": "scheme_status_code_description4",
                                "status": "confirmed"
                              },
                              "created_on": "2016-03-13T12:52:32.123Z",
                              "id": "00001c2a-0000-0000-0000-000000000000",
                              "modified_on": "2016-03-13T12:52:32.123Z",
                              "organisation_id": "00000b24-0000-0000-0000-000000000000",
                              "relationships": {
                                "report": {}
                              },
                              "type": "report_admissions"
                            }
                          ]
                        },
                        "report_request": {
                          "data": [
                            {},
                            {}
                          ]
                        },
                        "transaction_file": {
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
                      "type": "reports",
                      "version": 110
                    }
                  ]
                },
                "report_request_submission": {
                  "data": [
                    {},
                    {},
                    {}
                  ]
                }
              },
              "type": "report_requests",
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
```

