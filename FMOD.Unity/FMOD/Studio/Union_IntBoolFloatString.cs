using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[StructLayout(2)]
	internal struct Union_IntBoolFloatString
	{
		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int intvalue;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool boolvalue;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float floatvalue;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper stringvalue;
	}
}
