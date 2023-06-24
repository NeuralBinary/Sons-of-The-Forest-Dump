using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Physics;
using Endnight.Utilities;
using FMODUnity;
using Il2CppDummyDll;
using PathologicalGames;
using Sons.Ai.Vail.Inventory;
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
	// Token: 0x020007A7 RID: 1959
	[Token(Token = "0x20007A7")]
	[AddComponentMenu("Sons/Pickup/PickUp")]
	public class PickUp : MonoBehaviour, IDismember, ISpawnable, IKillBoxReceiver, IOnSpawned, IParentNotification, IVailPickupItem, ISeasonsReceiver
	{
		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006AB")]
		public bool ForceDisabled
		{
			[Token(Token = "0x60034A0")]
			[Address(RVA = "0x213CBB0", Offset = "0x213B1B0", VA = "0x18213CBB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60034A1")]
			[Address(RVA = "0x34CE390", Offset = "0x34CC990", VA = "0x1834CE390")]
			set
			{
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060034A3 RID: 13475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006AC")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x60034A2")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60034A3")]
			[Address(RVA = "0x784BB0", Offset = "0x7831B0", VA = "0x180784BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006AD")]
		public bool Used
		{
			[Token(Token = "0x60034A4")]
			[Address(RVA = "0x27394A0", Offset = "0x2737AA0", VA = "0x1827394A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60034A5")]
			[Address(RVA = "0x3359130", Offset = "0x3357730", VA = "0x183359130")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[Token(Token = "0x60034A6")]
		[Address(RVA = "0x34CE3B0", Offset = "0x34CC9B0", VA = "0x1834CE3B0")]
		private bool BlockedFullBodyInteraction()
		{
			return default(bool);
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x2E0D9F0", Offset = "0x2E0BFF0", VA = "0x182E0D9F0")]
		public bool IsPendingDestroyThroughBolt()
		{
			return default(bool);
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x28068F0", Offset = "0x2804EF0", VA = "0x1828068F0")]
		public bool IsBeingDestroyed()
		{
			return default(bool);
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x0000FC30 File Offset: 0x0000DE30
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x34CE3C0", Offset = "0x34CC9C0", VA = "0x1834CE3C0")]
		public bool HasSpawnOnPickup()
		{
			return default(bool);
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x34CE480", Offset = "0x34CCA80", VA = "0x1834CE480")]
		public void ResetIsCollected()
		{
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x34CE490", Offset = "0x34CCA90", VA = "0x1834CE490", Slot = "13")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x34CE820", Offset = "0x34CCE20", VA = "0x1834CE820")]
		protected void Start()
		{
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AD")]
		[Address(RVA = "0x34CE830", Offset = "0x34CCE30", VA = "0x1834CE830", Slot = "14")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AE")]
		[Address(RVA = "0x34CEAE0", Offset = "0x34CD0E0", VA = "0x1834CEAE0", Slot = "15")]
		protected virtual void SetupLinkUi()
		{
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034AF")]
		[Address(RVA = "0x34CEFD0", Offset = "0x34CD5D0", VA = "0x1834CEFD0")]
		private string SelectUIElementId()
		{
			return null;
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x0000FC48 File Offset: 0x0000DE48
		[Token(Token = "0x170006AE")]
		private bool IsSwimming
		{
			[Token(Token = "0x60034B0")]
			[Address(RVA = "0x34CF050", Offset = "0x34CD650", VA = "0x1834CF050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[Token(Token = "0x60034B1")]
		[Address(RVA = "0x34CF180", Offset = "0x34CD780", VA = "0x1834CF180", Slot = "16")]
		protected virtual bool CanPlayerGather()
		{
			return default(bool);
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x0000FC78 File Offset: 0x0000DE78
		[Token(Token = "0x60034B2")]
		[Address(RVA = "0x34CF1F0", Offset = "0x34CD7F0", VA = "0x1834CF1F0")]
		private bool SwimmingBlocked()
		{
			return default(bool);
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x0000FC90 File Offset: 0x0000DE90
		[Token(Token = "0x60034B3")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "17")]
		protected virtual bool IsWaitingToActivate()
		{
			return default(bool);
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x34CF220", Offset = "0x34CD820", VA = "0x1834CF220", Slot = "18")]
		protected virtual void Update()
		{
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x34C8070", Offset = "0x34C6670", VA = "0x1834C8070", Slot = "19")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x34CF2B0", Offset = "0x34CD8B0", VA = "0x1834CF2B0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x34CF440", Offset = "0x34CDA40", VA = "0x1834CF440", Slot = "20")]
		public virtual void SetItemInstance(ItemInstance itemInstance, bool pushToBolt = true)
		{
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x34CF610", Offset = "0x34CDC10", VA = "0x1834CF610")]
		private void PushItemInstanceToBolt()
		{
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x34CF7E0", Offset = "0x34CDDE0", VA = "0x1834CF7E0")]
		private void OnTake(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x34CF820", Offset = "0x34CDE20", VA = "0x1834CF820")]
		private void OnUse(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x34CF860", Offset = "0x34CDE60", VA = "0x1834CF860", Slot = "21")]
		protected virtual void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BC")]
		[Address(RVA = "0x34CF920", Offset = "0x34CDF20", VA = "0x1834CF920", Slot = "22")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void SpawnInitialize(GameObject root)
		{
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BE")]
		[Address(RVA = "0x34D0070", Offset = "0x34CE670", VA = "0x1834D0070", Slot = "7")]
		public void OnSpawned(SpawnPool pool)
		{
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BF")]
		[Address(RVA = "0x34D0200", Offset = "0x34CE800", VA = "0x1834D0200", Slot = "23")]
		public virtual void GrabEnter()
		{
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x673AD0", Offset = "0x6720D0", VA = "0x180673AD0", Slot = "24")]
		public virtual void GrabStay()
		{
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x34D02C0", Offset = "0x34CE8C0", VA = "0x1834D02C0", Slot = "25")]
		public virtual void GrabExit()
		{
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x34D0320", Offset = "0x34CE920", VA = "0x1834D0320")]
		public void ToggleIcons(bool enable)
		{
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x34D05C0", Offset = "0x34CEBC0", VA = "0x1834D05C0")]
		private void OwnershipCheckRegistration()
		{
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x34D0700", Offset = "0x34CED00", VA = "0x1834D0700")]
		private void OwnershipCheckUnregister()
		{
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x34D0780", Offset = "0x34CED80", VA = "0x1834D0780", Slot = "26")]
		protected virtual void OwnershipCheck()
		{
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x34D09E0", Offset = "0x34CEFE0", VA = "0x1834D09E0")]
		private bool DestroyThroughBolt(bool fakeDrop)
		{
			return default(bool);
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x34D10D0", Offset = "0x34CF6D0", VA = "0x1834D10D0")]
		public void Take()
		{
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C8")]
		[Address(RVA = "0x34D10F0", Offset = "0x34CF6F0", VA = "0x1834D10F0", Slot = "27")]
		protected virtual void Collect()
		{
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x34D15A0", Offset = "0x34CFBA0", VA = "0x1834D15A0")]
		private bool ShouldSpawnOnPickup()
		{
			return default(bool);
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x34D1680", Offset = "0x34CFC80", VA = "0x1834D1680")]
		private void CheckSpiderChance()
		{
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x34D18E0", Offset = "0x34CFEE0", VA = "0x1834D18E0")]
		protected GameObject SpawnPickupPrefab(Vector3 spawnPos, Quaternion spawnRot, GameObject pickupPrefab, bool dynamic)
		{
			return null;
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x34D1D90", Offset = "0x34D0390", VA = "0x1834D1D90", Slot = "28")]
		protected virtual void SpawnAfterPickup(bool isDynamic = false)
		{
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x34D1FD0", Offset = "0x34D05D0", VA = "0x1834D1FD0", Slot = "29")]
		protected virtual bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x34D2460", Offset = "0x34D0A60", VA = "0x1834D2460")]
		private void CollectAdditionalItems()
		{
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x34D2640", Offset = "0x34D0C40", VA = "0x1834D2640", Slot = "10")]
		public void ClearOut(bool fakeDrop)
		{
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0x34D2970", Offset = "0x34D0F70", VA = "0x1834D2970")]
		public void Respawn()
		{
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x34D29E0", Offset = "0x34D0FE0", VA = "0x1834D29E0")]
		public bool TryPool()
		{
			return default(bool);
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x34D2EF0", Offset = "0x34D14F0", VA = "0x1834D2EF0")]
		private void ToggleRenderers(Transform t, bool enabled)
		{
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x0000FD08 File Offset: 0x0000DF08
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x34D3280", Offset = "0x34D1880", VA = "0x1834D3280", Slot = "30")]
		protected virtual bool DoFakeDrop()
		{
			return default(bool);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x34D3320", Offset = "0x34D1920", VA = "0x1834D3320")]
		public void SetColliders(bool active)
		{
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x34D3410", Offset = "0x34D1A10", VA = "0x1834D3410", Slot = "9")]
		public void SetDynamic(bool isDynamic)
		{
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x0000FD20 File Offset: 0x0000DF20
		[Token(Token = "0x60034D6")]
		[Address(RVA = "0x34D36F0", Offset = "0x34D1CF0", VA = "0x1834D36F0")]
		public bool IsDynamic()
		{
			return default(bool);
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D7")]
		[Address(RVA = "0x34D3810", Offset = "0x34D1E10", VA = "0x1834D3810", Slot = "4")]
		private void OnDismember(int sourceActorType)
		{
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D8")]
		[Address(RVA = "0x34D38D0", Offset = "0x34D1ED0", VA = "0x1834D38D0", Slot = "6")]
		public void HitKillBox()
		{
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D9")]
		[Address(RVA = "0x34D3960", Offset = "0x34D1F60", VA = "0x1834D3960", Slot = "8")]
		private void OnParentDisabled()
		{
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DA")]
		[Address(RVA = "0x34D3980", Offset = "0x34D1F80", VA = "0x1834D3980")]
		private void SeasonsInitialize()
		{
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x0000FD38 File Offset: 0x0000DF38
		[Token(Token = "0x60034DB")]
		[Address(RVA = "0x34D3C10", Offset = "0x34D2210", VA = "0x1834D3C10")]
		private bool HasValidSeasonalPropertyChanceValidator()
		{
			return default(bool);
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DC")]
		[Address(RVA = "0x34D3D50", Offset = "0x34D2350", VA = "0x1834D3D50")]
		private void SeasonsDisconnect()
		{
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DD")]
		[Address(RVA = "0x34D3E50", Offset = "0x34D2450", VA = "0x1834D3E50", Slot = "11")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DE")]
		[Address(RVA = "0x34D3FE0", Offset = "0x34D25E0", VA = "0x1834D3FE0")]
		public PickUp()
		{
		}

		// Token: 0x04002D75 RID: 11637
		[Token(Token = "0x4002D75")]
		private const string ScreenTakeUiElementId = "screen.take";

		// Token: 0x04002D76 RID: 11638
		[Token(Token = "0x4002D76")]
		private const string ScreenTakeAndUseUiElementId = "screen.takeAndUse";

		// Token: 0x04002D77 RID: 11639
		[Token(Token = "0x4002D77")]
		private const string ScreenUseUiElementId = "screen.use";

		// Token: 0x04002D78 RID: 11640
		[Token(Token = "0x4002D78")]
		private const string PickupsPoolId = "PickUps";

		// Token: 0x04002D79 RID: 11641
		[Token(Token = "0x4002D79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _pickupDelayOnSpawn;

		// Token: 0x04002D7A RID: 11642
		[Token(Token = "0x4002D7A")]
		[FieldOffset(Offset = "0x28")]
		public RandomRange _amount;

		// Token: 0x04002D7B RID: 11643
		[Token(Token = "0x4002D7B")]
		[FieldOffset(Offset = "0x30")]
		public bool _bodyAutoCollect;

		// Token: 0x04002D7C RID: 11644
		[Token(Token = "0x4002D7C")]
		[FieldOffset(Offset = "0x38")]
		public List<ItemAndRange> _additionalItems;

		// Token: 0x04002D7D RID: 11645
		[Token(Token = "0x4002D7D")]
		[FieldOffset(Offset = "0x40")]
		public bool _destroyIfAlreadyOwned;

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0x41")]
		public bool _hideIfAlreadyOwned;

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		[FieldOffset(Offset = "0x42")]
		public bool _destroyIfFull;

		// Token: 0x04002D80 RID: 11648
		[Token(Token = "0x4002D80")]
		[FieldOffset(Offset = "0x48")]
		public GameObject _destroyTarget;

		// Token: 0x04002D81 RID: 11649
		[Token(Token = "0x4002D81")]
		[FieldOffset(Offset = "0x50")]
		public bool _disableInsteadOfDestroy;

		// Token: 0x04002D82 RID: 11650
		[Token(Token = "0x4002D82")]
		[FieldOffset(Offset = "0x51")]
		public bool _dynamicOnParentDisabled;

		// Token: 0x04002D83 RID: 11651
		[Token(Token = "0x4002D83")]
		[FieldOffset(Offset = "0x52")]
		public bool _forceAutoEquip;

		// Token: 0x04002D84 RID: 11652
		[Token(Token = "0x4002D84")]
		[FieldOffset(Offset = "0x53")]
		public bool _grabberAutoCollect;

		// Token: 0x04002D85 RID: 11653
		[Token(Token = "0x4002D85")]
		[FieldOffset(Offset = "0x54")]
		public bool _infinite;

		// Token: 0x04002D86 RID: 11654
		[Token(Token = "0x4002D86")]
		[FieldOffset(Offset = "0x55")]
		[SerializeField]
		private bool _needsFullBodyInteraction;

		// Token: 0x04002D87 RID: 11655
		[Token(Token = "0x4002D87")]
		[FieldOffset(Offset = "0x56")]
		[SerializeField]
		private bool _blockWhileSwimming;

		// Token: 0x04002D88 RID: 11656
		[Token(Token = "0x4002D88")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _spawnOnPickup;

		// Token: 0x04002D89 RID: 11657
		[Token(Token = "0x4002D89")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _spawnOnPickupStaticOnly;

		// Token: 0x04002D8A RID: 11658
		[Token(Token = "0x4002D8A")]
		[FieldOffset(Offset = "0x61")]
		private bool _forceDisabled;

		// Token: 0x04002D8B RID: 11659
		[Token(Token = "0x4002D8B")]
		[FieldOffset(Offset = "0x64")]
		protected int _amountToAdd;

		// Token: 0x04002D8C RID: 11660
		[Token(Token = "0x4002D8C")]
		[FieldOffset(Offset = "0x68")]
		[ItemIdPicker(true)]
		public int _itemId;

		// Token: 0x04002D8D RID: 11661
		[Token(Token = "0x4002D8D")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		protected bool _useContextualInputMethod;

		// Token: 0x04002D8E RID: 11662
		[Token(Token = "0x4002D8E")]
		[FieldOffset(Offset = "0x6D")]
		[SerializeField]
		protected bool _forceProgressIndicator;

		// Token: 0x04002D8F RID: 11663
		[Token(Token = "0x4002D8F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[HideInInspector]
		protected LinkUiElement _linkUiElement;

		// Token: 0x04002D90 RID: 11664
		[Token(Token = "0x4002D90")]
		[FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("_myPickUp")]
		public GameObject _interactionElement;

		// Token: 0x04002D91 RID: 11665
		[Token(Token = "0x4002D91")]
		[FieldOffset(Offset = "0x80")]
		[FormerlySerializedAs("_sheen")]
		public GameObject _icon;

		// Token: 0x04002D92 RID: 11666
		[Token(Token = "0x4002D92")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ItemRenderable _itemRenderable;

		// Token: 0x04002D93 RID: 11667
		[Token(Token = "0x4002D93")]
		[FieldOffset(Offset = "0x90")]
		public bool _poolManagerDespawnCreature;

		// Token: 0x04002D94 RID: 11668
		[Token(Token = "0x4002D94")]
		[FieldOffset(Offset = "0x98")]
		public string _poolManagerPool;

		// Token: 0x04002D95 RID: 11669
		[Token(Token = "0x4002D95")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected bool _preventAutoEquip;

		// Token: 0x04002D96 RID: 11670
		[Token(Token = "0x4002D96")]
		[FieldOffset(Offset = "0xA1")]
		public bool _preventFakeDrop;

		// Token: 0x04002D97 RID: 11671
		[Token(Token = "0x4002D97")]
		[FieldOffset(Offset = "0xA2")]
		public bool _preventFakeDropReUse;

		// Token: 0x04002D98 RID: 11672
		[Token(Token = "0x4002D98")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject _spawnAfterPickupPrefab;

		// Token: 0x04002D99 RID: 11673
		[Token(Token = "0x4002D99")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject _spawnAfterPickupPrefab2;

		// Token: 0x04002D9A RID: 11674
		[Token(Token = "0x4002D9A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[FormerlySerializedAs("_spiderDice")]
		private bool _spawnSpiders;

		// Token: 0x04002D9B RID: 11675
		[Token(Token = "0x4002D9B")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _spiderSpawnChance;

		// Token: 0x04002D9C RID: 11676
		[Token(Token = "0x4002D9C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[EventRef]
		protected string _onPickupAudioEvent;

		// Token: 0x04002D9D RID: 11677
		[Token(Token = "0x4002D9D")]
		[FieldOffset(Offset = "0xC8")]
		public UnityEvent<PickUp> OnPickedUp;

		// Token: 0x04002D9E RID: 11678
		[Token(Token = "0x4002D9E")]
		[FieldOffset(Offset = "0xD0")]
		private float _enableTime;

		// Token: 0x04002D9F RID: 11679
		[Token(Token = "0x4002D9F")]
		[FieldOffset(Offset = "0xD4")]
		protected bool _pendingDestroyThroughBolt;

		// Token: 0x04002DA0 RID: 11680
		[Token(Token = "0x4002DA0")]
		[FieldOffset(Offset = "0xD5")]
		protected bool _isCollected;

		// Token: 0x04002DA1 RID: 11681
		[Token(Token = "0x4002DA1")]
		[FieldOffset(Offset = "0xD8")]
		private int _wsToken;

		// Token: 0x04002DA2 RID: 11682
		[Token(Token = "0x4002DA2")]
		[FieldOffset(Offset = "0xDC")]
		private bool _isBeingDestroyed;

		// Token: 0x04002DA5 RID: 11685
		[Token(Token = "0x4002DA5")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private SeasonPropertyChanceValidator[] _seasonalPropertyChanceValidators;

		// Token: 0x04002DA6 RID: 11686
		[Token(Token = "0x4002DA6")]
		[FieldOffset(Offset = "0xF8")]
		private bool _registeredSeasons;

		// Token: 0x04002DA7 RID: 11687
		[Token(Token = "0x4002DA7")]
		[FieldOffset(Offset = "0x100")]
		private SeasonsManager _seasonsManager;
	}
}
