using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	public class JsonMergeSettings
	{
		// Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x25CB020", Offset = "0x25C9620", VA = "0x1825CB020")]
		public JsonMergeSettings()
		{
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00006120 File Offset: 0x00004320
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020E")]
		public MergeArrayHandling MergeArrayHandling
		{
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return MergeArrayHandling.Concat;
			}
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x25CB030", Offset = "0x25C9630", VA = "0x1825CB030")]
			set
			{
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00006138 File Offset: 0x00004338
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020F")]
		public MergeNullValueHandling MergeNullValueHandling
		{
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return MergeNullValueHandling.Ignore;
			}
			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x25CB0A0", Offset = "0x25C96A0", VA = "0x1825CB0A0")]
			set
			{
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00006150 File Offset: 0x00004350
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000210")]
		public StringComparison PropertyNameComparison
		{
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return StringComparison.CurrentCulture;
			}
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x25CB110", Offset = "0x25C9710", VA = "0x1825CB110")]
			set
			{
			}
		}

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x10")]
		private MergeArrayHandling _mergeArrayHandling;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x14")]
		private MergeNullValueHandling _mergeNullValueHandling;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x18")]
		private StringComparison _propertyNameComparison;
	}
}
