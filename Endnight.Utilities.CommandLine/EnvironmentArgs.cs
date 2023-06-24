using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Endnight.Utilities.CommandLine
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class EnvironmentArgs
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public static EnvironmentArgs Instance
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0xA81640", Offset = "0xA7FC40", VA = "0x180A81640")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xA81710", Offset = "0xA7FD10", VA = "0x180A81710")]
		private EnvironmentArgs()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xA818C0", Offset = "0xA7FEC0", VA = "0x180A818C0")]
		public void AddArgs(string[] args)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000006")]
		[Address(RVA = "0xA81D10", Offset = "0xA80310", VA = "0x180A81D10")]
		public string GetArgOrDefault(string key, string defaultValue)
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000007")]
		[Address(RVA = "0xA81DC0", Offset = "0xA803C0", VA = "0x180A81DC0")]
		public bool HasArg(string key)
		{
			return default(bool);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xA81E30", Offset = "0xA80430", VA = "0x180A81E30")]
		public bool TryGetArg(string key, out string value)
		{
			return default(bool);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xA81FC0", Offset = "0xA805C0", VA = "0x180A81FC0")]
		public bool RemoveArg(string key)
		{
			return default(bool);
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private static EnvironmentArgs _instance;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> _args;
	}
}
