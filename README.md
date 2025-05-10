# Prerequisites

1. After cloning the repository, run `abp install-libs` to install necessary client-side libraries.
2. Verify your database connection string in `appsettings.json` before running the application.

# Challenges Faced During Development

## 1. MudBlazor Installation and Configuration
- Spent significant time trying to properly install and configure MudBlazor components
- The UI framework integration issues had downstream effects on the solution
- Required multiple attempts to resolve dependency and styling conflicts

## 2. Namespace Conflicts
- Encountered namespace conflicts that consumed development time
- Resolution required careful analysis of using directives and assembly references
- Affected multiple files before being properly resolved
