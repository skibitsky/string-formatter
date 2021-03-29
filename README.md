# String Formatter
> Format strings with HTML-like tags (Unity's Rich Text) in LINQ fashion

## Usage

```csharp
// Without String Formatter
Debug.Log($"Player's name: <color=red><size=16><i><b>{name}</b></i></size></color>");

// With String Formatter
Debug.Log($"Player's name: {name.Bold().Italic().Size(16).Red()});

// Reuse
var nameFormat = new FormattedStringBuilder().Bold().Italic().Size(16).Red();
Debug.Log($"Player One name: {nameFormat.Appy(name1)});
Debug.Log($"Player Two name: {nameFormat.Appy(name2)});

// Extend
public static FormattedStringBuilder Dead(this FormattedStringBuilder source)
{
    source.Append("Player ");       // Add before string. Used for opening tags
    source.PushToEnd(" is dead!");  // Add after string. Used for closing tags
    
    return source.Bold().Italic();  // Also make string bold and italic
}
public static FormattedStringBuilder Dead(this string source) => new FormattedStringBuilder(source).Dead();

```

## Installation

### Install via OpenUPM

The package is available on the [openupm registry](https://openupm.com). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli).

```
openupm add com.skibitsky.string-formatter
```

### Install via Git URL

Open *Packages/manifest.json* with your favorite text editor. Add the following line to the dependencies block.

    {
        "dependencies": {
            "com.skibitsky.string-formatter": "https://github.com/skibitsky/string-formatter.git"
        }
    }

Notice: Unity Package Manager records the current commit to a lock entry of the *manifest.json*. To update to the latest version, change the hash value manually or remove the lock entry to resolve the package.

    "lock": {
      "com.skibitsky.string-formatter": {
        "revision": "master",
        "hash": "..."
      }
    }


