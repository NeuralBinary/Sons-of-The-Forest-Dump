using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012B RID: 299
[Token(Token = "0x200012B")]
public class getWalkableSurface : MonoBehaviour
{
	// Token: 0x060008E8 RID: 2280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public getWalkableSurface()
	{
	}

	// Token: 0x0400071A RID: 1818
	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x20")]
	public float CustomSlopeLimit;

	// Token: 0x0400071B RID: 1819
	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x24")]
	public getWalkableSurface.walkableType _type;

	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	public enum walkableType
	{
		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		slippery,
		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		normal
	}
}
