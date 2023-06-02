# Weather aplication
## Weather Api
- open-meteo (https://open-meteo.com/)
## .NET version
- 7.0
## Design pattern
- MVVM

# API Requests
## GetCurrentWeather
Request:
https://api.open-meteo.com/v1/forecast?latitude=49.98&longitude=18.95&current_weather=true&timezone=Europe/Warsaw&forecast_days=1

Response:
```JSON
{
  "latitude": 50.0,
  "longitude": 18.9375,
  "generationtime_ms": 0.44608116149902344,
  "utc_offset_seconds": 7200,
  "timezone": "Europe/Warsaw",
  "timezone_abbreviation": "CEST",
  "elevation": 246.0,
  "current_weather": {
    "temperature": 15.3,
    "windspeed": 12.6,
    "winddirection": 20.0,
    "weathercode": 2,
    "is_day": 1,
    "time": "2023-06-02T20:00"
  }
}
```
## GetLocalizaton
Exampe request:
https://geocoding-api.open-meteo.com/v1/search?name=Richmond

Example response:
```JSON
{
  "results": [
    {
      "id": 4781708,
      "name": "Richmond",
      "latitude": 37.55376,
      "longitude": -77.46026,
      "elevation": 64.0,
      "feature_code": "PPLA",
      "country_code": "US",
      "admin1_id": 6254928,
      "admin2_id": 4781756,
      "timezone": "America/New_York",
      "population": 220289,
      "postcodes": [
        "23218",
        "23219"
      ],
      "country_id": 6252001,
      "country": "United States",
      "admin1": "Virginia",
      "admin2": "City of Richmond"
    },
    {
      "id": 6122085,
      "name": "Richmond",
      "latitude": 49.17003,
      "longitude": -123.13683,
      "elevation": 9.0,
      "feature_code": "PPL",
      "country_code": "CA",
      "admin1_id": 5909050,
      "admin2_id": 5965814,
      "admin3_id": 12031871,
      "timezone": "America/Vancouver",
      "population": 182000,
      "country_id": 6251999,
      "country": "Canada",
      "admin1": "British Columbia",
      "admin2": "Greater Vancouver Regional District",
      "admin3": "Richmond"
    }
  ],
  "generationtime_ms": 1.1119843
}
```