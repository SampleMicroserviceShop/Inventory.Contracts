# Inventory.Contracts
Contracts supported by the Inventory microservice.

## General Variables
```powershell
$contracts_version="1.0.2"
$owner="SampleMicroserviceShop"
$gh_pat="[PAT HERE]"
$appname="microshop"
```

## Create and publish package
```powershell
dotnet pack --configuration Release -p:PackageVersion=$version -o ..\..\packages\$owner
```

 ## Add the GitHub package source
```powershell
dotnet nuget add source --username USERNAME --password $gh_pat --store-password-in-clear-text --name github https://nuget.pkg.github.com/$owner/index.json
```

 ## Push Contracts Package to GitHub
 ```powershell
dotnet nuget push ..\..\packages\$owner\Inventory.Contracts.$contracts_version.nupkg --api-key $gh_pat --source "github"
```

## Required repository secrets for GitHub workflow
Repository Settings --> Secret and variables --> Actions --> New Repository Secret
NuGetPackagePush : Created in GitHub user profile --> Settings --> Developer settings --> Personal access token
