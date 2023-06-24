using System;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	internal abstract class Maybe<T>
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000170")]
		protected Maybe(MaybeType tag)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x1700004B")]
		public MaybeType Tag
		{
			[Token(Token = "0x6000171")]
			get
			{
				return MaybeType.Just;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000172")]
		public bool MatchJust(out T value)
		{
			return default(bool);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x6000173")]
		public bool MatchNothing()
		{
			return default(bool);
		}

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x0")]
		private readonly MaybeType tag;
	}
}
