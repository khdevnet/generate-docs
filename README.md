# Generate documentation for microservice
### Generate swagger documentation using Swagger CLI
```
swagger tofile --serializeasv2 --output .\pet.swagger.json PetStore.Api.dll v1
```

### Generate documentation from sln
```
docfx .\docfx.json
docfx --serve
```

### Get version of assembly
```
(Get-Command PetStore.Api.dll).FileVersionInfo.FileVersion
```
### Set version on build
```
dotnet build --configuration Release /p:Version=1.2.3-preview2-final
```

## Resources
[Doc fx](https://dotnet.github.io/docfx/index.html)
[dotnet version](https://andrewlock.net/version-vs-versionsuffix-vs-packageversion-what-do-they-all-mean/)
