using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedTerrainGrass
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Serializable]
	public class GrassCell
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x59FA80", Offset = "0x59E080", VA = "0x18059FA80")]
		public GrassCell()
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		public int state;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x14")]
		public int index;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Center;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x28")]
		public List<int> CellContentIndexes;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		public int CellContentCount;
	}
}
