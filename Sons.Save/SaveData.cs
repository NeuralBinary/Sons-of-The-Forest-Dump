using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Save
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[Serializable]
	internal class SaveData
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3128FD0", Offset = "0x31275D0", VA = "0x183128FD0")]
		public SaveData()
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> Data;
	}
}
