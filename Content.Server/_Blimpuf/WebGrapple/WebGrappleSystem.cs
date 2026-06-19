using Content.Server.Actions;
using Content.Shared._Blimpuf.WebGrapple;
using Robust.Shared.Player;
using Content.Server.Popups;

namespace Content.Server._Blimpuf.WebGrapple;

/// <inheritdoc/>
public sealed partial class WebGrappleSystem : SharedWebGrappleSystem
{
    [Dependency] private readonly ActionsSystem _actionsSystem = default!;
    [Dependency] private readonly EntityManager _entityManager = default!;
    [Dependency] private PopupSystem _popup = default!;

    /// <inheritdoc/>
    public override void Initialize()
    {
        SubscribeLocalEvent<WebGrappleComponent, ActionWebGrapple>(OnShootGrapple);
        SubscribeLocalEvent<WebGrappleComponent, MapInitEvent>(OnMapInit);
    }

    private void OnMapInit(EntityUid uid, WebGrappleComponent component, MapInitEvent args)
    {
        // try to add web grapple action
        _actionsSystem.AddAction(uid, ref component.WebGrappleActionEntity, component.WebGrappleAction);
    }

    private void OnShootGrapple(EntityUid uid, WebGrappleComponent component, ActionWebGrapple args)
    {
        if (args.Handled)
            return;

        //TODO: The Actual function to shoot the grappling hook
    }
}
