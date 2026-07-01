#  WhatsApp — Twilio + C#

Sending WhatsApp messages using the Twilio API and C# (.NET).

## Technologies

- C# / .NET
- [Twilio SDK for .NET](https://www.twilio.com/docs/libraries/csharp-dotnet)
- WhatsApp Business API (via Twilio Sandbox)

## ⚙️ How to run

### 1. Clone the repository

```bash
git clone https://github.com/seu-usuario/whatsapp-poc.git
cd whatsapp-poc
```

### 2. environment variables

Copy the example file and fill in your Twilio credentials:

```bash
cp .env.example .env
```

Edit the `.env` with your data:

```
TWILIO_ACCOUNT_SID=ACxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
TWILIO_AUTH_TOKEN=xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
TWILIO_WHATSAPP_FROM=whatsapp:+14155238886
```

> The credentials are available in the Twilio panel at **Account Dashboard**.

### 3. Activate Twilio Sandbox

To receive messages in the sandbox, the destination number needs to opt-in:

1. Go to the Twilio panel → **Messaging** → **Try it out** → **Send a WhatsApp message**
2. Note the keyword (ex: `join bright-dragon`)
3. Send this message to `+14155238886` on WhatsApp

### 4. Run the project

```bash
dotnet run
```

Enter the destination number in the format `+5517999999999` and the message will be sent.

## 📝 Notes

- This PoC uses the **Twilio sandbox**, ideal for development and testing
- In production, the sending number must be replaced by an official approved number
- Messages initiated by the company outside the 24h window require **approved templates**

## 🔗 Contexto

This project is part of the development of [Lumina Suite](private repository), a clinic management system. The objective is to validate the flow of sending messages via WhatsApp before integrating with the official Meta API.
