using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x02000595 RID: 1429
	[Token(Token = "0x2000595")]
	[AttributeUsage(256)]
	public abstract class InspectorAttribute : PropertyAttribute
	{
		// Token: 0x06002515 RID: 9493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002515")]
		[Address(RVA = "0x2D82F60", Offset = "0x2D81F60", VA = "0x182D82F60")]
		public InspectorAttribute()
		{
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002516")]
		[Address(RVA = "0x8FF070", Offset = "0x8FE070", VA = "0x1808FF070")]
		public InspectorAttribute(string label)
		{
		}

		// Token: 0x0400216B RID: 8555
		[Token(Token = "0x400216B")]
		[FieldOffset(Offset = "0x18")]
		public readonly string label;

		// Token: 0x0400216C RID: 8556
		[Token(Token = "0x400216C")]
		[FieldOffset(Offset = "0x20")]
		public string tooltip;

		// Token: 0x0400216D RID: 8557
		[Token(Token = "0x400216D")]
		[FieldOffset(Offset = "0x28")]
		public string useProperty;

		// Token: 0x0400216E RID: 8558
		[Token(Token = "0x400216E")]
		[FieldOffset(Offset = "0x30")]
		public string visibleCheck;

		// Token: 0x0400216F RID: 8559
		[Token(Token = "0x400216F")]
		[FieldOffset(Offset = "0x38")]
		public string enabledCheck;

		// Token: 0x04002170 RID: 8560
		[Token(Token = "0x4002170")]
		[FieldOffset(Offset = "0x40")]
		public int indentLevel;
	}
}
