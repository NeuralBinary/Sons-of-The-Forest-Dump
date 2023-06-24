using System;
using Il2CppDummyDll;
using Sons.Gameplay.GPS;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005FC RID: 1532
	[Token(Token = "0x20005FC")]
	[Serializable]
	public class GPSLocatorItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x060027D6 RID: 10198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D6")]
		[Address(RVA = "0x33CE410", Offset = "0x33CCA10", VA = "0x1833CE410", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x33CE420", Offset = "0x33CCA20", VA = "0x1833CE420", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x33CE550", Offset = "0x33CCB50", VA = "0x1833CE550", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x33CE5C0", Offset = "0x33CCBC0", VA = "0x1833CE5C0", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x33CE650", Offset = "0x33CCC50", VA = "0x1833CE650", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DC")]
		[Address(RVA = "0x33CE6C0", Offset = "0x33CCCC0", VA = "0x1833CE6C0", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x33CE750", Offset = "0x33CCD50", VA = "0x1833CE750")]
		public GPSLocatorItemInstanceModule()
		{
		}

		// Token: 0x04002410 RID: 9232
		[Token(Token = "0x4002410")]
		[FieldOffset(Offset = "0x20")]
		public GPSLocator.Style UiStyle;

		// Token: 0x04002411 RID: 9233
		[Token(Token = "0x4002411")]
		[FieldOffset(Offset = "0x24")]
		public Color Color;

		// Token: 0x04002412 RID: 9234
		[Token(Token = "0x4002412")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D IconImage;

		// Token: 0x04002413 RID: 9235
		[Token(Token = "0x4002413")]
		[FieldOffset(Offset = "0x40")]
		public float IconScale;

		// Token: 0x04002414 RID: 9236
		[Token(Token = "0x4002414")]
		[FieldOffset(Offset = "0x44")]
		public bool PulseIcon;

		// Token: 0x04002415 RID: 9237
		[Token(Token = "0x4002415")]
		[FieldOffset(Offset = "0x45")]
		public bool ConstrainToScreen;

		// Token: 0x04002416 RID: 9238
		[Token(Token = "0x4002416")]
		[FieldOffset(Offset = "0x46")]
		public bool RecordMovementHistory;

		// Token: 0x04002417 RID: 9239
		[Token(Token = "0x4002417")]
		[FieldOffset(Offset = "0x48")]
		public int RecordEveryNSeconds;

		// Token: 0x04002418 RID: 9240
		[Token(Token = "0x4002418")]
		[FieldOffset(Offset = "0x4C")]
		public bool ShouldBeepWhenInRange;

		// Token: 0x04002419 RID: 9241
		[Token(Token = "0x4002419")]
		[FieldOffset(Offset = "0x50")]
		public float BeepMaxRange;

		// Token: 0x0400241A RID: 9242
		[Token(Token = "0x400241A")]
		[FieldOffset(Offset = "0x54")]
		public bool IsActive;

		// Token: 0x0400241B RID: 9243
		[Token(Token = "0x400241B")]
		[FieldOffset(Offset = "0x58")]
		public int CurrentIconId;

		// Token: 0x0400241C RID: 9244
		[Token(Token = "0x400241C")]
		[FieldOffset(Offset = "0x5C")]
		public bool HasBeenPopulated;

		// Token: 0x020005FD RID: 1533
		[Token(Token = "0x20005FD")]
		[Serializable]
		public class GpsLocatorSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x060027DE RID: 10206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60027DE")]
			[Address(RVA = "0x33CE370", Offset = "0x33CC970", VA = "0x1833CE370")]
			public GpsLocatorSaveData()
			{
			}

			// Token: 0x0400241D RID: 9245
			[Token(Token = "0x400241D")]
			[FieldOffset(Offset = "0x20")]
			public int IconIndex;

			// Token: 0x0400241E RID: 9246
			[Token(Token = "0x400241E")]
			[FieldOffset(Offset = "0x24")]
			public bool ShowBreadcrumbs;
		}
	}
}
