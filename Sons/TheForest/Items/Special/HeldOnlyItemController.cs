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
	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000495")]
	public class HeldOnlyItemController : EntityBehaviour<IPlayerState>, IHeldOnlyItemController, IKnockDownReceiver, IEnterSwimmingReceiver, ISaveGameSerializer<HeldOnlyItemController.HeldOnlyItemSaveData>
	{
		// Token: 0x06001E47 RID: 7751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E47")]
		[Address(RVA = "0x32EF750", Offset = "0x32EDD50", VA = "0x1832EF750")]
		private void Awake()
		{
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x32EF930", Offset = "0x32EDF30", VA = "0x1832EF930")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E49")]
		[Address(RVA = "0x32EF990", Offset = "0x32EDF90", VA = "0x1832EF990")]
		private void Start()
		{
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x32EFA50", Offset = "0x32EE050", VA = "0x1832EFA50")]
		private void Update()
		{
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x32EFC10", Offset = "0x32EE210", VA = "0x1832EFC10")]
		private void OnDisable()
		{
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00008940 File Offset: 0x00006B40
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x32EFC20", Offset = "0x32EE220", VA = "0x1832EFC20", Slot = "29")]
		public bool Controlling(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x32EFCA0", Offset = "0x32EE2A0", VA = "0x1832EFCA0", Slot = "30")]
		public bool Has(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x32EFCB0", Offset = "0x32EE2B0", VA = "0x1832EFCB0", Slot = "31")]
		public bool Lift(int itemId, ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0x32F0290", Offset = "0x32EE890", VA = "0x1832F0290")]
		private HeldOnlyItemController.ControllerItemData GetHeldItem()
		{
			return null;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x32F02A0", Offset = "0x32EE8A0", VA = "0x1832F02A0")]
		private HeldOnlyItemController.ControllerItemData GetControlledItem(int itemId)
		{
			return null;
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x32F0320", Offset = "0x32EE920", VA = "0x1832F0320")]
		public void RemoveHeldItem(bool equipPrevious, bool drop = true)
		{
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x32F0570", Offset = "0x32EEB70", VA = "0x1832F0570")]
		private IEnumerator DelaySetActive(GameObject target, bool activeValue, float delay, bool disableSelf)
		{
			return null;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x32F0620", Offset = "0x32EEC20", VA = "0x1832F0620", Slot = "33")]
		public void DropAll()
		{
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x32F0800", Offset = "0x32EEE00", VA = "0x1832F0800", Slot = "32")]
		public bool PutDown(bool fake = false, bool drop = false, bool equipPrevious = true, [Optional] GameObject preSpawned, int itemId = -1, float delay = -1f)
		{
			return default(bool);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x32F09B0", Offset = "0x32EEFB0", VA = "0x1832F09B0")]
		private IEnumerator SpawnDropItemDelayed(GameObject preSpawned, float delay, int itemId)
		{
			return null;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x32F0AD0", Offset = "0x32EF0D0", VA = "0x1832F0AD0")]
		private void SpawnHeldItemDrop(GameObject preSpawned, int itemId, ItemInstance heldItemInstance)
		{
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x32F1CF0", Offset = "0x32F02F0", VA = "0x1832F1CF0")]
		private void UpdateBoltEntity()
		{
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x32F1E20", Offset = "0x32F0420", VA = "0x1832F1E20")]
		private GameObject GetCurrentHeldGo()
		{
			return null;
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x32F1E80", Offset = "0x32F0480", VA = "0x1832F1E80")]
		private GameObject GetCurrentHeldGo(int itemId)
		{
			return null;
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000422")]
		public ItemInstance HeldItem
		{
			[Token(Token = "0x6001E5A")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x17000423")]
		public int Amount
		{
			[Token(Token = "0x6001E5B")]
			[Address(RVA = "0x784B50", Offset = "0x783150", VA = "0x180784B50", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x000089B8 File Offset: 0x00006BB8
		[Token(Token = "0x17000424")]
		public bool HasItem
		{
			[Token(Token = "0x6001E5C")]
			[Address(RVA = "0x32F1EF0", Offset = "0x32F04F0", VA = "0x1832F1EF0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x000089D0 File Offset: 0x00006BD0
		// (set) Token: 0x06001E5E RID: 7774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000425")]
		public bool InfiniteHack
		{
			[Token(Token = "0x6001E5D")]
			[Address(RVA = "0xA03DA0", Offset = "0xA023A0", VA = "0x180A03DA0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E5E")]
			[Address(RVA = "0x31D1A20", Offset = "0x31D0020", VA = "0x1831D1A20", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0x32F1F00", Offset = "0x32F0500", VA = "0x1832F1F00", Slot = "34")]
		private void OnKnockDownStarted()
		{
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x32F1F00", Offset = "0x32F0500", VA = "0x1832F1F00", Slot = "35")]
		private void OnEnterSwimming()
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000426")]
		private string SerializedName
		{
			[Token(Token = "0x6001E61")]
			[Address(RVA = "0x32F20E0", Offset = "0x32F06E0", VA = "0x1832F20E0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x000089E8 File Offset: 0x00006BE8
		[Token(Token = "0x17000427")]
		private bool UniqueFile
		{
			[Token(Token = "0x6001E62")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x17000428")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6001E63")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x17000429")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6001E64")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E65")]
		[Address(RVA = "0x32F2110", Offset = "0x32F0710", VA = "0x1832F2110", Slot = "37")]
		private HeldOnlyItemController.HeldOnlyItemSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E66")]
		[Address(RVA = "0x32F21D0", Offset = "0x32F07D0", VA = "0x1832F21D0", Slot = "38")]
		private void OnDeserialize(HeldOnlyItemController.HeldOnlyItemSaveData data)
		{
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E67")]
		[Address(RVA = "0x32F2470", Offset = "0x32F0A70", VA = "0x1832F2470")]
		public HeldOnlyItemController()
		{
		}

		// Token: 0x04001C6A RID: 7274
		[Token(Token = "0x4001C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HeldOnlyItemController.ControllerItemData[] _heldOnlyItems;

		// Token: 0x04001C6B RID: 7275
		[Token(Token = "0x4001C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[ItemIdPicker]
		public int _lighterItemId;

		// Token: 0x04001C6C RID: 7276
		[Token(Token = "0x4001C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PlayerInventory _player;

		// Token: 0x04001C6D RID: 7277
		[Token(Token = "0x4001C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask _layerMask;

		// Token: 0x04001C6E RID: 7278
		[Token(Token = "0x4001C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string _pickupAudioEvent;

		// Token: 0x04001C6F RID: 7279
		[Token(Token = "0x4001C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ItemInstance _heldItemInstance;

		// Token: 0x04001C70 RID: 7280
		[Token(Token = "0x4001C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _heldItemId;

		// Token: 0x04001C71 RID: 7281
		[Token(Token = "0x4001C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _heldCount;

		// Token: 0x04001C72 RID: 7282
		[Token(Token = "0x4001C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector3 _dropSpawnOffset;

		// Token: 0x04001C73 RID: 7283
		[Token(Token = "0x4001C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[FormerlySerializedAs("_dropSpawnRotationOffset")]
		[SerializeField]
		private Vector3 _dropSpawnRotationOffsetMin;

		// Token: 0x04001C74 RID: 7284
		[Token(Token = "0x4001C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector3 _dropSpawnRotationOffsetMax;

		// Token: 0x04001C75 RID: 7285
		[Token(Token = "0x4001C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _logDropForce;

		// Token: 0x04001C76 RID: 7286
		[Token(Token = "0x4001C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _logDropUpForce;

		// Token: 0x04001C77 RID: 7287
		[Token(Token = "0x4001C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Vector3 _logDropTorqueMin;

		// Token: 0x04001C78 RID: 7288
		[Token(Token = "0x4001C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector3 _logDropTorqueMax;

		// Token: 0x04001C79 RID: 7289
		[Token(Token = "0x4001C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Action ItemRemovedEvent;

		// Token: 0x04001C7A RID: 7290
		[Token(Token = "0x4001C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Action ItemAddedEvent;

		// Token: 0x04001C7B RID: 7291
		[Token(Token = "0x4001C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly TimedFailSafeCancellationToken _timedFailSafeCancellationToken;

		// Token: 0x02000496 RID: 1174
		[Token(Token = "0x2000496")]
		[Serializable]
		public class ControllerItemData
		{
			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700042A")]
			public GameObject[] Held
			{
				[Token(Token = "0x6001E68")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001E69 RID: 7785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E69")]
			[Address(RVA = "0x32F2550", Offset = "0x32F0B50", VA = "0x1832F2550")]
			public ItemData GetItemCache()
			{
				return null;
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06001E6A RID: 7786 RVA: 0x00008A30 File Offset: 0x00006C30
			[Token(Token = "0x1700042B")]
			public float ItemLength
			{
				[Token(Token = "0x6001E6A")]
				[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00008A48 File Offset: 0x00006C48
			[Token(Token = "0x1700042C")]
			public float ItemMaxLength
			{
				[Token(Token = "0x6001E6B")]
				[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x06001E6C RID: 7788 RVA: 0x00008A60 File Offset: 0x00006C60
			[Token(Token = "0x1700042D")]
			public float ItemThickness
			{
				[Token(Token = "0x6001E6C")]
				[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700042E RID: 1070
			// (get) Token: 0x06001E6D RID: 7789 RVA: 0x00008A78 File Offset: 0x00006C78
			[Token(Token = "0x1700042E")]
			public float DropSpawnDelay
			{
				[Token(Token = "0x6001E6D")]
				[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x06001E6E RID: 7790 RVA: 0x00008A90 File Offset: 0x00006C90
			[Token(Token = "0x1700042F")]
			public bool UseDropOffset
			{
				[Token(Token = "0x6001E6E")]
				[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06001E6F RID: 7791 RVA: 0x00008AA8 File Offset: 0x00006CA8
			[Token(Token = "0x17000430")]
			public Vector3 DropPositionOffset
			{
				[Token(Token = "0x6001E6F")]
				[Address(RVA = "0x62AC70", Offset = "0x629270", VA = "0x18062AC70")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x06001E70 RID: 7792 RVA: 0x00008AC0 File Offset: 0x00006CC0
			[Token(Token = "0x17000431")]
			public Quaternion DropRotationOffset
			{
				[Token(Token = "0x6001E70")]
				[Address(RVA = "0x2B88D90", Offset = "0x2B87390", VA = "0x182B88D90")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x06001E71 RID: 7793 RVA: 0x00008AD8 File Offset: 0x00006CD8
			[Token(Token = "0x6001E71")]
			[Address(RVA = "0x32F2680", Offset = "0x32F0C80", VA = "0x1832F2680")]
			public int GetActiveRenderersCount()
			{
				return 0;
			}

			// Token: 0x06001E72 RID: 7794 RVA: 0x00008AF0 File Offset: 0x00006CF0
			[Token(Token = "0x6001E72")]
			[Address(RVA = "0x32F27E0", Offset = "0x32F0DE0", VA = "0x1832F27E0")]
			public int GetIdleStateHash()
			{
				return 0;
			}

			// Token: 0x06001E73 RID: 7795 RVA: 0x00008B08 File Offset: 0x00006D08
			[Token(Token = "0x6001E73")]
			[Address(RVA = "0x32F28E0", Offset = "0x32F0EE0", VA = "0x1832F28E0")]
			public float GetIdleStateTime()
			{
				return 0f;
			}

			// Token: 0x06001E74 RID: 7796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E74")]
			[Address(RVA = "0x32F2980", Offset = "0x32F0F80", VA = "0x1832F2980")]
			public ControllerItemData()
			{
			}

			// Token: 0x04001C7D RID: 7293
			[Token(Token = "0x4001C7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject[] _held;

			// Token: 0x04001C7E RID: 7294
			[Token(Token = "0x4001C7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[ItemIdPicker(true)]
			private int _itemId;

			// Token: 0x04001C7F RID: 7295
			[Token(Token = "0x4001C7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private float _itemLength;

			// Token: 0x04001C80 RID: 7296
			[Token(Token = "0x4001C80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _itemMaxLength;

			// Token: 0x04001C81 RID: 7297
			[Token(Token = "0x4001C81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			private float _itemThickness;

			// Token: 0x04001C82 RID: 7298
			[Token(Token = "0x4001C82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private float _dropSpawnDelay;

			// Token: 0x04001C83 RID: 7299
			[Token(Token = "0x4001C83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private bool _useDropOffset;

			// Token: 0x04001C84 RID: 7300
			[Token(Token = "0x4001C84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Vector3 _dropPositionOffset;

			// Token: 0x04001C85 RID: 7301
			[Token(Token = "0x4001C85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private Quaternion _dropRotationOffset;

			// Token: 0x04001C86 RID: 7302
			[Token(Token = "0x4001C86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[SerializeField]
			private HeldOnlyItemController.ControllerItemData.AnimTypes _animType;

			// Token: 0x04001C87 RID: 7303
			[Token(Token = "0x4001C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private ItemData _itemCache;

			// Token: 0x02000497 RID: 1175
			[Token(Token = "0x2000497")]
			public enum AnimTypes
			{
				// Token: 0x04001C89 RID: 7305
				[Token(Token = "0x4001C89")]
				Log,
				// Token: 0x04001C8A RID: 7306
				[Token(Token = "0x4001C8A")]
				Stone
			}
		}

		// Token: 0x02000498 RID: 1176
		[Token(Token = "0x2000498")]
		[Serializable]
		public class HeldOnlyItemSaveData
		{
			// Token: 0x06001E75 RID: 7797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E75")]
			[Address(RVA = "0x32F29D0", Offset = "0x32F0FD0", VA = "0x1832F29D0")]
			public HeldOnlyItemSaveData()
			{
			}

			// Token: 0x04001C8B RID: 7307
			[Token(Token = "0x4001C8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public string Version;

			// Token: 0x04001C8C RID: 7308
			[Token(Token = "0x4001C8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public int ItemId;

			// Token: 0x04001C8D RID: 7309
			[Token(Token = "0x4001C8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[JsonProperty]
			public int Count;
		}
	}
}
