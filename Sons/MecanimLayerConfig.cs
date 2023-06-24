using System;
using Il2CppDummyDll;

// Token: 0x0200006F RID: 111
[Token(Token = "0x200006F")]
[Serializable]
public class MecanimLayerConfig
{
	// Token: 0x06000373 RID: 883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000373")]
	[Address(RVA = "0x31CB2A0", Offset = "0x31C98A0", VA = "0x1831CB2A0")]
	public void ResetValues()
	{
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000374")]
	[Address(RVA = "0x31CB2B0", Offset = "0x31C98B0", VA = "0x1831CB2B0")]
	public MecanimLayerConfig()
	{
	}

	// Token: 0x040002FE RID: 766
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x18")]
	public bool SyncWeight;

	// Token: 0x04000300 RID: 768
	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x1C")]
	public float TransitionTime;

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public float NormalizedTime;

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x24")]
	[NonSerialized]
	public float Weight;

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public int Hash;

	// Token: 0x04000304 RID: 772
	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x2C")]
	[NonSerialized]
	public int Hash_Recv;

	// Token: 0x04000305 RID: 773
	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x30")]
	[NonSerialized]
	public int LayerIndex;

	// Token: 0x04000306 RID: 774
	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x34")]
	[NonSerialized]
	public int ArrayIndex;
}
