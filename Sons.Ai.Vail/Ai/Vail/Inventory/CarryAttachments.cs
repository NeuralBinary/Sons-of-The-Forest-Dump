using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail.Inventory
{
	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	public class CarryAttachments : MonoBehaviour
	{
		// Token: 0x06000F2B RID: 3883 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x2BB6210", Offset = "0x2BB4810", VA = "0x182BB6210")]
		private static ValueDropdownList<string> GetInventoryItemTypes()
		{
			return null;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000CF")]
		public Transform PickupOverrideTransform
		{
			[Token(Token = "0x6000F2C")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x2BB6250", Offset = "0x2BB4850", VA = "0x182BB6250")]
		public bool IsType(string itemType)
		{
			return default(bool);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x2BB62A0", Offset = "0x2BB48A0", VA = "0x182BB62A0")]
		public Transform GetCarryTransform(int index)
		{
			return null;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x2BB6330", Offset = "0x2BB4930", VA = "0x182BB6330")]
		private void SetFromChildren()
		{
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x2BB6630", Offset = "0x2BB4C30", VA = "0x182BB6630")]
		public void StartTween(Transform itemTransform, Transform endTransform, float tweenTime)
		{
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x2BB6880", Offset = "0x2BB4E80", VA = "0x182BB6880")]
		public void UpdateTween(float deltaTime)
		{
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x2BB6D40", Offset = "0x2BB5340", VA = "0x182BB6D40")]
		public CarryAttachments()
		{
		}

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _itemTypes;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _transforms;

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _pickupOverrideTransform;

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x38")]
		private float _tweenT;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x3C")]
		private float _tweenRate;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _startPosition;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x4C")]
		private Quaternion _startRotation;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x60")]
		private Transform _endTransform;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x68")]
		private Transform _itemTransform;
	}
}
