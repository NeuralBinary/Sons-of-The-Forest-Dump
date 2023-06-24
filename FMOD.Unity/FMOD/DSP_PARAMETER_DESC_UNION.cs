using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	[StructLayout(2)]
	public struct DSP_PARAMETER_DESC_UNION
	{
		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_INT intdesc;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
}
