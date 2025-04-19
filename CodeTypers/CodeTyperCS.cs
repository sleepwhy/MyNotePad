using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

internal class CodeTyperCS
{
    private RichTextBox textBox;

    // Constructor: RichTextBox'u alır ve renklendirme işlemini başlatır
    public CodeTyperCS(RichTextBox richTextBox)
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
            "public", "void", "int", "class", "string", "return", "if", "else",
            "static", "private", "protected", "new", "interface", "namespace", "using",
            "readonly", "volatile", "abstract", "virtual", "sealed", "override", "delegate", "event"
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
        string variablePattern = @"\b(int|string|bool|double|decimal|char|float|object)\s+\w+\b"; // Değişkenler (tip + isim)

        foreach (Match match in Regex.Matches(textBox.Text, variablePattern))
        {
            HighlightText(match.Value, Color.Red); // Değişkenleri kırmızı renkte göster
        }
    }

    // Yorumları renklendir (Tek satırlık ve çok satırlık)
    private void HighlightComments()
    {
        string commentPatternSingleLine = @"//.*$"; // Tek satırlık yorumlar
        string commentPatternMultiLine = @"/\*[\s\S]*?\*/"; // Çok satırlı yorumlar

        foreach (Match match in Regex.Matches(textBox.Text, commentPatternSingleLine, RegexOptions.Multiline))
        {
            HighlightText(match.Value, Color.Gray); // Tek satırlık yorumları gri renkte göster
        }

        foreach (Match match in Regex.Matches(textBox.Text, commentPatternMultiLine))
        {
            HighlightText(match.Value, Color.Gray); // Çok satırlı yorumları gri renkte göster
        }
    }

    // String literalleri renklendir
    private void HighlightStrings()
    {
        string stringPattern = "\"(.*?)\""; // String literalleri

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
