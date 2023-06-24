using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public abstract class ParserResult<T>
	{
		// Token: 0x06000236 RID: 566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000236")]
		internal ParserResult(IEnumerable<Error> errors, TypeInfo typeInfo)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000237")]
		internal ParserResult(T value, TypeInfo typeInfo)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x1700006E")]
		public ParserResultType Tag
		{
			[Token(Token = "0x6000238")]
			get
			{
				return ParserResultType.Parsed;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006F")]
		public TypeInfo TypeInfo
		{
			[Token(Token = "0x6000239")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public T Value
		{
			[Token(Token = "0x600023A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000071")]
		public IEnumerable<Error> Errors
		{
			[Token(Token = "0x600023B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x0")]
		private readonly ParserResultType tag;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x0")]
		private readonly TypeInfo typeInfo;
	}
}
