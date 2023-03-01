using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000074 RID: 116
[Token(Token = "0x2000074")]
[Serializable]
public class BreathingData
{
	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000372 RID: 882 RVA: 0x00003030 File Offset: 0x00001230
	[Token(Token = "0x1700008B")]
	public float MaxLungAirCapacityFinal
	{
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2B60360", Offset = "0x2B5F360", VA = "0x182B60360")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000373 RID: 883 RVA: 0x00003048 File Offset: 0x00001248
	[Token(Token = "0x1700008C")]
	public float CurrentAirPercent
	{
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2B60330", Offset = "0x2B5F330", VA = "0x182B60330")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000374")]
	[Address(RVA = "0x2B60300", Offset = "0x2B5F300", VA = "0x182B60300")]
	public BreathingData()
	{
	}

	// Token: 0x04000308 RID: 776
	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x10")]
	[Tooltip("In real life seconds")]
	public float MaxLungAirCapacity;

	// Token: 0x04000309 RID: 777
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x14")]
	[Tooltip("In real life seconds")]
	public float CurrentLungAir;

	// Token: 0x0400030A RID: 778
	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("In real life seconds")]
	public float MaxRebreatherAirCapacity;

	// Token: 0x0400030B RID: 779
	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x1C")]
	[Tooltip("In real life seconds")]
	public float CurrentRebreatherAir;

	// Token: 0x0400030C RID: 780
	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("UseRebreather")]
	public bool RebreatherIsActive;

	// Token: 0x0400030D RID: 781
	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x24")]
	[Tooltip("In real life seconds")]
	public float OutOfAirWarningThreshold;
}
