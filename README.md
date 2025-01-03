# game
Introduction

## How to Run the MonoGame Application

### Dependencies

- MonoGame Framework
- .NET Core SDK

### Installation Steps

1. Install the MonoGame Framework from the official website: https://www.monogame.net/downloads/
2. Install the .NET Core SDK from the official website: https://dotnet.microsoft.com/download

### Running the Application

1. Clone the repository:
   ```
   git clone https://github.com/warren-burke84/game.git
   ```
2. Navigate to the project directory:
   ```
   cd game
   ```
3. Build the project:
   ```
   dotnet build
   ```
4. Run the application:
   ```
   dotnet run
   ```

## Automated Build and Package Process using GitHub Actions

This repository includes a GitHub Actions workflow to automate the build and package process for the game. The workflow is defined in the `.github/workflows/build.yml` file.

### Workflow Steps

1. Set up .NET Core
2. Restore dependencies
3. Build the project
4. Package the game
