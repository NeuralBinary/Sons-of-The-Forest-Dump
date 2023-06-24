using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public class RecastBBTreeBox
	{
		// Token: 0x06000750 RID: 1872 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x6BB3C0", Offset = "0x6B99C0", VA = "0x1806BB3C0")]
		public RecastBBTreeBox(RecastMeshObj mesh)
		{
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000057A4 File Offset: 0x000039A4
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x6BB4A0", Offset = "0x6B9AA0", VA = "0x1806BB4A0")]
		public bool Contains(Vector3 p)
		{
			return default(bool);
		}

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x10")]
		public Rect rect;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x20")]
		public RecastMeshObj mesh;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x28")]
		public RecastBBTreeBox c1;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x30")]
		public RecastBBTreeBox c2;
	}
}
