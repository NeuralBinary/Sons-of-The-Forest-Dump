using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	public struct Bus
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x0000581C File Offset: 0x00003A1C
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xB4AF40", Offset = "0xB49540", VA = "0x180B4AF40")]
		public RESULT getID(out Guid id)
		{
			return RESULT.OK;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00005834 File Offset: 0x00003A34
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xB4AFD0", Offset = "0xB495D0", VA = "0x180B4AFD0")]
		public RESULT getPath(out string path)
		{
			return RESULT.OK;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000584C File Offset: 0x00003A4C
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xB4B380", Offset = "0xB49980", VA = "0x180B4B380")]
		public RESULT getVolume(out float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00005864 File Offset: 0x00003A64
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xB4B420", Offset = "0xB49A20", VA = "0x180B4B420")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return RESULT.OK;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000587C File Offset: 0x00003A7C
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xB4B4C0", Offset = "0xB49AC0", VA = "0x180B4B4C0")]
		public RESULT setVolume(float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00005894 File Offset: 0x00003A94
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xB4B550", Offset = "0xB49B50", VA = "0x180B4B550")]
		public RESULT getPaused(out bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000058AC File Offset: 0x00003AAC
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xB4B5F0", Offset = "0xB49BF0", VA = "0x180B4B5F0")]
		public RESULT setPaused(bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000058C4 File Offset: 0x00003AC4
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xB4B680", Offset = "0xB49C80", VA = "0x180B4B680")]
		public RESULT getMute(out bool mute)
		{
			return RESULT.OK;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000058DC File Offset: 0x00003ADC
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xB4B720", Offset = "0xB49D20", VA = "0x180B4B720")]
		public RESULT setMute(bool mute)
		{
			return RESULT.OK;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000058F4 File Offset: 0x00003AF4
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xB4B7B0", Offset = "0xB49DB0", VA = "0x180B4B7B0")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return RESULT.OK;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000590C File Offset: 0x00003B0C
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xB4B840", Offset = "0xB49E40", VA = "0x180B4B840")]
		public RESULT lockChannelGroup()
		{
			return RESULT.OK;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00005924 File Offset: 0x00003B24
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xB4B8C0", Offset = "0xB49EC0", VA = "0x180B4B8C0")]
		public RESULT unlockChannelGroup()
		{
			return RESULT.OK;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000593C File Offset: 0x00003B3C
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xB4B940", Offset = "0xB49F40", VA = "0x180B4B940")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return RESULT.OK;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00005954 File Offset: 0x00003B54
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xB4B9D0", Offset = "0xB49FD0", VA = "0x180B4B9D0")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return RESULT.OK;
		}

		// Token: 0x060005EB RID: 1515
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xB4BA70", Offset = "0xB4A070", VA = "0x180B4BA70")]
		[PreserveSig]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		// Token: 0x060005EC RID: 1516
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xB4BAF0", Offset = "0xB4A0F0", VA = "0x180B4BAF0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		// Token: 0x060005ED RID: 1517
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xB4BB80", Offset = "0xB4A180", VA = "0x180B4BB80")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		// Token: 0x060005EE RID: 1518
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xB4BC30", Offset = "0xB4A230", VA = "0x180B4BC30")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		// Token: 0x060005EF RID: 1519
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xB4BCD0", Offset = "0xB4A2D0", VA = "0x180B4BCD0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		// Token: 0x060005F0 RID: 1520
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xB4BD60", Offset = "0xB4A360", VA = "0x180B4BD60")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		// Token: 0x060005F1 RID: 1521
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xB4BE00", Offset = "0xB4A400", VA = "0x180B4BE00")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		// Token: 0x060005F2 RID: 1522
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xB4BE90", Offset = "0xB4A490", VA = "0x180B4BE90")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		// Token: 0x060005F3 RID: 1523
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xB4BF30", Offset = "0xB4A530", VA = "0x180B4BF30")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		// Token: 0x060005F4 RID: 1524
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xB4BFC0", Offset = "0xB4A5C0", VA = "0x180B4BFC0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		// Token: 0x060005F5 RID: 1525
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xB4C050", Offset = "0xB4A650", VA = "0x180B4C050")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		// Token: 0x060005F6 RID: 1526
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xB4C0D0", Offset = "0xB4A6D0", VA = "0x180B4C0D0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		// Token: 0x060005F7 RID: 1527
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xB4C150", Offset = "0xB4A750", VA = "0x180B4C150")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		// Token: 0x060005F8 RID: 1528
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xB4C1E0", Offset = "0xB4A7E0", VA = "0x180B4C1E0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bus_GetCPUUsage(IntPtr bus, out uint exclusive, out uint inclusive);

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000596C File Offset: 0x00003B6C
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00005984 File Offset: 0x00003B84
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xB4C280", Offset = "0xB4A880", VA = "0x180B4C280")]
		public bool isValid()
		{
			return default(bool);
		}

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
