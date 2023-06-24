using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	internal sealed class NotNullWhenAttribute : Attribute
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
		public NotNullWhenAttribute(bool returnValue)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x17000001")]
		public bool ReturnValue
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}
	}
}
