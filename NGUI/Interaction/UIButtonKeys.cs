using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	[AddComponentMenu("NGUI/Interaction/Button Keys (Legacy)")]
	[ExecuteInEditMode]
	public class UIButtonKeys : UIKeyNavigation
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x26ACCE0", Offset = "0x26AB2E0", VA = "0x1826ACCE0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x26ACE10", Offset = "0x26AB410", VA = "0x1826ACE10")]
		public void Upgrade()
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x26AD900", Offset = "0x26ABF00", VA = "0x1826AD900")]
		public UIButtonKeys()
		{
		}

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x60")]
		public UIButtonKeys selectOnClick;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x68")]
		public UIButtonKeys selectOnUp;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x70")]
		public UIButtonKeys selectOnDown;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonKeys selectOnLeft;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonKeys selectOnRight;
	}
}
