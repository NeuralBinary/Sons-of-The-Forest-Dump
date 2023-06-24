using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public struct ERRORCALLBACK_INFO
	{
		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x0")]
		public RESULT result;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x4")]
		public ERRORCALLBACK_INSTANCETYPE instancetype;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr instance;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x10")]
		public StringWrapper functionname;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x18")]
		public StringWrapper functionparams;
	}
}
