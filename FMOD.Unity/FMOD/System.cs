using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public struct System
	{
		// Token: 0x060000CA RID: 202 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xB183F0", Offset = "0xB169F0", VA = "0x180B183F0")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xB18470", Offset = "0xB16A70", VA = "0x180B18470")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return RESULT.OK;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xB18500", Offset = "0xB16B00", VA = "0x180B18500")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return RESULT.OK;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xB18590", Offset = "0xB16B90", VA = "0x180B18590")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return RESULT.OK;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xB18620", Offset = "0xB16C20", VA = "0x180B18620")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return RESULT.OK;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xB18850", Offset = "0xB16E50", VA = "0x180B18850")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xB188A0", Offset = "0xB16EA0", VA = "0x180B188A0")]
		public RESULT setDriver(int driver)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xB18930", Offset = "0xB16F30", VA = "0x180B18930")]
		public RESULT getDriver(out int driver)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xB189C0", Offset = "0xB16FC0", VA = "0x180B189C0")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xB18A50", Offset = "0xB17050", VA = "0x180B18A50")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xB18AE0", Offset = "0xB170E0", VA = "0x180B18AE0")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xB18B80", Offset = "0xB17180", VA = "0x180B18B80")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xB18C30", Offset = "0xB17230", VA = "0x180B18C30")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xB18CD0", Offset = "0xB172D0", VA = "0x180B18CD0")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xB18D70", Offset = "0xB17370", VA = "0x180B18D70")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return RESULT.OK;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xB18E90", Offset = "0xB17490", VA = "0x180B18E90")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return RESULT.OK;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xB18F70", Offset = "0xB17570", VA = "0x180B18F70")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return RESULT.OK;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xB190B0", Offset = "0xB176B0", VA = "0x180B190B0")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return RESULT.OK;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xB191F0", Offset = "0xB177F0", VA = "0x180B191F0")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return RESULT.OK;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xB19290", Offset = "0xB17890", VA = "0x180B19290")]
		public RESULT setPluginPath(string path)
		{
			return RESULT.OK;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xB19410", Offset = "0xB17A10", VA = "0x180B19410")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0U)
		{
			return RESULT.OK;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xB195B0", Offset = "0xB17BB0", VA = "0x180B195B0")]
		public RESULT unloadPlugin(uint handle)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xB19640", Offset = "0xB17C40", VA = "0x180B19640")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xB196E0", Offset = "0xB17CE0", VA = "0x180B196E0")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xB19780", Offset = "0xB17D80", VA = "0x180B19780")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xB19820", Offset = "0xB17E20", VA = "0x180B19820")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xB198C0", Offset = "0xB17EC0", VA = "0x180B198C0")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xB19AE0", Offset = "0xB180E0", VA = "0x180B19AE0")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xB19B10", Offset = "0xB18110", VA = "0x180B19B10")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xB19BA0", Offset = "0xB181A0", VA = "0x180B19BA0")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xB19C30", Offset = "0xB18230", VA = "0x180B19C30")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return RESULT.OK;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xB19CD0", Offset = "0xB182D0", VA = "0x180B19CD0")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return RESULT.OK;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xB19D70", Offset = "0xB18370", VA = "0x180B19D70")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return RESULT.OK;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xB19F30", Offset = "0xB18530", VA = "0x180B19F30")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xB19FD0", Offset = "0xB185D0", VA = "0x180B19FD0")]
		public RESULT close()
		{
			return RESULT.OK;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xB1A050", Offset = "0xB18650", VA = "0x180B1A050")]
		public RESULT update()
		{
			return RESULT.OK;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xB1A0D0", Offset = "0xB186D0", VA = "0x180B1A0D0")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return RESULT.OK;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xB1A190", Offset = "0xB18790", VA = "0x180B1A190")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xB1A260", Offset = "0xB18860", VA = "0x180B1A260")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xB1A300", Offset = "0xB18900", VA = "0x180B1A300")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xB1A3A0", Offset = "0xB189A0", VA = "0x180B1A3A0")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xB1A460", Offset = "0xB18A60", VA = "0x180B1A460")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xB1A510", Offset = "0xB18B10", VA = "0x180B1A510")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xB1A5A0", Offset = "0xB18BA0", VA = "0x180B1A5A0")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xB1A630", Offset = "0xB18C30", VA = "0x180B1A630")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xB1A6E0", Offset = "0xB18CE0", VA = "0x180B1A6E0")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xB1A790", Offset = "0xB18D90", VA = "0x180B1A790")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return RESULT.OK;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xB1A830", Offset = "0xB18E30", VA = "0x180B1A830")]
		public RESULT mixerSuspend()
		{
			return RESULT.OK;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xB1A8B0", Offset = "0xB18EB0", VA = "0x180B1A8B0")]
		public RESULT mixerResume()
		{
			return RESULT.OK;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xB1A930", Offset = "0xB18F30", VA = "0x180B1A930")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return RESULT.OK;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xB1A9F0", Offset = "0xB18FF0", VA = "0x180B1A9F0")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return RESULT.OK;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xB1AA90", Offset = "0xB19090", VA = "0x180B1AA90")]
		public RESULT getVersion(out uint version)
		{
			return RESULT.OK;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xB1AB20", Offset = "0xB19120", VA = "0x180B1AB20")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return RESULT.OK;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xB1ABB0", Offset = "0xB191B0", VA = "0x180B1ABB0")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return RESULT.OK;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x6000100")]
		[Address(RVA = "0xB1AC40", Offset = "0xB19240", VA = "0x180B1AC40")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return RESULT.OK;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xB1ACE0", Offset = "0xB192E0", VA = "0x180B1ACE0")]
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return RESULT.OK;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xB1AD90", Offset = "0xB19390", VA = "0x180B1AD90")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return RESULT.OK;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x6000103")]
		[Address(RVA = "0xB1AE40", Offset = "0xB19440", VA = "0x180B1AE40")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xB1AF70", Offset = "0xB19570", VA = "0x180B1AF70")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xB1AF90", Offset = "0xB19590", VA = "0x180B1AF90")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x6000106")]
		[Address(RVA = "0xB1B160", Offset = "0xB19760", VA = "0x180B1B160")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x6000107")]
		[Address(RVA = "0xB1B290", Offset = "0xB19890", VA = "0x180B1B290")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xB1B3C0", Offset = "0xB199C0", VA = "0x180B1B3C0")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xB1B3E0", Offset = "0xB199E0", VA = "0x180B1B3E0")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x600010A")]
		[Address(RVA = "0xB1B5B0", Offset = "0xB19BB0", VA = "0x180B1B5B0")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x600010B")]
		[Address(RVA = "0xB1B6E0", Offset = "0xB19CE0", VA = "0x180B1B6E0")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return RESULT.OK;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x600010C")]
		[Address(RVA = "0xB1B8A0", Offset = "0xB19EA0", VA = "0x180B1B8A0")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return RESULT.OK;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x600010D")]
		[Address(RVA = "0xB1B940", Offset = "0xB19F40", VA = "0x180B1B940")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return RESULT.OK;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x600010E")]
		[Address(RVA = "0xB1BAD0", Offset = "0xB1A0D0", VA = "0x180B1BAD0")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return RESULT.OK;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x600010F")]
		[Address(RVA = "0xB1BC60", Offset = "0xB1A260", VA = "0x180B1BC60")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return RESULT.OK;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x6000110")]
		[Address(RVA = "0xB1BCF0", Offset = "0xB1A2F0", VA = "0x180B1BCF0")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return RESULT.OK;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x6000111")]
		[Address(RVA = "0xB1BDA0", Offset = "0xB1A3A0", VA = "0x180B1BDA0")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return RESULT.OK;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x6000112")]
		[Address(RVA = "0xB1BE50", Offset = "0xB1A450", VA = "0x180B1BE50")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return RESULT.OK;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x6000113")]
		[Address(RVA = "0xB1BEF0", Offset = "0xB1A4F0", VA = "0x180B1BEF0")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return RESULT.OK;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x6000114")]
		[Address(RVA = "0xB1BF80", Offset = "0xB1A580", VA = "0x180B1BF80")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return RESULT.OK;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x6000115")]
		[Address(RVA = "0xB1C010", Offset = "0xB1A610", VA = "0x180B1C010")]
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return RESULT.OK;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xB1C0D0", Offset = "0xB1A6D0", VA = "0x180B1C0D0")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return RESULT.OK;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x6000117")]
		[Address(RVA = "0xB1C160", Offset = "0xB1A760", VA = "0x180B1C160")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return RESULT.OK;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x6000118")]
		[Address(RVA = "0xB1C200", Offset = "0xB1A800", VA = "0x180B1C200")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return RESULT.OK;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x6000119")]
		[Address(RVA = "0xB1C2A0", Offset = "0xB1A8A0", VA = "0x180B1C2A0")]
		public RESULT lockDSP()
		{
			return RESULT.OK;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x600011A")]
		[Address(RVA = "0xB1C320", Offset = "0xB1A920", VA = "0x180B1C320")]
		public RESULT unlockDSP()
		{
			return RESULT.OK;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x600011B")]
		[Address(RVA = "0xB1C3A0", Offset = "0xB1A9A0", VA = "0x180B1C3A0")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return RESULT.OK;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x600011C")]
		[Address(RVA = "0xB1C440", Offset = "0xB1AA40", VA = "0x180B1C440")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return RESULT.OK;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x600011D")]
		[Address(RVA = "0xB1C670", Offset = "0xB1AC70", VA = "0x180B1C670")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return RESULT.OK;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xB1C6D0", Offset = "0xB1ACD0", VA = "0x180B1C6D0")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return RESULT.OK;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x600011F")]
		[Address(RVA = "0xB1C770", Offset = "0xB1AD70", VA = "0x180B1C770")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return RESULT.OK;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xB1C820", Offset = "0xB1AE20", VA = "0x180B1C820")]
		public RESULT recordStop(int id)
		{
			return RESULT.OK;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x6000121")]
		[Address(RVA = "0xB1C8B0", Offset = "0xB1AEB0", VA = "0x180B1C8B0")]
		public RESULT isRecording(int id, out bool recording)
		{
			return RESULT.OK;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x6000122")]
		[Address(RVA = "0xB1C960", Offset = "0xB1AF60", VA = "0x180B1C960")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return RESULT.OK;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x6000123")]
		[Address(RVA = "0xB1CA00", Offset = "0xB1B000", VA = "0x180B1CA00")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return RESULT.OK;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x6000124")]
		[Address(RVA = "0xB1CA90", Offset = "0xB1B090", VA = "0x180B1CA90")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return RESULT.OK;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x6000125")]
		[Address(RVA = "0xB1CB20", Offset = "0xB1B120", VA = "0x180B1CB20")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return RESULT.OK;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x6000126")]
		[Address(RVA = "0xB1CBD0", Offset = "0xB1B1D0", VA = "0x180B1CBD0")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return RESULT.OK;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x6000127")]
		[Address(RVA = "0xB1CC80", Offset = "0xB1B280", VA = "0x180B1CC80")]
		public RESULT setNetworkProxy(string proxy)
		{
			return RESULT.OK;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x6000128")]
		[Address(RVA = "0xB1CE00", Offset = "0xB1B400", VA = "0x180B1CE00")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return RESULT.OK;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x6000129")]
		[Address(RVA = "0xB1D050", Offset = "0xB1B650", VA = "0x180B1D050")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return RESULT.OK;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x600012A")]
		[Address(RVA = "0xB1D0E0", Offset = "0xB1B6E0", VA = "0x180B1D0E0")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return RESULT.OK;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x600012B")]
		[Address(RVA = "0xB1D170", Offset = "0xB1B770", VA = "0x180B1D170")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x600012C")]
		[Address(RVA = "0xB1D200", Offset = "0xB1B800", VA = "0x180B1D200")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x0600012D RID: 301
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xB1D290", Offset = "0xB1B890", VA = "0x180B1D290")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		// Token: 0x0600012E RID: 302
		[Token(Token = "0x600012E")]
		[Address(RVA = "0xB1D310", Offset = "0xB1B910", VA = "0x180B1D310")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		// Token: 0x0600012F RID: 303
		[Token(Token = "0x600012F")]
		[Address(RVA = "0xB1D3A0", Offset = "0xB1B9A0", VA = "0x180B1D3A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		// Token: 0x06000130 RID: 304
		[Token(Token = "0x6000130")]
		[Address(RVA = "0xB1D430", Offset = "0xB1BA30", VA = "0x180B1D430")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		// Token: 0x06000131 RID: 305
		[Token(Token = "0x6000131")]
		[Address(RVA = "0xB1D4C0", Offset = "0xB1BAC0", VA = "0x180B1D4C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		// Token: 0x06000132 RID: 306
		[Token(Token = "0x6000132")]
		[Address(RVA = "0xB1D570", Offset = "0xB1BB70", VA = "0x180B1D570")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		// Token: 0x06000133 RID: 307
		[Token(Token = "0x6000133")]
		[Address(RVA = "0xB1D600", Offset = "0xB1BC00", VA = "0x180B1D600")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		// Token: 0x06000134 RID: 308
		[Token(Token = "0x6000134")]
		[Address(RVA = "0xB1D690", Offset = "0xB1BC90", VA = "0x180B1D690")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		// Token: 0x06000135 RID: 309
		[Token(Token = "0x6000135")]
		[Address(RVA = "0xB1D720", Offset = "0xB1BD20", VA = "0x180B1D720")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		// Token: 0x06000136 RID: 310
		[Token(Token = "0x6000136")]
		[Address(RVA = "0xB1D7B0", Offset = "0xB1BDB0", VA = "0x180B1D7B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		// Token: 0x06000137 RID: 311
		[Token(Token = "0x6000137")]
		[Address(RVA = "0xB1D850", Offset = "0xB1BE50", VA = "0x180B1D850")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		// Token: 0x06000138 RID: 312
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xB1D900", Offset = "0xB1BF00", VA = "0x180B1D900")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		// Token: 0x06000139 RID: 313
		[Token(Token = "0x6000139")]
		[Address(RVA = "0xB1D9A0", Offset = "0xB1BFA0", VA = "0x180B1D9A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		// Token: 0x0600013A RID: 314
		[Token(Token = "0x600013A")]
		[Address(RVA = "0xB1DA40", Offset = "0xB1C040", VA = "0x180B1DA40")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		// Token: 0x0600013B RID: 315
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xB1DB60", Offset = "0xB1C160", VA = "0x180B1DB60")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		// Token: 0x0600013C RID: 316
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xB1DC40", Offset = "0xB1C240", VA = "0x180B1DC40")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		// Token: 0x0600013D RID: 317
		[Token(Token = "0x600013D")]
		[Address(RVA = "0xB1DCD0", Offset = "0xB1C2D0", VA = "0x180B1DCD0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		// Token: 0x0600013E RID: 318
		[Token(Token = "0x600013E")]
		[Address(RVA = "0xB1DD60", Offset = "0xB1C360", VA = "0x180B1DD60")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		// Token: 0x0600013F RID: 319
		[Token(Token = "0x600013F")]
		[Address(RVA = "0xB1DE00", Offset = "0xB1C400", VA = "0x180B1DE00")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		// Token: 0x06000140 RID: 320
		[Token(Token = "0x6000140")]
		[Address(RVA = "0xB1DEA0", Offset = "0xB1C4A0", VA = "0x180B1DEA0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		// Token: 0x06000141 RID: 321
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xB1DF60", Offset = "0xB1C560", VA = "0x180B1DF60")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		// Token: 0x06000142 RID: 322
		[Token(Token = "0x6000142")]
		[Address(RVA = "0xB1DFF0", Offset = "0xB1C5F0", VA = "0x180B1DFF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		// Token: 0x06000143 RID: 323
		[Token(Token = "0x6000143")]
		[Address(RVA = "0xB1E090", Offset = "0xB1C690", VA = "0x180B1E090")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		// Token: 0x06000144 RID: 324
		[Token(Token = "0x6000144")]
		[Address(RVA = "0xB1E130", Offset = "0xB1C730", VA = "0x180B1E130")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		// Token: 0x06000145 RID: 325
		[Token(Token = "0x6000145")]
		[Address(RVA = "0xB1E1D0", Offset = "0xB1C7D0", VA = "0x180B1E1D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		// Token: 0x06000146 RID: 326
		[Token(Token = "0x6000146")]
		[Address(RVA = "0xB1E270", Offset = "0xB1C870", VA = "0x180B1E270")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		// Token: 0x06000147 RID: 327
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xB1E320", Offset = "0xB1C920", VA = "0x180B1E320")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		// Token: 0x06000148 RID: 328
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xB1E3B0", Offset = "0xB1C9B0", VA = "0x180B1E3B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		// Token: 0x06000149 RID: 329
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xB1E440", Offset = "0xB1CA40", VA = "0x180B1E440")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		// Token: 0x0600014A RID: 330
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xB1E4E0", Offset = "0xB1CAE0", VA = "0x180B1E4E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		// Token: 0x0600014B RID: 331
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xB1E580", Offset = "0xB1CB80", VA = "0x180B1E580")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		// Token: 0x0600014C RID: 332
		[Token(Token = "0x600014C")]
		[Address(RVA = "0xB1E740", Offset = "0xB1CD40", VA = "0x180B1E740")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		// Token: 0x0600014D RID: 333
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xB1E7E0", Offset = "0xB1CDE0", VA = "0x180B1E7E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		// Token: 0x0600014E RID: 334
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xB1E860", Offset = "0xB1CE60", VA = "0x180B1E860")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		// Token: 0x0600014F RID: 335
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xB1E8E0", Offset = "0xB1CEE0", VA = "0x180B1E8E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		// Token: 0x06000150 RID: 336
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xB1E9A0", Offset = "0xB1CFA0", VA = "0x180B1E9A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		// Token: 0x06000151 RID: 337
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xB1EA70", Offset = "0xB1D070", VA = "0x180B1EA70")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		// Token: 0x06000152 RID: 338
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xB1EB10", Offset = "0xB1D110", VA = "0x180B1EB10")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		// Token: 0x06000153 RID: 339
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xB1EBB0", Offset = "0xB1D1B0", VA = "0x180B1EBB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		// Token: 0x06000154 RID: 340
		[Token(Token = "0x6000154")]
		[Address(RVA = "0xB1EC70", Offset = "0xB1D270", VA = "0x180B1EC70")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		// Token: 0x06000155 RID: 341
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xB1ED20", Offset = "0xB1D320", VA = "0x180B1ED20")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		// Token: 0x06000156 RID: 342
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xB1EDB0", Offset = "0xB1D3B0", VA = "0x180B1EDB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		// Token: 0x06000157 RID: 343
		[Token(Token = "0x6000157")]
		[Address(RVA = "0xB1EE40", Offset = "0xB1D440", VA = "0x180B1EE40")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		// Token: 0x06000158 RID: 344
		[Token(Token = "0x6000158")]
		[Address(RVA = "0xB1EEF0", Offset = "0xB1D4F0", VA = "0x180B1EEF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		// Token: 0x06000159 RID: 345
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xB1EFA0", Offset = "0xB1D5A0", VA = "0x180B1EFA0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		// Token: 0x0600015A RID: 346
		[Token(Token = "0x600015A")]
		[Address(RVA = "0xB1F040", Offset = "0xB1D640", VA = "0x180B1F040")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		// Token: 0x0600015B RID: 347
		[Token(Token = "0x600015B")]
		[Address(RVA = "0xB1F0C0", Offset = "0xB1D6C0", VA = "0x180B1F0C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		// Token: 0x0600015C RID: 348
		[Token(Token = "0x600015C")]
		[Address(RVA = "0xB1F140", Offset = "0xB1D740", VA = "0x180B1F140")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		// Token: 0x0600015D RID: 349
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xB1F200", Offset = "0xB1D800", VA = "0x180B1F200")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		// Token: 0x0600015E RID: 350
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xB1F2A0", Offset = "0xB1D8A0", VA = "0x180B1F2A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		// Token: 0x0600015F RID: 351
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xB1F330", Offset = "0xB1D930", VA = "0x180B1F330")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		// Token: 0x06000160 RID: 352
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xB1F3C0", Offset = "0xB1D9C0", VA = "0x180B1F3C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		// Token: 0x06000161 RID: 353
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xB1F460", Offset = "0xB1DA60", VA = "0x180B1F460")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		// Token: 0x06000162 RID: 354
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xB1F500", Offset = "0xB1DB00", VA = "0x180B1F500")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		// Token: 0x06000163 RID: 355
		[Token(Token = "0x6000163")]
		[Address(RVA = "0xB1F5B0", Offset = "0xB1DBB0", VA = "0x180B1F5B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		// Token: 0x06000164 RID: 356
		[Token(Token = "0x6000164")]
		[Address(RVA = "0xB1F660", Offset = "0xB1DC60", VA = "0x180B1F660")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		// Token: 0x06000165 RID: 357
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xB1F850", Offset = "0xB1DE50", VA = "0x180B1F850")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		// Token: 0x06000166 RID: 358
		[Token(Token = "0x6000166")]
		[Address(RVA = "0xB1FA20", Offset = "0xB1E020", VA = "0x180B1FA20")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		// Token: 0x06000167 RID: 359
		[Token(Token = "0x6000167")]
		[Address(RVA = "0xB1FC10", Offset = "0xB1E210", VA = "0x180B1FC10")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		// Token: 0x06000168 RID: 360
		[Token(Token = "0x6000168")]
		[Address(RVA = "0xB1FDE0", Offset = "0xB1E3E0", VA = "0x180B1FDE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		// Token: 0x06000169 RID: 361
		[Token(Token = "0x6000169")]
		[Address(RVA = "0xB1FFA0", Offset = "0xB1E5A0", VA = "0x180B1FFA0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		// Token: 0x0600016A RID: 362
		[Token(Token = "0x600016A")]
		[Address(RVA = "0xB20040", Offset = "0xB1E640", VA = "0x180B20040")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		// Token: 0x0600016B RID: 363
		[Token(Token = "0x600016B")]
		[Address(RVA = "0xB200F0", Offset = "0xB1E6F0", VA = "0x180B200F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		// Token: 0x0600016C RID: 364
		[Token(Token = "0x600016C")]
		[Address(RVA = "0xB201A0", Offset = "0xB1E7A0", VA = "0x180B201A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		// Token: 0x0600016D RID: 365
		[Token(Token = "0x600016D")]
		[Address(RVA = "0xB20230", Offset = "0xB1E830", VA = "0x180B20230")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		// Token: 0x0600016E RID: 366
		[Token(Token = "0x600016E")]
		[Address(RVA = "0xB202E0", Offset = "0xB1E8E0", VA = "0x180B202E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		// Token: 0x0600016F RID: 367
		[Token(Token = "0x600016F")]
		[Address(RVA = "0xB20390", Offset = "0xB1E990", VA = "0x180B20390")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		// Token: 0x06000170 RID: 368
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xB20430", Offset = "0xB1EA30", VA = "0x180B20430")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		// Token: 0x06000171 RID: 369
		[Token(Token = "0x6000171")]
		[Address(RVA = "0xB204C0", Offset = "0xB1EAC0", VA = "0x180B204C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		// Token: 0x06000172 RID: 370
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xB20550", Offset = "0xB1EB50", VA = "0x180B20550")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		// Token: 0x06000173 RID: 371
		[Token(Token = "0x6000173")]
		[Address(RVA = "0xB20610", Offset = "0xB1EC10", VA = "0x180B20610")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		// Token: 0x06000174 RID: 372
		[Token(Token = "0x6000174")]
		[Address(RVA = "0xB206A0", Offset = "0xB1ECA0", VA = "0x180B206A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		// Token: 0x06000175 RID: 373
		[Token(Token = "0x6000175")]
		[Address(RVA = "0xB20740", Offset = "0xB1ED40", VA = "0x180B20740")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		// Token: 0x06000176 RID: 374
		[Token(Token = "0x6000176")]
		[Address(RVA = "0xB207E0", Offset = "0xB1EDE0", VA = "0x180B207E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		// Token: 0x06000177 RID: 375
		[Token(Token = "0x6000177")]
		[Address(RVA = "0xB20860", Offset = "0xB1EE60", VA = "0x180B20860")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		// Token: 0x06000178 RID: 376
		[Token(Token = "0x6000178")]
		[Address(RVA = "0xB208E0", Offset = "0xB1EEE0", VA = "0x180B208E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		// Token: 0x06000179 RID: 377
		[Token(Token = "0x6000179")]
		[Address(RVA = "0xB20980", Offset = "0xB1EF80", VA = "0x180B20980")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		// Token: 0x0600017A RID: 378
		[Token(Token = "0x600017A")]
		[Address(RVA = "0xB20A30", Offset = "0xB1F030", VA = "0x180B20A30")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		// Token: 0x0600017B RID: 379
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xB20AD0", Offset = "0xB1F0D0", VA = "0x180B20AD0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		// Token: 0x0600017C RID: 380
		[Token(Token = "0x600017C")]
		[Address(RVA = "0xB20B80", Offset = "0xB1F180", VA = "0x180B20B80")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		// Token: 0x0600017D RID: 381
		[Token(Token = "0x600017D")]
		[Address(RVA = "0xB20C10", Offset = "0xB1F210", VA = "0x180B20C10")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		// Token: 0x0600017E RID: 382
		[Token(Token = "0x600017E")]
		[Address(RVA = "0xB20CC0", Offset = "0xB1F2C0", VA = "0x180B20CC0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		// Token: 0x0600017F RID: 383
		[Token(Token = "0x600017F")]
		[Address(RVA = "0xB20D60", Offset = "0xB1F360", VA = "0x180B20D60")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		// Token: 0x06000180 RID: 384
		[Token(Token = "0x6000180")]
		[Address(RVA = "0xB20DF0", Offset = "0xB1F3F0", VA = "0x180B20DF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		// Token: 0x06000181 RID: 385
		[Token(Token = "0x6000181")]
		[Address(RVA = "0xB20E80", Offset = "0xB1F480", VA = "0x180B20E80")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		// Token: 0x06000182 RID: 386
		[Token(Token = "0x6000182")]
		[Address(RVA = "0xB20F30", Offset = "0xB1F530", VA = "0x180B20F30")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		// Token: 0x06000183 RID: 387
		[Token(Token = "0x6000183")]
		[Address(RVA = "0xB20FE0", Offset = "0xB1F5E0", VA = "0x180B20FE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		// Token: 0x06000184 RID: 388
		[Token(Token = "0x6000184")]
		[Address(RVA = "0xB21080", Offset = "0xB1F680", VA = "0x180B21080")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		// Token: 0x06000185 RID: 389
		[Token(Token = "0x6000185")]
		[Address(RVA = "0xB21120", Offset = "0xB1F720", VA = "0x180B21120")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		// Token: 0x06000186 RID: 390
		[Token(Token = "0x6000186")]
		[Address(RVA = "0xB211B0", Offset = "0xB1F7B0", VA = "0x180B211B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		// Token: 0x06000187 RID: 391
		[Token(Token = "0x6000187")]
		[Address(RVA = "0xB21240", Offset = "0xB1F840", VA = "0x180B21240")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		// Token: 0x06000188 RID: 392
		[Token(Token = "0x6000188")]
		[Address(RVA = "0xB212D0", Offset = "0xB1F8D0", VA = "0x180B212D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		// Token: 0x06000189 RID: 393 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x6000189")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
