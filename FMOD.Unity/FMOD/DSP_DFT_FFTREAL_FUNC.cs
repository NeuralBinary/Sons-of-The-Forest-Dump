using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000078 RID: 120
	// (Invoke) Token: 0x06000499 RID: 1177
	[Token(Token = "0x2000078")]
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
}
