using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Serialization;

namespace Sons.Inventory
{
	// Token: 0x020005D5 RID: 1493
	[Token(Token = "0x20005D5")]
	[AddComponentMenu("Sons/Inventory/InventoryCameraController")]
	public class InventoryCameraController : MonoBehaviour
	{
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000523")]
		public Camera Camera
		{
			[Token(Token = "0x600262D")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x17000524")]
		public bool CursorMovedThisFrame
		{
			[Token(Token = "0x600262E")]
			[Address(RVA = "0x255EC70", Offset = "0x255DC70", VA = "0x18255EC70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x2D98AA0", Offset = "0x2D97AA0", VA = "0x182D98AA0")]
		private void Start()
		{
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x2D97F50", Offset = "0x2D96F50", VA = "0x182D97F50")]
		private void OnEnable()
		{
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002631")]
		[Address(RVA = "0x2D97E80", Offset = "0x2D96E80", VA = "0x182D97E80")]
		private void OnDisable()
		{
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x2D97CC0", Offset = "0x2D96CC0", VA = "0x182D97CC0")]
		private IEnumerator DelayedEnableCamera()
		{
			return null;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x2D983F0", Offset = "0x2D973F0", VA = "0x182D983F0")]
		public void ResetCamera()
		{
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x2D98870", Offset = "0x2D97870", VA = "0x182D98870")]
		public void ShowCursor(bool show)
		{
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002635")]
		[Address(RVA = "0x2D987B0", Offset = "0x2D977B0", VA = "0x182D987B0")]
		public void ResetCursor()
		{
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x2D97D30", Offset = "0x2D96D30", VA = "0x182D97D30")]
		public void FollowPlayerCamera(bool enable)
		{
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002637")]
		[Address(RVA = "0x2D983E0", Offset = "0x2D973E0", VA = "0x182D983E0")]
		public void PauseCameraMovement(bool pauseCamera)
		{
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x2D98BB0", Offset = "0x2D97BB0", VA = "0x182D98BB0")]
		private void Update()
		{
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x2D97D40", Offset = "0x2D96D40", VA = "0x182D97D40")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x2D96B90", Offset = "0x2D95B90", VA = "0x182D96B90")]
		private void ApplyCameraPan(Vector3 mouseViewportCoords)
		{
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263B")]
		[Address(RVA = "0x2D97560", Offset = "0x2D96560", VA = "0x182D97560")]
		private void ApplyCameraTilt(Vector3 mouseViewportCoords)
		{
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263C")]
		[Address(RVA = "0x2D96ED0", Offset = "0x2D95ED0", VA = "0x182D96ED0")]
		private void ApplyCameraPivot(Vector3 mouseViewportCoords)
		{
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x2D988A0", Offset = "0x2D978A0", VA = "0x182D988A0")]
		private static Quaternion SmoothDampQuaternion(Quaternion current, Quaternion target, ref Vector3 currentVelocity, float smoothTime)
		{
			return default(Quaternion);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x2D98280", Offset = "0x2D97280", VA = "0x182D98280")]
		public void OnMouseEnterLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263F")]
		[Address(RVA = "0x2D982A0", Offset = "0x2D972A0", VA = "0x182D982A0")]
		public void OnMouseExitLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002640")]
		[Address(RVA = "0x2D98340", Offset = "0x2D97340", VA = "0x182D98340")]
		public void OnMouseOverLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002641")]
		[Address(RVA = "0x2D98EF0", Offset = "0x2D97EF0", VA = "0x182D98EF0")]
		public InventoryCameraController()
		{
		}

		// Token: 0x04002272 RID: 8818
		[Token(Token = "0x4002272")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04002273 RID: 8819
		[Token(Token = "0x4002273")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _defaultFieldOfView;

		// Token: 0x04002274 RID: 8820
		[Token(Token = "0x4002274")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _topAnchor;

		// Token: 0x04002275 RID: 8821
		[Token(Token = "0x4002275")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _bottomAnchor;

		// Token: 0x04002276 RID: 8822
		[Token(Token = "0x4002276")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _leftAnchor;

		// Token: 0x04002277 RID: 8823
		[Token(Token = "0x4002277")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _rightAnchor;

		// Token: 0x04002278 RID: 8824
		[Token(Token = "0x4002278")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _panSmoothTime;

		// Token: 0x04002279 RID: 8825
		[Token(Token = "0x4002279")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _panSmoothTimeEdgeMultiplier;

		// Token: 0x0400227A RID: 8826
		[Token(Token = "0x400227A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _useCurve;

		// Token: 0x0400227B RID: 8827
		[Token(Token = "0x400227B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _panTarget;

		// Token: 0x0400227C RID: 8828
		[Token(Token = "0x400227C")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("_panCurve")]
		[SerializeField]
		private AnimationCurve _panXCurve;

		// Token: 0x0400227D RID: 8829
		[Token(Token = "0x400227D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationCurve _panYCurve;

		// Token: 0x0400227E RID: 8830
		[Token(Token = "0x400227E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _useTilt;

		// Token: 0x0400227F RID: 8831
		[Token(Token = "0x400227F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _tiltTarget;

		// Token: 0x04002280 RID: 8832
		[Token(Token = "0x4002280")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Vector2 _maxTiltDegrees;

		// Token: 0x04002281 RID: 8833
		[Token(Token = "0x4002281")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector2 _maxTiltThreshold;

		// Token: 0x04002282 RID: 8834
		[Token(Token = "0x4002282")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _tiltSmoothTime;

		// Token: 0x04002283 RID: 8835
		[Token(Token = "0x4002283")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _tiltSmoothTimeEdgeMultiplier;

		// Token: 0x04002284 RID: 8836
		[Token(Token = "0x4002284")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<BoxCollider> _tiltDeadZones;

		// Token: 0x04002285 RID: 8837
		[Token(Token = "0x4002285")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _usePivot;

		// Token: 0x04002286 RID: 8838
		[Token(Token = "0x4002286")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _pivotTarget;

		// Token: 0x04002287 RID: 8839
		[Token(Token = "0x4002287")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AnimationCurve _pivotCurve;

		// Token: 0x04002288 RID: 8840
		[Token(Token = "0x4002288")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private PathCreator _pivotStrengthSpline;

		// Token: 0x04002289 RID: 8841
		[Token(Token = "0x4002289")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private LayerMask _pivotLayerMask;

		// Token: 0x0400228A RID: 8842
		[Token(Token = "0x400228A")]
		[FieldOffset(Offset = "0xDC")]
		[Range(0f, 180f)]
		[SerializeField]
		private float _maxPivotAngle;

		// Token: 0x0400228B RID: 8843
		[Token(Token = "0x400228B")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Range(0f, 10f)]
		private float _maxPivotAngleRate;

		// Token: 0x0400228C RID: 8844
		[Token(Token = "0x400228C")]
		[FieldOffset(Offset = "0xE4")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _triggerPlayerKneelAtDelta;

		// Token: 0x0400228D RID: 8845
		[Token(Token = "0x400228D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Transform _positionConstraintSource;

		// Token: 0x0400228E RID: 8846
		[Token(Token = "0x400228E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Transform _rotationConstraintSource;

		// Token: 0x0400228F RID: 8847
		[Token(Token = "0x400228F")]
		[FieldOffset(Offset = "0xF8")]
		private float _screenRatio;

		// Token: 0x04002290 RID: 8848
		[Token(Token = "0x4002290")]
		[FieldOffset(Offset = "0xFC")]
		private float _adjustedMaxXTiltDegrees;

		// Token: 0x04002291 RID: 8849
		[Token(Token = "0x4002291")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		public bool _inTiltDeadZone;

		// Token: 0x04002292 RID: 8850
		[Token(Token = "0x4002292")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private InventoryCursorController _inventoryCursorController;

		// Token: 0x04002293 RID: 8851
		[Token(Token = "0x4002293")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Transform _constraintTranfsorm;

		// Token: 0x04002294 RID: 8852
		[Token(Token = "0x4002294")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 _panningVelocity;

		// Token: 0x04002295 RID: 8853
		[Token(Token = "0x4002295")]
		[FieldOffset(Offset = "0x124")]
		private bool _followingPlayerCamera;

		// Token: 0x04002296 RID: 8854
		[Token(Token = "0x4002296")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private float _constraintSmoothTime;

		// Token: 0x04002297 RID: 8855
		[Token(Token = "0x4002297")]
		[FieldOffset(Offset = "0x12C")]
		private bool _cursorMovedThisFrame;

		// Token: 0x04002298 RID: 8856
		[Token(Token = "0x4002298")]
		[FieldOffset(Offset = "0x12D")]
		private bool _cameraMovementIsPaused;

		// Token: 0x04002299 RID: 8857
		[Token(Token = "0x4002299")]
		[FieldOffset(Offset = "0x12E")]
		private bool _isOverItem;

		// Token: 0x0400229A RID: 8858
		[Token(Token = "0x400229A")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 _tiltVelocity;

		// Token: 0x0400229B RID: 8859
		[Token(Token = "0x400229B")]
		[FieldOffset(Offset = "0x13C")]
		private Vector3 _originalCameraEulers;

		// Token: 0x0400229C RID: 8860
		[Token(Token = "0x400229C")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 _previousTiltEuler;

		// Token: 0x0400229D RID: 8861
		[Token(Token = "0x400229D")]
		[FieldOffset(Offset = "0x154")]
		private Vector3 _lastScreenMousePosition;

		// Token: 0x0400229E RID: 8862
		[Token(Token = "0x400229E")]
		[FieldOffset(Offset = "0x160")]
		private Vector3 _currentPivotVelocity;

		// Token: 0x0400229F RID: 8863
		[Token(Token = "0x400229F")]
		[FieldOffset(Offset = "0x170")]
		private LayoutItem _activeLayoutItem;

		// Token: 0x040022A0 RID: 8864
		[Token(Token = "0x40022A0")]
		[FieldOffset(Offset = "0x178")]
		private PositionConstraint _positionConstraint;

		// Token: 0x040022A1 RID: 8865
		[Token(Token = "0x40022A1")]
		[FieldOffset(Offset = "0x180")]
		private RotationConstraint _rotationConstraint;

		// Token: 0x040022A2 RID: 8866
		[Token(Token = "0x40022A2")]
		[FieldOffset(Offset = "0x188")]
		private float _positionConstraintVelocity;

		// Token: 0x040022A3 RID: 8867
		[Token(Token = "0x40022A3")]
		[FieldOffset(Offset = "0x18C")]
		private float _rotationConstraintVelocity;

		// Token: 0x040022A4 RID: 8868
		[Token(Token = "0x40022A4")]
		[FieldOffset(Offset = "0x190")]
		private Transform _strengthSplineTransform;
	}
}
