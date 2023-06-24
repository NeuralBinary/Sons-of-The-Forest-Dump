using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public struct Bank
	{
		// Token: 0x06000609 RID: 1545 RVA: 0x00005A44 File Offset: 0x00003C44
		[Token(Token = "0x6000609")]
		[Address(RVA = "0xB4CCA0", Offset = "0xB4B2A0", VA = "0x180B4CCA0")]
		public RESULT getID(out Guid id)
		{
			return RESULT.OK;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00005A5C File Offset: 0x00003C5C
		[Token(Token = "0x600060A")]
		[Address(RVA = "0xB4CD30", Offset = "0xB4B330", VA = "0x180B4CD30")]
		public RESULT getPath(out string path)
		{
			return RESULT.OK;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00005A74 File Offset: 0x00003C74
		[Token(Token = "0x600060B")]
		[Address(RVA = "0xB4D0E0", Offset = "0xB4B6E0", VA = "0x180B4D0E0")]
		public RESULT unload()
		{
			return RESULT.OK;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00005A8C File Offset: 0x00003C8C
		[Token(Token = "0x600060C")]
		[Address(RVA = "0xB4D160", Offset = "0xB4B760", VA = "0x180B4D160")]
		public RESULT loadSampleData()
		{
			return RESULT.OK;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[Token(Token = "0x600060D")]
		[Address(RVA = "0xB4D1E0", Offset = "0xB4B7E0", VA = "0x180B4D1E0")]
		public RESULT unloadSampleData()
		{
			return RESULT.OK;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00005ABC File Offset: 0x00003CBC
		[Token(Token = "0x600060E")]
		[Address(RVA = "0xB4D260", Offset = "0xB4B860", VA = "0x180B4D260")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return RESULT.OK;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[Token(Token = "0x600060F")]
		[Address(RVA = "0xB4D2F0", Offset = "0xB4B8F0", VA = "0x180B4D2F0")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return RESULT.OK;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00005AEC File Offset: 0x00003CEC
		[Token(Token = "0x6000610")]
		[Address(RVA = "0xB4D380", Offset = "0xB4B980", VA = "0x180B4D380")]
		public RESULT getStringCount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00005B04 File Offset: 0x00003D04
		[Token(Token = "0x6000611")]
		[Address(RVA = "0xB4D410", Offset = "0xB4BA10", VA = "0x180B4D410")]
		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return RESULT.OK;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00005B1C File Offset: 0x00003D1C
		[Token(Token = "0x6000612")]
		[Address(RVA = "0xB4D820", Offset = "0xB4BE20", VA = "0x180B4D820")]
		public RESULT getEventCount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00005B34 File Offset: 0x00003D34
		[Token(Token = "0x6000613")]
		[Address(RVA = "0xB4D830", Offset = "0xB4BE30", VA = "0x180B4D830")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return RESULT.OK;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00005B4C File Offset: 0x00003D4C
		[Token(Token = "0x6000614")]
		[Address(RVA = "0xB4DAD0", Offset = "0xB4C0D0", VA = "0x180B4DAD0")]
		public RESULT getBusCount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00005B64 File Offset: 0x00003D64
		[Token(Token = "0x6000615")]
		[Address(RVA = "0xB4DAE0", Offset = "0xB4C0E0", VA = "0x180B4DAE0")]
		public RESULT getBusList(out Bus[] array)
		{
			return RESULT.OK;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00005B7C File Offset: 0x00003D7C
		[Token(Token = "0x6000616")]
		[Address(RVA = "0xB4DD80", Offset = "0xB4C380", VA = "0x180B4DD80")]
		public RESULT getVCACount(out int count)
		{
			return RESULT.OK;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00005B94 File Offset: 0x00003D94
		[Token(Token = "0x6000617")]
		[Address(RVA = "0xB4DD90", Offset = "0xB4C390", VA = "0x180B4DD90")]
		public RESULT getVCAList(out VCA[] array)
		{
			return RESULT.OK;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00005BAC File Offset: 0x00003DAC
		[Token(Token = "0x6000618")]
		[Address(RVA = "0xB4E030", Offset = "0xB4C630", VA = "0x180B4E030")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[Token(Token = "0x6000619")]
		[Address(RVA = "0xB4E0C0", Offset = "0xB4C6C0", VA = "0x180B4E0C0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x0600061A RID: 1562
		[Token(Token = "0x600061A")]
		[Address(RVA = "0xB4E150", Offset = "0xB4C750", VA = "0x180B4E150")]
		[PreserveSig]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		// Token: 0x0600061B RID: 1563
		[Token(Token = "0x600061B")]
		[Address(RVA = "0xB4E1D0", Offset = "0xB4C7D0", VA = "0x180B4E1D0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		// Token: 0x0600061C RID: 1564
		[Token(Token = "0x600061C")]
		[Address(RVA = "0xB4E260", Offset = "0xB4C860", VA = "0x180B4E260")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		// Token: 0x0600061D RID: 1565
		[Token(Token = "0x600061D")]
		[Address(RVA = "0xB4E310", Offset = "0xB4C910", VA = "0x180B4E310")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		// Token: 0x0600061E RID: 1566
		[Token(Token = "0x600061E")]
		[Address(RVA = "0xB4E390", Offset = "0xB4C990", VA = "0x180B4E390")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		// Token: 0x0600061F RID: 1567
		[Token(Token = "0x600061F")]
		[Address(RVA = "0xB4E410", Offset = "0xB4CA10", VA = "0x180B4E410")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		// Token: 0x06000620 RID: 1568
		[Token(Token = "0x6000620")]
		[Address(RVA = "0xB4E490", Offset = "0xB4CA90", VA = "0x180B4E490")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		// Token: 0x06000621 RID: 1569
		[Token(Token = "0x6000621")]
		[Address(RVA = "0xB4E520", Offset = "0xB4CB20", VA = "0x180B4E520")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		// Token: 0x06000622 RID: 1570
		[Token(Token = "0x6000622")]
		[Address(RVA = "0xB4E5B0", Offset = "0xB4CBB0", VA = "0x180B4E5B0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		// Token: 0x06000623 RID: 1571
		[Token(Token = "0x6000623")]
		[Address(RVA = "0xB4E640", Offset = "0xB4CC40", VA = "0x180B4E640")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		// Token: 0x06000624 RID: 1572
		[Token(Token = "0x6000624")]
		[Address(RVA = "0xB4E6F0", Offset = "0xB4CCF0", VA = "0x180B4E6F0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		// Token: 0x06000625 RID: 1573
		[Token(Token = "0x6000625")]
		[Address(RVA = "0xB4E780", Offset = "0xB4CD80", VA = "0x180B4E780")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		// Token: 0x06000626 RID: 1574
		[Token(Token = "0x6000626")]
		[Address(RVA = "0xB4E840", Offset = "0xB4CE40", VA = "0x180B4E840")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		// Token: 0x06000627 RID: 1575
		[Token(Token = "0x6000627")]
		[Address(RVA = "0xB4E8D0", Offset = "0xB4CED0", VA = "0x180B4E8D0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		// Token: 0x06000628 RID: 1576
		[Token(Token = "0x6000628")]
		[Address(RVA = "0xB4E990", Offset = "0xB4CF90", VA = "0x180B4E990")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		// Token: 0x06000629 RID: 1577
		[Token(Token = "0x6000629")]
		[Address(RVA = "0xB4EA20", Offset = "0xB4D020", VA = "0x180B4EA20")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		// Token: 0x0600062A RID: 1578
		[Token(Token = "0x600062A")]
		[Address(RVA = "0xB4EAE0", Offset = "0xB4D0E0", VA = "0x180B4EAE0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		// Token: 0x0600062B RID: 1579
		[Token(Token = "0x600062B")]
		[Address(RVA = "0xB4EB70", Offset = "0xB4D170", VA = "0x180B4EB70")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		// Token: 0x0600062C RID: 1580 RVA: 0x00005BDC File Offset: 0x00003DDC
		[Token(Token = "0x600062C")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[Token(Token = "0x600062E")]
		[Address(RVA = "0xB4EC00", Offset = "0xB4D200", VA = "0x180B4EC00")]
		public bool isValid()
		{
			return default(bool);
		}

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
