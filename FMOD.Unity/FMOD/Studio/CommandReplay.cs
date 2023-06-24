using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	public struct CommandReplay
	{
		// Token: 0x0600062F RID: 1583 RVA: 0x00005C0C File Offset: 0x00003E0C
		[Token(Token = "0x600062F")]
		[Address(RVA = "0xB4EC90", Offset = "0xB4D290", VA = "0x180B4EC90")]
		public RESULT getSystem(out System system)
		{
			return RESULT.OK;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00005C24 File Offset: 0x00003E24
		[Token(Token = "0x6000630")]
		[Address(RVA = "0xB4ED20", Offset = "0xB4D320", VA = "0x180B4ED20")]
		public RESULT getLength(out float length)
		{
			return RESULT.OK;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00005C3C File Offset: 0x00003E3C
		[Token(Token = "0x6000631")]
		[Address(RVA = "0xB4EDB0", Offset = "0xB4D3B0", VA = "0x180B4EDB0")]
		public RESULT getCommandCount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00005C54 File Offset: 0x00003E54
		[Token(Token = "0x6000632")]
		[Address(RVA = "0xB4EE40", Offset = "0xB4D440", VA = "0x180B4EE40")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return RESULT.OK;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00005C6C File Offset: 0x00003E6C
		[Token(Token = "0x6000633")]
		[Address(RVA = "0xB4EEE0", Offset = "0xB4D4E0", VA = "0x180B4EEE0")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return RESULT.OK;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00005C84 File Offset: 0x00003E84
		[Token(Token = "0x6000634")]
		[Address(RVA = "0xB4F1D0", Offset = "0xB4D7D0", VA = "0x180B4F1D0")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return RESULT.OK;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00005C9C File Offset: 0x00003E9C
		[Token(Token = "0x6000635")]
		[Address(RVA = "0xB4F270", Offset = "0xB4D870", VA = "0x180B4F270")]
		public RESULT setBankPath(string bankPath)
		{
			return RESULT.OK;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00005CB4 File Offset: 0x00003EB4
		[Token(Token = "0x6000636")]
		[Address(RVA = "0xB4F3F0", Offset = "0xB4D9F0", VA = "0x180B4F3F0")]
		public RESULT start()
		{
			return RESULT.OK;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00005CCC File Offset: 0x00003ECC
		[Token(Token = "0x6000637")]
		[Address(RVA = "0xB4F470", Offset = "0xB4DA70", VA = "0x180B4F470")]
		public RESULT stop()
		{
			return RESULT.OK;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00005CE4 File Offset: 0x00003EE4
		[Token(Token = "0x6000638")]
		[Address(RVA = "0xB4F4F0", Offset = "0xB4DAF0", VA = "0x180B4F4F0")]
		public RESULT seekToTime(float time)
		{
			return RESULT.OK;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00005CFC File Offset: 0x00003EFC
		[Token(Token = "0x6000639")]
		[Address(RVA = "0xB4F580", Offset = "0xB4DB80", VA = "0x180B4F580")]
		public RESULT seekToCommand(int commandIndex)
		{
			return RESULT.OK;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00005D14 File Offset: 0x00003F14
		[Token(Token = "0x600063A")]
		[Address(RVA = "0xB4F610", Offset = "0xB4DC10", VA = "0x180B4F610")]
		public RESULT getPaused(out bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00005D2C File Offset: 0x00003F2C
		[Token(Token = "0x600063B")]
		[Address(RVA = "0xB4F6B0", Offset = "0xB4DCB0", VA = "0x180B4F6B0")]
		public RESULT setPaused(bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00005D44 File Offset: 0x00003F44
		[Token(Token = "0x600063C")]
		[Address(RVA = "0xB4F740", Offset = "0xB4DD40", VA = "0x180B4F740")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return RESULT.OK;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00005D5C File Offset: 0x00003F5C
		[Token(Token = "0x600063D")]
		[Address(RVA = "0xB4F7D0", Offset = "0xB4DDD0", VA = "0x180B4F7D0")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return RESULT.OK;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00005D74 File Offset: 0x00003F74
		[Token(Token = "0x600063E")]
		[Address(RVA = "0xB4F870", Offset = "0xB4DE70", VA = "0x180B4F870")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00005D8C File Offset: 0x00003F8C
		[Token(Token = "0x600063F")]
		[Address(RVA = "0xB4F8F0", Offset = "0xB4DEF0", VA = "0x180B4F8F0")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return RESULT.OK;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00005DA4 File Offset: 0x00003FA4
		[Token(Token = "0x6000640")]
		[Address(RVA = "0xB4F990", Offset = "0xB4DF90", VA = "0x180B4F990")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return RESULT.OK;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00005DBC File Offset: 0x00003FBC
		[Token(Token = "0x6000641")]
		[Address(RVA = "0xB4FA30", Offset = "0xB4E030", VA = "0x180B4FA30")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return RESULT.OK;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00005DD4 File Offset: 0x00003FD4
		[Token(Token = "0x6000642")]
		[Address(RVA = "0xB4FAD0", Offset = "0xB4E0D0", VA = "0x180B4FAD0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00005DEC File Offset: 0x00003FEC
		[Token(Token = "0x6000643")]
		[Address(RVA = "0xB4FB60", Offset = "0xB4E160", VA = "0x180B4FB60")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000644 RID: 1604
		[Token(Token = "0x6000644")]
		[Address(RVA = "0xB4FBF0", Offset = "0xB4E1F0", VA = "0x180B4FBF0")]
		[PreserveSig]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		// Token: 0x06000645 RID: 1605
		[Token(Token = "0x6000645")]
		[Address(RVA = "0xB4FC70", Offset = "0xB4E270", VA = "0x180B4FC70")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		// Token: 0x06000646 RID: 1606
		[Token(Token = "0x6000646")]
		[Address(RVA = "0xB4FD00", Offset = "0xB4E300", VA = "0x180B4FD00")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		// Token: 0x06000647 RID: 1607
		[Token(Token = "0x6000647")]
		[Address(RVA = "0xB4FD90", Offset = "0xB4E390", VA = "0x180B4FD90")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		// Token: 0x06000648 RID: 1608
		[Token(Token = "0x6000648")]
		[Address(RVA = "0xB4FE20", Offset = "0xB4E420", VA = "0x180B4FE20")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		// Token: 0x06000649 RID: 1609
		[Token(Token = "0x6000649")]
		[Address(RVA = "0xB4FEC0", Offset = "0xB4E4C0", VA = "0x180B4FEC0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		// Token: 0x0600064A RID: 1610
		[Token(Token = "0x600064A")]
		[Address(RVA = "0xB4FF60", Offset = "0xB4E560", VA = "0x180B4FF60")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		// Token: 0x0600064B RID: 1611
		[Token(Token = "0x600064B")]
		[Address(RVA = "0xB50000", Offset = "0xB4E600", VA = "0x180B50000")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		// Token: 0x0600064C RID: 1612
		[Token(Token = "0x600064C")]
		[Address(RVA = "0xB500A0", Offset = "0xB4E6A0", VA = "0x180B500A0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		// Token: 0x0600064D RID: 1613
		[Token(Token = "0x600064D")]
		[Address(RVA = "0xB50120", Offset = "0xB4E720", VA = "0x180B50120")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		// Token: 0x0600064E RID: 1614
		[Token(Token = "0x600064E")]
		[Address(RVA = "0xB501A0", Offset = "0xB4E7A0", VA = "0x180B501A0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		// Token: 0x0600064F RID: 1615
		[Token(Token = "0x600064F")]
		[Address(RVA = "0xB50230", Offset = "0xB4E830", VA = "0x180B50230")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		// Token: 0x06000650 RID: 1616
		[Token(Token = "0x6000650")]
		[Address(RVA = "0xB502C0", Offset = "0xB4E8C0", VA = "0x180B502C0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		// Token: 0x06000651 RID: 1617
		[Token(Token = "0x6000651")]
		[Address(RVA = "0xB50360", Offset = "0xB4E960", VA = "0x180B50360")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		// Token: 0x06000652 RID: 1618
		[Token(Token = "0x6000652")]
		[Address(RVA = "0xB503F0", Offset = "0xB4E9F0", VA = "0x180B503F0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		// Token: 0x06000653 RID: 1619
		[Token(Token = "0x6000653")]
		[Address(RVA = "0xB50480", Offset = "0xB4EA80", VA = "0x180B50480")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		// Token: 0x06000654 RID: 1620
		[Token(Token = "0x6000654")]
		[Address(RVA = "0xB50520", Offset = "0xB4EB20", VA = "0x180B50520")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		// Token: 0x06000655 RID: 1621
		[Token(Token = "0x6000655")]
		[Address(RVA = "0xB505A0", Offset = "0xB4EBA0", VA = "0x180B505A0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		// Token: 0x06000656 RID: 1622
		[Token(Token = "0x6000656")]
		[Address(RVA = "0xB50640", Offset = "0xB4EC40", VA = "0x180B50640")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		// Token: 0x06000657 RID: 1623
		[Token(Token = "0x6000657")]
		[Address(RVA = "0xB506E0", Offset = "0xB4ECE0", VA = "0x180B506E0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		// Token: 0x06000658 RID: 1624
		[Token(Token = "0x6000658")]
		[Address(RVA = "0xB50780", Offset = "0xB4ED80", VA = "0x180B50780")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		// Token: 0x06000659 RID: 1625
		[Token(Token = "0x6000659")]
		[Address(RVA = "0xB50810", Offset = "0xB4EE10", VA = "0x180B50810")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		// Token: 0x0600065A RID: 1626 RVA: 0x00005E04 File Offset: 0x00004004
		[Token(Token = "0x600065A")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00005E1C File Offset: 0x0000401C
		[Token(Token = "0x600065C")]
		[Address(RVA = "0xB508A0", Offset = "0xB4EEA0", VA = "0x180B508A0")]
		public bool isValid()
		{
			return default(bool);
		}

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
