using System;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	internal abstract class Either<TLeft, TRight>
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DB")]
		protected Either(EitherType tag)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x17000038")]
		public EitherType Tag
		{
			[Token(Token = "0x60000DC")]
			get
			{
				return EitherType.Left;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000DD")]
		public bool MatchLeft(out TLeft value)
		{
			return default(bool);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000DE")]
		public bool MatchRight(out TRight value)
		{
			return default(bool);
		}

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x0")]
		private readonly EitherType tag;
	}
}
