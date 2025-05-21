# RunLengthEncodingLib

A C# library that implements Run Length Encoding (RLE).

## Features

- Encode strings using the RLE algorithm
- Lightweight and easy to integrate

## Usage

```csharp
using RunLengthEncodingLib.Encoding;

var encoded = RunLengthEncoder.Encode("aaabccdddddd"); // "3a1b2c6d"
