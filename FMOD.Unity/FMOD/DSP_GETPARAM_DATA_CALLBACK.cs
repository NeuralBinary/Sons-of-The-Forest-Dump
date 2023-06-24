using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200006A RID: 106
	// (Invoke) Token: 0x06000461 RID: 1121
	[Token(Token = "0x200006A")]
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
}
