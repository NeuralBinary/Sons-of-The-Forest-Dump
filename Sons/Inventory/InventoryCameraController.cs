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
	// Token: 0x020005E6 RID: 1510
	[Token(Token = "0x20005E6")]
	[AddComponentMenu("Sons/Inventory/InventoryCameraController")]
	public class InventoryCameraController : MonoBehaviour
	{
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000538")]
		public Camera Camera
		{
			[Token(Token = "0x6002736")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x17000539")]
		public bool CursorMovedThisFrame
		{
			[Token(Token = "0x6002737")]
			[Address(RVA = "0x2A29B60", Offset = "0x2A28160", VA = "0x182A29B60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002738")]
		[Address(RVA = "0x33BEB70", Offset = "0x33BD170", VA = "0x1833BEB70")]
		private void Start()
		{
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002739")]
		[Address(RVA = "0x33BED30", Offset = "0x33BD330", VA = "0x1833BED30")]
		private void OnEnable()
		{
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273A")]
		[Address(RVA = "0x33BF470", Offset = "0x33BDA70", VA = "0x1833BF470")]
		private void OnDisable()
		{
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600273B")]
		[Address(RVA = "0x33BF5C0", Offset = "0x33BDBC0", VA = "0x1833BF5C0")]
		private IEnumerator DelayedEnableCamera()
		{
			return null;
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273C")]
		[Address(RVA = "0x33BF650", Offset = "0x33BDC50", VA = "0x1833BF650")]
		public void ResetCamera()
		{
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273D")]
		[Address(RVA = "0x33BFBE0", Offset = "0x33BE1E0", VA = "0x1833BFBE0")]
		public void ShowCursor(bool show)
		{
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273E")]
		[Address(RVA = "0x33BFC50", Offset = "0x33BE250", VA = "0x1833BFC50")]
		public void ResetCursor()
		{
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273F")]
		[Address(RVA = "0x33BFD90", Offset = "0x33BE390", VA = "0x1833BFD90")]
		public void FollowPlayerCamera(bool enable)
		{
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002740")]
		[Address(RVA = "0x33BFDA0", Offset = "0x33BE3A0", VA = "0x1833BFDA0")]
		public void PauseCameraMovement(bool pauseCamera)
		{
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002741")]
		[Address(RVA = "0x33BFDB0", Offset = "0x33BE3B0", VA = "0x1833BFDB0")]
		private void Update()
		{
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002742")]
		[Address(RVA = "0x33C01E0", Offset = "0x33BE7E0", VA = "0x1833C01E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002743")]
		[Address(RVA = "0x33C03D0", Offset = "0x33BE9D0", VA = "0x1833C03D0")]
		private void ApplyCameraPan(Vector3 mouseViewportCoords)
		{
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x33C0940", Offset = "0x33BEF40", VA = "0x1833C0940")]
		private void ApplyCameraTilt(Vector3 mouseViewportCoords)
		{
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x33C1360", Offset = "0x33BF960", VA = "0x1833C1360")]
		private void ApplyCameraPivot(Vector3 mouseViewportCoords)
		{
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x33C1B80", Offset = "0x33C0180", VA = "0x1833C1B80")]
		private static Quaternion SmoothDampQuaternion(Quaternion current, Quaternion target, ref Vector3 currentVelocity, float smoothTime)
		{
			return default(Quaternion);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x33C1D00", Offset = "0x33C0300", VA = "0x1833C1D00")]
		public void OnMouseEnterLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002748")]
		[Address(RVA = "0x33C1D60", Offset = "0x33C0360", VA = "0x1833C1D60")]
		public void OnMouseExitLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002749")]
		[Address(RVA = "0x33C1ED0", Offset = "0x33C04D0", VA = "0x1833C1ED0")]
		public void OnMouseOverLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x33C1FF0", Offset = "0x33C05F0", VA = "0x1833C1FF0")]
		public InventoryCameraController()
		{
		}

		// Token: 0x04002350 RID: 9040
		[Token(Token = "0x4002350")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04002351 RID: 9041
		[Token(Token = "0x4002351")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _defaultFieldOfView;

		// Token: 0x04002352 RID: 9042
		[Token(Token = "0x4002352")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _topAnchor;

		// Token: 0x04002353 RID: 9043
		[Token(Token = "0x4002353")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _bottomAnchor;

		// Token: 0x04002354 RID: 9044
		[Token(Token = "0x4002354")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _leftAnchor;

		// Token: 0x04002355 RID: 9045
		[Token(Token = "0x4002355")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _rightAnchor;

		// Token: 0x04002356 RID: 9046
		[Token(Token = "0x4002356")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _panSmoothTime;

		// Token: 0x04002357 RID: 9047
		[Token(Token = "0x4002357")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _panSmoothTimeEdgeMultiplier;

		// Token: 0x04002358 RID: 9048
		[Token(Token = "0x4002358")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _useCurve;

		// Token: 0x04002359 RID: 9049
		[Token(Token = "0x4002359")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _panTarget;

		// Token: 0x0400235A RID: 9050
		[Token(Token = "0x400235A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[FormerlySerializedAs("_panCurve")]
		private AnimationCurve _panXCurve;

		// Token: 0x0400235B RID: 9051
		[Token(Token = "0x400235B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationCurve _panYCurve;

		// Token: 0x0400235C RID: 9052
		[Token(Token = "0x400235C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _useTilt;

		// Token: 0x0400235D RID: 9053
		[Token(Token = "0x400235D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _tiltTarget;

		// Token: 0x0400235E RID: 9054
		[Token(Token = "0x400235E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Vector2 _maxTiltDegrees;

		// Token: 0x0400235F RID: 9055
		[Token(Token = "0x400235F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector2 _maxTiltThreshold;

		// Token: 0x04002360 RID: 9056
		[Token(Token = "0x4002360")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _tiltSmoothTime;

		// Token: 0x04002361 RID: 9057
		[Token(Token = "0x4002361")]
		[FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _tiltSmoothTimeEdgeMultiplier;

		// Token: 0x04002362 RID: 9058
		[Token(Token = "0x4002362")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<BoxCollider> _tiltDeadZones;

		// Token: 0x04002363 RID: 9059
		[Token(Token = "0x4002363")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _usePivot;

		// Token: 0x04002364 RID: 9060
		[Token(Token = "0x4002364")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _pivotTarget;

		// Token: 0x04002365 RID: 9061
		[Token(Token = "0x4002365")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AnimationCurve _pivotCurve;

		// Token: 0x04002366 RID: 9062
		[Token(Token = "0x4002366")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private PathCreator _pivotStrengthSpline;

		// Token: 0x04002367 RID: 9063
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private LayerMask _pivotLayerMask;

		// Token: 0x04002368 RID: 9064
		[Token(Token = "0x4002368")]
		[FieldOffset(Offset = "0xDC")]
		[Range(0f, 180f)]
		[SerializeField]
		private float _maxPivotAngle;

		// Token: 0x04002369 RID: 9065
		[Token(Token = "0x4002369")]
		[FieldOffset(Offset = "0xE0")]
		[Range(0f, 10f)]
		[SerializeField]
		private float _maxPivotAngleRate;

		// Token: 0x0400236A RID: 9066
		[Token(Token = "0x400236A")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _triggerPlayerKneelAtDelta;

		// Token: 0x0400236B RID: 9067
		[Token(Token = "0x400236B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Transform _positionConstraintSource;

		// Token: 0x0400236C RID: 9068
		[Token(Token = "0x400236C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Transform _rotationConstraintSource;

		// Token: 0x0400236D RID: 9069
		[Token(Token = "0x400236D")]
		[FieldOffset(Offset = "0xF8")]
		private float _screenRatio;

		// Token: 0x0400236E RID: 9070
		[Token(Token = "0x400236E")]
		[FieldOffset(Offset = "0xFC")]
		private float _adjustedMaxXTiltDegrees;

		// Token: 0x0400236F RID: 9071
		[Token(Token = "0x400236F")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		public bool _inTiltDeadZone;

		// Token: 0x04002370 RID: 9072
		[Token(Token = "0x4002370")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private InventoryCursorController _inventoryCursorController;

		// Token: 0x04002371 RID: 9073
		[Token(Token = "0x4002371")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Transform _constraintTranfsorm;

		// Token: 0x04002372 RID: 9074
		[Token(Token = "0x4002372")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 _panningVelocity;

		// Token: 0x04002373 RID: 9075
		[Token(Token = "0x4002373")]
		[FieldOffset(Offset = "0x124")]
		private bool _followingPlayerCamera;

		// Token: 0x04002374 RID: 9076
		[Token(Token = "0x4002374")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private float _constraintSmoothTime;

		// Token: 0x04002375 RID: 9077
		[Token(Token = "0x4002375")]
		[FieldOffset(Offset = "0x12C")]
		private bool _cursorMovedThisFrame;

		// Token: 0x04002376 RID: 9078
		[Token(Token = "0x4002376")]
		[FieldOffset(Offset = "0x12D")]
		private bool _cameraMovementIsPaused;

		// Token: 0x04002377 RID: 9079
		[Token(Token = "0x4002377")]
		[FieldOffset(Offset = "0x12E")]
		private bool _isOverItem;

		// Token: 0x04002378 RID: 9080
		[Token(Token = "0x4002378")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 _tiltVelocity;

		// Token: 0x04002379 RID: 9081
		[Token(Token = "0x4002379")]
		[FieldOffset(Offset = "0x13C")]
		private Vector3 _originalCameraEulers;

		// Token: 0x0400237A RID: 9082
		[Token(Token = "0x400237A")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 _previousTiltEuler;

		// Token: 0x0400237B RID: 9083
		[Token(Token = "0x400237B")]
		[FieldOffset(Offset = "0x154")]
		private Vector3 _lastScreenMousePosition;

		// Token: 0x0400237C RID: 9084
		[Token(Token = "0x400237C")]
		[FieldOffset(Offset = "0x160")]
		private Vector3 _currentPivotVelocity;

		// Token: 0x0400237D RID: 9085
		[Token(Token = "0x400237D")]
		[FieldOffset(Offset = "0x170")]
		private LayoutItem _activeLayoutItem;

		// Token: 0x0400237E RID: 9086
		[Token(Token = "0x400237E")]
		[FieldOffset(Offset = "0x178")]
		private PositionConstraint _positionConstraint;

		// Token: 0x0400237F RID: 9087
		[Token(Token = "0x400237F")]
		[FieldOffset(Offset = "0x180")]
		private RotationConstraint _rotationConstraint;

		// Token: 0x04002380 RID: 9088
		[Token(Token = "0x4002380")]
		[FieldOffset(Offset = "0x188")]
		private float _positionConstraintVelocity;

		// Token: 0x04002381 RID: 9089
		[Token(Token = "0x4002381")]
		[FieldOffset(Offset = "0x18C")]
		private float _rotationConstraintVelocity;

		// Token: 0x04002382 RID: 9090
		[Token(Token = "0x4002382")]
		[FieldOffset(Offset = "0x190")]
		private Transform _strengthSplineTransform;
	}
}
