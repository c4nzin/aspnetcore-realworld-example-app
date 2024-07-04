using System.Text.Json.Serialization;

namespace Conduit.Features.Profiles;

//ok
//init : immutable you cant change when its created but you can modify when you initialize this prop
public class Profile
{
    public string? Username { get; init; }

    public string? Bio { get; init; }

    public string? Image { get; init; }

    [JsonPropertyName("following")]
    public bool IsFollowed { get; set; }
}
