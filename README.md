Number System Converter (GUI)

A lightweight Windows Forms desktop application written in C# that converts decimal numbers into binary and hexadecimal systems in real-time, featuring a graphical user interface (GUI).

## 🚀 Features
- Real-Time Conversion: Converts any valid decimal integer into both Binär (Base 2) and Hex (Base 16) formats instantly.
- Input Validation: Secure error-handling via `int.TryParse` to prevent system crashes from invalid or non-numeric inputs.
- Graphical User Interface (GUI): Clean and simple Windows Forms window built directly in code without external design dependencies.
- Hex Formatting: Automatically formats hexadecimal outputs with the standard `0x` prefix for standard IT notation.

## 🛠️ Technologies
- C# (Language Version 6.0+)
- .NET SDK 8.0 / 9.0 (Windows Forms component)
- Built-in assemblies: `System.Drawing`, `System.Windows.Forms`

## 📦 Installation & How to Run
1. Clone this repository to your local PC:
   git clone https://github.com/KristinaAlokhina/zahlensystem-konverter
   
2. Navigate to the project folder and launch the application directly using the .NET SDK:
   dotnet run

To build a single standalone `.exe` executable without extra DLL files, run:
dotnet publish -c Release -r win-x64 /p:PublishSingleFile=true /p:PublishReadyToRun=true --self-contained false
