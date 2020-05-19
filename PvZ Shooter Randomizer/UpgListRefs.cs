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

    private List<string> gw2LawPeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Reload", "Reload", "Damage", "Health"
    };

    public List<string> GetLawPeaUpgs()
    {
        return gw2LawPeaUpgs;
    }

    private List<string> gw2PlasmaPeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Reload", "Ammo", "Damage", "Health"
    };

    public List<string> GetPlasmaPeaUpgs()
    {
        return gw2PlasmaPeaUpgs;
    }

    private List<string> gw2RockPeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Reload", "Ammo", "Damage", "Health"
    };

    public List<string> GetRockPeaUpgs()
    {
        return gw2RockPeaUpgs;
    }

    private List<string> gw2ElectroPeaUpgs = new List<string>
    {
        "Health Regeneration Delay", "Zoom", "Health Regeneration", "Speed", "Health", "Reload", "Reload", "Ammo"
    };

    public List<string> GetElectroPeaUpgs()
    {
        return gw2ElectroPeaUpgs;
    }

    private List<string> gw2ChomperUpgs = new List<string>
    {
        "Speed", "Digestion", "Health", "Damage", "Digestion", "Damage", "Health Regeneration Delay", "Health Regeneration"
    };

    public List<string> GetChomperUpgs()
    {
        return gw2ChomperUpgs;
    }

    private List<string> gw2FireChomperUpgs = new List<string>
    {
        "Speed", "Digestion", "Health", "Fire", "Overheat", "Digestion", "Health Regeneration Delay", "Health Regeneration"
    };

    public List<string> GetFireChomperUpgs()
    {
        return gw2FireChomperUpgs;
    }
}
