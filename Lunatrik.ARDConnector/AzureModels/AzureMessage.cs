namespace Lunatrik.ARDConnector.AzureModels;


public partial class Account
{
    public string? id { get; set; }
}

public partial class Author
{
    public string? name { get; set; }
    public string? email { get; set; }
    public DateTime? date { get; set; }
}

public partial class Collection
{
    public string? id { get; set; }
}

public partial class Commit
{
    public string? commitId { get; set; }
    public Author? author { get; set; }
    public Committer? committer { get; set; }
    public string? comment { get; set; }
    public string? url { get; set; }
}

public partial class Committer
{
    public string? name { get; set; }
    public string? email { get; set; }
    public DateTime? date { get; set; }
}

public partial class DetailedMessage
{
    public string? text { get; set; }
    public string? html { get; set; }
    public string? markdown { get; set; }
}

public partial class Message
{
    public string? text { get; set; }
    public string? html { get; set; }
    public string? markdown { get; set; }
}

public partial class Project
{
    public string? id { get; set; }
    public string? name { get; set; }
    public string? url { get; set; }
    public string? state { get; set; }
    public string? visibility { get; set; }
    public DateTime? lastUpdateTime { get; set; }
}

public partial class PushedBy
{
    public string? displayName { get; set; }
    public string? id { get; set; }
    public string? uniqueName { get; set; }
}

public partial class RefUpdate
{
    public string? name { get; set; }
    public string? oldObjectId { get; set; }
    public string? newObjectId { get; set; }
}

public partial class Repository
{
    public string? id { get; set; }
    public string? name { get; set; }
    public string? url { get; set; }
    public Project? project { get; set; }
    public string? defaultBranch { get; set; }
    public string? remoteUrl { get; set; }
}

public partial class Resource
{
    public List<Commit>? commits { get; set; }
    public List<RefUpdate>? refUpdates { get; set; }
    public Repository? repository { get; set; }
    public PushedBy? pushedBy { get; set; }
    public int? pushId { get; set; }
    public DateTime? date { get; set; }
    public string? url { get; set; }
}

public partial class ResourceContainers
{
    public Collection? collection { get; set; }
    public Account? account { get; set; }
    public Project? project { get; set; }
}

public partial class AzureMessage
{
    public string? subscriptionId { get; set; }
    public int? notificationId { get; set; }
    public string? id { get; set; }
    public string? eventType { get; set; }
    public string? publisherId { get; set; }
    public Message? message { get; set; }
    public DetailedMessage? detailedMessage { get; set; }
    public Resource? resource { get; set; }
    public string? resourceVersion { get; set; }
    public ResourceContainers? resourceContainers { get; set; }
    public DateTime? createdDate { get; set; }
}

