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

## Resources
[Doc fx](https://dotnet.github.io/docfx/index.html)