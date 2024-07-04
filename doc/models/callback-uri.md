
# Callback URI

## Structure

`CallbackURI`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CallbackTransport` | [`CallbackTransportEnum`](../../doc/models/callback-transport-enum.md) | Required | - |
| `CallbackUri` | `string` | Required | URI that will be called with the notification<br>**Constraints**: *Pattern*: `^[A-Za-z0-9 .,@:\&\?=\/\-_]*$` |

## Example (as JSON)

```json
{
  "callback_transport": "queue",
  "callback_uri": "callback_uri4"
}
```

