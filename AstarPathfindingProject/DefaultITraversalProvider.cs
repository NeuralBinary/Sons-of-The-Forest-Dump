using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public static class DefaultITraversalProvider
	{
		// Token: 0x06000442 RID: 1090 RVA: 0x000042A4 File Offset: 0x000024A4
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x670EB0", Offset = "0x66F4B0", VA = "0x180670EB0")]
		public static bool CanTraverse(Path path, GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000042BC File Offset: 0x000024BC
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x670EF0", Offset = "0x66F4F0", VA = "0x180670EF0")]
		public static uint GetTraversalCost(Path path, GraphNode node)
		{
			return 0U;
		}
	}
}
