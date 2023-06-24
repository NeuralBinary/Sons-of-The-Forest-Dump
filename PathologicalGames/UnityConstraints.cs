using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
[AddComponentMenu("")]
public static class UnityConstraints
{
	// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x28B3960", Offset = "0x28B1F60", VA = "0x1828B3960")]
	public static void InterpolateRotationTo(Transform xform, Quaternion targetRot, UnityConstraints.INTERP_OPTIONS interpolation, float speed)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x28B3C50", Offset = "0x28B2250", VA = "0x1828B3C50")]
	public static void MaskOutputRotations(Transform xform, UnityConstraints.OUTPUT_ROT_OPTIONS option)
	{
	}

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x0")]
	private static float lastRealtimeSinceStartup;

	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public enum MODE_OPTIONS
	{
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		Align,
		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		Constrain
	}

	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public enum NO_TARGET_OPTIONS
	{
		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		Error,
		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		DoNothing,
		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		ReturnToDefault,
		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		SetByScript
	}

	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public enum INTERP_OPTIONS
	{
		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		Linear,
		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		Spherical,
		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		SphericalLimited
	}

	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public enum OUTPUT_ROT_OPTIONS
	{
		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		WorldAll,
		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		WorldX,
		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		WorldY,
		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		WorldZ,
		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		LocalX,
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		LocalY,
		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		LocalZ
	}
}
