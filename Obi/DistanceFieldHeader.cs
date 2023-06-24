using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public struct DistanceFieldHeader
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
		public DistanceFieldHeader(int firstNode, int nodeCount)
		{
		}

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x0")]
		public int firstNode;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x4")]
		public int nodeCount;
	}
}
