param (
    [string] $serverInstance = "",
    [string] $databaseName = ""
)

# Define your database connection parameters
$connectionString = "Server=$serverInstance;Database=$databaseName;Integrated Security=True"

# Define the SQL INSERT statement to insert dummy data
$sqlQuery = @"
INSERT INTO [User]
(FirstName, LastName, AccessSuccessCount, CreatedDateUtc, AccountDeactivated, CanCreateOffer, OrganizationId,
IsInstinetUser, EnableMatchmaking, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, 
PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount)
VALUES
(N'InstInvestorOne', N'DummyUser', 0, N'Nov 23 2023 10:24AM', 0, 0, 3,
0, 1, N'InstInvestorOne@gm.com', N'INSTINVESTORONE@GM.com', N'InstInvestorOne@gm.com', N'INSTINVESTORONE@GM.com', 1, 
N'AQAAAAEAACcQAAAAEIZI4V8M2pIO0gQW/vaaPNPrGQ0rpUyY2gpm5/S1puekt7d+diBmKlSMXaT1Oek2Ug==',
N'MBYIGDO4JO4OXH2FPS4YFAF7VFBONKBY', N'0fca7bdf-4aad-486d-ac5d-fd9ad6371fdd',
0, 0, 1, 0),

(N'PrivateInvestorOne', N'DummyUser', 0, N'Nov 23 2023 10:24AM', 0, 0, 4,
0, 1, N'PrivateInvestorOne@gm.com', N'PRIVATEINVESTORONE@GM.com', N'PrivateInvestorOne@gm.com', N'PRIVATEINVESTORONE@GM.com', 1, 
N'AQAAAAEAACcQAAAAEIZI4V8M2pIO0gQW/vaaPNPrGQ0rpUyY2gpm5/S1puekt7d+diBmKlSMXaT1Oek2Ug==',
N'MBYIGDO4JO4OXH2FPS4YFAF7VFBONKBY', N'0fca7bdf-4aad-486d-ac5d-fd9ad6371fdd',
0, 0, 1, 0),

(N'AdvisorOne', N'DummyUser', 0, N'Nov 23 2023 10:24AM', 0, 0, 7,
0, 1, N'AdvisorInvestorOne@gm.com', N'ADVISORINVESTORONE@GM.com', N'AdvisorInvestorOne@gm.com', N'ADVISORINVESTORONE@GM.com', 1, 
N'AQAAAAEAACcQAAAAEIZI4V8M2pIO0gQW/vaaPNPrGQ0rpUyY2gpm5/S1puekt7d+diBmKlSMXaT1Oek2Ug==',
N'MBYIGDO4JO4OXH2FPS4YFAF7VFBONKBY', N'0fca7bdf-4aad-486d-ac5d-fd9ad6371fdd',
0, 0, 1, 0),

(N'IssuerOne', N'DummyUser', 0, N'Nov 23 2023 10:24AM', 0, 0, 6,
0, 1, N'IssuerOne@gm.com', N'ISSUERONE@GM.com', N'IssuerOne@gm.com', N'ISSUERONE@GM.com', 1, 
N'AQAAAAEAACcQAAAAEIZI4V8M2pIO0gQW/vaaPNPrGQ0rpUyY2gpm5/S1puekt7d+diBmKlSMXaT1Oek2Ug==',
N'MBYIGDO4JO4OXH2FPS4YFAF7VFBONKBY', N'0fca7bdf-4aad-486d-ac5d-fd9ad6371fdd',
0, 0, 1, 0),

(N'AdvocateOne', N'DummyUser', 0, N'Nov 23 2023 10:24AM', 0, 0, 8,
0, 1, N'AdvocateOne@gm.com', N'ADVOCATEONE@GM.com', N'AdvocateOne@gm.com', N'ADVOCATEONE@GM.com', 1, 
N'AQAAAAEAACcQAAAAEIZI4V8M2pIO0gQW/vaaPNPrGQ0rpUyY2gpm5/S1puekt7d+diBmKlSMXaT1Oek2Ug==',
N'MBYIGDO4JO4OXH2FPS4YFAF7VFBONKBY', N'0fca7bdf-4aad-486d-ac5d-fd9ad6371fdd',
0, 0, 1, 0)
"@

# Execute the SQL INSERT statement using Invoke-Sqlcmd
Invoke-Sqlcmd -ServerInstance $serverInstance -Database $databaseName -Query $sqlQuery