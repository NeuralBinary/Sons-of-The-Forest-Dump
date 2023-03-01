using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200024B RID: 587
[Token(Token = "0x200024B")]
public class RainTypes : MonoBehaviour
{
	// Token: 0x0600101F RID: 4127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x2FB6FE0", Offset = "0x2FB5FE0", VA = "0x182FB6FE0")]
	private void OnValidate()
	{
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00005E20 File Offset: 0x00004020
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x2FB6CE0", Offset = "0x2FB5CE0", VA = "0x182FB6CE0")]
	public bool AllDisabled()
	{
		return default(bool);
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001021")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public RainTypes()
	{
	}

	// Token: 0x04000F2F RID: 3887
	[Token(Token = "0x4000F2F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CaveFilter;

	// Token: 0x04000F30 RID: 3888
	[Token(Token = "0x4000F30")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BlockTrigger;

	// Token: 0x04000F31 RID: 3889
	[Token(Token = "0x4000F31")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("RainHeavy")]
	[HideInInspector]
	public GameObject RainHeavyOld;

	// Token: 0x04000F32 RID: 3890
	[Token(Token = "0x4000F32")]
	[FieldOffset(Offset = "0x38")]
	public RainEffectController RainHeavy;

	// Token: 0x04000F33 RID: 3891
	[Token(Token = "0x4000F33")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	[FormerlySerializedAs("RainMedium")]
	public GameObject RainMediumOld;

	// Token: 0x04000F34 RID: 3892
	[Token(Token = "0x4000F34")]
	[FieldOffset(Offset = "0x48")]
	public RainEffectController RainMedium;

	// Token: 0x04000F35 RID: 3893
	[Token(Token = "0x4000F35")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	[FormerlySerializedAs("RainLight")]
	public GameObject RainLightOld;

	// Token: 0x04000F36 RID: 3894
	[Token(Token = "0x4000F36")]
	[FieldOffset(Offset = "0x58")]
	public RainEffectController RainLight;

	// Token: 0x04000F37 RID: 3895
	[Token(Token = "0x4000F37")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	[FormerlySerializedAs("SnowHeavy")]
	public GameObject SnowHeavyOld;

	// Token: 0x04000F38 RID: 3896
	[Token(Token = "0x4000F38")]
	[FieldOffset(Offset = "0x68")]
	public RainEffectController SnowHeavy;

	// Token: 0x04000F39 RID: 3897
	[Token(Token = "0x4000F39")]
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("SnowMedium")]
	[HideInInspector]
	public GameObject SnowMediumOld;

	// Token: 0x04000F3A RID: 3898
	[Token(Token = "0x4000F3A")]
	[FieldOffset(Offset = "0x78")]
	public RainEffectController SnowMedium;

	// Token: 0x04000F3B RID: 3899
	[Token(Token = "0x4000F3B")]
	[FieldOffset(Offset = "0x80")]
	[HideInInspector]
	[FormerlySerializedAs("SnowLight")]
	public GameObject SnowLightOld;

	// Token: 0x04000F3C RID: 3900
	[Token(Token = "0x4000F3C")]
	[FieldOffset(Offset = "0x88")]
	public RainEffectController SnowLight;

	// Token: 0x04000F3D RID: 3901
	[Token(Token = "0x4000F3D")]
	[FieldOffset(Offset = "0x90")]
	public GameObject SnowConstant;

	// Token: 0x04000F3E RID: 3902
	[Token(Token = "0x4000F3E")]
	[FieldOffset(Offset = "0x98")]
	public GameObject CausticLight;
}
