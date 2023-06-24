using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200007E RID: 126
	// (Invoke) Token: 0x060004B1 RID: 1201
	[Token(Token = "0x200007E")]
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
}
