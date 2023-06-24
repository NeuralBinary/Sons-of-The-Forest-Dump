using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[AddComponentMenu("NGUI/Interaction/Key Binding")]
	public class UIKeyBinding : MonoBehaviour
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x26C07F0", Offset = "0x26BEDF0", VA = "0x1826C07F0")]
		public static bool IsBound(KeyCode key)
		{
			return default(bool);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x26C09B0", Offset = "0x26BEFB0", VA = "0x1826C09B0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x26C0A70", Offset = "0x26BF070", VA = "0x1826C0A70", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x26C0AF0", Offset = "0x26BF0F0", VA = "0x1826C0AF0", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x26C0CF0", Offset = "0x26BF2F0", VA = "0x1826C0CF0", Slot = "7")]
		protected virtual void OnSubmit()
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x26C0DA0", Offset = "0x26BF3A0", VA = "0x1826C0DA0", Slot = "8")]
		protected virtual bool IsModifierActive()
		{
			return default(bool);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x26C11A0", Offset = "0x26BF7A0", VA = "0x1826C11A0", Slot = "9")]
		protected virtual void Update()
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x26C1410", Offset = "0x26BFA10", VA = "0x1826C1410", Slot = "10")]
		protected virtual void OnBindingPress(bool pressed)
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x26C14F0", Offset = "0x26BFAF0", VA = "0x1826C14F0", Slot = "11")]
		protected virtual void OnBindingClick()
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIKeyBinding()
		{
		}

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x0")]
		private static List<UIKeyBinding> mList;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x20")]
		public KeyCode keyCode;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x24")]
		public UIKeyBinding.Modifier modifier;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x28")]
		public UIKeyBinding.Action action;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x2C")]
		[NonSerialized]
		private bool mIgnoreUp;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x2D")]
		[NonSerialized]
		private bool mIsInput;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x2E")]
		[NonSerialized]
		private bool mPress;

		// Token: 0x020000BC RID: 188
		[Token(Token = "0x20000BC")]
		public enum Action
		{
			// Token: 0x040004D9 RID: 1241
			[Token(Token = "0x40004D9")]
			PressAndClick,
			// Token: 0x040004DA RID: 1242
			[Token(Token = "0x40004DA")]
			Select,
			// Token: 0x040004DB RID: 1243
			[Token(Token = "0x40004DB")]
			All
		}

		// Token: 0x020000BD RID: 189
		[Token(Token = "0x20000BD")]
		public enum Modifier
		{
			// Token: 0x040004DD RID: 1245
			[Token(Token = "0x40004DD")]
			Any,
			// Token: 0x040004DE RID: 1246
			[Token(Token = "0x40004DE")]
			Shift,
			// Token: 0x040004DF RID: 1247
			[Token(Token = "0x40004DF")]
			Control,
			// Token: 0x040004E0 RID: 1248
			[Token(Token = "0x40004E0")]
			Alt,
			// Token: 0x040004E1 RID: 1249
			[Token(Token = "0x40004E1")]
			None
		}
	}
}
