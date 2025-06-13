# Web UI Automation Test Suite

This project is a Web UI automation test suite built using **Selenium** and **XUnit** for comprehensive regression testing of a web application. The tests are designed to run in a specific sequence to maintain the flow of operations and include retry logic to handle intermittent failures, such as slow internet or delayed element loading.

## Project Overview

The test suite automates the entire web regression flow, ensuring that critical user journeys and functionalities are validated. Key features include:
- **Ordered Test Execution**: Tests are executed in a predefined sequence using `Xunit.Extensions.Ordering` with `[Order(N)]` attributes to maintain dependencies between test steps.
- **Retry Logic**: Failed tests are automatically retried up to a configurable number of times using `xRetry` to handle transient issues.
- **Page Object Model (POM)**: The project follows the POM design pattern for better code organization, readability, and maintainability.
- **Modular Configuration**: Configurations such as application URL, credentials, and asset paths are centralized for easy management.
- **Inheritance Hierarchy**: The codebase uses inheritance for structured access to configurations, locators, and utility functions.
- **Dynamic XPATHS**: The test suite uses Dynamic XPath locators for each web element to ensure the UI changes does not affect the tests.

## Project Structure

The project is organized into the following key directories and files:

- **`Assets/`**: Contains sample files (e.g., `primary.png`, `secondary.png`, `SampleDoc.docx`, `SamplePdf.pdf`, `SampleVideo.mp4`) used in test scenarios requiring file uploads.
- **`Bin/`**: Holds compiled binaries.
- **`Configuration/`**: Contains configuration files for the test environment:
  - `AssemblyInfo.cs`: Disables test parallelization and enables test ordering with XUnit attributes.
  - `Configurations.Basic.cs`: Defines constants for the application URL, uniqueness variable (to avoid duplicate entries), login credentials, and paths to asset files.
  - `Configurations.DriverSetup.cs`: Configures the Selenium WebDriver with options for headless execution, retry mechanisms, and wait timeouts.
  - Module-specific configuration files (e.g., for Company, News, Offers): Contain data for input fields specific to each module.
- **`Drivers/`**: Contains WebDriver executables (e.g., `geckodriver`), though this can be skipped if using WebDriverManager.
- **`Obj/`**: Contains object files and package references, including NuGet package targets.
- **`Tests/`**: Contains the test code:
  - `Base.cs`: Provides reusable Selenium interaction functions (e.g., `AddDataToField`, `ClickOnButton`) to simplify test scripts.
  - `ElementLocators/`**: Holds classes with XPaths for web elements, organized by module (e.g., `Locators.cs`).
  - Module-specific folders (e.g., `NewsCompose/`): Each contains:
    - `.Tests.cs`: XUnit test classes with ordered tests and retry logic (e.g., `NewsCompose.Tests.cs`).
    - `.Base.cs`: Utility functions for the module, following the Page Object Model (e.g., `NewsCompose.Base.cs`).
- **`SquarebookAutomation.csproj`**: The project file listing all NuGet package dependencies.
- **`SquarebookAutomation.sln`**: The solution file for Visual Studio.
- **`xunit.runner.json`**: Configures XUnit to disable parallel execution of tests to maintain the sequence of operations.

## Folders Map

```
SquarebookAutomation/
├── Assets/                # Sample media files for upload tests (images, docs, videos)
├── Configuration/         # Test settings, driver setup, credentials, data constants
├── Drivers/               # Browser driver binaries (e.g., geckodriver)
├── Tests/                 # Test projects organized by module
│   ├── ElementLocators/   # XPath locators for UI elements
│   ├── Base.cs            # Global Selenium wrapper utilities
│   ├── <Module>.Base.cs   # Module-specific helper methods
│   └── <Module>.Tests.cs  # xUnit tests with ordering and retry logic
├── obj/                   # Build artifacts (auto-generated)
├── bin/                   # Compiled binaries
├── SquarebookAutomation.csproj          # NuGet package references & asset copy settings
├── SquarebookAutomation.csproj.nuget.g.targets  # Imported build targets for packages
├── SquarebookAutomation.sln              # Visual Studio solution file
└── xunit.runner.json     # xUnit runner configuration (disable parallelization)
```

## Setup Instructions

1. **Clone the Repository**: 
   ```bash
   git clone <repository-url>
   ```
2. **Open the Solution**:
   - Open `SquarebookAutomation.sln` in Visual Studio.
3. **Restore NuGet Packages**:
   - Right-click the solution in Visual Studio and select "Restore NuGet Packages" to ensure all dependencies are installed.
4. **Configure Test Settings**:
   - Update the `Configurations.Basic.cs` file with the necessary values:
     - `AppURL`: The URL of the web application under test (replace `YOUR_WEBAPP_URL`).
     - `USER_NAME` and `PASSWORD`: Credentials for logging into the application (replace `YOUR_USERNAME_HERE` and `YOUR_PASSWORD_HERE`).
   - Ensure that the asset files in the `Assets/` folder are present and correctly referenced in the configuration.
5. **Optional Configurations**:
   - Set `IS_HEADLESS` in `Configurations.DriverSetup.cs` to `true` if you want to run the tests in headless mode.
   - Adjust `FAIL_TEST_RETRIES` (default is 3) to control how many times a failed test should be retried.

## Running the Tests

To run the tests, you can use either Visual Studio's Test Explorer or the command line.

- **Using Visual Studio**:
  1. Open the **Test Explorer** (Test > Test Explorer).
  2. Click **Run All** to execute the entire test suite.
  
- **Using Command Line**:
  1. Navigate to the project directory.
  2. Run the following command:
     ```bash
     dotnet test
     ```

The tests are set to run in a specific order as defined by the `[Order(N)]` attributes, ensuring that dependent actions are performed in the correct sequence. Failed tests will be automatically retried up to the number specified in `FAIL_TEST_RETRIES`.

## Test Suite Features 

- **Test Ordering**: The tests are ordered using `Xunit.Extensions.Ordering` to maintain the sequence of operations. This is crucial for scenarios where one test depends on the outcome of another.
- **Retry Mechanism**: The project uses `xRetry` with `[RetryFact(FAIL_TEST_RETRIES)]` to retry failed tests, helping to mitigate intermittent failures due to network issues or slow element loading.
- **Page Object Model (POM)**: Each module (e.g., News, Offers) has its own test and base classes, promoting code reuse and making the test suite easier to maintain.
- **Inheritance Hierarchy**: The project uses inheritance and statuc funtions to organize configurations, locators, and utility functions, following this hierarchy:  

    ```
    Configurations → Locators → Base → <Module>.Base → <Module>.Tests
    ```
- **Uniqueness Variable**: A uniqueness variable based on the current timestamp (`Uniqueness`) is used to avoid "record already exists" errors when creating entities with unique names.
- **Dynamic XPATHS**: The project leverages the dynamic XPATHS for each web module/page, written with precision to have the UI elements not affected due to frequent UI changes.

This structure ensures that the test suite is easily human readable, modular, maintainable, and robust against common automation challenges.