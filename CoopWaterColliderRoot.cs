using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D9 RID: 217
[Token(Token = "0x20000D9")]
public class CoopWaterColliderRoot : MonoBehaviour
{
	// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000661")]
	[Address(RVA = "0x2E83310", Offset = "0x2E82310", VA = "0x182E83310")]
	private void Awake()
	{
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000662")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public CoopWaterColliderRoot()
	{
	}

	// Token: 0x04000569 RID: 1385
	[Token(Token = "0x4000569")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CoopWaterCollider[] _all;

	// Token: 0x0400056A RID: 1386
	[Token(Token = "0x400056A")]
	[FieldOffset(Offset = "0x0")]
	public static CoopWaterCollider[] All;
}
