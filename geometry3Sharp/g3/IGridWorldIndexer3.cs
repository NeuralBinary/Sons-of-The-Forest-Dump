using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	public interface IGridWorldIndexer3
	{
		// Token: 0x06001D52 RID: 7506
		[Token(Token = "0x6001D52")]
		Vector3i ToGrid(Vector3d pointf);

		// Token: 0x06001D53 RID: 7507
		[Token(Token = "0x6001D53")]
		Vector3d ToGridf(Vector3d pointf);

		// Token: 0x06001D54 RID: 7508
		[Token(Token = "0x6001D54")]
		Vector3d FromGrid(Vector3i gridpoint);

		// Token: 0x06001D55 RID: 7509
		[Token(Token = "0x6001D55")]
		Vector3d FromGrid(Vector3d gridpointf);
	}
}
