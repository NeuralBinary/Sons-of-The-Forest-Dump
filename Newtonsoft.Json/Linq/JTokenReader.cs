using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	[NullableContext(1)]
	[Nullable(0)]
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700022A")]
		[Nullable(2)]
		public JToken CurrentToken
		{
			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D77")]
		[Address(RVA = "0x25D9B60", Offset = "0x25D8160", VA = "0x1825D9B60")]
		public JTokenReader(JToken token)
		{
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x25D9C80", Offset = "0x25D8280", VA = "0x1825D9C80")]
		public JTokenReader(JToken token, string initialPath)
		{
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x25D9CF0", Offset = "0x25D82F0", VA = "0x1825D9CF0", Slot = "21")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x25DA1D0", Offset = "0x25D87D0", VA = "0x1825DA1D0")]
		private bool ReadOver(JToken t)
		{
			return default(bool);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x25DA2B0", Offset = "0x25D88B0", VA = "0x1825DA2B0")]
		private bool ReadToEnd()
		{
			return default(bool);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x25DA3A0", Offset = "0x25D89A0", VA = "0x1825DA3A0")]
		private JsonToken? GetEndToken(JContainer c)
		{
			return null;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x25DA4F0", Offset = "0x25D8AF0", VA = "0x1825DA4F0")]
		private bool ReadInto(JContainer c)
		{
			return default(bool);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x25DA620", Offset = "0x25D8C20", VA = "0x1825DA620")]
		private bool SetEnd(JContainer c)
		{
			return default(bool);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x25DA860", Offset = "0x25D8E60", VA = "0x1825DA860")]
		private void SetToken(JToken token)
		{
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x25DB350", Offset = "0x25D9950", VA = "0x1825DB350")]
		[NullableContext(2)]
		private string SafeToString(object value)
		{
			return null;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x25DB380", Offset = "0x25D9980", VA = "0x1825DB380", Slot = "32")]
		private bool HasLineInfo()
		{
			return default(bool);
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000066D8 File Offset: 0x000048D8
		[Token(Token = "0x1700022B")]
		private int LineNumber
		{
			[Token(Token = "0x6000D82")]
			[Address(RVA = "0x25DB3E0", Offset = "0x25D99E0", VA = "0x1825DB3E0", Slot = "33")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x1700022C")]
		private int LinePosition
		{
			[Token(Token = "0x6000D83")]
			[Address(RVA = "0x25DB440", Offset = "0x25D9A40", VA = "0x1825DB440", Slot = "34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700022D")]
		public override string Path
		{
			[Token(Token = "0x6000D84")]
			[Address(RVA = "0x25DB4A0", Offset = "0x25D9AA0", VA = "0x1825DB4A0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x78")]
		private readonly JToken _root;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x80")]
		[Nullable(2)]
		private string _initialPath;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x88")]
		[Nullable(2)]
		private JToken _parent;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x90")]
		[Nullable(2)]
		private JToken _current;
	}
}
