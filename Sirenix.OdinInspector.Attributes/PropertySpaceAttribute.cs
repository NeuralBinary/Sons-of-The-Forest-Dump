using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class PropertySpaceAttribute : Attribute
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2A89A70", Offset = "0x2A88070", VA = "0x182A89A70")]
		public PropertySpaceAttribute()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2A89A80", Offset = "0x2A88080", VA = "0x182A89A80")]
		public PropertySpaceAttribute(float spaceBefore)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2A89A90", Offset = "0x2A88090", VA = "0x182A89A90")]
		public PropertySpaceAttribute(float spaceBefore, float spaceAfter)
		{
		}

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x10")]
		public float SpaceBefore;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x14")]
		public float SpaceAfter;
	}
}
