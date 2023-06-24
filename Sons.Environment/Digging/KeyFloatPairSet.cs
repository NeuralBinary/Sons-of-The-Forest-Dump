using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Environment.Digging
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[Serializable]
	public class KeyFloatPairSet
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public KeyFloatPairSet()
		{
		}

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x10")]
		public List<KeyFloatPair> Pairs;
	}
}
