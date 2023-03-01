using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000257 RID: 599
[Token(Token = "0x2000257")]
public class SetSaveGame : MonoBehaviour
{
	// Token: 0x0600105B RID: 4187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105B")]
	[Address(RVA = "0x2FB89E0", Offset = "0x2FB79E0", VA = "0x182FB89E0")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x2FB8A50", Offset = "0x2FB7A50", VA = "0x182FB8A50")]
	public SetSaveGame()
	{
	}

	// Token: 0x04000F6C RID: 3948
	[Token(Token = "0x4000F6C")]
	[FieldOffset(Offset = "0x20")]
	public int Current;

	// Token: 0x04000F6D RID: 3949
	[Token(Token = "0x4000F6D")]
	[FieldOffset(Offset = "0x24")]
	public int MinVersion;
}
