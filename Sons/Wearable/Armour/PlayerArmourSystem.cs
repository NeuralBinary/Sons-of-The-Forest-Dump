using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Sons.Save;
using Sons.Wearable.Clothing;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005D7 RID: 1495
	[Token(Token = "0x20005D7")]
	[AddComponentMenu("Sons/Wearable/Armour/PlayerArmourSystem")]
	public class PlayerArmourSystem : MonoBehaviour, ISaveGameSerializer<PlayerArmourSystem.PlayerArmourSaveData>
	{
		// Token: 0x060026DC RID: 9948 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x33B69B0", Offset = "0x33B4FB0", VA = "0x1833B69B0")]
		private bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x33B6B10", Offset = "0x33B5110", VA = "0x1833B6B10")]
		public void SwitchToThirdPerson()
		{
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x33B6B20", Offset = "0x33B5120", VA = "0x1833B6B20")]
		public void SwitchToFirstPerson()
		{
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x33B6B30", Offset = "0x33B5130", VA = "0x1833B6B30")]
		public bool IsWearingGoldenArmour()
		{
			return default(bool);
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x17000530")]
		public bool IsWearingFullTechArmour
		{
			[Token(Token = "0x60026E0")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x33B6B70", Offset = "0x33B5170", VA = "0x1833B6B70")]
		private PlayerClothingSystem GetPlayerClothingSystem()
		{
			return null;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x33B6D90", Offset = "0x33B5390", VA = "0x1833B6D90")]
		public void Start()
		{
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x33B6E20", Offset = "0x33B5420", VA = "0x1833B6E20")]
		private void OnClothingEquippedEvent(int itemId)
		{
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x33B7010", Offset = "0x33B5610", VA = "0x1833B7010")]
		private void OnValidate()
		{
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x33B7510", Offset = "0x33B5B10", VA = "0x1833B7510")]
		private ArmourPiece GetArmourPieceById(int itemId)
		{
			return null;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0000B958 File Offset: 0x00009B58
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x33B75D0", Offset = "0x33B5BD0", VA = "0x1833B75D0")]
		public bool EquipToNextAvailableSlot(ArmourPiece armourPiece)
		{
			return default(bool);
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x0000B970 File Offset: 0x00009B70
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x33B76B0", Offset = "0x33B5CB0", VA = "0x1833B76B0")]
		public bool EquipToSlot(int itemId, WearableSlots slot)
		{
			return default(bool);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x33B78A0", Offset = "0x33B5EA0", VA = "0x1833B78A0")]
		private bool EquipToSlot(ArmourPiece armourPiece, WearableSlots slot)
		{
			return default(bool);
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x33B8230", Offset = "0x33B6830", VA = "0x1833B8230")]
		public bool TryUnequipSlot(WearableSlots slot, bool destroyArmourPiece = false)
		{
			return default(bool);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x33B8830", Offset = "0x33B6E30", VA = "0x1833B8830")]
		public float CalculateRemainingDamageAfterArmourHit(float initialDamage, bool isDemonic)
		{
			return 0f;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026EB")]
		[Address(RVA = "0x33B8E10", Offset = "0x33B7410", VA = "0x1833B8E10")]
		private PlayerArmourSystem.ArmourSlotData GetTopmostArmourSlotData()
		{
			return null;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x60026EC")]
		[Address(RVA = "0x33B8FF0", Offset = "0x33B75F0", VA = "0x1833B8FF0")]
		public bool IsWearingAnyArmour()
		{
			return default(bool);
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x60026ED")]
		[Address(RVA = "0x33B9180", Offset = "0x33B7780", VA = "0x1833B9180")]
		public bool TryGetArmourSlotData(WearableSlots slot, out PlayerArmourSystem.ArmourSlotData armourSlotData)
		{
			return default(bool);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026EE")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public List<WearableSlots> GetSlotOrder()
		{
			return null;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026EF")]
		[Address(RVA = "0x33B9250", Offset = "0x33B7850", VA = "0x1833B9250")]
		public PlayerArmourSystem.ArmourSlotData GetArmourSlotData(WearableSlots slot)
		{
			return null;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F0")]
		[Address(RVA = "0x33B92C0", Offset = "0x33B78C0", VA = "0x1833B92C0")]
		public void RemapSkinnedMeshes(Transform animationRoot, Transform armourInstance)
		{
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F1")]
		[Address(RVA = "0x33B96B0", Offset = "0x33B7CB0", VA = "0x1833B96B0")]
		private void SetShadowCastingMode(ShadowCastingMode mode)
		{
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x33B9900", Offset = "0x33B7F00", VA = "0x1833B9900")]
		public void CheckForTechArmour()
		{
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x33B9D60", Offset = "0x33B8360", VA = "0x1833B9D60")]
		public void RefreshBlendShapes()
		{
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x33BA2A0", Offset = "0x33B88A0", VA = "0x1833BA2A0")]
		public void HideArms(bool value)
		{
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F5")]
		[Address(RVA = "0x33BA580", Offset = "0x33B8B80", VA = "0x1833BA580")]
		private void Awake()
		{
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F6")]
		[Address(RVA = "0x33BA5F0", Offset = "0x33B8BF0", VA = "0x1833BA5F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000531")]
		public string SerializedName
		{
			[Token(Token = "0x60026F7")]
			[Address(RVA = "0x33BA660", Offset = "0x33B8C60", VA = "0x1833BA660", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x17000532")]
		private bool UniqueFile
		{
			[Token(Token = "0x60026F8")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x17000533")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x60026F9")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x0000BA30 File Offset: 0x00009C30
		[Token(Token = "0x17000534")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x60026FA")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026FB")]
		[Address(RVA = "0x33BA690", Offset = "0x33B8C90", VA = "0x1833BA690", Slot = "5")]
		private PlayerArmourSystem.PlayerArmourSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FC")]
		[Address(RVA = "0x33BAAA0", Offset = "0x33B90A0", VA = "0x1833BAAA0", Slot = "6")]
		private void OnDeserialize(PlayerArmourSystem.PlayerArmourSaveData data)
		{
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FD")]
		[Address(RVA = "0x33BAC50", Offset = "0x33B9250", VA = "0x1833BAC50")]
		public PlayerArmourSystem()
		{
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FE")]
		[Address(RVA = "0x33BAD40", Offset = "0x33B9340", VA = "0x1833BAD40")]
		[CompilerGenerated]
		internal static void <HideArms>g__SetRenderMode|37_0(GameObject armourObject, ShadowCastingMode mode)
		{
		}

		// Token: 0x0400230D RID: 8973
		[Token(Token = "0x400230D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<WearableSlots> _armourSlotOrder;

		// Token: 0x0400230E RID: 8974
		[Token(Token = "0x400230E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _nextAvailableArmourSlotIndex;

		// Token: 0x0400230F RID: 8975
		[Token(Token = "0x400230F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<PlayerArmourSystem.ArmourSlotData> _armourSlotData;

		// Token: 0x04002310 RID: 8976
		[Token(Token = "0x4002310")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _animationRoot;

		// Token: 0x04002311 RID: 8977
		[Token(Token = "0x4002311")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<ArmourPiece> _armourPieces;

		// Token: 0x04002312 RID: 8978
		[Token(Token = "0x4002312")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _goldenArmourDemonicDamageMultiplier;

		// Token: 0x04002313 RID: 8979
		[Token(Token = "0x4002313")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _goldenArmourGeneralDamageMultiplier;

		// Token: 0x04002314 RID: 8980
		[Token(Token = "0x4002314")]
		[FieldOffset(Offset = "0x50")]
		public Action<ArmourPiece, WearableSlots> OnArmourEquipped;

		// Token: 0x04002315 RID: 8981
		[Token(Token = "0x4002315")]
		[FieldOffset(Offset = "0x58")]
		public Action<ArmourPiece, WearableSlots> OnArmourUnequipped;

		// Token: 0x04002316 RID: 8982
		[Token(Token = "0x4002316")]
		[FieldOffset(Offset = "0x60")]
		public Action<ArmourPiece, WearableSlots> OnArmourBroken;

		// Token: 0x04002317 RID: 8983
		[Token(Token = "0x4002317")]
		[FieldOffset(Offset = "0x68")]
		private bool _techArmourComplete;

		// Token: 0x04002318 RID: 8984
		[Token(Token = "0x4002318")]
		[FieldOffset(Offset = "0x70")]
		private PlayerClothingSystem _clothingSystem;

		// Token: 0x04002319 RID: 8985
		[Token(Token = "0x4002319")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _shouldSerialize;

		// Token: 0x020005D8 RID: 1496
		[Token(Token = "0x20005D8")]
		[Serializable]
		public class ArmourSlotData
		{
			// Token: 0x060026FF RID: 9983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026FF")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ArmourSlotData()
			{
			}

			// Token: 0x0400231A RID: 8986
			[Token(Token = "0x400231A")]
			[FieldOffset(Offset = "0x10")]
			public WearableSlots Slot;

			// Token: 0x0400231B RID: 8987
			[Token(Token = "0x400231B")]
			[FieldOffset(Offset = "0x18")]
			public Transform ArmourInstance;

			// Token: 0x0400231C RID: 8988
			[Token(Token = "0x400231C")]
			[FieldOffset(Offset = "0x20")]
			public ArmourPiece ArmourPiece;

			// Token: 0x0400231D RID: 8989
			[Token(Token = "0x400231D")]
			[FieldOffset(Offset = "0x28")]
			public float RemainingArmourpoints;
		}

		// Token: 0x020005D9 RID: 1497
		[Token(Token = "0x20005D9")]
		[Serializable]
		internal class PlayerArmourSaveData
		{
			// Token: 0x06002700 RID: 9984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002700")]
			[Address(RVA = "0x33BAEA0", Offset = "0x33B94A0", VA = "0x1833BAEA0")]
			public PlayerArmourSaveData()
			{
			}

			// Token: 0x0400231E RID: 8990
			[Token(Token = "0x400231E")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x0400231F RID: 8991
			[Token(Token = "0x400231F")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerArmourSystem.PlayerArmourSaveData.ArmourPiece> ArmourPieces;

			// Token: 0x020005DA RID: 1498
			[Token(Token = "0x20005DA")]
			[Serializable]
			public class ArmourPiece
			{
				// Token: 0x06002701 RID: 9985 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002701")]
				[Address(RVA = "0x33BAFD0", Offset = "0x33B95D0", VA = "0x1833BAFD0")]
				[OnSerializing]
				private void OnSerializing(StreamingContext context)
				{
				}

				// Token: 0x06002702 RID: 9986 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002702")]
				[Address(RVA = "0x33BB020", Offset = "0x33B9620", VA = "0x1833BB020")]
				[OnDeserialized]
				private void OnDeserialized(StreamingContext context)
				{
				}

				// Token: 0x06002703 RID: 9987 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002703")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public ArmourPiece()
				{
				}

				// Token: 0x04002320 RID: 8992
				[Token(Token = "0x4002320")]
				[FieldOffset(Offset = "0x10")]
				public int ItemId;

				// Token: 0x04002321 RID: 8993
				[Token(Token = "0x4002321")]
				[FieldOffset(Offset = "0x14")]
				public WearableSlots Slot;

				// Token: 0x04002322 RID: 8994
				[Token(Token = "0x4002322")]
				[FieldOffset(Offset = "0x18")]
				public float RemainingArmourpoints;
			}
		}
	}
}
