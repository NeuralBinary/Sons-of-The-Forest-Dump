using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x020005A5 RID: 1445
	[Token(Token = "0x20005A5")]
	[AttributeUsage(AttributeTargets.Field)]
	public abstract class InspectorAttribute : PropertyAttribute
	{
		// Token: 0x06002614 RID: 9748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002614")]
		[Address(RVA = "0xFC5D60", Offset = "0xFC4360", VA = "0x180FC5D60")]
		public InspectorAttribute()
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public InspectorAttribute(string label)
		{
		}

		// Token: 0x0400223F RID: 8767
		[Token(Token = "0x400223F")]
		[FieldOffset(Offset = "0x18")]
		public readonly string label;

		// Token: 0x04002240 RID: 8768
		[Token(Token = "0x4002240")]
		[FieldOffset(Offset = "0x20")]
		public string tooltip;

		// Token: 0x04002241 RID: 8769
		[Token(Token = "0x4002241")]
		[FieldOffset(Offset = "0x28")]
		public string useProperty;

		// Token: 0x04002242 RID: 8770
		[Token(Token = "0x4002242")]
		[FieldOffset(Offset = "0x30")]
		public string visibleCheck;

		// Token: 0x04002243 RID: 8771
		[Token(Token = "0x4002243")]
		[FieldOffset(Offset = "0x38")]
		public string enabledCheck;

		// Token: 0x04002244 RID: 8772
		[Token(Token = "0x4002244")]
		[FieldOffset(Offset = "0x40")]
		public int indentLevel;
	}
}
