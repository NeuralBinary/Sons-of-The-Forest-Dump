using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using Sons.Crafting.Structures;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x0200063D RID: 1597
	[Token(Token = "0x200063D")]
	[AddComponentMenu("Sons/Gameplay/DryingRackHookPoint")]
	public class DryingRackHookPoint : ItemHookPoint, ITemperatureModifierReceiver
	{
		// Token: 0x0600290D RID: 10509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x2DB6720", Offset = "0x2DB5720", VA = "0x182DB6720")]
		public ItemInstance GetItemInstance()
		{
			return null;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x2DB6B40", Offset = "0x2DB5B40", VA = "0x182DB6B40", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x2DB67B0", Offset = "0x2DB57B0", VA = "0x182DB67B0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002910")]
		[Address(RVA = "0x2DB6990", Offset = "0x2DB5990", VA = "0x182DB6990")]
		private void SetPerishableStateMp()
		{
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002911")]
		[Address(RVA = "0x2DB6A80", Offset = "0x2DB5A80", VA = "0x182DB6A80", Slot = "9")]
		protected override void Shutdown()
		{
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002912")]
		[Address(RVA = "0x2DB64F0", Offset = "0x2DB54F0", VA = "0x182DB64F0", Slot = "7")]
		public override void AssignPickup(PickUp pickup)
		{
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002913")]
		[Address(RVA = "0x2DB6970", Offset = "0x2DB5970", VA = "0x182DB6970", Slot = "8")]
		protected override void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002914")]
		[Address(RVA = "0x2DB6950", Offset = "0x2DB5950", VA = "0x182DB6950", Slot = "10")]
		public void OnEnteredTemperatureVolume(float temperatureCelsius)
		{
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x2DB6950", Offset = "0x2DB5950", VA = "0x182DB6950", Slot = "11")]
		public void OnStayedTemperatureVolume(float temperatureCelsius)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002916")]
		[Address(RVA = "0x2DB6960", Offset = "0x2DB5960", VA = "0x182DB6960", Slot = "12")]
		public void OnExitedTemperatureVolume(float temperatureCelsius)
		{
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002917")]
		[Address(RVA = "0x2A56F40", Offset = "0x2A55F40", VA = "0x182A56F40")]
		public void SetUsedInMp(bool used)
		{
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x2DB6DF0", Offset = "0x2DB5DF0", VA = "0x182DB6DF0")]
		public DryingRackHookPoint()
		{
		}

		// Token: 0x040024B3 RID: 9395
		[Token(Token = "0x40024B3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _bloodDripsPrefab;

		// Token: 0x040024B4 RID: 9396
		[Token(Token = "0x40024B4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _requiredCureTimeGameDays;

		// Token: 0x040024B5 RID: 9397
		[Token(Token = "0x40024B5")]
		[FieldOffset(Offset = "0x5C")]
		private float _remainingCureTimeSeconds;

		// Token: 0x040024B6 RID: 9398
		[Token(Token = "0x40024B6")]
		[FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("_dryingRackController")]
		[SerializeField]
		private DryingRackScrewStructure _dryingRackScrewStructure;

		// Token: 0x040024B7 RID: 9399
		[Token(Token = "0x40024B7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _minTemperatureToGainDryBoost;

		// Token: 0x040024B8 RID: 9400
		[Token(Token = "0x40024B8")]
		[FieldOffset(Offset = "0x6C")]
		[Min(0f)]
		[SerializeField]
		private float _dryBoostMultiplier;

		// Token: 0x040024B9 RID: 9401
		[Token(Token = "0x40024B9")]
		[FieldOffset(Offset = "0x70")]
		private PerishableItemInstanceModule _perishableItemInstanceModule;

		// Token: 0x040024BA RID: 9402
		[Token(Token = "0x40024BA")]
		[FieldOffset(Offset = "0x78")]
		private GameObject _bloodDrips;

		// Token: 0x040024BB RID: 9403
		[Token(Token = "0x40024BB")]
		[FieldOffset(Offset = "0x80")]
		private bool _isInsideTemperatureVolume;

		// Token: 0x040024BC RID: 9404
		[Token(Token = "0x40024BC")]
		[FieldOffset(Offset = "0x84")]
		private float _temperatureVolumeTemperature;
	}
}
