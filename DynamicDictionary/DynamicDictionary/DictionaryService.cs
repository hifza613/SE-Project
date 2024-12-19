using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class DictionaryService
{
    
    private static readonly HttpClient client = new HttpClient();
    private const string apiUrl = "https://api.dictionaryapi.dev/api/v2/entries/en/";
    public static async Task<string> GetWordDefinitionAsync(string word)
    {
        try
        {
            var url = $"{apiUrl}{word.ToLower()}";  
            var response = await client.GetStringAsync(url);

           
            var jsonObject = JArray.Parse(response); 

            if (jsonObject.Count > 0)
            {
                var meanings = jsonObject[0]["meanings"];
                if (meanings != null && meanings.HasValues)
                {
                    
                    foreach (var meaning in meanings)
                    {
                        var wordDefinitions = meaning["definitions"];
                        if (wordDefinitions != null && wordDefinitions.HasValues)
                        {
                            return wordDefinitions[0]["definition"].ToString();
                        }
                    }
                }
            }

            return "No definition found.";
        }
        catch (JsonException jsonEx)
        {
            return $"Error parsing definition: {jsonEx.Message}";
        }
        catch (Exception ex)
        {
           
            return $"Error fetching definition: {ex.Message}";
        }
    }
}
