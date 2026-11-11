# Camper
An application for campers or camping.

Users can create and plan camping trips, that will allow them to manage equipment, prep for weather changes, receive alerts about a camping experience.

Features to include:

Allow visualizing current location with GPS while on the main screen of the application.

Camper Alerts (Weather Alert, Equipement Alert, GPS Alert)

Camper Equip list and check list for modifying camping setup or for planning.

## Campsite API

Set the `CAMPSITE_API_URL` environment variable to the full HTTP or HTTPS URL of a campsite endpoint before starting the application (and Visual Studio, if launching from it). Opening Campsites sends a GET request and displays the results. The endpoint must return a JSON array with lowercase `name`, `location`, and `capacity` properties, for example:

```json
[{"name":"Pine Camp","location":"Colorado","capacity":20}]
```

The APIService project supplies the HTTP client; its Windows service skeleton does not host a campsite API. An empty or invalid URL, request failure, or invalid response is reported on the Campsites page.
