using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[CreateAssetMenu(menuName = "Sons/VFX/Beach Wave Settings")]
public class BeachWaveVFXSettings : ScriptableObject
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
	public BeachWaveVFXSettings()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public bool _loop;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve _wetnessDecalBlurredAlpha;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve _wetnessDecalBlurredPosX;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve _wetnessDecalBlurredWidth;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve _wetnessDecalBlurredHeight;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve _wetnessDecalSharpAlpha;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve _wetnessDecalSharpPosX;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve _wetnessDecalSharpWidth;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve _wetnessDecalSharpHeight;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve _foamDecalsAlpha;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve _foamDecalsPosX;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve _foamDecalsWidth;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve _foamDecalsHeight;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve _displacementGameObjectsPosX;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x88")]
	public AnimationCurve _displacementGameObjectsPosY;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve _displacementGameObjectsScaleY;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x98")]
	public AnimationCurve _foamVATsAlpha;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0xA0")]
	public AnimationCurve _foamVATsPosX;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0xA8")]
	public AnimationCurve _particlesPosX;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0xB0")]
	public float _totalTime;
}
