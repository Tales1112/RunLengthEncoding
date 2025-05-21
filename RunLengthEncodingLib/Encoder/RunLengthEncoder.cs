namespace RunLengthEncodingLib.Encoder;

using System.Text;

/// <summary>
/// Provides Run Length Encoding functionality.
/// </summary>
public static class RunLengthEncoder
{
    /// <summary>
    /// Encodes the input string using RLE.
    /// </summary>
    /// <param name="input">The input string to encode.</param>
    /// <returns>The RLE-encoded string.</returns>
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var encoded = new StringBuilder();
        char currentChar = input[0];
        int count = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == currentChar)
            {
                count++;
            }
            else
            {
                AppendEncodedGroup(encoded, currentChar, count);
                currentChar = input[i];
                count = 1;
            }
        }

        AppendEncodedGroup(encoded, currentChar, count);

        return encoded.ToString();
    }

    private static void AppendEncodedGroup(StringBuilder builder, char character, int count)
    {
        builder.Append(count);
        builder.Append(character);
    }
}
