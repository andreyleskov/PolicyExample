# PolicyExample

**InsurTech Policy Domain Reference Architecture (.NET, DDD, GraphQL, REST & Embedded Scripting)**

[![.NET](https://img.shields.io/badge/.NET-ASP.NET%20Core-512BD4)](https://dotnet.microsoft.com/)
[![GraphQL](https://img.shields.io/badge/GraphQL-HotChocolate-E10098)](https://chillicream.com/docs/hotchocolate)

---

## Overview

`PolicyExample` is a multi-layered reference architecture for an **InsurTech Policy Management Engine** in C# / .NET. It compares rich **Domain-Driven Design (DDD)** aggregates against anemic domain models and exposes unified policy operations across **GraphQL**, **REST**, and **dynamic scripting** runtimes.

---

## Solution Architecture

| Project | Architectural Role |
| :--- | :--- |
| `PolicyExample.Domain` | Rich DDD domain model encapsulating insurance policy lifecycle, endorsements, and invariants |
| `PolicyExample.Anemic` | Comparative anemic domain model demonstrating trade-offs vs. rich tactical DDD |
| `PolicyExample.Abstractions` | Core aggregate addressing and domain contracts (`AggregateAddress`) |
| `PolicyExample.Scripting` | Dynamic rule and policy calculation scripting engine integration |
| `PolicyExample.API.GraphQL` | Schema-first & code-first GraphQL API server powered by HotChocolate (`cover-go-policyexample.graphql`) |
| `PolicyExample.GraphQL.Types` / `Client` | Strongly-typed GraphQL schema types and .NET GraphQL client |
| `PolicyExample.API.Rest` / `Controllers` | RESTful HTTP API endpoints with OpenAPI conventions |
| `PolicyExample.Infrastructure` | Persistence and cross-cutting infrastructure adapters |
| `PolicyExample.Tests` & `Tests.Integration` | Unit and full-stack integration test suites |

---

## Companion Contract Repositories

- [`andreyleskov/policyexample-api-spec`](https://github.com/andreyleskov/policyexample-api-spec) — OpenAPI v3 specification (`InsurancePolicy.v1.yaml`).
- [`andreyleskov/policy-example-graphql-contract`](https://github.com/andreyleskov/policy-example-graphql-contract) — GraphQL schema contract definition.
- [`andreyleskov/PolicyExampleAPIServer`](https://github.com/andreyleskov/PolicyExampleAPIServer) — Standalone ASP.NET Core Web API server host.

---

## Author

**[Andrey Leskov](https://github.com/andreyleskov)** — CTO & Principal Systems Architect ([illumi.one](https://illumi.one) · [LinkedIn](https://linkedin.com/in/andrey-leskov)).
