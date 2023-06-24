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
	// Token: 0x020005C5 RID: 1477
	[Token(Token = "0x20005C5")]
	[AddComponentMenu("Sons/Wearable/Clothing/PlayerClothingSystem")]
	public class PlayerClothingSystem : MonoBehaviour, ISaveGameSerializer<PlayerClothingSystem.PlayerClothingSaveData>
	{
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06002689 RID: 9865 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600268A RID: 9866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001A")]
		public event Action<int> OnClothingEquipped
		{
			[Token(Token = "0x6002689")]
			[Address(RVA = "0x33ADE50", Offset = "0x33AC450", VA = "0x1833ADE50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600268A")]
			[Address(RVA = "0x33ADFC0", Offset = "0x33AC5C0", VA = "0x1833ADFC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600268B RID: 9867 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600268C RID: 9868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001B")]
		public event Action<int> OnClothingUnequipped
		{
			[Token(Token = "0x600268B")]
			[Address(RVA = "0x33AE130", Offset = "0x33AC730", VA = "0x1833AE130")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600268C")]
			[Address(RVA = "0x33AE2A0", Offset = "0x33AC8A0", VA = "0x1833AE2A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x33AE410", Offset = "0x33ACA10", VA = "0x1833AE410")]
		private bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x33AE560", Offset = "0x33ACB60", VA = "0x1833AE560")]
		public void OnEnable()
		{
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x33AE570", Offset = "0x33ACB70", VA = "0x1833AE570")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x33AE850", Offset = "0x33ACE50", VA = "0x1833AE850")]
		public bool IsWearingItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x33AEA70", Offset = "0x33AD070", VA = "0x1833AEA70")]
		public List<int> GetCurrentClothingIds()
		{
			return null;
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x33AECF0", Offset = "0x33AD2F0", VA = "0x1833AECF0")]
		private ClothingPiece GetClothingPiece(int clothingId)
		{
			return null;
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x33AEDD0", Offset = "0x33AD3D0", VA = "0x1833AEDD0")]
		public void WearClothesPreviousToGoldArmour()
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x0000B6E8 File Offset: 0x000098E8
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x33AEFA0", Offset = "0x33AD5A0", VA = "0x1833AEFA0")]
		public bool TryWearClothingPiece(int clothingId, bool shouldReplaceCurrentlyWorn)
		{
			return default(bool);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x33AFA30", Offset = "0x33AE030", VA = "0x1833AFA30")]
		public bool TryRemoveClothingPiece(int clothingId)
		{
			return default(bool);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002696")]
		[Address(RVA = "0x33AFE00", Offset = "0x33AE400", VA = "0x1833AFE00")]
		public void WearClothingList(IEnumerable<int> clothingIdList)
		{
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002697")]
		[Address(RVA = "0x33AFFC0", Offset = "0x33AE5C0", VA = "0x1833AFFC0")]
		private void LoadRenderable(PlayerClothingSystem.ClothingHookupData hookupData)
		{
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002698")]
		[Address(RVA = "0x33B0330", Offset = "0x33AE930", VA = "0x1833B0330")]
		private void OnLoadDone(AsyncOperationHandle<GameObject> handle)
		{
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002699")]
		[Address(RVA = "0x33B0400", Offset = "0x33AEA00", VA = "0x1833B0400")]
		private void LoadClothing(Transform objectTransform)
		{
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x33B1200", Offset = "0x33AF800", VA = "0x1833B1200")]
		public void WearDefaultClothingIfNeeded()
		{
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x33B1570", Offset = "0x33AFB70", VA = "0x1833B1570")]
		private void RetargetBonesToPlayer(Transform clothing)
		{
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x33B1970", Offset = "0x33AFF70", VA = "0x1833B1970")]
		private void SetShadowCastingMode(PlayerClothingSystem.ClothingHookupData clothingHookupData, ShadowCastingMode mode)
		{
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x33B1CA0", Offset = "0x33B02A0", VA = "0x1833B1CA0")]
		public void HideArms(bool onOff)
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x33B2070", Offset = "0x33B0670", VA = "0x1833B2070")]
		public void ApplyBlendShapeWeight(int clothingId, int weight, int blendShapeIndex, int subMeshIndex)
		{
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269F")]
		[Address(RVA = "0x33B2500", Offset = "0x33B0B00", VA = "0x1833B2500")]
		private void Awake()
		{
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x33B2570", Offset = "0x33B0B70", VA = "0x1833B2570")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000521")]
		public string SerializedName
		{
			[Token(Token = "0x60026A1")]
			[Address(RVA = "0x33B25E0", Offset = "0x33B0BE0", VA = "0x1833B25E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x17000522")]
		private bool UniqueFile
		{
			[Token(Token = "0x60026A2")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x17000523")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x60026A3")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x17000524")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x60026A4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x33B2610", Offset = "0x33B0C10", VA = "0x1833B2610", Slot = "5")]
		private PlayerClothingSystem.PlayerClothingSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x33B29F0", Offset = "0x33B0FF0", VA = "0x1833B29F0", Slot = "6")]
		private void OnDeserialize(PlayerClothingSystem.PlayerClothingSaveData data)
		{
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x33B2C60", Offset = "0x33B1260", VA = "0x1833B2C60")]
		public PlayerClothingSystem()
		{
		}

		// Token: 0x040022CC RID: 8908
		[Token(Token = "0x40022CC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ClothingSlotCount;

		// Token: 0x040022CD RID: 8909
		[Token(Token = "0x40022CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _animationRoot;

		// Token: 0x040022CE RID: 8910
		[Token(Token = "0x40022CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isRobbyPlayer;

		// Token: 0x040022CF RID: 8911
		[Token(Token = "0x40022CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<PlayerClothingSystem.ClothingHookupData> _clothingHookupData;

		// Token: 0x040022D0 RID: 8912
		[Token(Token = "0x40022D0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ClothingPiece> _defaultClothing;

		// Token: 0x040022D1 RID: 8913
		[Token(Token = "0x40022D1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<ClothingPiece> _allClothing;

		// Token: 0x040022D2 RID: 8914
		[Token(Token = "0x40022D2")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<int> _itemIdsToAddBackToInventory;

		// Token: 0x040022D3 RID: 8915
		[Token(Token = "0x40022D3")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<int> _cachedClothingPriorToGoldenArmour;

		// Token: 0x040022D4 RID: 8916
		[Token(Token = "0x40022D4")]
		[FieldOffset(Offset = "0x58")]
		private List<int> _clothingIdsCurrentlyLoading;

		// Token: 0x040022D5 RID: 8917
		[Token(Token = "0x40022D5")]
		[FieldOffset(Offset = "0x60")]
		private List<PlayerClothingSystem.DelayedBlendShapeDataToApply> _delayedBlendShapeDataToApply;

		// Token: 0x040022D8 RID: 8920
		[Token(Token = "0x40022D8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _shouldSerialize;

		// Token: 0x020005C6 RID: 1478
		[Token(Token = "0x20005C6")]
		private class DelayedBlendShapeDataToApply
		{
			// Token: 0x060026A9 RID: 9897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026A9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public DelayedBlendShapeDataToApply()
			{
			}

			// Token: 0x040022D9 RID: 8921
			[Token(Token = "0x40022D9")]
			[FieldOffset(Offset = "0x10")]
			public int ClothingId;

			// Token: 0x040022DA RID: 8922
			[Token(Token = "0x40022DA")]
			[FieldOffset(Offset = "0x14")]
			public int Weight;

			// Token: 0x040022DB RID: 8923
			[Token(Token = "0x40022DB")]
			[FieldOffset(Offset = "0x18")]
			public int BlendShapeIndex;

			// Token: 0x040022DC RID: 8924
			[Token(Token = "0x40022DC")]
			[FieldOffset(Offset = "0x1C")]
			public int SubMeshIndex;
		}

		// Token: 0x020005C7 RID: 1479
		[Token(Token = "0x20005C7")]
		[Serializable]
		private class ClothingHookupData
		{
			// Token: 0x060026AA RID: 9898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026AA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ClothingHookupData()
			{
			}

			// Token: 0x040022DD RID: 8925
			[Token(Token = "0x40022DD")]
			[FieldOffset(Offset = "0x10")]
			public ClothingPiece.ClothingSlot Slot;

			// Token: 0x040022DE RID: 8926
			[Token(Token = "0x40022DE")]
			[FieldOffset(Offset = "0x18")]
			public ClothingPiece ClothingPiece;

			// Token: 0x040022DF RID: 8927
			[Token(Token = "0x40022DF")]
			[FieldOffset(Offset = "0x20")]
			public Transform Instance;
		}

		// Token: 0x020005C8 RID: 1480
		[Token(Token = "0x20005C8")]
		[Serializable]
		internal class PlayerClothingSaveData
		{
			// Token: 0x060026AB RID: 9899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026AB")]
			[Address(RVA = "0x33B3200", Offset = "0x33B1800", VA = "0x1833B3200")]
			public PlayerClothingSaveData()
			{
			}

			// Token: 0x040022E0 RID: 8928
			[Token(Token = "0x40022E0")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x040022E1 RID: 8929
			[Token(Token = "0x40022E1")]
			[FieldOffset(Offset = "0x18")]
			public List<int> Clothing;
		}
	}
}
