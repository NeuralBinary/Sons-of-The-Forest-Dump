using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	public class ObiHeightFieldContainer
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x27D1200", Offset = "0x27CF800", VA = "0x1827D1200")]
		public ObiHeightFieldContainer()
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x27D13C0", Offset = "0x27CF9C0", VA = "0x1827D13C0")]
		public ObiHeightFieldHandle GetOrCreateHeightField(TerrainData source)
		{
			return null;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x27D1710", Offset = "0x27CFD10", VA = "0x1827D1710")]
		public void DestroyHeightField(ObiHeightFieldHandle handle)
		{
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x27D1A70", Offset = "0x27D0070", VA = "0x1827D1A70")]
		public void Dispose()
		{
		}

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<TerrainData, ObiHeightFieldHandle> handles;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x18")]
		public ObiNativeHeightFieldHeaderList headers;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x20")]
		public ObiNativeFloatList samples;
	}
}
