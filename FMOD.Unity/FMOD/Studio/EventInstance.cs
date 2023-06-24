using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	public struct EventInstance
	{
		// Token: 0x06000593 RID: 1427 RVA: 0x00005474 File Offset: 0x00003674
		[Token(Token = "0x6000593")]
		[Address(RVA = "0xB48280", Offset = "0xB46880", VA = "0x180B48280")]
		public RESULT getDescription(out EventDescription description)
		{
			return RESULT.OK;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0000548C File Offset: 0x0000368C
		[Token(Token = "0x6000594")]
		[Address(RVA = "0xB48310", Offset = "0xB46910", VA = "0x180B48310")]
		public RESULT getVolume(out float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000054A4 File Offset: 0x000036A4
		[Token(Token = "0x6000595")]
		[Address(RVA = "0xB483B0", Offset = "0xB469B0", VA = "0x180B483B0")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000054BC File Offset: 0x000036BC
		[Token(Token = "0x6000596")]
		[Address(RVA = "0xB48450", Offset = "0xB46A50", VA = "0x180B48450")]
		public RESULT setVolume(float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000054D4 File Offset: 0x000036D4
		[Token(Token = "0x6000597")]
		[Address(RVA = "0xB484E0", Offset = "0xB46AE0", VA = "0x180B484E0")]
		public RESULT getPitch(out float pitch)
		{
			return RESULT.OK;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000054EC File Offset: 0x000036EC
		[Token(Token = "0x6000598")]
		[Address(RVA = "0xB48580", Offset = "0xB46B80", VA = "0x180B48580")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return RESULT.OK;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00005504 File Offset: 0x00003704
		[Token(Token = "0x6000599")]
		[Address(RVA = "0xB48620", Offset = "0xB46C20", VA = "0x180B48620")]
		public RESULT setPitch(float pitch)
		{
			return RESULT.OK;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000551C File Offset: 0x0000371C
		[Token(Token = "0x600059A")]
		[Address(RVA = "0xB486B0", Offset = "0xB46CB0", VA = "0x180B486B0")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return RESULT.OK;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00005534 File Offset: 0x00003734
		[Token(Token = "0x600059B")]
		[Address(RVA = "0xB48740", Offset = "0xB46D40", VA = "0x180B48740")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return RESULT.OK;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000554C File Offset: 0x0000374C
		[Token(Token = "0x600059C")]
		[Address(RVA = "0xB487D0", Offset = "0xB46DD0", VA = "0x180B487D0")]
		public RESULT getListenerMask(out uint mask)
		{
			return RESULT.OK;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00005564 File Offset: 0x00003764
		[Token(Token = "0x600059D")]
		[Address(RVA = "0xB48860", Offset = "0xB46E60", VA = "0x180B48860")]
		public RESULT setListenerMask(uint mask)
		{
			return RESULT.OK;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000557C File Offset: 0x0000377C
		[Token(Token = "0x600059E")]
		[Address(RVA = "0xB488F0", Offset = "0xB46EF0", VA = "0x180B488F0")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return RESULT.OK;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00005594 File Offset: 0x00003794
		[Token(Token = "0x600059F")]
		[Address(RVA = "0xB48990", Offset = "0xB46F90", VA = "0x180B48990")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return RESULT.OK;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000055AC File Offset: 0x000037AC
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xB48A30", Offset = "0xB47030", VA = "0x180B48A30")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return RESULT.OK;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000055C4 File Offset: 0x000037C4
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xB48AD0", Offset = "0xB470D0", VA = "0x180B48AD0")]
		public RESULT setReverbLevel(int index, float level)
		{
			return RESULT.OK;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000055DC File Offset: 0x000037DC
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xB48B70", Offset = "0xB47170", VA = "0x180B48B70")]
		public RESULT getPaused(out bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000055F4 File Offset: 0x000037F4
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xB48C10", Offset = "0xB47210", VA = "0x180B48C10")]
		public RESULT setPaused(bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000560C File Offset: 0x0000380C
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xB48CA0", Offset = "0xB472A0", VA = "0x180B48CA0")]
		public RESULT start()
		{
			return RESULT.OK;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00005624 File Offset: 0x00003824
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xB48D20", Offset = "0xB47320", VA = "0x180B48D20")]
		public RESULT stop(STOP_MODE mode)
		{
			return RESULT.OK;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000563C File Offset: 0x0000383C
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xB48DB0", Offset = "0xB473B0", VA = "0x180B48DB0")]
		public RESULT getTimelinePosition(out int position)
		{
			return RESULT.OK;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00005654 File Offset: 0x00003854
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xB48E40", Offset = "0xB47440", VA = "0x180B48E40")]
		public RESULT setTimelinePosition(int position)
		{
			return RESULT.OK;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000566C File Offset: 0x0000386C
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xB48ED0", Offset = "0xB474D0", VA = "0x180B48ED0")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return RESULT.OK;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00005684 File Offset: 0x00003884
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xB48F60", Offset = "0xB47560", VA = "0x180B48F60")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return RESULT.OK;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000569C File Offset: 0x0000389C
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xB48FF0", Offset = "0xB475F0", VA = "0x180B48FF0")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000056B4 File Offset: 0x000038B4
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xB49070", Offset = "0xB47670", VA = "0x180B49070")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return RESULT.OK;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000056CC File Offset: 0x000038CC
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xB49110", Offset = "0xB47710", VA = "0x180B49110")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return RESULT.OK;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000056E4 File Offset: 0x000038E4
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xB491C0", Offset = "0xB477C0", VA = "0x180B491C0")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return RESULT.OK;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000056FC File Offset: 0x000038FC
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xB49270", Offset = "0xB47870", VA = "0x180B49270")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return RESULT.OK;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00005714 File Offset: 0x00003914
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xB49320", Offset = "0xB47920", VA = "0x180B49320")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return RESULT.OK;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000572C File Offset: 0x0000392C
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xB493F0", Offset = "0xB479F0", VA = "0x180B493F0")]
		public RESULT getParameterByName(string name, out float value)
		{
			return RESULT.OK;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00005744 File Offset: 0x00003944
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xB49420", Offset = "0xB47A20", VA = "0x180B49420")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return RESULT.OK;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000575C File Offset: 0x0000395C
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xB495C0", Offset = "0xB47BC0", VA = "0x180B495C0")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return RESULT.OK;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00005774 File Offset: 0x00003974
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xB49770", Offset = "0xB47D70", VA = "0x180B49770")]
		public RESULT triggerCue()
		{
			return RESULT.OK;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000578C File Offset: 0x0000398C
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xB497F0", Offset = "0xB47DF0", VA = "0x180B497F0")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return RESULT.OK;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000057A4 File Offset: 0x000039A4
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xB49890", Offset = "0xB47E90", VA = "0x180B49890")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000057BC File Offset: 0x000039BC
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xB49920", Offset = "0xB47F20", VA = "0x180B49920")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000057D4 File Offset: 0x000039D4
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xB499B0", Offset = "0xB47FB0", VA = "0x180B499B0")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return RESULT.OK;
		}

		// Token: 0x060005B8 RID: 1464
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xB49A50", Offset = "0xB48050", VA = "0x180B49A50")]
		[PreserveSig]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		// Token: 0x060005B9 RID: 1465
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xB49AD0", Offset = "0xB480D0", VA = "0x180B49AD0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		// Token: 0x060005BA RID: 1466
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xB49B60", Offset = "0xB48160", VA = "0x180B49B60")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		// Token: 0x060005BB RID: 1467
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xB49C00", Offset = "0xB48200", VA = "0x180B49C00")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		// Token: 0x060005BC RID: 1468
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xB49C90", Offset = "0xB48290", VA = "0x180B49C90")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		// Token: 0x060005BD RID: 1469
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xB49D30", Offset = "0xB48330", VA = "0x180B49D30")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		// Token: 0x060005BE RID: 1470
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xB49DC0", Offset = "0xB483C0", VA = "0x180B49DC0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		// Token: 0x060005BF RID: 1471
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xB49E50", Offset = "0xB48450", VA = "0x180B49E50")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		// Token: 0x060005C0 RID: 1472
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xB49EE0", Offset = "0xB484E0", VA = "0x180B49EE0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		// Token: 0x060005C1 RID: 1473
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xB49F70", Offset = "0xB48570", VA = "0x180B49F70")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		// Token: 0x060005C2 RID: 1474
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xB4A000", Offset = "0xB48600", VA = "0x180B4A000")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		// Token: 0x060005C3 RID: 1475
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xB4A0A0", Offset = "0xB486A0", VA = "0x180B4A0A0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		// Token: 0x060005C4 RID: 1476
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xB4A140", Offset = "0xB48740", VA = "0x180B4A140")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		// Token: 0x060005C5 RID: 1477
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xB4A1E0", Offset = "0xB487E0", VA = "0x180B4A1E0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		// Token: 0x060005C6 RID: 1478
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xB4A280", Offset = "0xB48880", VA = "0x180B4A280")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		// Token: 0x060005C7 RID: 1479
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xB4A320", Offset = "0xB48920", VA = "0x180B4A320")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		// Token: 0x060005C8 RID: 1480
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xB4A3B0", Offset = "0xB489B0", VA = "0x180B4A3B0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		// Token: 0x060005C9 RID: 1481
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xB4A430", Offset = "0xB48A30", VA = "0x180B4A430")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		// Token: 0x060005CA RID: 1482
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xB4A4C0", Offset = "0xB48AC0", VA = "0x180B4A4C0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		// Token: 0x060005CB RID: 1483
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xB4A550", Offset = "0xB48B50", VA = "0x180B4A550")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		// Token: 0x060005CC RID: 1484
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xB4A5E0", Offset = "0xB48BE0", VA = "0x180B4A5E0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		// Token: 0x060005CD RID: 1485
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xB4A670", Offset = "0xB48C70", VA = "0x180B4A670")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		// Token: 0x060005CE RID: 1486
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xB4A700", Offset = "0xB48D00", VA = "0x180B4A700")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		// Token: 0x060005CF RID: 1487
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xB4A780", Offset = "0xB48D80", VA = "0x180B4A780")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		// Token: 0x060005D0 RID: 1488
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xB4A820", Offset = "0xB48E20", VA = "0x180B4A820")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		// Token: 0x060005D1 RID: 1489
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xB4A8E0", Offset = "0xB48EE0", VA = "0x180B4A8E0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		// Token: 0x060005D2 RID: 1490
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xB4A9A0", Offset = "0xB48FA0", VA = "0x180B4A9A0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue);

		// Token: 0x060005D3 RID: 1491
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xB4AA50", Offset = "0xB49050", VA = "0x180B4AA50")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		// Token: 0x060005D4 RID: 1492
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xB4AB00", Offset = "0xB49100", VA = "0x180B4AB00")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		// Token: 0x060005D5 RID: 1493
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xB4ABD0", Offset = "0xB491D0", VA = "0x180B4ABD0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		// Token: 0x060005D6 RID: 1494
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xB4AC50", Offset = "0xB49250", VA = "0x180B4AC50")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		// Token: 0x060005D7 RID: 1495
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xB4ACF0", Offset = "0xB492F0", VA = "0x180B4ACF0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		// Token: 0x060005D8 RID: 1496
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xB4AD80", Offset = "0xB49380", VA = "0x180B4AD80")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		// Token: 0x060005D9 RID: 1497
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xB4AE10", Offset = "0xB49410", VA = "0x180B4AE10")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventInstance_GetCPUUsage(IntPtr _event, out uint exclusive, out uint inclusive);

		// Token: 0x060005DA RID: 1498 RVA: 0x000057EC File Offset: 0x000039EC
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00005804 File Offset: 0x00003A04
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xB4AEB0", Offset = "0xB494B0", VA = "0x180B4AEB0")]
		public bool isValid()
		{
			return default(bool);
		}

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
