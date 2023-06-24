using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class BFX_BloodSettings : MonoBehaviour
{
	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x4B07310", Offset = "0x4B05910", VA = "0x184B07310")]
	public BFX_BloodSettings()
	{
	}

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	public float AnimationSpeed;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x24")]
	public float GroundHeight;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	public float LightIntensityMultiplier;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x2C")]
	public bool FreezeDecalDisappearance;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x30")]
	public BFX_BloodSettings._DecalRenderinMode DecalRenderinMode;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x34")]
	public bool ClampDecalSideSurface;

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public enum _DecalRenderinMode
	{
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		Floor_XZ,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		AverageRayBetwenForwardAndFloor
	}
}
