using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public struct ArrayIndices
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
		internal ArrayIndices(int[] indices)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x170000FC")]
		public int Length
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x8EC160", Offset = "0x8EA760", VA = "0x1808EC160")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000FD RID: 253
		[Token(Token = "0x170000FD")]
		[Documentation(Ignore = true)]
		public int this[int index]
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x8EC170", Offset = "0x8EA770", VA = "0x1808EC170")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x0")]
		private readonly int[] indices;
	}
}
