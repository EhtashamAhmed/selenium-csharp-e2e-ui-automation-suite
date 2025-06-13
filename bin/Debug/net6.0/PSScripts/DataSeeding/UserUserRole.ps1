param (
    [string] $serverInstance = "",
    [string] $databaseName = ""
)

# Define your database connection parameters
$connectionString = "Server=$serverInstance;Database=$databaseName;Integrated Security=True"

# Define the SQL INSERT statement to insert dummy data
$sqlQuery = @"
INSERT INTO UserUserRole
(UserId, RoleId, ModifiedBy)
VALUES
(3, 2, 2),
(4, 2, 2),
(5, 3, 2),
(6, 6, 2),
(7, 7, 2)
"@

# Execute the SQL INSERT statement using Invoke-Sqlcmd
Invoke-Sqlcmd -ServerInstance $serverInstance -Database $databaseName -Query $sqlQuery