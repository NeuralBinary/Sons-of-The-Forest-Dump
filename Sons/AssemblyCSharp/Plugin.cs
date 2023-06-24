using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace AssemblyCSharp
{
	// Token: 0x02000353 RID: 851
	[Token(Token = "0x2000353")]
	public class Plugin
	{
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000319")]
		public Exception Exception
		{
			[Token(Token = "0x600154A")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600154B")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700031A")]
		public string PluginName
		{
			[Token(Token = "0x600154C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600154D")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600154E")]
		[Address(RVA = "0x326E840", Offset = "0x326CE40", VA = "0x18326E840")]
		public Plugin(string fileName)
		{
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x1700031B")]
		public bool Loaded
		{
			[Token(Token = "0x600154F")]
			[Address(RVA = "0x66CB40", Offset = "0x66B140", VA = "0x18066CB40")]
			get
			{
				return default(bool);
			}
		}
	}
}
