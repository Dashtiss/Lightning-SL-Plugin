using Exiled.API.Interfaces;
using System.ComponentModel;

public class Config : IConfig
{
    [Description("If the plugin is enabled or not")]
    public bool IsEnabled { get; set; } = true;
    public bool Debug { get; set; }
    [Description("broadcast if round lock is off")]
    public string RLDisabledMessage { get; set; } = "Round Lock is off";
    [Description("Broadcast if roundlock is on")]
    public string RLEnabledMessage { get; set; } = "Round lock is on";
}