using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200007C RID: 124
	// (Invoke) Token: 0x060004A9 RID: 1193
	[Token(Token = "0x200007C")]
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
}
