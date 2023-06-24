using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public abstract class PropertyGroupAttribute : Attribute
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2A89510", Offset = "0x2A87B10", VA = "0x182A89510")]
		public PropertyGroupAttribute(string groupId, float order)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2A89640", Offset = "0x2A87C40", VA = "0x182A89640")]
		public PropertyGroupAttribute(string groupId)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2A89650", Offset = "0x2A87C50", VA = "0x182A89650")]
		public PropertyGroupAttribute Combine(PropertyGroupAttribute other)
		{
			return null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		protected virtual void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x10")]
		public string GroupID;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x18")]
		public string GroupName;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x20")]
		public float Order;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x24")]
		public bool HideWhenChildrenAreInvisible;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x28")]
		public string VisibleIf;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x30")]
		public bool AnimateVisibility;
	}
}
