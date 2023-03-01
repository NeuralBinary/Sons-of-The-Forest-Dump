using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000518 RID: 1304
	[Token(Token = "0x2000518")]
	[AddComponentMenu("Sons/TerrainDetail/WorldObjectLocatorSeasonHelper")]
	public class WorldObjectLocatorSeasonHelper : MonoBehaviour
	{
		// Token: 0x06002200 RID: 8704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002200")]
		[Address(RVA = "0x2D7B520", Offset = "0x2D7A520", VA = "0x182D7B520")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002201")]
		[Address(RVA = "0x2D7B520", Offset = "0x2D7A520", VA = "0x182D7B520")]
		private void CheckSwitchInstant()
		{
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002202")]
		[Address(RVA = "0x2D7B3E0", Offset = "0x2D7A3E0", VA = "0x182D7B3E0")]
		private void Awake()
		{
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002203")]
		[Address(RVA = "0x2D7B5F0", Offset = "0x2D7A5F0", VA = "0x182D7B5F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002204")]
		[Address(RVA = "0x2D7B740", Offset = "0x2D7A740", VA = "0x182D7B740")]
		private void OnSourceChanged(WorldObjectLocator worldObjectLocator)
		{
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002205")]
		[Address(RVA = "0x2D7B280", Offset = "0x2D7A280", VA = "0x182D7B280")]
		private void ApplyToSeasonComponents()
		{
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002206")]
		[Address(RVA = "0x9445B0", Offset = "0x9435B0", VA = "0x1809445B0")]
		public WorldObjectLocatorSeasonHelper()
		{
		}

		// Token: 0x04001F13 RID: 7955
		[Token(Token = "0x4001F13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldObjectLocatorHolder _locatorHolder;

		// Token: 0x04001F14 RID: 7956
		[Token(Token = "0x4001F14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _autoCollectSeasonComponents;

		// Token: 0x04001F15 RID: 7957
		[Token(Token = "0x4001F15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<SeasonalAssetSwapper> _seasonalAssetSwappers;

		// Token: 0x04001F16 RID: 7958
		[Token(Token = "0x4001F16")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private SeasonalAssetSwapper _seasonalAssetSwapper;

		// Token: 0x04001F17 RID: 7959
		[Token(Token = "0x4001F17")]
		[FieldOffset(Offset = "0x40")]
		private SeasonsManager.Season _activeSeason;

		// Token: 0x04001F18 RID: 7960
		[Token(Token = "0x4001F18")]
		[FieldOffset(Offset = "0x48")]
		private WorldObjectLocator _cachedWorldObjectLocator;
	}
}
