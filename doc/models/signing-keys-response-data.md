
# Signing Keys Response Data

## Structure

`SigningKeysResponseData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`SigningKeysAttributes`](../../doc/models/signing-keys-attributes.md) | Required | - |
| `CreatedOn` | `DateTime?` | Optional | - |
| `Id` | `Guid` | Required | - |
| `ModifiedOn` | `DateTime?` | Optional | - |
| `OrganisationId` | `Guid` | Required | - |
| `Type` | `string` | Required, Constant | **Default**: `"signing_keys"` |
| `Version` | `int` | Required | - |

## Example (as JSON)

```json
{
  "attributes": {
    "certificate": "certificate2",
    "expiration_datetime": "2016-03-13T12:52:32.123Z",
    "public_key": "public_key8",
    "revocation_datetime": "2016-03-13T12:52:32.123Z",
    "status": "expired"
  },
  "id": "0000230a-0000-0000-0000-000000000000",
  "organisation_id": "00001204-0000-0000-0000-000000000000",
  "type": "signing_keys",
  "version": 78,
  "created_on": "2016-03-13T12:52:32.123Z",
  "modified_on": "2016-03-13T12:52:32.123Z"
}
```

