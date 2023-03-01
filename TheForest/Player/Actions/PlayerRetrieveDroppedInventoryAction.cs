using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Gameplay;
using Sons.Inventory;
using Sons.Save;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000487 RID: 1159
	[Token(Token = "0x2000487")]
	[AddComponentMenu("Sons/Actions/PlayerRetrieveDroppedInventoryAction")]
	public class PlayerRetrieveDroppedInventoryAction : MonoBehaviour, ISaveGameSerializer<PlayerRetrieveDroppedInventoryAction.DroppedInventorySaveData>
	{
		// Token: 0x06001D49 RID: 7497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x2D00660", Offset = "0x2CFF660", VA = "0x182D00660")]
		public DroppedInventoryItemsPickup SpawnAndFillDroppedInventoryBag(Transform location)
		{
			return null;
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D4A")]
		[Address(RVA = "0x2D00770", Offset = "0x2CFF770", VA = "0x182D00770")]
		private DroppedInventoryItemsPickup SpawnAndFillDroppedInventoryBag(Vector3 position, Vector3 rotation)
		{
			return null;
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4B")]
		[Address(RVA = "0x2CFFD90", Offset = "0x2CFED90", VA = "0x182CFFD90")]
		private void OnRetrievalCompleteInternal()
		{
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4C")]
		[Address(RVA = "0x2CFF7A0", Offset = "0x2CFE7A0", VA = "0x182CFF7A0")]
		public void AddInventoryItems(IReadOnlyDictionary<int, ItemInstanceManager.Items> itemsMap)
		{
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4D")]
		[Address(RVA = "0x2D00A10", Offset = "0x2CFFA10", VA = "0x182D00A10")]
		public void StartRetrieval(int gatheredItemId, Transform target, PlayerRetrieveDroppedInventoryAction.OnRetrievalComplete onGatheringCompleteCallback, Vector3 playerOffset)
		{
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0x2D001A0", Offset = "0x2CFF1A0", VA = "0x182D001A0")]
		private IEnumerator RetrievalRoutine()
		{
			return null;
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4F")]
		[Address(RVA = "0x2D003B0", Offset = "0x2CFF3B0", VA = "0x182D003B0")]
		private void SetupBag()
		{
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D50")]
		[Address(RVA = "0x2D00210", Offset = "0x2CFF210", VA = "0x182D00210")]
		private static void SetRigidBodyLock(bool lockValue)
		{
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D51")]
		[Address(RVA = "0x2CFFB80", Offset = "0x2CFEB80", VA = "0x182CFFB80")]
		private void Awake()
		{
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D52")]
		[Address(RVA = "0x2CFFC90", Offset = "0x2CFEC90", VA = "0x182CFFC90")]
		private void OnDestroy()
		{
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FE")]
		public string SerializedName
		{
			[Token(Token = "0x6001D53")]
			[Address(RVA = "0x2D00C80", Offset = "0x2CFFC80", VA = "0x182D00C80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x170003FF")]
		private bool UniqueFile
		{
			[Token(Token = "0x6001D54")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x00008460 File Offset: 0x00006660
		[Token(Token = "0x17000400")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6001D55")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00008478 File Offset: 0x00006678
		[Token(Token = "0x17000401")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6001D56")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x2D00530", Offset = "0x2CFF530", VA = "0x182D00530", Slot = "5")]
		private PlayerRetrieveDroppedInventoryAction.DroppedInventorySaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x2D00480", Offset = "0x2CFF480", VA = "0x182D00480", Slot = "6")]
		private void OnDeserialize(PlayerRetrieveDroppedInventoryAction.DroppedInventorySaveData data)
		{
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D59")]
		[Address(RVA = "0x2CFFD40", Offset = "0x2CFED40", VA = "0x182CFFD40")]
		private void OnPostLoad()
		{
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0x2D00AC0", Offset = "0x2CFFAC0", VA = "0x182D00AC0")]
		public PlayerRetrieveDroppedInventoryAction()
		{
		}

		// Token: 0x04001BC2 RID: 7106
		[Token(Token = "0x4001BC2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _droppedItemsPickupPrefab;

		// Token: 0x04001BC3 RID: 7107
		[Token(Token = "0x4001BC3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private float _offsetBackFromTarget;

		// Token: 0x04001BC4 RID: 7108
		[Token(Token = "0x4001BC4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lerpTime;

		// Token: 0x04001BC5 RID: 7109
		[Token(Token = "0x4001BC5")]
		[FieldOffset(Offset = "0x30")]
		private PlayerRetrieveDroppedInventoryAction.OnRetrievalComplete _onRetrievalComplete;

		// Token: 0x04001BC6 RID: 7110
		[Token(Token = "0x4001BC6")]
		[FieldOffset(Offset = "0x38")]
		private Transform _targetTransform;

		// Token: 0x04001BC7 RID: 7111
		[Token(Token = "0x4001BC7")]
		[FieldOffset(Offset = "0x40")]
		private int _pickUpBagHash;

		// Token: 0x04001BC8 RID: 7112
		[Token(Token = "0x4001BC8")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 _playerOffset;

		// Token: 0x04001BC9 RID: 7113
		[Token(Token = "0x4001BC9")]
		[FieldOffset(Offset = "0x50")]
		private ItemInstanceManager _itemInstanceManager;

		// Token: 0x04001BCA RID: 7114
		[Token(Token = "0x4001BCA")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _droppedInventoryPosition;

		// Token: 0x04001BCB RID: 7115
		[Token(Token = "0x4001BCB")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _droppedInventoryRotation;

		// Token: 0x04001BCC RID: 7116
		[Token(Token = "0x4001BCC")]
		[FieldOffset(Offset = "0x70")]
		private bool _isInventoryDropped;

		// Token: 0x04001BCD RID: 7117
		[Token(Token = "0x4001BCD")]
		[FieldOffset(Offset = "0x71")]
		private bool _loadInventoryFromSave;

		// Token: 0x04001BCE RID: 7118
		[Token(Token = "0x4001BCE")]
		[FieldOffset(Offset = "0x78")]
		private readonly ILayerBehaviourActivator[] FullBodyDisableSpineActivators;

		// Token: 0x02000488 RID: 1160
		// (Invoke) Token: 0x06001D5C RID: 7516
		[Token(Token = "0x2000488")]
		public delegate void OnRetrievalComplete();

		// Token: 0x02000489 RID: 1161
		[Token(Token = "0x2000489")]
		[Serializable]
		internal class DroppedInventorySaveData
		{
			// Token: 0x06001D5F RID: 7519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D5F")]
			[Address(RVA = "0x2CF43D0", Offset = "0x2CF33D0", VA = "0x182CF43D0")]
			public DroppedInventorySaveData()
			{
			}

			// Token: 0x04001BCF RID: 7119
			[Token(Token = "0x4001BCF")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04001BD0 RID: 7120
			[Token(Token = "0x4001BD0")]
			[FieldOffset(Offset = "0x18")]
			public bool IsInventoryDropped;

			// Token: 0x04001BD1 RID: 7121
			[Token(Token = "0x4001BD1")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3S DroppedInventoryPosition;

			// Token: 0x04001BD2 RID: 7122
			[Token(Token = "0x4001BD2")]
			[FieldOffset(Offset = "0x28")]
			public Vector3S DroppedInventoryRotation;

			// Token: 0x04001BD3 RID: 7123
			[Token(Token = "0x4001BD3")]
			[FieldOffset(Offset = "0x38")]
			public ItemInstanceManager.ItemInstanceManagerSaveData ItemInstanceManagerData;
		}
	}
}
