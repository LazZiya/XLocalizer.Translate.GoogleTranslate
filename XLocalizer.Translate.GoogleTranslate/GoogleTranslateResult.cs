using Newtonsoft.Json;

namespace XLocalizer.Translate.GoogleTranslate
{
    /// <summary>
    /// Google translate result object
    /// </summary>
    public class GoogleTranslateResult
    {
        /// <summary>
        /// Google trnaslate data object
        /// </summary>
        [JsonProperty("data")]
        public GoogleData Data { get; set; }
    }

    /// <summary>
    /// Google translate data object
    /// </summary>
    public class GoogleData
    {
        /// <summary>
        /// Google translate result list
        /// </summary>
        [JsonProperty("translations")]
        public GoogleTranslation[] Translations { get; set; }
    }

    /// <summary>
    /// Google tranlste result text
    /// </summary>
    public class GoogleTranslation
    {
        /// <summary>
        /// Google translate result text
        /// </summary>
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }
    }
}