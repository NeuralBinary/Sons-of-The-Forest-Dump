using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[AddComponentMenu("Sons/Vail/VailActorVariations")]
	public class VailActorVariations : MonoBehaviour
	{
		// Token: 0x060003F5 RID: 1013 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
		public int GetCurrentIndex()
		{
			return 0;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2B0D830", Offset = "0x2B0BE30", VA = "0x182B0D830")]
		public string GetCurrentName()
		{
			return null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2B0D8F0", Offset = "0x2B0BEF0", VA = "0x182B0D8F0")]
		public int GetCurrentItemId()
		{
			return 0;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2B0D9B0", Offset = "0x2B0BFB0", VA = "0x182B0D9B0")]
		public int GetCurrentVariationId()
		{
			return 0;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2B0DA40", Offset = "0x2B0C040", VA = "0x182B0DA40")]
		public bool TrySetOutfit(int itemId)
		{
			return default(bool);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2B0DB30", Offset = "0x2B0C130", VA = "0x182B0DB30")]
		public void SetOutfit(string outfitName)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2B0DC50", Offset = "0x2B0C250", VA = "0x182B0DC50")]
		public void SetIndex(int index)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2B0DCE0", Offset = "0x2B0C2E0", VA = "0x182B0DCE0")]
		public void SetVariationId(int variationId)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2B0DDC0", Offset = "0x2B0C3C0", VA = "0x182B0DDC0")]
		private void SetOutfit(VailActorVariations.Variation newVariation)
		{
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2B0DF70", Offset = "0x2B0C570", VA = "0x182B0DF70")]
		private void Clear()
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2B0E0B0", Offset = "0x2B0C6B0", VA = "0x182B0E0B0")]
		public VailActorVariations()
		{
		}

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<VailActorVariations.Variation> _outfits;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _variationReceivers;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x30")]
		private int _currentIdx;

		// Token: 0x0200004B RID: 75
		[Token(Token = "0x200004B")]
		[Serializable]
		internal class Variation
		{
			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x00003BB8 File Offset: 0x00001DB8
			[Token(Token = "0x1700004A")]
			public int ItemId
			{
				[Token(Token = "0x6000400")]
				[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x2B0E1A0", Offset = "0x2B0C7A0", VA = "0x182B0E1A0")]
			private VailActorVariations GetActorVariationsInstance()
			{
				return null;
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x2B0E290", Offset = "0x2B0C890", VA = "0x182B0E290")]
			private void Preview()
			{
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x2B0E480", Offset = "0x2B0CA80", VA = "0x182B0E480")]
			public void SetEnabled(bool show)
			{
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Variation()
			{
			}

			// Token: 0x04000337 RID: 823
			[Token(Token = "0x4000337")]
			[FieldOffset(Offset = "0x10")]
			public string _name;

			// Token: 0x04000338 RID: 824
			[Token(Token = "0x4000338")]
			[FieldOffset(Offset = "0x18")]
			public int _variationId;

			// Token: 0x04000339 RID: 825
			[Token(Token = "0x4000339")]
			[FieldOffset(Offset = "0x1C")]
			[ItemIdPicker(true)]
			[SerializeField]
			private int _itemId;

			// Token: 0x0400033A RID: 826
			[Token(Token = "0x400033A")]
			[FieldOffset(Offset = "0x20")]
			public GameObject[] _renderObjects;

			// Token: 0x0400033B RID: 827
			[Token(Token = "0x400033B")]
			[FieldOffset(Offset = "0x28")]
			public MaterialVariationSetter[] _materials;
		}
	}
}
