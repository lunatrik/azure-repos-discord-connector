# Azure DevOps to Discord Webhook Connector

This project is a webhook that intercepts push notifications from Azure DevOps and sends them to a specific Discord channel.

## File Structure

This project contains the following files:

1. `Program.cs`: The main file that starts the application, configures services, and defines the HTTP request pipeline.

2. `DiscordMessage.cs`: Defines the model for Discord messages.

3. `BasicAuthenticationHandler.cs`: An authentication handler to secure the webhook.

4. `appsettings.json`: Contains the application's configuration settings.

5. `AzureMessageToDiscordWebhook.cs`: An AutoMapper profile that maps Azure messages to Discord messages.

6. `CodePushed.cs`: Contains the model definitions for Azure DevOps push notifications.

## How It Works

When Azure DevOps sends a push notification, the application receives that notification, maps it to a Discord message, and sends it to a specific Discord channel.

## Configuration

### Discord

1. Create a Discord server or choose an existing one to which you have the "Manage Webhooks" permission.

2. Select a channel where notifications will be sent, click the gear icon to open channel settings.

3. Go to the "Integrations" tab, click on "Webhooks", then "New Webhook".

4. Set up the webhook name, channel it will post to, and optionally upload an avatar.

5. Copy the webhook URL, you will need to insert it in the `appsettings.json` file.

### Azure DevOps

1. Go to the project settings in Azure DevOps.

2. Click on "Service Hooks" under "General".

3. Click on the "+" button to create a new subscription.

4. Choose "Web Hooks" as the service type and "Code pushed" as the trigger.

5. Set up the filters as needed, insert the webhook URL that your application is running on.

### Application

1. `appsettings.json`: You will need to configure the following values in `appsettings.json`:

   - `"Discord_Webhook": "YOUR_DISCORD_WEBHOOK"`: Replace `"YOUR_DISCORD_WEBHOOK"` with the webhook URL of your Discord channel.
   - `"BasicAuth": {"Username": "username", "Password": "password"}`: Replace `"username"` and `"password"` with your credentials to secure your webhook.

2. `BasicAuthenticationHandler.cs`: This file handles basic authentication. It compares the credentials received in the Authorization header with those in the configuration file.

3. `Program.cs`: This file configures and starts the application. If necessary, you can add additional middleware or services here.

4. `AzureMessageToDiscordWebhook.cs`: This file defines how to map an Azure message to a Discord message. If the format of the Azure message changes, you might need to update this file.

## Usage

Once you have configured Discord, Azure DevOps and the application, start it up and it will be ready to receive push notifications from Azure DevOps. When the application receives a notification, it converts the Azure message to a Discord message and sends it to the specified Discord channel.

## Notes

Ensure your Discord webhook and Azure DevOps webhook are secure. Never share your Discord webhook URL or your Azure DevOps webhook URL. If you think any of your webhooks may have been compromised, you can regenerate them from your respective channels.