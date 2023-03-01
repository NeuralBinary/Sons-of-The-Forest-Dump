using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Environment;
using Sons.Interfaces;
using Sons.Inventory;
using Sons.Items.Core;
using TheForest.World;
using UnityEngine;

namespace Sons.Items
{
	// Token: 0x0200082C RID: 2092
	[Token(Token = "0x200082C")]
	[AddComponentMenu("Sons/Items/Core/Blood On Item")]
	public class BloodOnItem : MonoBehaviour, IEnvironmentWetnessReceiver, IWetable, IBloodReceiver
	{
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060037A7 RID: 14247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000703")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x60037A6")]
			[Address(RVA = "0x656130", Offset = "0x655130", VA = "0x180656130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037A7")]
			[Address(RVA = "0x656140", Offset = "0x655140", VA = "0x180656140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x2EAB180", Offset = "0x2EAA180", VA = "0x182EAB180")]
		private void OnRenderableLoaded(Transform renderableTransform)
		{
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x2EAAB60", Offset = "0x2EA9B60", VA = "0x182EAAB60")]
		private void FindMaterials(GameObject visualObject)
		{
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AA")]
		[Address(RVA = "0x2EAB610", Offset = "0x2EAA610", VA = "0x182EAB610")]
		private WeatherSystem WeatherSystem()
		{
			return null;
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037AB")]
		[Address(RVA = "0x2EAB040", Offset = "0x2EAA040", VA = "0x182EAB040")]
		private void OnEnable()
		{
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037AC")]
		[Address(RVA = "0x2EAAFB0", Offset = "0x2EA9FB0", VA = "0x182EAAFB0")]
		private void OnDisable()
		{
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037AD")]
		[Address(RVA = "0x2EAACD0", Offset = "0x2EA9CD0", VA = "0x182EAACD0")]
		public void ForceBloodAmounts(ItemInstance itemInstance, Color channelWeights)
		{
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037AE")]
		[Address(RVA = "0x2EAB2F0", Offset = "0x2EAA2F0", VA = "0x182EAB2F0")]
		private void Update()
		{
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037AF")]
		[Address(RVA = "0x2EAAF50", Offset = "0x2EA9F50", VA = "0x182EAAF50", Slot = "6")]
		public void GotBloody(Vector3 bloodSourcePosition)
		{
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B0")]
		[Address(RVA = "0x2EAB2B0", Offset = "0x2EAA2B0", VA = "0x182EAB2B0", Slot = "4")]
		public void UpdateWetness(float wetnessCurrent)
		{
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B1")]
		[Address(RVA = "0x2EAAFA0", Offset = "0x2EA9FA0", VA = "0x182EAAFA0", Slot = "5")]
		public void GotClean()
		{
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B2")]
		[Address(RVA = "0x2EAB790", Offset = "0x2EAA790", VA = "0x182EAB790")]
		public BloodOnItem()
		{
		}

		// Token: 0x04002F9F RID: 12191
		[Token(Token = "0x4002F9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemRenderable _itemRenderable;

		// Token: 0x04002FA0 RID: 12192
		[Token(Token = "0x4002FA0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _bloodifyRate;

		// Token: 0x04002FA1 RID: 12193
		[Token(Token = "0x4002FA1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Min(0f)]
		private float _cleanRate;

		// Token: 0x04002FA2 RID: 12194
		[Token(Token = "0x4002FA2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _currentBlood;

		// Token: 0x04002FA3 RID: 12195
		[Token(Token = "0x4002FA3")]
		[FieldOffset(Offset = "0x34")]
		private bool _isReady;

		// Token: 0x04002FA4 RID: 12196
		[Token(Token = "0x4002FA4")]
		[FieldOffset(Offset = "0x38")]
		private WeatherSystem _weatherSystem;

		// Token: 0x04002FA5 RID: 12197
		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0x40")]
		private List<Material> _materials;

		// Token: 0x04002FA6 RID: 12198
		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0x48")]
		private float _lastUpdateBloodAmount;

		// Token: 0x04002FA7 RID: 12199
		[Token(Token = "0x4002FA7")]
		[FieldOffset(Offset = "0x4C")]
		private float _currentCleanRate;

		// Token: 0x04002FA8 RID: 12200
		[Token(Token = "0x4002FA8")]
		[FieldOffset(Offset = "0x50")]
		private bool _forceClean;

		// Token: 0x04002FA9 RID: 12201
		[Token(Token = "0x4002FA9")]
		[FieldOffset(Offset = "0x54")]
		private Color _channelWeights;

		// Token: 0x04002FAA RID: 12202
		[Token(Token = "0x4002FAA")]
		[FieldOffset(Offset = "0x68")]
		private BloodRevealItemInstanceModule _bloodRevealItemInstanceModule;

		// Token: 0x04002FAC RID: 12204
		[Token(Token = "0x4002FAC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _rChannelPropertyId;

		// Token: 0x04002FAD RID: 12205
		[Token(Token = "0x4002FAD")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int _gChannelPropertyId;

		// Token: 0x04002FAE RID: 12206
		[Token(Token = "0x4002FAE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _bChannelPropertyId;

		// Token: 0x04002FAF RID: 12207
		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int _aChannelPropertyId;
	}
}
