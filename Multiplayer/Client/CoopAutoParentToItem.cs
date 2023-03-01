using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Sons.Multiplayer.Client
{
	// Token: 0x02000563 RID: 1379
	[Token(Token = "0x2000563")]
	public class CoopAutoParentToItem : EntityBehaviour<IWeaponFire>
	{
		// Token: 0x060023E7 RID: 9191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x2D7CE50", Offset = "0x2D7BE50", VA = "0x182D7CE50", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void SetParent()
		{
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x2D7D480", Offset = "0x2D7C480", VA = "0x182D7D480")]
		private void SetPosition()
		{
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x2D7D640", Offset = "0x2D7C640", VA = "0x182D7D640")]
		private void SetRotation()
		{
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x2D7D800", Offset = "0x2D7C800", VA = "0x182D7D800")]
		public CoopAutoParentToItem()
		{
		}

		// Token: 0x0400204D RID: 8269
		[Token(Token = "0x400204D")]
		[FieldOffset(Offset = "0x28")]
		public EquipmentSlot _slot;

		// Token: 0x0400204E RID: 8270
		[Token(Token = "0x400204E")]
		[FieldOffset(Offset = "0x2C")]
		public bool attachToCloth;
	}
}
