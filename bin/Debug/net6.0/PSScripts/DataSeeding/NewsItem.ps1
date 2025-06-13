param (
    [string] $serverInstance = "",
    [string] $databaseName = ""
)

# Define your database connection parameters
$connectionString = "Server=$serverInstance;Database=$databaseName;Integrated Security=True"

# Define the SQL INSERT statement to insert dummy data
$sqlQuery = @"
INSERT INTO NewsItem
(Name, Description, Summary, Icon, Link, IsPublished, IsDeleted, PublishedDate, ModifiedBy, Visibility)
VALUES
(N'DummyNamePS', N'DummyDescriptionPS', N'DummySummaryPS', N'DummyIconPS', N'DummyLinkPS', 1, 0, GETDATE(), 1, 0)
"@

# Execute the SQL INSERT statement using Invoke-Sqlcmd
Invoke-Sqlcmd -ServerInstance $serverInstance -Database $databaseName -Query $sqlQuery