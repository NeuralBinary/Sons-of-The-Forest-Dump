using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class VerticalGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2A88380", Offset = "0x2A86980", VA = "0x182A88380")]
		public VerticalGroupAttribute(string groupId, float order = 0f)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2A8AB60", Offset = "0x2A89160", VA = "0x182A8AB60")]
		public VerticalGroupAttribute(float order = 0f)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2A8ABB0", Offset = "0x2A891B0", VA = "0x182A8ABB0", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x38")]
		public float PaddingTop;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x3C")]
		public float PaddingBottom;
	}
}
