# Description

A simple example of web services running in a Docker swarm.

## Building
Run these commands in a command prompt to build the docker image

    cd WebService
    dotnet publish -c Release
    cd..
    docker build -t web-service .

## Running

Run the container with docker-compose using this command

    docker-compose up

Terminate the stack with CTRL-C and then clean up with

    docker-compose down

## Using

Open this URL in a browser to call the web service

http://localhost/api

Swagger endpoint: http://localhost/swagger

A GET request will return host info in JSON format like this example

    {
      "time": "2021-02-20T22:00:48.2844811+00:00",
      "hostname": "f3e76ac40326",
      "ipAddress": "172.19.0.2",
      "tickCount": 309557324
    }

The number of replicas of the web service is specified in **docker-compose.yml**.
