using System;
using Il2CppDummyDll;

namespace Endnight.Build
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	public static class BuildTools
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x17000046")]
		public static bool IsBuildRunning
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600048F")]
		[Address(RVA = "0xAABF30", Offset = "0xAAA530", VA = "0x180AABF30")]
		public static string GetBuildIdFromPath(string scenePath)
		{
			return null;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000490")]
		[Address(RVA = "0xAABFF0", Offset = "0xAAA5F0", VA = "0x180AABFF0")]
		public static void SetIsBuildingAddressables(bool value)
		{
		}

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isBuildingAddressables;
	}
}
