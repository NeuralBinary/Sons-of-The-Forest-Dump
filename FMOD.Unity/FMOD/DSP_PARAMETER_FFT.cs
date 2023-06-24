using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public struct DSP_PARAMETER_FFT
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700000C")]
		public float[][] spectrum
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xB3CDD0", Offset = "0xB3B3D0", VA = "0x180B3CDD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xB3CFF0", Offset = "0xB3B5F0", VA = "0x180B3CFF0")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xB3D0B0", Offset = "0xB3B6B0", VA = "0x180B3D0B0")]
		public void getSpectrum(int channel, ref float[] buffer)
		{
		}

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x0")]
		public int length;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x4")]
		public int numchannels;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr[] spectrum_internal;
	}
}
