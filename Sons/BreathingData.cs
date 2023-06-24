using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000073 RID: 115
[Token(Token = "0x2000073")]
[Serializable]
public class BreathingData
{
	// Token: 0x1700008D RID: 141
	// (get) Token: 0x0600037D RID: 893 RVA: 0x00003108 File Offset: 0x00001308
	[Token(Token = "0x1700008D")]
	public float MaxLungAirCapacityFinal
	{
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x31CBEC0", Offset = "0x31CA4C0", VA = "0x1831CBEC0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x0600037E RID: 894 RVA: 0x00003120 File Offset: 0x00001320
	[Token(Token = "0x1700008E")]
	public float CurrentAirPercent
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x31CBF40", Offset = "0x31CA540", VA = "0x1831CBF40")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037F")]
	[Address(RVA = "0x31CBF70", Offset = "0x31CA570", VA = "0x1831CBF70")]
	public BreathingData()
	{
	}

	// Token: 0x04000316 RID: 790
	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x10")]
	[Tooltip("In real life seconds")]
	public float MaxLungAirCapacity;

	// Token: 0x04000317 RID: 791
	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x14")]
	[Tooltip("In real life seconds")]
	public float CurrentLungAir;

	// Token: 0x04000318 RID: 792
	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("In real life seconds")]
	public float MaxRebreatherAirCapacity;

	// Token: 0x04000319 RID: 793
	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x1C")]
	[Tooltip("In real life seconds")]
	public float CurrentRebreatherAir;

	// Token: 0x0400031A RID: 794
	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("UseRebreather")]
	public bool RebreatherIsActive;

	// Token: 0x0400031B RID: 795
	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x24")]
	[Tooltip("In real life seconds")]
	public float OutOfAirWarningThreshold;
}
