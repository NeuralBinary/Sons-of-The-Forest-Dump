using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public struct DSP
	{
		// Token: 0x06000372 RID: 882 RVA: 0x000042D4 File Offset: 0x000024D4
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xB31AB0", Offset = "0xB300B0", VA = "0x180B31AB0")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000042EC File Offset: 0x000024EC
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xB31B30", Offset = "0xB30130", VA = "0x180B31B30")]
		public RESULT getSystemObject(out System system)
		{
			return RESULT.OK;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00004304 File Offset: 0x00002504
		[Token(Token = "0x6000374")]
		[Address(RVA = "0xB31BC0", Offset = "0xB301C0", VA = "0x180B31BC0")]
		public RESULT addInput(DSP input)
		{
			return RESULT.OK;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000431C File Offset: 0x0000251C
		[Token(Token = "0x6000375")]
		[Address(RVA = "0xB31C50", Offset = "0xB30250", VA = "0x180B31C50")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return RESULT.OK;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00004334 File Offset: 0x00002534
		[Token(Token = "0x6000376")]
		[Address(RVA = "0xB31D00", Offset = "0xB30300", VA = "0x180B31D00")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return RESULT.OK;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000434C File Offset: 0x0000254C
		[Token(Token = "0x6000377")]
		[Address(RVA = "0xB31DA0", Offset = "0xB303A0", VA = "0x180B31DA0")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return RESULT.OK;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00004364 File Offset: 0x00002564
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xB31E40", Offset = "0xB30440", VA = "0x180B31E40")]
		public RESULT getNumInputs(out int numinputs)
		{
			return RESULT.OK;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000437C File Offset: 0x0000257C
		[Token(Token = "0x6000379")]
		[Address(RVA = "0xB31ED0", Offset = "0xB304D0", VA = "0x180B31ED0")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return RESULT.OK;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00004394 File Offset: 0x00002594
		[Token(Token = "0x600037A")]
		[Address(RVA = "0xB31F60", Offset = "0xB30560", VA = "0x180B31F60")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return RESULT.OK;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000043AC File Offset: 0x000025AC
		[Token(Token = "0x600037B")]
		[Address(RVA = "0xB32000", Offset = "0xB30600", VA = "0x180B32000")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return RESULT.OK;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000043C4 File Offset: 0x000025C4
		[Token(Token = "0x600037C")]
		[Address(RVA = "0xB320A0", Offset = "0xB306A0", VA = "0x180B320A0")]
		public RESULT setActive(bool active)
		{
			return RESULT.OK;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000043DC File Offset: 0x000025DC
		[Token(Token = "0x600037D")]
		[Address(RVA = "0xB32130", Offset = "0xB30730", VA = "0x180B32130")]
		public RESULT getActive(out bool active)
		{
			return RESULT.OK;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000043F4 File Offset: 0x000025F4
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xB321D0", Offset = "0xB307D0", VA = "0x180B321D0")]
		public RESULT setBypass(bool bypass)
		{
			return RESULT.OK;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000440C File Offset: 0x0000260C
		[Token(Token = "0x600037F")]
		[Address(RVA = "0xB32260", Offset = "0xB30860", VA = "0x180B32260")]
		public RESULT getBypass(out bool bypass)
		{
			return RESULT.OK;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00004424 File Offset: 0x00002624
		[Token(Token = "0x6000380")]
		[Address(RVA = "0xB32300", Offset = "0xB30900", VA = "0x180B32300")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return RESULT.OK;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000443C File Offset: 0x0000263C
		[Token(Token = "0x6000381")]
		[Address(RVA = "0xB323C0", Offset = "0xB309C0", VA = "0x180B323C0")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return RESULT.OK;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00004454 File Offset: 0x00002654
		[Token(Token = "0x6000382")]
		[Address(RVA = "0xB32470", Offset = "0xB30A70", VA = "0x180B32470")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return RESULT.OK;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000446C File Offset: 0x0000266C
		[Token(Token = "0x6000383")]
		[Address(RVA = "0xB32510", Offset = "0xB30B10", VA = "0x180B32510")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return RESULT.OK;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00004484 File Offset: 0x00002684
		[Token(Token = "0x6000384")]
		[Address(RVA = "0xB325C0", Offset = "0xB30BC0", VA = "0x180B325C0")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return RESULT.OK;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000449C File Offset: 0x0000269C
		[Token(Token = "0x6000385")]
		[Address(RVA = "0xB32670", Offset = "0xB30C70", VA = "0x180B32670")]
		public RESULT reset()
		{
			return RESULT.OK;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000044B4 File Offset: 0x000026B4
		[Token(Token = "0x6000386")]
		[Address(RVA = "0xB326F0", Offset = "0xB30CF0", VA = "0x180B326F0")]
		public RESULT setParameterFloat(int index, float value)
		{
			return RESULT.OK;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x6000387")]
		[Address(RVA = "0xB32790", Offset = "0xB30D90", VA = "0x180B32790")]
		public RESULT setParameterInt(int index, int value)
		{
			return RESULT.OK;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000044E4 File Offset: 0x000026E4
		[Token(Token = "0x6000388")]
		[Address(RVA = "0xB32830", Offset = "0xB30E30", VA = "0x180B32830")]
		public RESULT setParameterBool(int index, bool value)
		{
			return RESULT.OK;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000044FC File Offset: 0x000026FC
		[Token(Token = "0x6000389")]
		[Address(RVA = "0xB328D0", Offset = "0xB30ED0", VA = "0x180B328D0")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return RESULT.OK;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x600038A")]
		[Address(RVA = "0xB32A00", Offset = "0xB31000", VA = "0x180B32A00")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return RESULT.OK;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x600038B")]
		[Address(RVA = "0xB32AA0", Offset = "0xB310A0", VA = "0x180B32AA0")]
		public RESULT getParameterInt(int index, out int value)
		{
			return RESULT.OK;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x600038C")]
		[Address(RVA = "0xB32B40", Offset = "0xB31140", VA = "0x180B32B40")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return RESULT.OK;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x600038D")]
		[Address(RVA = "0xB32C00", Offset = "0xB31200", VA = "0x180B32C00")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return RESULT.OK;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x600038E")]
		[Address(RVA = "0xB32CC0", Offset = "0xB312C0", VA = "0x180B32CC0")]
		public RESULT getNumParameters(out int numparams)
		{
			return RESULT.OK;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x600038F")]
		[Address(RVA = "0xB32D50", Offset = "0xB31350", VA = "0x180B32D50")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return RESULT.OK;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x6000390")]
		[Address(RVA = "0xB32FF0", Offset = "0xB315F0", VA = "0x180B32FF0")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return RESULT.OK;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x6000391")]
		[Address(RVA = "0xB33090", Offset = "0xB31690", VA = "0x180B33090")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return RESULT.OK;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x6000392")]
		[Address(RVA = "0xB33130", Offset = "0xB31730", VA = "0x180B33130")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return RESULT.OK;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x6000393")]
		[Address(RVA = "0xB33350", Offset = "0xB31950", VA = "0x180B33350")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return RESULT.OK;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x6000394")]
		[Address(RVA = "0xB33390", Offset = "0xB31990", VA = "0x180B33390")]
		public RESULT getType(out DSP_TYPE type)
		{
			return RESULT.OK;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x6000395")]
		[Address(RVA = "0xB33420", Offset = "0xB31A20", VA = "0x180B33420")]
		public RESULT getIdle(out bool idle)
		{
			return RESULT.OK;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00004634 File Offset: 0x00002834
		[Token(Token = "0x6000396")]
		[Address(RVA = "0xB334C0", Offset = "0xB31AC0", VA = "0x180B334C0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x6000397")]
		[Address(RVA = "0xB33550", Offset = "0xB31B50", VA = "0x180B33550")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x6000398")]
		[Address(RVA = "0xB335E0", Offset = "0xB31BE0", VA = "0x180B335E0")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return RESULT.OK;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x6000399")]
		[Address(RVA = "0xB33680", Offset = "0xB31C80", VA = "0x180B33680")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return RESULT.OK;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x600039A")]
		[Address(RVA = "0xB33740", Offset = "0xB31D40", VA = "0x180B33740")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return RESULT.OK;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000046AC File Offset: 0x000028AC
		[Token(Token = "0x600039B")]
		[Address(RVA = "0xB33870", Offset = "0xB31E70", VA = "0x180B33870")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return RESULT.OK;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x600039C")]
		[Address(RVA = "0xB339A0", Offset = "0xB31FA0", VA = "0x180B339A0")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return RESULT.OK;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000046DC File Offset: 0x000028DC
		[Token(Token = "0x600039D")]
		[Address(RVA = "0xB33B90", Offset = "0xB32190", VA = "0x180B33B90")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return RESULT.OK;
		}

		// Token: 0x0600039E RID: 926
		[Token(Token = "0x600039E")]
		[Address(RVA = "0xB33C30", Offset = "0xB32230", VA = "0x180B33C30")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		// Token: 0x0600039F RID: 927
		[Token(Token = "0x600039F")]
		[Address(RVA = "0xB33CB0", Offset = "0xB322B0", VA = "0x180B33CB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		// Token: 0x060003A0 RID: 928
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xB33D40", Offset = "0xB32340", VA = "0x180B33D40")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		// Token: 0x060003A1 RID: 929
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xB33DF0", Offset = "0xB323F0", VA = "0x180B33DF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		// Token: 0x060003A2 RID: 930
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xB33EA0", Offset = "0xB324A0", VA = "0x180B33EA0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		// Token: 0x060003A3 RID: 931
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xB33F40", Offset = "0xB32540", VA = "0x180B33F40")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		// Token: 0x060003A4 RID: 932
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xB33FE0", Offset = "0xB325E0", VA = "0x180B33FE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		// Token: 0x060003A5 RID: 933
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xB34070", Offset = "0xB32670", VA = "0x180B34070")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		// Token: 0x060003A6 RID: 934
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xB34100", Offset = "0xB32700", VA = "0x180B34100")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		// Token: 0x060003A7 RID: 935
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xB341A0", Offset = "0xB327A0", VA = "0x180B341A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		// Token: 0x060003A8 RID: 936
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xB34240", Offset = "0xB32840", VA = "0x180B34240")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		// Token: 0x060003A9 RID: 937
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xB342D0", Offset = "0xB328D0", VA = "0x180B342D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		// Token: 0x060003AA RID: 938
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xB34370", Offset = "0xB32970", VA = "0x180B34370")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		// Token: 0x060003AB RID: 939
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xB34400", Offset = "0xB32A00", VA = "0x180B34400")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		// Token: 0x060003AC RID: 940
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xB344A0", Offset = "0xB32AA0", VA = "0x180B344A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		// Token: 0x060003AD RID: 941
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xB34560", Offset = "0xB32B60", VA = "0x180B34560")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		// Token: 0x060003AE RID: 942
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xB34610", Offset = "0xB32C10", VA = "0x180B34610")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		// Token: 0x060003AF RID: 943
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xB346B0", Offset = "0xB32CB0", VA = "0x180B346B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		// Token: 0x060003B0 RID: 944
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xB34760", Offset = "0xB32D60", VA = "0x180B34760")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		// Token: 0x060003B1 RID: 945
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xB34810", Offset = "0xB32E10", VA = "0x180B34810")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		// Token: 0x060003B2 RID: 946
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xB34890", Offset = "0xB32E90", VA = "0x180B34890")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		// Token: 0x060003B3 RID: 947
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xB34930", Offset = "0xB32F30", VA = "0x180B34930")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		// Token: 0x060003B4 RID: 948
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xB349D0", Offset = "0xB32FD0", VA = "0x180B349D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		// Token: 0x060003B5 RID: 949
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xB34A70", Offset = "0xB33070", VA = "0x180B34A70")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		// Token: 0x060003B6 RID: 950
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xB34B10", Offset = "0xB33110", VA = "0x180B34B10")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		// Token: 0x060003B7 RID: 951
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xB34BC0", Offset = "0xB331C0", VA = "0x180B34BC0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		// Token: 0x060003B8 RID: 952
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xB34C70", Offset = "0xB33270", VA = "0x180B34C70")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		// Token: 0x060003B9 RID: 953
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xB34D40", Offset = "0xB33340", VA = "0x180B34D40")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		// Token: 0x060003BA RID: 954
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xB34DF0", Offset = "0xB333F0", VA = "0x180B34DF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		// Token: 0x060003BB RID: 955
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xB34E80", Offset = "0xB33480", VA = "0x180B34E80")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out IntPtr desc);

		// Token: 0x060003BC RID: 956
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xB34F20", Offset = "0xB33520", VA = "0x180B34F20")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		// Token: 0x060003BD RID: 957
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xB34FC0", Offset = "0xB335C0", VA = "0x180B34FC0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		// Token: 0x060003BE RID: 958
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xB35060", Offset = "0xB33660", VA = "0x180B35060")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		// Token: 0x060003BF RID: 959
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xB35110", Offset = "0xB33710", VA = "0x180B35110")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		// Token: 0x060003C0 RID: 960
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xB351A0", Offset = "0xB337A0", VA = "0x180B351A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		// Token: 0x060003C1 RID: 961
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xB35240", Offset = "0xB33840", VA = "0x180B35240")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		// Token: 0x060003C2 RID: 962
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xB352D0", Offset = "0xB338D0", VA = "0x180B352D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		// Token: 0x060003C3 RID: 963
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xB35360", Offset = "0xB33960", VA = "0x180B35360")]
		[PreserveSig]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		// Token: 0x060003C4 RID: 964
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xB35400", Offset = "0xB33A00", VA = "0x180B35400")]
		[PreserveSig]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		// Token: 0x060003C5 RID: 965
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xB354C0", Offset = "0xB33AC0", VA = "0x180B354C0")]
		[PreserveSig]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		// Token: 0x060003C6 RID: 966
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xB355F0", Offset = "0xB33BF0", VA = "0x180B355F0")]
		[PreserveSig]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		// Token: 0x060003C7 RID: 967
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xB35720", Offset = "0xB33D20", VA = "0x180B35720")]
		[PreserveSig]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		// Token: 0x060003C8 RID: 968
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xB35910", Offset = "0xB33F10", VA = "0x180B35910")]
		[PreserveSig]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		// Token: 0x060003C9 RID: 969 RVA: 0x000046F4 File Offset: 0x000028F4
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
