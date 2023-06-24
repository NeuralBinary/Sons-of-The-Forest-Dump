using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[AddComponentMenu("NGUI/Interaction/Event Trigger")]
	public class UIEventTrigger : MonoBehaviour
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x1700014E")]
		public bool isColliderEnabled
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x26BBD50", Offset = "0x26BA350", VA = "0x1826BBD50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x26BBF70", Offset = "0x26BA570", VA = "0x1826BBF70")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x26BC190", Offset = "0x26BA790", VA = "0x1826BC190")]
		private void OnPress(bool pressed)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x26BC3B0", Offset = "0x26BA9B0", VA = "0x1826BC3B0")]
		private void OnSelect(bool selected)
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x26BC5D0", Offset = "0x26BABD0", VA = "0x1826BC5D0")]
		private void OnClick()
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x26BC7D0", Offset = "0x26BADD0", VA = "0x1826BC7D0")]
		private void OnDoubleClick()
		{
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x26BC9D0", Offset = "0x26BAFD0", VA = "0x1826BC9D0")]
		private void OnDragStart()
		{
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x26BCBC0", Offset = "0x26BB1C0", VA = "0x1826BCBC0")]
		private void OnDragEnd()
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x26BCDB0", Offset = "0x26BB3B0", VA = "0x1826BCDB0")]
		private void OnDragOver(GameObject go)
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x26BCFB0", Offset = "0x26BB5B0", VA = "0x1826BCFB0")]
		private void OnDragOut(GameObject go)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x26BD1B0", Offset = "0x26BB7B0", VA = "0x1826BD1B0")]
		private void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x26BD3A0", Offset = "0x26BB9A0", VA = "0x1826BD3A0")]
		public UIEventTrigger()
		{
		}

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x0")]
		public static UIEventTrigger current;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x20")]
		public List<EventDelegate> onHoverOver;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x28")]
		public List<EventDelegate> onHoverOut;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x30")]
		public List<EventDelegate> onPress;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x38")]
		public List<EventDelegate> onRelease;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x40")]
		public List<EventDelegate> onSelect;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x48")]
		public List<EventDelegate> onDeselect;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x50")]
		public List<EventDelegate> onClick;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x58")]
		public List<EventDelegate> onDoubleClick;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x60")]
		public List<EventDelegate> onDragStart;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x68")]
		public List<EventDelegate> onDragEnd;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x70")]
		public List<EventDelegate> onDragOver;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x78")]
		public List<EventDelegate> onDragOut;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x80")]
		public List<EventDelegate> onDrag;
	}
}
