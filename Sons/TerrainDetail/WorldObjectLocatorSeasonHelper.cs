using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000520 RID: 1312
	[Token(Token = "0x2000520")]
	[AddComponentMenu("Sons/TerrainDetail/WorldObjectLocatorSeasonHelper")]
	public class WorldObjectLocatorSeasonHelper : MonoBehaviour
	{
		// Token: 0x060022ED RID: 8941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022ED")]
		[Address(RVA = "0x3347930", Offset = "0x3345F30", VA = "0x183347930")]
		private void LateUpdate()
		{
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x3347930", Offset = "0x3345F30", VA = "0x183347930")]
		private void CheckSwitchInstant()
		{
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x3347A00", Offset = "0x3346000", VA = "0x183347A00")]
		private void Awake()
		{
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x3347BE0", Offset = "0x33461E0", VA = "0x183347BE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x3347E20", Offset = "0x3346420", VA = "0x183347E20")]
		private void OnSourceChanged(WorldObjectLocator worldObjectLocator)
		{
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x3347F30", Offset = "0x3346530", VA = "0x183347F30")]
		private void ApplyToSeasonComponents()
		{
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F3")]
		[Address(RVA = "0xAB5B60", Offset = "0xAB4160", VA = "0x180AB5B60")]
		public WorldObjectLocatorSeasonHelper()
		{
		}

		// Token: 0x04001FC7 RID: 8135
		[Token(Token = "0x4001FC7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldObjectLocatorHolder _locatorHolder;

		// Token: 0x04001FC8 RID: 8136
		[Token(Token = "0x4001FC8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _autoCollectSeasonComponents;

		// Token: 0x04001FC9 RID: 8137
		[Token(Token = "0x4001FC9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<SeasonalAssetSwapper> _seasonalAssetSwappers;

		// Token: 0x04001FCA RID: 8138
		[Token(Token = "0x4001FCA")]
		[FieldOffset(Offset = "0x38")]
		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private SeasonalAssetSwapper _seasonalAssetSwapper;

		// Token: 0x04001FCB RID: 8139
		[Token(Token = "0x4001FCB")]
		[FieldOffset(Offset = "0x40")]
		private SeasonsManager.Season _activeSeason;

		// Token: 0x04001FCC RID: 8140
		[Token(Token = "0x4001FCC")]
		[FieldOffset(Offset = "0x48")]
		private WorldObjectLocator _cachedWorldObjectLocator;
	}
}
