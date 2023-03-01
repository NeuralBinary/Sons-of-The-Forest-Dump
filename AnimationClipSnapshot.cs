using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
[Serializable]
public class AnimationClipSnapshot
{
	// Token: 0x06000017 RID: 23 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0")]
	private int GetClipMax()
	{
		return default(int);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Apply()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
	public AnimationClipSnapshot()
	{
	}

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x10")]
	public AnimationClip _clip;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x18")]
	public int _frame;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x20")]
	private ApplyAnimationPose _holder;
}
