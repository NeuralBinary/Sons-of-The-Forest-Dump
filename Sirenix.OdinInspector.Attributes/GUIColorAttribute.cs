using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class GUIColorAttribute : Attribute
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2A88710", Offset = "0x2A86D10", VA = "0x182A88710")]
		public GUIColorAttribute(float r, float g, float b, float a = 1f)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public GUIColorAttribute(string getColor)
		{
		}

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x10")]
		public Color Color;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		public string GetColor;
	}
}
