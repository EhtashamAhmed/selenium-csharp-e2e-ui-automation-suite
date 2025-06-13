param (
    [string] $serverInstance = "",
    [string] $databaseName = ""
)

# Define your database connection parameters
$connectionString = "Server=$serverInstance;Database=$databaseName;Integrated Security=True"

# Define the SQL INSERT statement to insert dummy data
$sqlQuery = @"
INSERT INTO Organization

(OrganizationTypeID, Name, Description, ModifiedBy, IsDeactivated, IsDeleted, HasComplianceUser, EnableMatchMaking)
VALUES
(2, N'Institutional Investor',  N'Institutional Investor Organisation Description', 2, 0, 0, 0, 0),
(5, N'Private Investor',  N'Private Investor Organisation Description', 2, 0, 0, 0, 0),
(1, N'Administrator',  N'Administrator Organisation Description', 2, 0, 0, 0, 0),
(3, N'Issuer',  N'Issuer Organisation Description', 2, 0, 0, 0, 0),
(4, N'Advisor',  N'Advisor Organisation Description', 2, 0, 0, 0, 0),
(6, N'Advocate',  N'Advocate Organisation Description', 2, 0, 0, 0, 0)
"@

# Execute the SQL INSERT statement using Invoke-Sqlcmd
Invoke-Sqlcmd -ServerInstance $serverInstance -Database $databaseName -Query $sqlQuery