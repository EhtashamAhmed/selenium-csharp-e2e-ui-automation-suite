param (
    [string] $serverInstance,
    [string] $databaseName
)
# Set the database to single-user mode and disconnect all active connections
Invoke-Sqlcmd -ServerInstance $serverInstance -Query "ALTER DATABASE [$databaseName] SET SINGLE_USER WITH ROLLBACK IMMEDIATE"

# Drop the database
Invoke-Sqlcmd -ServerInstance $serverInstance -Query "DROP DATABASE [$databaseName]"