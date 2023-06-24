using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	public class ObiEdgeMeshContainer
	{
		// Token: 0x060006FE RID: 1790 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x27CFF20", Offset = "0x27CE520", VA = "0x1827CFF20")]
		public ObiEdgeMeshContainer()
		{
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x27D01D0", Offset = "0x27CE7D0", VA = "0x1827D01D0")]
		public ObiEdgeMeshHandle GetOrCreateEdgeMesh(EdgeCollider2D source)
		{
			return null;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x27D0B60", Offset = "0x27CF160", VA = "0x1827D0B60")]
		public void DestroyEdgeMesh(ObiEdgeMeshHandle handle)
		{
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x27D0FB0", Offset = "0x27CF5B0", VA = "0x1827D0FB0")]
		public void Dispose()
		{
		}

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<EdgeCollider2D, ObiEdgeMeshHandle> handles;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x18")]
		public ObiNativeEdgeMeshHeaderList headers;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x20")]
		public ObiNativeBIHNodeList bihNodes;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x28")]
		public ObiNativeEdgeList edges;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x30")]
		public ObiNativeVector2List vertices;
	}
}
