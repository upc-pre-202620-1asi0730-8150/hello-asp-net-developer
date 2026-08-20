# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added
- `PersonName` Value Object in domain model to encapsulate name behavior, validation, and trimming.

### Changed
- Refactored `Developer` entity to encapsulate `PersonName` Value Object.
- Updated `DeveloperAssembler` to leverage `PersonName` for name validation and creation.

## [1.1.0] - 2026-08-19

### Added
- `GetGreetingCountResponse` resource record to represent greeting count in REST interface.
- Static `GreetingCount` property and `IncrementGreetingCount` method in `Developer` entity.
- Summaries and parameter documentation for `GetGreetingCount` and `CreateGreeting` endpoints and responses.

### Changed
- Refactored greeting endpoints with `/api/v1` version prefix and updated response handling.
- Standardized namespace casing from `REST` to `Rest` and namespace from `Generic` to `Profiles`.
- Updated SDK rollForward policy, language version to C# 14, and package dependencies for .NET 10.

## [1.0.0] - 2026-08-19

### Added
- Initial release of the `hello-asp-net-developer` Minimal API application.
- `Developer` entity with greeting formatting and name validation.
- `GreetDeveloperRequest` and `GreetDeveloperResponse` REST resources and assemblers.
- `GET` and `POST` greeting endpoints.
- OpenAPI / Swagger documentation support.
- User stories and class diagram documentation.
