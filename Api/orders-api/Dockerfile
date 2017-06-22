FROM microsoft/aspnetcore:1.1
WORKDIR /app
COPY published ./
ENV ASPNETCORE_URLS http://*:5000
ENTRYPOINT ["dotnet", "orders-api.dll"]