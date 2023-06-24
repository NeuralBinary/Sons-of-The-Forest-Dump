using System;
using Il2CppDummyDll;

namespace Sons.Environment.Digging
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[Serializable]
	public class KeyFloatPair
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public KeyFloatPair()
		{
		}

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x10")]
		public string Key;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x18")]
		public float Value;
	}
}
