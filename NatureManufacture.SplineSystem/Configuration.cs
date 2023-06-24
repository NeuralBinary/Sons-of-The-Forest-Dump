using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TriangleNet
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class Configuration
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2485FB0", Offset = "0x24845B0", VA = "0x182485FB0")]
		public Configuration()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2486210", Offset = "0x2484810", VA = "0x182486210")]
		public Configuration(Func<IPredicates> predicates)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public Configuration(Func<IPredicates> predicates, Func<TrianglePool> trianglePool)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public Func<IPredicates> Predicates
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public Func<TrianglePool> TrianglePool
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
