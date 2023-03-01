using System;
using Il2CppDummyDll;
using Sons.Utils;
using UnityEngine;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000077")]
[Serializable]
public class FrostSettingsData
{
	// Token: 0x06000377 RID: 887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000377")]
	[Address(RVA = "0x2B6DAE0", Offset = "0x2B6CAE0", VA = "0x182B6DAE0")]
	public FrostSettingsData()
	{
	}

	// Token: 0x0400031B RID: 795
	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x10")]
	public int StartDay;

	// Token: 0x0400031C RID: 796
	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x14")]
	[Tooltip("Duration standing still at max cold before damage kicks in")]
	public float Duration;

	// Token: 0x0400031D RID: 797
	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("Current time in seconds that player has been standing still at max cold")]
	public float CurrentTimer;

	// Token: 0x0400031E RID: 798
	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x1C")]
	[Tooltip("Total damage per game day")]
	public int Damage;

	// Token: 0x0400031F RID: 799
	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x20")]
	public RandomRange DamageChance;

	// Token: 0x04000320 RID: 800
	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x28")]
	public bool TakingDamage;

	// Token: 0x04000321 RID: 801
	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x2C")]
	[Tooltip("Cold value at which de-frost stops and returns to normal cold routine")]
	public float DeFrostThreshold;

	// Token: 0x04000322 RID: 802
	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Time it takes for full screen frost to fade off after taking cold damage")]
	public float DeFrostDuration;

	// Token: 0x04000323 RID: 803
	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x34")]
	public bool DoDeFrost;

	// Token: 0x04000324 RID: 804
	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x38")]
	[Tooltip("in game day time")]
	public float NextCheckArms;
}
