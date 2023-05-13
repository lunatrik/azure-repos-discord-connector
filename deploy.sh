export NODE_ID=$(docker info -f '{{.Swarm.NodeID}}')
docker node update --label-add traefik-public.traefik-public-certificates=true $NODE_ID

source .env

export HOST=localhost.com
export ASPNETCORE_ENVIRONMENT=Production
export DISCORD_WEBHOOK=your_discord_webhook
export BASICAUTH_USERNAME=your_username
export BASICAUTH_PASSWORD=your_password

docker stack deploy -c stack.yml ard_connector