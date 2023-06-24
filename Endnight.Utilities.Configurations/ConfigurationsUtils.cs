using System;
using Il2CppDummyDll;

namespace Endnight.Utilities.Configurations
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class ConfigurationsUtils
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000004")]
		private static string ConfigFolder
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xA822A0", Offset = "0xA808A0", VA = "0x180A822A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		public static void SaveCfg<T>(T cfg) where T : JsonConfigurationFile<T>, new()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000010")]
		public static bool Exists<T>() where T : JsonConfigurationFile<T>, new()
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000011")]
		public static string GetPath<T>() where T : JsonConfigurationFile<T>, new()
		{
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000012")]
		public static T LoadCfg<T>(bool allowArgsOverrides = true) where T : JsonConfigurationFile<T>, new()
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000013")]
		public static T LoadCfg<T>(out bool found, out string path, out bool wasProperlyDeserialized, bool allowArgsOverrides = true) where T : JsonConfigurationFile<T>, new()
		{
			return null;
		}
	}
}
