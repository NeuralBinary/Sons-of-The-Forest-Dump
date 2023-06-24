using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000958 RID: 2392
	[Token(Token = "0x2000958")]
	public class OpenSecurityDoorTerminalTrigger : DoorTriggerCutsceneBase
	{
		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06004544 RID: 17732 RVA: 0x000152D0 File Offset: 0x000134D0
		[Token(Token = "0x17000908")]
		protected override int IdleOpenAnimHash
		{
			[Token(Token = "0x6004544")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x000152E8 File Offset: 0x000134E8
		[Token(Token = "0x17000909")]
		protected override int IdleClosedAnimHash
		{
			[Token(Token = "0x6004545")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06004546 RID: 17734 RVA: 0x00015300 File Offset: 0x00013500
		[Token(Token = "0x1700090A")]
		protected override int EnterAnimHash
		{
			[Token(Token = "0x6004546")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x00015318 File Offset: 0x00013518
		[Token(Token = "0x1700090B")]
		protected override int EnterAnimBoolHash
		{
			[Token(Token = "0x6004547")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06004548 RID: 17736 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x1700090C")]
		protected override int DenyEntryAnimHash
		{
			[Token(Token = "0x6004548")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x1700090D")]
		protected override int DenyEntryBoolHash
		{
			[Token(Token = "0x6004549")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "23")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x00015360 File Offset: 0x00013560
		[Token(Token = "0x600454A")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "24")]
		protected override bool CheckCanOpen()
		{
			return default(bool);
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454B")]
		[Address(RVA = "0x3660A50", Offset = "0x365F050", VA = "0x183660A50", Slot = "34")]
		protected override IEnumerator PlayOpenDoorSequenceSynced()
		{
			return null;
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454C")]
		[Address(RVA = "0x3660AE0", Offset = "0x365F0E0", VA = "0x183660AE0", Slot = "27")]
		protected override void OnDoorSateChanged(DoorState doorState)
		{
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454D")]
		[Address(RVA = "0x3660B50", Offset = "0x365F150", VA = "0x183660B50")]
		private void SetListActive(List<GameObject> listSource, bool value)
		{
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454E")]
		[Address(RVA = "0x36534B0", Offset = "0x3651AB0", VA = "0x1836534B0")]
		public OpenSecurityDoorTerminalTrigger()
		{
		}

		// Token: 0x040047D5 RID: 18389
		[Token(Token = "0x40047D5")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private List<GameObject> _activateOnOpen;

		// Token: 0x040047D6 RID: 18390
		[Token(Token = "0x40047D6")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<GameObject> _deactivateOnOpen;

		// Token: 0x040047D7 RID: 18391
		[Token(Token = "0x40047D7")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private UnityEvent _onOpenDoorEvent;

		// Token: 0x040047D8 RID: 18392
		[Token(Token = "0x40047D8")]
		[FieldOffset(Offset = "0x140")]
		private bool _playedOpenDoorSequence;
	}
}
