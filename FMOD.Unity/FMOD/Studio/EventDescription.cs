using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	public struct EventDescription
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x000051A4 File Offset: 0x000033A4
		[Token(Token = "0x6000557")]
		[Address(RVA = "0xB458E0", Offset = "0xB43EE0", VA = "0x180B458E0")]
		public RESULT getID(out Guid id)
		{
			return RESULT.OK;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000051BC File Offset: 0x000033BC
		[Token(Token = "0x6000558")]
		[Address(RVA = "0xB45970", Offset = "0xB43F70", VA = "0x180B45970")]
		public RESULT getPath(out string path)
		{
			return RESULT.OK;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000051D4 File Offset: 0x000033D4
		[Token(Token = "0x6000559")]
		[Address(RVA = "0xB45D20", Offset = "0xB44320", VA = "0x180B45D20")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000051EC File Offset: 0x000033EC
		[Token(Token = "0x600055A")]
		[Address(RVA = "0xB45DB0", Offset = "0xB443B0", VA = "0x180B45DB0")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return RESULT.OK;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00005204 File Offset: 0x00003404
		[Token(Token = "0x600055B")]
		[Address(RVA = "0xB45E50", Offset = "0xB44450", VA = "0x180B45E50")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return RESULT.OK;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000521C File Offset: 0x0000341C
		[Token(Token = "0x600055C")]
		[Address(RVA = "0xB45FE0", Offset = "0xB445E0", VA = "0x180B45FE0")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return RESULT.OK;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00005234 File Offset: 0x00003434
		[Token(Token = "0x600055D")]
		[Address(RVA = "0xB46080", Offset = "0xB44680", VA = "0x180B46080")]
		public RESULT getUserPropertyCount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000524C File Offset: 0x0000344C
		[Token(Token = "0x600055E")]
		[Address(RVA = "0xB46110", Offset = "0xB44710", VA = "0x180B46110")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return RESULT.OK;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00005264 File Offset: 0x00003464
		[Token(Token = "0x600055F")]
		[Address(RVA = "0xB461F0", Offset = "0xB447F0", VA = "0x180B461F0")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return RESULT.OK;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000527C File Offset: 0x0000347C
		[Token(Token = "0x6000560")]
		[Address(RVA = "0xB463D0", Offset = "0xB449D0", VA = "0x180B463D0")]
		public RESULT getLength(out int length)
		{
			return RESULT.OK;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00005294 File Offset: 0x00003494
		[Token(Token = "0x6000561")]
		[Address(RVA = "0xB46460", Offset = "0xB44A60", VA = "0x180B46460")]
		public RESULT getMinimumDistance(out float distance)
		{
			return RESULT.OK;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000052AC File Offset: 0x000034AC
		[Token(Token = "0x6000562")]
		[Address(RVA = "0xB464F0", Offset = "0xB44AF0", VA = "0x180B464F0")]
		public RESULT getMaximumDistance(out float distance)
		{
			return RESULT.OK;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000052C4 File Offset: 0x000034C4
		[Token(Token = "0x6000563")]
		[Address(RVA = "0xB46580", Offset = "0xB44B80", VA = "0x180B46580")]
		public RESULT getSoundSize(out float size)
		{
			return RESULT.OK;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000052DC File Offset: 0x000034DC
		[Token(Token = "0x6000564")]
		[Address(RVA = "0xB46610", Offset = "0xB44C10", VA = "0x180B46610")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return RESULT.OK;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000052F4 File Offset: 0x000034F4
		[Token(Token = "0x6000565")]
		[Address(RVA = "0xB466B0", Offset = "0xB44CB0", VA = "0x180B466B0")]
		public RESULT isOneshot(out bool oneshot)
		{
			return RESULT.OK;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000530C File Offset: 0x0000350C
		[Token(Token = "0x6000566")]
		[Address(RVA = "0xB46750", Offset = "0xB44D50", VA = "0x180B46750")]
		public RESULT isStream(out bool isStream)
		{
			return RESULT.OK;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00005324 File Offset: 0x00003524
		[Token(Token = "0x6000567")]
		[Address(RVA = "0xB467F0", Offset = "0xB44DF0", VA = "0x180B467F0")]
		public RESULT is3D(out bool is3D)
		{
			return RESULT.OK;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000533C File Offset: 0x0000353C
		[Token(Token = "0x6000568")]
		[Address(RVA = "0xB46890", Offset = "0xB44E90", VA = "0x180B46890")]
		public RESULT hasCue(out bool cue)
		{
			return RESULT.OK;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00005354 File Offset: 0x00003554
		[Token(Token = "0x6000569")]
		[Address(RVA = "0xB46930", Offset = "0xB44F30", VA = "0x180B46930")]
		public RESULT createInstance(out EventInstance instance)
		{
			return RESULT.OK;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000536C File Offset: 0x0000356C
		[Token(Token = "0x600056A")]
		[Address(RVA = "0xB469C0", Offset = "0xB44FC0", VA = "0x180B469C0")]
		public RESULT getInstanceCount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00005384 File Offset: 0x00003584
		[Token(Token = "0x600056B")]
		[Address(RVA = "0xB469D0", Offset = "0xB44FD0", VA = "0x180B469D0")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return RESULT.OK;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000539C File Offset: 0x0000359C
		[Token(Token = "0x600056C")]
		[Address(RVA = "0xB46C70", Offset = "0xB45270", VA = "0x180B46C70")]
		public RESULT loadSampleData()
		{
			return RESULT.OK;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000053B4 File Offset: 0x000035B4
		[Token(Token = "0x600056D")]
		[Address(RVA = "0xB46CF0", Offset = "0xB452F0", VA = "0x180B46CF0")]
		public RESULT unloadSampleData()
		{
			return RESULT.OK;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000053CC File Offset: 0x000035CC
		[Token(Token = "0x600056E")]
		[Address(RVA = "0xB46D70", Offset = "0xB45370", VA = "0x180B46D70")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return RESULT.OK;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000053E4 File Offset: 0x000035E4
		[Token(Token = "0x600056F")]
		[Address(RVA = "0xB46E00", Offset = "0xB45400", VA = "0x180B46E00")]
		public RESULT releaseAllInstances()
		{
			return RESULT.OK;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000053FC File Offset: 0x000035FC
		[Token(Token = "0x6000570")]
		[Address(RVA = "0xB46E80", Offset = "0xB45480", VA = "0x180B46E80")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return RESULT.OK;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00005414 File Offset: 0x00003614
		[Token(Token = "0x6000571")]
		[Address(RVA = "0xB46F20", Offset = "0xB45520", VA = "0x180B46F20")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000542C File Offset: 0x0000362C
		[Token(Token = "0x6000572")]
		[Address(RVA = "0xB46FB0", Offset = "0xB455B0", VA = "0x180B46FB0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000573 RID: 1395
		[Token(Token = "0x6000573")]
		[Address(RVA = "0xB47040", Offset = "0xB45640", VA = "0x180B47040")]
		[PreserveSig]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		// Token: 0x06000574 RID: 1396
		[Token(Token = "0x6000574")]
		[Address(RVA = "0xB470C0", Offset = "0xB456C0", VA = "0x180B470C0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		// Token: 0x06000575 RID: 1397
		[Token(Token = "0x6000575")]
		[Address(RVA = "0xB47150", Offset = "0xB45750", VA = "0x180B47150")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		// Token: 0x06000576 RID: 1398
		[Token(Token = "0x6000576")]
		[Address(RVA = "0xB47200", Offset = "0xB45800", VA = "0x180B47200")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		// Token: 0x06000577 RID: 1399
		[Token(Token = "0x6000577")]
		[Address(RVA = "0xB47290", Offset = "0xB45890", VA = "0x180B47290")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		// Token: 0x06000578 RID: 1400
		[Token(Token = "0x6000578")]
		[Address(RVA = "0xB47330", Offset = "0xB45930", VA = "0x180B47330")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		// Token: 0x06000579 RID: 1401
		[Token(Token = "0x6000579")]
		[Address(RVA = "0xB473E0", Offset = "0xB459E0", VA = "0x180B473E0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		// Token: 0x0600057A RID: 1402
		[Token(Token = "0x600057A")]
		[Address(RVA = "0xB47480", Offset = "0xB45A80", VA = "0x180B47480")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		// Token: 0x0600057B RID: 1403
		[Token(Token = "0x600057B")]
		[Address(RVA = "0xB47510", Offset = "0xB45B10", VA = "0x180B47510")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		// Token: 0x0600057C RID: 1404
		[Token(Token = "0x600057C")]
		[Address(RVA = "0xB475F0", Offset = "0xB45BF0", VA = "0x180B475F0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		// Token: 0x0600057D RID: 1405
		[Token(Token = "0x600057D")]
		[Address(RVA = "0xB476E0", Offset = "0xB45CE0", VA = "0x180B476E0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		// Token: 0x0600057E RID: 1406
		[Token(Token = "0x600057E")]
		[Address(RVA = "0xB47770", Offset = "0xB45D70", VA = "0x180B47770")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		// Token: 0x0600057F RID: 1407
		[Token(Token = "0x600057F")]
		[Address(RVA = "0xB47800", Offset = "0xB45E00", VA = "0x180B47800")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		// Token: 0x06000580 RID: 1408
		[Token(Token = "0x6000580")]
		[Address(RVA = "0xB47890", Offset = "0xB45E90", VA = "0x180B47890")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		// Token: 0x06000581 RID: 1409
		[Token(Token = "0x6000581")]
		[Address(RVA = "0xB47920", Offset = "0xB45F20", VA = "0x180B47920")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		// Token: 0x06000582 RID: 1410
		[Token(Token = "0x6000582")]
		[Address(RVA = "0xB479C0", Offset = "0xB45FC0", VA = "0x180B479C0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		// Token: 0x06000583 RID: 1411
		[Token(Token = "0x6000583")]
		[Address(RVA = "0xB47A60", Offset = "0xB46060", VA = "0x180B47A60")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		// Token: 0x06000584 RID: 1412
		[Token(Token = "0x6000584")]
		[Address(RVA = "0xB47B00", Offset = "0xB46100", VA = "0x180B47B00")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		// Token: 0x06000585 RID: 1413
		[Token(Token = "0x6000585")]
		[Address(RVA = "0xB47BA0", Offset = "0xB461A0", VA = "0x180B47BA0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		// Token: 0x06000586 RID: 1414
		[Token(Token = "0x6000586")]
		[Address(RVA = "0xB47C40", Offset = "0xB46240", VA = "0x180B47C40")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		// Token: 0x06000587 RID: 1415
		[Token(Token = "0x6000587")]
		[Address(RVA = "0xB47CD0", Offset = "0xB462D0", VA = "0x180B47CD0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		// Token: 0x06000588 RID: 1416
		[Token(Token = "0x6000588")]
		[Address(RVA = "0xB47D60", Offset = "0xB46360", VA = "0x180B47D60")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		// Token: 0x06000589 RID: 1417
		[Token(Token = "0x6000589")]
		[Address(RVA = "0xB47E20", Offset = "0xB46420", VA = "0x180B47E20")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		// Token: 0x0600058A RID: 1418
		[Token(Token = "0x600058A")]
		[Address(RVA = "0xB47EA0", Offset = "0xB464A0", VA = "0x180B47EA0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		// Token: 0x0600058B RID: 1419
		[Token(Token = "0x600058B")]
		[Address(RVA = "0xB47F20", Offset = "0xB46520", VA = "0x180B47F20")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		// Token: 0x0600058C RID: 1420
		[Token(Token = "0x600058C")]
		[Address(RVA = "0xB47FB0", Offset = "0xB465B0", VA = "0x180B47FB0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		// Token: 0x0600058D RID: 1421
		[Token(Token = "0x600058D")]
		[Address(RVA = "0xB48030", Offset = "0xB46630", VA = "0x180B48030")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		// Token: 0x0600058E RID: 1422
		[Token(Token = "0x600058E")]
		[Address(RVA = "0xB480D0", Offset = "0xB466D0", VA = "0x180B480D0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		// Token: 0x0600058F RID: 1423
		[Token(Token = "0x600058F")]
		[Address(RVA = "0xB48160", Offset = "0xB46760", VA = "0x180B48160")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		// Token: 0x06000590 RID: 1424 RVA: 0x00005444 File Offset: 0x00003644
		[Token(Token = "0x6000590")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000545C File Offset: 0x0000365C
		[Token(Token = "0x6000592")]
		[Address(RVA = "0xB481F0", Offset = "0xB467F0", VA = "0x180B481F0")]
		public bool isValid()
		{
			return default(bool);
		}

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
