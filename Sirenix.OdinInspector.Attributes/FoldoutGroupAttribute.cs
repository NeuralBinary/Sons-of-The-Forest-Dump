using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public class FoldoutGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public bool Expanded
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2A88640", Offset = "0x2A86C40", VA = "0x182A88640")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public bool HasDefinedExpanded
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x98F620", Offset = "0x98DC20", VA = "0x18098F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2A88380", Offset = "0x2A86980", VA = "0x182A88380")]
		public FoldoutGroupAttribute(string groupName, float order = 0f)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2A88650", Offset = "0x2A86C50", VA = "0x182A88650")]
		public FoldoutGroupAttribute(string groupName, bool expanded, float order = 0f)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2A88680", Offset = "0x2A86C80", VA = "0x182A88680", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x38")]
		private bool expanded;
	}
}
