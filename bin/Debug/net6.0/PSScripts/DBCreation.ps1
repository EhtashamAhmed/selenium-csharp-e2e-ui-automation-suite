param (
    [string] $serverInstance,
    [string] $databaseName
)

# Create a new database
Invoke-Sqlcmd -ServerInstance $serverInstance -Query "CREATE DATABASE $databaseName"