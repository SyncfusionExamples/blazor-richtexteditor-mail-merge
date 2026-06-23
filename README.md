# Blazor RichTextEditor — Mail Merge

Simple demo to insert merge fields into a document and replace them with data.

## What this sample shows

- Insert merge fields (e.g., customer name or address) via the toolbar or by typing `{` for suggestions.
- Use the "Finish & Merge" action to fill those fields with values from the sample data file.

## Prerequisites

- .NET 8.0 SDK
- Visual Studio 2022+ or VS Code
- Syncfusion Blazor packages (a license may be required)

## Setup & Running Steps

Installation

```bash
git clone https://github.com/SyncfusionExamples/blazor-richtexteditor-mail-merge.git
cd blazor-richtexteditor-mail-merge
```

Restore NuGet packages

```bash
dotnet restore
```

Run the application

```bash
dotnet run
```

## How to use

1. Open the running app.
2. Insert merge fields from the "Insert Merge Field" menu or the mention suggestions (type `{`).
3. Edit the document as needed.
4. Click "Finish & Merge" to replace fields with values from `Data/InvoiceData.json`.

## Troubleshooting

- If the app won't start, run `dotnet restore` and ensure the project builds.
- If merged values are missing, check that `Data/InvoiceData.json` exists and contains valid data.

## Support

This sample is provided for demonstration purposes. For issues, open an issue in the repository.

## See also

- [Online examples](https://blazor.syncfusion.com/demos/rich-text-editor/overview?theme=fluent2)
- [Documentation](https://blazor.syncfusion.com/documentation/rich-text-editor/getting-started-webapp)

>Looking for the full Blazor Rich Text Editor component overview, features, pricing, and documentation? Visit the [Blazor Rich Text Editor](https://www.syncfusion.com/blazor-components/blazor-rich-text-editor) page.
