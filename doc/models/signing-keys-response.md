
# Signing Keys Response

## Structure

`SigningKeysResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`SigningKeysResponseData`](../../doc/models/signing-keys-response-data.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "certificate": "certificate2",
      "expiration_datetime": "2016-03-13T12:52:32.123Z",
      "public_key": "public_key8",
      "revocation_datetime": "2016-03-13T12:52:32.123Z",
      "status": "expired"
    },
    "id": "00001c2a-0000-0000-0000-000000000000",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "type": "signing_keys",
    "version": 110,
    "created_on": "2016-03-13T12:52:32.123Z",
    "modified_on": "2016-03-13T12:52:32.123Z"
  }
}
```

