using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Physics;
using Endnight.Utilities;
using FMODUnity;
using Il2CppDummyDll;
using PathologicalGames;
using Sons.Atmosphere;
using Sons.Gui.Input;
using Sons.Inventory;
using Sons.Items.Core;
using Sons.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x02000685 RID: 1669
	[Token(Token = "0x2000685")]
	[AddComponentMenu("Sons/Pickup/PickUp")]
	public class PickUp : MonoBehaviour, IDismember, ISpawnable, IKillBoxReceiver, IOnSpawned, IParentNotification, ISeasonsReceiver
	{
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x0000C420 File Offset: 0x0000A620
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057F")]
		public bool ForceDisabled
		{
			[Token(Token = "0x6002A93")]
			[Address(RVA = "0x2DD88B0", Offset = "0x2DD78B0", VA = "0x182DD88B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A94")]
			[Address(RVA = "0x2DD88C0", Offset = "0x2DD78C0", VA = "0x182DD88C0")]
			set
			{
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000580")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x6002A95")]
			[Address(RVA = "0x6B7130", Offset = "0x6B6130", VA = "0x1806B7130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A96")]
			[Address(RVA = "0x6B7320", Offset = "0x6B6320", VA = "0x1806B7320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x0000C438 File Offset: 0x0000A638
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000581")]
		public bool Used
		{
			[Token(Token = "0x6002A97")]
			[Address(RVA = "0x59F880", Offset = "0x59E880", VA = "0x18059F880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A98")]
			[Address(RVA = "0x59FBF0", Offset = "0x59EBF0", VA = "0x18059FBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A99")]
		[Address(RVA = "0x2DD7300", Offset = "0x2DD6300", VA = "0x182DD7300")]
		public void ResetIsCollected()
		{
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0x2DD54E0", Offset = "0x2DD44E0", VA = "0x182DD54E0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0x2DD8080", Offset = "0x2DD7080", VA = "0x182DD8080")]
		protected void Start()
		{
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0x2DD6B40", Offset = "0x2DD5B40", VA = "0x182DD6B40", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0x2DD78D0", Offset = "0x2DD68D0", VA = "0x182DD78D0", Slot = "13")]
		protected virtual void SetupLinkUi()
		{
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x2DD76C0", Offset = "0x2DD66C0", VA = "0x182DD76C0")]
		private string SelectUIElementId()
		{
			return null;
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x0000C450 File Offset: 0x0000A650
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x2DD56A0", Offset = "0x2DD46A0", VA = "0x182DD56A0", Slot = "14")]
		protected virtual bool CanPlayerGather()
		{
			return default(bool);
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x0000C468 File Offset: 0x0000A668
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "15")]
		protected virtual bool IsWaitingToActivate()
		{
			return default(bool);
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x2DD8740", Offset = "0x2DD7740", VA = "0x182DD8740", Slot = "16")]
		protected virtual void Update()
		{
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x2DC61F0", Offset = "0x2DC51F0", VA = "0x182DC61F0", Slot = "17")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x2DD6EA0", Offset = "0x2DD5EA0", VA = "0x182DD6EA0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x2DD7850", Offset = "0x2DD6850", VA = "0x182DD7850", Slot = "18")]
		public virtual void SetItemInstance(ItemInstance itemInstance, bool pushToBolt = true)
		{
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x2DD7260", Offset = "0x2DD6260", VA = "0x182DD7260")]
		private void PushItemInstanceToBolt()
		{
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x2DD6E60", Offset = "0x2DD5E60", VA = "0x182DD6E60")]
		private void OnTake(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x2DD6F60", Offset = "0x2DD5F60", VA = "0x182DD6F60")]
		private void OnUse(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x2DD6D30", Offset = "0x2DD5D30", VA = "0x182DD6D30", Slot = "19")]
		protected virtual void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x2DD67C0", Offset = "0x2DD57C0", VA = "0x182DD67C0", Slot = "20")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "5")]
		public void SpawnInitialize(GameObject root)
		{
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0x2DD6DB0", Offset = "0x2DD5DB0", VA = "0x182DD6DB0", Slot = "7")]
		public void OnSpawned(SpawnPool pool)
		{
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x2DD6250", Offset = "0x2DD5250", VA = "0x182DD6250", Slot = "21")]
		public virtual void GrabEnter()
		{
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x2DD62E0", Offset = "0x2DD52E0", VA = "0x182DD62E0", Slot = "22")]
		public virtual void GrabStay()
		{
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x2DD62B0", Offset = "0x2DD52B0", VA = "0x182DD62B0", Slot = "23")]
		public virtual void GrabExit()
		{
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAF")]
		[Address(RVA = "0x2DD8090", Offset = "0x2DD7090", VA = "0x182DD8090")]
		public void ToggleIcons(bool enable)
		{
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB0")]
		[Address(RVA = "0x2DD6FA0", Offset = "0x2DD5FA0", VA = "0x182DD6FA0")]
		private void OwnershipCheckRegistration()
		{
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB1")]
		[Address(RVA = "0x2DD7050", Offset = "0x2DD6050", VA = "0x182DD7050")]
		private void OwnershipCheckUnregister()
		{
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x2DD70D0", Offset = "0x2DD60D0", VA = "0x182DD70D0", Slot = "24")]
		protected virtual void OwnershipCheck()
		{
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x0000C480 File Offset: 0x0000A680
		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0x2DD5E30", Offset = "0x2DD4E30", VA = "0x182DD5E30")]
		private bool DestroyThroughBolt(bool fakeDrop)
		{
			return default(bool);
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x5F0BB0", Offset = "0x5EFBB0", VA = "0x1805F0BB0")]
		public void Take()
		{
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x2DD5C50", Offset = "0x2DD4C50", VA = "0x182DD5C50", Slot = "25")]
		protected virtual void Collect()
		{
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x2DD56D0", Offset = "0x2DD46D0", VA = "0x182DD56D0")]
		private void CheckSpiderChance()
		{
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0x2DD7DA0", Offset = "0x2DD6DA0", VA = "0x182DD7DA0")]
		protected GameObject SpawnPickupPrefab(Vector3 spawnPos, Quaternion spawnRot, GameObject pickupPrefab, bool dynamic)
		{
			return null;
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB8")]
		[Address(RVA = "0x2DD7BE0", Offset = "0x2DD6BE0", VA = "0x182DD7BE0", Slot = "26")]
		protected virtual void SpawnAfterPickup()
		{
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0000C498 File Offset: 0x0000A698
		[Token(Token = "0x6002AB9")]
		[Address(RVA = "0x2DD64E0", Offset = "0x2DD54E0", VA = "0x182DD64E0", Slot = "27")]
		protected virtual bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0x2DD5AE0", Offset = "0x2DD4AE0", VA = "0x182DD5AE0")]
		private void CollectAdditionalItems()
		{
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0x2DD5810", Offset = "0x2DD4810", VA = "0x182DD5810")]
		public void ClearOut(bool fakeDrop)
		{
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABC")]
		[Address(RVA = "0x2DD7310", Offset = "0x2DD6310", VA = "0x182DD7310")]
		public void Respawn()
		{
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[Token(Token = "0x6002ABD")]
		[Address(RVA = "0x2DD8480", Offset = "0x2DD7480", VA = "0x182DD8480")]
		public bool TryPool()
		{
			return default(bool);
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABE")]
		[Address(RVA = "0x2DD81C0", Offset = "0x2DD71C0", VA = "0x182DD81C0")]
		private void ToggleRenderers(Transform t, bool enabled)
		{
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x2DD61C0", Offset = "0x2DD51C0", VA = "0x182DD61C0", Slot = "28")]
		protected virtual bool DoFakeDrop()
		{
			return default(bool);
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x2DD7780", Offset = "0x2DD6780", VA = "0x182DD7780")]
		public void SetDynamic(bool isDynamic)
		{
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x2DD6450", Offset = "0x2DD5450", VA = "0x182DD6450", Slot = "4")]
		private void OnDismember(int sourceActorType)
		{
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x2DD63C0", Offset = "0x2DD53C0", VA = "0x182DD63C0", Slot = "6")]
		public void HitKillBox()
		{
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0x2DD6230", Offset = "0x2DD5230", VA = "0x182DD6230", Slot = "8")]
		private void OnParentDisabled()
		{
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0x2DD7500", Offset = "0x2DD6500", VA = "0x182DD7500")]
		private void SeasonsInitialize()
		{
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0x2DD6300", Offset = "0x2DD5300", VA = "0x182DD6300")]
		private bool HasValidSeasonalPropertyChanceValidator()
		{
			return default(bool);
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC6")]
		[Address(RVA = "0x2DD7460", Offset = "0x2DD6460", VA = "0x182DD7460")]
		private void SeasonsDisconnect()
		{
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0x2DD7340", Offset = "0x2DD6340", VA = "0x182DD7340", Slot = "9")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0x2DD87A0", Offset = "0x2DD77A0", VA = "0x182DD87A0")]
		public PickUp()
		{
		}

		// Token: 0x04002614 RID: 9748
		[Token(Token = "0x4002614")]
		private const string ScreenTakeUiElementId = "screen.take";

		// Token: 0x04002615 RID: 9749
		[Token(Token = "0x4002615")]
		private const string ScreenTakeAndUseUiElementId = "screen.takeAndUse";

		// Token: 0x04002616 RID: 9750
		[Token(Token = "0x4002616")]
		private const string ScreenUseUiElementId = "screen.use";

		// Token: 0x04002617 RID: 9751
		[Token(Token = "0x4002617")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _pickupDelayOnSpawn;

		// Token: 0x04002618 RID: 9752
		[Token(Token = "0x4002618")]
		[FieldOffset(Offset = "0x28")]
		public RandomRange _amount;

		// Token: 0x04002619 RID: 9753
		[Token(Token = "0x4002619")]
		[FieldOffset(Offset = "0x30")]
		public bool _bodyAutoCollect;

		// Token: 0x0400261A RID: 9754
		[Token(Token = "0x400261A")]
		[FieldOffset(Offset = "0x38")]
		public List<ItemAndRange> _additionalItems;

		// Token: 0x0400261B RID: 9755
		[Token(Token = "0x400261B")]
		[FieldOffset(Offset = "0x40")]
		public bool _destroyIfAlreadyOwned;

		// Token: 0x0400261C RID: 9756
		[Token(Token = "0x400261C")]
		[FieldOffset(Offset = "0x41")]
		public bool _hideIfAlreadyOwned;

		// Token: 0x0400261D RID: 9757
		[Token(Token = "0x400261D")]
		[FieldOffset(Offset = "0x42")]
		public bool _destroyIfFull;

		// Token: 0x0400261E RID: 9758
		[Token(Token = "0x400261E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject _destroyTarget;

		// Token: 0x0400261F RID: 9759
		[Token(Token = "0x400261F")]
		[FieldOffset(Offset = "0x50")]
		public bool _disableInsteadOfDestroy;

		// Token: 0x04002620 RID: 9760
		[Token(Token = "0x4002620")]
		[FieldOffset(Offset = "0x51")]
		public bool _dynamicOnParentDisabled;

		// Token: 0x04002621 RID: 9761
		[Token(Token = "0x4002621")]
		[FieldOffset(Offset = "0x52")]
		public bool _forceAutoEquip;

		// Token: 0x04002622 RID: 9762
		[Token(Token = "0x4002622")]
		[FieldOffset(Offset = "0x53")]
		public bool _grabberAutoCollect;

		// Token: 0x04002623 RID: 9763
		[Token(Token = "0x4002623")]
		[FieldOffset(Offset = "0x54")]
		public bool _infinite;

		// Token: 0x04002624 RID: 9764
		[Token(Token = "0x4002624")]
		[FieldOffset(Offset = "0x55")]
		private bool _forceDisabled;

		// Token: 0x04002625 RID: 9765
		[Token(Token = "0x4002625")]
		[FieldOffset(Offset = "0x58")]
		protected int _amountToAdd;

		// Token: 0x04002626 RID: 9766
		[Token(Token = "0x4002626")]
		[FieldOffset(Offset = "0x5C")]
		[ItemIdPicker(true)]
		public int _itemId;

		// Token: 0x04002627 RID: 9767
		[Token(Token = "0x4002627")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected bool _useContextualInputMethod;

		// Token: 0x04002628 RID: 9768
		[Token(Token = "0x4002628")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		protected bool _forceProgressIndicator;

		// Token: 0x04002629 RID: 9769
		[Token(Token = "0x4002629")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		protected LinkUiElement _linkUiElement;

		// Token: 0x0400262A RID: 9770
		[Token(Token = "0x400262A")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("_myPickUp")]
		public GameObject _interactionElement;

		// Token: 0x0400262B RID: 9771
		[Token(Token = "0x400262B")]
		[FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("_sheen")]
		public GameObject _icon;

		// Token: 0x0400262C RID: 9772
		[Token(Token = "0x400262C")]
		[FieldOffset(Offset = "0x80")]
		public bool _poolManagerDespawnCreature;

		// Token: 0x0400262D RID: 9773
		[Token(Token = "0x400262D")]
		[FieldOffset(Offset = "0x88")]
		public string _poolManagerPool;

		// Token: 0x0400262E RID: 9774
		[Token(Token = "0x400262E")]
		[FieldOffset(Offset = "0x90")]
		public bool _positionHashSaving;

		// Token: 0x0400262F RID: 9775
		[Token(Token = "0x400262F")]
		[FieldOffset(Offset = "0x91")]
		[SerializeField]
		protected bool _preventAutoEquip;

		// Token: 0x04002630 RID: 9776
		[Token(Token = "0x4002630")]
		[FieldOffset(Offset = "0x92")]
		public bool _preventFakeDrop;

		// Token: 0x04002631 RID: 9777
		[Token(Token = "0x4002631")]
		[FieldOffset(Offset = "0x93")]
		public bool _preventFakeDropReUse;

		// Token: 0x04002632 RID: 9778
		[Token(Token = "0x4002632")]
		[FieldOffset(Offset = "0x98")]
		public GameObject _spawnAfterPickupPrefab;

		// Token: 0x04002633 RID: 9779
		[Token(Token = "0x4002633")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject _spawnAfterPickupPrefab2;

		// Token: 0x04002634 RID: 9780
		[Token(Token = "0x4002634")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[FormerlySerializedAs("_spiderDice")]
		private bool _spawnSpiders;

		// Token: 0x04002635 RID: 9781
		[Token(Token = "0x4002635")]
		[FieldOffset(Offset = "0xAC")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _spiderSpawnChance;

		// Token: 0x04002636 RID: 9782
		[Token(Token = "0x4002636")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[EventRef]
		protected string _onPickupAudioEvent;

		// Token: 0x04002637 RID: 9783
		[Token(Token = "0x4002637")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent<PickUp> OnPickedUp;

		// Token: 0x04002638 RID: 9784
		[Token(Token = "0x4002638")]
		[FieldOffset(Offset = "0xC0")]
		private float _enableTime;

		// Token: 0x04002639 RID: 9785
		[Token(Token = "0x4002639")]
		[FieldOffset(Offset = "0xC4")]
		protected bool _pendingDestroyThroughBolt;

		// Token: 0x0400263A RID: 9786
		[Token(Token = "0x400263A")]
		[FieldOffset(Offset = "0xC5")]
		protected bool _isCollected;

		// Token: 0x0400263B RID: 9787
		[Token(Token = "0x400263B")]
		[FieldOffset(Offset = "0xC8")]
		private int _wsToken;

		// Token: 0x0400263E RID: 9790
		[Token(Token = "0x400263E")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private SeasonPropertyChanceValidator[] _seasonalPropertyChanceValidators;

		// Token: 0x0400263F RID: 9791
		[Token(Token = "0x400263F")]
		[FieldOffset(Offset = "0xE8")]
		private bool _registeredSeasons;

		// Token: 0x04002640 RID: 9792
		[Token(Token = "0x4002640")]
		[FieldOffset(Offset = "0xF0")]
		private SeasonsManager _seasonsManager;
	}
}
