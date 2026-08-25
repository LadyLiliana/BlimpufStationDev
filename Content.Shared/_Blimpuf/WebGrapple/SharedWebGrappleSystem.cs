using Content.Shared.Actions;

namespace Content.Shared._Blimpuf.WebGrapple;

/// <summary>
/// This System is for the Web Grapple ability for arachnids.
/// </summary>
public abstract class SharedWebGrappleSystem : EntitySystem
{

}

public sealed partial class ActionWebGrapple : WorldTargetActionEvent
{
}
