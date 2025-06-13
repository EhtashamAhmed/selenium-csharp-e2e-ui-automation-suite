param (
    [string] $serverInstance = "EHTASHAMAHMED",
    [string] $databaseName = "SAADDEMO"
)

# Define your database connection parameters
$connectionString = "Server=$serverInstance;Database=$databaseName;Integrated Security=True"

# Define the SQL INSERT statement to insert dummy data
$sqlQuery = @"
INSERT INTO Organization

(OrganizationTypeID,
Name,
Description,
ModifiedBy,
IsDeactivated,
IsDeleted,
HasComplianceUser,
ComplianceUserId,
EnableMatchMaking)
VALUES
(2,
N'DummyNAME', 
N'DummyDescription', 
1, 
0, 
0, 
0, 
NULL,
0)
"@

# Execute the SQL INSERT statement using Invoke-Sqlcmd
Invoke-Sqlcmd -ServerInstance $serverInstance -Database $databaseName -Query $sqlQuery