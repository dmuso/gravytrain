# Gravy Train

An easy way to get a lightweight API microservice started with .NET Core and Nancy running in Docker.

### Project objectives

* An easy starting point for a backend API microservice
* Cross platform (Mac OS, Linux and Windows)
* To be as lightweight as possible
* Builds and tests can run from the command line
* No IDE (Visual Studio) required

### Requirements

* Docker
* Docker Compose

### Build/test instructions

This project utilises a multi-stage Dockerfile for building, running tests and running a release build as a web server.

Building and running unit tests can be done via Docker Compose:

		$ docker-compose run test

To run the service:

		$ docker-compose up web

Verify everything is working:

		$ curl localhost:8080

By default, this will run the server on port 8080, but is customisable via the `docker-compose.yml` file.
