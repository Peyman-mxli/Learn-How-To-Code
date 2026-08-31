# Installation and Setup Notes

## 1. IntelliJ IDEA overview

IntelliJ IDEA is a cross-platform integrated development environment developed by JetBrains. It combines a code editor, project explorer, build integration, debugger, terminal, version-control tools, and extensibility through plugins.

It is widely used for Java and Kotlin development.

## 2. Product and licensing model

IntelliJ IDEA is distributed as a unified product. Core Java and Kotlin development features are available at no cost, while advanced features can require an IntelliJ IDEA Ultimate subscription.

JetBrains also continues to make the open-source Community Edition available. The free functionality is sufficient for the lessons in this repository.

Because licensing and included features can change, always review the current information on the [official download page](https://www.jetbrains.com/idea/download/).

## 3. Official system requirements

The current JetBrains documentation lists these baseline requirements:

| Component | Requirement |
|---|---|
| CPU | x86_64 or ARM64 processor with four cores |
| Memory | 8 GB total RAM, with approximately 3 GB available to IDE processes |
| Storage | 10 GB available disk space |
| Display | Minimum resolution of 1280 × 720 |
| Windows | Windows 10 or Windows 11 |
| macOS | A macOS version currently supported by JetBrains |
| Linux | A supported 64-bit distribution and desktop environment |

Consult the [official installation guide](https://www.jetbrains.com/help/idea/installation-guide.html) before installing because supported operating systems change over time.

### Recommended learning environment

For a comfortable experience:

- use 16 GB RAM when available;
- install the IDE on an SSD;
- retain additional space for projects, caches, JDKs, plugins, and build output;
- maintain a stable internet connection for downloads and updates; and
- close unnecessary memory-intensive applications.

## 4. Choosing an installation method

### JetBrains Toolbox App

Toolbox is convenient for managing JetBrains applications, installed versions, and updates.

1. Download [JetBrains Toolbox App](https://www.jetbrains.com/toolbox-app/).
2. Install and open it.
3. Find IntelliJ IDEA.
4. Choose the current stable release.
5. Install and launch the IDE.

### Standalone installer

1. Open the [IntelliJ IDEA download page](https://www.jetbrains.com/idea/download/).
2. Confirm the operating system and processor architecture.
3. Download the correct installer.
4. Run it and review each option.
5. Finish installation.
6. Launch IntelliJ IDEA.

Only download installers from JetBrains or a deployment source approved by an organization.

## 5. Windows installation

The Windows installer may offer options such as:

- a desktop shortcut;
- adding the launcher directory to PATH;
- an **Open Folder as Project** context-menu command; and
- file associations.

Select only the options that are useful and understood. PATH integration can help open projects from a terminal but is not required for the first lesson.

Restart Windows only if requested or if a selected integration is not available after installation.

## 6. macOS installation

1. Download the build matching the processor.
2. Open the disk image.
3. Drag IntelliJ IDEA into Applications.
4. Launch it from Applications.
5. Approve the macOS security prompt when appropriate.

Use ARM64 for Apple Silicon and the Intel build for an Intel-based Mac.

## 7. Linux installation

JetBrains supports the Toolbox App and a downloadable archive. Package-manager availability depends on the distribution.

For the archive method:

1. download it from JetBrains;
2. extract it to an appropriate applications directory;
3. open the extracted bin directory;
4. run the supplied launcher script; and
5. optionally create a desktop entry from the IDE.

Follow the current [JetBrains standalone instructions](https://www.jetbrains.com/help/idea/installation-guide.html#standalone) for exact commands.

## 8. First launch

IntelliJ IDEA may ask whether to import settings.

Choose **Do not import settings** for a first installation or a clean learning environment. Import settings only when a known compatible configuration should be reused.

Other initial screens can include:

- privacy or data-sharing choices;
- license details;
- appearance settings;
- available plugins; and
- the Welcome screen.

Read each choice rather than accepting every default automatically.

## 9. Initial configuration

### Theme

Choose a theme based on comfort and accessibility. It can be changed later and does not affect program behavior.

### Updates

Prefer stable updates. Read the release information before updating during an important project and restart when requested.

### Plugins

Start with built-in features. Add a plugin only for a specific requirement.

Before installing one:

1. verify the publisher;
2. confirm compatibility;
3. read its description and requested permissions;
4. check recent maintenance activity; and
5. restart the IDE if required.

Installing many plugins can increase startup time, memory use, and incompatibility risk.

## 10. Why the IDE uses memory

IntelliJ IDEA performs background work such as:

- indexing;
- static code analysis;
- error detection;
- code-completion calculation;
- version-control tracking; and
- plugin execution.

Temporary high CPU or memory usage is normal during initial indexing.

## 11. Verification

After installation:

1. launch IntelliJ IDEA;
2. confirm that the Welcome screen appears;
3. open Settings;
4. open Plugins;
5. select **Help → About**;
6. record the exact IDE version;
7. record the operating system; and
8. verify that adequate disk space remains.

The presence of **New Project**, **Open**, and **Get from VCS** confirms that the Welcome screen loaded correctly.

## 12. Troubleshooting

### Installer does not open

- Verify the operating system and processor architecture.
- Download the installer again from JetBrains.
- Check whether the operating system blocked it.
- Confirm installation permissions.

### Slow startup

- Allow initial indexing to finish.
- Close unnecessary applications.
- Disable unneeded third-party plugins.
- Check memory and available disk space.
- Prefer SSD storage.

### IDE does not start

- Restart the computer.
- Try launching without opening a large project.
- Record the full error message.
- Consult JetBrains support documentation.

### Paid-feature notice appears

Some unified-product capabilities require Ultimate. Review the notice and continue with free core Java and Kotlin functionality when appropriate.

### Installation completes but no Welcome screen appears

IntelliJ IDEA may reopen the last project automatically. Use **File → Close Project** to return to the Welcome screen.

## 13. Scope boundary

A successful IDE installation does not mean the programming environment is fully ready. A JDK and project SDK must still be configured before building JVM applications. That work belongs to the next lesson stage.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
