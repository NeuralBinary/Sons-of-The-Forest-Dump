using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class HorizontalGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2A88970", Offset = "0x2A86F70", VA = "0x182A88970")]
		public HorizontalGroupAttribute(string group, float width = 0f, int marginLeft = 0, int marginRight = 0, float order = 0f)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2A889D0", Offset = "0x2A86FD0", VA = "0x182A889D0")]
		public HorizontalGroupAttribute(float width = 0f, int marginLeft = 0, int marginRight = 0, float order = 0f)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2A88A60", Offset = "0x2A87060", VA = "0x182A88A60", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x38")]
		public float Width;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x3C")]
		public float MarginLeft;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x40")]
		public float MarginRight;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x44")]
		public float PaddingLeft;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x48")]
		public float PaddingRight;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x4C")]
		public float MinWidth;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x50")]
		public float MaxWidth;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x58")]
		public string Title;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x60")]
		public float LabelWidth;
	}
}
