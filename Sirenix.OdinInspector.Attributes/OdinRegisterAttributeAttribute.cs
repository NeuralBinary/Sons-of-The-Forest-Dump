using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = true)]
	public class OdinRegisterAttributeAttribute : Attribute
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2A8C710", Offset = "0x2A8AD10", VA = "0x182A8C710")]
		public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise)
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2A8C830", Offset = "0x2A8AE30", VA = "0x182A8C830")]
		public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise, string url)
		{
		}

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x10")]
		public Type AttributeType;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x18")]
		public string Categories;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x20")]
		public string Description;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x28")]
		public string DocumentationUrl;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x30")]
		public bool IsEnterprise;
	}
}
