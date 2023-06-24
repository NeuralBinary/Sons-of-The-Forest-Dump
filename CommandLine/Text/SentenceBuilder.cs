using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CommandLine.Text
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	public abstract class SentenceBuilder
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x99DF50", Offset = "0x99C550", VA = "0x18099DF50")]
		public static SentenceBuilder Create()
		{
			return null;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AB")]
		public static Func<SentenceBuilder> Factory
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x99DFF0", Offset = "0x99C5F0", VA = "0x18099DFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x99E040", Offset = "0x99C640", VA = "0x18099E040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003AB RID: 939
		[Token(Token = "0x170000AC")]
		public abstract Func<string> RequiredWord { [Token(Token = "0x60003AB")] get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003AC RID: 940
		[Token(Token = "0x170000AD")]
		public abstract Func<string> OptionGroupWord { [Token(Token = "0x60003AC")] get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003AD RID: 941
		[Token(Token = "0x170000AE")]
		public abstract Func<string> ErrorsHeadingText { [Token(Token = "0x60003AD")] get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003AE RID: 942
		[Token(Token = "0x170000AF")]
		public abstract Func<string> UsageHeadingText { [Token(Token = "0x60003AE")] get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003AF RID: 943
		[Token(Token = "0x170000B0")]
		public abstract Func<bool, string> HelpCommandText { [Token(Token = "0x60003AF")] get; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003B0 RID: 944
		[Token(Token = "0x170000B1")]
		public abstract Func<bool, string> VersionCommandText { [Token(Token = "0x60003B0")] get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003B1 RID: 945
		[Token(Token = "0x170000B2")]
		public abstract Func<Error, string> FormatError { [Token(Token = "0x60003B1")] get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003B2 RID: 946
		[Token(Token = "0x170000B3")]
		public abstract Func<IEnumerable<MutuallyExclusiveSetError>, string> FormatMutuallyExclusiveSetErrors { [Token(Token = "0x60003B2")] get; }

		// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected SentenceBuilder()
		{
		}

		// Token: 0x020000A1 RID: 161
		[Token(Token = "0x20000A1")]
		private class DefaultSentenceBuilder : SentenceBuilder
		{
			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B4")]
			public override Func<string> RequiredWord
			{
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0x99E200", Offset = "0x99C800", VA = "0x18099E200", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B5")]
			public override Func<string> ErrorsHeadingText
			{
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0x99E330", Offset = "0x99C930", VA = "0x18099E330", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B6")]
			public override Func<string> UsageHeadingText
			{
				[Token(Token = "0x60003B7")]
				[Address(RVA = "0x99E460", Offset = "0x99CA60", VA = "0x18099E460", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B7")]
			public override Func<string> OptionGroupWord
			{
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0x99E590", Offset = "0x99CB90", VA = "0x18099E590", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B8")]
			public override Func<bool, string> HelpCommandText
			{
				[Token(Token = "0x60003B9")]
				[Address(RVA = "0x99E6C0", Offset = "0x99CCC0", VA = "0x18099E6C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B9")]
			public override Func<bool, string> VersionCommandText
			{
				[Token(Token = "0x60003BA")]
				[Address(RVA = "0x99E7F0", Offset = "0x99CDF0", VA = "0x18099E7F0", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000BA")]
			public override Func<Error, string> FormatError
			{
				[Token(Token = "0x60003BB")]
				[Address(RVA = "0x99E920", Offset = "0x99CF20", VA = "0x18099E920", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000BB")]
			public override Func<IEnumerable<MutuallyExclusiveSetError>, string> FormatMutuallyExclusiveSetErrors
			{
				[Token(Token = "0x60003BC")]
				[Address(RVA = "0x99EA50", Offset = "0x99D050", VA = "0x18099EA50", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x99EB80", Offset = "0x99D180", VA = "0x18099EB80")]
			public DefaultSentenceBuilder()
			{
			}
		}
	}
}
