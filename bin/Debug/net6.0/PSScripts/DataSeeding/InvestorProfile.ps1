param (
    [string] $serverInstance = "",
    [string] $databaseName = ""
)

# Define your database connection parameters
$connectionString = "Server=$serverInstance;Database=$databaseName;Integrated Security=True"

# Define the SQL INSERT statement to insert dummy data
$sqlQuery = @"
INSERT INTO InvestorProfile

(Logo ,Summary ,BackgroundImage ,IsDeleted ,Status ,ModifiedBy ,Scope ,OrganizationId)
VALUES
(N'/assets/media/logos/SBLogos/logoWebApp.svg', N'Inst Investor Profile Summary',  N'/assets/media/logos/SBLogos/whitebg.jpg',  0,  2,  2,  2,  3),
(N'/assets/media/logos/SBLogos/logoWebApp.svg', N'Pvt Investor ProfileSummary',  N'/assets/media/logos/SBLogos/whitebg.jpg',  0,  2,  2,  2,  4)
"@

# Execute the SQL INSERT statement using Invoke-Sqlcmd
Invoke-Sqlcmd -ServerInstance $serverInstance -Database $databaseName -Query $sqlQuery