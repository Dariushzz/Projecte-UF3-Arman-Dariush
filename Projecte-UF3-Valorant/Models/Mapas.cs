// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace Projecte_UF3_Arman_Dariush.Models;

public class Callout
{
    public string regionName { get; set; }
    public string superRegionName { get; set; }
    public Location location { get; set; }
}

public class Datum2
{
    public string uuid { get; set; }
    public string displayName { get; set; }
    public object narrativeDescription { get; set; }
    public string tacticalDescription { get; set; }
    public string coordinates { get; set; }
    public string displayIcon { get; set; }
    public string listViewIcon { get; set; }
    public string listViewIconTall { get; set; }
    public string splash { get; set; }
    public string stylizedBackgroundImage { get; set; }
    public string premierBackgroundImage { get; set; }
    public string assetPath { get; set; }
    public string mapUrl { get; set; }
    public double xMultiplier { get; set; }
    public double yMultiplier { get; set; }
    public double xScalarToAdd { get; set; }
    public double yScalarToAdd { get; set; }
    public List<Callout> callouts { get; set; }
}

public class Location
{
    public double x { get; set; }
    public double y { get; set; }
}

public class Root2
{
    public int status { get; set; }
    public List<Datum2> data { get; set; }
}

