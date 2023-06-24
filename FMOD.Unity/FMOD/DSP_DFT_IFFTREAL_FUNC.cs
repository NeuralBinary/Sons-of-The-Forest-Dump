using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000079 RID: 121
	// (Invoke) Token: 0x0600049D RID: 1181
	[Token(Token = "0x2000079")]
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
}
