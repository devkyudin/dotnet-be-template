# TemplateApp be-app

## TemplateApp solution structure

- `src`
    - [TemplateApp.Presentation](#TemplateAppPresentation)
    - [TemplateApp.ExternalServices](#TemplateAppExternalServices)
    - [TemplateApp.Abstractions](#TemplateAppAbstractions)
    - [TemplateApp.Domain](#TemplateAppDomain)
    - [TemplateApp.DomainServices](#TemplateAppDomainServices)
    - [TemplateApp.GenericSubdomain](#TemplateAppGenericSubdomain)
    - [TemplateApp.Infrastructure](#TemplateAppInfrastructure)
    - [TemplateApp.Repository](#TemplateAppRepository)
- `tests`
    - [TemplateApp.IntegrationTests](#TemplateAppIntegrationTests)
    - [TemplateApp.Testing](#TemplateAppTesting)
    - [TemplateApp.UnitTests](#TemplateAppUnitTests)
- `common`
    - [.gitignore](#gitignore)
    - [Directory.Build.props](#DirectoryBuildprops)
    - [Directory.Packages.props](#DirectoryPackagesprops)
    - [infrastructure-services.yml](#infrastructure-servicesyml)
    - [infrastructure-tools.yml](#infrastructure-toolsyml)
    - [README.md](#READMEmd)
- `benchmarks`
    - [TemplateApp.Benchmarks](#TemplateAppBenchmarks)

### src

This folder contains a `TemplateApp` application. You can create an app without any benchmarks, infrastructure things,
tests (shame on you) and other helpful tools, but the main logic of service is contained in `src` folder.

`TemplateApp` implements Onion Architectural style, so it has many different projects to separate layers. Please, read
purposes of each project for better understanding what is happening before creating any PRs.

#### TemplateApp.Presentation

`Presentation` project contains all things to launch the application and to start serving external calls. Typically you
can find here:

- `Program.cs` file with the Main entrypoint of app, in which web-host is created, configured and started.
- `Startup.cs` file with app configuration (Controller mappings, DI-container configuration, Options bindings etc.)
- `appsettings.*ENVIRONMENT*.json` files with where you can configure app for each environment differently
- `Controllers` folder with Http/gRPC endpoint controllers
- `EventListeners` folder with Kafka topic / RabbitMq queue / other event bus listeners
- `Jobs` folder with Quartz.Net / Hangfire scheduled jobs

The main purpose of this layer is to separate API from core logic, so the only thing you allowed to do here is to catch
external requests/signals for converting them into DTOs and passing them to the DomainServices level.

#### TemplateApp.DomainServices

`DomainServices` project contains application's services and command/query handlers. In this layer you can instantiate
domain objects and interact with `Repository`/`ExternalServices` layers if you need.

#### TemplateApp.Domain

`Domain` project contains domain (core) objects of this application. You should create rich/anemic domain models of your
app right here.

#### TemplateApp.ExternalServices

#### TemplateApp.Abstractions

#### TemplateApp.GenericSubdomain

#### TemplateApp.Infrastructure

#### TemplateApp.Repository

### tests

#### TemplateApp.IntegrationTests

#### TemplateApp.Testing

#### TemplateApp.UnitTests

### common

#### .gitignore

#### Directory.Build.props

#### Directory.Packages.props

#### infrastructure-services.yml

#### infrastructure-tools.yml

#### README.md

### benchmarks

#### TemplateApp.Benchmarks
