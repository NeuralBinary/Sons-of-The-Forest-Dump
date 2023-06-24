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
	// Token: 0x0200075A RID: 1882
	[Token(Token = "0x200075A")]
	[AddComponentMenu("Sons/Gameplay/DryingRackHookPoint")]
	public class DryingRackHookPoint : ItemHookPoint, ITemperatureModifierReceiver
	{
		// Token: 0x060032EC RID: 13036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032EC")]
		[Address(RVA = "0x34AD670", Offset = "0x34ABC70", VA = "0x1834AD670")]
		public ItemInstance GetItemInstance()
		{
			return null;
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032ED")]
		[Address(RVA = "0x34AD750", Offset = "0x34ABD50", VA = "0x1834AD750", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032EE")]
		[Address(RVA = "0x34ADBE0", Offset = "0x34AC1E0", VA = "0x1834ADBE0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032EF")]
		[Address(RVA = "0x34ADE80", Offset = "0x34AC480", VA = "0x1834ADE80")]
		private void SetPerishableStateMp()
		{
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F0")]
		[Address(RVA = "0x34AE080", Offset = "0x34AC680", VA = "0x1834AE080", Slot = "10")]
		protected override void Shutdown()
		{
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F1")]
		[Address(RVA = "0x34AE250", Offset = "0x34AC850", VA = "0x1834AE250", Slot = "8")]
		public override void AssignPickup(PickUp pickup)
		{
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F2")]
		[Address(RVA = "0x34AE620", Offset = "0x34ACC20", VA = "0x1834AE620", Slot = "9")]
		protected override void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F3")]
		[Address(RVA = "0x34AE640", Offset = "0x34ACC40", VA = "0x1834AE640", Slot = "11")]
		public void OnEnteredTemperatureVolume(float temperatureCelsius)
		{
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F4")]
		[Address(RVA = "0x34AE640", Offset = "0x34ACC40", VA = "0x1834AE640", Slot = "12")]
		public void OnStayedTemperatureVolume(float temperatureCelsius)
		{
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F5")]
		[Address(RVA = "0x34AE650", Offset = "0x34ACC50", VA = "0x1834AE650", Slot = "13")]
		public void OnExitedTemperatureVolume(float temperatureCelsius)
		{
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F6")]
		[Address(RVA = "0x31AD260", Offset = "0x31AB860", VA = "0x1831AD260")]
		public void SetUsedInMp(bool used)
		{
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F7")]
		[Address(RVA = "0x34AE660", Offset = "0x34ACC60", VA = "0x1834AE660")]
		public DryingRackHookPoint()
		{
		}

		// Token: 0x04002BF7 RID: 11255
		[Token(Token = "0x4002BF7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _bloodDripsPrefab;

		// Token: 0x04002BF8 RID: 11256
		[Token(Token = "0x4002BF8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _requiredCureTimeGameDays;

		// Token: 0x04002BF9 RID: 11257
		[Token(Token = "0x4002BF9")]
		[FieldOffset(Offset = "0x5C")]
		private float _remainingCureTimeSeconds;

		// Token: 0x04002BFA RID: 11258
		[Token(Token = "0x4002BFA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[FormerlySerializedAs("_dryingRackController")]
		private DryingRackScrewStructure _dryingRackScrewStructure;

		// Token: 0x04002BFB RID: 11259
		[Token(Token = "0x4002BFB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _minTemperatureToGainDryBoost;

		// Token: 0x04002BFC RID: 11260
		[Token(Token = "0x4002BFC")]
		[FieldOffset(Offset = "0x6C")]
		[Min(0f)]
		[SerializeField]
		private float _dryBoostMultiplier;

		// Token: 0x04002BFD RID: 11261
		[Token(Token = "0x4002BFD")]
		[FieldOffset(Offset = "0x70")]
		private PerishableItemInstanceModule _perishableItemInstanceModule;

		// Token: 0x04002BFE RID: 11262
		[Token(Token = "0x4002BFE")]
		[FieldOffset(Offset = "0x78")]
		private GameObject _bloodDrips;

		// Token: 0x04002BFF RID: 11263
		[Token(Token = "0x4002BFF")]
		[FieldOffset(Offset = "0x80")]
		private bool _isInsideTemperatureVolume;

		// Token: 0x04002C00 RID: 11264
		[Token(Token = "0x4002C00")]
		[FieldOffset(Offset = "0x84")]
		private float _temperatureVolumeTemperature;
	}
}
