using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Construction
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	[Serializable]
	public class StructureInfo
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000395C File Offset: 0x00001B5C
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015B")]
		[JsonProperty]
		public float Health
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00003974 File Offset: 0x00001B74
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015C")]
		[JsonProperty]
		public float MaxHealth
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000398C File Offset: 0x00001B8C
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015D")]
		[JsonProperty]
		public int ElementCount
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003AC RID: 940 RVA: 0x000039A4 File Offset: 0x00001BA4
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015E")]
		[JsonProperty]
		public int MaxElements
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xA7FDD0", Offset = "0xA7E3D0", VA = "0x180A7FDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003AE RID: 942 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x1700015F")]
		[JsonProperty]
		public float BreakCount
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x2DCA120", Offset = "0x2DC8720", VA = "0x182DCA120")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003AF RID: 943 RVA: 0x000039D4 File Offset: 0x00001BD4
		[Token(Token = "0x17000160")]
		[JsonProperty]
		public bool CanBreakTopElement
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x2DCA140", Offset = "0x2DC8740", VA = "0x182DCA140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2DCA160", Offset = "0x2DC8760", VA = "0x182DCA160")]
		public bool ShouldBeDistorted()
		{
			return default(bool);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StructureInfo()
		{
		}
	}
}
