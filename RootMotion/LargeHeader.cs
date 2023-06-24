using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class LargeHeader : PropertyAttribute
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x28F2590", Offset = "0x28F0B90", VA = "0x1828F2590")]
		public LargeHeader(string name)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x28F26D0", Offset = "0x28F0CD0", VA = "0x1828F26D0")]
		public LargeHeader(string name, string color)
		{
		}

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x20")]
		public string color;
	}
}
