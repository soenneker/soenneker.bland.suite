[![](https://img.shields.io/nuget/v/soenneker.bland.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.bland.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.bland.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.bland.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.bland.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.bland.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.bland.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.bland.suite/actions/workflows/codeql.yml)

# Soenneker.Bland.Suite

A convenience package that references and registers the typed Bland.ai Calls utility.

## Installation

```bash
dotnet add package Soenneker.Bland.Suite
```

## Configuration

```json
{
  "Bland": {
    "ApiKey": "your-api-key"
  }
}
```

`Bland:ApiKey` is required. `Bland:EncryptedKey` is optional for accounts that require the additional encrypted-key header.

## Registration

```csharp
using Soenneker.Bland.Suite.Registrars;

services.AddBlandSuiteAsScoped();
```

This registers `IBlandCallUtil` as scoped and the underlying Bland HTTP client as singleton. `AddBlandSuiteAsSingleton()` registers the Calls utility as singleton as well.

## Usage

```csharp
using Soenneker.Bland.Calls.Abstract;
using Soenneker.Bland.Calls.Requests;
using Soenneker.Bland.Calls.Responses;

public sealed class AppointmentCaller
{
    private readonly IBlandCallUtil _calls;

    public AppointmentCaller(IBlandCallUtil calls)
    {
        _calls = calls;
    }

    public ValueTask<CreateCallResponse?> Call(string phoneNumber, CancellationToken cancellationToken = default)
    {
        return _calls.Create(
            new CreateCallRequest
            {
                PhoneNumber = phoneNumber,
                Task = "Confirm the customer's appointment."
            },
            cancellationToken);
    }
}
```

Creating a call can incur charges and contact a real person. Enforce consent, recipient validation, calling hours, recording requirements, and spend controls before invoking the API.

For the complete Calls API, filtering behavior, and stop operations, see [`Soenneker.Bland.Calls`](https://www.nuget.org/packages/Soenneker.Bland.Calls).
