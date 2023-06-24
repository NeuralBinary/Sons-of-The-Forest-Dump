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
	// Token: 0x0200073F RID: 1855
	[Token(Token = "0x200073F")]
	[AddComponentMenu("Sons/Items/Core/Blood On Item")]
	public class BloodOnItem : MonoBehaviour, IEnvironmentWetnessReceiver, IWetable, IBloodReceiver
	{
		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600318B RID: 12683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067B")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x600318A")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600318B")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318C")]
		[Address(RVA = "0x348C760", Offset = "0x348AD60", VA = "0x18348C760")]
		private void OnRenderableLoaded(Transform renderableTransform)
		{
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318D")]
		[Address(RVA = "0x348C980", Offset = "0x348AF80", VA = "0x18348C980")]
		private void FindMaterials(GameObject visualObject)
		{
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318E")]
		[Address(RVA = "0x348CB30", Offset = "0x348B130", VA = "0x18348CB30")]
		private WeatherSystem WeatherSystem()
		{
			return null;
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318F")]
		[Address(RVA = "0x348CC80", Offset = "0x348B280", VA = "0x18348CC80")]
		private void OnEnable()
		{
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003190")]
		[Address(RVA = "0x348CEB0", Offset = "0x348B4B0", VA = "0x18348CEB0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003191")]
		[Address(RVA = "0x348CF90", Offset = "0x348B590", VA = "0x18348CF90")]
		public void ForceBloodAmounts(ItemInstance itemInstance, Color channelWeights)
		{
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003192")]
		[Address(RVA = "0x348D2C0", Offset = "0x348B8C0", VA = "0x18348D2C0")]
		private void Update()
		{
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003193")]
		[Address(RVA = "0x348D750", Offset = "0x348BD50", VA = "0x18348D750", Slot = "6")]
		public void GotBloody(Vector3 bloodSourcePosition)
		{
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003194")]
		[Address(RVA = "0x348D7A0", Offset = "0x348BDA0", VA = "0x18348D7A0", Slot = "4")]
		public void UpdateWetness(float wetnessCurrent)
		{
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003195")]
		[Address(RVA = "0x348D7E0", Offset = "0x348BDE0", VA = "0x18348D7E0", Slot = "5")]
		public void GotClean()
		{
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003196")]
		[Address(RVA = "0x348D7F0", Offset = "0x348BDF0", VA = "0x18348D7F0")]
		public BloodOnItem()
		{
		}

		// Token: 0x04002ABB RID: 10939
		[Token(Token = "0x4002ABB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemRenderable _itemRenderable;

		// Token: 0x04002ABC RID: 10940
		[Token(Token = "0x4002ABC")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _bloodifyRate;

		// Token: 0x04002ABD RID: 10941
		[Token(Token = "0x4002ABD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Min(0f)]
		private float _cleanRate;

		// Token: 0x04002ABE RID: 10942
		[Token(Token = "0x4002ABE")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _currentBlood;

		// Token: 0x04002ABF RID: 10943
		[Token(Token = "0x4002ABF")]
		[FieldOffset(Offset = "0x34")]
		private bool _isReady;

		// Token: 0x04002AC0 RID: 10944
		[Token(Token = "0x4002AC0")]
		[FieldOffset(Offset = "0x38")]
		private WeatherSystem _weatherSystem;

		// Token: 0x04002AC1 RID: 10945
		[Token(Token = "0x4002AC1")]
		[FieldOffset(Offset = "0x40")]
		private List<Material> _materials;

		// Token: 0x04002AC2 RID: 10946
		[Token(Token = "0x4002AC2")]
		[FieldOffset(Offset = "0x48")]
		private float _lastUpdateBloodAmount;

		// Token: 0x04002AC3 RID: 10947
		[Token(Token = "0x4002AC3")]
		[FieldOffset(Offset = "0x4C")]
		private float _currentCleanRate;

		// Token: 0x04002AC4 RID: 10948
		[Token(Token = "0x4002AC4")]
		[FieldOffset(Offset = "0x50")]
		private bool _forceClean;

		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		[FieldOffset(Offset = "0x54")]
		private Color _channelWeights;

		// Token: 0x04002AC6 RID: 10950
		[Token(Token = "0x4002AC6")]
		[FieldOffset(Offset = "0x68")]
		private BloodRevealItemInstanceModule _bloodRevealItemInstanceModule;

		// Token: 0x04002AC8 RID: 10952
		[Token(Token = "0x4002AC8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _rChannelPropertyId;

		// Token: 0x04002AC9 RID: 10953
		[Token(Token = "0x4002AC9")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int _gChannelPropertyId;

		// Token: 0x04002ACA RID: 10954
		[Token(Token = "0x4002ACA")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _bChannelPropertyId;

		// Token: 0x04002ACB RID: 10955
		[Token(Token = "0x4002ACB")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int _aChannelPropertyId;
	}
}
