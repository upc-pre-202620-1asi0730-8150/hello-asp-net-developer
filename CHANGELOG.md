# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Changed
- Modernized `Developer` entity using C# primary constructor syntax.
- Modernized `PersonName` value object into a `readonly record struct` utilizing the C# 14 `field` contextual keyword in property accessors.

## [1.1.0] - 2026-08-20

### Added
- Unit test suite project `Acme.Hello.Platform.Tests` covering domain layer behavior (`PersonName` Value Object, `Developer` Entity, and `GreetingCounter` Domain Service).
- `PersonName` Value Object in domain model to encapsulate name behavior, validation, and trimming.
- `IGreetingCounter` domain service and `GreetingCounter` thread-safe singleton implementation for tracking greeting metrics.
- `GetGreetingCountResponse` resource record to represent greeting count in REST interface.
- `GreetingEndpoints` extension class in REST interface layer to modularize Minimal API route mappings.
- HTTP request specifications in `Acme.Hello.Platform.http` for greeting API endpoints.
- Summaries and parameter documentation for `GetGreetingCount` and `CreateGreeting` endpoints and responses.

### Changed
- Refactored `Developer` entity to encapsulate `PersonName` Value Object.
- Updated `DeveloperAssembler` to leverage `PersonName` for name validation and creation.
- Decoupled greeting count tracking from `Developer` entity and injected `IGreetingCounter` domain service in Minimal API endpoints.
- Simplified `GetGreetingCountResponse` resource record by decoupling it from domain entities.
- Refactored greeting endpoints with `/api/v1` version prefix and updated response handling.
- Modularized endpoint route registrations from `Program.cs` into `MapGreetingEndpoints` extension method.
- Cleaned up XML route comments in interface layer.
- Standardized namespace casing from `REST` to `Rest` and namespace from `Generic` to `Profiles`.
- Updated SDK rollForward policy, language version to C# 14, and package dependencies for .NET 10.
- Updated `docs/class-diagram.puml` with `Profiles` bounded context namespaces, `PersonName` Value Object, and `IGreetingCounter` service.
- Synchronized `docs/user-stories.md` and `README.md` with `/api/v1/greetings` endpoint signatures and greeting metrics behavior.

## [1.0.0] - 2026-08-19

### Added
- Initial release of the `hello-asp-net-developer` Minimal API application.
- `Developer` entity with greeting formatting and name validation.
- `GreetDeveloperRequest` and `GreetDeveloperResponse` REST resources and assemblers.
- `GET` and `POST` greeting endpoints.
- OpenAPI / Swagger documentation support.
- User stories and class diagram documentation.
