<p align="center">
  <ins><b><kbd>&nbsp;WINDOWS DESKTOP APPLICATION&nbsp;</kbd></b></ins>
</p>

<h1 align="center">🔢 IT NUMBER SYSTEM CONVERTER</h1>

<p align="center">
  <strong>Ein kompakter und intuitiver Zahlensystem-Konverter für IT-Anwendungen.</strong>
  <br />
  <i>Entwickelt mit C#, Windows Forms und .NET für die schnelle Umrechnung zwischen verschiedenen Zahlensystemen.</i>
</p>

<p align="center">
  <a href="#-deutsch">🇩🇪 Deutsch</a> •
  <a href="#-english">🇺🇸 English</a> •
  <a href="#-русский">🇷🇺 Русский</a> •
  <a href="#-українська">🇺🇦 Українська</a>
</p>

---

## 🇩🇪 Deutsch

### 📌 Über das Projekt

Der **IT Number System Converter** ist eine Windows-Desktopanwendung zur Umrechnung von Zahlen zwischen den vier wichtigsten Zahlensystemen der Informatik: Dezimal, Binär, Oktal und Hexadezimal.

Die Anwendung wurde mit C# und Windows Forms entwickelt und bietet eine einfache grafische Benutzeroberfläche zur Eingabe, Konvertierung und Anzeige der Ergebnisse.

### 🚀 Funktionen

- **Konvertierung zwischen Zahlensystemen 🔢**: Unterstützt Dezimal (Basis 10), Binär (Basis 2), Oktal (Basis 8) und Hexadezimal (Basis 16).
- **Mehrfachausgabe der Ergebnisse 📊**: Zeigt die umgerechnete Zahl gleichzeitig in allen vier Zahlensystemen an.
- **Intelligente Eingabevalidierung 🛡️**: Begrenzt die zulässigen Zeichen abhängig vom ausgewählten Zahlensystem.
- **Hexadezimal-Präfix-Unterstützung 🔤**: Akzeptiert bei der Eingabe optional das Präfix `0x`.
- **Binärcode in die Zwischenablage kopieren 📋**: Kopiert das berechnete Binärergebnis mit einem Klick.
- **Zurücksetzen der Eingabe 🧹**: Löscht die Eingabe und setzt die Ergebnisanzeige zurück.
- **Fehlerbehandlung ⚠️**: Erkennt ungültige Eingaben und Zahlen außerhalb des unterstützten `Int32`-Wertebereichs.
- **Kompaktes Windows-Interface 🖥️**: Fest dimensioniertes Fenster mit übersichtlicher Anordnung der Steuerelemente.

### 🛠️ Technologien

- **Programmiersprache**: C#
- **Framework**: .NET / Windows Forms
- **Benutzeroberfläche**: Windows Forms Controls
- **Zahlensystem-Konvertierung**: `System.Convert`
- **Zwischenablage**: `System.Windows.Forms.Clipboard`
- **GUI-Ereignisse**: Event Handling und Eingabevalidierung
- **Entwicklungsumgebung**: Visual Studio

### 📦 Installation & Ausführung

#### Option 1: Fertige Anwendung herunterladen

1. Öffne den Bereich **Releases** dieses GitHub-Repositories.
2. Lade die veröffentlichte ausführbare Datei herunter.
3. Starte die Anwendung unter Windows.

#### Option 2: Aus dem Quellcode erstellen

Voraussetzungen:
- Windows
- Ein passendes .NET SDK für das Projekt
- Git

1. Repository klonen:

   ```bash
   git clone https://github.com/KristinaAlokhina/NumerikKonverterGui.git
   ```

2. In das Projektverzeichnis wechseln:

   ```bash
   cd NumerikKonverterGui
   ```

3. Die Projektdatei öffnen und den Projektnamen bei Bedarf anpassen:

   ```bash
   dotnet build -c Release
   ```

> Hinweis: Der Repository-Link und der Projektordner müssen mit den tatsächlichen Namen deines GitHub-Repositories übereinstimmen. Für die Veröffentlichung als ausführbare Datei kann `dotnet publish` verwendet werden.

### 🎯 Projektziel

