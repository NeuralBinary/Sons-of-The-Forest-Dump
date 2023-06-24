using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000E3 RID: 227
	// (Invoke) Token: 0x060004E3 RID: 1251
	[Token(Token = "0x20000E3")]
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(CommandReplay replay, int commandindex, Guid bankguid, StringWrapper bankfilename, LOAD_BANK_FLAGS flags, out Bank bank, IntPtr userdata);
}
