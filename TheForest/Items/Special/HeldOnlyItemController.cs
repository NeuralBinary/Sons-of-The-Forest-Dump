using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bolt;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Inventory;
using Sons.Items.Core;
using Sons.Save;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Items.Special
{
	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	public class HeldOnlyItemController : EntityBehaviour<IPlayerState>, IHeldOnlyItemController, IKnockDownReceiver, IEnterSwimmingReceiver, ISaveGameSerializer<HeldOnlyItemController.HeldOnlyItemSaveData>
	{
		// Token: 0x06001DF7 RID: 7671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF7")]
		[Address(RVA = "0x2D0C730", Offset = "0x2D0B730", VA = "0x182D0C730")]
		private void Awake()
		{
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF8")]
		[Address(RVA = "0x2D0D2B0", Offset = "0x2D0C2B0", VA = "0x182D0D2B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0x2D0E920", Offset = "0x2D0D920", VA = "0x182D0E920")]
		private void Start()
		{
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFA")]
		[Address(RVA = "0x2D0EA90", Offset = "0x2D0DA90", VA = "0x182D0EA90")]
		private void Update()
		{
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0x2D0D310", Offset = "0x2D0C310", VA = "0x182D0D310")]
		private void OnDisable()
		{
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00008688 File Offset: 0x00006888
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x2D0C820", Offset = "0x2D0B820", VA = "0x182D0C820", Slot = "29")]
		public bool Controlling(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x000086A0 File Offset: 0x000068A0
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x2D0CC30", Offset = "0x2D0BC30", VA = "0x182D0CC30", Slot = "30")]
		public bool Has(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x000086B8 File Offset: 0x000068B8
		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x2D0CD70", Offset = "0x2D0BD70", VA = "0x182D0CD70", Slot = "31")]
		public bool Lift(int itemId, ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x2D0CBD0", Offset = "0x2D0BBD0", VA = "0x182D0CBD0")]
		private HeldOnlyItemController.ControllerItemData GetHeldItem()
		{
			return null;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x2D0CA40", Offset = "0x2D0BA40", VA = "0x182D0CA40")]
		private HeldOnlyItemController.ControllerItemData GetControlledItem(int itemId)
		{
			return null;
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x2D0D4A0", Offset = "0x2D0C4A0", VA = "0x182D0D4A0")]
		public void RemoveHeldItem(bool equipPrevious, bool drop = true)
		{
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x2D0C880", Offset = "0x2D0B880", VA = "0x182D0C880")]
		private IEnumerator DelaySetActive(GameObject target, bool activeValue, float delay, bool disableSelf)
		{
			return null;
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x2D0C910", Offset = "0x2D0B910", VA = "0x182D0C910", Slot = "33")]
		public void DropAll()
		{
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x2D0D320", Offset = "0x2D0C320", VA = "0x182D0D320", Slot = "32")]
		public bool PutDown(bool fake = false, bool drop = false, bool equipPrevious = true, [Optional] GameObject preSpawned, int itemId = -1, float delay = -1f)
		{
			return default(bool);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x2D0DBC0", Offset = "0x2D0CBC0", VA = "0x182D0DBC0")]
		private IEnumerator SpawnDropItemDelayed(GameObject preSpawned, float delay, int itemId)
		{
			return null;
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x2D0DC70", Offset = "0x2D0CC70", VA = "0x182D0DC70")]
		private void SpawnHeldItemDrop(GameObject preSpawned, int itemId)
		{
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x2D0E960", Offset = "0x2D0D960", VA = "0x182D0E960")]
		private void UpdateBoltEntity()
		{
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x2D0CB40", Offset = "0x2D0BB40", VA = "0x182D0CB40")]
		private GameObject GetCurrentHeldGo()
		{
			return null;
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x2D0CAA0", Offset = "0x2D0BAA0", VA = "0x182D0CAA0")]
		private GameObject GetCurrentHeldGo(int itemId)
		{
			return null;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000417")]
		public ItemInstance HeldItem
		{
			[Token(Token = "0x6001E0A")]
			[Address(RVA = "0x5E9610", Offset = "0x5E8610", VA = "0x1805E9610", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x17000418")]
		public int Amount
		{
			[Token(Token = "0x6001E0B")]
			[Address(RVA = "0x6B70D0", Offset = "0x6B60D0", VA = "0x1806B70D0", Slot = "25")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x17000419")]
		public bool HasItem
		{
			[Token(Token = "0x6001E0C")]
			[Address(RVA = "0x2D0ECF0", Offset = "0x2D0DCF0", VA = "0x182D0ECF0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x00008718 File Offset: 0x00006918
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041A")]
		public bool InfiniteHack
		{
			[Token(Token = "0x6001E0D")]
			[Address(RVA = "0x8C5EB0", Offset = "0x8C4EB0", VA = "0x1808C5EB0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E0E")]
			[Address(RVA = "0x2B885F0", Offset = "0x2B875F0", VA = "0x182B885F0", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x2D0CC40", Offset = "0x2D0BC40", VA = "0x182D0CC40", Slot = "34")]
		private void OnKnockDownStarted()
		{
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x2D0CC40", Offset = "0x2D0BC40", VA = "0x182D0CC40", Slot = "35")]
		private void OnEnterSwimming()
		{
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041B")]
		private string SerializedName
		{
			[Token(Token = "0x6001E11")]
			[Address(RVA = "0x2D0DB90", Offset = "0x2D0CB90", VA = "0x182D0DB90", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x1700041C")]
		private bool UniqueFile
		{
			[Token(Token = "0x6001E12")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x1700041D")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6001E13")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x1700041E")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6001E14")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x2D0DAF0", Offset = "0x2D0CAF0", VA = "0x182D0DAF0", Slot = "37")]
		private HeldOnlyItemController.HeldOnlyItemSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x2D0D880", Offset = "0x2D0C880", VA = "0x182D0D880", Slot = "38")]
		private void OnDeserialize(HeldOnlyItemController.HeldOnlyItemSaveData data)
		{
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x2D0EC50", Offset = "0x2D0DC50", VA = "0x182D0EC50")]
		public HeldOnlyItemController()
		{
		}

		// Token: 0x04001C3A RID: 7226
		[Token(Token = "0x4001C3A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HeldOnlyItemController.ControllerItemData[] _heldOnlyItems;

		// Token: 0x04001C3B RID: 7227
		[Token(Token = "0x4001C3B")]
		[FieldOffset(Offset = "0x30")]
		[ItemIdPicker]
		public int _lighterItemId;

		// Token: 0x04001C3C RID: 7228
		[Token(Token = "0x4001C3C")]
		[FieldOffset(Offset = "0x38")]
		public PlayerInventory _player;

		// Token: 0x04001C3D RID: 7229
		[Token(Token = "0x4001C3D")]
		[FieldOffset(Offset = "0x40")]
		public LayerMask _layerMask;

		// Token: 0x04001C3E RID: 7230
		[Token(Token = "0x4001C3E")]
		[FieldOffset(Offset = "0x48")]
		public string _pickupAudioEvent;

		// Token: 0x04001C3F RID: 7231
		[Token(Token = "0x4001C3F")]
		[FieldOffset(Offset = "0x50")]
		private ItemInstance _heldItemInstance;

		// Token: 0x04001C40 RID: 7232
		[Token(Token = "0x4001C40")]
		[FieldOffset(Offset = "0x58")]
		private int _heldItemId;

		// Token: 0x04001C41 RID: 7233
		[Token(Token = "0x4001C41")]
		[FieldOffset(Offset = "0x5C")]
		private int _heldCount;

		// Token: 0x04001C42 RID: 7234
		[Token(Token = "0x4001C42")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector3 _dropSpawnOffset;

		// Token: 0x04001C43 RID: 7235
		[Token(Token = "0x4001C43")]
		[FieldOffset(Offset = "0x6C")]
		[FormerlySerializedAs("_dropSpawnRotationOffset")]
		[SerializeField]
		private Vector3 _dropSpawnRotationOffsetMin;

		// Token: 0x04001C44 RID: 7236
		[Token(Token = "0x4001C44")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector3 _dropSpawnRotationOffsetMax;

		// Token: 0x04001C45 RID: 7237
		[Token(Token = "0x4001C45")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _logDropForce;

		// Token: 0x04001C46 RID: 7238
		[Token(Token = "0x4001C46")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _logDropUpForce;

		// Token: 0x04001C47 RID: 7239
		[Token(Token = "0x4001C47")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Vector3 _logDropTorqueMin;

		// Token: 0x04001C48 RID: 7240
		[Token(Token = "0x4001C48")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector3 _logDropTorqueMax;

		// Token: 0x04001C49 RID: 7241
		[Token(Token = "0x4001C49")]
		[FieldOffset(Offset = "0xA8")]
		public Action ItemRemovedEvent;

		// Token: 0x04001C4A RID: 7242
		[Token(Token = "0x4001C4A")]
		[FieldOffset(Offset = "0xB0")]
		public Action ItemAddedEvent;

		// Token: 0x04001C4B RID: 7243
		[Token(Token = "0x4001C4B")]
		[FieldOffset(Offset = "0xB8")]
		private readonly TimedFailSafeCancellationToken _timedFailSafeCancellationToken;

		// Token: 0x020004A1 RID: 1185
		[Token(Token = "0x20004A1")]
		[Serializable]
		public class ControllerItemData
		{
			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700041F")]
			public GameObject[] Held
			{
				[Token(Token = "0x6001E18")]
				[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06001E19 RID: 7705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000420")]
			public ItemData ItemCache
			{
				[Token(Token = "0x6001E19")]
				[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00008778 File Offset: 0x00006978
			[Token(Token = "0x17000421")]
			public float ItemLength
			{
				[Token(Token = "0x6001E1A")]
				[Address(RVA = "0x567960", Offset = "0x566960", VA = "0x180567960")]
				get
				{
					return default(float);
				}
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00008790 File Offset: 0x00006990
			[Token(Token = "0x17000422")]
			public float ItemMaxLength
			{
				[Token(Token = "0x6001E1B")]
				[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910")]
				get
				{
					return default(float);
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06001E1C RID: 7708 RVA: 0x000087A8 File Offset: 0x000069A8
			[Token(Token = "0x17000423")]
			public float ItemThickness
			{
				[Token(Token = "0x6001E1C")]
				[Address(RVA = "0x5A46D0", Offset = "0x5A36D0", VA = "0x1805A46D0")]
				get
				{
					return default(float);
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06001E1D RID: 7709 RVA: 0x000087C0 File Offset: 0x000069C0
			[Token(Token = "0x17000424")]
			public float DropSpawnDelay
			{
				[Token(Token = "0x6001E1D")]
				[Address(RVA = "0x5A46C0", Offset = "0x5A36C0", VA = "0x1805A46C0")]
				get
				{
					return default(float);
				}
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000087D8 File Offset: 0x000069D8
			[Token(Token = "0x17000425")]
			public bool UseDropOffset
			{
				[Token(Token = "0x6001E1E")]
				[Address(RVA = "0x5A15F0", Offset = "0x5A05F0", VA = "0x1805A15F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000087F0 File Offset: 0x000069F0
			[Token(Token = "0x17000426")]
			public Vector3 DropPositionOffset
			{
				[Token(Token = "0x6001E1F")]
				[Address(RVA = "0x6C5520", Offset = "0x6C4520", VA = "0x1806C5520")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06001E20 RID: 7712 RVA: 0x00008808 File Offset: 0x00006A08
			[Token(Token = "0x17000427")]
			public Quaternion DropRotationOffset
			{
				[Token(Token = "0x6001E20")]
				[Address(RVA = "0x12E73D0", Offset = "0x12E63D0", VA = "0x1812E73D0")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x06001E21 RID: 7713 RVA: 0x00008820 File Offset: 0x00006A20
			[Token(Token = "0x6001E21")]
			[Address(RVA = "0x2D0C5C0", Offset = "0x2D0B5C0", VA = "0x182D0C5C0")]
			public int GetActiveRenderersCount()
			{
				return default(int);
			}

			// Token: 0x06001E22 RID: 7714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E22")]
			[Address(RVA = "0x2D0C6D0", Offset = "0x2D0B6D0", VA = "0x182D0C6D0")]
			public ControllerItemData()
			{
			}

			// Token: 0x04001C4D RID: 7245
			[Token(Token = "0x4001C4D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject[] _held;

			// Token: 0x04001C4E RID: 7246
			[Token(Token = "0x4001C4E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private ItemData _itemCache;

			// Token: 0x04001C4F RID: 7247
			[Token(Token = "0x4001C4F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _itemLength;

			// Token: 0x04001C50 RID: 7248
			[Token(Token = "0x4001C50")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private float _itemMaxLength;

			// Token: 0x04001C51 RID: 7249
			[Token(Token = "0x4001C51")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private float _itemThickness;

			// Token: 0x04001C52 RID: 7250
			[Token(Token = "0x4001C52")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private float _dropSpawnDelay;

			// Token: 0x04001C53 RID: 7251
			[Token(Token = "0x4001C53")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private bool _useDropOffset;

			// Token: 0x04001C54 RID: 7252
			[Token(Token = "0x4001C54")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private Vector3 _dropPositionOffset;

			// Token: 0x04001C55 RID: 7253
			[Token(Token = "0x4001C55")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Quaternion _dropRotationOffset;
		}

		// Token: 0x020004A2 RID: 1186
		[Token(Token = "0x20004A2")]
		[Serializable]
		public class HeldOnlyItemSaveData
		{
			// Token: 0x06001E23 RID: 7715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E23")]
			[Address(RVA = "0x2D0ED00", Offset = "0x2D0DD00", VA = "0x182D0ED00")]
			public HeldOnlyItemSaveData()
			{
			}

			// Token: 0x04001C56 RID: 7254
			[Token(Token = "0x4001C56")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public string Version;

			// Token: 0x04001C57 RID: 7255
			[Token(Token = "0x4001C57")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public int ItemId;

			// Token: 0x04001C58 RID: 7256
			[Token(Token = "0x4001C58")]
			[FieldOffset(Offset = "0x1C")]
			[JsonProperty]
			public int Count;
		}
	}
}
