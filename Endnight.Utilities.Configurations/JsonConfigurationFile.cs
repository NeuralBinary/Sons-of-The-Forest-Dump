using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Endnight.Utilities.Configurations
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public abstract class JsonConfigurationFile<T> where T : JsonConfigurationFile<T>, new()
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3
		[Token(Token = "0x17000001")]
		[JsonIgnore]
		public abstract string RootName { [Token(Token = "0x6000003")] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000002")]
		[JsonIgnore]
		public string FileName
		{
			[Token(Token = "0x6000004")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000003")]
		[JsonIgnore]
		public static T Instance
		{
			[Token(Token = "0x6000005")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		public static void Create<U>() where U : JsonConfigurationFile<U>, new()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000007")]
		public static bool Exists<U>() where U : JsonConfigurationFile<U>, new()
		{
			return default(bool);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000008")]
		public static string GetPath<U>() where U : JsonConfigurationFile<U>, new()
		{
			return null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000009")]
		public static bool CreateIfNotExist<U>() where U : JsonConfigurationFile<U>, new()
		{
			return default(bool);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		protected JsonConfigurationFile()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;
	}
}
