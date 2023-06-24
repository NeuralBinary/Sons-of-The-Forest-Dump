using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x0200095A RID: 2394
	[Token(Token = "0x200095A")]
	public class OpenSecurityDoorTrigger : DoorTriggerCutsceneBase
	{
		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06004555 RID: 17749 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x17000910")]
		protected override int EnterAnimHash
		{
			[Token(Token = "0x6004555")]
			[Address(RVA = "0x3660DB0", Offset = "0x365F3B0", VA = "0x183660DB0", Slot = "20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06004556 RID: 17750 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x17000911")]
		protected override int EnterAnimBoolHash
		{
			[Token(Token = "0x6004556")]
			[Address(RVA = "0x3660E10", Offset = "0x365F410", VA = "0x183660E10", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06004557 RID: 17751 RVA: 0x000153C0 File Offset: 0x000135C0
		[Token(Token = "0x17000912")]
		protected override int IdleClosedAnimHash
		{
			[Token(Token = "0x6004557")]
			[Address(RVA = "0x3660E70", Offset = "0x365F470", VA = "0x183660E70", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06004558 RID: 17752 RVA: 0x000153D8 File Offset: 0x000135D8
		[Token(Token = "0x17000913")]
		protected override int IdleOpenAnimHash
		{
			[Token(Token = "0x6004558")]
			[Address(RVA = "0x3660ED0", Offset = "0x365F4D0", VA = "0x183660ED0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06004559 RID: 17753 RVA: 0x000153F0 File Offset: 0x000135F0
		[Token(Token = "0x17000914")]
		protected override int DenyEntryAnimHash
		{
			[Token(Token = "0x6004559")]
			[Address(RVA = "0x3660F30", Offset = "0x365F530", VA = "0x183660F30", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x0600455A RID: 17754 RVA: 0x00015408 File Offset: 0x00013608
		[Token(Token = "0x17000915")]
		protected override int DenyEntryBoolHash
		{
			[Token(Token = "0x600455A")]
			[Address(RVA = "0x3660F90", Offset = "0x365F590", VA = "0x183660F90", Slot = "23")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00015420 File Offset: 0x00013620
		[Token(Token = "0x600455B")]
		[Address(RVA = "0x3660FF0", Offset = "0x365F5F0", VA = "0x183660FF0", Slot = "24")]
		protected override bool CheckCanOpen()
		{
			return default(bool);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455C")]
		[Address(RVA = "0x3661090", Offset = "0x365F690", VA = "0x183661090", Slot = "38")]
		internal override void DoEquipKeyItem()
		{
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x00015438 File Offset: 0x00013638
		[Token(Token = "0x600455D")]
		[Address(RVA = "0x3661100", Offset = "0x365F700", VA = "0x183661100", Slot = "37")]
		internal override bool IsHoldingKeyItem()
		{
			return default(bool);
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x17000916")]
		protected int KeyItemId
		{
			[Token(Token = "0x600455E")]
			[Address(RVA = "0x3661160", Offset = "0x365F760", VA = "0x183661160")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455F")]
		[Address(RVA = "0x3661170", Offset = "0x365F770", VA = "0x183661170", Slot = "27")]
		protected override void OnDoorSateChanged(DoorState doorState)
		{
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004560")]
		[Address(RVA = "0x36534B0", Offset = "0x3651AB0", VA = "0x1836534B0")]
		public OpenSecurityDoorTrigger()
		{
		}

		// Token: 0x040047DC RID: 18396
		[Token(Token = "0x40047DC")]
		[FieldOffset(Offset = "0x128")]
		[ItemIdPicker(true)]
		[SerializeField]
		[FormerlySerializedAs("_showItemId")]
		private int _keyItemId;
	}
}
