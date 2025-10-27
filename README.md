# C# Main Method - All Valid Signatures

A comprehensive collection of all valid Main method signatures in C# with practical examples.

## 📚 Overview

The `Main` method is the entry point of any C# console application. This repository demonstrates all valid signatures and configurations supported by the C# language.

## 🎯 What's Included

### Basic Signatures

1. **VoidNoArgs** - `static void Main()`
   - Simplest form
   - No parameters, no return value
   - Default exit code: 0

2. **VoidWithArgs** - `static void Main(string[] args)`
   - Receives command-line arguments
   - No explicit return value
   - Default exit code: 0

3. **IntNoArgs** - `static int Main()`
   - Returns explicit exit code
   - No parameters
   - Useful for indicating success/failure

4. **IntWithArgs** - `static int Main(string[] args)`
   - Most complete synchronous signature
   - Receives arguments and returns exit code
   - Best for error handling scenarios

### Async Signatures (C# 7.1+)

5. **AsyncTaskNoArgs** - `static async Task Main()`
   - For async operations without return value
   - Enables await in Main

6. **AsyncTaskWithArgs** - `static async Task Main(string[] args)`
   - Async with command-line arguments
   - Most common async pattern

7. **AsyncTaskIntNoArgs** - `static async Task<int> Main()`
   - Async with exit code return
   - No arguments

8. **AsyncTaskIntWithArgs** - `static async Task<int> Main(string[] args)`
   - Most complete async signature
   - Arguments + exit code + async support

### Advanced Examples

9. **ParamsModifier** - Using `params` keyword
10. **CustomClassName** - Main in non-Program class
11. **PublicAccessModifier** - Public Main method
12. **MultipleMainMethods** - Multiple entry points with StartupObject
13. **TopLevelStatements** - Modern C# 9+ approach

## 🚀 How to Run

### Individual Examples

Navigate to any example folder and run:
```bash
cd 01-VoidNoArgs
dotnet run

### With Arguments

bash
cd 02-VoidWithArgs
dotnet run -- arg1 arg2 arg3

### Check Exit Code

**Windows (PowerShell):**
powershell
dotnet run
$LASTEXITCODE

**Linux/macOS:**
bash
dotnet run
echo $?

## 📋 Valid Signatures Summary

| Signature | Parameters | Return Type | Async | Since |
|-----------|------------|-------------|-------|-------|
| `static void Main()` | ❌ | void | ❌ | C# 1.0 |
| `static void Main(string[] args)` | ✅ | void | ❌ | C# 1.0 |
| `static int Main()` | ❌ | int | ❌ | C# 1.0 |
| `static int Main(string[] args)` | ✅ | int | ❌ | C# 1.0 |
| `static async Task Main()` | ❌ | Task | ✅ | C# 7.1 |
| `static async Task Main(string[] args)` | ✅ | Task | ✅ | C# 7.1 |
| `static async Task<int> Main()` | ❌ | Task<int> | ✅ | C# 7.1 |
| `static async Task<int> Main(string[] args)` | ✅ | Task<int> | ✅ | C# 7.1 |

## ❌ Invalid Signatures

### ❌ Non-Static
csharp
void Main() { }  // ERROR: Must be static

### ❌ Generic
csharp
static void Main<T>() { }  // ERROR: Cannot be generic

### ❌ Wrong Parameter Type
csharp
static void Main(int port) { }  // ERROR: Only string[] allowed

### ❌ In Struct
csharp
struct MyStruct {
static void Main() { }  // ERROR: Only classes allowed
}

### ❌ Wrong Return Type
csharp
static string Main() { }  // ERROR: Only void, int, Task, Task<int>

## 🔧 Requirements

- .NET 6.0 or later
- C# 9.0 or later (for Top-Level Statements)

## 📖 Exit Codes Convention

| Code | Meaning |
|------|---------|
| 0 | Success |
| 1 | General error |
| 2 | Invalid input |
| 3 | Invalid value/state |
| 99 | Unexpected error |

## 🎓 Key Concepts

### Why Must Main Be Static?

When a program starts, no objects exist yet. The runtime needs to call Main without creating an instance first. That's why it must be static.

### Why Only string[] for Parameters?

The operating system passes command-line arguments as strings. The runtime can't parse them into other types because it doesn't know what types you expect.

### Why Limited Return Types?

Return values must be compatible with OS exit codes:
- `void`: No exit code (defaults to 0)
- `int`: Explicit exit code for success/failure
- `Task` / `Task<int>`: Async versions of above

## 📚 Resources

- [Microsoft Docs: Main() and command-line arguments](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line)
- [Top-level statements](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements)
- [Async Main](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-7.1/async-main)

## 🤝 Contributing

Feel free to open issues or submit pull requests if you find any errors or have suggestions for improvements.

## 📝 License

MIT License - feel free to use these examples for learning and teaching purposes.

---

Made with ❤️ for C# learners


---

## 🎯 نکات مهم برای گیت‌هاب:

1. **فایل .gitignore** اضافه کنید:

```gitignore
## Ignore Visual Studio temporary files, build results, and
## files generated by popular Visual Studio add-ons.

# User-specific files
*.suo
*.user
*.userosscache
*.sln.docstates

# Build results
[Dd]ebug/
[Dd]ebugPublic/
[Rr]elease/
[Rr]eleases/
x64/
x86/
[Bb]in/
[Oo]bj/

# Visual Studio cache/options directory
.vs/

# .NET
project.lock.json
project.fragment.lock.json
artifacts/
