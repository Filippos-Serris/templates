# Clean Architecture Web API Template

A reusable ASP.NET Core Web API template based on Clean Architecture principles.

## Prerequisites

- .NET SDK installed
- Git installed

Verify your .NET installation:

```bash
dotnet --version
```

## Install Template Locally

Clone the template branch:

```bash
git clone --branch template/clean-architecture <repository-url>
```

Navigate to the template directory:

```bash
cd clean-architecture
```

Install the template:

```bash
dotnet new install .
```

Verify that the template is installed:

```bash
dotnet new list
```

You should see:

```
Clean Architecture Web API    clean-arch
```

## Create a New Project

Navigate to an empty directory:

```bash
mkdir MyProject
cd MyProject
```

Create a new project using the template:

```bash
dotnet new clean-arch -n MyCompany.Api
```

The template will replace the placeholder project name (`MyApp`) with the name provided:

```
MyCompany
```

## Build the Generated Project

Navigate into the generated project:

```bash
cd MyCompany
```

Restore dependencies and build:

```bash
dotnet build
```

## Uninstall Template

To remove the locally installed template:

```bash
dotnet new uninstall .
```

## Template Structure

```
CleanArchitecture.WebApi
│
├── .template.config
│   └── template.json
│
├── src
│   ├── MyApp.Api
│   ├── MyApp.Application
│   ├── MyApp.Domain
│   └── MyApp.Infrastructure
│
├── tests
│
└── MyApp.sln
```