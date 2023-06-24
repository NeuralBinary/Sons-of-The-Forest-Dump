using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009C RID: 156
[Token(Token = "0x200009C")]
public class BoltHeldItem : EntityBehaviour
{
	// Token: 0x06000550 RID: 1360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x3501620", Offset = "0x34FFC20", VA = "0x183501620")]
	private void OnEnable()
	{
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000551")]
	[Address(RVA = "0x3501690", Offset = "0x34FFC90", VA = "0x183501690")]
	private void OnDisable()
	{
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000552")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public BoltHeldItem()
	{
	}

	// Token: 0x040004EA RID: 1258
	[Token(Token = "0x40004EA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int Id;
}
