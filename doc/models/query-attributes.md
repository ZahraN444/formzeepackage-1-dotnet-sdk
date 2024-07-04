
# Query Attributes

## Structure

`QueryAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Agents` | [`List<RequestForInformationAgent>`](../../doc/models/request-for-information-agent.md) | Optional | - |
| `AutoHandled` | `bool?` | Optional | - |
| `CreatorParty` | [`RequestForInformationCreatorParty`](../../doc/models/request-for-information-creator-party.md) | Optional | - |
| `MessageId` | `string` | Optional | - |
| `ProcessingDate` | `DateTime?` | Optional | - |
| `QuerySubTypes` | `List<string>` | Optional | - |
| `QueryType` | [`QueryTypeEnum`](../../doc/models/query-type-enum.md) | Required | - |
| `References` | [`List<RequestForInformationReference>`](../../doc/models/request-for-information-reference.md) | Optional | - |
| `RequestedInformation` | [`List<RequestForInformationRequestedInformation>`](../../doc/models/request-for-information-requested-information.md) | Optional | - |
| `SchemeTransactionId` | `string` | Optional | - |
| `Status` | [`ReportRequestStatusEnum?`](../../doc/models/report-request-status-enum.md) | Optional | - |
| `UnstructuredMessage` | `string` | Optional | - |

## Example (as JSON)

```json
{
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
  "message_id": "message_id2",
  "processing_date": "2016-03-13",
  "query_type": "claim_non_receipt"
}
```

