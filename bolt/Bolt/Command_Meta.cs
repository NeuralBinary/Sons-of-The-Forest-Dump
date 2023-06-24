using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	internal abstract class Command_Meta : NetworkObj_Meta
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x8DCDF0", Offset = "0x8DB3F0", VA = "0x1808DCDF0")]
		protected Command_Meta()
		{
		}

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x78")]
		internal int SmoothFrames;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x7C")]
		internal bool CompressZeroValues;
	}
}
