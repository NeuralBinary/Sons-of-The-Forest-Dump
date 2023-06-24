using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr sound;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x10")]
		public int subsoundIndex;
	}
}
