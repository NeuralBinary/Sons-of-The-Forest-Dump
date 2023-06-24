using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gameplay.ZipLines;
using UnityEngine;

// Token: 0x0200005B RID: 91
[Token(Token = "0x200005B")]
public class ZiplineDaisyChainGenerator : MonoBehaviour
{
	// Token: 0x0600029C RID: 668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x31B44D0", Offset = "0x31B2AD0", VA = "0x1831B44D0")]
	private void Generate()
	{
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029D")]
	[Address(RVA = "0x31B4C00", Offset = "0x31B3200", VA = "0x1831B4C00")]
	public ZiplineDaisyChainGenerator()
	{
	}

	// Token: 0x0400028B RID: 651
	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> _connectionNodes;

	// Token: 0x0400028C RID: 652
	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<ZipLineController> _zipLineControllers;
}
