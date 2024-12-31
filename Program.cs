
using OpenAI_API;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var api=new OpenAIAPI("Your API Key");
var request = new OpenAI_API.Images.ImageGenerationRequest
{
    Prompt = "A cute kitten in a basket"
};

var response = api.ImageGenerations.CreateImageAsync(request).Result;
Console.WriteLine("Image URL: {0}", response.Data[0].Url);
