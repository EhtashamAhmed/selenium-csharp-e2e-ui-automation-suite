## Will update database with migrations in nuget package folder.
# Set these values to target desired database 
param (
    [string] $serverInstance = "EHTASHAMAHMED",
    [string] $databaseName = "SAADDEMO",
    [bool] $runInPipelineMode =$false
)

$versionFile = join-path $PSScriptRoot ".\InstalledDbContextVersion.txt"
$version = Get-Content $versionFile
$packageFolder = $env:userprofile + "\.nuget\packages\SB.Auction.DbContext.EF6\" + $version  

$scriptPath = $packageFolder + "\tools\runmigrations.ps1"

$migrationScript=$packageFolder + "\Scripts\"

write-host "running migrations for version: $node.Version, in package folder : $packageFolder"
& $scriptPath -sqlServerInstance $serverInstance -databaseName $databaseName -packageFolder $migrationScript -runInPipelineMode $runInPipelineMode

write-host "complete!"
