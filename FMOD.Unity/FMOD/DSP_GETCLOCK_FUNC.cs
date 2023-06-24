using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000075 RID: 117
	// (Invoke) Token: 0x0600048D RID: 1165
	[Token(Token = "0x2000075")]
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
}
