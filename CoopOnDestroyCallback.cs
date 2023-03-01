using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C4 RID: 196
[Token(Token = "0x20000C4")]
public class CoopOnDestroyCallback : MonoBehaviour
{
	// Token: 0x060005FC RID: 1532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x28CD580", Offset = "0x28CC580", VA = "0x1828CD580")]
	private void OnDestroy()
	{
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public CoopOnDestroyCallback()
	{
	}

	// Token: 0x04000539 RID: 1337
	[Token(Token = "0x4000539")]
	[FieldOffset(Offset = "0x20")]
	public Action Callback;
}
