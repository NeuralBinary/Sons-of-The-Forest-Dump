using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public class JsonLoadSettings
	{
		// Token: 0x06000C96 RID: 3222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x25CAEC0", Offset = "0x25C94C0", VA = "0x1825CAEC0")]
		public JsonLoadSettings()
		{
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x000060D8 File Offset: 0x000042D8
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020B")]
		public CommentHandling CommentHandling
		{
			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return CommentHandling.Ignore;
			}
			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x25CAED0", Offset = "0x25C94D0", VA = "0x1825CAED0")]
			set
			{
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x000060F0 File Offset: 0x000042F0
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020C")]
		public LineInfoHandling LineInfoHandling
		{
			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return LineInfoHandling.Ignore;
			}
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x25CAF40", Offset = "0x25C9540", VA = "0x1825CAF40")]
			set
			{
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00006108 File Offset: 0x00004308
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020D")]
		public DuplicatePropertyNameHandling DuplicatePropertyNameHandling
		{
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return DuplicatePropertyNameHandling.Replace;
			}
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x25CAFB0", Offset = "0x25C95B0", VA = "0x1825CAFB0")]
			set
			{
			}
		}

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x10")]
		private CommentHandling _commentHandling;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x14")]
		private LineInfoHandling _lineInfoHandling;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x18")]
		private DuplicatePropertyNameHandling _duplicatePropertyNameHandling;
	}
}
