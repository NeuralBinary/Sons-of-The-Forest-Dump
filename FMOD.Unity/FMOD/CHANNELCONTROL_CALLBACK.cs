using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200002D RID: 45
	// (Invoke) Token: 0x0600006D RID: 109
	[Token(Token = "0x200002D")]
	public delegate RESULT CHANNELCONTROL_CALLBACK(IntPtr channelcontrol, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE callbacktype, IntPtr commanddata1, IntPtr commanddata2);
}
