using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

public class UpgListRef
{
    private List<string> gw2PeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Reload", "Ammo", "Damage", "Health"
    };

    public List<string> GetPeaUpgs()
    {
        return gw2PeaUpgs;
    }

    private List<string> gw2FirePeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Reload", "Ammo", "Fire", "Health"
    };

    public List<string> GetFirePeaUpgs()
    {
        return gw2FirePeaUpgs;
    }

    private List<string> gw2IcePeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Reload", "Ammo", "Ice", "Health"
    };

    public List<string> GetIcePeaUpgs()
    {
        return gw2IcePeaUpgs;
    }

    private List<string> gw2ToxicPeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Reload", "Ammo", "Toxic", "Health"
    };

    public List<string> GetToxicPeaUpgs()
    {
        return gw2ToxicPeaUpgs;
    }

    private List<string> gw2CommandoPeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Reload", "Ammo", "Damage", "Health"
    };

    public List<string> GetCommandoPeaUpgs()
    {
        return gw2CommandoPeaUpgs;
    }

    private List<string> gw2AgentPeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Reload", "Ammo", "Damage", "Health"
    };

    public List<string> GetAgentPeaUpgs()
    {
        return gw2AgentPeaUpgs;
    }

}
