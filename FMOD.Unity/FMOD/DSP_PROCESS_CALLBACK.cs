using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000062 RID: 98
	// (Invoke) Token: 0x06000441 RID: 1089
	[Token(Token = "0x2000062")]
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
}
