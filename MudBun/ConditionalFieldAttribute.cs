using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	[AttributeUsage(AttributeTargets.Field)]
	public class ConditionalFieldAttribute : PropertyAttribute
	{
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x170000E4")]
		public bool ShowRange
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x2437010", Offset = "0x2435610", VA = "0x182437010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2437030", Offset = "0x2435630", VA = "0x182437030")]
		public ConditionalFieldAttribute([Optional] string propertyToCheck, [Optional] object compareValue, [Optional] object compareValue2, [Optional] object compareValue3, [Optional] object compareValue4, [Optional] object compareValue5, [Optional] object compareValue6)
		{
		}

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyToCheck;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object CompareValue;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object CompareValue2;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public object CompareValue3;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object CompareValue4;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public object CompareValue5;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public object CompareValue6;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string Label;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Tooltip;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float Min;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float Max;
	}
}
