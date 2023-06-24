using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Text
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public sealed class Example : IEquatable<Example>
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x9971D0", Offset = "0x9957D0", VA = "0x1809971D0")]
		public Example(string helpText, IEnumerable<UnParserSettings> formatStyles, object sample)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x997320", Offset = "0x995920", VA = "0x180997320")]
		public Example(string helpText, UnParserSettings formatStyle, object sample)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x997510", Offset = "0x995B10", VA = "0x180997510")]
		public Example(string helpText, object sample)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		public string HelpText
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		public IEnumerable<UnParserSettings> FormatStyles
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000093")]
		public object Sample
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x997690", Offset = "0x995C90", VA = "0x180997690", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x9977F0", Offset = "0x995DF0", VA = "0x1809977F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x997960", Offset = "0x995F60", VA = "0x180997960", Slot = "4")]
		public bool Equals(Example other)
		{
			return default(bool);
		}

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x10")]
		private readonly string helpText;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x18")]
		private readonly IEnumerable<UnParserSettings> formatStyles;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x20")]
		private readonly object sample;
	}
}
