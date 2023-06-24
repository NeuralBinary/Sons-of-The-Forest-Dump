using System;
using Il2CppDummyDll;
using Sons.Utils;
using UnityEngine;

// Token: 0x02000076 RID: 118
[Token(Token = "0x2000076")]
[Serializable]
public class FrostSettingsData
{
	// Token: 0x06000382 RID: 898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x3358F70", Offset = "0x3357570", VA = "0x183358F70")]
	public FrostSettingsData()
	{
	}

	// Token: 0x04000329 RID: 809
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x10")]
	public int StartDay;

	// Token: 0x0400032A RID: 810
	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x14")]
	[Tooltip("Duration standing still at max cold before damage kicks in")]
	public float Duration;

	// Token: 0x0400032B RID: 811
	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("Current time in seconds that player has been standing still at max cold")]
	public float CurrentTimer;

	// Token: 0x0400032C RID: 812
	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x1C")]
	[Tooltip("Total damage per game day")]
	public int Damage;

	// Token: 0x0400032D RID: 813
	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x20")]
	public RandomRange DamageChance;

	// Token: 0x0400032E RID: 814
	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x28")]
	public bool TakingDamage;

	// Token: 0x0400032F RID: 815
	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x2C")]
	[Tooltip("Cold value at which de-frost stops and returns to normal cold routine")]
	public float DeFrostThreshold;

	// Token: 0x04000330 RID: 816
	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Time it takes for full screen frost to fade off after taking cold damage")]
	public float DeFrostDuration;

	// Token: 0x04000331 RID: 817
	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x34")]
	public bool DoDeFrost;

	// Token: 0x04000332 RID: 818
	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x38")]
	[Tooltip("in game day time")]
	public float NextCheckArms;
}
