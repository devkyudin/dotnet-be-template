# TemplateApp be-app

## TemplateApp solution structure

- `src`
    - [TemplateApp.ExternalServices](#TemplateAppExternalServices)
    - [TemplateApp.Abstractions`](#TemplateAppAbstractions)
    - [TemplateApp.Domain](#TemplateAppDomain)
    - [TemplateApp.DomainServices](#TemplateAppDomainServices)
    - [TemplateApp.GenericSubdomain](#TemplateAppGenericSubdomain)
    - [TemplateApp.Infrastructure](#TemplateAppInfrastructure)
    - [TemplateApp.Presentation](#TemplateAppPresentation)
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

#### TemplateApp.ExternalServices

#### TemplateApp.Abstractions

#### TemplateApp.Domain

#### TemplateApp.DomainServices

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
