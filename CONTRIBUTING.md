# Contributing to AICLI 🚀

First off, thank you for considering contributing to **AICLI**! It's people like you who make this tool better for the entire Windows community.

By participating in this project, you agree to abide by our [Code of Conduct](CODE_OF_CONDUCT.md).

---

## 🗺️ How Can I Contribute?

### 🐛 Reporting Bugs
If you find a bug, please help us by opening an issue. Be sure to include:
- A clear, descriptive title.
- Steps to reproduce the issue.
- Expected vs. actual behavior.
- Your environment details (OS version, .NET version).

### ✨ Suggesting Enhancements
Have an idea to make AICLI better? We'd love to hear it! Open an issue with the "feature request" template and describe your vision.

### 🛠️ Pull Requests
1. **Fork** the repository and create your branch from `main`.
2. **Setup** your development environment (see below).
3. **Commit** your changes with clear, descriptive messages.
4. **Test** your changes thoroughly.
5. **Submit** a pull request! Ensure your PR description explains *what* you changed and *why*.

---

## 💻 Development Setup

### Prerequisites
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
- A [Gemini API Key](https://aistudio.google.com/)

### Local Setup
1. Fork and clone the repository:
   ```powershell
   git clone https://github.com/YourUsername/AICLI.git
   cd AICLI
   ```
2. Set up your API key for the session:
   ```powershell
   $env:GEMINI_API_KEY = "your_api_key_here"
   ```
3. Build the project:
   ```powershell
   dotnet build
   ```
4. Run the project locally:
   ```powershell
   dotnet run --project AICLI -- "how to list all files"
   ```

---

## 🎨 Coding Standards

- **Style:** Follow standard [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).
- **Naming:** Use `PascalCase` for classes and methods, `camelCase` for local variables and private fields.
- **Formatting:** Ensure your code is clean and readable. Use Visual Studio's "Format Document" (Ctrl+K, Ctrl+D) or `dotnet format`.
- **Logic:** Keep methods small and focused. AICLI aims to be lightweight and fast.

---

## 📜 Commit Messages

We appreciate clear and concise commit messages. A good format to follow is:
```text
[Tag] Short description (50 chars or less)

- Detailed bullet point if necessary
- Another point
```
Common Tags: `[Fix]`, `[Feature]`, `[Docs]`, `[Refactor]`, `[Style]`.

---

## 🤝 Need Help?

If you have questions or need guidance, feel free to reach out via GitHub Issues or start a discussion. We're happy to help!

Happy Coding! ✨
