using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.Tests
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[Serializable]
	public class SampleResult
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		[JsonProperty]
		public string Location
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000017")]
		[JsonProperty]
		public float Fps
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SampleResult()
		{
		}
	}
}
