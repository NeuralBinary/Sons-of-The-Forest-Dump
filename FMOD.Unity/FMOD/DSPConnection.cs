using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public struct DSPConnection
	{
		// Token: 0x060003CB RID: 971 RVA: 0x0000470C File Offset: 0x0000290C
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xB359B0", Offset = "0xB33FB0", VA = "0x180B359B0")]
		public RESULT getInput(out DSP input)
		{
			return RESULT.OK;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00004724 File Offset: 0x00002924
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xB35A40", Offset = "0xB34040", VA = "0x180B35A40")]
		public RESULT getOutput(out DSP output)
		{
			return RESULT.OK;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xB35AD0", Offset = "0xB340D0", VA = "0x180B35AD0")]
		public RESULT setMix(float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xB35B60", Offset = "0xB34160", VA = "0x180B35B60")]
		public RESULT getMix(out float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xB35BF0", Offset = "0xB341F0", VA = "0x180B35BF0")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return RESULT.OK;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00004784 File Offset: 0x00002984
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xB35CB0", Offset = "0xB342B0", VA = "0x180B35CB0")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return RESULT.OK;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000479C File Offset: 0x0000299C
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xB35D70", Offset = "0xB34370", VA = "0x180B35D70")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return RESULT.OK;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000047B4 File Offset: 0x000029B4
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xB35E00", Offset = "0xB34400", VA = "0x180B35E00")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xB35E90", Offset = "0xB34490", VA = "0x180B35E90")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060003D4 RID: 980
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xB35F20", Offset = "0xB34520", VA = "0x180B35F20")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		// Token: 0x060003D5 RID: 981
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xB35FB0", Offset = "0xB345B0", VA = "0x180B35FB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		// Token: 0x060003D6 RID: 982
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xB36040", Offset = "0xB34640", VA = "0x180B36040")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		// Token: 0x060003D7 RID: 983
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xB360D0", Offset = "0xB346D0", VA = "0x180B360D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		// Token: 0x060003D8 RID: 984
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xB36160", Offset = "0xB34760", VA = "0x180B36160")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		// Token: 0x060003D9 RID: 985
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xB36220", Offset = "0xB34820", VA = "0x180B36220")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		// Token: 0x060003DA RID: 986
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xB362E0", Offset = "0xB348E0", VA = "0x180B362E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		// Token: 0x060003DB RID: 987
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xB36370", Offset = "0xB34970", VA = "0x180B36370")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		// Token: 0x060003DC RID: 988
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xB36400", Offset = "0xB34A00", VA = "0x180B36400")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		// Token: 0x060003DD RID: 989 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
