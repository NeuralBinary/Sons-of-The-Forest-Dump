using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class FlightPathParams
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2D1D7C0", Offset = "0x2D1BDC0", VA = "0x182D1D7C0")]
		public FlightPathParams()
		{
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		public float StopMinDistance;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x14")]
		public float CircleRadius;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18")]
		public float MinOffsetY;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x1C")]
		public float MaxOffsetY;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		public float RandomRadiusXZ;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x24")]
		public float MaxYawDelta;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x28")]
		public float MinDistance;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x2C")]
		public float MaxDistance;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x30")]
		public float MaxPitch;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 NumCircles;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x3C")]
		public bool SnapEndToGround;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x3D")]
		public bool RaycastVerify;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x3E")]
		public bool IgnorePathBounds;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x40")]
		public Action CompletedCallback;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x48")]
		public Action InterruptedCallback;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x50")]
		public bool RandomLandPoint;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x51")]
		public bool IsSwoop;
	}
}
