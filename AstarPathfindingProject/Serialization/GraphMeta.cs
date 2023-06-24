using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Serialization
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	public class GraphMeta
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x704CA0", Offset = "0x7032A0", VA = "0x180704CA0")]
		public Type GetGraphType(int index, Type[] availableGraphTypes)
		{
			return null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public GraphMeta()
		{
		}

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x10")]
		public Version version;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x18")]
		public int graphs;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x20")]
		public List<string> guids;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x28")]
		public List<string> typeNames;
	}
}
