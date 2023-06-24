using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public abstract class JsonNameTable
	{
		// Token: 0x060000A0 RID: 160
		[Token(Token = "0x60000A0")]
		[NullableContext(1)]
		public abstract string Get(char[] key, int start, int length);

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected JsonNameTable()
		{
		}
	}
}
