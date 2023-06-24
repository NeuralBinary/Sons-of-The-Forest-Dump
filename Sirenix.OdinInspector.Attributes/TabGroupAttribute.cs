using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sirenix.OdinInspector.Internal;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public class TabGroupAttribute : PropertyGroupAttribute, ISubGroupProviderAttribute
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2A89CD0", Offset = "0x2A882D0", VA = "0x182A89CD0")]
		public TabGroupAttribute(string tab, bool useFixedHeight = false, float order = 0f)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2A89D50", Offset = "0x2A88350", VA = "0x182A89D50")]
		public TabGroupAttribute(string group, string tab, bool useFixedHeight = false, float order = 0f)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public List<string> Tabs
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2A89F10", Offset = "0x2A88510", VA = "0x182A89F10", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2A8A020", Offset = "0x2A88620", VA = "0x182A8A020", Slot = "8")]
		private IList<PropertyGroupAttribute> GetSubGroupAttributes()
		{
			return null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2A8A2B0", Offset = "0x2A888B0", VA = "0x182A8A2B0", Slot = "9")]
		private string RepathMemberAttribute(PropertyGroupAttribute attr)
		{
			return null;
		}

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		public const string DEFAULT_NAME = "_DefaultTabGroup";

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x38")]
		public string TabName;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x40")]
		public bool UseFixedHeight;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x41")]
		public bool Paddingless;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x42")]
		public bool HideTabGroupIfTabGroupOnlyHasOneTab;

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		[Conditional("UNITY_EDITOR")]
		public class TabSubGroupAttribute : PropertyGroupAttribute
		{
			// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2A88380", Offset = "0x2A86980", VA = "0x182A88380")]
			public TabSubGroupAttribute(string groupId, float order)
			{
			}
		}
	}
}
