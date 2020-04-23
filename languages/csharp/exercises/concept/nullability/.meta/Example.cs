using System;

public static class Badge
{
    public static string Label(int? id, string name, string? department)
    {
        var worksAt = department?.ToUpper() ?? "GUEST";

        if (id == null)
        {
            return $"{name} - {worksAt}";
        }

        return $"[{id}] - {name} - {worksAt}";
    }

    public static string PrintLabel(string? prefix, string label, int maximumWidth)
    {
        var maximumLabelWidth = maximumWidth - (prefix?.Length ?? 0);
        var output = "";

        for (var i = 0; i < label.Length; i += maximumLabelWidth)
        {
            var labelWidth = Math.Min(maximumLabelWidth, label.Length - i);
            var truncatedLabel = label.Substring(i, labelWidth);
            output += $"{prefix ?? ""}{truncatedLabel}\n";
        }

        return output.TrimEnd();
    }
}
