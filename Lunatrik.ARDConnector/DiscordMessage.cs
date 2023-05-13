namespace Lunatrik.ARDConnector;

public class Embed
{
    public string? title { get; set; }
    public string? description { get; set; }
    public string? url { get; set; }
    public int? color { get; set; }
    public List<Field>? fields { get; set; }
}

public class Field
{
    public string? name { get; set; }
    public string? value { get; set; }
    public bool? inline { get; set; }
}

public class DiscordMessage
{
    public string? content { get; set; }
    public string? username { get; set; }
    public string? avatar_url { get; set; }
    public List<Embed>? embeds { get; set; }
}
