using System;
using Il2CppDummyDll;

namespace AmplifyImpostors
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[Serializable]
	public class VersionInfo
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x5BBF30", Offset = "0x5BA530", VA = "0x1805BBF30")]
		public static string StaticToString()
		{
			return null;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x17000007")]
		public static int FullNumber
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x5BC0D0", Offset = "0x5BA6D0", VA = "0x1805BC0D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000008")]
		public static string FullLabel
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x5BC110", Offset = "0x5BA710", VA = "0x1805BC110")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public VersionInfo()
		{
		}

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		public const byte Major = 0;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		public const byte Minor = 9;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		public const byte Release = 7;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x0")]
		public static byte Revision;
	}
}
