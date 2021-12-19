# Docker Compose RabbitMQ
```yaml
version: '3'
services:
  rabbitmq:
    image: "rabbitmq:3-management"
    hostname: "rabbit1"
    ports:
      - "15672:15672"
      - "5672:5672"
    labels:
      NAME: "some-rabbit"
  sqlserver:
    image: "mcr.microsoft.com/mssql/server:2017-latest"
    environment:
      ACCEPT_EULA: "Y"
      SA_PASSWORD: "paa55w0rd!"
      MSSQL_PID: "Express"
    ports:
      - "1433:1433"
```

In terminal, move to the folder where the yaml file is contained, and use `docker-compose up -d`. There will be two services: an SqlServer bd and a RabbitMQ host.
