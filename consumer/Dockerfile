# build


FROM microsoft/dotnet:2.1-sdk as builder

WORKDIR /app

COPY ./*.csproj ./src/
COPY tests/*.csproj ./tests/

WORKDIR /app/src
COPY . .
RUN dotnet build

# test

FROM builder AS test
WORKDIR /app/tests
COPY tests/. .
RUN dotnet test

# publish

FROM builder AS publish
WORKDIR /app/src
RUN dotnet publish -c Release -o out

# web

FROM microsoft/dotnet:2.1-runtime AS web
COPY --from=publish /app/src/out /app
# ENTRYPOINT ["dotnet", "/app/consumer.dll"]
