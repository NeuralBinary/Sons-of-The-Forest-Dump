using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction.Utils
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public static class Pooling<T> where T : class, new()
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002278 File Offset: 0x00000478
		[Token(Token = "0x17000002")]
		public static int PooledInstances
		{
			[Token(Token = "0x6000064")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002290 File Offset: 0x00000490
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		public static int MaxPooledInstances
		{
			[Token(Token = "0x6000065")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000066")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		public static void SetPooledInstanceLimit(int limit)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000022A6 File Offset: 0x000004A6
		[Token(Token = "0x6000068")]
		public static T GetInstance()
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		public static void DisposeInstance(T instance)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		public static void DisposeList<L>(L instance) where L : IList, T
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		public static void DisposeDict<L>(L instance) where L : IDictionary, T
		{
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Queue<T> Pool;
	}
}
