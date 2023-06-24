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
	// Token: 0x02000479 RID: 1145
	[Token(Token = "0x2000479")]
	[AddComponentMenu("Sons/Actions/PlayerRetrieveDroppedInventoryAction")]
	public class PlayerRetrieveDroppedInventoryAction : MonoBehaviour, ISaveGameSerializer<PlayerRetrieveDroppedInventoryAction.DroppedInventorySaveData>
	{
		// Token: 0x06001D8D RID: 7565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8D")]
		[Address(RVA = "0x32DC290", Offset = "0x32DA890", VA = "0x1832DC290")]
		public DroppedInventoryItemsPickup SpawnAndFillDroppedInventoryBag(Transform location)
		{
			return null;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8E")]
		[Address(RVA = "0x32DC3C0", Offset = "0x32DA9C0", VA = "0x1832DC3C0")]
		private DroppedInventoryItemsPickup SpawnAndFillDroppedInventoryBag(Vector3 position, Vector3 rotation)
		{
			return null;
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D8F")]
		[Address(RVA = "0x32DC850", Offset = "0x32DAE50", VA = "0x1832DC850")]
		private void OnRetrievalCompleteInternal()
		{
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D90")]
		[Address(RVA = "0x32DCD90", Offset = "0x32DB390", VA = "0x1832DCD90")]
		public void AddInventoryItems(IReadOnlyDictionary<int, ItemInstanceManager.Items> itemsMap)
		{
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D91")]
		[Address(RVA = "0x32DD230", Offset = "0x32DB830", VA = "0x1832DD230")]
		public void StartRetrieval(int gatheredItemId, Transform target, PlayerRetrieveDroppedInventoryAction.OnRetrievalComplete onGatheringCompleteCallback, Vector3 playerOffset)
		{
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D92")]
		[Address(RVA = "0x32DD3A0", Offset = "0x32DB9A0", VA = "0x1832DD3A0")]
		private IEnumerator RetrievalRoutine()
		{
			return null;
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x32DD430", Offset = "0x32DBA30", VA = "0x1832DD430")]
		private void SetupBag()
		{
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D94")]
		[Address(RVA = "0x32DD500", Offset = "0x32DBB00", VA = "0x1832DD500")]
		private static void SetRigidBodyLock(bool lockValue)
		{
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x32DD7E0", Offset = "0x32DBDE0", VA = "0x1832DD7E0")]
		private void Awake()
		{
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x32DD960", Offset = "0x32DBF60", VA = "0x1832DD960")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000408")]
		public string SerializedName
		{
			[Token(Token = "0x6001D97")]
			[Address(RVA = "0x32DDA10", Offset = "0x32DC010", VA = "0x1832DDA10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x17000409")]
		private bool UniqueFile
		{
			[Token(Token = "0x6001D98")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x1700040A")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6001D99")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x1700040B")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6001D9A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x32DDA40", Offset = "0x32DC040", VA = "0x1832DDA40", Slot = "5")]
		private PlayerRetrieveDroppedInventoryAction.DroppedInventorySaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x32DDC00", Offset = "0x32DC200", VA = "0x1832DDC00", Slot = "6")]
		private void OnDeserialize(PlayerRetrieveDroppedInventoryAction.DroppedInventorySaveData data)
		{
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x32DDCB0", Offset = "0x32DC2B0", VA = "0x1832DDCB0")]
		private void OnPostLoad()
		{
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x32DDD10", Offset = "0x32DC310", VA = "0x1832DDD10")]
		public PlayerRetrieveDroppedInventoryAction()
		{
		}

		// Token: 0x04001BEC RID: 7148
		[Token(Token = "0x4001BEC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _droppedItemsPickupPrefab;

		// Token: 0x04001BED RID: 7149
		[Token(Token = "0x4001BED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private float _offsetBackFromTarget;

		// Token: 0x04001BEE RID: 7150
		[Token(Token = "0x4001BEE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lerpTime;

		// Token: 0x04001BEF RID: 7151
		[Token(Token = "0x4001BEF")]
		[FieldOffset(Offset = "0x30")]
		private PlayerRetrieveDroppedInventoryAction.OnRetrievalComplete _onRetrievalComplete;

		// Token: 0x04001BF0 RID: 7152
		[Token(Token = "0x4001BF0")]
		[FieldOffset(Offset = "0x38")]
		private Transform _targetTransform;

		// Token: 0x04001BF1 RID: 7153
		[Token(Token = "0x4001BF1")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _playerOffset;

		// Token: 0x04001BF2 RID: 7154
		[Token(Token = "0x4001BF2")]
		[FieldOffset(Offset = "0x50")]
		private ItemInstanceManager _itemInstanceManager;

		// Token: 0x04001BF3 RID: 7155
		[Token(Token = "0x4001BF3")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _droppedInventoryPosition;

		// Token: 0x04001BF4 RID: 7156
		[Token(Token = "0x4001BF4")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _droppedInventoryRotation;

		// Token: 0x04001BF5 RID: 7157
		[Token(Token = "0x4001BF5")]
		[FieldOffset(Offset = "0x70")]
		private bool _isInventoryDropped;

		// Token: 0x04001BF6 RID: 7158
		[Token(Token = "0x4001BF6")]
		[FieldOffset(Offset = "0x71")]
		private bool _loadInventoryFromSave;

		// Token: 0x04001BF7 RID: 7159
		[Token(Token = "0x4001BF7")]
		[FieldOffset(Offset = "0x78")]
		private GameObject _pickupObject;

		// Token: 0x04001BF8 RID: 7160
		[Token(Token = "0x4001BF8")]
		[FieldOffset(Offset = "0x80")]
		private readonly ILayerBehaviourActivator[] FullBodyDisableSpineActivators;

		// Token: 0x0200047A RID: 1146
		// (Invoke) Token: 0x06001DA0 RID: 7584
		[Token(Token = "0x200047A")]
		public delegate void OnRetrievalComplete();

		// Token: 0x0200047B RID: 1147
		[Token(Token = "0x200047B")]
		[Serializable]
		internal class DroppedInventorySaveData
		{
			// Token: 0x06001DA3 RID: 7587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DA3")]
			[Address(RVA = "0x32DDF80", Offset = "0x32DC580", VA = "0x1832DDF80")]
			public DroppedInventorySaveData()
			{
			}

			// Token: 0x04001BF9 RID: 7161
			[Token(Token = "0x4001BF9")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04001BFA RID: 7162
			[Token(Token = "0x4001BFA")]
			[FieldOffset(Offset = "0x18")]
			public bool IsInventoryDropped;

			// Token: 0x04001BFB RID: 7163
			[Token(Token = "0x4001BFB")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3S DroppedInventoryPosition;

			// Token: 0x04001BFC RID: 7164
			[Token(Token = "0x4001BFC")]
			[FieldOffset(Offset = "0x28")]
			public Vector3S DroppedInventoryRotation;

			// Token: 0x04001BFD RID: 7165
			[Token(Token = "0x4001BFD")]
			[FieldOffset(Offset = "0x38")]
			public ItemInstanceManager.ItemInstanceManagerSaveData ItemInstanceManagerData;
		}
	}
}
