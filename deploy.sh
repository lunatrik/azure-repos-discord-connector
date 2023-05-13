#!/bin/bash

export NODE_ID=$(docker info -f '{{.Swarm.NodeID}}')
docker node update --label-add traefik-public.traefik-public-certificates=true $NODE_ID

source .env

export HOST=$HOST
export ASPNETCORE_ENVIRONMENT=$ASPNETCORE_ENVIRONMENT
export DISCORD_WEBHOOK=$DISCORD_WEBHOOK
export BASICAUTH_USERNAME=$BASICAUTH_USERNAME
export BASICAUTH_PASSWORD=$BASICAUTH_PASSWORD

docker stack deploy -c stack.yml ard_connector