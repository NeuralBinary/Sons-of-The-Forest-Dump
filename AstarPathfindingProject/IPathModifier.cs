using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public interface IPathModifier
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600078F RID: 1935
		[Token(Token = "0x1700012E")]
		int Order { [Token(Token = "0x600078F")] get; }

		// Token: 0x06000790 RID: 1936
		[Token(Token = "0x6000790")]
		void Apply(Path path);

		// Token: 0x06000791 RID: 1937
		[Token(Token = "0x6000791")]
		void PreProcess(Path path);
	}
}
