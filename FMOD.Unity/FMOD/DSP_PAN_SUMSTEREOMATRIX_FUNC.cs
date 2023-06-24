using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200007B RID: 123
	// (Invoke) Token: 0x060004A5 RID: 1189
	[Token(Token = "0x200007B")]
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
}
