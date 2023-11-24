using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapGet("/", () => "Hello World!");

app.Run();


public class WebhookController : Controller
{
    [HttpPost("/webhook")]
    public IActionResult HandleWebhook([FromBody] JObject data)
    {
        // Process the webhook data (add your processing logic here)
        System.Console.WriteLine("Webhook received: " + data);

        // You may want to store the data in a database or log file for tracking

        return Ok(new { status = "success" });
    }
}