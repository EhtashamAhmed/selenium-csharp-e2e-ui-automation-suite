
param (
    [string] $serverInstance = "",
    [string] $databaseName = ""
)
# Define the list of script names in the desired execution order
$scriptOrder = @(
    "NewsItem.ps1",
    "Organization.ps1",
    "InvestorProfile.ps1",
    "AdvisorProfile.ps1",
    "CustomerDueDiligence.ps1",
    "User.ps1",
    "UserUserRole.ps1"
)

# Define the path to the folder containing your scripts
$folderPath = "DataSeeding/"

# Get a list of all .ps1 files in the folder and its subfolders
$scriptFiles = Get-ChildItem -Path $folderPath -Filter *.ps1 -File -Recurse

# Loop through and execute the scripts in the desired order
foreach ($scriptName in $scriptOrder) {
    $scriptPath = Join-Path -Path $folderPath -ChildPath $scriptName
    Write-Host "Running script: $scriptName"

    $scriptFile = $scriptFiles | Where-Object { $_.Name -eq $scriptName }

    if ($scriptFile -ne $null) {
        & $scriptPath -serverInstance $serverInstance -databaseName $databaseName
        Write-Host "Script $scriptName completed."
    } else {
        Write-Host "Script $scriptName not found."
    }
}
