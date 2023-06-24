using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	[AttributeUsage(AttributeTargets.Field)]
	public class InspectorButtonAttribute : PropertyAttribute
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00004A24 File Offset: 0x00002C24
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000147")]
		public float ButtonWidth
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
			set
			{
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x27F3D10", Offset = "0x27F2310", VA = "0x1827F3D10")]
		public InspectorButtonAttribute(string MethodName)
		{
		}

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x0")]
		public static float kDefaultButtonWidth;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x18")]
		public readonly string MethodName;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x20")]
		private float _buttonWidth;
	}
}
