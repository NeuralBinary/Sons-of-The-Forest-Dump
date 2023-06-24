using System;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	[Obsolete("Use AstarPath.navmeshUpdates instead. You can safely remove this component.")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_tile_handler_helper.php")]
	public class TileHandlerHelper : VersionedMonoBehaviour
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00005B04 File Offset: 0x00003D04
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700013B")]
		public float updateInterval
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x6D27A0", Offset = "0x6D0DA0", VA = "0x1806D27A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x6D2810", Offset = "0x6D0E10", VA = "0x1806D2810")]
			set
			{
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x6D2890", Offset = "0x6D0E90", VA = "0x1806D2890")]
		[Obsolete("All navmesh/recast graphs now use navmesh cutting")]
		public void UseSpecifiedHandler(TileHandler newHandler)
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x6D28E0", Offset = "0x6D0EE0", VA = "0x1806D28E0")]
		public void DiscardPending()
		{
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x6D2950", Offset = "0x6D0F50", VA = "0x1806D2950")]
		public void ForceUpdate()
		{
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TileHandlerHelper()
		{
		}
	}
}
