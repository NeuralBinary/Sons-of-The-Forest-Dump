using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class RequiredAttribute : Attribute
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2A89AA0", Offset = "0x2A880A0", VA = "0x182A89AA0")]
		public RequiredAttribute()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
		public RequiredAttribute(string errorMessage, InfoMessageType messageType)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2A89AB0", Offset = "0x2A880B0", VA = "0x182A89AB0")]
		public RequiredAttribute(string errorMessage)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
		public RequiredAttribute(InfoMessageType messageType)
		{
		}

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x10")]
		public string ErrorMessage;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x18")]
		public InfoMessageType MessageType;
	}
}
