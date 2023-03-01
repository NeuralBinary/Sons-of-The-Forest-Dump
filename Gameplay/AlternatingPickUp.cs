using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000674 RID: 1652
	[Token(Token = "0x2000674")]
	[AddComponentMenu("Sons/Pickup/Alternating")]
	public class AlternatingPickUp : EdiblePickUp, ISeasonsReceiver
	{
		// Token: 0x06002A36 RID: 10806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A36")]
		[Address(RVA = "0x2DC5F00", Offset = "0x2DC4F00", VA = "0x182DC5F00", Slot = "11")]
		protected override void Awake()
		{
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A37")]
		[Address(RVA = "0x2DC61F0", Offset = "0x2DC51F0", VA = "0x182DC61F0", Slot = "17")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A38")]
		[Address(RVA = "0x2DC5F10", Offset = "0x2DC4F10", VA = "0x182DC5F10", Slot = "21")]
		public override void GrabEnter()
		{
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A39")]
		[Address(RVA = "0x2DC60C0", Offset = "0x2DC50C0", VA = "0x182DC60C0", Slot = "23")]
		public override void GrabExit()
		{
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0x2DC6160", Offset = "0x2DC5160", VA = "0x182DC6160", Slot = "27")]
		protected override bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0x2DC6290", Offset = "0x2DC5290", VA = "0x182DC6290")]
		public AlternatingPickUp()
		{
		}

		// Token: 0x040025C4 RID: 9668
		[Token(Token = "0x40025C4")]
		[FieldOffset(Offset = "0x118")]
		[ItemIdPicker]
		public int _heldItemId;

		// Token: 0x040025C5 RID: 9669
		[Token(Token = "0x40025C5")]
		[FieldOffset(Offset = "0x11C")]
		public EquipmentSlot _heldItemSlot;

		// Token: 0x040025C6 RID: 9670
		[Token(Token = "0x40025C6")]
		[FieldOffset(Offset = "0x120")]
		[ItemIdPicker]
		public int _altItemId;

		// Token: 0x040025C7 RID: 9671
		[Token(Token = "0x40025C7")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		[HideInInspector]
		private int _originalItemId;

		// Token: 0x040025C8 RID: 9672
		[Token(Token = "0x40025C8")]
		[FieldOffset(Offset = "0x128")]
		public GameObject _altMyPickUp;
	}
}
