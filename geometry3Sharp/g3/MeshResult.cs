using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200021A RID: 538
	[Token(Token = "0x200021A")]
	public enum MeshResult
	{
		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		Ok,
		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		Failed_NotAVertex,
		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		Failed_NotATriangle,
		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		Failed_NotAnEdge,
		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		Failed_BrokenTopology = 10,
		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		Failed_HitValenceLimit,
		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		Failed_IsBoundaryEdge = 20,
		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		Failed_FlippedEdgeExists,
		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		Failed_IsBowtieVertex,
		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		Failed_InvalidNeighbourhood,
		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		Failed_FoundDuplicateTriangle,
		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		Failed_CollapseTetrahedron,
		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		Failed_CollapseTriangle,
		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		Failed_NotABoundaryEdge,
		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		Failed_SameOrientation,
		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		Failed_WouldCreateBowtie = 30,
		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		Failed_VertexAlreadyExists,
		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		Failed_CannotAllocateVertex,
		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		Failed_WouldCreateNonmanifoldEdge = 50,
		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		Failed_TriangleAlreadyExists,
		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		Failed_CannotAllocateTriangle
	}
}
