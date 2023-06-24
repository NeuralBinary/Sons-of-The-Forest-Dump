using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Util;

namespace Pathfinding
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	[Serializable]
	public class NavmeshUpdates
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x6CFAE0", Offset = "0x6CE0E0", VA = "0x1806CFAE0")]
		internal void OnEnable()
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x6CFBB0", Offset = "0x6CE1B0", VA = "0x1806CFBB0")]
		internal void OnDisable()
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x6CFC80", Offset = "0x6CE280", VA = "0x1806CFC80")]
		public void DiscardPending()
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x6CFEE0", Offset = "0x6CE4E0", VA = "0x1806CFEE0")]
		private void HandleOnEnableCallback(NavmeshClipper obj)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x6D0010", Offset = "0x6CE610", VA = "0x1806D0010")]
		private void HandleOnDisableCallback(NavmeshClipper obj)
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x6D0130", Offset = "0x6CE730", VA = "0x1806D0130")]
		internal void Update()
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x6D0340", Offset = "0x6CE940", VA = "0x1806D0340")]
		public void ForceUpdate()
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x6D0870", Offset = "0x6CEE70", VA = "0x1806D0870")]
		public NavmeshUpdates()
		{
		}

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x10")]
		public float updateInterval;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x14")]
		private float lastUpdateTime;

		// Token: 0x020000E4 RID: 228
		[Token(Token = "0x20000E4")]
		internal class NavmeshUpdateSettings
		{
			// Token: 0x060007E9 RID: 2025 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x6D0880", Offset = "0x6CEE80", VA = "0x1806D0880")]
			public NavmeshUpdateSettings(NavmeshBase graph)
			{
			}

			// Token: 0x060007EA RID: 2026 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x6D09A0", Offset = "0x6CEFA0", VA = "0x1806D09A0")]
			public void Refresh(bool forceCreate = false)
			{
			}

			// Token: 0x060007EB RID: 2027 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x6D10E0", Offset = "0x6CF6E0", VA = "0x1806D10E0")]
			public void OnRecalculatedTiles(NavmeshTile[] tiles)
			{
			}

			// Token: 0x060007EC RID: 2028 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x6D11B0", Offset = "0x6CF7B0", VA = "0x1806D11B0")]
			public void AddClipper(NavmeshClipper obj)
			{
			}

			// Token: 0x060007ED RID: 2029 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x6D12C0", Offset = "0x6CF8C0", VA = "0x1806D12C0")]
			public void RemoveClipper(NavmeshClipper obj)
			{
			}

			// Token: 0x04000574 RID: 1396
			[Token(Token = "0x4000574")]
			[FieldOffset(Offset = "0x10")]
			public TileHandler handler;

			// Token: 0x04000575 RID: 1397
			[Token(Token = "0x4000575")]
			[FieldOffset(Offset = "0x18")]
			public readonly List<IntRect> forcedReloadRects;

			// Token: 0x04000576 RID: 1398
			[Token(Token = "0x4000576")]
			[FieldOffset(Offset = "0x20")]
			private readonly NavmeshBase graph;
		}
	}
}
