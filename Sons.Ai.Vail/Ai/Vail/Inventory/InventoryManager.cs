using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.Inventory
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	public class InventoryManager : MonoBehaviour
	{
		// Token: 0x06000F33 RID: 3891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x2BB6E20", Offset = "0x2BB5420", VA = "0x182BB6E20")]
		private void CollectAttachments()
		{
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
		public void SetCallbacks(IRobbyCallbacks callbacks)
		{
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
		public IRobbyCallbacks GetRobbyCallbacks()
		{
			return null;
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x2BB6FA0", Offset = "0x2BB55A0", VA = "0x182BB6FA0")]
		private Transform GetPickupParent(string itemName)
		{
			return null;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x2BB7240", Offset = "0x2BB5840", VA = "0x182BB7240")]
		public bool CanPickup(VailPickup item)
		{
			return default(bool);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x2BB7350", Offset = "0x2BB5950", VA = "0x182BB7350")]
		private static void ClearWorldItem(VailPickup worldItem)
		{
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x2BB7550", Offset = "0x2BB5B50", VA = "0x182BB7550")]
		public void Pickup(VailPickup worldItem)
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x2BB76E0", Offset = "0x2BB5CE0", VA = "0x182BB76E0")]
		public void Pickup(string itemType, Vector3 worldPos, Quaternion worldRot, VailPickup worldItem)
		{
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x2BB79F0", Offset = "0x2BB5FF0", VA = "0x182BB79F0")]
		public static void SetCarryParam(Animator animator, string itemType)
		{
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x2BB7B20", Offset = "0x2BB6120", VA = "0x182BB7B20")]
		public void ShowAttachedPickup(string itemType)
		{
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0x2BB84C0", Offset = "0x2BB6AC0", VA = "0x182BB84C0")]
		public void ClearAttachedPickups()
		{
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x2BB87A0", Offset = "0x2BB6DA0", VA = "0x182BB87A0")]
		public void InstantCarry(string itemType)
		{
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x2BB8BF0", Offset = "0x2BB71F0", VA = "0x182BB8BF0")]
		private CarryAttachments GetCarryAttachments(string itemType)
		{
			return null;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x2BB8D80", Offset = "0x2BB7380", VA = "0x182BB8D80")]
		private bool TryAttachToCarryPoint(VailPickup pickup)
		{
			return default(bool);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x2BB9020", Offset = "0x2BB7620", VA = "0x182BB9020")]
		private void SendAttachItemEventIfNeeded(VailPickup pickup, bool attached)
		{
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x2BB9280", Offset = "0x2BB7880", VA = "0x182BB9280")]
		public void OnAttachItemEvent(VailAttachItemEvent evt)
		{
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x2BB9650", Offset = "0x2BB7C50", VA = "0x182BB9650")]
		public void TransferToCarry()
		{
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x2BB9740", Offset = "0x2BB7D40", VA = "0x182BB9740")]
		public void TransferToHand()
		{
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x2BB9940", Offset = "0x2BB7F40", VA = "0x182BB9940")]
		private void AlignPickupTransform(VailPickup pickup)
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x2BB9EB0", Offset = "0x2BB84B0", VA = "0x182BB9EB0")]
		private bool AttachPhysicsPickup(VailPickup pickup, Transform parent)
		{
			return default(bool);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x2BBA120", Offset = "0x2BB8720", VA = "0x182BBA120")]
		private void DropPhysicsItem()
		{
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x2BBA330", Offset = "0x2BB8930", VA = "0x182BBA330")]
		private void AttachToCharacter(VailPickup pickup, InventoryManager.AttachType attachType)
		{
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x2BBA4E0", Offset = "0x2BB8AE0", VA = "0x182BBA4E0")]
		public void DropAll(Vector3 facingDir, int addedToHolderCount = 0)
		{
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x2BBA9F0", Offset = "0x2BB8FF0", VA = "0x182BBA9F0")]
		public void ClearCarry()
		{
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x2BBACC0", Offset = "0x2BB92C0", VA = "0x182BBACC0")]
		public void OnImpact(Vector3 impactKnockbackDir)
		{
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x2BBACF0", Offset = "0x2BB92F0", VA = "0x182BBACF0")]
		public void UpdateTransforms(float deltaTime)
		{
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x2BBAFD0", Offset = "0x2BB95D0", VA = "0x182BBAFD0")]
		public void SpawnItem(VailPickup heldItem, Vector3 spawnPos, Quaternion spawnRot, Vector3 velDir)
		{
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x2BBB410", Offset = "0x2BB9A10", VA = "0x182BBB410")]
		private bool IsHolding(string itemType)
		{
			return default(bool);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x2BBB430", Offset = "0x2BB9A30", VA = "0x182BBB430")]
		private bool IsFull(string itemType)
		{
			return default(bool);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x2BBB480", Offset = "0x2BB9A80", VA = "0x182BBB480")]
		public string GetItemType()
		{
			return null;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00008610 File Offset: 0x00006810
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x2BBB660", Offset = "0x2BB9C60", VA = "0x182BBB660")]
		public int GetCount(string itemType)
		{
			return 0;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00008628 File Offset: 0x00006828
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x2BBB890", Offset = "0x2BB9E90", VA = "0x182BBB890")]
		public int GetCountAll()
		{
			return 0;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x2BBB940", Offset = "0x2BB9F40", VA = "0x182BBB940")]
		public void AddHeldItem(VailPickup pickup)
		{
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00008640 File Offset: 0x00006840
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x2BBB9E0", Offset = "0x2BB9FE0", VA = "0x182BBB9E0")]
		public int GetItemCarryTypeCount()
		{
			return 0;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x2BBBB10", Offset = "0x2BBA110", VA = "0x182BBBB10")]
		private void TestReplicateCurrentHeld()
		{
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x2BBBB40", Offset = "0x2BBA140", VA = "0x182BBBB40")]
		private void TestReplicateHoldItem(string type, int count)
		{
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x2BBBBF0", Offset = "0x2BBA1F0", VA = "0x182BBBBF0")]
		public void OnReplicatedHeldItems(int itemTypes)
		{
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x2BBBED0", Offset = "0x2BBA4D0", VA = "0x182BBBED0")]
		public string GetDebugString()
		{
			return null;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00008658 File Offset: 0x00006858
		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x2BBC1B0", Offset = "0x2BBA7B0", VA = "0x182BBC1B0")]
		public bool CanDrop(IVailDropTarget target)
		{
			return default(bool);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x2BBC220", Offset = "0x2BBA820", VA = "0x182BBC220")]
		public InventoryManager()
		{
		}

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		private const int MaxHeldItems = 5;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		private const int BitsPerItemId = 6;

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		private const int ItemIdMask = 63;

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _dropItemsOnImpact;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _pickupParent;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<CarryAttachments> _carryAttachments;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<VailPickup> _heldItems;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<VailPickup> _attachedItems;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x48")]
		private int _clientHeldCount;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody _heldRigidBody;

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0x60")]
		private Transform _heldRigidBodyParent;

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x68")]
		private Transform _placingItem;

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0x70")]
		private IRobbyCallbacks _robbyCallbacks;

		// Token: 0x02000219 RID: 537
		[Token(Token = "0x2000219")]
		private enum AttachType
		{
			// Token: 0x04000950 RID: 2384
			[Token(Token = "0x4000950")]
			Pickup,
			// Token: 0x04000951 RID: 2385
			[Token(Token = "0x4000951")]
			Carry
		}
	}
}
