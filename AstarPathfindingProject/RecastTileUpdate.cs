using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	[AddComponentMenu("Pathfinding/Navmesh/RecastTileUpdate")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_recast_tile_update.php")]
	public class RecastTileUpdate : MonoBehaviour
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060004C9 RID: 1225 RVA: 0x00002082 File Offset: 0x00000282
		// (remove) Token: 0x060004CA RID: 1226 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x14000005")]
		public static event Action<Bounds> OnNeedUpdates
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x678BD0", Offset = "0x6771D0", VA = "0x180678BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x678D50", Offset = "0x677350", VA = "0x180678D50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x678ED0", Offset = "0x6774D0", VA = "0x180678ED0")]
		private void Start()
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x678ED0", Offset = "0x6774D0", VA = "0x180678ED0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x678EE0", Offset = "0x6774E0", VA = "0x180678EE0")]
		public void ScheduleUpdate()
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RecastTileUpdate()
		{
		}
	}
}
