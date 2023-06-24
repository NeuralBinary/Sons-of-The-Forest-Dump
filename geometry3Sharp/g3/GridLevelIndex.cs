using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200037D RID: 893
	[Token(Token = "0x200037D")]
	public struct GridLevelIndex
	{
		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x0")]
		public Vector3i block_index;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0xC")]
		public Vector3i local_index;
	}
}
