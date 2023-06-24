using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000070 RID: 112
[Token(Token = "0x2000070")]
[Serializable]
public class MecanimStateOverride
{
	// Token: 0x06000375 RID: 885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000375")]
	[Address(RVA = "0x31CB340", Offset = "0x31C9940", VA = "0x1831CB340")]
	public void OnValidate()
	{
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000376")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public MecanimStateOverride()
	{
	}

	// Token: 0x04000307 RID: 775
	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x10")]
	public int Layer;

	// Token: 0x04000308 RID: 776
	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("SourceStateName")]
	private string _sourceStateName;

	// Token: 0x04000309 RID: 777
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("OverrideStateName")]
	private string _overrideStateName;

	// Token: 0x0400030A RID: 778
	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int SourceStateHash;

	// Token: 0x0400030B RID: 779
	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int OverrideStateHash;
}
