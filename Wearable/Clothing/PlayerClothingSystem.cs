using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Save;
using Sons.Wearable.Armour.Clothing;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Sons.Wearable.Clothing
{
	// Token: 0x020005B5 RID: 1461
	[Token(Token = "0x20005B5")]
	[AddComponentMenu("Sons/Wearable/Clothing/PlayerClothingSystem")]
	public class PlayerClothingSystem : MonoBehaviour, ISaveGameSerializer<PlayerClothingSystem.PlayerClothingSaveData>
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600258A RID: 9610 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600258B RID: 9611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000017")]
		public event Action<int> OnClothingEquipped
		{
			[Token(Token = "0x600258A")]
			[Address(RVA = "0x2D8A610", Offset = "0x2D89610", VA = "0x182D8A610")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600258B")]
			[Address(RVA = "0x2D8A7A0", Offset = "0x2D897A0", VA = "0x182D8A7A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600258C RID: 9612 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600258D RID: 9613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000018")]
		public event Action<int> OnClothingUnequipped
		{
			[Token(Token = "0x600258C")]
			[Address(RVA = "0x2D8A6C0", Offset = "0x2D896C0", VA = "0x182D8A6C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600258D")]
			[Address(RVA = "0x2D8A850", Offset = "0x2D89850", VA = "0x182D8A850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x0000AFF8 File Offset: 0x000091F8
		[Token(Token = "0x600258E")]
		[Address(RVA = "0x2D87E20", Offset = "0x2D86E20", VA = "0x182D87E20")]
		private bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258F")]
		[Address(RVA = "0x2D88AE0", Offset = "0x2D87AE0", VA = "0x182D88AE0")]
		public void OnEnable()
		{
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002590")]
		[Address(RVA = "0x2D88030", Offset = "0x2D87030", VA = "0x182D88030")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x0000B010 File Offset: 0x00009210
		[Token(Token = "0x6002591")]
		[Address(RVA = "0x2D87EB0", Offset = "0x2D86EB0", VA = "0x182D87EB0")]
		public bool IsWearingItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002592")]
		[Address(RVA = "0x2D87C50", Offset = "0x2D86C50", VA = "0x182D87C50")]
		public List<int> GetCurrentClothingIds()
		{
			return null;
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002593")]
		[Address(RVA = "0x2D87B70", Offset = "0x2D86B70", VA = "0x182D87B70")]
		private ClothingPiece GetClothingPiece(int clothingId)
		{
			return null;
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002594")]
		[Address(RVA = "0x2D89F90", Offset = "0x2D88F90", VA = "0x182D89F90")]
		public void WearClothesPreviousToGoldArmour()
		{
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x6002595")]
		[Address(RVA = "0x2D895E0", Offset = "0x2D885E0", VA = "0x182D895E0")]
		public bool TryWearClothingPiece(int clothingId, bool shouldReplaceCurrentlyWorn)
		{
			return default(bool);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x0000B040 File Offset: 0x00009240
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x2D89330", Offset = "0x2D88330", VA = "0x182D89330")]
		public bool TryRemoveClothingPiece(int clothingId)
		{
			return default(bool);
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x2D888F0", Offset = "0x2D878F0", VA = "0x182D888F0")]
		private void LoadRenderable(PlayerClothingSystem.ClothingHookupData hookupData)
		{
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x2D88AF0", Offset = "0x2D87AF0", VA = "0x182D88AF0")]
		private void OnLoadDone(AsyncOperationHandle<GameObject> handle)
		{
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x2D88230", Offset = "0x2D87230", VA = "0x182D88230")]
		private void LoadClothing(Transform objectTransform)
		{
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259A")]
		[Address(RVA = "0x2D8A0B0", Offset = "0x2D890B0", VA = "0x182D8A0B0")]
		public void WearDefaultClothingIfNeeded()
		{
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259B")]
		[Address(RVA = "0x2D88B80", Offset = "0x2D87B80", VA = "0x182D88B80")]
		private void RetargetBonesToPlayer(Transform clothing)
		{
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259C")]
		[Address(RVA = "0x2D88DD0", Offset = "0x2D87DD0", VA = "0x182D88DD0")]
		private void SetShadowCastingMode(PlayerClothingSystem.ClothingHookupData clothingHookupData, ShadowCastingMode mode)
		{
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259D")]
		[Address(RVA = "0x2D878A0", Offset = "0x2D868A0", VA = "0x182D878A0")]
		public void ApplyBlendShapeWeight(int clothingId, int weight, int blendShapeIndex, int subMeshIndex)
		{
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259E")]
		[Address(RVA = "0x2D87B00", Offset = "0x2D86B00", VA = "0x182D87B00")]
		private void Awake()
		{
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x2D88A70", Offset = "0x2D87A70", VA = "0x182D88A70")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050D")]
		public string SerializedName
		{
			[Token(Token = "0x60025A0")]
			[Address(RVA = "0x2D8A770", Offset = "0x2D89770", VA = "0x182D8A770", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x0000B058 File Offset: 0x00009258
		[Token(Token = "0x1700050E")]
		private bool UniqueFile
		{
			[Token(Token = "0x60025A1")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x0000B070 File Offset: 0x00009270
		[Token(Token = "0x1700050F")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x60025A2")]
			[Address(RVA = "0x1E52250", Offset = "0x1E51250", VA = "0x181E52250", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x17000510")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x60025A3")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x2D89120", Offset = "0x2D88120", VA = "0x182D89120", Slot = "5")]
		private PlayerClothingSystem.PlayerClothingSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x2D88FB0", Offset = "0x2D87FB0", VA = "0x182D88FB0", Slot = "6")]
		private void OnDeserialize(PlayerClothingSystem.PlayerClothingSaveData data)
		{
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x2D8A440", Offset = "0x2D89440", VA = "0x182D8A440")]
		public PlayerClothingSystem()
		{
		}

		// Token: 0x040021F7 RID: 8695
		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ClothingSlotCount;

		// Token: 0x040021F8 RID: 8696
		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _animationRoot;

		// Token: 0x040021F9 RID: 8697
		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<PlayerClothingSystem.ClothingHookupData> _clothingHookupData;

		// Token: 0x040021FA RID: 8698
		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ClothingPiece> _defaultClothing;

		// Token: 0x040021FB RID: 8699
		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ClothingPiece> _allClothing;

		// Token: 0x040021FC RID: 8700
		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<int> _itemIdsToAddBackToInventory;

		// Token: 0x040021FD RID: 8701
		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<int> _cachedClothingPriorToGoldenArmour;

		// Token: 0x040021FE RID: 8702
		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x50")]
		private List<int> _clothingIdsCurrentlyLoading;

		// Token: 0x04002201 RID: 8705
		[Token(Token = "0x4002201")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _shouldSerialize;

		// Token: 0x020005B6 RID: 1462
		[Token(Token = "0x20005B6")]
		[Serializable]
		private class ClothingHookupData
		{
			// Token: 0x060025A8 RID: 9640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025A8")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ClothingHookupData()
			{
			}

			// Token: 0x04002202 RID: 8706
			[Token(Token = "0x4002202")]
			[FieldOffset(Offset = "0x10")]
			public ClothingPiece.ClothingSlot Slot;

			// Token: 0x04002203 RID: 8707
			[Token(Token = "0x4002203")]
			[FieldOffset(Offset = "0x18")]
			public ClothingPiece ClothingPiece;

			// Token: 0x04002204 RID: 8708
			[Token(Token = "0x4002204")]
			[FieldOffset(Offset = "0x20")]
			public Transform Instance;
		}

		// Token: 0x020005B7 RID: 1463
		[Token(Token = "0x20005B7")]
		[Serializable]
		internal class PlayerClothingSaveData
		{
			// Token: 0x060025A9 RID: 9641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025A9")]
			[Address(RVA = "0x2DAAD70", Offset = "0x2DA9D70", VA = "0x182DAAD70")]
			public PlayerClothingSaveData()
			{
			}

			// Token: 0x04002205 RID: 8709
			[Token(Token = "0x4002205")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04002206 RID: 8710
			[Token(Token = "0x4002206")]
			[FieldOffset(Offset = "0x18")]
			public List<int> Clothing;
		}
	}
}
