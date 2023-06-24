using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000061 RID: 97
	// (Invoke) Token: 0x0600043D RID: 1085
	[Token(Token = "0x2000061")]
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
}
