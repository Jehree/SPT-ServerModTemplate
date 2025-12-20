using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Logging;
using SPTarkov.Server.Core.Models.Spt.Mod;
using SPTarkov.Server.Core.Models.Utils;

namespace ModName.Core;

[Injectable(TypePriority = OnLoadOrder.PreSptModLoader + 1)]
public class Mod(
    ISptLogger<Mod> logger)
    : IOnLoad
{
    public Task OnLoad()
    {
        
        return Task.CompletedTask;
    }
}
