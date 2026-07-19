# Generics
## Why?
## Problems without Generics
Before Generics, if we wanted to perform the same operation on different data types, we had two main options:

- Create a separate method for each type, which led to duplicated code, poor maintainability, and reduced readability.
- Use `object`, which accepted any type but required casting and could introduce runtime errors.

Generics solved this problem by allowing us to write a single implementation that works with different types while preserving compile-time type safety.