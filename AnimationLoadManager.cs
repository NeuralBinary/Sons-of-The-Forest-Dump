using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000FC RID: 252
[Token(Token = "0x20000FC")]
public class AnimationLoadManager : MonoBehaviour
{
	// Token: 0x06000754 RID: 1876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000754")]
	[Address(RVA = "0x2F28D10", Offset = "0x2F27D10", VA = "0x182F28D10")]
	private void Start()
	{
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000755")]
	[Address(RVA = "0x2F28990", Offset = "0x2F27990", VA = "0x182F28990")]
	private IEnumerator LoadAnimClip(string clipName, string boolName)
	{
		return null;
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000756")]
	[Address(RVA = "0x2F28A20", Offset = "0x2F27A20", VA = "0x182F28A20")]
	public void LoadAnimation(string animationName, string animationBoolName)
	{
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000757")]
	[Address(RVA = "0x2F28D60", Offset = "0x2F27D60", VA = "0x182F28D60")]
	public IEnumerator UnloadAnimation(string clipName, bool refreshAssets)
	{
		return null;
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000758")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public AnimationLoadManager()
	{
	}

	// Token: 0x040005F9 RID: 1529
	[Token(Token = "0x40005F9")]
	[FieldOffset(Offset = "0x20")]
	private Animator animator;

	// Token: 0x040005FA RID: 1530
	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x28")]
	private AnimatorStateInfo[] layerInfo;

	// Token: 0x040005FB RID: 1531
	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x30")]
	private float[] layerWeights;

	// Token: 0x040005FC RID: 1532
	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x38")]
	private bool flashLightHeld;

	// Token: 0x040005FD RID: 1533
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x39")]
	private bool lighterHeld;

	// Token: 0x040005FE RID: 1534
	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x3A")]
	private bool pedHeld;
}
