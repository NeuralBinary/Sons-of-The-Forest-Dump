using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public struct Reverb3D
	{
		// Token: 0x06000409 RID: 1033 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x6000409")]
		[Address(RVA = "0xB37D50", Offset = "0xB36350", VA = "0x180B37D50")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x600040A")]
		[Address(RVA = "0xB37DD0", Offset = "0xB363D0", VA = "0x180B37DD0")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return RESULT.OK;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x600040B")]
		[Address(RVA = "0xB37E80", Offset = "0xB36480", VA = "0x180B37E80")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return RESULT.OK;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x600040C")]
		[Address(RVA = "0xB37F30", Offset = "0xB36530", VA = "0x180B37F30")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return RESULT.OK;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x600040D")]
		[Address(RVA = "0xB37FC0", Offset = "0xB365C0", VA = "0x180B37FC0")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return RESULT.OK;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x600040E")]
		[Address(RVA = "0xB38050", Offset = "0xB36650", VA = "0x180B38050")]
		public RESULT setActive(bool active)
		{
			return RESULT.OK;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x600040F")]
		[Address(RVA = "0xB380E0", Offset = "0xB366E0", VA = "0x180B380E0")]
		public RESULT getActive(out bool active)
		{
			return RESULT.OK;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x6000410")]
		[Address(RVA = "0xB38180", Offset = "0xB36780", VA = "0x180B38180")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x6000411")]
		[Address(RVA = "0xB38210", Offset = "0xB36810", VA = "0x180B38210")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000412 RID: 1042
		[Token(Token = "0x6000412")]
		[Address(RVA = "0xB382A0", Offset = "0xB368A0", VA = "0x180B382A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		// Token: 0x06000413 RID: 1043
		[Token(Token = "0x6000413")]
		[Address(RVA = "0xB38320", Offset = "0xB36920", VA = "0x180B38320")]
		[PreserveSig]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		// Token: 0x06000414 RID: 1044
		[Token(Token = "0x6000414")]
		[Address(RVA = "0xB383D0", Offset = "0xB369D0", VA = "0x180B383D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		// Token: 0x06000415 RID: 1045
		[Token(Token = "0x6000415")]
		[Address(RVA = "0xB38480", Offset = "0xB36A80", VA = "0x180B38480")]
		[PreserveSig]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		// Token: 0x06000416 RID: 1046
		[Token(Token = "0x6000416")]
		[Address(RVA = "0xB38510", Offset = "0xB36B10", VA = "0x180B38510")]
		[PreserveSig]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		// Token: 0x06000417 RID: 1047
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xB385A0", Offset = "0xB36BA0", VA = "0x180B385A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		// Token: 0x06000418 RID: 1048
		[Token(Token = "0x6000418")]
		[Address(RVA = "0xB38630", Offset = "0xB36C30", VA = "0x180B38630")]
		[PreserveSig]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		// Token: 0x06000419 RID: 1049
		[Token(Token = "0x6000419")]
		[Address(RVA = "0xB386D0", Offset = "0xB36CD0", VA = "0x180B386D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		// Token: 0x0600041A RID: 1050
		[Token(Token = "0x600041A")]
		[Address(RVA = "0xB38760", Offset = "0xB36D60", VA = "0x180B38760")]
		[PreserveSig]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		// Token: 0x0600041B RID: 1051 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x600041B")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
