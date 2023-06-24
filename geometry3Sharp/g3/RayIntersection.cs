using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	public class RayIntersection
	{
		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private RayIntersection()
		{
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00013484 File Offset: 0x00011684
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x1F30910", Offset = "0x1F2EF10", VA = "0x181F30910")]
		public static bool Sphere(Vector3f vOrigin, Vector3f vDirection, Vector3f vCenter, float fRadius, out float fRayT)
		{
			return default(bool);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0001349C File Offset: 0x0001169C
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x1F30AF0", Offset = "0x1F2F0F0", VA = "0x181F30AF0")]
		public static bool SphereSigned(ref Vector3f vOrigin, ref Vector3f vDirection, ref Vector3f vCenter, float fRadius, out float fRayT)
		{
			return default(bool);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000134B4 File Offset: 0x000116B4
		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0x1F30C90", Offset = "0x1F2F290", VA = "0x181F30C90")]
		public static bool SphereSigned(ref Vector3d vOrigin, ref Vector3d vDirection, ref Vector3d vCenter, double fRadius, out double fRayT)
		{
			return default(bool);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000134CC File Offset: 0x000116CC
		[Token(Token = "0x6001ABA")]
		[Address(RVA = "0x1F30E20", Offset = "0x1F2F420", VA = "0x181F30E20")]
		public static bool InfiniteCylinder(Vector3f vOrigin, Vector3f vDirection, Vector3f vCylOrigin, Vector3f vCylAxis, float fRadius, out float fRayT)
		{
			return default(bool);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000134E4 File Offset: 0x000116E4
		[Token(Token = "0x6001ABB")]
		[Address(RVA = "0x1F30F30", Offset = "0x1F2F530", VA = "0x181F30F30")]
		public static bool InfiniteCylinderSigned(Vector3f vOrigin, Vector3f vDirection, Vector3f vCylOrigin, Vector3f vCylAxis, float fRadius, out float fRayT)
		{
			return default(bool);
		}
	}
}
