using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012E RID: 302
[Token(Token = "0x200012E")]
public class getWalkableSurface : MonoBehaviour
{
	// Token: 0x060008A1 RID: 2209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public getWalkableSurface()
	{
	}

	// Token: 0x040006FE RID: 1790
	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0x20")]
	public float CustomSlopeLimit;

	// Token: 0x040006FF RID: 1791
	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x24")]
	public getWalkableSurface.walkableType _type;

	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	public enum walkableType
	{
		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		slippery,
		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		normal
	}
}
