Zahlensystem-Konverter (GUI)

Eine leichtgewichtige Windows-Forms-Desktopanwendung in C#, die eingegebene Dezimalzahlen in Echtzeit in das Binär- und Hexadezimalsystem umrechnet. Das Projekt verfügt über eine grafische Benutzeroberfläche (GUI) [INDEX].

🚀 Funktionen
- Echtzeit-Konvertierung: Wandelt jede gültige ganze Dezimalzahl sofort in das Binär- (Basis 2) und Hexadezimalformat (Basis 16) um.
- Eingabevalidierung: Sichere Fehlerbehandlung mittels `int.TryParse`, um Systemabstürze durch ungültige oder nicht-numerische Eingaben zu verhindern.
- Grafische Benutzeroberfläche (GUI): Sauberes und minimalistisches Windows-Forms-Fenster, das direkt im Code ohne externe Design-Abhängigkeiten erstellt wurde.
- Hex-Formatierung: Automatische Formatierung der Hexadezimal-Ausgabe mit dem IT-Standard-Präfix `0x` [INDEX].

🛠️ Technologien
- C# (Sprachversion 6.0+)
- .NET SDK 8.0 / 9.0 (Windows Forms Komponente)
- Integrierte Namespaces: `System.Drawing`, `System.Windows.Forms`

📦 Installation & Start
1. Klonen Sie dieses Repository auf Ihren lokalen PC:
   git clone https://github.com/KristinaAlokhina/zahlensystem-konverter

2. Navigieren Sie in den Projektordner und starten Sie die Anwendung direkt über das .NET SDK:
   dotnet run
   

Um eine einzelne, eigenständige `.exe`-Datei ohne zusätzliche DLL-Dateien zu erstellen, führen Sie folgenden Befehl aus:

dotnet publish -c Release -r win-x64 /p:PublishSingleFile=true /p:PublishReadyToRun=true --self-contained false