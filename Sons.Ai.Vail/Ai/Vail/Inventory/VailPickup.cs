using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using Sons.Ragdoll;
using UnityEngine;

namespace Sons.Ai.Vail.Inventory
{
	// Token: 0x02000222 RID: 546
	[Token(Token = "0x2000222")]
	[AddComponentMenu("Sons/Ai/Interact/Vail Pickup")]
	public class VailPickup : MonoBehaviour, IVailActorInteract
	{
		// Token: 0x06000F82 RID: 3970 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x2BBED30", Offset = "0x2BBD330", VA = "0x182BBED30")]
		private static ValueDropdownList<string> GetItemTypes()
		{
			return null;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public Transform GetRoot()
		{
			return null;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public string GetItemType()
		{
			return null;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		public Transform GetPickupTransform()
		{
			return null;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000D5")]
		public Rigidbody HoldByRigidbody
		{
			[Token(Token = "0x6000F86")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x2BBED70", Offset = "0x2BBD370", VA = "0x182BBED70")]
		private void Awake()
		{
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x2BBEEC0", Offset = "0x2BBD4C0", VA = "0x182BBEEC0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x2BBEF60", Offset = "0x2BBD560", VA = "0x182BBEF60")]
		public bool IsAvailable(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
		public void Claim(VailActor actor)
		{
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x2BBF180", Offset = "0x2BBD780", VA = "0x182BBF180", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x2BBF250", Offset = "0x2BBD850", VA = "0x182BBF250")]
		public void SetSolidCollision(bool value)
		{
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8F")]
		[Address(RVA = "0x2BBF370", Offset = "0x2BBD970", VA = "0x182BBF370")]
		public void Drop(Vector3 force)
		{
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x2BBF670", Offset = "0x2BBDC70", VA = "0x182BBF670")]
		public void SetDynamic(bool value)
		{
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x2BBF8B0", Offset = "0x2BBDEB0", VA = "0x182BBF8B0")]
		public void HoldByRagdollBody()
		{
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x2BBFAC0", Offset = "0x2BBE0C0", VA = "0x182BBFAC0")]
		public void SetVelocity(Vector3 newVelocity)
		{
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x2BBFBF0", Offset = "0x2BBE1F0", VA = "0x182BBFBF0")]
		public void StartCooldown()
		{
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VailPickup()
		{
		}

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _itemType;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _root;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("optional : controls the point and orientation on pickup attached to grab")]
		private Transform _pickupTransform;

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("optional : can be used to change collider settings, eg. turn collision off/on")]
		private Collider[] _colliders;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _enabledOnDrop;

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RagdollManager _ragdollManager;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Rigidbody _holdByRigidbody;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x60")]
		private VailActor _claimedBy;
	}
}
