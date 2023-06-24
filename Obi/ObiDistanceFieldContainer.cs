using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	public class ObiDistanceFieldContainer
	{
		// Token: 0x060006F6 RID: 1782 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x27CF5D0", Offset = "0x27CDBD0", VA = "0x1827CF5D0")]
		public ObiDistanceFieldContainer()
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x27CF790", Offset = "0x27CDD90", VA = "0x1827CF790")]
		public ObiDistanceFieldHandle GetOrCreateDistanceField(ObiDistanceField source)
		{
			return null;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x27CF980", Offset = "0x27CDF80", VA = "0x1827CF980")]
		public void DestroyDistanceField(ObiDistanceFieldHandle handle)
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x27CFCE0", Offset = "0x27CE2E0", VA = "0x1827CFCE0")]
		public void Dispose()
		{
		}

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<ObiDistanceField, ObiDistanceFieldHandle> handles;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x18")]
		public ObiNativeDistanceFieldHeaderList headers;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x20")]
		public ObiNativeDFNodeList dfNodes;
	}
}
