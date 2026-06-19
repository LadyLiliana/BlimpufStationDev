using Robust.Shared.Prototypes;

namespace Content.Server._Blimpuf.WebGrapple;

[RegisterComponent]
public sealed partial class WebGrappleComponent : Component
{
    [DataField] public EntProtoId WebGrappleAction = "ActionWebGrapple";

    [DataField] public EntityUid? WebGrappleActionEntity;
}
