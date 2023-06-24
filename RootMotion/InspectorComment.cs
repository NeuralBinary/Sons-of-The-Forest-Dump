using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class InspectorComment : PropertyAttribute
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x28F12F0", Offset = "0x28EF8F0", VA = "0x1828F12F0")]
		public InspectorComment(string name)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x28F1430", Offset = "0x28EFA30", VA = "0x1828F1430")]
		public InspectorComment(string name, string color)
		{
		}

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x20")]
		public string color;
	}
}
