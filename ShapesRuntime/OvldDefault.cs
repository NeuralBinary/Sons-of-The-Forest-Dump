using System;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal class OvldDefault : Attribute
	{
		// Token: 0x06000A6C RID: 2668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public OvldDefault(string @default)
		{
		}

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x10")]
		public string @default;
	}
}
