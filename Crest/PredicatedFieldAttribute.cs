using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class PredicatedFieldAttribute : PropertyAttribute
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x9D1B40", Offset = "0x9D0140", VA = "0x1809D1B40")]
		public PredicatedFieldAttribute(string propertyName, bool inverted = false, int disableIfValueIs = 0)
		{
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x18")]
		public readonly string _propertyName;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x20")]
		public readonly bool _inverted;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x24")]
		public readonly int _disableIfValueIs;
	}
}
