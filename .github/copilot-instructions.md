# Copilot instructions for this repository

## Project overview

This repository is a teaching-focused collection of small examples for software design and object-oriented principles. It is not a production application or a multi-project solution. The code is intentionally organized around standalone demos that illustrate a single concept at a time.

- `abstractions/`: examples of core OOP ideas such as abstraction, encapsulation, inheritance, polymorphism, composition, and state.
- `design principles/`: JavaScript snippets demonstrating DRY, KISS, YAGNI, cohesion, and coupling.
- `solid/`: C# examples mapping the SOLID principles and a small dependency injection demo under `solid/DependencyInjectionDemo/`.

The project is best understood as a set of educational examples rather than a shared application architecture.

## Build, test, and validation commands

There is no formal test suite, lint configuration, or package setup for the repo as a whole.

For the .NET demo project:

```bash
dotnet build "solid/DependencyInjectionDemo/DependencyInjectionDemo.csproj"
dotnet run --project "solid/DependencyInjectionDemo/DependencyInjectionDemo.csproj"
```

For a single JavaScript example, run the file directly with Node:

```bash
node "design principles/DRY.js"
node "design principles/KISS.js"
```

When working on a specific example, validate it by running the script or the demo project that owns that example rather than expecting a global suite.

## High-level architecture

The repository follows a very simple pattern: each folder groups examples around one theme, and each file is usually self-contained.

- `abstractions/` files are classic OOP demonstrations; they usually define a few classes and show how responsibilities, interfaces, or composition work in practice.
- `design principles/` files are minimal JavaScript samples that compare a "bad" implementation to a better design, often within the same file.
- `solid/` files are C# examples that mirror the SOLID principles one by one; they are not connected modules but independent teaching examples.
- `solid/DependencyInjectionDemo` is the only project-like entry point in the repo. It uses `Microsoft.Extensions.DependencyInjection` to register implementations of `ISaver<T>` and resolve `User` and `Sale` objects at runtime.

This means future work should preserve the "single concept per example" structure rather than introducing a shared app framework or abstraction layer that does not belong in the demo.

## Key conventions

- Most examples are intentionally small and explicit. Keep changes readable and easy to follow for someone studying the concept directly.
- Many files use paired examples such as "Sin Principio" vs "Con Principio", "Sin DRY" vs "Con DRY", or "without" vs "with" the principle being demonstrated. Preserve that comparison style when editing or adding examples.
- The repo frequently uses Spanish comments and naming for educational clarity. Keep the existing language and terminology when extending a file.
- Files are usually top-level scripts, not layered applications. Avoid introducing additional project structure, frameworks, or abstractions unless the example itself requires them.
- The dependency injection example is the template for any real executable entry point in the repo. If a new C# demo is added, it should follow the simple one-file, console-app pattern used there.

## Practical guidance for changes

- Prefer making the smallest possible edit to preserve the educational intent of the example.
- Keep code runnable as a standalone snippet or as a minimal console app.
- When adding a new example, follow the existing folder naming conventions and keep the file focused on one principle or concept.
- Do not introduce test infrastructure or package managers unless the repository already has a clear need for them.
