using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public class UnParserSettings
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002CA0 File Offset: 0x00000EA0
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000080")]
		public bool PreferShortName
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x994190", Offset = "0x992790", VA = "0x180994190")]
			set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000081")]
		public bool GroupSwitches
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x5FD500", Offset = "0x5FBB00", VA = "0x1805FD500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x994210", Offset = "0x992810", VA = "0x180994210")]
			set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000082")]
		public bool UseEqualToken
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x5FD520", Offset = "0x5FBB20", VA = "0x1805FD520")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x994290", Offset = "0x992890", VA = "0x180994290")]
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000083")]
		public bool ShowHidden
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x5FD540", Offset = "0x5FBB40", VA = "0x1805FD540")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x994310", Offset = "0x992910", VA = "0x180994310")]
			set
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00002D00 File Offset: 0x00000F00
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000084")]
		public bool SkipDefault
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x994390", Offset = "0x992990", VA = "0x180994390")]
			set
			{
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x994410", Offset = "0x992A10", VA = "0x180994410")]
		public static UnParserSettings WithGroupSwitchesOnly()
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x994470", Offset = "0x992A70", VA = "0x180994470")]
		public static UnParserSettings WithUseEqualTokenOnly()
		{
			return null;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00002D18 File Offset: 0x00000F18
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000085")]
		internal bool Consumed
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x9944D0", Offset = "0x992AD0", VA = "0x1809944D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x9944E0", Offset = "0x992AE0", VA = "0x1809944E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public UnParserSettings()
		{
		}

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x10")]
		private bool preferShortName;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x11")]
		private bool groupSwitches;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x12")]
		private bool useEqualToken;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x13")]
		private bool showHidden;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x14")]
		private bool skipDefault;
	}
}
