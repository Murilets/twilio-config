using Twilio;
using Twilio.Rest.Api.V2010.Account;

var accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
var authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
var fromNumber = Environment.GetEnvironmentVariable("TWILIO_WHATSAPP_FROM") ?? "whatsapp:+14155238886"; // deafult number sandbox Twilio

TwilioClient.Init(accountSid, authToken);

Console.Write("digite o numero de destino: ");
var tel = Console.ReadLine();

if (string.IsNullOrWhiteSpace(accountSid) || string.IsNullOrWhiteSpace(authToken))
{
    Console.WriteLine("Invalid environment variables");
    return;
}   

if (string.IsNullOrWhiteSpace(tel))
{
    Console.WriteLine("Invalid number");
    return;
}   

var message = MessageResource.Create(
    from: new Twilio.Types.PhoneNumber(fromNumber),
    to: new Twilio.Types.PhoneNumber($"whatsapp:{tel}"),
    body: "Olá está é uma mensagem de testes!"
);
Console.WriteLine($"Mensagem enviada! SID: {message.Sid}");
Console.WriteLine($"Status: {message.Status}");