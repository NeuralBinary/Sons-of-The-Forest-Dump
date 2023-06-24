using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class PropertyRangeAttribute : Attribute
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the MinGetter member instead.", false)]
		public string MinMember
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		[Obsolete("Use the MaxGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MaxMember
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2A898C0", Offset = "0x2A87EC0", VA = "0x182A898C0")]
		public PropertyRangeAttribute(double min, double max)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2A89900", Offset = "0x2A87F00", VA = "0x182A89900")]
		public PropertyRangeAttribute(string minGetter, double max)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2A89960", Offset = "0x2A87F60", VA = "0x182A89960")]
		public PropertyRangeAttribute(double min, string maxGetter)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2A899C0", Offset = "0x2A87FC0", VA = "0x182A899C0")]
		public PropertyRangeAttribute(string minGetter, string maxGetter)
		{
		}

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x10")]
		public double Min;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		public double Max;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x20")]
		public string MinGetter;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x28")]
		public string MaxGetter;
	}
}
