using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F9 RID: 249
[Token(Token = "0x20000F9")]
public class AnimationLoadManager : MonoBehaviour
{
	// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079C")]
	[Address(RVA = "0x367A6E0", Offset = "0x3678CE0", VA = "0x18367A6E0")]
	private void Start()
	{
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600079D")]
	[Address(RVA = "0x367A770", Offset = "0x3678D70", VA = "0x18367A770")]
	private IEnumerator LoadAnimClip(string clipName, string boolName)
	{
		return null;
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x367A870", Offset = "0x3678E70", VA = "0x18367A870")]
	public void LoadAnimation(string animationName, string animationBoolName)
	{
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600079F")]
	[Address(RVA = "0x367AEC0", Offset = "0x36794C0", VA = "0x18367AEC0")]
	public IEnumerator UnloadAnimation(string clipName, bool refreshAssets)
	{
		return null;
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public AnimationLoadManager()
	{
	}

	// Token: 0x04000616 RID: 1558
	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x20")]
	private Animator animator;

	// Token: 0x04000617 RID: 1559
	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x28")]
	private AnimatorStateInfo[] layerInfo;

	// Token: 0x04000618 RID: 1560
	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x30")]
	private float[] layerWeights;

	// Token: 0x04000619 RID: 1561
	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x38")]
	private bool flashLightHeld;

	// Token: 0x0400061A RID: 1562
	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x39")]
	private bool lighterHeld;

	// Token: 0x0400061B RID: 1563
	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0x3A")]
	private bool pedHeld;
}
