using System;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	internal static class NameExtensions
	{
		// Token: 0x060004A6 RID: 1190 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x9A9910", Offset = "0x9A7F10", VA = "0x1809A9910")]
		public static bool MatchName(this string value, string shortName, string longName, StringComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x9A9950", Offset = "0x9A7F50", VA = "0x1809A9950")]
		public static NameInfo FromOptionSpecification(this OptionSpecification specification)
		{
			return null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x9A99D0", Offset = "0x9A7FD0", VA = "0x1809A99D0")]
		public static NameInfo FromSpecification(this Specification specification)
		{
			return null;
		}
	}
}
