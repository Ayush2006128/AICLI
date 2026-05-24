<p align="center">
  <img src="AICLI/Assets/Icon.png" width="128" height="128" alt="AICLI Icon">
</p>

<h1 align="center">AICLI 🚀</h1>

<p align="center">
  <img src="https://img.shields.io/github/v/release/Ayush/AICLI?style=for-the-badge&color=blue" alt="Release">
  <img src="https://img.shields.io/github/license/Ayush/AICLI?style=for-the-badge&color=green" alt="License">
  <img src="https://img.shields.io/badge/.NET-10.0-purple?style=for-the-badge&logo=dotnet" alt=".NET Version">
</p>

---

### ✨ Why AICLI?

PowerShell is the silent architect of the Windows realm—a language of immense power that often remains a mystery to those who use it most. For students and terminal dwellers, it is the magic wand we wield without a manual. 🪄

We live in the terminal, yet we often find ourselves wandering away to find that one elusive command. **AICLI** was born from this frustration. It is the whisper of wisdom in your shell, a bridge between intent and execution. It allows you to summon complex PowerShell commands using natural language, ensuring your creative flow remains unbroken. No more context switching; just pure, unadulterated productivity. ⚡

---

### 🛠️ Usage

Getting the command you need is as simple as asking. Use the `ai` command followed by your prompt in quotes:

```powershell
ai "how to list all files larger than 100MB in the current directory"
```

**AICLI** will talk to the Gemini API and return only the valid PowerShell command, ready for you to copy and run! 📄✨

---

### 📥 Installation

1. Go to the [GitHub Releases](https://github.com/Ayush/AICLI/releases) page.
2. Download the latest `ai.exe` binary.
3. Move `ai.exe` to a folder that is in your system's `PATH` (e.g., `C:\Windows\System32` or a custom scripts folder).

---

### ⚙️ Setup

To use **AICLI**, you need a Gemini API Key. 🔑

1. Get your API key from the [Google AI Studio](https://aistudio.google.com/).
2. Add it to your environment variables:

**Temporary (Current Session):**
```powershell
$env:GEMINI_API_KEY = "your_api_key_here"
```

**Permanent (User Profile):**
1. Search for "Edit the system environment variables" in Windows.
2. Click **Environment Variables**.
3. Under **User variables**, click **New**.
4. Variable name: `GEMINI_API_KEY`, Variable value: `your_api_key_here`.

---

### 📜 License

This project is licensed under the [MIT License](LICENSE.txt). Feel free to use, modify, and distribute it! 🤝

---

<p align="center">
  Made with ❤️ by <b>Ayush</b> for the Windows Community 🪟✨
</p>
