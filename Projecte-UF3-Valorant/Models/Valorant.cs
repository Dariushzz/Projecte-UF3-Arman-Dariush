namespace Projecte_UF3_Arman_Dariush.Models;

public class Ability
{
    public string slot { get; set; }
    public string displayName { get; set; }
    public string description { get; set; }
    public string displayIcon { get; set; }
}

public class Datum
{
    public string uuid { get; set; }
    public string displayName { get; set; }
    public string description { get; set; }
    public string developerName { get; set; }
    public DateTime releaseDate { get; set; }
    public List<string> characterTags { get; set; }
    public string displayIcon { get; set; }
    public string displayIconSmall { get; set; }
    public string bustPortrait { get; set; }
    public string fullPortrait { get; set; }
    public string fullPortraitV2 { get; set; }
    public string killfeedPortrait { get; set; }
    public string background { get; set; }
    public List<string> backgroundGradientColors { get; set; }
    public string assetPath { get; set; }
    public bool isFullPortraitRightFacing { get; set; }
    public bool isPlayableCharacter { get; set; }
    public bool isAvailableForTest { get; set; }
    public bool isBaseContent { get; set; }
    public Role role { get; set; }
    public RecruitmentData recruitmentData { get; set; }
    // public List<Ability> abilities { get; set; }
    public object voiceLine { get; set; }
}

public class RecruitmentData
{
    public string counterId { get; set; }
    public string milestoneId { get; set; }
    public int milestoneThreshold { get; set; }
    public bool useLevelVpCostOverride { get; set; }
    public int levelVpCostOverride { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
}

public class Role
{
    public string uuid { get; set; }
    public string displayName { get; set; }
    public string description { get; set; }
    public string displayIcon { get; set; }
    public string assetPath { get; set; }
}

public class Root
{
    public int status { get; set; }
    public List<Datum> data { get; set; }
}

