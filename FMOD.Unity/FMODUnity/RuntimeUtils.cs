using System;
using System.Runtime.InteropServices;
using FMOD;
using Il2CppDummyDll;
using UnityEngine;

namespace FMODUnity
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	public static class RuntimeUtils
	{
		// Token: 0x06000679 RID: 1657 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000679")]
		[Address(RVA = "0xB513E0", Offset = "0xB4F9E0", VA = "0x180B513E0")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00005E34 File Offset: 0x00004034
		[Token(Token = "0x600067A")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00005E4C File Offset: 0x0000404C
		[Token(Token = "0x600067B")]
		[Address(RVA = "0xB3E860", Offset = "0xB3CE60", VA = "0x180B3E860")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00005E64 File Offset: 0x00004064
		[Token(Token = "0x600067C")]
		[Address(RVA = "0xB3E970", Offset = "0xB3CF70", VA = "0x180B3E970")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00005E7C File Offset: 0x0000407C
		[Token(Token = "0x600067D")]
		[Address(RVA = "0xB51400", Offset = "0xB4FA00", VA = "0x180B51400")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00005E94 File Offset: 0x00004094
		[Token(Token = "0x600067E")]
		[Address(RVA = "0xB51580", Offset = "0xB4FB80", VA = "0x180B51580")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00005EAC File Offset: 0x000040AC
		[Token(Token = "0x600067F")]
		[Address(RVA = "0xB51750", Offset = "0xB4FD50", VA = "0x180B51750")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00005EC4 File Offset: 0x000040C4
		[Token(Token = "0x6000680")]
		[Address(RVA = "0xB518A0", Offset = "0xB4FEA0", VA = "0x180B518A0")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00005EDC File Offset: 0x000040DC
		[Token(Token = "0x6000681")]
		[Address(RVA = "0xB51A40", Offset = "0xB50040", VA = "0x180B51A40")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return FMODPlatform.None;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000682")]
		[Address(RVA = "0xB51A50", Offset = "0xB50050", VA = "0x180B51A50")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000683")]
		[Address(RVA = "0xB51B90", Offset = "0xB50190", VA = "0x180B51B90")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000684")]
		[Address(RVA = "0xB51C60", Offset = "0xB50260", VA = "0x180B51C60")]
		public static void EnforceLibraryOrder()
		{
		}

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		private const string BankExtension = ".bank";
	}
}
