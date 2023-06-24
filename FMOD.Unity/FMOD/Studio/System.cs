using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public struct System
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xB3FC70", Offset = "0xB3E270", VA = "0x180B3FC70")]
		public static RESULT create(out System system)
		{
			return RESULT.OK;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xB3FCF0", Offset = "0xB3E2F0", VA = "0x180B3FCF0")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return RESULT.OK;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xB3FE50", Offset = "0xB3E450", VA = "0x180B3FE50")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return RESULT.OK;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xB3FFC0", Offset = "0xB3E5C0", VA = "0x180B3FFC0")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return RESULT.OK;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00004CDC File Offset: 0x00002EDC
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xB40120", Offset = "0xB3E720", VA = "0x180B40120")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, INITFLAGS flags, IntPtr extradriverdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xB401D0", Offset = "0xB3E7D0", VA = "0x180B401D0")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xB40250", Offset = "0xB3E850", VA = "0x180B40250")]
		public RESULT update()
		{
			return RESULT.OK;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xB402D0", Offset = "0xB3E8D0", VA = "0x180B402D0")]
		public RESULT getCoreSystem(out System coresystem)
		{
			return RESULT.OK;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xB40360", Offset = "0xB3E960", VA = "0x180B40360")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return RESULT.OK;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xB404F0", Offset = "0xB3EAF0", VA = "0x180B404F0")]
		public RESULT getBus(string path, out Bus bus)
		{
			return RESULT.OK;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00004D6C File Offset: 0x00002F6C
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xB40680", Offset = "0xB3EC80", VA = "0x180B40680")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return RESULT.OK;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xB40810", Offset = "0xB3EE10", VA = "0x180B40810")]
		public RESULT getBank(string path, out Bank bank)
		{
			return RESULT.OK;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xB409A0", Offset = "0xB3EFA0", VA = "0x180B409A0")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return RESULT.OK;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xB40A40", Offset = "0xB3F040", VA = "0x180B40A40")]
		public RESULT getBusByID(Guid id, out Bus bus)
		{
			return RESULT.OK;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00004DCC File Offset: 0x00002FCC
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xB40AE0", Offset = "0xB3F0E0", VA = "0x180B40AE0")]
		public RESULT getVCAByID(Guid id, out VCA vca)
		{
			return RESULT.OK;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xB40B80", Offset = "0xB3F180", VA = "0x180B40B80")]
		public RESULT getBankByID(Guid id, out Bank bank)
		{
			return RESULT.OK;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00004DFC File Offset: 0x00002FFC
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xB40C20", Offset = "0xB3F220", VA = "0x180B40C20")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return RESULT.OK;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00004E14 File Offset: 0x00003014
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xB40FF0", Offset = "0xB3F5F0", VA = "0x180B40FF0")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return RESULT.OK;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00004E2C File Offset: 0x0000302C
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xB41180", Offset = "0xB3F780", VA = "0x180B41180")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return RESULT.OK;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00004E44 File Offset: 0x00003044
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xB41220", Offset = "0xB3F820", VA = "0x180B41220")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return RESULT.OK;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00004E5C File Offset: 0x0000305C
		[Token(Token = "0x6000500")]
		[Address(RVA = "0xB412D0", Offset = "0xB3F8D0", VA = "0x180B412D0")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return RESULT.OK;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00004E74 File Offset: 0x00003074
		[Token(Token = "0x6000501")]
		[Address(RVA = "0xB41380", Offset = "0xB3F980", VA = "0x180B41380")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return RESULT.OK;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00004E8C File Offset: 0x0000308C
		[Token(Token = "0x6000502")]
		[Address(RVA = "0xB41430", Offset = "0xB3FA30", VA = "0x180B41430")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return RESULT.OK;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00004EA4 File Offset: 0x000030A4
		[Token(Token = "0x6000503")]
		[Address(RVA = "0xB41500", Offset = "0xB3FB00", VA = "0x180B41500")]
		public RESULT getParameterByName(string name, out float value)
		{
			return RESULT.OK;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00004EBC File Offset: 0x000030BC
		[Token(Token = "0x6000504")]
		[Address(RVA = "0xB41530", Offset = "0xB3FB30", VA = "0x180B41530")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return RESULT.OK;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00004ED4 File Offset: 0x000030D4
		[Token(Token = "0x6000505")]
		[Address(RVA = "0xB416D0", Offset = "0xB3FCD0", VA = "0x180B416D0")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return RESULT.OK;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00004EEC File Offset: 0x000030EC
		[Token(Token = "0x6000506")]
		[Address(RVA = "0xB41880", Offset = "0xB3FE80", VA = "0x180B41880")]
		public RESULT lookupID(string path, out Guid id)
		{
			return RESULT.OK;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00004F04 File Offset: 0x00003104
		[Token(Token = "0x6000507")]
		[Address(RVA = "0xB41A10", Offset = "0xB40010", VA = "0x180B41A10")]
		public RESULT lookupPath(Guid id, out string path)
		{
			return RESULT.OK;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00004F1C File Offset: 0x0000311C
		[Token(Token = "0x6000508")]
		[Address(RVA = "0xB41DF0", Offset = "0xB403F0", VA = "0x180B41DF0")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return RESULT.OK;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00004F34 File Offset: 0x00003134
		[Token(Token = "0x6000509")]
		[Address(RVA = "0xB41E80", Offset = "0xB40480", VA = "0x180B41E80")]
		public RESULT setNumListeners(int numlisteners)
		{
			return RESULT.OK;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00004F4C File Offset: 0x0000314C
		[Token(Token = "0x600050A")]
		[Address(RVA = "0xB41F10", Offset = "0xB40510", VA = "0x180B41F10")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return RESULT.OK;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00004F64 File Offset: 0x00003164
		[Token(Token = "0x600050B")]
		[Address(RVA = "0xB41FB0", Offset = "0xB405B0", VA = "0x180B41FB0")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return RESULT.OK;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00004F7C File Offset: 0x0000317C
		[Token(Token = "0x600050C")]
		[Address(RVA = "0xB42050", Offset = "0xB40650", VA = "0x180B42050")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return RESULT.OK;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00004F94 File Offset: 0x00003194
		[Token(Token = "0x600050D")]
		[Address(RVA = "0xB420F0", Offset = "0xB406F0", VA = "0x180B420F0")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return RESULT.OK;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00004FAC File Offset: 0x000031AC
		[Token(Token = "0x600050E")]
		[Address(RVA = "0xB42190", Offset = "0xB40790", VA = "0x180B42190")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return RESULT.OK;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00004FC4 File Offset: 0x000031C4
		[Token(Token = "0x600050F")]
		[Address(RVA = "0xB42330", Offset = "0xB40930", VA = "0x180B42330")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return RESULT.OK;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00004FDC File Offset: 0x000031DC
		[Token(Token = "0x6000510")]
		[Address(RVA = "0xB424A0", Offset = "0xB40AA0", VA = "0x180B424A0")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return RESULT.OK;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00004FF4 File Offset: 0x000031F4
		[Token(Token = "0x6000511")]
		[Address(RVA = "0xB426E0", Offset = "0xB40CE0", VA = "0x180B426E0")]
		public RESULT unloadAll()
		{
			return RESULT.OK;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000500C File Offset: 0x0000320C
		[Token(Token = "0x6000512")]
		[Address(RVA = "0xB42760", Offset = "0xB40D60", VA = "0x180B42760")]
		public RESULT flushCommands()
		{
			return RESULT.OK;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00005024 File Offset: 0x00003224
		[Token(Token = "0x6000513")]
		[Address(RVA = "0xB427E0", Offset = "0xB40DE0", VA = "0x180B427E0")]
		public RESULT flushSampleLoading()
		{
			return RESULT.OK;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000503C File Offset: 0x0000323C
		[Token(Token = "0x6000514")]
		[Address(RVA = "0xB42860", Offset = "0xB40E60", VA = "0x180B42860")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return RESULT.OK;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00005054 File Offset: 0x00003254
		[Token(Token = "0x6000515")]
		[Address(RVA = "0xB429F0", Offset = "0xB40FF0", VA = "0x180B429F0")]
		public RESULT stopCommandCapture()
		{
			return RESULT.OK;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000506C File Offset: 0x0000326C
		[Token(Token = "0x6000516")]
		[Address(RVA = "0xB42A70", Offset = "0xB41070", VA = "0x180B42A70")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return RESULT.OK;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00005084 File Offset: 0x00003284
		[Token(Token = "0x6000517")]
		[Address(RVA = "0xB42C10", Offset = "0xB41210", VA = "0x180B42C10")]
		public RESULT getBankCount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000509C File Offset: 0x0000329C
		[Token(Token = "0x6000518")]
		[Address(RVA = "0xB42C20", Offset = "0xB41220", VA = "0x180B42C20")]
		public RESULT getBankList(out Bank[] array)
		{
			return RESULT.OK;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000050B4 File Offset: 0x000032B4
		[Token(Token = "0x6000519")]
		[Address(RVA = "0xB42EC0", Offset = "0xB414C0", VA = "0x180B42EC0")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000050CC File Offset: 0x000032CC
		[Token(Token = "0x600051A")]
		[Address(RVA = "0xB42ED0", Offset = "0xB414D0", VA = "0x180B42ED0")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return RESULT.OK;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000050E4 File Offset: 0x000032E4
		[Token(Token = "0x600051B")]
		[Address(RVA = "0xB43180", Offset = "0xB41780", VA = "0x180B43180")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return RESULT.OK;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000050FC File Offset: 0x000032FC
		[Token(Token = "0x600051C")]
		[Address(RVA = "0xB43210", Offset = "0xB41810", VA = "0x180B43210")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return RESULT.OK;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00005114 File Offset: 0x00003314
		[Token(Token = "0x600051D")]
		[Address(RVA = "0xB432A0", Offset = "0xB418A0", VA = "0x180B432A0")]
		public RESULT resetBufferUsage()
		{
			return RESULT.OK;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0000512C File Offset: 0x0000332C
		[Token(Token = "0x600051E")]
		[Address(RVA = "0xB43320", Offset = "0xB41920", VA = "0x180B43320")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return RESULT.OK;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00005144 File Offset: 0x00003344
		[Token(Token = "0x600051F")]
		[Address(RVA = "0xB433C0", Offset = "0xB419C0", VA = "0x180B433C0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0000515C File Offset: 0x0000335C
		[Token(Token = "0x6000520")]
		[Address(RVA = "0xB43450", Offset = "0xB41A50", VA = "0x180B43450")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000521 RID: 1313
		[Token(Token = "0x6000521")]
		[Address(RVA = "0xB434E0", Offset = "0xB41AE0", VA = "0x180B434E0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		// Token: 0x06000522 RID: 1314
		[Token(Token = "0x6000522")]
		[Address(RVA = "0xB43570", Offset = "0xB41B70", VA = "0x180B43570")]
		[PreserveSig]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		// Token: 0x06000523 RID: 1315
		[Token(Token = "0x6000523")]
		[Address(RVA = "0xB435F0", Offset = "0xB41BF0", VA = "0x180B435F0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		// Token: 0x06000524 RID: 1316
		[Token(Token = "0x6000524")]
		[Address(RVA = "0xB43680", Offset = "0xB41C80", VA = "0x180B43680")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		// Token: 0x06000525 RID: 1317
		[Token(Token = "0x6000525")]
		[Address(RVA = "0xB43710", Offset = "0xB41D10", VA = "0x180B43710")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, INITFLAGS flags, IntPtr extradriverdata);

		// Token: 0x06000526 RID: 1318
		[Token(Token = "0x6000526")]
		[Address(RVA = "0xB437C0", Offset = "0xB41DC0", VA = "0x180B437C0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		// Token: 0x06000527 RID: 1319
		[Token(Token = "0x6000527")]
		[Address(RVA = "0xB43840", Offset = "0xB41E40", VA = "0x180B43840")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		// Token: 0x06000528 RID: 1320
		[Token(Token = "0x6000528")]
		[Address(RVA = "0xB438C0", Offset = "0xB41EC0", VA = "0x180B438C0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		// Token: 0x06000529 RID: 1321
		[Token(Token = "0x6000529")]
		[Address(RVA = "0xB43950", Offset = "0xB41F50", VA = "0x180B43950")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		// Token: 0x0600052A RID: 1322
		[Token(Token = "0x600052A")]
		[Address(RVA = "0xB43A00", Offset = "0xB42000", VA = "0x180B43A00")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		// Token: 0x0600052B RID: 1323
		[Token(Token = "0x600052B")]
		[Address(RVA = "0xB43AB0", Offset = "0xB420B0", VA = "0x180B43AB0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		// Token: 0x0600052C RID: 1324
		[Token(Token = "0x600052C")]
		[Address(RVA = "0xB43B60", Offset = "0xB42160", VA = "0x180B43B60")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		// Token: 0x0600052D RID: 1325
		[Token(Token = "0x600052D")]
		[Address(RVA = "0xB43C10", Offset = "0xB42210", VA = "0x180B43C10")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		// Token: 0x0600052E RID: 1326
		[Token(Token = "0x600052E")]
		[Address(RVA = "0xB43CB0", Offset = "0xB422B0", VA = "0x180B43CB0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus);

		// Token: 0x0600052F RID: 1327
		[Token(Token = "0x600052F")]
		[Address(RVA = "0xB43D50", Offset = "0xB42350", VA = "0x180B43D50")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca);

		// Token: 0x06000530 RID: 1328
		[Token(Token = "0x6000530")]
		[Address(RVA = "0xB43DF0", Offset = "0xB423F0", VA = "0x180B43DF0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank);

		// Token: 0x06000531 RID: 1329
		[Token(Token = "0x6000531")]
		[Address(RVA = "0xB43E90", Offset = "0xB42490", VA = "0x180B43E90")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		// Token: 0x06000532 RID: 1330
		[Token(Token = "0x6000532")]
		[Address(RVA = "0xB44170", Offset = "0xB42770", VA = "0x180B44170")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		// Token: 0x06000533 RID: 1331
		[Token(Token = "0x6000533")]
		[Address(RVA = "0xB44220", Offset = "0xB42820", VA = "0x180B44220")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		// Token: 0x06000534 RID: 1332
		[Token(Token = "0x6000534")]
		[Address(RVA = "0xB442C0", Offset = "0xB428C0", VA = "0x180B442C0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue);

		// Token: 0x06000535 RID: 1333
		[Token(Token = "0x6000535")]
		[Address(RVA = "0xB44370", Offset = "0xB42970", VA = "0x180B44370")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed);

		// Token: 0x06000536 RID: 1334
		[Token(Token = "0x6000536")]
		[Address(RVA = "0xB44420", Offset = "0xB42A20", VA = "0x180B44420")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		// Token: 0x06000537 RID: 1335
		[Token(Token = "0x6000537")]
		[Address(RVA = "0xB444F0", Offset = "0xB42AF0", VA = "0x180B444F0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		// Token: 0x06000538 RID: 1336
		[Token(Token = "0x6000538")]
		[Address(RVA = "0xB445B0", Offset = "0xB42BB0", VA = "0x180B445B0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		// Token: 0x06000539 RID: 1337
		[Token(Token = "0x6000539")]
		[Address(RVA = "0xB44670", Offset = "0xB42C70", VA = "0x180B44670")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		// Token: 0x0600053A RID: 1338
		[Token(Token = "0x600053A")]
		[Address(RVA = "0xB44720", Offset = "0xB42D20", VA = "0x180B44720")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved);

		// Token: 0x0600053B RID: 1339
		[Token(Token = "0x600053B")]
		[Address(RVA = "0xB447D0", Offset = "0xB42DD0", VA = "0x180B447D0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		// Token: 0x0600053C RID: 1340
		[Token(Token = "0x600053C")]
		[Address(RVA = "0xB44860", Offset = "0xB42E60", VA = "0x180B44860")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		// Token: 0x0600053D RID: 1341
		[Token(Token = "0x600053D")]
		[Address(RVA = "0xB448F0", Offset = "0xB42EF0", VA = "0x180B448F0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes);

		// Token: 0x0600053E RID: 1342
		[Token(Token = "0x600053E")]
		[Address(RVA = "0xB44990", Offset = "0xB42F90", VA = "0x180B44990")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		// Token: 0x0600053F RID: 1343
		[Token(Token = "0x600053F")]
		[Address(RVA = "0xB44A30", Offset = "0xB43030", VA = "0x180B44A30")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		// Token: 0x06000540 RID: 1344
		[Token(Token = "0x6000540")]
		[Address(RVA = "0xB44AD0", Offset = "0xB430D0", VA = "0x180B44AD0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		// Token: 0x06000541 RID: 1345
		[Token(Token = "0x6000541")]
		[Address(RVA = "0xB44B70", Offset = "0xB43170", VA = "0x180B44B70")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		// Token: 0x06000542 RID: 1346
		[Token(Token = "0x6000542")]
		[Address(RVA = "0xB44C30", Offset = "0xB43230", VA = "0x180B44C30")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		// Token: 0x06000543 RID: 1347
		[Token(Token = "0x6000543")]
		[Address(RVA = "0xB44CE0", Offset = "0xB432E0", VA = "0x180B44CE0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		// Token: 0x06000544 RID: 1348
		[Token(Token = "0x6000544")]
		[Address(RVA = "0xB44E70", Offset = "0xB43470", VA = "0x180B44E70")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		// Token: 0x06000545 RID: 1349
		[Token(Token = "0x6000545")]
		[Address(RVA = "0xB44EF0", Offset = "0xB434F0", VA = "0x180B44EF0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		// Token: 0x06000546 RID: 1350
		[Token(Token = "0x6000546")]
		[Address(RVA = "0xB44F70", Offset = "0xB43570", VA = "0x180B44F70")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		// Token: 0x06000547 RID: 1351
		[Token(Token = "0x6000547")]
		[Address(RVA = "0xB44FF0", Offset = "0xB435F0", VA = "0x180B44FF0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		// Token: 0x06000548 RID: 1352
		[Token(Token = "0x6000548")]
		[Address(RVA = "0xB450A0", Offset = "0xB436A0", VA = "0x180B450A0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		// Token: 0x06000549 RID: 1353
		[Token(Token = "0x6000549")]
		[Address(RVA = "0xB45120", Offset = "0xB43720", VA = "0x180B45120")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		// Token: 0x0600054A RID: 1354
		[Token(Token = "0x600054A")]
		[Address(RVA = "0xB451E0", Offset = "0xB437E0", VA = "0x180B451E0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		// Token: 0x0600054B RID: 1355
		[Token(Token = "0x600054B")]
		[Address(RVA = "0xB45270", Offset = "0xB43870", VA = "0x180B45270")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		// Token: 0x0600054C RID: 1356
		[Token(Token = "0x600054C")]
		[Address(RVA = "0xB45330", Offset = "0xB43930", VA = "0x180B45330")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		// Token: 0x0600054D RID: 1357
		[Token(Token = "0x600054D")]
		[Address(RVA = "0xB453C0", Offset = "0xB439C0", VA = "0x180B453C0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		// Token: 0x0600054E RID: 1358
		[Token(Token = "0x600054E")]
		[Address(RVA = "0xB454F0", Offset = "0xB43AF0", VA = "0x180B454F0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		// Token: 0x0600054F RID: 1359
		[Token(Token = "0x600054F")]
		[Address(RVA = "0xB45580", Offset = "0xB43B80", VA = "0x180B45580")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		// Token: 0x06000550 RID: 1360
		[Token(Token = "0x6000550")]
		[Address(RVA = "0xB45610", Offset = "0xB43C10", VA = "0x180B45610")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		// Token: 0x06000551 RID: 1361
		[Token(Token = "0x6000551")]
		[Address(RVA = "0xB45690", Offset = "0xB43C90", VA = "0x180B45690")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		// Token: 0x06000552 RID: 1362
		[Token(Token = "0x6000552")]
		[Address(RVA = "0xB45730", Offset = "0xB43D30", VA = "0x180B45730")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		// Token: 0x06000553 RID: 1363
		[Token(Token = "0x6000553")]
		[Address(RVA = "0xB457C0", Offset = "0xB43DC0", VA = "0x180B457C0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		// Token: 0x06000554 RID: 1364 RVA: 0x00005174 File Offset: 0x00003374
		[Token(Token = "0x6000554")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000518C File Offset: 0x0000338C
		[Token(Token = "0x6000556")]
		[Address(RVA = "0xB45850", Offset = "0xB43E50", VA = "0x180B45850")]
		public bool isValid()
		{
			return default(bool);
		}

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
