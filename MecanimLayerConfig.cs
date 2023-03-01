using System;
using Il2CppDummyDll;

// Token: 0x02000071 RID: 113
[Token(Token = "0x2000071")]
[Serializable]
public class MecanimLayerConfig
{
	// Token: 0x0600036D RID: 877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036D")]
	[Address(RVA = "0x2B6F2E0", Offset = "0x2B6E2E0", VA = "0x182B6F2E0")]
	public void ResetValues()
	{
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036E")]
	[Address(RVA = "0x2B6F2F0", Offset = "0x2B6E2F0", VA = "0x182B6F2F0")]
	public MecanimLayerConfig()
	{
	}

	// Token: 0x040002F7 RID: 759
	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	// Token: 0x040002F8 RID: 760
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x18")]
	public bool SyncWeight;

	// Token: 0x040002F9 RID: 761
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x1C")]
	public float TransitionTime;

	// Token: 0x040002FA RID: 762
	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public float NormalizedTime;

	// Token: 0x040002FB RID: 763
	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x24")]
	[NonSerialized]
	public float Weight;

	// Token: 0x040002FC RID: 764
	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public int Hash;

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x2C")]
	[NonSerialized]
	public int Hash_Recv;

	// Token: 0x040002FE RID: 766
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x30")]
	[NonSerialized]
	public int LayerIndex;

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x34")]
	[NonSerialized]
	public int ArrayIndex;
}
