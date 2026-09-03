# Zahlensystem-Konverter / Number System Converter

<p align="center">
  <a href="#-deutsch">Deutsch</a> • 
  <a href="#-english">English</a>
</p>

---

## 🇩🇪 Deutsch

### 🚀 Funktionen
* **Umfassende bidirektionale Konvertierung**: Wandelt Ganzzahlen aus einem beliebigen System (Dezimal, Binär, Oktal oder Hexadezimal) simultan in alle anderen drei IT-Zahlensysteme um.
* **Intelligente Eingabeauswahl**: Ein integriertes Dropdown-Menü (`ComboBox`) ermöglicht die flexible Festlegung des Eingabeformats und setzt das Textfeld bei Systemwechsel automatisch zurück.
* **Dynamische Tastatur-Validierung**: Verhindert Fehleingaben direkt beim Tippen (`KeyPress`-Validierung). Im Binärmodus werden nur `0` und `1` akzeptiert, im Dezimalmodus das Minuszeichen ausschließlich an erster Position.
* **Fehlertolerantes Hex-Parsing**: Erkennt und verarbeitet hexadezimale Eingaben sowohl in Groß- als auch Kleinschreibung und entfernt das `0x`- oder `0X`-Präfix automatisch.
* **Schnelle Zwischenablage**: Integrierter Kopier-Button (📋) zur sofortigen Übernahme des generierten Binärcodes inklusive visueller Erfolgsmeldung.
* **Komfortable Steuerung**: Unterstützt die `Enter`-Taste (`AcceptButton`) zur automatischen Auslösung der Konvertierung direkt aus dem Eingabefeld.
* **Ein-Klick-Zurücksetzung**: Ein dedizierter Löschen-Button setzt das Interface blitzschnell zurück, leert den Zustandsspeicher und fokussiert das Eingabefeld neu.
* **Sicheres Parsing & Speicherbereinigung**: Robuste Fehlerbehandlung bei der Konvertierung sowie manuelle Freigabe aller GUI-Komponenten (`Dispose`), um Memory Leaks zu verhindern.

### 🛠️ Technologien
* .NET Framework / .NET Core (C#)
* Windows Forms (GUI)
* Verwendete Namespaces: `System`, `System.Drawing`, `System.Windows.Forms`

### 📂 Unterstützte Zahlensysteme
Die Anwendung strukturiert die Ergebnisse übersichtlich nach folgenden Systemen:
* **Dezimal (Base 10)**: Zeigt das Ergebnis im Zehnersystem (unterstützt negative Zahlen).
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
* **Smart Input Selection**: A built-in dropdown menu (`ComboBox`) allows flexible definition of the input format and automatically clears the input box upon changing the base.
* **Dynamic Keyboard Validation**: Prevents invalid inputs on the fly via `KeyPress` filtering. It restricts input to `0` and `1` in Binary mode and enforces the minus sign to the first position in Decimal mode.
* **Fault-Tolerant Hex Parsing**: Handles hexadecimal inputs case-insensitively and automatically strips out any user-entered `0x` or `0X` prefixes.
* **Quick Clipboard Copy**: Built-in copy button (📋) to instantly save the generated binary code to your clipboard with a visual confirmation popup.
* **Enhanced Usability**: Supports the `Enter` key (`AcceptButton`) to automatically trigger the conversion directly from the input text box.
* **One-Click Reset**: A dedicated Clear button instantly resets all fields, clears the state cache, and restores active focus to the input box.
* **Secure Parsing & Memory Management**: Robust error handling during conversion and manual UI component lifecycle control (`Dispose`) to prevent potential memory leaks.

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
