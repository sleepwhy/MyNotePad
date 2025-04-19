using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

internal class CodeTyperPython
{
    private RichTextBox textBox;

    // Constructor: RichTextBox'u alır ve renklendirme işlemini başlatır
    public CodeTyperPython(RichTextBox richTextBox)
    {
        this.textBox = richTextBox;
    }

    // Kodu renklendirme fonksiyonu
    public void ApplySyntaxHighlighting(string code)
    {
        // Text'i sıfırlamıyoruz, renklendirme yapıyoruz
        int selectionStart = textBox.SelectionStart;
        int selectionLength = textBox.SelectionLength;

        // Anahtar kelimeleri, fonksiyonları ve diğer öğeleri renklendir
        HighlightKeywords();
        HighlightFunctions();
        HighlightVariables();
        HighlightComments();
        HighlightStrings();
        HighlightNumbers();

        // Texti geri yükle ve eski seçimleri koru
        textBox.Select(selectionStart, selectionLength);
    }

    // Anahtar kelimeleri renklendir
    private void HighlightKeywords()
    {
        string[] keywords = {
            "def", "class", "if", "else", "elif", "for", "while", "try",
            "except", "return", "import", "from", "as", "with", "lambda",
            "True", "False", "None", "and", "or", "not",
            "public", "private", "protected", "void", "int", "string", "class"
        };

        foreach (string keyword in keywords)
        {
            HighlightText(keyword, Color.Blue); // Anahtar kelimeleri mavi renkte göster
        }
    }

    // Fonksiyonları renklendir
    private void HighlightFunctions()
    {
        string functionPattern = @"\b\w+\b(?=\()";  // Fonksiyon isimleri

        foreach (Match match in Regex.Matches(textBox.Text, functionPattern))
        {
            HighlightText(match.Value, Color.Green); // Fonksiyonları yeşil renkte göster
        }
    }

    // Değişkenleri renklendir
    private void HighlightVariables()
    {
        string variablePattern = @"\b\w+\b"; // Değişkenler (tip belirtilmeden)

        foreach (Match match in Regex.Matches(textBox.Text, variablePattern))
        {
            HighlightText(match.Value, Color.Red); // Değişkenleri kırmızı renkte göster
        }
    }

    // Yorumları renklendir
    private void HighlightComments()
    {
        // Python için tek satırlık yorum
        string commentPatternSingleLinePython = @"#.*$";
        // Python ve C# için çok satırlı yorum
        string commentPatternMultiLine = @"(?<=/)(\*.*\*|/.*$)";  // C# için yorumlar

        foreach (Match match in Regex.Matches(textBox.Text, commentPatternSingleLinePython, RegexOptions.Multiline))
        {
            HighlightText(match.Value, Color.Gray); // Python'daki yorumları gri renkte göster
        }

        foreach (Match match in Regex.Matches(textBox.Text, commentPatternMultiLine, RegexOptions.Multiline))
        {
            HighlightText(match.Value, Color.Gray); // C# ve Python'daki çok satırlı yorumları gri renkte göster
        }
    }

    // String literalleri renklendir
    private void HighlightStrings()
    {
        string stringPattern = "\"(.*?)\"|'(.*?)'"; // String literalleri

        foreach (Match match in Regex.Matches(textBox.Text, stringPattern))
        {
            HighlightText(match.Value, Color.Purple); // String'leri mor renkte göster
        }
    }

    // Sayısal literalleri renklendir
    private void HighlightNumbers()
    {
        string numberPattern = @"\b\d+(\.\d+)?\b"; // Sayılar (tam ve ondalıklı)

        foreach (Match match in Regex.Matches(textBox.Text, numberPattern))
        {
            HighlightText(match.Value, Color.Orange); // Sayıları turuncu renkte göster
        }
    }

    // Seçilen metni renklendirme fonksiyonu
    private void HighlightText(string text, Color color)
    {
        int startIndex = textBox.Text.IndexOf(text);
        while (startIndex != -1)
        {
            textBox.Select(startIndex, text.Length);
            textBox.SelectionColor = color;
            startIndex = textBox.Text.IndexOf(text, startIndex + 1);
        }
    }
}
