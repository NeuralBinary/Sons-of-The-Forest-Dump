using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	internal sealed class OptionSpecification : Specification
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x9AB4E0", Offset = "0x9A9AE0", VA = "0x1809AB4E0")]
		public OptionSpecification(string shortName, string longName, bool required, string setName, Maybe<int> min, Maybe<int> max, char separator, Maybe<object> defaultValue, string helpText, string metaValue, IEnumerable<string> enumValues, Type conversionType, TargetType targetType, string group, bool flagCounter = false, bool hidden = false)
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x9AB7C0", Offset = "0x9A9DC0", VA = "0x1809AB7C0")]
		public static OptionSpecification FromAttribute(OptionAttribute attribute, Type conversionType, IEnumerable<string> enumValues)
		{
			return null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x9ABB10", Offset = "0x9AA110", VA = "0x1809ABB10")]
		public static OptionSpecification NewSwitch(string shortName, string longName, bool required, string helpText, string metaValue, bool hidden = false)
		{
			return null;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C5")]
		public string ShortName
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C6")]
		public string LongName
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x170000C7")]
		public char Separator
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x9ABDA0", Offset = "0x9AA3A0", VA = "0x1809ABDA0")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C8")]
		public string SetName
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C9")]
		public string Group
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x170000CA")]
		public bool FlagCounter
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x58")]
		private readonly string shortName;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x60")]
		private readonly string longName;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x68")]
		private readonly char separator;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x70")]
		private readonly string setName;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x78")]
		private readonly string group;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x80")]
		private readonly bool flagCounter;
	}
}
