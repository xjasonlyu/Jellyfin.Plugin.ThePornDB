#if __EMBY__
using System.ComponentModel;
using Emby.Web.GenericEdit;
using MediaBrowser.Model.Attributes;

#else
using MediaBrowser.Model.Plugins;
#endif

namespace ThePornDB.Configuration
{
    public enum OrderStyle
    {
        Default = 0,
        DistanceByTitle = 1,
    }

    public enum TagStyle
    {
        Genre = 0,
        Tag = 1,
        Disabled = 2,
    }

    public enum StudioStyle
    {
        Site = 0,
        Network = 1,
        Both = 2,
    }

    public enum ActorsOverviewStyle
    {
        None = 0,
        Default = 1,
        CustomExtras = 2,
    }

    public enum ActorsRoleStyle
    {
        None = 0,
        Gender = 1,
        NameByScene = 2,
    }

    public enum ActorsImageStyle
    {
        Poster = 0,
        Face = 1,
    }

#if __EMBY__
    public class PluginConfiguration : EditableOptionsBase
    {
        public override string EditorTitle => Plugin.Instance.Name;

#else
    public class PluginConfiguration : BasePluginConfiguration
    {
#endif
        public PluginConfiguration()
        {
            this.MetadataAPIToken = string.Empty;

            this.UseFilePath = true;
            this.UseOSHash = true;

            this.OrderStyle = OrderStyle.Default;
            this.TagStyle = TagStyle.Genre;

            this.AddCollectionToCollections = true;
            this.StudioStyle = StudioStyle.Both;

            this.UseCustomTitle = false;
            this.CustomTitle = "{studio}: {title} ({actors})";

            this.UseUnmatchedTag = false;
            this.UnmatchedTag = "Missing From ThePornDB";

            this.DisableMediaAutoIdentify = false;
            this.DisableActorsAutoIdentify = false;

            this.ActorsRole = ActorsRoleStyle.Gender;
            this.ActorsImage = ActorsImageStyle.Poster;
            this.ActorsOverview = ActorsOverviewStyle.Default;
            this.ActorsOverviewFormat = "<strong style=\"color:#ff0000\">{measurements}<br/></strong>{cupsize}-{waist}-{hips}<br/>{tattoos}<br/>{piercings}<br/>{bio}";
        }

#if __EMBY__
        [DisplayName("Token")]
        [Required]
#endif
        public string MetadataAPIToken { get; set; }

#if __EMBY__
        [DisplayName("Use FilePath for matching")]
#endif
        public bool UseFilePath { get; set; }

#if __EMBY__
        [DisplayName("Use OpenSubtitlesHash for matching")]
#endif
        public bool UseOSHash { get; set; }

#if __EMBY__
        [DisplayName("Order Style")]
#endif
        public OrderStyle OrderStyle { get; set; }

#if __EMBY__
        [DisplayName("Tag Style")]
#endif
        public TagStyle TagStyle { get; set; }

#if __EMBY__
        [DisplayName("Add Collection to Collections")]
#endif
        public bool AddCollectionToCollections { get; set; }

#if __EMBY__
        [DisplayName("Studio Style")]
#endif
        public StudioStyle StudioStyle { get; set; }

#if __EMBY__
        [DisplayName("Use Custom Title Format")]
#endif
        public bool UseCustomTitle { get; set; }

#if __EMBY__
        [DisplayName("Custom Title Format")]
#endif
        public string CustomTitle { get; set; }

#if __EMBY__
        [DisplayName("Use Unmatched Tag")]
#endif
        public bool UseUnmatchedTag { get; set; }

#if __EMBY__
        [DisplayName("Unmatched Tag")]
#endif
        public string UnmatchedTag { get; set; }

#if __EMBY__
        [DisplayName("Disable Media Auto Identify")]
#endif
        public bool DisableMediaAutoIdentify { get; set; }

#if __EMBY__
        [DisplayName("Disable Actors Auto Identify")]
#endif
        public bool DisableActorsAutoIdentify { get; set; }

#if __EMBY__
        [DisplayName("Actors Role Option")]
#endif
        public ActorsRoleStyle ActorsRole { get; set; }

#if __EMBY__
        [DisplayName("Actors Image Option")]
#endif
        public ActorsImageStyle ActorsImage { get; set; }

#if __EMBY__
        [DisplayName("Actors Overview Option")]
#endif
        public ActorsOverviewStyle ActorsOverview { get; set; }

#if __EMBY__
        [DisplayName("Actor Custom Format")]
#endif
        public string ActorsOverviewFormat { get; set; }
    }
}
