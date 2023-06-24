using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public class ParserSettings : IDisposable
	{
		// Token: 0x06000262 RID: 610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x993160", Offset = "0x991760", VA = "0x180993160")]
		public ParserSettings()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x993430", Offset = "0x991A30", VA = "0x180993430")]
		private int GetWindowWidth()
		{
			return 0;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x9923F0", Offset = "0x9909F0", VA = "0x1809923F0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00002B68 File Offset: 0x00000D68
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000072")]
		public bool CaseSensitive
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x5FD500", Offset = "0x5FBB00", VA = "0x1805FD500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x993670", Offset = "0x991C70", VA = "0x180993670")]
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00002B80 File Offset: 0x00000D80
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000073")]
		public bool CaseInsensitiveEnumValues
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x5FD520", Offset = "0x5FBB20", VA = "0x1805FD520")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x9936F0", Offset = "0x991CF0", VA = "0x1809936F0")]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000074")]
		public CultureInfo ParsingCulture
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x993770", Offset = "0x991D70", VA = "0x180993770")]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000075")]
		public TextWriter HelpWriter
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x993810", Offset = "0x991E10", VA = "0x180993810")]
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00002B98 File Offset: 0x00000D98
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000076")]
		public bool IgnoreUnknownArguments
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x993860", Offset = "0x991E60", VA = "0x180993860")]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000077")]
		public bool AutoHelp
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x9938F0", Offset = "0x991EF0", VA = "0x1809938F0")]
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00002BC8 File Offset: 0x00000DC8
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000078")]
		public bool AutoVersion
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x993970", Offset = "0x991F70", VA = "0x180993970")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x993980", Offset = "0x991F80", VA = "0x180993980")]
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002BE0 File Offset: 0x00000DE0
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000079")]
		public bool EnableDashDash
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x993A00", Offset = "0x992000", VA = "0x180993A00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x993A70", Offset = "0x992070", VA = "0x180993A70")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00002BF8 File Offset: 0x00000DF8
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007A")]
		public int MaximumDisplayWidth
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x993AE0", Offset = "0x9920E0", VA = "0x180993AE0")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002C10 File Offset: 0x00000E10
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007B")]
		public bool AllowMultiInstance
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x993AF0", Offset = "0x9920F0", VA = "0x180993AF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x993B60", Offset = "0x992160", VA = "0x180993B60")]
			set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00002C28 File Offset: 0x00000E28
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007C")]
		public bool GetoptMode
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x993BE0", Offset = "0x9921E0", VA = "0x180993BE0")]
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00002C40 File Offset: 0x00000E40
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007D")]
		public bool PosixlyCorrect
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x993C60", Offset = "0x992260", VA = "0x180993C60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x993F20", Offset = "0x992520", VA = "0x180993F20")]
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		internal StringComparer NameComparer
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x993F90", Offset = "0x992590", VA = "0x180993F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00002C58 File Offset: 0x00000E58
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007F")]
		internal bool Consumed
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x994000", Offset = "0x992600", VA = "0x180994000", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x994090", Offset = "0x992690", VA = "0x180994090")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		private const int DefaultMaximumLength = 80;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x10")]
		private bool disposed;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x11")]
		private bool caseSensitive;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x12")]
		private bool caseInsensitiveEnumValues;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x18")]
		private TextWriter helpWriter;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x20")]
		private bool ignoreUnknownArguments;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x21")]
		private bool autoHelp;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x22")]
		private bool autoVersion;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x28")]
		private CultureInfo parsingCulture;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x30")]
		private Maybe<bool> enableDashDash;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x38")]
		private int maximumDisplayWidth;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x40")]
		private Maybe<bool> allowMultiInstance;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x48")]
		private bool getoptMode;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x50")]
		private Maybe<bool> posixlyCorrect;
	}
}
