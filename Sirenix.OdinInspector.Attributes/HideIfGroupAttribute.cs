using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Conditional("UNITY_EDITOR")]
	public class HideIfGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public bool Animate
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		[Obsolete("Use the Condition member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MemberName
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2A887B0", Offset = "0x2A86DB0", VA = "0x182A887B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public string Condition
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2A887B0", Offset = "0x2A86DB0", VA = "0x182A887B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2A887D0", Offset = "0x2A86DD0", VA = "0x182A887D0")]
		public HideIfGroupAttribute(string path, bool animate = true)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A88800", Offset = "0x2A86E00", VA = "0x182A88800")]
		public HideIfGroupAttribute(string path, object value, bool animate = true)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2A88890", Offset = "0x2A86E90", VA = "0x182A88890", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x38")]
		public object Value;
	}
}
