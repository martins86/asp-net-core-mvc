#!/bin/bash
docker build -f "./MySqlDocker.Dockerfile" -t "mysql-docker" .

sh ./start_containers.sh
