# Weather

Small app to play around with fullstack development. To get it up and running quickly after cloning:
```
$ cd src
$ docker-compose up
```

Once it is up and running, you should see similar output when you run
```
$ docker ps -a
CONTAINER ID        IMAGE               COMMAND                  CREATED             STATUS              PORTS                    NAMES
11daa577811b        src_web             "docker-entrypoint.s…"   10 hours ago        Up 5 seconds        0.0.0.0:5000->5000/tcp   weather_portal
42482e238134        src_api             "dotnet Weather.dll"     10 hours ago        Up 5 seconds        0.0.0.0:5001->5001/tcp   weather_api
e33d6f8dca29        postgres:13.2       "docker-entrypoint.s…"   10 hours ago        Up 5 seconds        0.0.0.0:5432->5432/tcp   weather_postgres
```

## Frontend:
- React (generated with CRA)
- Typescript

### Frontend goals:
- Learn React more in depth and set up a small site to query/look at weather from various areas
- Write good, clean components
- Have styling with dark mode awareness

## Backend:
- ASP.NET Core 5 (will migrate to 6 eventually as part of learning migrations..)

### Backend goals:
- Leverage EF w/ Npgsql
- SOLID principles

## Data tier:
- PostgreSQL 13.2 (will migrate to 14 eventually as part of learning that as well..)

### Data tier goals:
- Learn good indexing strategies, even if only for a few thousand rows
- Learn replication and setup failover with `pg_auto_failover`
