using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All)]
	public class InlineEditorAttribute : Attribute
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public bool Expanded
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x2A88CA0", Offset = "0x2A872A0", VA = "0x182A88CA0")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public bool ExpandedHasValue
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x9962C0", Offset = "0x9948C0", VA = "0x1809962C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x9962D0", Offset = "0x9948D0", VA = "0x1809962D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2A88CB0", Offset = "0x2A872B0", VA = "0x182A88CB0")]
		public InlineEditorAttribute(InlineEditorModes inlineEditorMode = InlineEditorModes.GUIOnly, InlineEditorObjectFieldModes objectFieldMode = InlineEditorObjectFieldModes.Boxed)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2A88DA0", Offset = "0x2A873A0", VA = "0x182A88DA0")]
		public InlineEditorAttribute(InlineEditorObjectFieldModes objectFieldMode)
		{
		}

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x10")]
		private bool expanded;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x11")]
		public bool DrawHeader;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x12")]
		public bool DrawGUI;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x13")]
		public bool DrawPreview;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x14")]
		public float MaxHeight;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x18")]
		public float PreviewWidth;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x1C")]
		public float PreviewHeight;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x20")]
		public bool IncrementInlineEditorDrawerDepth;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x24")]
		public InlineEditorObjectFieldModes ObjectFieldMode;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x28")]
		public bool DisableGUIForVCSLockedAssets;
	}
}
