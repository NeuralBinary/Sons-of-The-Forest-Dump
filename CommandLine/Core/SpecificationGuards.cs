using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	internal static class SpecificationGuards
	{
		// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x9B0050", Offset = "0x9AE650", VA = "0x1809B0050")]
		private static Func<Specification, bool> GuardAgainstScalarWithRange()
		{
			return null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x9B0180", Offset = "0x9AE780", VA = "0x1809B0180")]
		private static Func<Specification, bool> GuardAgainstSequenceWithWrongRange()
		{
			return null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x9B02B0", Offset = "0x9AE8B0", VA = "0x1809B02B0")]
		private static Func<Specification, bool> GuardAgainstOneCharLongName()
		{
			return null;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x9B03E0", Offset = "0x9AE9E0", VA = "0x1809B03E0")]
		private static Func<Specification, bool> GuardAgainstSequenceWithZeroRange()
		{
			return null;
		}

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IEnumerable<Tuple<Func<Specification, bool>, string>> Lookup;
	}
}
