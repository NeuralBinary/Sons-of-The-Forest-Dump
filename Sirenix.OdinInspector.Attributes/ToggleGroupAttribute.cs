using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ToggleGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2A8A760", Offset = "0x2A88D60", VA = "0x182A8A760")]
		public ToggleGroupAttribute(string toggleMemberName, float order = 0f, [Optional] string groupTitle)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2A8A7E0", Offset = "0x2A88DE0", VA = "0x182A8A7E0")]
		public ToggleGroupAttribute(string toggleMemberName, string groupTitle)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2A8A760", Offset = "0x2A88D60", VA = "0x182A8A760")]
		[Obsolete("Use [ToggleGroup(\"toggleMemberName\", groupTitle: \"$titleStringMemberName\")] instead")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ToggleGroupAttribute(string toggleMemberName, float order, string groupTitle, string titleStringMemberName)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003B")]
		public string ToggleMemberName
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Add a $ infront of group title instead, i.e: \"$MyStringMember\".")]
		public string TitleStringMemberName
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2A8A860", Offset = "0x2A88E60", VA = "0x182A8A860", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string ToggleGroupTitle;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool CollapseOthersOnExpand;
	}
}
