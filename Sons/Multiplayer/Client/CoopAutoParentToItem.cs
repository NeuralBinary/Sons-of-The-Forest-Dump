using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Sons.Multiplayer.Client
{
	// Token: 0x02000573 RID: 1395
	[Token(Token = "0x2000573")]
	public class CoopAutoParentToItem : EntityBehaviour<IWeaponFire>
	{
		// Token: 0x060024E5 RID: 9445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x3391690", Offset = "0x338FC90", VA = "0x183391690", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void SetParent()
		{
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E7")]
		[Address(RVA = "0x3391DC0", Offset = "0x33903C0", VA = "0x183391DC0")]
		private void SetPosition()
		{
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x33920C0", Offset = "0x33906C0", VA = "0x1833920C0")]
		private void SetRotation()
		{
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x33923B0", Offset = "0x33909B0", VA = "0x1833923B0")]
		public CoopAutoParentToItem()
		{
		}

		// Token: 0x04002120 RID: 8480
		[Token(Token = "0x4002120")]
		[FieldOffset(Offset = "0x28")]
		public EquipmentSlot _slot;

		// Token: 0x04002121 RID: 8481
		[Token(Token = "0x4002121")]
		[FieldOffset(Offset = "0x2C")]
		public bool attachToCloth;
	}
}
