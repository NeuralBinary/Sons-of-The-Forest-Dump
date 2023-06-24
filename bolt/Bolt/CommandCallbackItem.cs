using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	internal struct CommandCallbackItem
	{
		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x0")]
		public int End;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x4")]
		public int Start;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x8")]
		public Command Command;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x10")]
		public CommandCallback Callback;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x18")]
		public CommandCallbackModes Mode;
	}
}
