using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
[Serializable]
public class MecanimStateOverride
{
	// Token: 0x0600036F RID: 879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036F")]
	[Address(RVA = "0x2B6F350", Offset = "0x2B6E350", VA = "0x182B6F350")]
	public void OnValidate()
	{
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000370")]
	[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
	public MecanimStateOverride()
	{
	}

	// Token: 0x04000300 RID: 768
	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x10")]
	public int Layer;

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("SourceStateName")]
	private string _sourceStateName;

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("OverrideStateName")]
	private string _overrideStateName;

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int SourceStateHash;

	// Token: 0x04000304 RID: 772
	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int OverrideStateHash;
}
