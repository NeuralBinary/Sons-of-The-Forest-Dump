using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E9 RID: 489
[Token(Token = "0x20001E9")]
public class DestroyWall : MonoBehaviour
{
	// Token: 0x06000DF0 RID: 3568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x370FBE0", Offset = "0x370E1E0", VA = "0x18370FBE0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public DestroyWall()
	{
	}

	// Token: 0x04000CEE RID: 3310
	[Token(Token = "0x4000CEE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NormalWall;

	// Token: 0x04000CEF RID: 3311
	[Token(Token = "0x4000CEF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DynamicWall;
}
