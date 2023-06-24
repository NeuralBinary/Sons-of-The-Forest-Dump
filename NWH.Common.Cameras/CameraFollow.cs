using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Cameras
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class CameraFollow : VehicleCamera
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x26E4AF0", Offset = "0x26E30F0", VA = "0x1826E4AF0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x26E5340", Offset = "0x26E3940", VA = "0x1826E5340")]
		private void OnEnable()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x26E5350", Offset = "0x26E3950", VA = "0x1826E5350")]
		public CameraFollow()
		{
		}

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 30f)]
		[Tooltip("    Distance at which camera will follow.")]
		public float distance;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		[Tooltip("    Height in relation to the target at which the camera will follow.")]
		public float height;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("    Positional and rotational smoothing of the camera.")]
		public float smoothing;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x34")]
		[Range(-10f, 10f)]
		[Tooltip("    Offset in the forward direction from the target. Use this if you do not want to use camera baits.")]
		public float targetForwardOffset;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x38")]
		[Range(-5f, 5f)]
		[Tooltip("    Offset in the up direction from the target. Use this if you do not want to use camera baits.")]
		public float targetUpOffset;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x3C")]
		private bool firstFrame;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 targetForward;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 targetForwardVelocity;
	}
}
