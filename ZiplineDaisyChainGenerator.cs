using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gameplay.ZipLines;
using UnityEngine;

// Token: 0x0200005A RID: 90
[Token(Token = "0x200005A")]
public class ZiplineDaisyChainGenerator : MonoBehaviour
{
	// Token: 0x0600027F RID: 639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x2B820C0", Offset = "0x2B810C0", VA = "0x182B820C0")]
	private void Generate()
	{
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x2B826D0", Offset = "0x2B816D0", VA = "0x182B826D0")]
	public ZiplineDaisyChainGenerator()
	{
	}

	// Token: 0x0400025F RID: 607
	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> _connectionNodes;

	// Token: 0x04000260 RID: 608
	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<ZipLineController> _zipLineControllers;
}
