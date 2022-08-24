using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


/// <summary>
/// Remove reticle when an object is grabbed,
/// put it back when it's ungrabbed
/// <remark>
/// Still doesn't work, needs fix
/// </remark>
/// </summary>
public class ReticleOffOnGrab : MonoBehaviour
{
	[Header("Left Hand")]
	[SerializeField] private XRInteractorLineVisual _leftXRInteractorLineVisual;

	[Space(1)]
	[Header("Right Hand")]
	[SerializeField] private XRInteractorLineVisual _rightXRInteractorLineVisual;

	[Space(1)]
	[Header("Grab Reticles Renderers")]
	[SerializeField] private MeshRenderer _leftGrabReticle;
	[SerializeField] private MeshRenderer _rightGrabReticle;

	public void LeftHandOnGrab()
	{
		//_leftXRInteractorLineVisual.reticle = null;
		_leftGrabReticle.enabled = false;
	}

	public void LeftHandOffGrab()
	{
		//_leftXRInteractorLineVisual.reticle = _grabReticle;
		_leftGrabReticle.enabled = true;
	}

	public void RightHandOnGrab()
	{
		//_rightXRInteractorLineVisual.reticle = null;
		_rightGrabReticle.enabled = false;
	}

	public void RightHandOffGrab()
	{
		//_rightXRInteractorLineVisual.reticle = _grabReticle;
		_rightGrabReticle.enabled = true;
	}
}
