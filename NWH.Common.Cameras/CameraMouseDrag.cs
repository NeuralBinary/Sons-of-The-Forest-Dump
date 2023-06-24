using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace NWH.Common.Cameras
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class CameraMouseDrag : VehicleCamera
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000001")]
		private bool PointerOverUI
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x26E5460", Offset = "0x26E3A60", VA = "0x1826E5460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x26E5570", Offset = "0x26E3B70", VA = "0x1826E5570", Slot = "4")]
		public override void Awake()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x26E5650", Offset = "0x26E3C50", VA = "0x1826E5650")]
		private void Start()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x26E5690", Offset = "0x26E3C90", VA = "0x1826E5690")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x26E74E0", Offset = "0x26E5AE0", VA = "0x1826E74E0")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x26E7630", Offset = "0x26E5C30", VA = "0x1826E7630")]
		private void OnEnable()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x26E7640", Offset = "0x26E5C40", VA = "0x1826E7640")]
		public float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x26E7690", Offset = "0x26E5C90", VA = "0x1826E7690")]
		public CameraMouseDrag()
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Camera POV type. First person camera will invert controls.\r\nZoom is not available in 1st person.")]
		public CameraMouseDrag.POVType povType;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("    Can the camera be rotated by the user?")]
		public bool allowRotation;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x2D")]
		[Tooltip("    Can the camera be panned by the user?")]
		public bool allowPanning;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("    Distance from target at which camera will be positioned. Might vary depending on smoothing.")]
		[Range(0f, 100f)]
		public float distance;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("    If true the camera will rotate with the vehicle along the X and Y axis.")]
		[FormerlySerializedAs("followTargetsRotation")]
		public bool followTargetPitchAndYaw;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x35")]
		[Tooltip("    If true the camera will rotate with the vehicle along the Z axis.")]
		public bool followTargetRoll;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 100f)]
		[Tooltip("    Maximum distance that will be reached when zooming out.")]
		public float maxDistance;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 100f)]
		[Tooltip("    Minimum distance that will be reached when zooming in.")]
		public float minDistance;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 15f)]
		[Tooltip("    Sensitivity of the middle mouse button / wheel.")]
		public float zoomSensitivity;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("    Smoothing of the camera rotation.")]
		[Range(0f, 1f)]
		public float rotationSmoothing;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("    Maximum vertical angle the camera can achieve.")]
		[Range(-90f, 90f)]
		public float verticalMaxAngle;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("    Minimum vertical angle the camera can achieve.")]
		[Range(-90f, 90f)]
		public float verticalMinAngle;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("    Sensitivity of rotation input.")]
		public Vector2 rotationSensitivity;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("    Sensitivity of panning input.")]
		public Vector2 panningSensitivity;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("    Initial rotation around the X axis (up/down)")]
		public float initXRotation;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("    Initial rotation around the Y axis (left/right)")]
		public float initYRotation;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("    Look position offset from the target center.")]
		public Vector3 targetPositionOffset;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("Should camera movement on acceleration be used?")]
		public bool useShake;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		[Tooltip("    Maximum head movement from the initial position.")]
		public float shakeMaxOffset;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		[Tooltip("    How much will the head move around for the given g-force.")]
		public float shakeIntensity;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		[Tooltip("    Smoothing of the head movement.")]
		public float shakeSmoothing;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x84")]
		[Tooltip("    Movement intensity per axis. Set to 0 to disable movement on that axis or negative to reverse it.")]
		public Vector3 shakeAxisIntensity;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 _lookDir;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 _newLookDir;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 _lookDirVel;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 _camPosVel;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 _lookAtPosition;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xCC")]
		private Vector2 _rot;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 _pan;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xE0")]
		private Quaternion _lookAngle;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xF0")]
		private bool _isFirstFrame;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xF1")]
		private bool _rotationModifier;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0xF2")]
		private bool _panningModifier;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0xF4")]
		private Vector2 _rotationInput;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0xFC")]
		private Vector2 _panningInput;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x104")]
		private float _zoomInput;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x108")]
		private Vector3 _acceleration;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x114")]
		private Vector3 _prevAcceleration;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 _accelerationChangeVelocity;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x12C")]
		private Vector3 _initialPosition;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x138")]
		private Quaternion _initialRotation;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 _localAcceleration;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x154")]
		private Vector3 _newPositionOffset;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x160")]
		private Vector3 _offsetChangeVelocity;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x16C")]
		private Vector3 _positionOffset;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x178")]
		private Vector3 _rollVel;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public enum POVType
		{
			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			FirstPerson,
			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			ThirdPerson
		}
	}
}
