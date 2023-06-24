using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	public class StringTagSet<T>
	{
		// Token: 0x06000443 RID: 1091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000443")]
		public StringTagSet()
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000444")]
		private void create()
		{
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000445")]
		public void Add(T reference, string tag)
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x6000446")]
		public bool Has(T reference)
		{
			return default(bool);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000447")]
		public string Get(T reference)
		{
			return null;
		}

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		public const string InvalidTag = "";

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, string> tags;
	}
}
