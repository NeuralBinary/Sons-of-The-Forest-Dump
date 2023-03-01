using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005E8 RID: 1512
	[Token(Token = "0x20005E8")]
	[Serializable]
	public class DismemberedLimbItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x060026C2 RID: 9922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x2D934F0", Offset = "0x2D924F0", VA = "0x182D934F0")]
		public void SetSourceActor(int actorTypeId)
		{
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x2D933E0", Offset = "0x2D923E0", VA = "0x182D933E0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x2D934A0", Offset = "0x2D924A0", VA = "0x182D934A0", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x2D933B0", Offset = "0x2D923B0", VA = "0x182D933B0", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x2D932C0", Offset = "0x2D922C0", VA = "0x182D932C0", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x2D93330", Offset = "0x2D92330", VA = "0x182D93330", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CA")]
		[Address(RVA = "0x2D93510", Offset = "0x2D92510", VA = "0x182D93510")]
		public DismemberedLimbItemInstanceModule()
		{
		}

		// Token: 0x0400232A RID: 9002
		[Token(Token = "0x400232A")]
		[FieldOffset(Offset = "0x20")]
		private GameObject _itemObject;

		// Token: 0x0400232B RID: 9003
		[Token(Token = "0x400232B")]
		[FieldOffset(Offset = "0x28")]
		private VailActorTypeId _sourceActorType;

		// Token: 0x020005E9 RID: 1513
		[Token(Token = "0x20005E9")]
		[Serializable]
		public class DismemberedSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x060026CB RID: 9931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026CB")]
			[Address(RVA = "0x2D93520", Offset = "0x2D92520", VA = "0x182D93520")]
			public DismemberedSaveData()
			{
			}

			// Token: 0x0400232C RID: 9004
			[Token(Token = "0x400232C")]
			[FieldOffset(Offset = "0x20")]
			public int SourceActorType;
		}
	}
}
