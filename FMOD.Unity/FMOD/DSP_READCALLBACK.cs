using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000060 RID: 96
	// (Invoke) Token: 0x06000439 RID: 1081
	[Token(Token = "0x2000060")]
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
}
