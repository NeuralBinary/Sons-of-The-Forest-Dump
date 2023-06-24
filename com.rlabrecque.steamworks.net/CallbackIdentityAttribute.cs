using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
	internal class CallbackIdentityAttribute : Attribute
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00007BA4 File Offset: 0x00005DA4
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000024")]
		public int Identity
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public CallbackIdentityAttribute(int callbackNum)
		{
		}
	}
}
