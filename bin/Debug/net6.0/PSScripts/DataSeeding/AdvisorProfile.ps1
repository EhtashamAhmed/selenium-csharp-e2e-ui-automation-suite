param (
    [string] $serverInstance = "",
    [string] $databaseName = ""
)

# Define your database connection parameters
$connectionString = "Server=$serverInstance;Database=$databaseName;Integrated Security=True"

# Define the SQL INSERT statement to insert dummy data
$sqlQuery = @"
INSERT INTO AdvisorProfile

(Logo , Favicon, FooterIcon, StrapLine , AccentColorOne, AccentColorTwo, AccentColorThree, 
SecondaryColorOne, SecondaryColorTwo, SecondaryColorThree, IsDeleted, ModifiedBy, Status, OrganizationId)
VALUES
(N'/assets/media/logos/SBLogos/logoWebApp.svg', 
N'/assets/media/logos/SBLogos/logo-small.svg',  
N'/assets/media/logos/SBLogos/logo-small.svg',  
N'Branded Advisor Profile',  
N'#b4e5fa', N'#5487ff', N'#e88941',
N'#f2f3f9', N'#f2f3f9', N'#d4d5e9', 
0, 2, 2, 7)
"@

# Execute the SQL INSERT statement using Invoke-Sqlcmd
Invoke-Sqlcmd -ServerInstance $serverInstance -Database $databaseName -Query $sqlQuery