Dieses Projekt vertieft praktische Kenntnisse in C#, der Entwicklung grafischer Windows-Anwendungen, der Validierung von Benutzereingaben und der Umrechnung zwischen Zahlensystemen – grundlegende Themen der Informatik und Systemintegration.

---

## 🇺🇸 English

### 📌 About the Project

The **IT Number System Converter** is a Windows desktop application designed to convert numbers between four fundamental numeral systems used in computing: decimal, binary, octal, and hexadecimal.

Built with C# and Windows Forms, it provides a compact graphical interface for entering numbers, performing conversions, and viewing the results.

### 🚀 Features

- **Multi-Base Conversion 🔢**: Supports decimal (base 10), binary (base 2), octal (base 8), and hexadecimal (base 16).
- **Simultaneous Results 📊**: Displays the converted number in all four numeral systems at once.
- **Smart Input Validation 🛡️**: Restricts permitted characters according to the selected input base.
- **Hexadecimal Prefix Support 🔤**: Accepts the optional `0x` prefix for hexadecimal input.
- **Copy Binary Result 📋**: Copies the calculated binary representation to the Windows clipboard with one click.
- **Clear and Reset 🧹**: Clears the input and resets all displayed results.
- **Error Handling ⚠️**: Handles invalid input and numbers outside the supported `Int32` range.
- **Compact Windows Interface 🖥️**: Uses a fixed-size window with clearly arranged controls.

### 🛠️ Technologies

- **Programming Language**: C#
- **Framework**: .NET / Windows Forms
- **User Interface**: Windows Forms Controls
- **Numeral Conversion**: `System.Convert`
- **Clipboard Integration**: `System.Windows.Forms.Clipboard`
- **GUI Logic**: Event handling and input validation
- **IDE**: Visual Studio

### 📦 Installation & Setup

#### Option 1: Download the Application

1. Open the **Releases** section of this GitHub repository.
2. Download the published executable.
3. Run the application on Windows.

#### Option 2: Build from Source

Requirements:
- Windows
- A compatible .NET SDK for the project
- Git

1. Clone the repository:

   ```bash
   git clone https://github.com/KristinaAlokhina/NumerikKonverterGui.git
   ```

2. Navigate to the project directory:

   ```bash
   cd NumerikKonverterGui
   ```

3. Build the project in Release configuration:

   ```bash
   dotnet build -c Release
   ```

> Note: Make sure the repository URL and folder name match your actual GitHub repository. Use `dotnet publish` to create a distributable application.

### 🎯 Project Goal

This project strengthens practical skills in C#, Windows desktop application development, user input validation, and numeral system conversion – fundamental concepts in computer science and IT system integration.

---

## 🇷🇺 Русский

### 📌 О проекте

**IT Number System Converter** — это настольное приложение для Windows, предназначенное для перевода чисел между четырьмя основными системами счисления: десятичной, двоичной, восьмеричной и шестнадцатеричной.

Приложение разработано на C# с использованием Windows Forms и предоставляет компактный графический интерфейс для ввода чисел, выполнения конвертации и просмотра результатов.

### 🚀 Возможности

- **Перевод между системами счисления 🔢**: Поддерживаются десятичная (основание 10), двоичная (основание 2), восьмеричная (основание 8) и шестнадцатеричная (основание 16) системы.
- **Одновременное отображение результатов 📊**: Результат показывается сразу во всех четырёх системах счисления.
- **Проверка ввода 🛡️**: Допустимые символы зависят от выбранной системы счисления.
- **Поддержка префикса `0x` 🔤**: При вводе шестнадцатеричного числа можно использовать префикс `0x`.
- **Копирование двоичного результата 📋**: Двоичное представление можно скопировать в буфер обмена Windows одним нажатием.
- **Очистка данных 🧹**: Поле ввода и результаты можно сбросить.
- **Обработка ошибок ⚠️**: Приложение обрабатывает некорректный ввод и числа за пределами диапазона `Int32`.
- **Компактный интерфейс Windows 🖥️**: Небольшое окно фиксированного размера с понятным расположением элементов.

### 🛠️ Технологии

- **Язык программирования**: C#
- **Платформа**: .NET / Windows Forms
- **Графический интерфейс**: Элементы управления Windows Forms
- **Конвертация чисел**: `System.Convert`
- **Буфер обмена**: `System.Windows.Forms.Clipboard`
- **Обработка событий**: События интерфейса и проверка пользовательского ввода
- **Среда разработки**: Visual Studio

