using AutoMapper;
using Lunatrik.ARDConnector.AzureModels;

namespace Lunatrik.ARDConnector.Mappings;

public class AzureMessageToDiscordWebhook : Profile
{
    public AzureMessageToDiscordWebhook()
    {
        CreateMap<AzureMessage, DiscordMessage>()
            .ForMember(dest => dest.username, opt => opt.MapFrom(src => src.resource.pushedBy.displayName))
            .ForMember(dest => dest.content, opt => opt.MapFrom(src => src.message.text))
            .ForMember(dest => dest.avatar_url, opt => opt.MapFrom(src => "https://cdn.vsassets.io/ext/ms.vss-code-web/common-content/Nav-Code.0tJczm.png"))
            .ForMember(dest => dest.embeds, opt => opt.MapFrom(src => new List<Embed>
            {
                new Embed
                {
                    title = src.resource.repository.name,
                    description = src.detailedMessage.text,
                    url = src.resource.url,
                    fields = src.resource.commits.Select(commit => new Field
                    {
                        name = commit.commitId,
                        value = commit.comment,
                        inline = false
                    }).ToList()
                }
            }));
    }

}
