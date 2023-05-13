# Azure DevOps to Discord Connector

## Overview

This is a .NET 6.0 application that listens for POST requests from Azure DevOps with information about pushes to a repository. It then formats the data into a Discord-friendly format and sends it to a Discord webhook. 

## Setup

### 1. Clone the Repository

Clone this repository to your local machine.

### 2. Configure Azure DevOps

Set up a service hook in Azure DevOps that sends a POST request to the endpoint `/code_pushed` on your server whenever a push event occurs in your desired repository.

### 3. Configure Discord

Create a new webhook in the desired Discord channel. Copy the webhook URL.

### 4. Update .env file

Copy .env.local to new .env file and update the following variables:

```env
Discord_Webhook=your_discord_webhook
BasicAuth__Username=your_username
BasicAuth__Password=your_password
ASPNETCORE_ENVIRONMENT=Production
Traefik_Host=your_host
```

### 5. Docker Compose

Run the application with Docker Compose:

```bash
docker-compose up
```

## Files

The main files in the application are:

- `Program.cs`: The main entry point for the application.
- `DiscordMessage.cs`: Defines the structure of a message that can be sent to Discord.
- `BasicAuthenticationHandler.cs`: A custom authentication handler for Basic Authentication.
- `appsettings.json`: The application configuration file.
- `AzureMessageToDiscordWebhook.cs`: Defines the mapping between the AzureMessage model and the DiscordMessage model.
- `CodePushed.cs`: Defines the structure of the AzureMessage model.

## Docker

A `Dockerfile` is included for building a Docker image of the application. A `docker-compose.yml` file is also included for running the application with Docker Compose.

## Environment Variables

The application uses the following environment variables:

- `Discord_Webhook`: The URL of your Discord webhook.
- `BasicAuth__Username`: The username for Basic Authentication.
- `BasicAuth__Password`: The password for Basic Authentication.
- `ASPNETCORE_ENVIRONMENT`: The environment the application is running in. Should be `Production` for a production environment.
- `Traefik_Host`: The host that Traefik will use to expose your application.

## License

This project is licensed under the terms of the MIT license.