# .assets

I use this folder to keep the media and visual files that belong to this repository in one organized place.

The purpose of `.assets` is to avoid placing banners, screenshots, images, videos, diagrams, and other media files randomly across the repository.

## What I store here

I can use this folder for files such as:

- repository banners;
- module and project banners;
- screenshots;
- images used in README files;
- diagrams;
- GIFs and animations;
- short videos or demonstrations;
- icons;
- logos;
- visual examples;
- other media related to my learning notes and projects.

## Recommended structure

As the number of assets grows, I can organize them by type or by section of the repository.

```text
.assets/
├── banners/
├── images/
├── screenshots/
├── diagrams/
├── videos/
├── gifs/
├── icons/
└── README.md
```

I do not need to create every subfolder immediately. I only add a folder when I actually have files that belong there.

## File naming

I use clear, descriptive file names.

Good examples:

```text
01-vscode-banner.png
python-variables-example.png
kotlin-intellij-setup.png
student-management-console.png
unitrack-login-screen.png
data-structures-diagram.drawio
```

I avoid names such as:

```text
image1.png
new.png
final-final.png
screenshot123.png
untitled.jpg
```

## Naming rules

I follow these rules when possible:

- use lowercase file names;
- use hyphens between words;
- describe what the file contains;
- include the related module or project when useful;
- keep the original file extension;
- avoid spaces and unnecessary special characters;
- avoid duplicate files with different names.

## Using assets in README files

For a file stored directly inside `.assets`:

```markdown
![VS Code banner](../../.assets/01-vscode-banner.png)
```

The relative path depends on the location of the README that is using the file.

For assets inside a subfolder:

```markdown
![VS Code banner](../../.assets/banners/01-vscode-banner.png)
```

## Image guidelines

For repository images and banners, I try to:

- use readable dimensions;
- keep text large enough to read on GitHub;
- compress files when possible;
- use PNG for graphics and screenshots when appropriate;
- use JPG or WebP for photographic images when appropriate;
- use SVG for scalable vector graphics when appropriate;
- include meaningful alt text when embedding images in Markdown.

## Video guidelines

Large video files can make a Git repository unnecessarily heavy.

When I store video files here, I keep them short and relevant. For larger recordings, I can keep only a preview, thumbnail, GIF, or external reference in the repository instead of committing a very large file.

## Organization rule

I keep only assets that are actually related to this repository.

Each asset should have a clear purpose and should be easy to identify from its filename and folder location.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
