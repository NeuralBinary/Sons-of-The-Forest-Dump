using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008DD RID: 2269
	[Token(Token = "0x20008DD")]
	public class OpenSecurityDoorTrigger : DoorTriggerCutsceneBase
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x00012228 File Offset: 0x00010428
		[Token(Token = "0x170007CE")]
		protected override int EnterAnimHash
		{
			[Token(Token = "0x6003DB4")]
			[Address(RVA = "0x2F20D70", Offset = "0x2F1FD70", VA = "0x182F20D70", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x00012240 File Offset: 0x00010440
		[Token(Token = "0x170007CF")]
		protected override int EnterAnimBoolHash
		{
			[Token(Token = "0x6003DB5")]
			[Address(RVA = "0x2F20D10", Offset = "0x2F1FD10", VA = "0x182F20D10", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x00012258 File Offset: 0x00010458
		[Token(Token = "0x170007D0")]
		protected override int IdleClosedAnimHash
		{
			[Token(Token = "0x6003DB6")]
			[Address(RVA = "0x2F20DD0", Offset = "0x2F1FDD0", VA = "0x182F20DD0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x00012270 File Offset: 0x00010470
		[Token(Token = "0x170007D1")]
		protected override int IdleOpenAnimHash
		{
			[Token(Token = "0x6003DB7")]
			[Address(RVA = "0x2F20E30", Offset = "0x2F1FE30", VA = "0x182F20E30", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x00012288 File Offset: 0x00010488
		[Token(Token = "0x170007D2")]
		protected override int DenyEntryAnimHash
		{
			[Token(Token = "0x6003DB8")]
			[Address(RVA = "0x2F20C50", Offset = "0x2F1FC50", VA = "0x182F20C50", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x000122A0 File Offset: 0x000104A0
		[Token(Token = "0x170007D3")]
		protected override int DenyEntryBoolHash
		{
			[Token(Token = "0x6003DB9")]
			[Address(RVA = "0x2F20CB0", Offset = "0x2F1FCB0", VA = "0x182F20CB0", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x000122B8 File Offset: 0x000104B8
		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x2F20B70", Offset = "0x2F1FB70", VA = "0x182F20B70", Slot = "24")]
		protected override bool CheckCanOpen()
		{
			return default(bool);
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0x2F20BD0", Offset = "0x2F1FBD0", VA = "0x182F20BD0", Slot = "36")]
		internal override void DoEquipKeyItem()
		{
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x000122D0 File Offset: 0x000104D0
		[Token(Token = "0x170007D4")]
		protected int KeyItemId
		{
			[Token(Token = "0x6003DBC")]
			[Address(RVA = "0x2F20E90", Offset = "0x2F1FE90", VA = "0x182F20E90")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBD")]
		[Address(RVA = "0x2F20C40", Offset = "0x2F1FC40", VA = "0x182F20C40", Slot = "27")]
		protected override void OnDoorSateChanged(DoorState doorState)
		{
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBE")]
		[Address(RVA = "0x2F18C60", Offset = "0x2F17C60", VA = "0x182F18C60")]
		public OpenSecurityDoorTrigger()
		{
		}

		// Token: 0x04004176 RID: 16758
		[Token(Token = "0x4004176")]
		[FieldOffset(Offset = "0x128")]
		[FormerlySerializedAs("_showItemId")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _keyItemId;
	}
}
