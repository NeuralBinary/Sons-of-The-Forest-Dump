using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200007F RID: 127
	// (Invoke) Token: 0x060004B5 RID: 1205
	[Token(Token = "0x200007F")]
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
}
