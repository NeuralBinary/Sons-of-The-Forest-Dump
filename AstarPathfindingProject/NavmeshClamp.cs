using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_navmesh_clamp.php")]
	public class NavmeshClamp : MonoBehaviour
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x6781B0", Offset = "0x6767B0", VA = "0x1806781B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public NavmeshClamp()
		{
		}

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x20")]
		private GraphNode prevNode;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 prevPos;
	}
}
