docker rm -f ServiceTemplate
docker build . -t service-template && ^
docker run -d --name ServiceTemplate -p 2500:80 ^
-e ASPNETCORE_ENVIRONMENT=DockerDev ^
-it service-template
echo finish service-template
pause
