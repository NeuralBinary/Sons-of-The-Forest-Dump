using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
[Serializable]
public class JSONGreebleData
{
	// Token: 0x0600000C RID: 12 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public JSONGreebleData()
	{
	}

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x10")]
	public string[] prefabGuids;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x18")]
	public Vector3[] positions;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x20")]
	public Vector3[] scales;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x28")]
	public Quaternion[] rotations;
}
