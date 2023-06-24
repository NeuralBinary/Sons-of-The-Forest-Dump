using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.GameApplication
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public static class Version
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2FE83D0", Offset = "0x2FE69D0", VA = "0x182FE83D0")]
		public static Version.VersionInfo GetVersionInfo()
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2FE8410", Offset = "0x2FE6A10", VA = "0x182FE8410")]
		public static string GetVersionString()
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2FE8450", Offset = "0x2FE6A50", VA = "0x182FE8450")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void Initialize()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2FE8640", Offset = "0x2FE6C40", VA = "0x182FE8640")]
		public static void LoadVersionData(out Version.VersionInfo versionInfo, out string versionString)
		{
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		private static string _versionString;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x8")]
		private static Version.VersionInfo _versionInfo;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		private const string LoadFilename = "VersionInfo";

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		private const string LoadFilenameWithExt = "VersionInfo.json";

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		private const string LoadPathSuffix = "/VersionInfo.json";

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		private const string ChangeIdMatchString = "STATUS ";

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		private const string SpaceMatchString = " ";

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public class VersionInfo
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000016 RID: 22 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000001")]
			public string Platform
			{
				[Token(Token = "0x6000016")]
				[Address(RVA = "0x2FE8790", Offset = "0x2FE6D90", VA = "0x182FE8790")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000017 RID: 23 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2FE87C0", Offset = "0x2FE6DC0", VA = "0x182FE87C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public VersionInfo()
			{
			}

			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x10")]
			public int Major;

			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x14")]
			public int Minor;

			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x18")]
			public int Patch;

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x20")]
			public string Stage;

			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x28")]
			public int ChangeId;
		}
	}
}
