param (
    [string] $serverInstance = "",
    [string] $databaseName = ""
)

# Define your database connection parameters
$connectionString = "Server=$serverInstance;Database=$databaseName;Integrated Security=True"

# Define the SQL INSERT statement to insert dummy data
$sqlQuery = @"
INSERT INTO InvestorCategories

(Category ,InvestorId ,ExpiresAt ,ModifiedBy)
VALUES
(4, 3, N'2025-04-10 04:12:00.0000000', 2),
(0, 4, N'2025-04-10 04:12:00.0000000', 2)
"@

# Execute the SQL INSERT statement using Invoke-Sqlcmd
Invoke-Sqlcmd -ServerInstance $serverInstance -Database $databaseName -Query $sqlQuery