# .Net-Microservices


-- Create a a docker container with a specific name, port and volume

docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo
