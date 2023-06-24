using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000248 RID: 584
[Token(Token = "0x2000248")]
public class RainTypes : MonoBehaviour
{
	// Token: 0x06001075 RID: 4213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001075")]
	[Address(RVA = "0x3739460", Offset = "0x3737A60", VA = "0x183739460")]
	private void OnValidate()
	{
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x000060A8 File Offset: 0x000042A8
	[Token(Token = "0x6001076")]
	[Address(RVA = "0x3739A80", Offset = "0x3738080", VA = "0x183739A80")]
	public bool AllDisabled()
	{
		return default(bool);
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public RainTypes()
	{
	}

	// Token: 0x04000F5A RID: 3930
	[Token(Token = "0x4000F5A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CaveFilter;

	// Token: 0x04000F5B RID: 3931
	[Token(Token = "0x4000F5B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BlockTrigger;

	// Token: 0x04000F5C RID: 3932
	[Token(Token = "0x4000F5C")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("RainHeavy")]
	[HideInInspector]
	public GameObject RainHeavyOld;

	// Token: 0x04000F5D RID: 3933
	[Token(Token = "0x4000F5D")]
	[FieldOffset(Offset = "0x38")]
	public RainEffectController RainHeavy;

	// Token: 0x04000F5E RID: 3934
	[Token(Token = "0x4000F5E")]
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("RainMedium")]
	[HideInInspector]
	public GameObject RainMediumOld;

	// Token: 0x04000F5F RID: 3935
	[Token(Token = "0x4000F5F")]
	[FieldOffset(Offset = "0x48")]
	public RainEffectController RainMedium;

	// Token: 0x04000F60 RID: 3936
	[Token(Token = "0x4000F60")]
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("RainLight")]
	[HideInInspector]
	public GameObject RainLightOld;

	// Token: 0x04000F61 RID: 3937
	[Token(Token = "0x4000F61")]
	[FieldOffset(Offset = "0x58")]
	public RainEffectController RainLight;

	// Token: 0x04000F62 RID: 3938
	[Token(Token = "0x4000F62")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	[FormerlySerializedAs("SnowHeavy")]
	public GameObject SnowHeavyOld;

	// Token: 0x04000F63 RID: 3939
	[Token(Token = "0x4000F63")]
	[FieldOffset(Offset = "0x68")]
	public RainEffectController SnowHeavy;

	// Token: 0x04000F64 RID: 3940
	[Token(Token = "0x4000F64")]
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("SnowMedium")]
	[HideInInspector]
	public GameObject SnowMediumOld;

	// Token: 0x04000F65 RID: 3941
	[Token(Token = "0x4000F65")]
	[FieldOffset(Offset = "0x78")]
	public RainEffectController SnowMedium;

	// Token: 0x04000F66 RID: 3942
	[Token(Token = "0x4000F66")]
	[FieldOffset(Offset = "0x80")]
	[HideInInspector]
	[FormerlySerializedAs("SnowLight")]
	public GameObject SnowLightOld;

	// Token: 0x04000F67 RID: 3943
	[Token(Token = "0x4000F67")]
	[FieldOffset(Offset = "0x88")]
	public RainEffectController SnowLight;

	// Token: 0x04000F68 RID: 3944
	[Token(Token = "0x4000F68")]
	[FieldOffset(Offset = "0x90")]
	public GameObject SnowConstant;

	// Token: 0x04000F69 RID: 3945
	[Token(Token = "0x4000F69")]
	[FieldOffset(Offset = "0x98")]
	public GameObject CausticLight;
}
