# Zahlensystem-Konverter / Number System Converter

<p align="center">
  <a href="#-deutsch">Deutsch</a> • 
  <a href="#-english">English</a>
</p>

---

## 🇩🇪 Deutsch

### 🚀 Funktionen
* **Umfassende bidirektionale Konvertierung**: Wandelt Ganzzahlen aus einem beliebigen System (Dezimal, Binär, Oktal oder Hexadezimal) simultan in alle anderen drei IT-Zahlensysteme um.
* **Intelligente Eingabeauswahl**: Ein integriertes Dropdown-Menü (`ComboBox`) ermöglicht die flexible Festlegung des Eingabeformats.
* **Dynamische Tastatur-Validierung**: Verhindert Fehleingaben direkt beim Tippen (`KeyPress`-Validierung). Im Binärmodus werden z. B. nur `0` und `1` akzeptiert, im Hexadezimalmodus nur gültige Hex-Zeichen (`0-9`, `A-F`).
* **Schnelle Zwischenablage**: Integrierter Kopier-Button (📋) zur sofortigen Übernahme des generierten Binärcodes.
* **Komfortable Steuerung**: Unterstützt die `Enter`-Taste zur automatischen Auslösung der Konvertierung direkt aus dem Eingabefeld.
* **Ein-Klick-Zurücksetzung**: Ein dedizierter Löschen-Button setzt das Interface blitzschnell zurück und fokussiert das Eingabefeld neu.
* **Sicheres Parsing & Speicherbereinigung**: Robuste Fehlerbehandlung bei der Konvertierung sowie ordnungsgemäße Ressourcenfreigabe (`Dispose`), um Memory Leaks zu verhindern.

### 🛠️ Technologien
* .NET Framework / .NET Core (C#)
* Windows Forms (GUI)
* Verwendete Namespaces: `System`, `System.Drawing`, `System.Windows.Forms`

### 📂 Unterstützte Zahlensysteme
Die Anwendung strukturiert die Ergebnisse übersichtlich nach folgenden Systemen:
* **Dezimal (Base 10)**: Zeigt das Ergebnis im Zehnersystem (unterstützt auch negative Zahlen).
* **Binär (Base 2)**: Gibt den reinen Binärcode der Zahl aus.
* **Oktal (Base 8)**: Stellt die Zahl im klassischen achtbasierten System dar.
* **Hexadezimal (Base 16)**: Formatiert die Ausgabe in Großbuchstaben mit dem typischen `0x`-Präfix.

### 📦 Installation & Start
1. Repository klonen:
   ```bash
   git clone https://github.com/KristinaAlokhina/zahlensystem-konverter
   ```
2. Projekt in Visual Studio öffnen oder über die CLI kompilieren und ausführen:
   ```bash
   dotnet run
   ```

---

## 🇺🇸 English

### 🚀 Features
* **Comprehensive Bidirectional Conversion**: Converts integers from any chosen system (Decimal, Binary, Octal, or Hexadecimal) simultaneously into all other three IT numeral systems.
* **Smart Input Selection**: A built-in dropdown menu (`ComboBox`) allows flexible definition of the input format.
* **Dynamic Keyboard Validation**: Prevents invalid inputs on the fly via `KeyPress` filtering. For example, it restricts input to `0` and `1` in Binary mode, or valid hex characters (`0-9`, `A-F`) in Hexadecimal mode.
* **Quick Clipboard Copy**: Built-in copy button (📋) to instantly save the generated binary code to your clipboard.
* **Enhanced Usability**: Supports the `Enter` key to automatically trigger the conversion directly from the input text box.
* **One-Click Reset**: A dedicated Clear button instantly resets all input fields, clear labels, and restores focus to the input box.
* **Secure Parsing & Memory Management**: Robust error handling during conversion and proper resource disposal (`Dispose`) to prevent memory leaks.

### 🛠️ Technologies
* .NET Framework / .NET Core (C#)
* Windows Forms (GUI)
* Core Namespaces: `System`, `System.Drawing`, `System.Windows.Forms`

### 📂 Supported Numeral Systems
The application categorizes and formats the outputs based on the following bases:
* **Decimal (Base 10)**: Displays the number in base-10 notation (supports negative values).
* **Binary (Base 2)**: Outputs the exact binary stream of the number.
* **Octal (Base 8)**: Represents the number in the classic base-8 notation.
* **Hexadecimal (Base 16)**: Formats the output in uppercase with the standard `0x` prefix.

### 📦 Installation & Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/KristinaAlokhina/zahlensystem-konverter
   ```
2. Open the project in Visual Studio or compile and run via CLI:
   ```bash
   dotnet run
   ```
