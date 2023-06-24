using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000E4 RID: 228
	// (Invoke) Token: 0x060004E7 RID: 1255
	[Token(Token = "0x20000E4")]
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(CommandReplay replay, int commandindex, EventDescription eventdescription, out EventInstance instance, IntPtr userdata);
}
