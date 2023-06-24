using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	public class IntTagSet<T>
	{
		// Token: 0x0600043B RID: 1083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043B")]
		public IntTagSet()
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043C")]
		private void create()
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043D")]
		public void Add(T reference, int tag)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000401C File Offset: 0x0000221C
		[Token(Token = "0x600043E")]
		public bool Has(T reference)
		{
			return default(bool);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x600043F")]
		public int Get(T reference)
		{
			return 0;
		}

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		public const int InvalidTag = 2147483647;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, int> tags;
	}
}
