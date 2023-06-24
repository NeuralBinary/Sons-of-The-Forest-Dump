using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200007D RID: 125
	// (Invoke) Token: 0x060004AD RID: 1197
	[Token(Token = "0x200007D")]
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
}