### 📦 Установка и запуск

#### Вариант 1: Скачать готовое приложение

1. Открой раздел **Releases** в этом GitHub-репозитории.
2. Скачай опубликованный исполняемый файл.
3. Запусти приложение в Windows.

#### Вариант 2: Собрать из исходного кода

Требования:
- Windows
- Совместимый с проектом .NET SDK
- Git

1. Клонируй репозиторий:

   ```bash
   git clone https://github.com/KristinaAlokhina/NumerikKonverterGui.git
   ```

2. Перейди в папку проекта:

   ```bash
   cd NumerikKonverterGui
   ```

3. Собери проект в конфигурации Release:

   ```bash
   dotnet build -c Release
   ```

> Примечание: Ссылка на репозиторий и имя папки должны совпадать с фактическими данными на GitHub. Для подготовки исполняемого приложения используй `dotnet publish`.

### 🎯 Цель проекта

Проект помогает развивать практические навыки программирования на C#, создания графических приложений для Windows, проверки пользовательского ввода и работы с системами счисления — важными темами информатики и системной интеграции.

---

## 🇺🇦 Українська

### 📌 Про проєкт

**IT Number System Converter** — це настільний застосунок для Windows, призначений для перетворення чисел між чотирма основними системами числення: десятковою, двійковою, вісімковою та шістнадцятковою.

Застосунок створено мовою C# із використанням Windows Forms. Він має компактний графічний інтерфейс для введення чисел, виконання перетворень і перегляду результатів.

### 🚀 Можливості

- **Перетворення між системами числення 🔢**: Підтримуються десяткова (основа 10), двійкова (основа 2), вісімкова (основа 8) та шістнадцяткова (основа 16) системи.
- **Одночасне відображення результатів 📊**: Результат відображається одразу в усіх чотирьох системах числення.
- **Перевірка введення 🛡️**: Дозволені символи залежать від обраної системи числення.
- **Підтримка префікса `0x` 🔤**: Для шістнадцяткового числа можна використовувати префікс `0x`.
- **Копіювання двійкового результату 📋**: Двійкове представлення можна скопіювати до буфера обміну Windows одним натисканням.
- **Очищення даних 🧹**: Поле введення та результати можна скинути.
- **Обробка помилок ⚠️**: Застосунок обробляє некоректне введення та числа поза межами діапазону `Int32`.
- **Компактний інтерфейс Windows 🖥️**: Невелике вікно фіксованого розміру зі зрозумілим розташуванням елементів.

### 🛠️ Технології

- **Мова програмування**: C#
- **Платформа**: .NET / Windows Forms
- **Графічний інтерфейс**: Елементи керування Windows Forms
- **Перетворення чисел**: `System.Convert`
- **Буфер обміну**: `System.Windows.Forms.Clipboard`
- **Обробка подій**: Події інтерфейсу та перевірка введення користувача
- **Середовище розробки**: Visual Studio

### 📦 Встановлення та запуск

#### Варіант 1: Завантажити готовий застосунок

1. Відкрий розділ **Releases** цього GitHub-репозиторію.
2. Завантаж опублікований виконуваний файл.
3. Запусти застосунок у Windows.

#### Варіант 2: Зібрати з вихідного коду

Вимоги:
- Windows
- Сумісний із проєктом .NET SDK
- Git

1. Клонуй репозиторій:

   ```bash
   git clone https://github.com/KristinaAlokhina/NumerikKonverterGui.git
   ```

2. Перейди до папки проєкту:

   ```bash
   cd NumerikKonverterGui
   ```

3. Збери проєкт у конфігурації Release:

   ```bash
   dotnet build -c Release
   ```

> Примітка: Посилання на репозиторій та назва папки мають відповідати фактичним даним на GitHub. Для підготовки виконуваного застосунку використовуй `dotnet publish`.

### 🎯 Мета проєкту

Проєкт допомагає розвивати практичні навички програмування на C#, створення графічних застосунків для Windows, перевірки введення користувача та роботи із системами числення — важливими темами інформатики й системної інтеграції.

---

<p align="center">
  <i>Developed as a personal learning project.</i>
</p>
