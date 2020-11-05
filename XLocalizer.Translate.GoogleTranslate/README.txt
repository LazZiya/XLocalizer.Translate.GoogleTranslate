XLocalizer.TranslationServices.GoogleTranslate

Instructions to use this package :

- This package requires Rapid API Key, must be obtained from https://rapidapi.com/googlecloud/api/google-translate1
- Add the API key to user secrets :

````
{
  "XLocalizer.Translate": {
    "RapidApiKey": "xxx-rapid-api-key-xxx"
  }
}
````

- Register in startup:
````
services.AddHttpClient<ITranslator, GoogleTranslateService>();
````

Repository: https://github.com/LazZiya/XLocalizer.Translate.GoogleTranslate
Docs: https://docs.ziyad.info/en/XLocalizer/v1.0/translate-services-google.md