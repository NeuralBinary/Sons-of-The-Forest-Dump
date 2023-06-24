using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public static class DeepCopy
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001E1")]
		public static List<T> List<T>(IEnumerable<T> Input) where T : IDuplicatable<T>
		{
			return null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001E2")]
		public static T[] Array<T>(IEnumerable<T> Input) where T : IDuplicatable<T>
		{
			return null;
		}
	}
}
