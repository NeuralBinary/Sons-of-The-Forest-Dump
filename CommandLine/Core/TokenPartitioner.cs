using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	internal static class TokenPartitioner
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x9BF3D0", Offset = "0x9BD9D0", VA = "0x1809BF3D0")]
		public static Tuple<IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable<string>, IEnumerable<Token>> Partition(IEnumerable<Token> tokens, Func<string, Maybe<TypeDescriptor>> typeLookup)
		{
			return null;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x9BF900", Offset = "0x9BDF00", VA = "0x1809BF900")]
		public static Tuple<IEnumerable<Token>, IEnumerable<Token>, IEnumerable<Token>, IEnumerable<Token>> PartitionTokensByType(IEnumerable<Token> tokens, Func<string, Maybe<TypeDescriptor>> typeLookup)
		{
			return null;
		}

		// Token: 0x02000104 RID: 260
		[Token(Token = "0x2000104")]
		private enum SequenceState
		{
			// Token: 0x0400034E RID: 846
			[Token(Token = "0x400034E")]
			TokenSearch,
			// Token: 0x0400034F RID: 847
			[Token(Token = "0x400034F")]
			SequenceTokenFound,
			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			ScalarTokenFound
		}
	}
}
