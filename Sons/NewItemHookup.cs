using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005E RID: 94
[Token(Token = "0x200005E")]
public class NewItemHookup : MonoBehaviour
{
	// Token: 0x060002AC RID: 684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public NewItemHookup()
	{
	}

	// Token: 0x040002A0 RID: 672
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x20")]
	public Transform NewItemParent;

	// Token: 0x040002A1 RID: 673
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x28")]
	public Transform AlternateItemParent;
}
