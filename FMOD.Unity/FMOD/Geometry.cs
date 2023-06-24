using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public struct Geometry
	{
		// Token: 0x060003DF RID: 991 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xB36490", Offset = "0xB34A90", VA = "0x180B36490")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00004814 File Offset: 0x00002A14
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xB36510", Offset = "0xB34B10", VA = "0x180B36510")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return RESULT.OK;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000482C File Offset: 0x00002A2C
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xB365E0", Offset = "0xB34BE0", VA = "0x180B365E0")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return RESULT.OK;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00004844 File Offset: 0x00002A44
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xB36670", Offset = "0xB34C70", VA = "0x180B36670")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return RESULT.OK;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xB36710", Offset = "0xB34D10", VA = "0x180B36710")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return RESULT.OK;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00004874 File Offset: 0x00002A74
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xB367B0", Offset = "0xB34DB0", VA = "0x180B367B0")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return RESULT.OK;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000488C File Offset: 0x00002A8C
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xB36850", Offset = "0xB34E50", VA = "0x180B36850")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return RESULT.OK;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000048A4 File Offset: 0x00002AA4
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xB368F0", Offset = "0xB34EF0", VA = "0x180B368F0")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return RESULT.OK;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xB369B0", Offset = "0xB34FB0", VA = "0x180B369B0")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return RESULT.OK;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xB36A80", Offset = "0xB35080", VA = "0x180B36A80")]
		public RESULT setActive(bool active)
		{
			return RESULT.OK;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xB36B10", Offset = "0xB35110", VA = "0x180B36B10")]
		public RESULT getActive(out bool active)
		{
			return RESULT.OK;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xB36BB0", Offset = "0xB351B0", VA = "0x180B36BB0")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return RESULT.OK;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xB36C50", Offset = "0xB35250", VA = "0x180B36C50")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return RESULT.OK;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00004934 File Offset: 0x00002B34
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xB36CF0", Offset = "0xB352F0", VA = "0x180B36CF0")]
		public RESULT setPosition(ref VECTOR position)
		{
			return RESULT.OK;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xB36D80", Offset = "0xB35380", VA = "0x180B36D80")]
		public RESULT getPosition(out VECTOR position)
		{
			return RESULT.OK;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00004964 File Offset: 0x00002B64
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xB36E10", Offset = "0xB35410", VA = "0x180B36E10")]
		public RESULT setScale(ref VECTOR scale)
		{
			return RESULT.OK;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xB36EA0", Offset = "0xB354A0", VA = "0x180B36EA0")]
		public RESULT getScale(out VECTOR scale)
		{
			return RESULT.OK;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00004994 File Offset: 0x00002B94
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xB36F30", Offset = "0xB35530", VA = "0x180B36F30")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return RESULT.OK;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xB36FD0", Offset = "0xB355D0", VA = "0x180B36FD0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xB37060", Offset = "0xB35660", VA = "0x180B37060")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x060003F3 RID: 1011
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xB370F0", Offset = "0xB356F0", VA = "0x180B370F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		// Token: 0x060003F4 RID: 1012
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xB37170", Offset = "0xB35770", VA = "0x180B37170")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		// Token: 0x060003F5 RID: 1013
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xB37240", Offset = "0xB35840", VA = "0x180B37240")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		// Token: 0x060003F6 RID: 1014
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xB372D0", Offset = "0xB358D0", VA = "0x180B372D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		// Token: 0x060003F7 RID: 1015
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xB37370", Offset = "0xB35970", VA = "0x180B37370")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		// Token: 0x060003F8 RID: 1016
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xB37410", Offset = "0xB35A10", VA = "0x180B37410")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		// Token: 0x060003F9 RID: 1017
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xB374B0", Offset = "0xB35AB0", VA = "0x180B374B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		// Token: 0x060003FA RID: 1018
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xB37550", Offset = "0xB35B50", VA = "0x180B37550")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		// Token: 0x060003FB RID: 1019
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xB37610", Offset = "0xB35C10", VA = "0x180B37610")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		// Token: 0x060003FC RID: 1020
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xB376E0", Offset = "0xB35CE0", VA = "0x180B376E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		// Token: 0x060003FD RID: 1021
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xB37770", Offset = "0xB35D70", VA = "0x180B37770")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		// Token: 0x060003FE RID: 1022
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xB37810", Offset = "0xB35E10", VA = "0x180B37810")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		// Token: 0x060003FF RID: 1023
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xB378B0", Offset = "0xB35EB0", VA = "0x180B378B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		// Token: 0x06000400 RID: 1024
		[Token(Token = "0x6000400")]
		[Address(RVA = "0xB37950", Offset = "0xB35F50", VA = "0x180B37950")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		// Token: 0x06000401 RID: 1025
		[Token(Token = "0x6000401")]
		[Address(RVA = "0xB379E0", Offset = "0xB35FE0", VA = "0x180B379E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		// Token: 0x06000402 RID: 1026
		[Token(Token = "0x6000402")]
		[Address(RVA = "0xB37A70", Offset = "0xB36070", VA = "0x180B37A70")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		// Token: 0x06000403 RID: 1027
		[Token(Token = "0x6000403")]
		[Address(RVA = "0xB37B00", Offset = "0xB36100", VA = "0x180B37B00")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		// Token: 0x06000404 RID: 1028
		[Token(Token = "0x6000404")]
		[Address(RVA = "0xB37B90", Offset = "0xB36190", VA = "0x180B37B90")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		// Token: 0x06000405 RID: 1029
		[Token(Token = "0x6000405")]
		[Address(RVA = "0xB37C30", Offset = "0xB36230", VA = "0x180B37C30")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		// Token: 0x06000406 RID: 1030
		[Token(Token = "0x6000406")]
		[Address(RVA = "0xB37CC0", Offset = "0xB362C0", VA = "0x180B37CC0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		// Token: 0x06000407 RID: 1031 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x6000407")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
