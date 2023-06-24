using System;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	internal sealed class Left<TLeft, TRight> : Either<TLeft, TRight>
	{
		// Token: 0x060000DF RID: 223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DF")]
		internal Left(TLeft value)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public TLeft Value
		{
			[Token(Token = "0x60000E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x0")]
		private readonly TLeft value;
	}
}
