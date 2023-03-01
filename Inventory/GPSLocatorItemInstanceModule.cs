using System;
using Il2CppDummyDll;
using Sons.Gameplay.GPS;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005EA RID: 1514
	[Token(Token = "0x20005EA")]
	[Serializable]
	public class GPSLocatorItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x060026CC RID: 9932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CC")]
		[Address(RVA = "0x2D935A0", Offset = "0x2D925A0", VA = "0x182D935A0", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CD")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CE")]
		[Address(RVA = "0x2D93690", Offset = "0x2D92690", VA = "0x182D93690", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CF")]
		[Address(RVA = "0x2D93740", Offset = "0x2D92740", VA = "0x182D93740", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D0")]
		[Address(RVA = "0x2D93640", Offset = "0x2D92640", VA = "0x182D93640", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0x2D93530", Offset = "0x2D92530", VA = "0x182D93530", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x2D935B0", Offset = "0x2D925B0", VA = "0x182D935B0", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x2D937A0", Offset = "0x2D927A0", VA = "0x182D937A0")]
		public GPSLocatorItemInstanceModule()
		{
		}

		// Token: 0x0400232D RID: 9005
		[Token(Token = "0x400232D")]
		[FieldOffset(Offset = "0x20")]
		public GPSLocator.Style UiStyle;

		// Token: 0x0400232E RID: 9006
		[Token(Token = "0x400232E")]
		[FieldOffset(Offset = "0x24")]
		public Color Color;

		// Token: 0x0400232F RID: 9007
		[Token(Token = "0x400232F")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D IconImage;

		// Token: 0x04002330 RID: 9008
		[Token(Token = "0x4002330")]
		[FieldOffset(Offset = "0x40")]
		public float IconScale;

		// Token: 0x04002331 RID: 9009
		[Token(Token = "0x4002331")]
		[FieldOffset(Offset = "0x44")]
		public bool PulseIcon;

		// Token: 0x04002332 RID: 9010
		[Token(Token = "0x4002332")]
		[FieldOffset(Offset = "0x45")]
		public bool ConstrainToScreen;

		// Token: 0x04002333 RID: 9011
		[Token(Token = "0x4002333")]
		[FieldOffset(Offset = "0x46")]
		public bool RecordMovementHistory;

		// Token: 0x04002334 RID: 9012
		[Token(Token = "0x4002334")]
		[FieldOffset(Offset = "0x48")]
		public int RecordEveryNSeconds;

		// Token: 0x04002335 RID: 9013
		[Token(Token = "0x4002335")]
		[FieldOffset(Offset = "0x4C")]
		public bool ShouldBeepWhenInRange;

		// Token: 0x04002336 RID: 9014
		[Token(Token = "0x4002336")]
		[FieldOffset(Offset = "0x50")]
		public float BeepMaxRange;

		// Token: 0x04002337 RID: 9015
		[Token(Token = "0x4002337")]
		[FieldOffset(Offset = "0x54")]
		public bool IsActive;

		// Token: 0x04002338 RID: 9016
		[Token(Token = "0x4002338")]
		[FieldOffset(Offset = "0x58")]
		public int CurrentIconId;

		// Token: 0x04002339 RID: 9017
		[Token(Token = "0x4002339")]
		[FieldOffset(Offset = "0x5C")]
		public bool HasBeenPopulated;

		// Token: 0x020005EB RID: 1515
		[Token(Token = "0x20005EB")]
		[Serializable]
		public class GpsLocatorSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x060026D4 RID: 9940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026D4")]
			[Address(RVA = "0x2D93520", Offset = "0x2D92520", VA = "0x182D93520")]
			public GpsLocatorSaveData()
			{
			}

			// Token: 0x0400233A RID: 9018
			[Token(Token = "0x400233A")]
			[FieldOffset(Offset = "0x20")]
			public int IconIndex;

			// Token: 0x0400233B RID: 9019
			[Token(Token = "0x400233B")]
			[FieldOffset(Offset = "0x24")]
			public bool ShowBreadcrumbs;
		}
	}
}
