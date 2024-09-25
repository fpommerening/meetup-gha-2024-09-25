FROM mcr.microsoft.com/dotnet/aspnet:8.0-bookworm-slim
EXPOSE 8080/TCP
WORKDIR /app/

COPY out ./

ENTRYPOINT ["./meetup-demo"]