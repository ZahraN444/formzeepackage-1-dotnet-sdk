
# Credential Creation Response

## Structure

`CredentialCreationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`CredentialSecret`](../../doc/models/credential-secret.md) | Required | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "client_id": "client_id2",
    "client_secret": "client_secret8"
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

