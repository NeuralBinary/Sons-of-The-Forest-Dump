using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public struct VCA
	{
		// Token: 0x060005FC RID: 1532 RVA: 0x0000599C File Offset: 0x00003B9C
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xB4C310", Offset = "0xB4A910", VA = "0x180B4C310")]
		public RESULT getID(out Guid id)
		{
			return RESULT.OK;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000059B4 File Offset: 0x00003BB4
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xB4C3A0", Offset = "0xB4A9A0", VA = "0x180B4C3A0")]
		public RESULT getPath(out string path)
		{
			return RESULT.OK;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000059CC File Offset: 0x00003BCC
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xB4C750", Offset = "0xB4AD50", VA = "0x180B4C750")]
		public RESULT getVolume(out float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000059E4 File Offset: 0x00003BE4
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xB4C7F0", Offset = "0xB4ADF0", VA = "0x180B4C7F0")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000059FC File Offset: 0x00003BFC
		[Token(Token = "0x6000600")]
		[Address(RVA = "0xB4C890", Offset = "0xB4AE90", VA = "0x180B4C890")]
		public RESULT setVolume(float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000601 RID: 1537
		[Token(Token = "0x6000601")]
		[Address(RVA = "0xB4C920", Offset = "0xB4AF20", VA = "0x180B4C920")]
		[PreserveSig]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		// Token: 0x06000602 RID: 1538
		[Token(Token = "0x6000602")]
		[Address(RVA = "0xB4C9A0", Offset = "0xB4AFA0", VA = "0x180B4C9A0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		// Token: 0x06000603 RID: 1539
		[Token(Token = "0x6000603")]
		[Address(RVA = "0xB4CA30", Offset = "0xB4B030", VA = "0x180B4CA30")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		// Token: 0x06000604 RID: 1540
		[Token(Token = "0x6000604")]
		[Address(RVA = "0xB4CAE0", Offset = "0xB4B0E0", VA = "0x180B4CAE0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		// Token: 0x06000605 RID: 1541
		[Token(Token = "0x6000605")]
		[Address(RVA = "0xB4CB80", Offset = "0xB4B180", VA = "0x180B4CB80")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		// Token: 0x06000606 RID: 1542 RVA: 0x00005A14 File Offset: 0x00003C14
		[Token(Token = "0x6000606")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00005A2C File Offset: 0x00003C2C
		[Token(Token = "0x6000608")]
		[Address(RVA = "0xB4CC10", Offset = "0xB4B210", VA = "0x180B4CC10")]
		public bool isValid()
		{
			return default(bool);
		}

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
