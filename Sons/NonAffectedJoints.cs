using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000200 RID: 512
[Token(Token = "0x2000200")]
[Serializable]
public class NonAffectedJoints
{
	// Token: 0x06000E38 RID: 3640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public NonAffectedJoints()
	{
	}

	// Token: 0x04000D2A RID: 3370
	[Token(Token = "0x4000D2A")]
	[FieldOffset(Offset = "0x10")]
	public Transform joint;

	// Token: 0x04000D2B RID: 3371
	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0x18")]
	public float effect;
}
