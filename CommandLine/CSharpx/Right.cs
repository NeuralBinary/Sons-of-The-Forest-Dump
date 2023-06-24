using System;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	internal sealed class Right<TLeft, TRight> : Either<TLeft, TRight>
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E1")]
		internal Right(TRight value)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public TRight Value
		{
			[Token(Token = "0x60000E2")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x0")]
		private readonly TRight value;
	}
}
