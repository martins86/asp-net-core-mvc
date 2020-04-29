#!/bin/bash
echo 'Show all'
docker image ls
echo ''
docker container ls
echo ''
docker volume ls
echo ''
docker network ls
echo ''
echo ''
echo 'Stop all'
all=$(docker container ls -a -q)
docker container stop $all
echo ''
docker system prune --all --force --volumes