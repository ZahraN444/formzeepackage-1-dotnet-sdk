
# Duplicate Transaction Information

## Structure

`DuplicateTransactionInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EndToEndReference` | `string` | Optional | Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.<br>**Constraints**: *Maximum Length*: `35` |
| `References` | [`List<QueryReference>`](../../doc/models/query-reference.md) | Optional | Reference for the duplicated payment for this Exception and Investigation case. |
| `SchemeTransactionId` | `string` | Optional | Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.<br>**Constraints**: *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "end_to_end_reference": "end_to_end_reference2",
  "references": [
    {
      "type": "type8",
      "value": "value4"
    },
    {
      "type": "type8",
      "value": "value4"
    },
    {
      "type": "type8",
      "value": "value4"
    }
  ],
  "scheme_transaction_id": "scheme_transaction_id4"
}
```

