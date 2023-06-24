using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000795 RID: 1941
	[Token(Token = "0x2000795")]
	[AddComponentMenu("Sons/Pickup/Alternating")]
	public class AlternatingPickUp : EdiblePickUp, ISeasonsReceiver
	{
		// Token: 0x0600343E RID: 13374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343E")]
		[Address(RVA = "0x34C8060", Offset = "0x34C6660", VA = "0x1834C8060", Slot = "13")]
		protected override void Awake()
		{
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343F")]
		[Address(RVA = "0x34C8070", Offset = "0x34C6670", VA = "0x1834C8070", Slot = "19")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003440")]
		[Address(RVA = "0x34C8170", Offset = "0x34C6770", VA = "0x1834C8170", Slot = "23")]
		public override void GrabEnter()
		{
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003441")]
		[Address(RVA = "0x34C84E0", Offset = "0x34C6AE0", VA = "0x1834C84E0", Slot = "25")]
		public override void GrabExit()
		{
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		[Token(Token = "0x6003442")]
		[Address(RVA = "0x34C8650", Offset = "0x34C6C50", VA = "0x1834C8650", Slot = "29")]
		protected override bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003443")]
		[Address(RVA = "0x34C7ED0", Offset = "0x34C64D0", VA = "0x1834C7ED0")]
		public AlternatingPickUp()
		{
		}

		// Token: 0x04002D24 RID: 11556
		[Token(Token = "0x4002D24")]
		[FieldOffset(Offset = "0x128")]
		[ItemIdPicker]
		public int _heldItemId;

		// Token: 0x04002D25 RID: 11557
		[Token(Token = "0x4002D25")]
		[FieldOffset(Offset = "0x12C")]
		public EquipmentSlot _heldItemSlot;

		// Token: 0x04002D26 RID: 11558
		[Token(Token = "0x4002D26")]
		[FieldOffset(Offset = "0x130")]
		[ItemIdPicker]
		public int _altItemId;

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		[HideInInspector]
		private int _originalItemId;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0x138")]
		public GameObject _altMyPickUp;
	}
}
