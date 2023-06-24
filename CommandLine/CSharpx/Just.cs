using System;
using Il2CppDummyDll;

namespace CSharpx
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	internal sealed class Just<T> : Maybe<T>
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000175")]
		internal Just(T value)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public T Value
		{
			[Token(Token = "0x6000176")]
			get
			{
				return null;
			}
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		private readonly T value;
	}
}
