using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public interface IRaycastableGraph
	{
		// Token: 0x060001EA RID: 490
		[Token(Token = "0x60001EA")]
		bool Linecast(Vector3 start, Vector3 end);

		// Token: 0x060001EB RID: 491
		[Token(Token = "0x60001EB")]
		[Obsolete]
		bool Linecast(Vector3 start, Vector3 end, GraphNode hint);

		// Token: 0x060001EC RID: 492
		[Token(Token = "0x60001EC")]
		[Obsolete]
		bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit);

		// Token: 0x060001ED RID: 493
		[Token(Token = "0x60001ED")]
		[Obsolete]
		bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace);

		// Token: 0x060001EE RID: 494
		[Token(Token = "0x60001EE")]
		bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit, [Optional] List<GraphNode> trace, [Optional] Func<GraphNode, bool> filter);
	}
}
