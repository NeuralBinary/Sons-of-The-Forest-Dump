using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class ShapesColorFieldAttribute : PropertyAttribute
	{
		// Token: 0x06000C01 RID: 3073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
		public ShapesColorFieldAttribute(bool showAlpha)
		{
		}

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool showAlpha;
	}
}
