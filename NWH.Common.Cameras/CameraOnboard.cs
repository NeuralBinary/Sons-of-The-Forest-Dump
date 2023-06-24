using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace NWH.Common.Cameras
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class CameraOnboard : VehicleCamera
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x26E78F0", Offset = "0x26E5EF0", VA = "0x1826E78F0", Slot = "4")]
		public override void Awake()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x26E7B00", Offset = "0x26E6100", VA = "0x1826E7B00")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x26E8260", Offset = "0x26E6860", VA = "0x1826E8260")]
		public CameraOnboard()
		{
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("maxPositionOffsetMagnitude")]
		[Tooltip("    Maximum head movement from the initial position.")]
		[Range(0f, 1f)]
		public float maxMovementOffset;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("    How much will the head move around for the given g-force.")]
		[Range(0f, 1f)]
		[FormerlySerializedAs("positionIntensity")]
		public float movementIntensity;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("positionSmoothing")]
		[Range(0f, 1f)]
		[Tooltip("    Smoothing of the head movement.")]
		public float movementSmoothing;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("    Movement intensity per axis. Set to 0 to disable movement on that axis or negative to reverse it.")]
		public Vector3 axisIntensity;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _acceleration;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 _prevAcceleration;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _accelerationChangeVelocity;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _initialPosition;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 _localAcceleration;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 _newPositionOffset;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 _offsetChangeVelocity;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 _positionOffset;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0xA0")]
		private Transform _targetTransform;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xA8")]
		private bool _firstFrame;
	}
}
