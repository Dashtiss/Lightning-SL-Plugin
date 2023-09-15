using Exiled.API.Interfaces;
using PlayerRoles;
using System.ComponentModel;

public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;
    [Description("If debug mode is enabled. When enabled, the plugin will log debug messages to the console. DON'T USE WITH MORE THEN 1 PLAYER, CONSOLE WILL FLOOD.")]
    public bool Debug { get; set; }

    public string CassieTest { get; set; } = "This is a test of cassie";
}