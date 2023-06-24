using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public struct Sound
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x600018B")]
		[Address(RVA = "0xB21370", Offset = "0xB1F970", VA = "0x180B21370")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x600018C")]
		[Address(RVA = "0xB213F0", Offset = "0xB1F9F0", VA = "0x180B213F0")]
		public RESULT getSystemObject(out System system)
		{
			return RESULT.OK;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x600018D")]
		[Address(RVA = "0xB21480", Offset = "0xB1FA80", VA = "0x180B21480")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return RESULT.OK;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x600018E")]
		[Address(RVA = "0xB21530", Offset = "0xB1FB30", VA = "0x180B21530")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return RESULT.OK;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x600018F")]
		[Address(RVA = "0xB215E0", Offset = "0xB1FBE0", VA = "0x180B215E0")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return RESULT.OK;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x6000190")]
		[Address(RVA = "0xB21680", Offset = "0xB1FC80", VA = "0x180B21680")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return RESULT.OK;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x6000191")]
		[Address(RVA = "0xB21720", Offset = "0xB1FD20", VA = "0x180B21720")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return RESULT.OK;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x6000192")]
		[Address(RVA = "0xB217C0", Offset = "0xB1FDC0", VA = "0x180B217C0")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return RESULT.OK;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x6000193")]
		[Address(RVA = "0xB21860", Offset = "0xB1FE60", VA = "0x180B21860")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x6000194")]
		[Address(RVA = "0xB21920", Offset = "0xB1FF20", VA = "0x180B21920")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x6000195")]
		[Address(RVA = "0xB219D0", Offset = "0xB1FFD0", VA = "0x180B219D0")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return RESULT.OK;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x6000196")]
		[Address(RVA = "0xB21A70", Offset = "0xB20070", VA = "0x180B21A70")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return RESULT.OK;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x6000197")]
		[Address(RVA = "0xB21B10", Offset = "0xB20110", VA = "0x180B21B10")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return RESULT.OK;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x6000198")]
		[Address(RVA = "0xB21BB0", Offset = "0xB201B0", VA = "0x180B21BB0")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return RESULT.OK;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x6000199")]
		[Address(RVA = "0xB21C40", Offset = "0xB20240", VA = "0x180B21C40")]
		public RESULT getName(out string name, int namelen)
		{
			return RESULT.OK;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x600019A")]
		[Address(RVA = "0xB21E90", Offset = "0xB20490", VA = "0x180B21E90")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return RESULT.OK;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x600019B")]
		[Address(RVA = "0xB21F30", Offset = "0xB20530", VA = "0x180B21F30")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return RESULT.OK;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00003074 File Offset: 0x00001274
		[Token(Token = "0x600019C")]
		[Address(RVA = "0xB21FE0", Offset = "0xB205E0", VA = "0x180B21FE0")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return RESULT.OK;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x600019D")]
		[Address(RVA = "0xB22070", Offset = "0xB20670", VA = "0x180B22070")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return RESULT.OK;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x600019E")]
		[Address(RVA = "0xB22110", Offset = "0xB20710", VA = "0x180B22110")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return RESULT.OK;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x600019F")]
		[Address(RVA = "0xB22320", Offset = "0xB20920", VA = "0x180B22320")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000030D4 File Offset: 0x000012D4
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xB22410", Offset = "0xB20A10", VA = "0x180B22410")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000030EC File Offset: 0x000012EC
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xB224C0", Offset = "0xB20AC0", VA = "0x180B224C0")]
		public RESULT seekData(uint pcm)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00003104 File Offset: 0x00001304
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xB22550", Offset = "0xB20B50", VA = "0x180B22550")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xB225E0", Offset = "0xB20BE0", VA = "0x180B225E0")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xB22670", Offset = "0xB20C70", VA = "0x180B22670")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xB22700", Offset = "0xB20D00", VA = "0x180B22700")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xB227A0", Offset = "0xB20DA0", VA = "0x180B227A0")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xB229C0", Offset = "0xB20FC0", VA = "0x180B229C0")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xB229F0", Offset = "0xB20FF0", VA = "0x180B229F0")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return RESULT.OK;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xB22BA0", Offset = "0xB211A0", VA = "0x180B22BA0")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return RESULT.OK;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xB22C30", Offset = "0xB21230", VA = "0x180B22C30")]
		public RESULT setMode(MODE mode)
		{
			return RESULT.OK;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xB22CC0", Offset = "0xB212C0", VA = "0x180B22CC0")]
		public RESULT getMode(out MODE mode)
		{
			return RESULT.OK;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000031F4 File Offset: 0x000013F4
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xB22D50", Offset = "0xB21350", VA = "0x180B22D50")]
		public RESULT setLoopCount(int loopcount)
		{
			return RESULT.OK;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xB22DE0", Offset = "0xB213E0", VA = "0x180B22DE0")]
		public RESULT getLoopCount(out int loopcount)
		{
			return RESULT.OK;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xB22E70", Offset = "0xB21470", VA = "0x180B22E70")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return RESULT.OK;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000323C File Offset: 0x0000143C
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xB22F20", Offset = "0xB21520", VA = "0x180B22F20")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return RESULT.OK;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00003254 File Offset: 0x00001454
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xB22FD0", Offset = "0xB215D0", VA = "0x180B22FD0")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return RESULT.OK;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000326C File Offset: 0x0000146C
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xB23060", Offset = "0xB21660", VA = "0x180B23060")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00003284 File Offset: 0x00001484
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xB23100", Offset = "0xB21700", VA = "0x180B23100")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xB231A0", Offset = "0xB217A0", VA = "0x180B231A0")]
		public RESULT setMusicSpeed(float speed)
		{
			return RESULT.OK;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xB23230", Offset = "0xB21830", VA = "0x180B23230")]
		public RESULT getMusicSpeed(out float speed)
		{
			return RESULT.OK;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000032CC File Offset: 0x000014CC
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xB232C0", Offset = "0xB218C0", VA = "0x180B232C0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000032E4 File Offset: 0x000014E4
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xB23350", Offset = "0xB21950", VA = "0x180B23350")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060001B7 RID: 439
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xB233E0", Offset = "0xB219E0", VA = "0x180B233E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		// Token: 0x060001B8 RID: 440
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xB23460", Offset = "0xB21A60", VA = "0x180B23460")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		// Token: 0x060001B9 RID: 441
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xB234F0", Offset = "0xB21AF0", VA = "0x180B234F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		// Token: 0x060001BA RID: 442
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xB235A0", Offset = "0xB21BA0", VA = "0x180B235A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		// Token: 0x060001BB RID: 443
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xB23650", Offset = "0xB21C50", VA = "0x180B23650")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		// Token: 0x060001BC RID: 444
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xB236F0", Offset = "0xB21CF0", VA = "0x180B236F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		// Token: 0x060001BD RID: 445
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xB23790", Offset = "0xB21D90", VA = "0x180B23790")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		// Token: 0x060001BE RID: 446
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xB23830", Offset = "0xB21E30", VA = "0x180B23830")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		// Token: 0x060001BF RID: 447
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xB238D0", Offset = "0xB21ED0", VA = "0x180B238D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		// Token: 0x060001C0 RID: 448
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xB23990", Offset = "0xB21F90", VA = "0x180B23990")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		// Token: 0x060001C1 RID: 449
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xB23A40", Offset = "0xB22040", VA = "0x180B23A40")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		// Token: 0x060001C2 RID: 450
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xB23AE0", Offset = "0xB220E0", VA = "0x180B23AE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		// Token: 0x060001C3 RID: 451
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xB23B80", Offset = "0xB22180", VA = "0x180B23B80")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		// Token: 0x060001C4 RID: 452
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xB23C20", Offset = "0xB22220", VA = "0x180B23C20")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		// Token: 0x060001C5 RID: 453
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xB23CB0", Offset = "0xB222B0", VA = "0x180B23CB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		// Token: 0x060001C6 RID: 454
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xB23D50", Offset = "0xB22350", VA = "0x180B23D50")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		// Token: 0x060001C7 RID: 455
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xB23DF0", Offset = "0xB223F0", VA = "0x180B23DF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		// Token: 0x060001C8 RID: 456
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xB23EA0", Offset = "0xB224A0", VA = "0x180B23EA0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		// Token: 0x060001C9 RID: 457
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xB23F30", Offset = "0xB22530", VA = "0x180B23F30")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		// Token: 0x060001CA RID: 458
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xB23FD0", Offset = "0xB225D0", VA = "0x180B23FD0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		// Token: 0x060001CB RID: 459
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xB240D0", Offset = "0xB226D0", VA = "0x180B240D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		// Token: 0x060001CC RID: 460
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xB241C0", Offset = "0xB227C0", VA = "0x180B241C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		// Token: 0x060001CD RID: 461
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xB24270", Offset = "0xB22870", VA = "0x180B24270")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		// Token: 0x060001CE RID: 462
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xB24300", Offset = "0xB22900", VA = "0x180B24300")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		// Token: 0x060001CF RID: 463
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xB24390", Offset = "0xB22990", VA = "0x180B24390")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		// Token: 0x060001D0 RID: 464
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xB24420", Offset = "0xB22A20", VA = "0x180B24420")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		// Token: 0x060001D1 RID: 465
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xB244B0", Offset = "0xB22AB0", VA = "0x180B244B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		// Token: 0x060001D2 RID: 466
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xB24550", Offset = "0xB22B50", VA = "0x180B24550")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		// Token: 0x060001D3 RID: 467
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xB24600", Offset = "0xB22C00", VA = "0x180B24600")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		// Token: 0x060001D4 RID: 468
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xB246C0", Offset = "0xB22CC0", VA = "0x180B246C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		// Token: 0x060001D5 RID: 469
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xB24750", Offset = "0xB22D50", VA = "0x180B24750")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		// Token: 0x060001D6 RID: 470
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xB247E0", Offset = "0xB22DE0", VA = "0x180B247E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		// Token: 0x060001D7 RID: 471
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xB24870", Offset = "0xB22E70", VA = "0x180B24870")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		// Token: 0x060001D8 RID: 472
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xB24900", Offset = "0xB22F00", VA = "0x180B24900")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		// Token: 0x060001D9 RID: 473
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xB24990", Offset = "0xB22F90", VA = "0x180B24990")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		// Token: 0x060001DA RID: 474
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xB24A40", Offset = "0xB23040", VA = "0x180B24A40")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		// Token: 0x060001DB RID: 475
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xB24AF0", Offset = "0xB230F0", VA = "0x180B24AF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		// Token: 0x060001DC RID: 476
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xB24B80", Offset = "0xB23180", VA = "0x180B24B80")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		// Token: 0x060001DD RID: 477
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xB24C20", Offset = "0xB23220", VA = "0x180B24C20")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		// Token: 0x060001DE RID: 478
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xB24CC0", Offset = "0xB232C0", VA = "0x180B24CC0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xB24D50", Offset = "0xB23350", VA = "0x180B24D50")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		// Token: 0x060001E0 RID: 480
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xB24DE0", Offset = "0xB233E0", VA = "0x180B24DE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		// Token: 0x060001E1 RID: 481
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xB24E70", Offset = "0xB23470", VA = "0x180B24E70")]
		[PreserveSig]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		// Token: 0x060001E2 RID: 482 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
