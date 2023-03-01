using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
public class NewItemHookup : MonoBehaviour
{
	// Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public NewItemHookup()
	{
	}

	// Token: 0x0400029E RID: 670
	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x20")]
	public Transform NewItemParent;

	// Token: 0x0400029F RID: 671
	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x28")]
	public Transform AlternateItemParent;
}
