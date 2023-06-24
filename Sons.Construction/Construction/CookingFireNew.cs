using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Atmosphere;
using Sons.Gameplay.Cooking;
using Sons.Gui.Input;
using Sons.Interfaces;
using Sons.Inventory;
using Sons.Items.Core;
using Sons.Lighting;
using TheForest.World;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Construction
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	[AddComponentMenu("Sons/Construction/CookingFireNew")]
	public class CookingFireNew : MonoBehaviour, IStructureCompletedReceiver, ISetInstanceIdReceiver, IWetable, ILightableFire, IMonoBehaviour
	{
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00008F54 File Offset: 0x00007154
		[Token(Token = "0x1700035B")]
		private bool PlayerOwnsLighterItem
		{
			[Token(Token = "0x6000E6B")]
			[Address(RVA = "0x2EEC510", Offset = "0x2EEAB10", VA = "0x182EEC510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00008F6C File Offset: 0x0000716C
		[Token(Token = "0x1700035C")]
		public bool IsLit
		{
			[Token(Token = "0x6000E6C")]
			[Address(RVA = "0x2EEC570", Offset = "0x2EEAB70", VA = "0x182EEC570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700035D")]
		public CookingFireNew.IFireData Data
		{
			[Token(Token = "0x6000E6D")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700035E")]
		public CookingSurface CookingSurface
		{
			[Token(Token = "0x6000E6E")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x2EEC590", Offset = "0x2EEAB90", VA = "0x182EEC590")]
		private void Awake()
		{
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x2EEC9F0", Offset = "0x2EEAFF0", VA = "0x182EEC9F0")]
		private void Update()
		{
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x2EECBE0", Offset = "0x2EEB1E0", VA = "0x182EECBE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x2EECD40", Offset = "0x2EEB340", VA = "0x182EECD40")]
		private void OnDisable()
		{
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x2EECE60", Offset = "0x2EEB460", VA = "0x182EECE60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x2EED090", Offset = "0x2EEB690", VA = "0x182EED090")]
		private void GrabEnter()
		{
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x2EED460", Offset = "0x2EEBA60", VA = "0x182EED460")]
		private void GrabStay()
		{
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x2EED470", Offset = "0x2EEBA70", VA = "0x182EED470")]
		private void GrabExit()
		{
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x2EED700", Offset = "0x2EEBD00", VA = "0x182EED700", Slot = "7")]
		public void ToggleUiIcons(bool onOff)
		{
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x2EEDA30", Offset = "0x2EEC030", VA = "0x182EEDA30")]
		private void OnInteractWithFire(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x2EEDE80", Offset = "0x2EEC480", VA = "0x182EEDE80")]
		private void OnItemUnequipped(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x2EEE1D0", Offset = "0x2EEC7D0", VA = "0x182EEE1D0", Slot = "6")]
		private void GotClean()
		{
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x2EEE1E0", Offset = "0x2EEC7E0", VA = "0x182EEE1E0")]
		public void Burn()
		{
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x2EEE280", Offset = "0x2EEC880", VA = "0x182EEE280", Slot = "8")]
		private void LightFire()
		{
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00008F84 File Offset: 0x00007184
		[Token(Token = "0x1700035F")]
		private bool ShouldLeanToLight
		{
			[Token(Token = "0x6000E7D")]
			[Address(RVA = "0x993970", Offset = "0x991F70", VA = "0x180993970", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x2EEE2A0", Offset = "0x2EEC8A0", VA = "0x182EEE2A0")]
		private void LightFireAction()
		{
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x2EEE390", Offset = "0x2EEC990", VA = "0x182EEE390")]
		public void SetAlight()
		{
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x2EEE610", Offset = "0x2EECC10", VA = "0x182EEE610")]
		private void On()
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x2EEEA30", Offset = "0x2EED030", VA = "0x182EEEA30")]
		private void Off()
		{
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x2EEF010", Offset = "0x2EED610", VA = "0x182EEF010")]
		private void SetLitStatus(bool isLit)
		{
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x2EEF0F0", Offset = "0x2EED6F0", VA = "0x182EEF0F0")]
		private void ForcedColliderRefresh()
		{
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x2EEF250", Offset = "0x2EED850", VA = "0x182EEF250")]
		private void EnableFireDamage()
		{
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00008F9C File Offset: 0x0000719C
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x2EEF340", Offset = "0x2EED940", VA = "0x182EEF340")]
		private bool TryDismantleFire()
		{
			return default(bool);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x2EEF510", Offset = "0x2EEDB10", VA = "0x182EEF510")]
		private void TryReleaseCookingPot()
		{
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00008FB4 File Offset: 0x000071B4
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x2EEF9D0", Offset = "0x2EEDFD0", VA = "0x182EEF9D0")]
		private bool TryDeSpawnFuel()
		{
			return default(bool);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x2EEFE70", Offset = "0x2EEE470", VA = "0x182EEFE70")]
		private void DestroyFire()
		{
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x2EF0520", Offset = "0x2EEEB20", VA = "0x182EF0520")]
		private void UpdateFuelDrain()
		{
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x2EF0690", Offset = "0x2EEEC90", VA = "0x182EF0690")]
		public void SetPutOut()
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x2EF06A0", Offset = "0x2EEECA0", VA = "0x182EF06A0")]
		private void CheckAutoPutOut()
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x2EF0780", Offset = "0x2EEED80", VA = "0x182EF0780")]
		public void OnFireStoked()
		{
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x2EF0A90", Offset = "0x2EEF090", VA = "0x182EF0A90")]
		private void FuelChanged()
		{
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x2EF0C00", Offset = "0x2EEF200", VA = "0x182EF0C00")]
		public void MpSetProxy(FireMpProxy fireMpProxy)
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x2EF0CE0", Offset = "0x2EEF2E0", VA = "0x182EF0CE0")]
		public void MpSetFuel(float fuel)
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x2EF0DD0", Offset = "0x2EEF3D0", VA = "0x182EF0DD0", Slot = "5")]
		private void OnSetInstanceId()
		{
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x2EF0F60", Offset = "0x2EEF560", VA = "0x182EF0F60", Slot = "4")]
		private void WasJustCompleted(ConstructionManager manager)
		{
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x2EF10F0", Offset = "0x2EEF6F0", VA = "0x182EF10F0")]
		public void SetReinforcementRatio(float reinforcementRatio)
		{
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x2EF1130", Offset = "0x2EEF730", VA = "0x182EF1130")]
		public void RegisterFuelSource(FireFuelSource fireFuelSource)
		{
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x2EF13E0", Offset = "0x2EEF9E0", VA = "0x182EF13E0")]
		public void UnRegisterFuelSource(FireFuelSource fireFuelSource)
		{
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x2EF1450", Offset = "0x2EEFA50", VA = "0x182EF1450")]
		public CookingFireNew()
		{
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "10")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "11")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00008FCC File Offset: 0x000071CC
		[Token(Token = "0x6000E98")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _startsLit;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _infinitePutOut;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _leanToLight;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _lighterItem;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CookingFireNew.FuelController _fuel;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CookingFireNew.FlameVisualController _flameVisual;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<FireFuelSource> _fuelSources;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CookingFireNew.FireSaveData _saveData;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CookingSurface _cookingSurface;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LinkUiElement _fireLinkUIElement;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LinkUiElement _cookLinkUIElement;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LinkUiElement _takePotLinkUIElement;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _fireDamage;

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TemperatureModifierVolume _temperatureModifierVolume;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[EventRef]
		private string _addFuelEvent;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x80")]
		private bool _proximity;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x81")]
		private bool _hasPreloaded;

		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x82")]
		private bool _isLightingFire;

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x88")]
		private FireMpProxy _mpProxy;

		// Token: 0x020001E7 RID: 487
		[Token(Token = "0x20001E7")]
		public interface IFireData
		{
			// Token: 0x17000360 RID: 864
			// (get) Token: 0x06000E99 RID: 3737
			// (set) Token: 0x06000E9A RID: 3738
			[Token(Token = "0x17000360")]
			bool IsLit { [Token(Token = "0x6000E99")] get; [Token(Token = "0x6000E9A")] set; }

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x06000E9B RID: 3739
			// (set) Token: 0x06000E9C RID: 3740
			[Token(Token = "0x17000361")]
			int PutOutChance { [Token(Token = "0x6000E9B")] get; [Token(Token = "0x6000E9C")] set; }

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x06000E9D RID: 3741
			// (set) Token: 0x06000E9E RID: 3742
			[Token(Token = "0x17000362")]
			float Fuel { [Token(Token = "0x6000E9D")] get; [Token(Token = "0x6000E9E")] set; }

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06000E9F RID: 3743
			// (set) Token: 0x06000EA0 RID: 3744
			[Token(Token = "0x17000363")]
			float FuelDrainRate { [Token(Token = "0x6000E9F")] get; [Token(Token = "0x6000EA0")] set; }
		}

		// Token: 0x020001E8 RID: 488
		[Token(Token = "0x20001E8")]
		[Serializable]
		public class FireSaveData : CookingFireNew.IFireData
		{
			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00008FE4 File Offset: 0x000071E4
			// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000364")]
			public bool IsLit
			{
				[Token(Token = "0x6000EA1")]
				[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000EA2")]
				[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00008FFC File Offset: 0x000071FC
			// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000365")]
			public int PutOutChance
			{
				[Token(Token = "0x6000EA3")]
				[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000EA4")]
				[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510", Slot = "7")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00009014 File Offset: 0x00007214
			// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000366")]
			public float Fuel
			{
				[Token(Token = "0x6000EA5")]
				[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000EA6")]
				[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0000902C File Offset: 0x0000722C
			// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000367")]
			public float FuelDrainRate
			{
				[Token(Token = "0x6000EA7")]
				[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930", Slot = "10")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000EA8")]
				[Address(RVA = "0x26F9F30", Offset = "0x26F8530", VA = "0x1826F9F30", Slot = "11")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000EA9 RID: 3753 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EA9")]
			[Address(RVA = "0x2EF1530", Offset = "0x2EEFB30", VA = "0x182EF1530")]
			public void Init(CookingFireNew fire)
			{
			}

			// Token: 0x06000EAA RID: 3754 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EAA")]
			[Address(RVA = "0x2EF15D0", Offset = "0x2EEFBD0", VA = "0x182EF15D0")]
			public void OnDestroy()
			{
			}

			// Token: 0x06000EAB RID: 3755 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EAB")]
			[Address(RVA = "0x2EF1750", Offset = "0x2EEFD50", VA = "0x182EF1750")]
			public void OnLoaded()
			{
			}

			// Token: 0x06000EAC RID: 3756 RVA: 0x00009044 File Offset: 0x00007244
			[Token(Token = "0x6000EAC")]
			[Address(RVA = "0x2EF1780", Offset = "0x2EEFD80", VA = "0x182EF1780")]
			public int GetStructureTypeID()
			{
				return 0;
			}

			// Token: 0x06000EAD RID: 3757 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EAD")]
			[Address(RVA = "0x2EF1850", Offset = "0x2EEFE50", VA = "0x182EF1850")]
			public FireSaveData()
			{
			}

			// Token: 0x040007FB RID: 2043
			[Token(Token = "0x40007FB")]
			[FieldOffset(Offset = "0x20")]
			private CookingFireNew _fire;
		}

		// Token: 0x020001E9 RID: 489
		[Token(Token = "0x20001E9")]
		[Serializable]
		public class FlameVisualController
		{
			// Token: 0x06000EAE RID: 3758 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EAE")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			internal void Init(CookingFireNew fire)
			{
			}

			// Token: 0x06000EAF RID: 3759 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x2EF1860", Offset = "0x2EEFE60", VA = "0x182EF1860")]
			internal void Toggle(bool onOff)
			{
			}

			// Token: 0x06000EB0 RID: 3760 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EB0")]
			[Address(RVA = "0x2EF1B00", Offset = "0x2EF0100", VA = "0x182EF1B00")]
			internal void Update()
			{
			}

			// Token: 0x06000EB1 RID: 3761 RVA: 0x0000905C File Offset: 0x0000725C
			[Token(Token = "0x6000EB1")]
			[Address(RVA = "0x2EF1FD0", Offset = "0x2EF05D0", VA = "0x182EF1FD0")]
			private static float CalcIntensityMultFromScale(float flameScale)
			{
				return 0f;
			}

			// Token: 0x06000EB2 RID: 3762 RVA: 0x00009074 File Offset: 0x00007274
			[Token(Token = "0x6000EB2")]
			[Address(RVA = "0x2EF2030", Offset = "0x2EF0630", VA = "0x182EF2030")]
			private static float CalcParticleScale(float flameScale)
			{
				return 0f;
			}

			// Token: 0x06000EB3 RID: 3763 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EB3")]
			[Address(RVA = "0x2EF2040", Offset = "0x2EF0640", VA = "0x182EF2040")]
			private void SetIntensityMult(float intensityMult, bool force)
			{
			}

			// Token: 0x06000EB4 RID: 3764 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EB4")]
			[Address(RVA = "0x2EF2240", Offset = "0x2EF0840", VA = "0x182EF2240")]
			internal void BumpScale()
			{
			}

			// Token: 0x06000EB5 RID: 3765 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EB5")]
			[Address(RVA = "0x2EF2390", Offset = "0x2EF0990", VA = "0x182EF2390")]
			internal void SetFueledUp()
			{
			}

			// Token: 0x06000EB6 RID: 3766 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EB6")]
			[Address(RVA = "0x2EF23F0", Offset = "0x2EF09F0", VA = "0x182EF23F0")]
			public FlameVisualController()
			{
			}

			// Token: 0x040007FC RID: 2044
			[Token(Token = "0x40007FC")]
			[FieldOffset(Offset = "0x10")]
			[Header("Settings")]
			[SerializeField]
			private float FuelMaxThreshold;

			// Token: 0x040007FD RID: 2045
			[Token(Token = "0x40007FD")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float FueledUpExtraScale;

			// Token: 0x040007FE RID: 2046
			[Token(Token = "0x40007FE")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float FueledUpExtraIntensityMult;

			// Token: 0x040007FF RID: 2047
			[Token(Token = "0x40007FF")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Header("References")]
			private FireSphere FireSphere;

			// Token: 0x04000800 RID: 2048
			[Token(Token = "0x4000800")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private GameObject FlamesRoot;

			// Token: 0x04000801 RID: 2049
			[Token(Token = "0x4000801")]
			[FieldOffset(Offset = "0x30")]
			private CookingFireNew _fire;

			// Token: 0x04000802 RID: 2050
			[Token(Token = "0x4000802")]
			[FieldOffset(Offset = "0x38")]
			private float _fueledUpUntilTime;

			// Token: 0x04000803 RID: 2051
			[Token(Token = "0x4000803")]
			[FieldOffset(Offset = "0x40")]
			private LightFlicker _lightFlicker;

			// Token: 0x04000804 RID: 2052
			[Token(Token = "0x4000804")]
			[FieldOffset(Offset = "0x48")]
			private LightFadeIn _lightFadeIn;

			// Token: 0x04000805 RID: 2053
			[Token(Token = "0x4000805")]
			[FieldOffset(Offset = "0x50")]
			private ParticleScaler _flamesScale;

			// Token: 0x04000806 RID: 2054
			[Token(Token = "0x4000806")]
			private const float FueledUpDuration = 2f;
		}

		// Token: 0x020001EA RID: 490
		[Token(Token = "0x20001EA")]
		[Serializable]
		public class FuelController
		{
			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0000908C File Offset: 0x0000728C
			[Token(Token = "0x17000368")]
			internal float MaxAmount
			{
				[Token(Token = "0x6000EB7")]
				[Address(RVA = "0x2EF2410", Offset = "0x2EF0A10", VA = "0x182EF2410")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x000090A4 File Offset: 0x000072A4
			[Token(Token = "0x17000369")]
			internal float DrainRate
			{
				[Token(Token = "0x6000EB8")]
				[Address(RVA = "0x2EF2420", Offset = "0x2EF0A20", VA = "0x182EF2420")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x000090BC File Offset: 0x000072BC
			// (set) Token: 0x06000EBA RID: 3770 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700036A")]
			internal float Amount
			{
				[Token(Token = "0x6000EB9")]
				[Address(RVA = "0x2EF2470", Offset = "0x2EF0A70", VA = "0x182EF2470")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000EBA")]
				[Address(RVA = "0x2EF24A0", Offset = "0x2EF0AA0", VA = "0x182EF24A0")]
				set
				{
				}
			}

			// Token: 0x06000EBB RID: 3771 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EBB")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			public void Init(CookingFireNew fire)
			{
			}

			// Token: 0x06000EBC RID: 3772 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EBC")]
			[Address(RVA = "0x2EF24E0", Offset = "0x2EF0AE0", VA = "0x182EF24E0")]
			internal void UpdateDrain()
			{
			}

			// Token: 0x06000EBD RID: 3773 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EBD")]
			[Address(RVA = "0x2EF26B0", Offset = "0x2EF0CB0", VA = "0x182EF26B0")]
			public void Add(float amount)
			{
			}

			// Token: 0x06000EBE RID: 3774 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EBE")]
			[Address(RVA = "0x2EF2710", Offset = "0x2EF0D10", VA = "0x182EF2710")]
			public void OnFuelSourcesChanged()
			{
			}

			// Token: 0x06000EBF RID: 3775 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EBF")]
			[Address(RVA = "0x2EF27E0", Offset = "0x2EF0DE0", VA = "0x182EF27E0")]
			public FuelController()
			{
			}

			// Token: 0x04000807 RID: 2055
			[Token(Token = "0x4000807")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float _fuelMax;

			// Token: 0x04000808 RID: 2056
			[Token(Token = "0x4000808")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float _drainRate;

			// Token: 0x04000809 RID: 2057
			[Token(Token = "0x4000809")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float _drainRateRaining;

			// Token: 0x0400080A RID: 2058
			[Token(Token = "0x400080A")]
			[FieldOffset(Offset = "0x1C")]
			private float _nextFuelSourceCollapse;

			// Token: 0x0400080B RID: 2059
			[Token(Token = "0x400080B")]
			[FieldOffset(Offset = "0x20")]
			private CookingFireNew _fire;
		}
	}
}
