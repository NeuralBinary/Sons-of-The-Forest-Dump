using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	internal class DoesNotReturnIfAttribute : Attribute
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
		public DoesNotReturnIfAttribute(bool parameterValue)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x17000002")]
		public bool ParameterValue
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}
	}
}
